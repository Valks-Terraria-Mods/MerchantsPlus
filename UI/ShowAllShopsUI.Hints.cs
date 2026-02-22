using MerchantsPlus.Shops;
using Terraria.GameContent;
using Terraria.GameContent.UI.Elements;

namespace MerchantsPlus.UI;

public partial class ShowAllShopsUI
{
    private void InvalidateHintCache()
    {
        _hintCacheMerchantId = NPCID.None;
        _hintCacheShopName = string.Empty;
        _hintCacheProgression = int.MinValue;
        _hintCacheUnlockAll = false;
        _hintCacheWorldSessionNonce = -1;
        _hintCacheText = string.Empty;
        _hintCacheLockedCount = -1;
    }

    private void EnsureSelectedHintCache()
    {
        int progressionLevel = Progression.LevelFull();
        bool unlockAllItems = Config.Instance?.UnlockAllItems == true;
        int sessionNonce = GetWorldSessionNonceForHintCache();

        if (_hintCacheMerchantId == _selectedMerchantId
            && string.Equals(_hintCacheShopName, _selectedShopName, StringComparison.Ordinal)
            && _hintCacheProgression == progressionLevel
            && _hintCacheUnlockAll == unlockAllItems
            && _hintCacheWorldSessionNonce == sessionNonce
            && !string.IsNullOrWhiteSpace(_hintCacheText)
            && _hintCacheLockedCount >= 0)
        {
            return;
        }

        (string hintText, int lockedCount) = ComputeSelectedHintAndLockedCount();
        _hintCacheMerchantId = _selectedMerchantId;
        _hintCacheShopName = _selectedShopName ?? string.Empty;
        _hintCacheProgression = progressionLevel;
        _hintCacheUnlockAll = unlockAllItems;
        _hintCacheWorldSessionNonce = sessionNonce;
        _hintCacheText = hintText;
        _hintCacheLockedCount = Math.Max(0, lockedCount);
    }

    private int GetWorldSessionNonceForHintCache()
    {
        if (_onlyPresentTownMerchants
            && TryGetWorldSession(out WorldShopSession session)
            && session is not null
            && session.IsActive)
        {
            return session.OpenNonce;
        }

        return -1;
    }

    private (string HintText, int LockedCount) ComputeSelectedHintAndLockedCount()
    {
        if (!_shopWasExplicitlyClicked)
        {
            return ("Select a shop to open it and view unlock hints.", 0);
        }

        if (_selectedMerchantId <= NPCID.None || string.IsNullOrWhiteSpace(_selectedShopName))
        {
            return ("-", 0);
        }

        if (Config.Instance?.UnlockAllItems == true)
        {
            return ("Show All Items is enabled.", 0);
        }

        ShopUnlockInfo info = GetShopUnlockInfo(_selectedMerchantId, _selectedShopName);
        if (info.HasCatalogData)
        {
            if (info.LockedCount <= 0)
            {
                return ("All items currently unlocked for this shop.", 0);
            }

            string itemName = GetItemDisplayName(info.NextItemId);
            string unlockHint = Progression.GetLevelFullUnlockHint(info.NextRequiredProgression);
            string hint = string.IsNullOrWhiteSpace(itemName)
                ? unlockHint
                : $"Next: {itemName}. {unlockHint}";
            return (hint, Math.Max(0, info.LockedCount));
        }

        return GetDynamicShopHintAndLockedCount(_selectedMerchantId, _selectedShopName);
    }

    private string GetSelectedShopHint()
    {
        EnsureSelectedHintCache();
        return string.IsNullOrWhiteSpace(_hintCacheText) ? "-" : _hintCacheText;
    }

