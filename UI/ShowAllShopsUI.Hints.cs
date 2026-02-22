using MerchantsPlus.Shops;
using Terraria.GameContent;
using Terraria.GameContent.UI.Elements;

namespace MerchantsPlus.UI;

public partial class ShowAllShopsUI
{
    private string GetSelectedShopHint()
    {
        if (!_shopWasExplicitlyClicked)
        {
            return "Select a shop to open it and view unlock hints.";
        }

        if (_selectedMerchantId <= NPCID.None || string.IsNullOrWhiteSpace(_selectedShopName))
        {
            return "-";
        }

        if (Config.Instance?.UnlockAllItems == true)
        {
            return "Show All Items is enabled.";
        }

        ShopUnlockInfo info = GetShopUnlockInfo(_selectedMerchantId, _selectedShopName);
        if (!info.HasCatalogData)
        {
            return GetDynamicShopHint(_selectedMerchantId, _selectedShopName);
        }

        if (info.LockedCount <= 0)
        {
            return "All items currently unlocked for this shop.";
        }

        string itemName = GetItemDisplayName(info.NextItemId);
        string unlockHint = Progression.GetLevelFullUnlockHint(info.NextRequiredProgression);
        if (string.IsNullOrWhiteSpace(itemName))
        {
            return unlockHint;
        }

        return $"Next: {itemName}. {unlockHint}";
    }

    private string GetDynamicShopHint(int merchantId, string shopName)
    {
        if (Config.Instance?.UnlockAllItems == true)
        {
            return "Show All Items is enabled.";
        }

        List<int> currentItems = SnapshotShopItemsAtState(merchantId, shopName, Progression.LevelFull(), forceUnlockAllItems: false);
        if (currentItems.Count == 0)
        {
            return "No items currently visible in this shop.";
        }

        HashSet<int> currentSet = [.. currentItems];
        int currentLevel = Progression.LevelFull();

        for (int nextLevel = currentLevel + 1; nextLevel <= 21; nextLevel++)
        {
            List<int> futureItems = SnapshotShopItemsAtState(merchantId, shopName, nextLevel, forceUnlockAllItems: false);
            int nextProgressionItem = GetFirstNewItem(futureItems, currentSet);
            if (nextProgressionItem > ItemID.None)
            {
                return $"Next: {GetItemDisplayName(nextProgressionItem)}. {Progression.GetLevelFullUnlockHint(nextLevel)}";
            }
        }

        List<int> allItems = SnapshotShopItemsAtState(merchantId, shopName, 21, forceUnlockAllItems: true);
        int eventLockedItem = GetFirstNewItem(allItems, currentSet);
        if (eventLockedItem > ItemID.None)
        {
            return $"Next: {GetItemDisplayName(eventLockedItem)}. Defeat related enemies/events in addition to boss progression.";
        }

        return "All items currently unlocked for this shop.";
    }

    private static string GetItemDisplayName(int itemId)
    {
        if (itemId <= ItemID.None)
        {
            return string.Empty;
        }

        string itemName = Lang.GetItemNameValue(itemId);
        return string.IsNullOrWhiteSpace(itemName) ? $"Item {itemId}" : itemName;
    }

    private static ShopUnlockInfo GetShopUnlockInfo(int merchantId, string shopName)
    {
        if (merchantId <= NPCID.None || string.IsNullOrWhiteSpace(shopName))
        {
            return default;
        }

        if (!ShopExpandedCatalog.TryGetPage(merchantId, shopName, out ShopExpandedCatalog.ShopPage page))
        {
            return new ShopUnlockInfo(0, 0, ItemID.None, false);
        }

        if (Config.Instance?.UnlockAllItems == true)
        {
            return new ShopUnlockInfo(0, 0, ItemID.None, true);
        }

        int progression = Progression.LevelFull();
        int lockedCount = 0;
        int nextRequired = int.MaxValue;
        int nextItemId = ItemID.None;

        foreach (ShopExpandedCatalog.ShopItem item in page.Items)
        {
            if (item.RequiredProgression <= progression)
            {
                continue;
            }

            lockedCount++;
            if (item.RequiredProgression < nextRequired)
            {
                nextRequired = item.RequiredProgression;
                nextItemId = item.ItemId;
            }
        }

        if (nextRequired == int.MaxValue)
        {
            nextRequired = 0;
        }

        return new ShopUnlockInfo(lockedCount, nextRequired, nextItemId, true);
    }

    private static int GetFirstNewItem(IEnumerable<int> candidateItems, HashSet<int> currentItems)
    {
        foreach (int itemId in candidateItems)
        {
            if (!currentItems.Contains(itemId))
            {
                return itemId;
            }
        }

        return ItemID.None;
    }

