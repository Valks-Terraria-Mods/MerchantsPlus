namespace MerchantsPlus.Shops;

public class ShopCyborg : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.Cyborg, ShopCyborgCatalog.ShopNames);

    public override bool IsBaseShopVisible(string shopName)
    {
        if (shopName != ShopCyborgCatalog.RoboticsShopName)
        {
            return true;
        }

        if (HasAnyStagedItemVisible(ShopCyborgCatalog.RoboticsGear, 10, 21))
        {
            return true;
        }

        return HasAnyConditionalOfferVisible(ShopCyborgCatalog.RoboticsUnlocks);
    }

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.Cyborg, shop))
        {
            return;
        }

        if (shop == ShopCyborgCatalog.RoboticsShopName)
        {
            AddStagedItems(ShopCyborgCatalog.RoboticsGear, 10, 21);
            AddConditionalOffers(ShopCyborgCatalog.RoboticsUnlocks);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.Cyborg);
    }
}




