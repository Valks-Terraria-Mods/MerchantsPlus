namespace MerchantsPlus.Shops;

public class ShopTruffle : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.Truffle, ShopTruffleCatalog.ShopNames);

    public override bool IsBaseShopVisible(string shopName)
    {
        if (shopName == ShopTruffleCatalog.GearShopName)
        {
            return HasAnyStagedItemVisible(ShopTruffleCatalog.MushroomGear, 8, 21);
        }

        return true;
    }

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.Truffle, shop))
        {
            return;
        }

        if (shop == ShopTruffleCatalog.GearShopName)
        {
            AddStagedItems(ShopTruffleCatalog.MushroomGear, 8, 21);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.Truffle);
    }
}




