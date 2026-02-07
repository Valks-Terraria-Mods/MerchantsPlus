namespace MerchantsPlus.Shops;

public class ShopStylist : Shop
{
    private const int BannerKillsRequirement = 50;

    public override List<string> Shops { get; } = BuildShopList(NPCID.Stylist, ShopStylistCatalog.ShopNames);

    public override bool IsBaseShopVisible(string shopName)
    {
        if (shopName == ShopStylistCatalog.HairDyesShopName)
        {
            return HasAnyStagedItemVisible(ShopStylistCatalog.HairDyes, 2, 18);
        }

        if (ShopStylistCatalog.BannerOffersByShop.TryGetValue(shopName, out NpcBannerOffer[] offers))
        {
            foreach (NpcBannerOffer offer in offers)
            {
                if (offer.IsUnlocked(BannerKillsRequirement))
                {
                    return true;
                }
            }

            return false;
        }

        return true;
    }

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.Stylist, shop))
        {
            return;
        }

        if (shop == ShopStylistCatalog.HairDyesShopName)
        {
            AddStagedItems(ShopStylistCatalog.HairDyes, 2, 18);
            return;
        }

        if (ShopStylistCatalog.BannerOffersByShop.TryGetValue(shop, out NpcBannerOffer[] offers))
        {
            AddBannerOffers(offers);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.Stylist);
    }

    private void AddBannerOffers(IReadOnlyList<NpcBannerOffer> offers)
    {
        foreach (NpcBannerOffer offer in offers)
        {
            AddItem(offer.IsUnlocked(BannerKillsRequirement), offer.BannerItemId, offer.Price);
        }
    }
}



