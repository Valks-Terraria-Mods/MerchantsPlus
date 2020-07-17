using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    internal class ShopArmsDealer
    {
        private Chest shop;
        private int nextSlot;

        public ShopArmsDealer(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            if (currentShop == "Msc")
            {
                if (NPC.downedPlantBoss)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.SniperRifle);
                    shop.item[nextSlot++].SetDefaults(ItemID.RifleScope);
                }
                if (!Main.dayTime) shop.item[nextSlot++].SetDefaults(ItemID.IllegalGunParts);
                if (Main.hardMode) shop.item[nextSlot++].SetDefaults(ItemID.EmptyBullet);
                shop.item[nextSlot++].SetDefaults(ItemID.AmmoBox);
                shop.item[nextSlot].SetDefaults(ItemID.AmmoReservationPotion);
                shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                return;
            }

            if (currentShop == "Guns")
            {
                ShopBulletMain(shop, ref nextSlot);
                ShopBulletOther(shop, ref nextSlot);
                ShopPistol(shop, ref nextSlot);
                ShopRifle(shop, ref nextSlot);
                ShopShotgun(shop, ref nextSlot);
                return;
            }

            // Default Shop
            shop.SetupShop(2);
        }

        private void ShopBulletMain(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.MusketBall);
            if (NPC.downedBoss1) shop.item[nextSlot].SetDefaults(ItemID.SilverBullet);
            if (NPC.downedBoss2) shop.item[nextSlot].SetDefaults(ItemID.MeteorShot);
            if (Utils.DownedMechBosses() == 1) shop.item[nextSlot].SetDefaults(ItemID.CursedBullet);
            if (Utils.DownedMechBosses() == 2) shop.item[nextSlot].SetDefaults(ItemID.IchorBullet);
            if (Utils.DownedMechBosses() == 3) shop.item[nextSlot].SetDefaults(ItemID.CrystalBullet);
            if (NPC.downedPlantBoss) shop.item[nextSlot].SetDefaults(ItemID.ChlorophyteBullet);
            if (NPC.downedMoonlord) shop.item[nextSlot].SetDefaults(ItemID.MoonlordBullet);
            nextSlot++;
        }

        private void ShopBulletOther(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.PartyBullet);
            shop.item[nextSlot].shopCustomPrice = Utils.Coins(0, 1);
            if (NPC.downedSlimeKing) shop.item[nextSlot].shopCustomPrice = Utils.Coins(50);
            if (NPC.downedBoss1) shop.item[nextSlot].shopCustomPrice = Utils.Coins(25);
            if (NPC.downedBoss2) shop.item[nextSlot].shopCustomPrice = Utils.Coins(5);
            if (NPC.downedQueenBee) shop.item[nextSlot].shopCustomPrice = Utils.Coins(1);
            if (NPC.downedBoss3) shop.item[nextSlot].SetDefaults(ItemID.ExplodingBullet);
            if (Utils.DownedMechBosses() == 1) shop.item[nextSlot].SetDefaults(ItemID.GoldenBullet);
            if (Utils.DownedMechBosses() == 2) shop.item[nextSlot].SetDefaults(ItemID.NanoBullet);
            if (Utils.DownedMechBosses() == 3) shop.item[nextSlot].SetDefaults(ItemID.HighVelocityBullet);
            if (NPC.downedPlantBoss) shop.item[nextSlot].SetDefaults(ItemID.VenomBullet);
            nextSlot++;
        }

        private void ShopPistol(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.FlintlockPistol);
            if (NPC.downedSlimeKing) shop.item[nextSlot].SetDefaults(ItemID.TheUndertaker);
            if (NPC.downedBoss1) shop.item[nextSlot].SetDefaults(ItemID.Revolver);
            if (NPC.downedBoss2) shop.item[nextSlot].SetDefaults(ItemID.Handgun);
            if (NPC.downedQueenBee) shop.item[nextSlot].SetDefaults(ItemID.PhoenixBlaster);
            if (Main.hardMode) shop.item[nextSlot].SetDefaults(ItemID.Uzi);
            if (Utils.DownedMechBosses() == 3) shop.item[nextSlot].SetDefaults(ItemID.VenusMagnum);
            nextSlot++;
        }

        private void ShopRifle(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.RedRyder);
            if (NPC.downedBoss1) shop.item[nextSlot].SetDefaults(ItemID.Musket);
            if (NPC.downedBoss2) shop.item[nextSlot].SetDefaults(ItemID.Minishark);
            if (Main.hardMode) shop.item[nextSlot].SetDefaults(ItemID.ClockworkAssaultRifle);
            if (Utils.DownedMechBosses() == 1) shop.item[nextSlot].SetDefaults(ItemID.Gatligator);
            if (Utils.DownedMechBosses() == 2) shop.item[nextSlot].SetDefaults(ItemID.Megashark);
            if (NPC.downedAncientCultist) shop.item[nextSlot].SetDefaults(ItemID.VortexBeater);
            if (NPC.downedMoonlord) shop.item[nextSlot].SetDefaults(ItemID.SDMG);
            nextSlot++;
        }

        private void ShopShotgun(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.Boomstick);
            if (Main.hardMode) shop.item[nextSlot].SetDefaults(ItemID.Shotgun);
            if (Utils.DownedMechBosses() == 1) shop.item[nextSlot].SetDefaults(ItemID.OnyxBlaster);
            if (NPC.downedPlantBoss) shop.item[nextSlot].SetDefaults(ItemID.TacticalShotgun);
            nextSlot++;
        }
    }
}