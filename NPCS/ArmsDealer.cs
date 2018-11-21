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
            if (npc.type == NPCID.ArmsDealer) { // Make sure we are only editing the arms dealer npc.
                npc.lifeMax = 500; // Set the max life to 500
            }
        }
        
        /*
         * Unique dialog for the arms dealer.
         */
        public override void GetChat(NPC npc, ref string chat) {
            if (npc.type == NPCID.ArmsDealer) { // Make sure we are only editing the arms dealer npc.
                switch (Main.rand.Next(13)) // The number must match how much dialog we have.
                {
                    case 0:
                        chat = "GET UR EEPIC GUNS NOW";
                        break;
                    case 1:
                        chat = "EPIC GUNS FER SALE BRUH";
                        break;
                    case 2:
                        chat = "IM 5 YEARS OLD DEAL WITH IT BRAH";
                        break;
                    case 3:
                        chat = "YOU NEED A GUN BRAH?";
                        break;
                    case 4:
                        chat = "GET YA GUNS TODAY BRAH";
                        break;
                    case 5:
                        chat = "GUNS FOR SALE BRAH!";
                        break;
                    case 6:
                        chat = Utils.dialogGift(npc, "TAKE THIS GUN BRAH", "BRAH", true, 5, ItemID.FlintlockPistol, 10);
                        break;
                    case 7:
                        chat = "BRAH YOU GONNA' BUY SOMETIN OR WHAT";
                        break;
                    case 8:
                        chat = "BRAH I DON'T GOT ALL DAY";
                        break;
                    case 9:
                        chat = "EPIC GUNS BRAH";
                        break;
                    case 10:
                        chat = "BRAH IT LOOKS LIKE YOU NEED A GUN!";
                        break;
                    case 11:
                        if (Utils.isNPCHere(NPCID.Pirate))
                        {
                            chat = "TELL YE PIRATE DUDE TO STOP SHOOTIN' CANNON BALLS AT ME";
                        }
                        else { 
                            chat = "WONDER WHERE THAT PIRATE DUDE IS AT, HE OWES MEH GUNNNZZ";
                        }
                        break;
                    default:
                        chat = "NEED A GUN BRAH?";
                        break;
                }
            }
        }

        /*
         * Here we modify what the shop looks like for the arms dealer.
         */
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.ArmsDealer) // Make sure we are only editing the arms dealer npc.
            {
                if (!Main.hardMode) { // If not in hardmode.
                    if (NPC.downedSlimeKing) // If the slime king was killed.
                    {
                        shop.item[0].SetDefaults(ItemID.SilverBullet); // Replace default bullets with silver bullets
                        shop.item[1].SetDefaults(ItemID.TheUndertaker); // Replace default flintlock pistol with the undertaker
                        shop.item[nextSlot++].SetDefaults(ItemID.RedRyder); // Add red ryder as an additional item to the shop
                    }

                    if (NPC.downedBoss1) // If the eye of cthulu was killed
                    {
                        shop.item[0].SetDefaults(ItemID.MeteorShot); // Replace silver bullets with meteor bullets
                        shop.item[1].SetDefaults(ItemID.Revolver); // Replace undertaker with revolver
                        shop.item[nextSlot++].SetDefaults(ItemID.Boomstick); // Add boom stick as an additional item to the shop
                    }

                    if (NPC.downedBoss2) // If the eater of worlds or the brain of cthulu was killed
                    {
                        shop.item[0].SetDefaults(ItemID.CrystalBullet); // Replace meteor bullets with crystal bullets
                        shop.item[1].SetDefaults(ItemID.Handgun); // Replace revolver with handgun
                        shop.item[nextSlot++].SetDefaults(ItemID.Musket); // Add musket as an additional item to the shop
                    }

                    if (NPC.downedQueenBee) // If the queen bee was killed
                    {
                        shop.item[0].SetDefaults(ItemID.GoldenBullet);
                        shop.item[1].SetDefaults(ItemID.PhoenixBlaster);
                    }

                    if (NPC.downedBoss3)
                    { // Skeletron
                        shop.item[0].SetDefaults(ItemID.ExplodingBullet);
                        shop.item[nextSlot++].SetDefaults(ItemID.ClockworkAssaultRifle);
                        shop.item[nextSlot++].SetDefaults(ItemID.OnyxBlaster);
                    }
                }

                if (Main.hardMode) {
                    shop.item[0].SetDefaults(ItemID.NanoBullet);
                    shop.item[1].SetDefaults(ItemID.OnyxBlaster);
                    shop.item[2].SetDefaults(ItemID.HellfireArrow);
                    shop.item[3].SetDefaults(ItemID.Uzi);
                    shop.item[4].SetDefaults(ItemID.ClockworkAssaultRifle);

                    if (NPC.downedMechBossAny)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.Gatligator);
                        shop.item[0].SetDefaults(ItemID.HighVelocityBullet);
                        shop.item[2].SetDefaults(ItemID.HolyArrow);
                    }

                    if (NPC.downedMechBoss1)
                    {
                        shop.item[0].SetDefaults(ItemID.IchorBullet);
                        shop.item[2].SetDefaults(ItemID.IchorArrow);
                    }

                    if (NPC.downedMechBoss2)
                    {
                        shop.item[0].SetDefaults(ItemID.CursedBullet);
                        shop.item[2].SetDefaults(ItemID.CursedArrow);
                    }

                    if (NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3)
                    {
                        shop.item[0].SetDefaults(ItemID.VenomBullet);
                        shop.item[2].SetDefaults(ItemID.VenomArrow);
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
                        shop.item[2].SetDefaults(ItemID.ChlorophyteArrow);
                        shop.item[4].SetDefaults(ItemID.VortexBeater);
                    }

                    if (NPC.downedGolemBoss)
                    {
                        shop.item[4].SetDefaults(ItemID.SDMG);
                    }

                    if (NPC.downedFishron)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.CandyCornRifle);
                        shop.item[0].SetDefaults(ItemID.MoonlordBullet);
                        shop.item[2].SetDefaults(ItemID.MoonlordArrow);
                    }
                }

                if (Main.npc[NPCID.Dryad].UsesPartyHat()) {
                    shop.item[0].SetDefaults(ItemID.PartyBullet);
                }
            }
        }
    }
}
