using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    class ShopNurse
    {
        private Chest shop;
        private int nextSlot;

        public ShopNurse(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            switch (currentShop)
            {
                case "Potions":
                    shop.item[nextSlot].SetDefaults(ItemID.EndurancePotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.IronskinPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.LifeforcePotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.RegenerationPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.HeartreachPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    break;
                default:
                    shop.item[nextSlot].SetDefaults(ItemID.LifeCrystal);
                    shop.item[nextSlot++].shopCustomPrice = 250000;
                    if (Main.hardMode)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.LifeFruit);
                        shop.item[nextSlot++].shopCustomPrice = 1000000;
                    }
                    shop.item[nextSlot].SetDefaults(ItemID.HeartLantern);
                    shop.item[nextSlot++].shopCustomPrice = 100000;
                    break;
            }
        }
    }
}
