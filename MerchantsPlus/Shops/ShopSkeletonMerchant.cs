namespace MerchantsPlus.Shops;

public class ShopSkeletonMerchant : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.SkeletonMerchant, ShopSkeletonMerchantCatalog.ShopNames);

    public override bool IsBaseShopVisible(string shopName)
    {
        if (shopName == ShopSkeletonMerchantCatalog.MusicBoxesShopName)
        {
            return HasAnyStagedItemVisible(ShopSkeletonMerchantCatalog.MusicBoxes, 6, 20);
        }

        if (shopName == ShopSkeletonMerchantCatalog.GearShopName)
        {
            if (HasAnyStagedItemVisible(ShopSkeletonMerchantCatalog.YoyoAccessories, 4, 18))
            {
                return true;
            }

            return HasAnyConditionalOfferVisible(ShopSkeletonMerchantCatalog.GearSoulOffers);
        }

        return true;
    }

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.SkeletonMerchant, shop))
        {
            return;
        }

        if (shop == ShopSkeletonMerchantCatalog.MusicBoxesShopName)
        {
            AddStagedItems(ShopSkeletonMerchantCatalog.MusicBoxes, 6, 20);
            return;
        }

        if (shop == ShopSkeletonMerchantCatalog.GearShopName)
        {
            AddStagedItems(ShopSkeletonMerchantCatalog.YoyoAccessories, 4, 18);
            AddConditionalOffers(ShopSkeletonMerchantCatalog.GearSoulOffers);

            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.SkeletonMerchant);
    }
}







