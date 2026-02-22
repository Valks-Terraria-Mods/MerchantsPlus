namespace MerchantsPlus.Shops;

public class ShopCyborg : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.Cyborg, ShopCyborgCatalog.ShopNames);

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.Cyborg, shop))
        {
            return;
        }

        if (shop == ShopCyborgCatalog.RoboticsShopName)
        {
            AddItems(ShopCyborgCatalog.RoboticsGear);
            AddConditionalOffers(ShopCyborgCatalog.RoboticsUnlocks);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.Cyborg);
    }
}




