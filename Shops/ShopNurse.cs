namespace MerchantsPlus.Shops;

public class ShopNurse : Shop
{
    public override List<string> Shops { get; } = [.. ShopNurseCatalog.ShopNames];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == ShopNurseCatalog.LifeShopName)
        {
            AddItemsAtPrice(ShopNurseCatalog.LifeItemPrice, ShopNurseCatalog.LifeItems);
            AddConditionalOffers(ShopNurseCatalog.LifeUnlocks);
        }
    }
}
