namespace MerchantsPlus.Shops;

public class ShopNurse : Shop
{
    public override List<string> Shops { get; } = 
    [
        "Life"
    ];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Life")
        {
            AddItem(ItemID.LifeCrystal, Coins.Platinum());
            AddItem(Progression.Hardmode, ItemID.LifeFruit, Coins.Platinum());
            AddItem(ItemID.HeartLantern, Coins.Platinum());
        }
    }
}