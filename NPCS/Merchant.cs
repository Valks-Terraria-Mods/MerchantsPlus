using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    /*shop.item[nextSlot++].SetDefaults(ItemID.DepthMeter);
    shop.item[nextSlot++].SetDefaults(ItemID.Compass);
    shop.item[nextSlot++].SetDefaults(ItemID.MetalDetector);
    shop.item[nextSlot++].SetDefaults(ItemID.DPSMeter);
    shop.item[nextSlot++].SetDefaults(ItemID.Stopwatch);
    shop.item[nextSlot++].SetDefaults(ItemID.TallyCounter);
    shop.item[nextSlot++].SetDefaults(ItemID.LifeformAnalyzer);
    shop.item[nextSlot++].SetDefaults(ItemID.Radar);
    shop.item[nextSlot++].SetDefaults(ItemID.MagicQuiver);*/
    class Merchant : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.Merchant) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 0.8f;
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Merchant) return;
                chat = Utils.dialog(new string[] { "Hey. Buddy. I have to tell you a secret.. wait nvm. I'll catch you later." ,
                "Hey, did you hear? Were in a two dimensional world, why can't I sell three dimensional stuff! >:(",
                "Hey, need a general purpose item? I'm your guy."});
        }

        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type != NPCID.Merchant) return;
            shop.item[0].SetDefaults(ItemID.BugNet); //golden bug net
            shop.item[1].SetDefaults(ItemID.TinPickaxe);
            shop.item[2].SetDefaults(ItemID.TinAxe);
            shop.item[3].SetDefaults(ItemID.TinHammer);
            shop.item[4].SetDefaults(ItemID.TinHelmet);
            shop.item[5].SetDefaults(ItemID.TinChainmail);
            shop.item[6].SetDefaults(ItemID.TinGreaves);
            shop.item[7].SetDefaults(ItemID.LesserHealingPotion);
            shop.item[8].SetDefaults(ItemID.LesserManaPotion);
            shop.item[9].SetDefaults(ItemID.Torch);
            shop.item[10].SetDefaults(ItemID.WoodenArrow);
            shop.item[11].SetDefaults(ItemID.Snowball);
            shop.item[12].SetDefaults(ItemID.Rope);
            shop.item[13].SetDefaults(ItemID.Sickle);
            shop.item[14].SetDefaults(ItemID.IronAnvil);
            shop.item[15].SetDefaults(ItemID.PiggyBank);
            shop.item[16].SetDefaults(ItemID.Safe);
            shop.item[17].SetDefaults(ItemID.FairyBell);
            shop.item[18].SetDefaults(ItemID.DogWhistle);
            shop.item[18].shopCustomPrice = 100000;
            shop.item[19].SetDefaults(ItemID.UnluckyYarn);
            shop.item[19].shopCustomPrice = 100000;

            if (NPC.downedSlimeKing) {
                shop.item[1].SetDefaults(ItemID.IronPickaxe);
                shop.item[2].SetDefaults(ItemID.IronAxe);
                shop.item[3].SetDefaults(ItemID.IronHammer);
                shop.item[4].SetDefaults(ItemID.IronHelmet);
                shop.item[5].SetDefaults(ItemID.IronChainmail);
                shop.item[6].SetDefaults(ItemID.IronGreaves);
                shop.item[10].SetDefaults(ItemID.BoneArrow);
                shop.item[11].SetDefaults(ItemID.Shuriken);
            }
            if (NPC.downedBoss1) {
                shop.item[1].SetDefaults(ItemID.SilverPickaxe);
                shop.item[2].SetDefaults(ItemID.SilverAxe);
                shop.item[3].SetDefaults(ItemID.SilverHammer);
                shop.item[4].SetDefaults(ItemID.SilverHelmet);
                shop.item[5].SetDefaults(ItemID.SilverChainmail);
                shop.item[6].SetDefaults(ItemID.SilverGreaves);
                shop.item[7].SetDefaults(ItemID.HealingPotion);
                shop.item[8].SetDefaults(ItemID.ManaPotion);
                shop.item[10].SetDefaults(ItemID.FlamingArrow);
                shop.item[11].SetDefaults(ItemID.ThrowingKnife);
            }
            if (NPC.downedBoss2) {
                shop.item[1].SetDefaults(ItemID.GoldPickaxe);
                shop.item[2].SetDefaults(ItemID.GoldAxe);
                shop.item[3].SetDefaults(ItemID.GoldHammer);
                shop.item[4].SetDefaults(ItemID.GoldHelmet);
                shop.item[5].SetDefaults(ItemID.GoldChainmail);
                shop.item[6].SetDefaults(ItemID.GoldGreaves);
                shop.item[10].SetDefaults(ItemID.FrostburnArrow);
                shop.item[11].SetDefaults(ItemID.BoneDagger);
            }
            if (NPC.downedBoss3) {
                shop.item[1].SetDefaults(ItemID.NightmarePickaxe);
                shop.item[2].SetDefaults(ItemID.WarAxeoftheNight);
                shop.item[3].SetDefaults(ItemID.TheBreaker);
                switch (Utils.getPlayerClass()) {
                    case "melee":
                        shop.item[4].SetDefaults(ItemID.ShadowHelmet);
                        shop.item[5].SetDefaults(ItemID.ShadowScalemail);
                        shop.item[6].SetDefaults(ItemID.ShadowGreaves);
                        break;
                    case "ranged":
                        shop.item[4].SetDefaults(ItemID.NecroHelmet);
                        shop.item[5].SetDefaults(ItemID.NecroBreastplate);
                        shop.item[6].SetDefaults(ItemID.NecroGreaves);
                        break;
                    case "mage":
                        shop.item[4].SetDefaults(ItemID.JungleHat);
                        shop.item[5].SetDefaults(ItemID.JungleShirt);
                        shop.item[6].SetDefaults(ItemID.JunglePants);
                        break;
                    case "summoner":
                        shop.item[4].SetDefaults(ItemID.BeeHeadgear);
                        shop.item[5].SetDefaults(ItemID.BeeBreastplate);
                        shop.item[6].SetDefaults(ItemID.BeeGreaves);
                        break;
                }
                
                shop.item[9].SetDefaults(ItemID.BoneTorch);
                shop.item[10].SetDefaults(ItemID.JestersArrow);
                shop.item[11].SetDefaults(ItemID.PoisonedKnife);
                shop.item[12].SetDefaults(ItemID.Chain);
            }
            if (Main.hardMode) {
                shop.item[1].SetDefaults(ItemID.MoltenPickaxe);
                shop.item[2].SetDefaults(ItemID.MoltenHamaxe);
                shop.item[3].SetDefaults(ItemID.Rockfish);
                shop.item[4].SetDefaults(ItemID.MoltenHelmet);
                shop.item[5].SetDefaults(ItemID.MoltenBreastplate);
                shop.item[6].SetDefaults(ItemID.MoltenGreaves);
                shop.item[7].SetDefaults(ItemID.GreaterHealingPotion);
                shop.item[8].SetDefaults(ItemID.GreaterManaPotion);
                shop.item[9].SetDefaults(ItemID.UltrabrightTorch);
                shop.item[10].SetDefaults(ItemID.UnholyArrow);
                shop.item[11].SetDefaults(ItemID.Javelin);
                shop.item[17].SetDefaults(ItemID.WispinaBottle);
            }
            if (Utils.downedMechBosses() == 1) {
                shop.item[1].SetDefaults(ItemID.CobaltPickaxe);
                shop.item[2].SetDefaults(ItemID.CobaltWaraxe);
                shop.item[4].SetDefaults(ItemID.CobaltHelmet);
                shop.item[5].SetDefaults(ItemID.CobaltBreastplate);
                shop.item[6].SetDefaults(ItemID.CobaltLeggings);
                shop.item[10].SetDefaults(ItemID.HolyArrow);
                shop.item[11].SetDefaults(ItemID.BoneJavelin);
            }
            if (Utils.downedMechBosses() == 2) {
                shop.item[1].SetDefaults(ItemID.MythrilPickaxe);
                shop.item[2].SetDefaults(ItemID.MythrilWaraxe);
                shop.item[4].SetDefaults(ItemID.MythrilHelmet);
                shop.item[5].SetDefaults(ItemID.MythrilChainmail);
                shop.item[6].SetDefaults(ItemID.MythrilGreaves);
                shop.item[10].SetDefaults(ItemID.IchorArrow);
                shop.item[14].SetDefaults(ItemID.MythrilAnvil);
            }
            if (Utils.downedMechBosses() == 3) {
                shop.item[1].SetDefaults(ItemID.TitaniumPickaxe);
                shop.item[2].SetDefaults(ItemID.TitaniumWaraxe);
                shop.item[3].SetDefaults(ItemID.Hammush);
                shop.item[4].SetDefaults(ItemID.TitaniumHelmet);
                shop.item[5].SetDefaults(ItemID.TitaniumBreastplate);
                shop.item[6].SetDefaults(ItemID.TitaniumLeggings);
                shop.item[10].SetDefaults(ItemID.CursedArrow);
            }
            if (NPC.downedPlantBoss) {
                shop.item[1].SetDefaults(ItemID.ChlorophytePickaxe);
                shop.item[2].SetDefaults(ItemID.ChlorophyteGreataxe);
                shop.item[3].SetDefaults(ItemID.ChlorophyteJackhammer);
                shop.item[4].SetDefaults(ItemID.ChlorophyteHelmet);
                shop.item[5].SetDefaults(ItemID.ChlorophytePlateMail);
                shop.item[6].SetDefaults(ItemID.ChlorophyteGreaves);
                shop.item[10].SetDefaults(ItemID.ChlorophyteArrow);
            }
            if (NPC.downedGolemBoss) {
                shop.item[1].SetDefaults(ItemID.Picksaw);
                shop.item[2].SetDefaults(ItemID.ShroomiteDiggingClaw);
            }
            if (NPC.downedMoonlord) {
                shop.item[1].SetDefaults(ItemID.NebulaPickaxe);
                shop.item[2].SetDefaults(ItemID.NebulaAxe);
                shop.item[3].SetDefaults(ItemID.NebulaHammer);
                shop.item[4].SetDefaults(ItemID.NebulaHelmet);
                shop.item[5].SetDefaults(ItemID.NebulaBreastplate);
                shop.item[6].SetDefaults(ItemID.NebulaLeggings);
                shop.item[7].SetDefaults(ItemID.SuperHealingPotion);
                shop.item[8].SetDefaults(ItemID.SuperManaPotion);
                shop.item[10].SetDefaults(ItemID.MoonlordArrow);
            }
        }
    }
}
