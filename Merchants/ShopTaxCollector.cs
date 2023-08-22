namespace MerchantsPlus.Merchants;

internal class ShopTaxCollector : Shop
{
    public override string[] Shops => Array.Empty<string>();

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        // Default Shop
        AddItem(ItemID.UglySweater, Utils.Coins(0, 0, 0, 99));
    }
}