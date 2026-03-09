namespace MerchantsPlus.Shops;

public class ShopClothier : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.Clothier, ShopClothierCatalog.ShopNames);

    public override bool IsBaseShopVisible(string shopName)
    {
        if (shopName == ShopClothierCatalog.ClothingShopName)
        {
            return true;
        }

        if (!ShopClothierCatalog.VanityCollectionsByShop.TryGetValue(shopName, out int[] vanityCollection))
        {
            return true;
        }

        (int minProgression, int maxProgression) = GetVanityProgressionWindow(shopName);
        return HasAnyStagedItemVisible(vanityCollection, minProgression, maxProgression);
    }

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
            (int minProgression, int maxProgression) = GetVanityProgressionWindow(shop);
            AddStagedItemsAtPrice(ItemCosts.Vanity, vanityCollection, minProgression, maxProgression);
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

    private static (int MinProgression, int MaxProgression) GetVanityProgressionWindow(string shopName)
    {
        return shopName switch
        {
            ShopClothierCatalog.BossMasksShopName => (1, 13),
            ShopClothierCatalog.VanityCollectionIShopName => (0, 11),
            ShopClothierCatalog.VanityCollectionIIShopName => (3, 15),
            ShopClothierCatalog.VanityCollectionIIIShopName => (5, 17),
            ShopClothierCatalog.VanityCollectionIVShopName => (7, 19),
            _ => (2, 16),
        };
    }
}



