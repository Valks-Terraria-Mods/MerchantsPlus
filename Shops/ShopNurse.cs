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
            AddItemsAtPrice(ShopNurseCatalog.LifeItemPrice, ShopNurseCatalog.LifeItems);
            AddConditionalOffers(ShopNurseCatalog.LifeUnlocks);
        }
    }
}



