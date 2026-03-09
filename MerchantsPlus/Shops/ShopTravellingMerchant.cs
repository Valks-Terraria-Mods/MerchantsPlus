namespace MerchantsPlus.Shops;

public class ShopTravellingMerchant : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.TravellingMerchant, ShopTravellingMerchantCatalog.ShopNames);

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.TravellingMerchant, shop))
        {
            return;
        }

        if (shop == ShopTravellingMerchantCatalog.GearShopName)
        {
            Gear();
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.TravellingMerchant);
    }

    private void Gear()
    {
        AddItem(ShopTravellingMerchantCatalog.GoldenKeyItemId, Coins.Gold(3));
        AddItem(Progression.Moonlord, ShopTravellingMerchantCatalog.SuspiciousLookingTentacleItemId);
    }
}
