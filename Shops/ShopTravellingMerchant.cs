namespace MerchantsPlus.Shops;

public class ShopTravellingMerchant : Shop
{
    public override List<string> Shops { get; } = ["Gear"];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Gear")
        {
            AddItem(ItemID.GoldenKey, Coins.Gold(3));

            if (Progression.Moonlord)
            {
                AddItem(ItemID.SuspiciousLookingTentacle);
            }

            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.TravellingMerchant);
    }
}