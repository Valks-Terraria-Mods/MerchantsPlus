using MerchantsPlus.Shops;

namespace MerchantsPlus.UI;

internal static class ShopUnlockAsteriskTracker
{
    /// <summary>
    /// Call this when world progression changes (e.g. boss defeated) to force asterisks to update.
    /// </summary>
    public static void NotifyProgressionChanged()
    {
        _dynamicUnlockedCountCache.Clear();
    }
    private readonly record struct ShopKey(int MerchantId, string ShopName);
    private readonly record struct DynamicCountCache(int Count, ulong Tick);

    // Use world-persistent dictionary
    private static Dictionary<(int MerchantId, string ShopName), int> AcknowledgedCounts => ShopUnlockAsteriskWorldData.AcknowledgedCounts;
    private static readonly Dictionary<ShopKey, DynamicCountCache> _dynamicUnlockedCountCache = [];
    private const ulong DynamicProbeIntervalTicks = 45;

    public static bool HasUnseenUnlocks(int merchantId, string shopName)
    {
        int unlockedCount = GetUnlockedItemCount(merchantId, shopName);
        if (unlockedCount < 0)
        {
            return false;
        }

        var key = (merchantId, shopName);
        if (!AcknowledgedCounts.TryGetValue(key, out int acknowledgedCount))
        {
            // Unseen until the player acknowledges by clicking merchant/shop.
            return unlockedCount > 0;
        }

        if (unlockedCount < acknowledgedCount)
        {
            AcknowledgedCounts[key] = unlockedCount;
            return false;
        }

        return unlockedCount > acknowledgedCount;
    }

    public static void AcknowledgeShop(int merchantId, string shopName)
    {
        int unlockedCount = GetUnlockedItemCount(merchantId, shopName);
        if (unlockedCount < 0)
        {
            return;
        }
        AcknowledgedCounts[(merchantId, shopName)] = unlockedCount;
    }

    public static void AcknowledgeShops(int merchantId, IEnumerable<string> shopNames)
    {
        HashSet<string> seen = new(StringComparer.Ordinal);
        foreach (string shopName in shopNames ?? [])
        {
            if (string.IsNullOrWhiteSpace(shopName) || !seen.Add(shopName))
            {
                continue;
            }
            AcknowledgeShop(merchantId, shopName);
        }
    }

    // No longer needed: persistence is handled by ShopUnlockAsteriskWorldData

    private static int GetUnlockedItemCount(int merchantId, string shopName)
    {
        if (merchantId <= NPCID.None || string.IsNullOrWhiteSpace(shopName))
        {
            return -1;
        }

        // Suppress "new unlock" badges when all items are force-unlocked.
        if (Config.Instance?.UnlockAllItems == true)
        {
            return -1;
        }

        if (ShopExpandedCatalog.TryGetPage(merchantId, shopName, out ShopExpandedCatalog.ShopPage page))
        {
            int progression = Progression.LevelFull();
            int unlockedCount = 0;
            foreach (ShopExpandedCatalog.ShopItem item in page.Items)
            {
                if (item.RequiredProgression <= progression)
                {
                    unlockedCount++;
                }
            }

            return unlockedCount;
        }

        return GetDynamicUnlockedItemCount(merchantId, shopName);
    }

    private static int GetDynamicUnlockedItemCount(int merchantId, string shopName)
    {
        ShopKey key = new(merchantId, shopName);
        if (_dynamicUnlockedCountCache.TryGetValue(key, out DynamicCountCache cache)
            && Main.GameUpdateCount <= cache.Tick + DynamicProbeIntervalTicks)
        {
            return cache.Count;
        }

        int count = SnapshotVisibleItemCount(merchantId, shopName);
        _dynamicUnlockedCountCache[key] = new DynamicCountCache(count, Main.GameUpdateCount);
        return count;
    }

    private static int SnapshotVisibleItemCount(int merchantId, string shopName)
    {
        if (merchantId <= NPCID.None || string.IsNullOrWhiteSpace(shopName))
        {
            return -1;
        }

        if (!ShopUI.Shops.TryGetValue(merchantId, out Shop shop))
        {
            return -1;
        }

        int previousMerchantId = ShopUI.CurrentMerchantId;
        int previousTalkNpc = Main.LocalPlayer?.talkNPC ?? -1;
        int previousPlayerChest = Main.LocalPlayer?.chest ?? -1;
        int previousNpcShop = Main.npcShop;
        bool previousPlayerInventory = Main.playerInventory;
        string previousNpcChatText = Main.npcChatText;
        bool previousForceUnlockAll = Config.ForceUnlockAllItems;
        int previousCycleIndex = shop.CycleIndex;

        try
        {
            ShopUI.CurrentMerchantId = merchantId;
            Config.ForceUnlockAllItems = false;
            shop.OpenShopForNpcType(shopName, merchantId, suppressSound: true, sourceTag: "unlock_probe");

            Chest currentShop = Main.instance?.shop?[Main.npcShop];
            if (currentShop?.item is null)
            {
                return 0;
            }

            int count = 0;
            foreach (Item item in currentShop.item)
            {
                if (item is null || item.IsAir || item.type <= ItemID.None)
                {
                    continue;
                }

                count++;
            }

            return count;
        }
        finally
        {
            Config.ForceUnlockAllItems = previousForceUnlockAll;
            ShopUI.CurrentMerchantId = previousMerchantId;
            shop.CycleIndex = previousCycleIndex;
            Main.SetNPCShopIndex(previousNpcShop);
            Main.playerInventory = previousPlayerInventory;
            Main.npcChatText = previousNpcChatText;

            if (Main.LocalPlayer is not null)
            {
                Main.LocalPlayer.SetTalkNPC(previousTalkNpc);
                Main.LocalPlayer.chest = previousPlayerChest;
            }
        }
    }
}
