namespace MerchantsPlus.Shops;

public class ShopDemolitionist : Shop
{
    public override List<string> Shops { get; } = [.. ShopDemolitionistCatalog.ShopNames];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == ShopDemolitionistCatalog.ExplosivesShopName)
        {
            Explosives();
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.Demolitionist);
    }

    private void Explosives()
    {
        AddItems(ShopDemolitionistCatalog.BaseExplosives);
        AddConditionalOffers(ShopDemolitionistCatalog.ExplosiveUnlocks);
    }
}




