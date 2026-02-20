namespace MerchantsPlus.Shops;

public class ShopMechanic : Shop
{
    public override List<string> Shops { get; } = [.. ShopMechanicCatalog.ShopNames];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (ShopMechanicCatalog.SectionsByShop.TryGetValue(shop, out (int? Price, int[] ItemIds) section))
        {
            AddSectionItems(section);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.Mechanic);
    }

    private void AddSectionItems((int? Price, int[] ItemIds) section)
    {
        if (section.Price.HasValue)
        {
            AddItemsAtPrice(section.Price.Value, section.ItemIds);
            return;
        }

        AddItems(section.ItemIds);
    }
}




