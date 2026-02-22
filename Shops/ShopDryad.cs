namespace MerchantsPlus.Shops;

public class ShopDryad : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.Dryad, ShopDryadCatalog.ShopNames);

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.Dryad, shop))
        {
            return;
        }

        if (shop == ShopDryadCatalog.SeedsShopName)
        {
            AddStagedItemsAtPrice(ItemCosts.Seeds, ShopDryadCatalog.SeedStock, 0, 12);
            AddConditionalOffers(ShopDryadCatalog.SeedUnlocks);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.Dryad);
    }
}






