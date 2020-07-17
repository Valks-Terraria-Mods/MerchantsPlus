using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    internal class ShopDryad
    {
        private Chest shop;
        private int nextSlot;

        public ShopDryad(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            if (currentShop == "Potions") {
                shop.item[nextSlot].SetDefaults(ItemID.CalmingPotion);
                shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                shop.item[nextSlot].SetDefaults(ItemID.FeatherfallPotion);
                shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                return;
            }

            if (currentShop == "Seeds") {
                shop.item[nextSlot++].SetDefaults(ItemID.GrassSeeds);
                shop.item[nextSlot++].SetDefaults(ItemID.CorruptSeeds);
                shop.item[nextSlot++].SetDefaults(ItemID.HallowedSeeds);
                shop.item[nextSlot++].SetDefaults(ItemID.MushroomGrassSeeds);
                shop.item[nextSlot++].SetDefaults(ItemID.CrimsonSeeds);
                shop.item[nextSlot++].SetDefaults(ItemID.BlinkrootSeeds);
                shop.item[nextSlot++].SetDefaults(ItemID.DaybloomSeeds);
                shop.item[nextSlot++].SetDefaults(ItemID.DeathweedSeeds);
                shop.item[nextSlot++].SetDefaults(ItemID.FireblossomSeeds);
                shop.item[nextSlot++].SetDefaults(ItemID.MoonglowSeeds);
                shop.item[nextSlot++].SetDefaults(ItemID.WaterleafSeeds);
                shop.item[nextSlot++].SetDefaults(ItemID.ShiverthornSeeds);
                return;
            }

            // Default Shop
            shop.SetupShop(3);
        }
    }
}