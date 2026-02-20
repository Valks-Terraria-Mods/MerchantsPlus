namespace MerchantsPlus.Shops;

public class ShopTaxCollector : Shop
{
    public override List<string> Shops { get; } = [.. ShopTaxCollectorCatalog.ShopNames];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        // Default Shop
        AddItem(ShopTaxCollectorCatalog.TaxCollectorExclusiveItemId, ShopTaxCollectorCatalog.TaxCollectorExclusiveItemPrice);
    }
}
