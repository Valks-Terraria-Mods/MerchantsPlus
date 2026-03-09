namespace MerchantsPlus.Shops;

public class ShopPainter : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.Painter, ShopPainterCatalog.ShopNames);

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.Painter, shop))
        {
            return;
        }

        if (ShopPainterCatalog.SectionsByShop.TryGetValue(shop, out (int? Price, int[] ItemIds)[] sections))
        {
            AddSections(sections);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.Painter);
    }

    private void AddSections((int? Price, int[] ItemIds)[] sections)
    {
        foreach ((int? Price, int[] ItemIds) in sections)
        {
            if (Price.HasValue)
            {
                AddStagedItemsAtPrice(Price.Value, ItemIds, 0, 18);
            }
            else
            {
                AddStagedItems(ItemIds, 0, 18);
            }
        }
    }
}



