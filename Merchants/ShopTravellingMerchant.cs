using Terraria.ID;

namespace MerchantsPlus.Merchants;

internal class ShopTravellingMerchant : Shop
{
    public ShopTravellingMerchant(params string[] shops) : base(shops)
    {
    }

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Gear")
        {
            AddItem(ItemID.ShadowOrb);
            AddItem(ItemID.MagicLantern);
            AddItem(ItemID.DD2PetGhost);
            if (Main.hardMode) AddItem(ItemID.SuspiciousLookingTentacle);
            return;
        }

        // Default Shop
        Inv.SetupShop(19);
    }
}