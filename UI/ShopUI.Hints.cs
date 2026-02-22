using MerchantsPlus.Shops;
using Terraria.GameContent;

namespace MerchantsPlus.UI;

public partial class ShopUI
{
    private string GetCachedShopHint(int merchantId, string shopName)
    {
        int progressionLevel = Progression.LevelFull();
        bool unlockAll = Config.Instance?.UnlockAllItems == true;

        if (merchantId == _lastHintMerchantId
            && string.Equals(shopName, _lastHintShopName, StringComparison.Ordinal)
            && progressionLevel == _lastHintProgressionLevel
            && unlockAll == _lastHintUnlockAll
            && !string.IsNullOrWhiteSpace(_lastHintText))
        {
            return _lastHintText;
        }

        _lastHintMerchantId = merchantId;
        _lastHintShopName = shopName ?? string.Empty;
        _lastHintProgressionLevel = progressionLevel;
        _lastHintUnlockAll = unlockAll;
        _lastHintText = ComputeShopHint(merchantId, shopName);
        return _lastHintText;
    }

    private static string ComputeShopHint(int merchantId, string shopName)
    {
        if (string.IsNullOrWhiteSpace(shopName))
        {
            return "Select a shop from the list.";
        }

        if (Config.Instance?.UnlockAllItems == true)
        {
            return "Show All Items is enabled.";
        }

        ShopUnlockInfo info = GetShopUnlockInfo(merchantId, shopName);
        if (!info.HasCatalogData)
        {
            return GetDynamicShopHint(merchantId, shopName);
        }

        if (info.LockedCount <= 0 || info.NextItemId <= ItemID.None || info.NextRequiredProgression <= 0)
        {
            return "All items currently unlocked for this shop.";
        }

        string itemName = GetItemDisplayName(info.NextItemId);
        string unlockHint = Progression.GetLevelFullUnlockHint(info.NextRequiredProgression);
        return string.IsNullOrWhiteSpace(itemName)
            ? unlockHint
            : $"Next: {itemName}. {unlockHint}";
    }

    private static string GetDynamicShopHint(int merchantId, string shopName)
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
                shop.OpenShopForNpcType(shopName, merchantId, suppressSound: true, sourceTag: "hint_snapshot");
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

    private static string GetItemDisplayName(int itemId)
    {
        if (itemId <= ItemID.None)
        {
            return string.Empty;
        }

        string itemName = Lang.GetItemNameValue(itemId);
        return string.IsNullOrWhiteSpace(itemName) ? $"Item {itemId}" : itemName;
    }

    private static string WrapHintText(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return $"{HintPrefix}-";
        }

        string normalized = text
            .Replace('\r', ' ')
            .Replace('\n', ' ')
            .Trim();
        if (string.IsNullOrWhiteSpace(normalized))
        {
            return $"{HintPrefix}-";
        }

        string[] words = normalized.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (words.Length == 0)
        {
            return $"{HintPrefix}-";
        }

        List<string> lines = [];
        string current = words[0];

        for (int i = 1; i < words.Length; i++)
        {
            string candidate = $"{current} {words[i]}";
            if (MeasureHintWidth(candidate) <= HintWrapWidth)
            {
                current = candidate;
            }
            else
            {
                lines.Add(current);
                current = words[i];
            }
        }

        lines.Add(current);
        return string.Join('\n', lines);
    }

    private static float MeasureHintWidth(string text)
    {
        return FontAssets.MouseText.Value.MeasureString(text).X * HintScale;
    }
}
