namespace MerchantsPlus.Shops;

public class ShopCyborg : Shop
{
    public override List<string> Shops { get; } = [.. ShopCyborgCatalog.ShopNames];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

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

