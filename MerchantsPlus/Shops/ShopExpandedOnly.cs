namespace MerchantsPlus.Shops;

public class ShopExpandedOnly : Shop
{
    private readonly int _merchantNpcId;

    public override List<string> Shops { get; }

    public ShopExpandedOnly(int merchantNpcId)
    {
        _merchantNpcId = merchantNpcId;
        Shops = BuildShopList(merchantNpcId, []);
    }

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);
        OpenExpandedShop(_merchantNpcId, shop);
    }
}
