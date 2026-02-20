namespace MerchantsPlus.Shops;

public class ShopPartyGirl : Shop
{
    public override List<string> Shops { get; } = [.. ShopPartyGirlCatalog.ShopNames];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == ShopPartyGirlCatalog.PartyStuffShopName)
        {
            AddItems(ShopPartyGirlCatalog.PartySupplies);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.PartyGirl);
    }
}




