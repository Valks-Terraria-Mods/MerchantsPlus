using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class ArmsDealer : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.ArmsDealer)
            {
                if (NPC.downedSlimeKing) {
                    shop.item[nextSlot++].SetDefaults(ItemID.TheUndertaker);
                    shop.item[nextSlot++].SetDefaults(ItemID.RedRyder);
                    shop.item[nextSlot++].SetDefaults(ItemID.PartyBullet);
                }

                if (NPC.downedBoss1) { // EoC
                    shop.item[nextSlot++].SetDefaults(ItemID.Musket);
                    shop.item[nextSlot++].SetDefaults(ItemID.Revolver);
                    shop.item[nextSlot++].SetDefaults(ItemID.Boomstick);
                }

                if (NPC.downedBoss2) { // Worm / Brain
                    shop.item[nextSlot++].SetDefaults(ItemID.SpaceGun);
                    shop.item[nextSlot++].SetDefaults(ItemID.Handgun);
                    shop.item[nextSlot++].SetDefaults(ItemID.MeteorShot);
                }

                if (NPC.downedQueenBee)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.BeeGun);
                    shop.item[nextSlot++].SetDefaults(ItemID.PhoenixBlaster);
                    shop.item[nextSlot++].SetDefaults(ItemID.VenomBullet);
                }

                if (NPC.downedBoss3) { // Skeletron
                    shop.item[nextSlot++].SetDefaults(ItemID.ClockworkAssaultRifle);
                    shop.item[nextSlot++].SetDefaults(ItemID.OnyxBlaster);
                    shop.item[nextSlot++].SetDefaults(ItemID.CursedBullet);
                }

                if (Main.hardMode) {
                    shop.item[nextSlot++].SetDefaults(ItemID.Uzi);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrystalBullet);
                }

                if (NPC.downedMechBossAny) {
                    shop.item[nextSlot++].SetDefaults(ItemID.Gatligator);
                    shop.item[nextSlot++].SetDefaults(ItemID.ChlorophyteBullet);
                }

                if (NPC.downedFishron) {
                    shop.item[nextSlot++].SetDefaults(ItemID.CandyCornRifle);
                }

                if (NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3) {
                    shop.item[nextSlot++].SetDefaults(ItemID.Megashark);
                    shop.item[nextSlot++].SetDefaults(ItemID.VenusMagnum);
                    shop.item[nextSlot++].SetDefaults(ItemID.TacticalShotgun);
                    shop.item[nextSlot++].SetDefaults(ItemID.SniperRifle);
                    shop.item[nextSlot++].SetDefaults(ItemID.RifleScope);
                    shop.item[nextSlot++].SetDefaults(ItemID.Xenopopper);
                    shop.item[nextSlot++].SetDefaults(ItemID.ChainGun);
                }

                if (NPC.downedPlantBoss) {
                    shop.item[nextSlot++].SetDefaults(ItemID.VortexBeater);
                }

                if (NPC.downedGolemBoss) {
                    shop.item[nextSlot++].SetDefaults(ItemID.SDMG);
                }
            }
        }
    }
}
