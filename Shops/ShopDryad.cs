using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    class ShopDryad
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
            switch (currentShop)
            {
                case "Msc":
                    shop.item[nextSlot].SetDefaults(ItemID.CalmingPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.FeatherfallPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    break;
                case "Seeds":
                    shop.item[nextSlot++].SetDefaults(ItemID.CorruptSeeds);
                    shop.item[nextSlot++].SetDefaults(ItemID.HallowedSeeds);
                    shop.item[nextSlot++].SetDefaults(ItemID.GrassSeeds);
                    shop.item[nextSlot++].SetDefaults(ItemID.MushroomGrassSeeds);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrimsonSeeds);
                    shop.item[nextSlot++].SetDefaults(ItemID.BlinkrootSeeds);
                    shop.item[nextSlot++].SetDefaults(ItemID.DaybloomSeeds);
                    shop.item[nextSlot++].SetDefaults(ItemID.DeathweedSeeds);
                    shop.item[nextSlot++].SetDefaults(ItemID.FireblossomSeeds);
                    shop.item[nextSlot++].SetDefaults(ItemID.MoonglowSeeds);
                    shop.item[nextSlot++].SetDefaults(ItemID.WaterleafSeeds);
                    shop.item[nextSlot++].SetDefaults(ItemID.ShiverthornSeeds);
                    break;
                default:
                    shop.SetupShop(3);
                    break;
            }
        }
    }
}
