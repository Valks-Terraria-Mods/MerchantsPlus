using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class ArmsDealer : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.ArmsDealer) {
                npc.lifeMax = 500;
            }
        }

        public override void GetChat(NPC npc, ref string chat) {
            if (npc.type == NPCID.ArmsDealer) {
                switch (Main.rand.Next(3))
                {
                    case 0:
                        chat = "GET UR EEPIC GUNS NOW";
                        break;
                    case 1:
                        chat = "EPIC GUNS FER SALE BRUH";
                        break;
                    default:
                        chat = "NEED A GUN BRO?";
                        break;
                }
            }
        }

        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.ArmsDealer)
            {
                if (!Main.hardMode) {
                    if (NPC.downedSlimeKing)
                    {
                        shop.item[0].SetDefaults(ItemID.SilverBullet); // Replace default bullets
                        shop.item[1].SetDefaults(ItemID.TheUndertaker); // Replace default flintlock pistol
                        shop.item[nextSlot++].SetDefaults(ItemID.RedRyder);
                    }

                    if (NPC.downedBoss1)
                    { // EoC
                        shop.item[0].SetDefaults(ItemID.MeteorShot);
                        shop.item[1].SetDefaults(ItemID.Revolver);
                        shop.item[nextSlot++].SetDefaults(ItemID.Boomstick);
                    }

                    if (NPC.downedBoss2)
                    { // Worm / Brain
                        shop.item[0].SetDefaults(ItemID.CrystalBullet);
                        shop.item[1].SetDefaults(ItemID.Handgun);
                        shop.item[nextSlot++].SetDefaults(ItemID.Musket);
                        shop.item[nextSlot++].SetDefaults(ItemID.MeteorShot);
                    }

                    if (NPC.downedQueenBee)
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
