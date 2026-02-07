namespace MerchantsPlus.Shops;

public class ShopTaxCollector : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.TaxCollector, ShopTaxCollectorCatalog.ShopNames);

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.TaxCollector, shop))
        {
            return;
        }

        // Default Shop
        AddItem(ShopTaxCollectorCatalog.TaxCollectorExclusiveItemId, ShopTaxCollectorCatalog.TaxCollectorExclusiveItemPrice);
    }
}



