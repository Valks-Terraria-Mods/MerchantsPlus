namespace MerchantsPlus.Shops;

public class ShopWizard : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.Wizard, ShopWizardCatalog.ShopNames);

    public override bool IsBaseShopVisible(string shopName)
    {
        if (shopName == ShopWizardCatalog.GearShopName)
        {
            return HasAnyStagedItemVisible(ShopWizardCatalog.ArcaneGear, 8, 21);
        }

        return true;
    }

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.Wizard, shop))
        {
            return;
        }

        if (shop == ShopWizardCatalog.GearShopName)
        {
            AddStagedItems(ShopWizardCatalog.ArcaneGear, 8, 21);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.Wizard);
    }
}







