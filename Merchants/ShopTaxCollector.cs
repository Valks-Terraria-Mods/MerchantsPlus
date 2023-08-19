using Terraria.ID;

namespace MerchantsPlus.Merchants;

internal class ShopTaxCollector : Shop
{
    public ShopTaxCollector(params string[] shops) : base(shops)
    {
    }

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        // Default Shop
        AddItem(ItemID.UglySweater, Utils.Coins(0, 0, 0, 99));
    }
}