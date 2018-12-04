using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    class ShopPirate
    {
        private Chest shop;
        private int nextSlot;

        public ShopPirate(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            switch (currentShop)
            {
                case "Potions":
                    shop.item[nextSlot].SetDefaults(ItemID.TrapsightPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.HunterPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.InfernoPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    break;
                case "Arrr":
                    shop.item[nextSlot++].SetDefaults(ItemID.Sail);
                    shop.item[nextSlot++].SetDefaults(ItemID.ParrotCracker);
                    shop.item[nextSlot++].SetDefaults(ItemID.BunnyCannon);
                    shop.item[nextSlot++].SetDefaults(ItemID.RangerEmblem);
                    shop.item[nextSlot++].SetDefaults(ItemID.SorcererEmblem);
                    shop.item[nextSlot++].SetDefaults(ItemID.SummonerEmblem);
                    shop.item[nextSlot++].SetDefaults(ItemID.WarriorEmblem);
                    break;
                default:
                    shop.SetupShop(17);
                    break;
            }
        }
    }
}
