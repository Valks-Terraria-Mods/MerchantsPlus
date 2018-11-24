using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
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

        public override void TownNPCAttackCooldown(NPC npc, ref int cooldown, ref int randExtraCooldown)
        {
            if (npc.type != NPCID.Merchant) return;
            cooldown = 0;
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Merchant) return;
            projType = ProjectileID.ThrowingKnife;
            if (NPC.downedBoss2)
            {
                projType = ProjectileID.PoisonedKnife;
            }
            if (Utils.downedMechBosses() == 1)
            {
                projType = ProjectileID.BoneJavelin;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Merchant) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "Hey. Buddy. I have to tell you a secret.. wait nvm. I'll catch you later." ,
                "Hey, did you hear? Were in a two dimensional world, why can't I sell three dimensional stuff! >:(",
                "Hey, need a general purpose item? I'm your guy."});
        }

        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type != NPCID.Merchant) return;

            const int SLOT_BUG_NET = 0;
            const int SLOT_PICK = 1;
            const int SLOT_AXE = 2;
            const int SLOT_HAMMER = 3;
            const int SLOT_HELMET = 4;
            const int SLOT_CHESTPLATE = 5;
            const int SLOT_GREAVES = 6;
            const int SLOT_POTION_HEAL = 7;
            const int SLOT_POTION_MANA = 8;
            const int SLOT_TORCH = 9;
            const int SLOT_ARROW = 10;
            const int SLOT_THROWING = 11;
            const int SLOT_ROPE = 12;
            const int SLOT_SICKLE = 13;
            const int SLOT_IRON_ANVIL = 14;
            const int SLOT_PIGGY_BANK = 15;
            const int SLOT_SAFE = 16;
            const int SLOT_LIGHT_PET = 17;
            const int SLOT_PET_1 = 18;
            const int SLOT_PET_2 = 19;
            const int SLOT_WEAPON = 20;
            const int SLOT_WOOD_1 = 21;
            const int SLOT_WOOD_2 = 22;
            const int SLOT_MOUNT_1 = 23;
            const int SLOT_MOUNT_2 = 24;
            const int SLOT_MOUNT_3 = 25;
            const int SLOT_MOUNT_4 = 26;
            const int SLOT_MOUNT_5 = 27;
            const int SLOT_MOUNT_6 = 28;
            const int SLOT_MOUNT_7 = 29;

            shop.item[SLOT_BUG_NET].SetDefaults(ItemID.BugNet);
            shop.item[SLOT_PICK].SetDefaults(ItemID.TinPickaxe);
            shop.item[SLOT_AXE].SetDefaults(ItemID.TinAxe);
            shop.item[SLOT_HAMMER].SetDefaults(ItemID.TinHammer);
            shop.item[SLOT_HELMET].SetDefaults(ItemID.TinHelmet);
            shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.TinChainmail);
            shop.item[SLOT_GREAVES].SetDefaults(ItemID.TinGreaves);
            shop.item[SLOT_POTION_HEAL].SetDefaults(ItemID.LesserHealingPotion);
            shop.item[SLOT_POTION_MANA].SetDefaults(ItemID.LesserManaPotion);
            shop.item[SLOT_TORCH].SetDefaults(ItemID.Torch);
            shop.item[SLOT_ARROW].SetDefaults(ItemID.WoodenArrow);
            shop.item[SLOT_THROWING].SetDefaults(ItemID.Snowball);
            shop.item[SLOT_ROPE].SetDefaults(ItemID.Rope);
            shop.item[SLOT_SICKLE].SetDefaults(ItemID.Sickle);
            shop.item[SLOT_IRON_ANVIL].SetDefaults(ItemID.IronAnvil);
            shop.item[SLOT_PIGGY_BANK].SetDefaults(ItemID.PiggyBank);
            shop.item[SLOT_SAFE].SetDefaults(ItemID.Safe);
            shop.item[SLOT_LIGHT_PET].SetDefaults(ItemID.FairyBell);
            shop.item[SLOT_PET_1].SetDefaults(ItemID.DogWhistle);
            shop.item[SLOT_PET_1].shopCustomPrice = 100000;
            shop.item[SLOT_PET_2].SetDefaults(ItemID.UnluckyYarn);
            shop.item[SLOT_PET_2].shopCustomPrice = 100000;
            shop.item[SLOT_WOOD_1].SetDefaults(ItemID.Wood);
            shop.item[SLOT_WOOD_1].shopCustomPrice = 100;
            shop.item[SLOT_MOUNT_2].SetDefaults(ItemID.FuzzyCarrot);

            switch (Utils.getPlayerClass()) {
                case "melee":
                    shop.item[SLOT_WEAPON].SetDefaults(ItemID.TinBroadsword);
                    break;
                case "ranged":
                    shop.item[SLOT_WEAPON].SetDefaults(ItemID.TinBow);
                    break;
                case "mage":
                    shop.item[SLOT_WEAPON].SetDefaults(ItemID.WandofSparking);
                    break;
                case "summoner":
                    shop.item[SLOT_WEAPON].SetDefaults(ItemID.SlimeStaff);
                    break;
            }

            if (NPC.downedSlimeKing) {
                shop.item[SLOT_PICK].SetDefaults(ItemID.IronPickaxe);
                shop.item[SLOT_AXE].SetDefaults(ItemID.IronAxe);
                shop.item[SLOT_HAMMER].SetDefaults(ItemID.IronHammer);
                shop.item[SLOT_HELMET].SetDefaults(ItemID.IronHelmet);
                shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.IronChainmail);
                shop.item[SLOT_GREAVES].SetDefaults(ItemID.IronGreaves);
                shop.item[SLOT_ARROW].SetDefaults(ItemID.BoneArrow);
                shop.item[SLOT_THROWING].SetDefaults(ItemID.Shuriken);
                shop.item[SLOT_WOOD_2].SetDefaults(ItemID.BorealWood);
                shop.item[SLOT_WOOD_2].shopCustomPrice = 300;
                if (Utils.kills(NPCID.KingSlime) >= 3) shop.item[SLOT_MOUNT_1].SetDefaults(ItemID.SlimySaddle);
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.IronBroadsword);
                        break;
                    case "ranged":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.IronBow);
                        break;
                    case "mage":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.AmethystStaff);
                        break;
                    case "summoner":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.SlimeStaff);
                        break;
                }
            }
            if (NPC.downedBoss1) {
                shop.item[SLOT_PICK].SetDefaults(ItemID.SilverPickaxe);
                shop.item[SLOT_AXE].SetDefaults(ItemID.SilverAxe);
                shop.item[SLOT_HAMMER].SetDefaults(ItemID.SilverHammer);
                shop.item[SLOT_HELMET].SetDefaults(ItemID.SilverHelmet);
                shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.SilverChainmail);
                shop.item[SLOT_GREAVES].SetDefaults(ItemID.SilverGreaves);
                shop.item[SLOT_POTION_HEAL].SetDefaults(ItemID.HealingPotion);
                shop.item[SLOT_POTION_MANA].SetDefaults(ItemID.ManaPotion);
                shop.item[SLOT_ARROW].SetDefaults(ItemID.FlamingArrow);
                shop.item[SLOT_THROWING].SetDefaults(ItemID.ThrowingKnife);
                shop.item[SLOT_WOOD_2].SetDefaults(ItemID.Ebonwood);
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.SilverBroadsword);
                        break;
                    case "ranged":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.SilverBow);
                        break;
                    case "mage":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.AmberStaff);
                        break;
                    case "summoner":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.SlimeStaff);
                        break;
                }
            }
            if (NPC.downedBoss2) {
                shop.item[SLOT_PICK].SetDefaults(ItemID.GoldPickaxe);
                shop.item[SLOT_AXE].SetDefaults(ItemID.GoldAxe);
                shop.item[SLOT_HAMMER].SetDefaults(ItemID.GoldHammer);
                shop.item[SLOT_HELMET].SetDefaults(ItemID.GoldHelmet);
                shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.GoldChainmail);
                shop.item[SLOT_GREAVES].SetDefaults(ItemID.GoldGreaves);
                shop.item[SLOT_ARROW].SetDefaults(ItemID.FrostburnArrow);
                shop.item[SLOT_THROWING].SetDefaults(ItemID.BoneDagger);
                shop.item[SLOT_WOOD_2].SetDefaults(ItemID.Shadewood);
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.GoldBroadsword);
                        break;
                    case "ranged":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.GoldBow);
                        break;
                    case "mage":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.SpaceGun);
                        break;
                    case "summoner":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.SlimeStaff);
                        break;
                }
            }
            if (NPC.downedQueenBee) {
                if (Utils.kills(NPCID.QueenBee) >= 3) shop.item[SLOT_MOUNT_1].SetDefaults(ItemID.HoneyedGoggles);
                shop.item[SLOT_WOOD_2].SetDefaults(ItemID.Pearlwood);
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.BeeKeeper);
                        break;
                    case "ranged":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.BeesKnees);
                        break;
                    case "mage":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.BeeGun);
                        break;
                    case "summoner":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.HornetStaff);
                        break;
                }
            }
            if (NPC.downedBoss3) {
                shop.item[SLOT_PICK].SetDefaults(ItemID.NightmarePickaxe);
                shop.item[SLOT_AXE].SetDefaults(ItemID.WarAxeoftheNight);
                shop.item[SLOT_HAMMER].SetDefaults(ItemID.TheBreaker);
                switch (Utils.getPlayerClass()) {
                    case "melee":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.ShadowHelmet);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.ShadowScalemail);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.ShadowGreaves);
                        break;
                    case "ranged":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.NecroHelmet);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.NecroBreastplate);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.NecroGreaves);
                        break;
                    case "mage":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.JungleHat);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.JungleShirt);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.JunglePants);
                        break;
                    case "summoner":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.BeeHeadgear);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.BeeBreastplate);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.BeeGreaves);
                        break;
                }
                
                shop.item[SLOT_TORCH].SetDefaults(ItemID.BoneTorch);
                shop.item[SLOT_ARROW].SetDefaults(ItemID.JestersArrow);
                shop.item[SLOT_THROWING].SetDefaults(ItemID.PoisonedKnife);
                shop.item[SLOT_ROPE].SetDefaults(ItemID.Chain);
                shop.item[SLOT_WOOD_2].SetDefaults(ItemID.RichMahogany);
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.Arkhalis);
                        break;
                    case "ranged":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.MoltenFury);
                        break;
                    case "mage":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.BookofSkulls);
                        break;
                    case "summoner":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.HornetStaff);
                        break;
                }
            }
            if (Main.hardMode) {
                shop.item[SLOT_BUG_NET].SetDefaults(ItemID.GoldenBugNet);
                shop.item[SLOT_PICK].SetDefaults(ItemID.MoltenPickaxe);
                shop.item[SLOT_AXE].SetDefaults(ItemID.MoltenHamaxe);
                shop.item[SLOT_HAMMER].SetDefaults(ItemID.Rockfish);
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.MoltenHelmet);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.MoltenBreastplate);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.MoltenGreaves);
                        break;
                    case "ranged":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.NecroHelmet);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.NecroBreastplate);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.NecroGreaves);
                        break;
                    case "mage":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.JungleHat);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.JungleShirt);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.JunglePants);
                        break;
                    case "summoner":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.BeeHeadgear);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.BeeBreastplate);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.BeeGreaves);
                        break;
                }
                shop.item[SLOT_POTION_HEAL].SetDefaults(ItemID.GreaterHealingPotion);
                shop.item[SLOT_POTION_MANA].SetDefaults(ItemID.GreaterManaPotion);
                shop.item[SLOT_TORCH].SetDefaults(ItemID.UltrabrightTorch);
                shop.item[SLOT_ARROW].SetDefaults(ItemID.UnholyArrow);
                shop.item[SLOT_THROWING].SetDefaults(ItemID.Javelin);
                shop.item[SLOT_LIGHT_PET].SetDefaults(ItemID.WispinaBottle);
                shop.item[SLOT_MOUNT_1].SetDefaults(ItemID.AncientHorn);
                shop.item[SLOT_WOOD_2].SetDefaults(ItemID.DynastyWood);

                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.BreakerBlade);
                        break;
                    case "ranged":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.DD2PhoenixBow);
                        break;
                    case "mage":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.LaserRifle);
                        break;
                    case "summoner":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.ImpStaff);
                        break;
                }
            }
            if (Utils.downedMechBosses() == 1) {
                shop.item[SLOT_PICK].SetDefaults(ItemID.CobaltPickaxe);
                shop.item[SLOT_AXE].SetDefaults(ItemID.CobaltWaraxe);
                switch (Utils.getPlayerClass()) {
                    case "melee":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.CobaltHelmet);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.CobaltBreastplate);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.CobaltLeggings);
                        break;
                    case "ranged":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.CobaltMask);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.CobaltBreastplate);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.CobaltLeggings);
                        break;
                    case "mage":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.CobaltHat);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.CobaltBreastplate);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.CobaltLeggings);
                        break;
                    case "summoner":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.SpiderMask);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.SpiderBreastplate);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.SpiderGreaves);
                        break;
                }
                shop.item[SLOT_ARROW].SetDefaults(ItemID.HolyArrow);
                shop.item[SLOT_THROWING].SetDefaults(ItemID.BoneJavelin);
                if (Utils.kills(NPCID.Retinazer) >= 3) shop.item[SLOT_MOUNT_3].SetDefaults(ItemID.ReindeerBells);

                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.CobaltSword);
                        break;
                    case "ranged":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.Marrow);
                        break;
                    case "mage":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.MagicDagger);
                        break;
                    case "summoner":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.SpiderStaff);
                        break;
                }
            }
            if (Utils.downedMechBosses() == 2) {
                shop.item[SLOT_PICK].SetDefaults(ItemID.MythrilPickaxe);
                shop.item[SLOT_AXE].SetDefaults(ItemID.MythrilWaraxe);
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.MythrilHelmet);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.MythrilChainmail);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.MythrilGreaves);
                        break;
                    case "ranged":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.MythrilHat);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.MythrilChainmail);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.MythrilGreaves);
                        break;
                    case "mage":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.MythrilHood);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.MythrilChainmail);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.MythrilGreaves);
                        break;
                    case "summoner":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.SpookyHelmet);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.SpookyBreastplate);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.SpookyLeggings);
                        break;
                }
                shop.item[SLOT_ARROW].SetDefaults(ItemID.IchorArrow);
                shop.item[SLOT_IRON_ANVIL].SetDefaults(ItemID.MythrilAnvil);
                if (Utils.kills(NPCID.TheDestroyer) >= 3) shop.item[SLOT_MOUNT_4].SetDefaults(ItemID.BlessedApple);

                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.MythrilSword);
                        break;
                    case "ranged":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.IceBow);
                        break;
                    case "mage":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.VenomStaff);
                        break;
                    case "summoner":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.OpticStaff);
                        break;
                }
            }
            if (Utils.downedMechBosses() == 3) {
                shop.item[SLOT_PICK].SetDefaults(ItemID.TitaniumPickaxe);
                shop.item[SLOT_AXE].SetDefaults(ItemID.TitaniumWaraxe);
                shop.item[SLOT_HAMMER].SetDefaults(ItemID.Hammush);
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.TitaniumMask);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.TitaniumBreastplate);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.TitaniumLeggings);
                        break;
                    case "ranged":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.TitaniumHelmet);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.TitaniumBreastplate);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.TitaniumLeggings);
                        break;
                    case "mage":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.TitaniumHeadgear);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.TitaniumBreastplate);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.TitaniumLeggings);
                        break;
                    case "summoner":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.TikiMask);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.TikiShirt);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.TikiPants);
                        break;
                }
                shop.item[SLOT_ARROW].SetDefaults(ItemID.CursedArrow);
                if (Utils.kills(NPCID.SkeletronPrime) >= 3) shop.item[SLOT_MOUNT_5].SetDefaults(ItemID.BrainScrambler);

                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.TitaniumSword);
                        break;
                    case "ranged":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.ShadowFlameBow);
                        break;
                    case "mage":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.UnholyTrident);
                        break;
                    case "summoner":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.PygmyStaff);
                        break;
                }
            }
            if (NPC.downedPlantBoss) {
                shop.item[SLOT_PICK].SetDefaults(ItemID.ChlorophytePickaxe);
                shop.item[SLOT_AXE].SetDefaults(ItemID.ChlorophyteGreataxe);
                shop.item[SLOT_HAMMER].SetDefaults(ItemID.ChlorophyteJackhammer);
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.ChlorophyteMask);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.ChlorophytePlateMail);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.ChlorophyteGreaves);
                        break;
                    case "ranged":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.ChlorophyteHelmet);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.ChlorophytePlateMail);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.ChlorophyteGreaves);
                        break;
                    case "mage":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.ChlorophyteHeadgear);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.ChlorophytePlateMail);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.ChlorophyteGreaves);
                        break;
                    case "summoner":
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.TikiMask);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.TikiShirt);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.TikiPants);
                        break;
                }
                shop.item[SLOT_ARROW].SetDefaults(ItemID.ChlorophyteArrow);
                if (Utils.kills(NPCID.Plantera) >= 3) shop.item[SLOT_MOUNT_6].SetDefaults(ItemID.CosmicCarKey);

                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.Seedler);
                        break;
                    case "ranged":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.ChlorophyteShotbow);
                        break;
                    case "mage":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.LeafBlower);
                        break;
                    case "summoner":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.XenoStaff);
                        break;
                }
            }
            if (NPC.downedGolemBoss) {
                shop.item[SLOT_PICK].SetDefaults(ItemID.Picksaw);
                shop.item[SLOT_AXE].SetDefaults(ItemID.ShroomiteDiggingClaw);
                if (Utils.kills(NPCID.Golem) >= 3) shop.item[SLOT_MOUNT_7].SetDefaults(ItemID.ShrimpyTruffle);

                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.TrueNightsEdge);
                        break;
                    case "ranged":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.Tsunami);
                        break;
                    case "mage":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.HeatRay);
                        break;
                    case "summoner":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.RavenStaff);
                        break;
                }
            }
            if (NPC.downedMoonlord) {
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[SLOT_PICK].SetDefaults(ItemID.SolarFlarePickaxe);
                        shop.item[SLOT_AXE].SetDefaults(ItemID.SolarFlareAxe);
                        shop.item[SLOT_HAMMER].SetDefaults(ItemID.SolarFlareHammer);
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.SolarFlareHelmet);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.SolarFlareBreastplate);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.SolarFlareLeggings);
                        break;
                    case "ranged":
                        shop.item[SLOT_PICK].SetDefaults(ItemID.VortexPickaxe);
                        shop.item[SLOT_AXE].SetDefaults(ItemID.VortexAxe);
                        shop.item[SLOT_HAMMER].SetDefaults(ItemID.VortexHammer);
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.VortexHelmet);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.VortexBreastplate);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.VortexLeggings);
                        break;
                    case "mage":
                        shop.item[SLOT_PICK].SetDefaults(ItemID.NebulaPickaxe);
                        shop.item[SLOT_AXE].SetDefaults(ItemID.NebulaAxe);
                        shop.item[SLOT_HAMMER].SetDefaults(ItemID.NebulaHammer);
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.NebulaHelmet);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.NebulaBreastplate);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.NebulaLeggings);
                        break;
                    case "summoner":
                        shop.item[SLOT_PICK].SetDefaults(ItemID.StardustPickaxe);
                        shop.item[SLOT_AXE].SetDefaults(ItemID.StardustAxe);
                        shop.item[SLOT_HAMMER].SetDefaults(ItemID.StardustHammer);
                        shop.item[SLOT_HELMET].SetDefaults(ItemID.StardustHelmet);
                        shop.item[SLOT_CHESTPLATE].SetDefaults(ItemID.StardustBreastplate);
                        shop.item[SLOT_GREAVES].SetDefaults(ItemID.StardustLeggings);
                        break;
                }
                shop.item[SLOT_POTION_HEAL].SetDefaults(ItemID.SuperHealingPotion);
                shop.item[SLOT_POTION_MANA].SetDefaults(ItemID.SuperManaPotion);
                shop.item[SLOT_ARROW].SetDefaults(ItemID.MoonlordArrow);
                shop.item[SLOT_WOOD_2].SetDefaults(ItemID.SpookyWood);

                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.TerraBlade);
                        break;
                    case "ranged":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.Phantasm);
                        break;
                    case "mage":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.LunarFlareBook);
                        break;
                    case "summoner":
                        shop.item[SLOT_WEAPON].SetDefaults(ItemID.DeadlySphereStaff);
                        break;
                }
            }
        }
    }
}
