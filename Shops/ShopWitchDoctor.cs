namespace MerchantsPlus.Shops;

public class ShopWitchDoctor : Shop
{
    public override List<string> Shops { get; } = [.. ShopWitchDoctorCatalog.ShopNames];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        Action openShop = shop switch
        {
            ShopWitchDoctorCatalog.WingsShopName => Wings,
            ShopWitchDoctorCatalog.FlasksShopName => Flasks,
            ShopWitchDoctorCatalog.GearShopName => Gear,
            _ => () => Inv.SetupShop(ShopType.WitchDoctor)
        };

        openShop();
    }

    private void Gear()
    {
        AddItems(ShopWitchDoctorCatalog.GearItems);
        AddConditionalOffers(ShopWitchDoctorCatalog.GearUnlocks);
    }

    private void Flasks()
    {
        AddItems(ShopWitchDoctorCatalog.FlaskItems);
        AddConditionalOffers(ShopWitchDoctorCatalog.FlaskUnlocks);
    }

    private void Wings()
    {
        AddItem(ShopWitchDoctorCatalog.PrehardmodeWingItemId, Coins.Platinum());
        AddConditionalOffers(ShopWitchDoctorCatalog.WingUnlocks);
    }
}



