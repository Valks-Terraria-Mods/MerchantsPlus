namespace MerchantsPlus.Shops;

public class ShopTaxCollector : Shop
{
    public override string[] Shops => Array.Empty<string>();

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        // Default Shop
        AddItem(ItemID.UglySweater, Coins.Platinum(99));
    }
}