using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    internal class ShopCyborg
    {
        private Chest shop;
        private int nextSlot;

        public ShopCyborg(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            if (currentShop == "Buffs")
            {
                shop.item[nextSlot].SetDefaults(ItemID.GravitationPotion);
                shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                shop.item[nextSlot].SetDefaults(ItemID.SwiftnessPotion);
                shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                shop.item[nextSlot].SetDefaults(ItemID.ThornsPotion);
                shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                shop.item[nextSlot].SetDefaults(ItemID.TitanPotion);
                shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                shop.item[nextSlot].SetDefaults(ItemID.WarmthPotion);
                shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                shop.item[nextSlot].SetDefaults(ItemID.WrathPotion);
                shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                return;
            }

            if (currentShop == "Robotics")
            {
                shop.item[nextSlot++].SetDefaults(ItemID.ProximityMineLauncher);
                shop.item[nextSlot++].SetDefaults(ItemID.Nanites);
                shop.item[nextSlot++].SetDefaults(ItemID.PortalGun);
                shop.item[nextSlot++].SetDefaults(ItemID.PortalGunStation);

                if (NPC.downedGolemBoss)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.ElectrosphereLauncher);
                }

                if (NPC.downedFishron)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.RocketLauncher);
                }

                if (NPC.downedAncientCultist)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.SnowmanCannon);
                }

                if (NPC.downedTowerVortex)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.NailGun);
                }
                return;
            }

            // Default Shop
            shop.SetupShop(14);
        }
    }
}