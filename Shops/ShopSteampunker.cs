namespace MerchantsPlus.Shops;

public class ShopSteampunker : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.Steampunker, ShopSteampunkerCatalog.ShopNames);

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.Steampunker, shop))
        {
            return;
        }

        if (ShopSteampunkerCatalog.SectionsByShop.TryGetValue(shop, out (int? Price, int[] ItemIds)[] sections))
        {
            AddSections(sections);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.Steampunker);
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



