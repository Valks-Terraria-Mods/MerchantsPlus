namespace MerchantsPlus.Shops;

public class ShopTruffle : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.Truffle, ShopTruffleCatalog.ShopNames);

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.Truffle, shop))
        {
            return;
        }

        if (shop == ShopTruffleCatalog.GearShopName)
        {
            AddItems(ShopTruffleCatalog.MushroomGear);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.Truffle);
    }
}