    private int GetSelectedShopLockedCount()
    {
        if (!_shopWasExplicitlyClicked)
        {
            return 0;
        }

        if (_selectedMerchantId <= NPCID.None || string.IsNullOrWhiteSpace(_selectedShopName))
        {
            return 0;
        }

        if (Config.Instance?.UnlockAllItems == true)
        {
            return 0;
        }

        ShopUnlockInfo info = GetShopUnlockInfo(_selectedMerchantId, _selectedShopName);
        if (info.HasCatalogData)
        {
            return Math.Max(0, info.LockedCount);
        }

        List<int> currentItems = SnapshotShopItemsAtState(_selectedMerchantId, _selectedShopName, Progression.LevelFull(), forceUnlockAllItems: false);
        List<int> allItems = SnapshotShopItemsAtState(_selectedMerchantId, _selectedShopName, 21, forceUnlockAllItems: true);
        return Math.Max(0, allItems.Count - currentItems.Count);
    }

    private static List<int> SnapshotShopItemsAtState(int merchantId, string shopName, int progressionLevel, bool forceUnlockAllItems)
    {
        List<int> items = [];

        if (merchantId <= NPCID.None || string.IsNullOrWhiteSpace(shopName))
        {
            return items;
        }

        if (!ShopUI.Shops.TryGetValue(merchantId, out Shop shop))
        {
            return items;
        }

        int previousMerchantId = ShopUI.CurrentMerchantId;
        int previousTalkNpc = Main.LocalPlayer?.talkNPC ?? -1;
        bool previousForceUnlockAll = Config.ForceUnlockAllItems;

        try
        {
            ShopUI.CurrentMerchantId = merchantId;
            Config.ForceUnlockAllItems = forceUnlockAllItems;

            using (Progression.PushPreviewLevelOverride(progressionLevel))
            {
                shop.OpenShopForNpcType(shopName, merchantId, suppressSound: true);
                Chest currentShop = Main.instance?.shop?[Main.npcShop];
                if (currentShop?.item is null)
                {
                    return items;
                }

                foreach (Item item in currentShop.item)
                {
                    if (item is null || item.IsAir || item.type <= ItemID.None)
                    {
                        continue;
                    }

                    items.Add(item.type);
                }
            }
        }
        finally
        {
            Config.ForceUnlockAllItems = previousForceUnlockAll;
            ShopUI.CurrentMerchantId = previousMerchantId;

            if (Main.LocalPlayer is not null)
            {
                Main.LocalPlayer.SetTalkNPC(previousTalkNpc);
            }
        }

        return items;
    }

    private void OnShowAllItemsClicked(UIMouseEvent evt, UIElement listeningElement)
    {
        Config config = Config.Instance;
        if (config is null || !config.DevMode)
        {
            return;
        }

        config.ShowAllItems = !config.ShowAllItems;
        UpdateShowAllItemsButton();
        Refresh();
    }

    private void UpdateShowAllItemsButton()
    {
        if (_showAllItemsBtn is null)
        {
            return;
        }

        bool devMode = Config.Instance?.DevMode == true;
        bool showAllItems = Config.Instance?.ShowAllItems == true;
        _showAllItemsBtn.IgnoresMouseInteraction = !devMode;

        if (!devMode)
        {
            _showAllItemsBtn.SetText(string.Empty);
            _showAllItemsBtn.Left.Set(-10000f, 0f);
            return;
        }

        _showAllItemsBtn.Left.Set(8f, 0f);
        _showAllItemsBtn.SetText(showAllItems ? "Show All Items: ON" : "Show All Items");
    }

    private static string FitHintText(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return "-";
        }

        string trimmed = text.Trim();
        // Leave extra right-side breathing room to avoid glyph clipping.
        float maxWidth = PanelWidth - 36f;
        if (MeasureHintLineWidth(trimmed) <= maxWidth)
        {
            return trimmed;
        }

        const string ellipsis = "...";
        int low = 0;
        int high = trimmed.Length;
        while (low < high)
        {
            int mid = (low + high + 1) / 2;
            string candidate = trimmed[..mid].TrimEnd() + ellipsis;
            if (MeasureHintLineWidth(candidate) <= maxWidth)
            {
                low = mid;
            }
            else
            {
                high = mid - 1;
            }
        }

        if (low <= 0)
        {
            return ellipsis;
        }

        return trimmed[..low].TrimEnd() + ellipsis;
    }

    private static string AppendLockedStatus(string hintText, int lockedCount)
    {
        string baseText = string.IsNullOrWhiteSpace(hintText) ? "-" : hintText.Trim();
        if (lockedCount <= 0)
        {
            return baseText;
        }

        string suffix = lockedCount == 1
            ? "1 item remains locked in this shop."
            : $"{lockedCount} items remain locked in this shop.";
        return $"{baseText} {suffix}";
    }

    private static float MeasureHintLineWidth(string text)
    {
        return FontAssets.MouseText.Value.MeasureString(HintPrefix + text).X * HintTextScale;
    }
}
