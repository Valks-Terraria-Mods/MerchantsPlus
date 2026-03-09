namespace MerchantsPlus.Shops;

public class ShopGolem : Shop
{
    public override List<string> Shops { get; } = [.. ShopGolemCatalog.ShopNames];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == ShopGolemCatalog.StorageShopName)
        {
            Storage();
        }
    }

    private void Storage()
    {
        int progression = Progression.LevelFull();
        AddItemsAtPrice(Coins.Silver(), ShopGolemCatalog.BaseStorageItems());
        AddProgressionModItemTiers(progression, ShopGolemCatalog.StorageProgressionTiers);
    }
}
