namespace MerchantsPlus.Shops;

public class ShopTravellingMerchant : Shop
{
    public override List<string> Shops { get; } = [.. ShopTravellingMerchantCatalog.ShopNames];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

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
        AddProgressionItems(Progression.LevelFull(), ShopTravellingMerchantCatalog.GearItems);
        AddConditionalOffers(ShopTravellingMerchantCatalog.GearUnlocks);
    }
}
