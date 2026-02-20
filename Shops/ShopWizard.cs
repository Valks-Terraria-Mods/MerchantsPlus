namespace MerchantsPlus.Shops;

public class ShopWizard : Shop
{
    public override List<string> Shops { get; } = [.. ShopWizardCatalog.ShopNames];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == ShopWizardCatalog.GearShopName)
        {
            AddItems(ShopWizardCatalog.ArcaneGear);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.Wizard);
    }
}




