namespace MerchantsPlus.Shops;

public class ShopSteampunker : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.Steampunker, ShopSteampunkerCatalog.ShopNames);

    public override bool IsBaseShopVisible(string shopName)
    {
        if (!ShopSteampunkerCatalog.SectionsByShop.TryGetValue(shopName, out (int? Price, int[] ItemIds)[] sections))
        {
            return true;
        }

        foreach ((int? Price, int[] ItemIds) section in sections)
        {
            if (HasAnyStagedItemVisible(section.ItemIds, 8, 21))
            {
                return true;
            }
        }

        return false;
    }

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
                AddStagedItemsAtPrice(Price.Value, ItemIds, 8, 21);
            }
            else
            {
                AddStagedItems(ItemIds, 8, 21);
            }
        }
    }
}



