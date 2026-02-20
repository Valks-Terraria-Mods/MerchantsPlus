namespace MerchantsPlus.Shops;

public class ShopAngler : Shop
{
    public override List<string> Shops { get; } = [.. ShopAnglerCatalog.ShopNames];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

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
        ReplaceItem(ItemID.WoodFishingPole, Coins.Silver(10));
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
