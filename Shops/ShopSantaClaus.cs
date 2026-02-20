namespace MerchantsPlus.Shops;

public class ShopSantaClaus : Shop
{
    public override List<string> Shops { get; } = [.. ShopSantaClausCatalog.ShopNames];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (ShopSantaClausCatalog.ItemsByShop.TryGetValue(shop, out int[] items))
        {
            AddItems(items);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.SantaClaus);
    }
}




