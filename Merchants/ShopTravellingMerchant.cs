using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Merchants
{
    internal class ShopTravellingMerchant : Shop
    {
        public ShopTravellingMerchant(bool merchant, params string[] shops) : base(merchant, shops)
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
}