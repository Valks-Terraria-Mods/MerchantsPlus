using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    internal class ShopSantaClaus
    {
        private Chest shop;
        private int nextSlot;

        public ShopSantaClaus(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            switch (currentShop)
            {
                case "Potions":
                    shop.item[nextSlot].SetDefaults(ItemID.InvisibilityPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.GenderChangePotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.RecallPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.TeleportationPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.WormholePotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    break;

                case "Lights":
                    shop.item[nextSlot++].SetDefaults(ItemID.RedLight);
                    shop.item[nextSlot++].SetDefaults(ItemID.GreenLight);
                    shop.item[nextSlot++].SetDefaults(ItemID.BlueLight);
                    shop.item[nextSlot++].SetDefaults(ItemID.StarTopper1);
                    shop.item[nextSlot++].SetDefaults(ItemID.StarTopper2);
                    shop.item[nextSlot++].SetDefaults(ItemID.StarTopper3);
                    shop.item[nextSlot++].SetDefaults(ItemID.MulticoloredLights);
                    shop.item[nextSlot++].SetDefaults(ItemID.RedLights);
                    shop.item[nextSlot++].SetDefaults(ItemID.GreenLights);
                    shop.item[nextSlot++].SetDefaults(ItemID.BlueLights);
                    shop.item[nextSlot++].SetDefaults(ItemID.YellowLights);
                    shop.item[nextSlot++].SetDefaults(ItemID.RedAndYellowLights);
                    shop.item[nextSlot++].SetDefaults(ItemID.RedAndGreenLights);
                    shop.item[nextSlot++].SetDefaults(ItemID.YellowAndGreenLights);
                    shop.item[nextSlot++].SetDefaults(ItemID.BlueAndGreenLights);
                    shop.item[nextSlot++].SetDefaults(ItemID.RedAndBlueLights);
                    shop.item[nextSlot++].SetDefaults(ItemID.BlueAndYellowLights);
                    break;

                case "Bulbs":
                    shop.item[nextSlot++].SetDefaults(ItemID.RedBulb);
                    shop.item[nextSlot++].SetDefaults(ItemID.YellowBulb);
                    shop.item[nextSlot++].SetDefaults(ItemID.RedAndGreenBulb);
                    shop.item[nextSlot++].SetDefaults(ItemID.YellowAndGreenBulb);
                    shop.item[nextSlot++].SetDefaults(ItemID.RedAndYellowBulb);
                    shop.item[nextSlot++].SetDefaults(ItemID.WhiteBulb);
                    shop.item[nextSlot++].SetDefaults(ItemID.WhiteAndRedBulb);
                    shop.item[nextSlot++].SetDefaults(ItemID.WhiteAndYellowBulb);
                    shop.item[nextSlot++].SetDefaults(ItemID.WhiteAndGreenBulb);
                    break;

                case "Decor":
                    shop.item[nextSlot++].SetDefaults(ItemID.ChristmasTree);
                    shop.item[nextSlot++].SetDefaults(ItemID.BowTopper);
                    shop.item[nextSlot++].SetDefaults(ItemID.WhiteGarland);
                    shop.item[nextSlot++].SetDefaults(ItemID.WhiteAndRedGarland);
                    shop.item[nextSlot++].SetDefaults(ItemID.RedGardland);
                    shop.item[nextSlot++].SetDefaults(ItemID.GreenGardland);
                    shop.item[nextSlot++].SetDefaults(ItemID.GreenAndWhiteGarland);
                    shop.item[nextSlot++].SetDefaults(ItemID.MulticoloredBulb);
                    break;

                default:
                    shop.SetupShop(9);
                    break;
            }
        }
    }
}