namespace MerchantsPlus.Shops;

public class ShopTravellingMerchant : Shop
{
    public override string[] Shops => ["Gear"];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Gear")
        {
            AddItem(ItemID.ShadowOrb);
            AddItem(ItemID.MagicLantern);
            AddItem(ItemID.DD2PetGhost);

            if (Progression.Hardmode)
            {
                AddItem(ItemID.SuspiciousLookingTentacle);
            }

            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.TravellingMerchant);
    }
}