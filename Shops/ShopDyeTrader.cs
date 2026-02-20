namespace MerchantsPlus.Shops;

public class ShopDyeTrader : Shop
{
    public override List<string> Shops { get; } = [.. ShopDyeTraderCatalog.ShopNames];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (ShopDyeTraderCatalog.DyesByShop.TryGetValue(shop, out int[] dyeCollection))
        {
            AddItemsAtPrice(ItemCosts.Dyes, dyeCollection);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.DyeTrader);
    }
}



