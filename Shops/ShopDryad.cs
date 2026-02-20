namespace MerchantsPlus.Shops;

public class ShopDryad : Shop
{
    public override List<string> Shops { get; } = [.. ShopDryadCatalog.ShopNames];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == ShopDryadCatalog.SeedsShopName)
        {
            AddItemsAtPrice(ItemCosts.Seeds, ShopDryadCatalog.SeedStock);
            AddConditionalOffers(ShopDryadCatalog.SeedUnlocks);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.Dryad);
    }
}



