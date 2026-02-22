namespace MerchantsPlus.Shops;

public class ShopDyeTrader : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.DyeTrader, ShopDyeTraderCatalog.ShopNames);

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.DyeTrader, shop))
        {
            return;
        }

        if (ShopDyeTraderCatalog.DyesByShop.TryGetValue(shop, out int[] dyeCollection))
        {
            AddItemsAtPrice(ItemCosts.Dyes, dyeCollection);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.DyeTrader);
    }
}






