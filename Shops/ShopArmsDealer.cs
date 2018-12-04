using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.Shops
{
    class ShopArmsDealer
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
            switch (currentShop)
            {
                case "Msc":
                    if (NPC.downedPlantBoss)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.SniperRifle);
                        shop.item[nextSlot++].SetDefaults(ItemID.RifleScope);
                    }
                    if (Main.dayTime) shop.item[nextSlot++].SetDefaults(ItemID.IllegalGunParts);
                    if (Main.hardMode) shop.item[nextSlot++].SetDefaults(ItemID.EmptyBullet);
                    shop.item[nextSlot++].SetDefaults(ItemID.AmmoBox);
                    shop.item[nextSlot].SetDefaults(ItemID.AmmoReservationPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    break;
                case "Guns":
                    shopBulletMain(shop, ref nextSlot);
                    shopBulletOther(shop, ref nextSlot);
                    shopPistol(shop, ref nextSlot);
                    shopRifle(shop, ref nextSlot);
                    shopShotgun(shop, ref nextSlot);
                    break;
                default:
                    shop.SetupShop(2);
                    break;
            }
        }

        private void shopBulletMain(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.MusketBall);
            if (NPC.downedBoss1) shop.item[nextSlot].SetDefaults(ItemID.SilverBullet);
            if (NPC.downedBoss2) shop.item[nextSlot].SetDefaults(ItemID.MeteorShot);
            if (Utils.downedMechBosses() == 1) shop.item[nextSlot].SetDefaults(ItemID.CursedBullet);
            if (Utils.downedMechBosses() == 2) shop.item[nextSlot].SetDefaults(ItemID.IchorBullet);
            if (Utils.downedMechBosses() == 3) shop.item[nextSlot].SetDefaults(ItemID.CrystalBullet);
            if (NPC.downedPlantBoss) shop.item[nextSlot].SetDefaults(ItemID.ChlorophyteBullet);
            if (NPC.downedMoonlord) shop.item[nextSlot].SetDefaults(ItemID.MoonlordBullet);
            nextSlot++;
        }

        private void shopBulletOther(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.PartyBullet);
            shop.item[nextSlot].shopCustomPrice = 100;
            if (NPC.downedSlimeKing) shop.item[nextSlot].shopCustomPrice = 50;
            if (NPC.downedBoss1) shop.item[nextSlot].shopCustomPrice = 25;
            if (NPC.downedBoss2) shop.item[nextSlot].shopCustomPrice = 5;
            if (NPC.downedQueenBee) shop.item[nextSlot].shopCustomPrice = 1;
            if (NPC.downedBoss3) shop.item[nextSlot].SetDefaults(ItemID.ExplodingBullet);
            if (Utils.downedMechBosses() == 1) shop.item[nextSlot].SetDefaults(ItemID.GoldenBullet);
            if (Utils.downedMechBosses() == 2) shop.item[nextSlot].SetDefaults(ItemID.NanoBullet);
            if (Utils.downedMechBosses() == 3) shop.item[nextSlot].SetDefaults(ItemID.HighVelocityBullet);
            if (NPC.downedPlantBoss) shop.item[nextSlot].SetDefaults(ItemID.VenomBullet);
            nextSlot++;
        }

        private void shopPistol(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.FlintlockPistol);
            if (NPC.downedSlimeKing) shop.item[nextSlot].SetDefaults(ItemID.TheUndertaker);
            if (NPC.downedBoss1) shop.item[nextSlot].SetDefaults(ItemID.Revolver);
            if (NPC.downedBoss2) shop.item[nextSlot].SetDefaults(ItemID.Handgun);
            if (NPC.downedQueenBee) shop.item[nextSlot].SetDefaults(ItemID.PhoenixBlaster);
            if (Main.hardMode) shop.item[nextSlot].SetDefaults(ItemID.Uzi);
            if (Utils.downedMechBosses() == 3) shop.item[nextSlot].SetDefaults(ItemID.VenusMagnum);
            nextSlot++;
        }

        private void shopRifle(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.RedRyder);
            if (NPC.downedBoss1) shop.item[nextSlot].SetDefaults(ItemID.Musket);
            if (NPC.downedBoss2) shop.item[nextSlot].SetDefaults(ItemID.Minishark);
            if (Main.hardMode) shop.item[nextSlot].SetDefaults(ItemID.ClockworkAssaultRifle);
            if (Utils.downedMechBosses() == 1) shop.item[nextSlot].SetDefaults(ItemID.Gatligator);
            if (Utils.downedMechBosses() == 2) shop.item[nextSlot].SetDefaults(ItemID.Megashark);
            if (NPC.downedAncientCultist) shop.item[nextSlot].SetDefaults(ItemID.VortexBeater);
            if (NPC.downedMoonlord) shop.item[nextSlot].SetDefaults(ItemID.SDMG);
            nextSlot++;
        }

        private void shopShotgun(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.Boomstick);
            if (Main.hardMode) shop.item[nextSlot].SetDefaults(ItemID.Shotgun);
            if (Utils.downedMechBosses() == 1) shop.item[nextSlot].SetDefaults(ItemID.OnyxBlaster);
            if (NPC.downedPlantBoss) shop.item[nextSlot].SetDefaults(ItemID.TacticalShotgun);
            if ((NPC.downedFishron || NPC.downedMoonlord) && MerchantsPlus.overhaulLoaded)
            {
                Mod overhaul = ModLoader.GetMod("TerrariaOverhaul");
                shop.item[nextSlot].SetDefaults(overhaul.ItemType("SuperShotgun"));
            }
            nextSlot++;
        }
    }
}
