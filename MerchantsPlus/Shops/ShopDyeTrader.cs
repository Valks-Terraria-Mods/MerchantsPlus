namespace MerchantsPlus.Shops;

public class ShopDyeTrader : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.DyeTrader, ShopDyeTraderCatalog.ShopNames);

    public override bool IsBaseShopVisible(string shopName)
    {
        if (!ShopDyeTraderCatalog.DyesByShop.TryGetValue(shopName, out int[] dyeCollection))
        {
            return true;
        }

        (int minProgression, int maxProgression) = GetDyeProgressionWindow(shopName);
        return HasAnyStagedItemVisible(dyeCollection, minProgression, maxProgression);
    }

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.DyeTrader, shop))
        {
            return;
        }

        if (ShopDyeTraderCatalog.DyesByShop.TryGetValue(shop, out int[] dyeCollection))
        {
            (int minProgression, int maxProgression) = GetDyeProgressionWindow(shop);
            AddStagedItemsAtPrice(ItemCosts.Dyes, dyeCollection, minProgression, maxProgression);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.DyeTrader);
    }

    private static (int MinProgression, int MaxProgression) GetDyeProgressionWindow(string shopName)
    {
        return shopName switch
        {
            ShopDyeTraderCatalog.BasicShopName => (0, 6),
            ShopDyeTraderCatalog.BrightShopName => (2, 9),
            ShopDyeTraderCatalog.GradientShopName => (4, 13),
            ShopDyeTraderCatalog.CompoundShopName => (5, 15),
            ShopDyeTraderCatalog.StrangeShopName => (8, 19),
            ShopDyeTraderCatalog.LunarShopName => (16, 21),
            _ => (0, 16),
        };
    }
}






