namespace MerchantsPlus.Shops;

public class ShopAngler : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.Angler, ShopAnglerCatalog.ShopNames);

    public override bool IsBaseShopVisible(string shopName)
    {
        if (shopName != ShopAnglerCatalog.FoodShopName)
        {
            return true;
        }

        if (Config.Instance?.UnlockAllItems == true)
        {
            return true;
        }

        int progression = Progression.LevelFull();
        foreach (ProgressionShopItem item in ShopAnglerCatalog.FoodProgressionItems)
        {
            if (item.IsUnlocked(progression))
            {
                return true;
            }
        }

        return false;
    }

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.Angler, shop))
        {
            return;
        }

        int progression = Progression.LevelFull();
        Action openShop = shop switch
        {
            ShopAnglerCatalog.FoodShopName => () => Food(progression),
            ShopAnglerCatalog.CratesShopName => () => Crates(progression),
            ShopAnglerCatalog.BaitShopName => () => Bait(progression),
            _ => () => DefaultShop(progression)
        };

        openShop();
    }

    private void DefaultShop(int progression)
    {
        ShopFishingPole(progression);
        AddProgressionItems(progression, ShopAnglerCatalog.DefaultProgressionItems);
    }

    private void Bait(int progression)
    {
        AddProgressionTiers(progression, ShopAnglerCatalog.BaitTiers);
    }

    private void Crates(int progression)
    {
        AddProgressionItems(progression, ShopAnglerCatalog.CrateProgressionItems);
    }

    private void Food(int progression)
    {
        AddProgressionItems(progression, ShopAnglerCatalog.FoodProgressionItems);
    }

    private void ShopFishingPole(int progression)
    {
        if (Config.Instance?.UnlockAllItems == true)
        {
            AddItem(ShopAnglerCatalog.WoodFishingPoleItemId, Coins.Silver(10));
            foreach (ProgressionShopItem item in ShopAnglerCatalog.FishingPoleProgression)
            {
                AddItem(item.ItemId, item.Price);
            }

            return;
        }

        ReplaceItem(ShopAnglerCatalog.WoodFishingPoleItemId, Coins.Silver(10));
        ReplaceProgressionItems(progression, ShopAnglerCatalog.FishingPoleProgression);

        NextSlot++;
    }

    private void ReplaceProgressionItems(int progression, IReadOnlyList<ProgressionShopItem> items)
    {
        foreach (ProgressionShopItem item in items)
        {
            ReplaceItem(item.IsUnlocked(progression), item.ItemId, item.Price);
        }
    }
}



