namespace MerchantsPlus.Shops;

public class ShopPainter : Shop
{
    public override List<string> Shops { get; } = [.. ShopPainterCatalog.ShopNames];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

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
                AddItemsAtPrice(Price.Value, ItemIds);
            }
            else
            {
                AddItems(ItemIds);
            }
        }
    }
}
