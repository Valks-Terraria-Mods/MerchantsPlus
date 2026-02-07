namespace MerchantsPlus.Shops;

public class ShopPartyGirl : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.PartyGirl, ShopPartyGirlCatalog.ShopNames);

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.PartyGirl, shop))
        {
            return;
        }

        if (shop == ShopPartyGirlCatalog.PartyStuffShopName)
        {
            AddStagedItems(ShopPartyGirlCatalog.PartySupplies, 0, 16);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.PartyGirl);
    }
}







