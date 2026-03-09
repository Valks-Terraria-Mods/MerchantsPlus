namespace MerchantsPlus.Shops;

public class ShopSantaClaus : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.SantaClaus, ShopSantaClausCatalog.ShopNames);

    public override bool IsBaseShopVisible(string shopName)
    {
        if (!ShopSantaClausCatalog.ItemsByShop.TryGetValue(shopName, out int[] items))
        {
            return true;
        }

        return HasAnyStagedItemVisible(items, 10, 21);
    }

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.SantaClaus, shop))
        {
            return;
        }

        if (ShopSantaClausCatalog.ItemsByShop.TryGetValue(shop, out int[] items))
        {
            AddStagedItems(items, 10, 21);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.SantaClaus);
    }
}







