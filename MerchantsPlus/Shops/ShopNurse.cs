namespace MerchantsPlus.Shops;

public class ShopNurse : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.Nurse, ShopNurseCatalog.ShopNames);

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.Nurse, shop))
        {
            return;
        }

        if (shop == ShopNurseCatalog.LifeShopName)
        {
            AddStagedItemsAtPrice(ShopNurseCatalog.LifeItemPrice, ShopNurseCatalog.LifeItems, 0, 12);
            AddConditionalOffers(ShopNurseCatalog.LifeUnlocks);
        }
    }
}



