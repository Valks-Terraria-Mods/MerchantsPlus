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
            AddItem(ItemID.LifeCrystal, Coins.Gold(10));
            AddItem(Progression.DownedMechs(3), ItemID.LifeFruit, Coins.Gold(10));
            AddItem(ItemID.HeartLantern, Coins.Gold(10));
        }
    }
}