    private (string HintText, int LockedCount) GetDynamicShopHintAndLockedCount(int merchantId, string shopName)
    {
        if (Config.Instance?.UnlockAllItems == true)
        {
            return ("Show All Items is enabled.", 0);
        }

        int progressionLevel = Progression.LevelFull();
        List<int> currentItems = SnapshotShopItemsAtState(
            merchantId,
            shopName,
            progressionLevel,
            forceUnlockAllItems: false,
            sourceTag: "hint_snapshot");
        List<int> allItems = SnapshotShopItemsAtState(
            merchantId,
            shopName,
            21,
            forceUnlockAllItems: true,
            sourceTag: "hint_snapshot");
        int lockedCount = Math.Max(0, allItems.Count - currentItems.Count);

        if (currentItems.Count == 0)
        {
            return ("No items currently visible in this shop.", lockedCount);
        }

        HashSet<int> currentSet = [.. currentItems];
        for (int nextLevel = progressionLevel + 1; nextLevel <= 21; nextLevel++)
        {
            List<int> futureItems = SnapshotShopItemsAtState(
                merchantId,
                shopName,
                nextLevel,
                forceUnlockAllItems: false,
                sourceTag: "hint_snapshot");
            int nextProgressionItem = GetFirstNewItem(futureItems, currentSet);
            if (nextProgressionItem > ItemID.None)
            {
                return ($"Next: {GetItemDisplayName(nextProgressionItem)}. {Progression.GetLevelFullUnlockHint(nextLevel)}", lockedCount);
            }
        }

        int eventLockedItem = GetFirstNewItem(allItems, currentSet);
        if (eventLockedItem > ItemID.None)
        {
            return ($"Next: {GetItemDisplayName(eventLockedItem)}. Defeat related enemies/events in addition to boss progression.", lockedCount);
        }

        return ("All items currently unlocked for this shop.", 0);
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
        EnsureSelectedHintCache();
        return Math.Max(0, _hintCacheLockedCount);
    }

    private static List<int> SnapshotShopItemsAtState(
        int merchantId,
        string shopName,
        int progressionLevel,
        bool forceUnlockAllItems,
        string sourceTag)
    {
        List<int> itemIds = [];
        List<Item> entries = SnapshotShopEntriesAtState(
            merchantId,
            shopName,
            progressionLevel,
            forceUnlockAllItems,
            sourceTag);
        foreach (Item item in entries)
        {
            if (item is null || item.IsAir || item.type <= ItemID.None)
            {
                continue;
            }

            itemIds.Add(item.type);
        }

        return itemIds;
    }

    private static List<Item> SnapshotShopEntriesAtState(
        int merchantId,
        string shopName,
        int progressionLevel,
        bool forceUnlockAllItems,
        string sourceTag)
    {
        List<Item> items = [];

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
        int previousPlayerChest = Main.LocalPlayer?.chest ?? -1;
        int previousNpcShop = Main.npcShop;
        bool previousPlayerInventory = Main.playerInventory;
        string previousNpcChatText = Main.npcChatText;
        bool previousForceUnlockAll = Config.ForceUnlockAllItems;

        try
        {
            ShopUI.CurrentMerchantId = merchantId;
            Config.ForceUnlockAllItems = forceUnlockAllItems;

            using (Progression.PushPreviewLevelOverride(progressionLevel))
            {
                shop.OpenShopForNpcType(shopName, merchantId, suppressSound: true, sourceTag: sourceTag);
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

                    items.Add(item.Clone());
                }
            }
        }
        finally
        {
            Config.ForceUnlockAllItems = previousForceUnlockAll;
            ShopUI.CurrentMerchantId = previousMerchantId;
            Main.SetNPCShopIndex(previousNpcShop);
            Main.playerInventory = previousPlayerInventory;
            Main.npcChatText = previousNpcChatText;

            if (Main.LocalPlayer is not null)
            {
                Main.LocalPlayer.SetTalkNPC(previousTalkNpc);
                Main.LocalPlayer.chest = previousPlayerChest;
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

        _showAllItemsBtn.Left.Set(90f, 0f);
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
