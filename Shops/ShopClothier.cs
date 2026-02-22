namespace MerchantsPlus.Shops;

public class ShopClothier : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.Clothier, ShopClothierCatalog.ShopNames);

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.Clothier, shop))
        {
            return;
        }

        if (shop == ShopClothierCatalog.ClothingShopName)
        {
            Clothing();
            return;
        }

        if (ShopClothierCatalog.VanityCollectionsByShop.TryGetValue(shop, out int[] vanityCollection))
        {
            AddItemsAtPrice(ItemCosts.Vanity, vanityCollection);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.Clothier);
    }

    private void Clothing()
    {
        AddItems(ShopClothierCatalog.StarterClothing);
        AddConditionalOffers(ShopClothierCatalog.ClothingOffers);
    }
}



