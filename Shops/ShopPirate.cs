namespace MerchantsPlus.Shops;

public class ShopPirate : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.Pirate, ShopPirateCatalog.ShopNames);

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.Pirate, shop))
        {
            return;
        }

        if (ShopPirateCatalog.SectionsByShop.TryGetValue(shop, out (int? Price, int[] ItemIds)[] sections))
        {
            AddSections(sections);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.Pirate);
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



