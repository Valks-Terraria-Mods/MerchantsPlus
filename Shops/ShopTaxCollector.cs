namespace MerchantsPlus.Shops;

public class ShopTaxCollector : Shop
{
    public override List<string> Shops { get; } = [];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        // Default Shop
        AddItem(ItemID.UglySweater, Coins.Platinum(99));
    }
}