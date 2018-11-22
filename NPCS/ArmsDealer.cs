using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class ArmsDealer : GlobalNPC
    {
        /*
         * Set the defaults for the arms dealer.
         */
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.ArmsDealer) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500; // Set the max life to 500
            if (Config.merchantScaling) npc.scale = 0.7f;
        }

        public override void NPCLoot(NPC npc)
        {
            Utils.dropItem(npc, NPCID.ArmsDealer, new short[] { ItemID.HiTekSunglasses }, 25);
        }

        public override void TownNPCAttackCooldown(NPC npc, ref int cooldown, ref int randExtraCooldown)
        {
            if (npc.type != NPCID.ArmsDealer) return;
            cooldown = 0;
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.ArmsDealer) return;
            projType = ProjectileID.Bullet;
            if (NPC.downedSlimeKing)
            {
                projType = ProjectileID.GoldenBullet;
            }
            if (NPC.downedBoss2)
            {
                projType = ProjectileID.MeteorShot;
            }
            if (NPC.downedMechBoss1)
            {
                projType = ProjectileID.CursedBullet;
            }
            if (NPC.downedMechBoss2)
            {
                projType = ProjectileID.IchorBullet;
            }
            if (NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3)
            {
                projType = ProjectileID.CrystalBullet;
            }
            if (NPC.downedPlantBoss)
            {
                projType = ProjectileID.ChlorophyteBullet;
            }
            if (NPC.downedMoonlord)
            {
                projType = ProjectileID.MoonlordBullet;
            }
        }

        /*
         * Unique dialog for the arms dealer.
         */
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.ArmsDealer) return;
            chat = Utils.dialog(new string[] { "GET UR EEPIC GUNS NOW",
                "EPIC GUNS FER SALE BRUH",
                "IM 5 YEARS OLD DEAL WITH IT BRAH",
                "YOU NEED A GUN BRAH?",
                "GET YA GUNS TODAY BRAH",
                "GUNS FOR SALE BRAH!",
                Utils.dialogGift(npc, "TAKE THIS GUN BRAH", "BRAH", true, 5, ItemID.FlintlockPistol, 10),
                "BRAH YOU GONNA' BUY SOMETIN OR WHAT",
                "BRAH I DON'T GOT ALL DAY",
                "EPIC GUNS BRAH",
                "BRAH IT LOOKS LIKE YOU NEED A GUN!",
                "NEED A GUN BRAH?",
                Utils.isNPCHere(NPCID.Pirate) ? "TELL YE PIRATE DUDE TO STOP SHOOTIN' CANNON BALLS AT ME" : "WONDER WHERE THAT PIRATE DUDE IS AT, HE OWES MEH GUNNNZZ"});
        }

        /*
         * Here we modify what the shop looks like for the arms dealer.
         */
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type != NPCID.ArmsDealer) return;
            if (!Main.hardMode)
            { // If not in hardmode.
                if (NPC.downedSlimeKing) // If the slime king was killed.
                {

                    shop.item[1].SetDefaults(ItemID.TheUndertaker); // Replace default flintlock pistol with the undertaker
                    shop.item[nextSlot++].SetDefaults(ItemID.RedRyder); // Add red ryder as an additional item to the shop
                }

                if (NPC.downedBoss1) // If the eye of cthulu was killed
                {
                    shop.item[0].SetDefaults(ItemID.SilverBullet);
                    shop.item[1].SetDefaults(ItemID.Revolver); // Replace undertaker with revolver
                    shop.item[nextSlot++].SetDefaults(ItemID.Boomstick); // Add boom stick as an additional item to the shop
                }

                if (NPC.downedBoss2) // If the eater of worlds or the brain of cthulu was killed
                {
                    shop.item[0].SetDefaults(ItemID.MeteorShot);
                    shop.item[1].SetDefaults(ItemID.Handgun); // Replace revolver with handgun
                    shop.item[nextSlot++].SetDefaults(ItemID.Musket); // Add musket as an additional item to the shop
                }

                if (NPC.downedQueenBee) // If the queen bee was killed
                {
                    shop.item[1].SetDefaults(ItemID.PhoenixBlaster); // Replace handgun with phoenix blaster
                }

                if (NPC.downedBoss3) // If skeletron was killed
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.ClockworkAssaultRifle); // Add a rifle
                    shop.item[nextSlot++].SetDefaults(ItemID.OnyxBlaster); // Add a rifle
                }
            }

            if (Main.hardMode)
            { // If in hardmode
                shop.item[0].SetDefaults(ItemID.MeteorShot);
                shop.item[1].SetDefaults(ItemID.GoldenBullet);
                shop.item[2].SetDefaults(ItemID.PartyBullet);
                shop.item[3].SetDefaults(ItemID.Uzi); // Pistol slot
                shop.item[4].SetDefaults(ItemID.ClockworkAssaultRifle); // Replace with rifle
                shop.item[nextSlot++].SetDefaults(ItemID.OnyxBlaster);

                if (NPC.downedMechBossAny) // If any mech boss was killed
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.Gatligator);
                }

                if (Utils.downedMechBosses() == 1)
                {
                    shop.item[0].SetDefaults(ItemID.CursedBullet);
                    shop.item[1].SetDefaults(ItemID.NanoBullet);
                }

                if (Utils.downedMechBosses() == 2)
                {
                    shop.item[0].SetDefaults(ItemID.IchorBullet);
                    shop.item[1].SetDefaults(ItemID.HighVelocityBullet);
                }

                if (Utils.downedMechBosses() == 3)
                {
                    shop.item[0].SetDefaults(ItemID.CrystalBullet);
                    shop.item[1].SetDefaults(ItemID.VenomBullet);
                    shop.item[3].SetDefaults(ItemID.VenusMagnum);
                    shop.item[4].SetDefaults(ItemID.Megashark);
                    shop.item[5].SetDefaults(ItemID.TacticalShotgun);
                    shop.item[nextSlot++].SetDefaults(ItemID.SniperRifle);
                    shop.item[nextSlot++].SetDefaults(ItemID.RifleScope);
                    shop.item[nextSlot++].SetDefaults(ItemID.Xenopopper);
                    shop.item[nextSlot++].SetDefaults(ItemID.ChainGun);
                }

                if (NPC.downedPlantBoss)
                {
                    shop.item[0].SetDefaults(ItemID.ChlorophyteBullet);
                    shop.item[4].SetDefaults(ItemID.VortexBeater);
                }

                if (NPC.downedGolemBoss)
                {

                }

                if (NPC.downedFishron)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.CandyCornRifle);
                }

                if (NPC.downedMoonlord)
                {
                    shop.item[0].SetDefaults(ItemID.MoonlordBullet);
                    shop.item[nextSlot++].SetDefaults(ItemID.SDMG);
                }
            }
        }
    }
}
