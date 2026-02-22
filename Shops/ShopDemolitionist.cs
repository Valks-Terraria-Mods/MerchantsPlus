namespace MerchantsPlus.Shops;

public class ShopDemolitionist : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.Demolitionist, ShopDemolitionistCatalog.ShopNames);

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.Demolitionist, shop))
        {
            return;
        }

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







