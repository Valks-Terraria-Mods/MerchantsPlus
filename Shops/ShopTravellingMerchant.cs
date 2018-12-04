using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    class ShopTravellingMerchant
    {
        private Chest shop;
        private int nextSlot;

        public ShopTravellingMerchant(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            switch (currentShop) {
                case "Gear":
                    shop.item[nextSlot++].SetDefaults(ItemID.ShadowOrb);
                    shop.item[nextSlot++].SetDefaults(ItemID.MagicLantern);
                    shop.item[nextSlot++].SetDefaults(ItemID.DD2PetGhost);
                    if (Main.hardMode) shop.item[nextSlot++].SetDefaults(ItemID.SuspiciousLookingTentacle);
                    break;
                default:
                    shop.SetupShop(19);
                    break;
            }
            
        }
    }
}
