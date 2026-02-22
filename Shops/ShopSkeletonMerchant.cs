namespace MerchantsPlus.Shops;

public class ShopSkeletonMerchant : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.SkeletonMerchant, ShopSkeletonMerchantCatalog.ShopNames);

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.SkeletonMerchant, shop))
        {
            return;
        }

        if (shop == ShopSkeletonMerchantCatalog.MusicBoxesShopName)
        {
            AddItems(ShopSkeletonMerchantCatalog.MusicBoxes);
            return;
        }

        if (shop == ShopSkeletonMerchantCatalog.GearShopName)
        {
            AddItems(ShopSkeletonMerchantCatalog.YoyoAccessories);
            AddConditionalOffers(ShopSkeletonMerchantCatalog.GearSoulOffers);

            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.SkeletonMerchant);
    }
}







