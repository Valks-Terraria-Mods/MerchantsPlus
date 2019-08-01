using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.Shops
{
    class ShopMerchant
    {
        private Chest shop;
        private int nextSlot;

        public ShopMerchant(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop) {
            switch (currentShop)
            {
                case "Overhaul":
                    /*if (MerchantsPlus.overhaulLoaded)
                    {
                        Mod overhaul = ModLoader.GetMod("TerrariaOverhaul");
                        shop.item[nextSlot++].SetDefaults(overhaul.ItemType("BunnyPaw"));
                        shop.item[nextSlot++].SetDefaults(overhaul.ItemType("Calendar"));
                        shop.item[nextSlot].SetDefaults(overhaul.ItemType("Charcoal"));
                        shop.item[nextSlot++].shopCustomPrice = 100;
                        shop.item[nextSlot].SetDefaults(overhaul.ItemType("Cookie"));
                        shop.item[nextSlot++].shopCustomPrice = 1500;
                        shop.item[nextSlot++].SetDefaults(overhaul.ItemType("Gramophone"));
                        shop.item[nextSlot].shopCustomPrice = 10000;
                        shop.item[nextSlot++].SetDefaults(overhaul.ItemType("LightningRod"));
                        shop.item[nextSlot++].SetDefaults(overhaul.ItemType("Mop"));
                        shop.item[nextSlot++].SetDefaults(overhaul.ItemType("MusicDisc"));
                        shop.item[nextSlot++].SetDefaults(overhaul.ItemType("OnyxCell"));
                        shop.item[nextSlot++].SetDefaults(overhaul.ItemType("RedGel"));
                        shop.item[nextSlot++].SetDefaults(overhaul.ItemType("RepairKit1"));
                        shop.item[nextSlot++].SetDefaults(overhaul.ItemType("RepairKit2"));
                        shop.item[nextSlot].SetDefaults(overhaul.ItemType("RepairTable"));
                        shop.item[nextSlot++].shopCustomPrice = 50000;
                        shop.item[nextSlot++].SetDefaults(overhaul.ItemType("SmokeDetector"));
                        shop.item[nextSlot++].SetDefaults(overhaul.ItemType("BlueNebula"));
                        shop.item[nextSlot++].SetDefaults(overhaul.ItemType("TheMeatImpaler"));
                        shop.item[nextSlot++].SetDefaults(overhaul.ItemType("SteelWhip"));
                        shop.item[nextSlot++].SetDefaults(overhaul.ItemType("WhipOfPain"));
                    }*/
                    break;
                case "Mounts":
                    shopMount(shop, ref nextSlot);
                    break;
                case "Pets":
                    shopPets(shop, ref nextSlot);
                    break;
                case "Ores":
                    if (WorldGen.copperBar > 0)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.CopperOre);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalOreCost;
                    }
                    else {
                        shop.item[nextSlot].SetDefaults(ItemID.TinOre);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalOreCost;
                    }

                    if (NPC.downedSlimeKing) {
                        if (WorldGen.ironBar > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.IronOre);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalOreCost;
                        }
                        else
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.LeadOre);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalOreCost;
                        }
                    }

                    if (NPC.downedBoss1) {
                        if (WorldGen.silverBar > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.SilverOre);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalOreCost;
                        }
                        else
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.TungstenOre);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalOreCost;
                        }
                    }

                    if (NPC.downedBoss2) {
                        if (WorldGen.goldBar > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.GoldOre);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalOreCost;
                        }
                        else
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.PlatinumOre);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalOreCost;
                        }
                        shop.item[nextSlot].SetDefaults(ItemID.Meteorite);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalOreCost;
                    }

                    if (NPC.downedBoss3) {
                        if (WorldGen.crimson)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.CrimtaneOre);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalOreCost;
                        }
                        else {
                            shop.item[nextSlot].SetDefaults(ItemID.DemoniteOre);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalOreCost;
                        }
                    }

                    if (Main.hardMode) {
                        shop.item[nextSlot].SetDefaults(ItemID.Hellstone);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalOreCost;
                    }

                    if (Utils.downedMechBosses() == 1) {
                        shop.item[nextSlot].SetDefaults(ItemID.PalladiumOre);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalOreCost * 2;
                        shop.item[nextSlot].SetDefaults(ItemID.CobaltOre);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalOreCost * 2;
                    }

                    if (Utils.downedMechBosses() == 2) {
                        shop.item[nextSlot].SetDefaults(ItemID.MythrilOre);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalOreCost * 3;
                        shop.item[nextSlot].SetDefaults(ItemID.OrichalcumOre);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalOreCost * 3;
                    }

                    if (Utils.downedMechBosses() == 3) {
                        shop.item[nextSlot].SetDefaults(ItemID.AdamantiteOre);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalOreCost * 4;
                        shop.item[nextSlot].SetDefaults(ItemID.TitaniumOre);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalOreCost * 4;

                        shop.item[nextSlot].SetDefaults(ItemID.HallowedBar);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalOreCost * 5;
                    }

                    if (NPC.downedPlantBoss) {
                        shop.item[nextSlot].SetDefaults(ItemID.ChlorophyteOre);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalOreCost * 10;
                    }

                    if (NPC.downedMoonlord) {
                        shop.item[nextSlot].SetDefaults(ItemID.LunarOre);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalOreCost * 100;
                    }
                    break;
                case "Gear":
                    shop.item[nextSlot++].SetDefaults(ItemID.Sickle);
                    if (!Main.hardMode) shop.item[nextSlot++].SetDefaults(ItemID.BugNet); else shop.item[nextSlot++].SetDefaults(ItemID.GoldenBugNet);
                    shopPickaxe(shop, ref nextSlot);
                    shopAxe(shop, ref nextSlot);
                    shopHammer(shop, ref nextSlot);
                    shopHelmet(shop, ref nextSlot);
                    shopBreastplate(shop, ref nextSlot);
                    shopGreaves(shop, ref nextSlot);
                    switch (Utils.getPlayerClass())
                    {
                        case "melee":
                            if (!NPC.downedBoss2) shopShortswords(shop, ref nextSlot);
                            shopBroadswords(shop, ref nextSlot);
                            break;
                        case "ranged":
                            shopBows(shop, ref nextSlot);
                            break;
                        case "mage":
                            shopMageWep(shop, ref nextSlot);
                            break;
                        case "summoner":
                            shopSummonWep(shop, ref nextSlot);
                            break;
                        case "thrower":
                            shopThrowerWep(shop, ref nextSlot);
                            break;
                    }
                    shopHealPotion(shop, ref nextSlot);
                    shopManaPotion(shop, ref nextSlot);
                    shopTorches(shop, ref nextSlot);
                    shopArrows(shop, ref nextSlot);
                    /*if (MerchantsPlus.overhaulLoaded)
                    {
                        Mod overhaul = ModLoader.GetMod("TerrariaOverhaul");
                        shop.item[nextSlot++].SetDefaults(overhaul.ItemType("WaterArrow"));
                    }*/

                    shopRope(shop, ref nextSlot);
                    shopLightPet(shop, ref nextSlot);
                    shopHooks(shop, ref nextSlot);
                    shop.item[nextSlot++].SetDefaults(ItemID.PiggyBank);
                    shop.item[nextSlot++].SetDefaults(ItemID.Safe);
                    shop.item[nextSlot].SetDefaults(ItemID.Wood);
                    shop.item[nextSlot++].shopCustomPrice = 100;
                    shopBuffPotion(shop, ref nextSlot);
                    shop.item[nextSlot].SetDefaults(ItemID.EmptyBucket);
                    shop.item[nextSlot++].shopCustomPrice = 10000;
                    shop.item[nextSlot].SetDefaults(ItemID.DemonWings);
                    shop.item[nextSlot++].shopCustomPrice = Item.buyPrice(10);
                    break;
                default:
                    shop.SetupShop(1);
                    break;
            }
        }

        private void shopPickaxe(Chest shop, ref int nextSlot)
        {
            /*if (MerchantsPlus.overhaulLoaded)
            {
                Mod overhaul = ModLoader.GetMod("TerrariaOverhaul");
                shop.item[nextSlot].SetDefaults(overhaul.ItemType("StonePickaxe"));
            }
            else*/
            {
                if (WorldGen.copperBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.CopperPickaxe);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.TinPickaxe);
                }
            }

            if (NPC.downedSlimeKing)
            {
                if (WorldGen.ironBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.IronPickaxe);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.LeadPickaxe);
                }
            }

            if (NPC.downedBoss1)
            {
                if (WorldGen.silverBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.SilverPickaxe);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.TungstenPickaxe);
                }
            }

            if (NPC.downedGoblins)
            {
                if (WorldGen.goldBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.GoldPickaxe);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.PlatinumPickaxe);
                }
            }

            if (NPC.downedBoss2)
            {
                if (WorldGen.crimson)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.DeathbringerPickaxe);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.NightmarePickaxe);
                }
            }

            if (NPC.downedBoss3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.MoltenPickaxe);
            }

            if (Utils.downedMechBosses() == 1)
            {
                shop.item[nextSlot].SetDefaults(ItemID.CobaltPickaxe);
            }

            if (Utils.downedMechBosses() == 2)
            {
                shop.item[nextSlot].SetDefaults(ItemID.MythrilPickaxe);
            }

            if (Utils.downedMechBosses() == 3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.TitaniumPickaxe);
            }

            if (NPC.downedPlantBoss)
            {
                shop.item[nextSlot].SetDefaults(ItemID.ChlorophytePickaxe);
            }

            if (NPC.downedGolemBoss)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Picksaw);
            }

            if (NPC.downedMoonlord)
            {
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[nextSlot].SetDefaults(ItemID.SolarFlarePickaxe);
                        break;
                    case "ranged":
                        shop.item[nextSlot].SetDefaults(ItemID.VortexPickaxe);
                        break;
                    case "mage":
                        shop.item[nextSlot].SetDefaults(ItemID.NebulaPickaxe);
                        break;
                    case "summoner":
                        shop.item[nextSlot].SetDefaults(ItemID.StardustPickaxe);
                        break;
                }
            }
            nextSlot++;
        }

        private void shopAxe(Chest shop, ref int nextSlot)
        {
            /*if (MerchantsPlus.overhaulLoaded)
            {
                Mod overhaul = ModLoader.GetMod("TerrariaOverhaul");
                shop.item[nextSlot].SetDefaults(overhaul.ItemType("StoneAxe"));
            }
            else*/
            {
                if (WorldGen.copperBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.CopperAxe);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.TinAxe);
                }
            }

            if (NPC.downedSlimeKing)
            {
                if (WorldGen.ironBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.IronAxe);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.LeadAxe);
                }
            }

            if (NPC.downedBoss1)
            {
                if (WorldGen.silverBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.SilverAxe);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.TungstenAxe);
                }
            }

            if (NPC.downedGoblins)
            {
                if (WorldGen.goldBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.GoldAxe);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.PlatinumAxe);
                }
            }

            if (NPC.downedBoss2)
            {
                if (WorldGen.crimson)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.BloodLustCluster);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.WarAxeoftheNight);
                }
            }

            if (NPC.downedBoss3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.MoltenHamaxe);
            }

            if (Utils.downedMechBosses() == 1)
            {
                shop.item[nextSlot].SetDefaults(ItemID.CobaltWaraxe);
            }

            if (Utils.downedMechBosses() == 2)
            {
                shop.item[nextSlot].SetDefaults(ItemID.MythrilWaraxe);
            }

            if (Utils.downedMechBosses() == 3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.TitaniumWaraxe);
            }

            if (NPC.downedPlantBoss)
            {
                shop.item[nextSlot].SetDefaults(ItemID.ChlorophyteGreataxe);
            }

            if (NPC.downedGolemBoss)
            {

            }

            if (NPC.downedMoonlord)
            {
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[nextSlot].SetDefaults(ItemID.SolarFlareAxe);
                        break;
                    case "ranged":
                        shop.item[nextSlot].SetDefaults(ItemID.VortexAxe);
                        break;
                    case "mage":
                        shop.item[nextSlot].SetDefaults(ItemID.NebulaAxe);
                        break;
                    case "summoner":
                        shop.item[nextSlot].SetDefaults(ItemID.StardustAxe);
                        break;
                }
            }
            nextSlot++;
        }

        private void shopHammer(Chest shop, ref int nextSlot)
        {
            if (WorldGen.copperBar > 0)
            {
                shop.item[nextSlot].SetDefaults(ItemID.CopperHammer);
            }
            else
            {
                shop.item[nextSlot].SetDefaults(ItemID.TinHammer);
            }

            if (NPC.downedSlimeKing)
            {
                if (WorldGen.ironBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.IronHammer);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.LeadHammer);
                }
            }

            if (NPC.downedBoss1)
            {
                if (WorldGen.silverBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.SilverHammer);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.TungstenHammer);
                }
            }

            if (NPC.downedGoblins)
            {
                if (WorldGen.goldBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.GoldHammer);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.PlatinumHammer);
                }
            }

            if (NPC.downedBoss2)
            {
                if (WorldGen.crimson)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.FleshGrinder);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.TheBreaker);
                }
            }

            if (NPC.downedBoss3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.MoltenHamaxe);
            }

            if (Utils.downedMechBosses() == 1)
            {

            }

            if (Utils.downedMechBosses() == 2)
            {

            }

            if (Utils.downedMechBosses() == 3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Hammush);
            }

            if (NPC.downedPlantBoss)
            {
                shop.item[nextSlot].SetDefaults(ItemID.ChlorophyteJackhammer);
            }

            if (NPC.downedGolemBoss)
            {

            }

            if (NPC.downedMoonlord)
            {
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[nextSlot].SetDefaults(ItemID.SolarFlareHammer);
                        break;
                    case "ranged":
                        shop.item[nextSlot].SetDefaults(ItemID.VortexHammer);
                        break;
                    case "mage":
                        shop.item[nextSlot].SetDefaults(ItemID.NebulaHammer);
                        break;
                    case "summoner":
                        shop.item[nextSlot].SetDefaults(ItemID.StardustHammer);
                        break;
                }
            }
            nextSlot++;
        }

        private void shopHelmet(Chest shop, ref int nextSlot)
        {
            if (WorldGen.copperBar > 0)
            {
                shop.item[nextSlot].SetDefaults(ItemID.CopperHelmet);
            }
            else
            {
                shop.item[nextSlot].SetDefaults(ItemID.TinHelmet);
            }

            if (NPC.downedSlimeKing)
            {
                if (WorldGen.ironBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.IronHelmet);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.LeadHelmet);
                }
            }

            if (NPC.downedBoss1)
            {
                if (WorldGen.silverBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.SilverHelmet);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.TungstenHelmet);
                }
            }

            if (NPC.downedGoblins)
            {
                if (WorldGen.goldBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.GoldHelmet);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.PlatinumHelmet);
                }
            }

            if (NPC.downedBoss2)
            {
                if (WorldGen.crimson)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.CrimsonHelmet);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.ShadowHelmet);
                }
            }

            if (NPC.downedBoss3)
            {
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[nextSlot].SetDefaults(ItemID.MoltenHelmet);
                        break;
                    case "ranged":
                        shop.item[nextSlot].SetDefaults(ItemID.NecroHelmet);
                        break;
                    case "mage":
                        shop.item[nextSlot].SetDefaults(ItemID.JungleHat);
                        break;
                    case "summoner":
                        shop.item[nextSlot].SetDefaults(ItemID.BeeGreaves);
                        break;
                }
            }

            if (Utils.downedMechBosses() == 1)
            {
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[nextSlot].SetDefaults(ItemID.CobaltHelmet);
                        break;
                    case "ranged":
                        shop.item[nextSlot].SetDefaults(ItemID.CobaltMask);
                        break;
                    case "mage":
                        shop.item[nextSlot].SetDefaults(ItemID.CobaltHat);
                        break;
                    case "summoner":
                        shop.item[nextSlot].SetDefaults(ItemID.SpiderMask);
                        break;
                }
            }

            if (Utils.downedMechBosses() == 2)
            {
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[nextSlot].SetDefaults(ItemID.MythrilHelmet);
                        break;
                    case "ranged":
                        shop.item[nextSlot].SetDefaults(ItemID.MythrilHat);
                        break;
                    case "mage":
                        shop.item[nextSlot].SetDefaults(ItemID.MythrilHood);
                        break;
                    case "summoner":
                        shop.item[nextSlot].SetDefaults(ItemID.SpookyHelmet);
                        break;
                }
            }

            if (Utils.downedMechBosses() == 3)
            {
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[nextSlot].SetDefaults(ItemID.TitaniumMask);
                        break;
                    case "ranged":
                        shop.item[nextSlot].SetDefaults(ItemID.TitaniumHelmet);
                        break;
                    case "mage":
                        shop.item[nextSlot].SetDefaults(ItemID.TitaniumHeadgear);
                        break;
                    case "summoner":
                        shop.item[nextSlot].SetDefaults(ItemID.TikiMask);
                        break;
                }
            }

            if (NPC.downedPlantBoss)
            {
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[nextSlot].SetDefaults(ItemID.ChlorophyteMask);
                        break;
                    case "ranged":
                        shop.item[nextSlot].SetDefaults(ItemID.ChlorophyteHelmet);
                        break;
                    case "mage":
                        shop.item[nextSlot].SetDefaults(ItemID.ChlorophyteHeadgear);
                        break;
                    case "summoner":
                        shop.item[nextSlot].SetDefaults(ItemID.TikiMask);
                        break;
                }
            }

            if (NPC.downedGolemBoss)
            {

            }

            if (NPC.downedMoonlord)
            {
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[nextSlot].SetDefaults(ItemID.SolarFlareHelmet);
                        break;
                    case "ranged":
                        shop.item[nextSlot].SetDefaults(ItemID.VortexHelmet);
                        break;
                    case "mage":
                        shop.item[nextSlot].SetDefaults(ItemID.NebulaHelmet);
                        break;
                    case "summoner":
                        shop.item[nextSlot].SetDefaults(ItemID.StardustHelmet);
                        break;
                }
            }
            nextSlot++;
        }

        private void shopBreastplate(Chest shop, ref int nextSlot)
        {
            if (WorldGen.copperBar > 0)
            {
                shop.item[nextSlot].SetDefaults(ItemID.CopperChainmail);
            }
            else
            {
                shop.item[nextSlot].SetDefaults(ItemID.TinChainmail);
            }

            if (NPC.downedSlimeKing)
            {
                if (WorldGen.ironBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.IronChainmail);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.LeadChainmail);
                }
            }

            if (NPC.downedBoss1)
            {
                if (WorldGen.silverBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.SilverChainmail);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.TungstenChainmail);
                }
            }

            if (NPC.downedGoblins)
            {
                if (WorldGen.goldBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.GoldChainmail);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.PlatinumChainmail);
                }
            }

            if (NPC.downedBoss2)
            {
                if (WorldGen.crimson)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.CrimsonScalemail);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.ShadowScalemail);
                }
            }

            if (NPC.downedBoss3)
            {
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[nextSlot].SetDefaults(ItemID.MoltenBreastplate);
                        break;
                    case "ranged":
                        shop.item[nextSlot].SetDefaults(ItemID.NecroBreastplate);
                        break;
                    case "mage":
                        shop.item[nextSlot].SetDefaults(ItemID.JungleShirt);
                        break;
                    case "summoner":
                        shop.item[nextSlot].SetDefaults(ItemID.BeeBreastplate);
                        break;
                }

            }

            if (Utils.downedMechBosses() == 1)
            {
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                    case "ranged":
                    case "mage":
                        shop.item[nextSlot].SetDefaults(ItemID.CobaltBreastplate);
                        break;
                    case "summoner":
                        shop.item[nextSlot].SetDefaults(ItemID.SpiderBreastplate);
                        break;
                }
            }

            if (Utils.downedMechBosses() == 2)
            {
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                    case "ranged":
                    case "mage":
                        shop.item[nextSlot].SetDefaults(ItemID.MythrilChainmail);
                        break;
                    case "summoner":
                        shop.item[nextSlot].SetDefaults(ItemID.SpookyBreastplate);
                        break;
                }
            }

            if (Utils.downedMechBosses() == 3)
            {
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                    case "ranged":
                    case "mage":
                        shop.item[nextSlot].SetDefaults(ItemID.TitaniumBreastplate);
                        break;
                    case "summoner":
                        shop.item[nextSlot].SetDefaults(ItemID.TikiShirt);
                        break;
                }
            }

            if (NPC.downedPlantBoss)
            {
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                    case "ranged":
                    case "mage":
                        shop.item[nextSlot].SetDefaults(ItemID.ChlorophytePlateMail);
                        break;
                    case "summoner":
                        shop.item[nextSlot].SetDefaults(ItemID.TikiShirt);
                        break;
                }
            }

            if (NPC.downedGolemBoss)
            {

            }

            if (NPC.downedMoonlord)
            {
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[nextSlot].SetDefaults(ItemID.SolarFlareBreastplate);
                        break;
                    case "ranged":
                        shop.item[nextSlot].SetDefaults(ItemID.VortexBreastplate);
                        break;
                    case "mage":
                        shop.item[nextSlot].SetDefaults(ItemID.NebulaBreastplate);
                        break;
                    case "summoner":
                        shop.item[nextSlot].SetDefaults(ItemID.StardustBreastplate);
                        break;
                }
            }
            nextSlot++;
        }

        private void shopGreaves(Chest shop, ref int nextSlot)
        {
            if (WorldGen.copperBar > 0)
            {
                shop.item[nextSlot].SetDefaults(ItemID.CopperGreaves);
            }
            else
            {
                shop.item[nextSlot].SetDefaults(ItemID.TinGreaves);
            }

            if (NPC.downedSlimeKing)
            {
                if (WorldGen.ironBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.IronGreaves);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.LeadGreaves);
                }
            }

            if (NPC.downedBoss1)
            {
                if (WorldGen.silverBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.SilverGreaves);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.TungstenGreaves);
                }
            }

            if (NPC.downedGoblins)
            {
                if (WorldGen.goldBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.GoldGreaves);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.PlatinumGreaves);
                }
            }

            if (NPC.downedBoss2)
            {
                if (WorldGen.crimson)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.CrimsonGreaves);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.ShadowGreaves);
                }
            }

            if (NPC.downedBoss3)
            {
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[nextSlot].SetDefaults(ItemID.MoltenGreaves);
                        break;
                    case "ranged":
                        shop.item[nextSlot].SetDefaults(ItemID.NecroGreaves);
                        break;
                    case "mage":
                        shop.item[nextSlot].SetDefaults(ItemID.JunglePants);
                        break;
                    case "summoner":
                        shop.item[nextSlot].SetDefaults(ItemID.BeeGreaves);
                        break;
                }

            }

            if (Utils.downedMechBosses() == 1)
            {
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                    case "ranged":
                    case "mage":
                        shop.item[nextSlot].SetDefaults(ItemID.CobaltLeggings);
                        break;
                    case "summoner":
                        shop.item[nextSlot].SetDefaults(ItemID.SpiderGreaves);
                        break;
                }
            }

            if (Utils.downedMechBosses() == 2)
            {
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                    case "ranged":
                    case "mage":
                        shop.item[nextSlot].SetDefaults(ItemID.MythrilGreaves);
                        break;
                    case "summoner":
                        shop.item[nextSlot].SetDefaults(ItemID.SpookyLeggings);
                        break;
                }
            }

            if (Utils.downedMechBosses() == 3)
            {
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                    case "ranged":
                    case "mage":
                        shop.item[nextSlot].SetDefaults(ItemID.TitaniumLeggings);
                        break;
                    case "summoner":
                        shop.item[nextSlot].SetDefaults(ItemID.TikiPants);
                        break;
                }
            }

            if (NPC.downedPlantBoss)
            {
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                    case "ranged":
                    case "mage":
                        shop.item[nextSlot].SetDefaults(ItemID.ChlorophyteGreaves);
                        break;
                    case "summoner":
                        shop.item[nextSlot].SetDefaults(ItemID.TikiPants);
                        break;
                }
            }

            if (NPC.downedGolemBoss)
            {

            }

            if (NPC.downedMoonlord)
            {
                switch (Utils.getPlayerClass())
                {
                    case "melee":
                        shop.item[nextSlot].SetDefaults(ItemID.SolarFlareLeggings);
                        break;
                    case "ranged":
                        shop.item[nextSlot].SetDefaults(ItemID.VortexLeggings);
                        break;
                    case "mage":
                        shop.item[nextSlot].SetDefaults(ItemID.NebulaLeggings);
                        break;
                    case "summoner":
                        shop.item[nextSlot].SetDefaults(ItemID.StardustLeggings);
                        break;
                }
            }
            nextSlot++;
        }

        private void shopShortswords(Chest shop, ref int nextSlot)
        {
            if (WorldGen.copperBar > 0)
            {
                shop.item[nextSlot].SetDefaults(ItemID.CopperShortsword);
            }
            else
            {
                shop.item[nextSlot].SetDefaults(ItemID.TinShortsword);
            }

            if (NPC.downedSlimeKing)
            {
                if (WorldGen.ironBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.IronShortsword);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.LeadShortsword);
                }
            }

            if (NPC.downedBoss1)
            {
                if (WorldGen.silverBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.SilverShortsword);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.TungstenShortsword);
                }
            }

            if (NPC.downedGoblins)
            {
                if (WorldGen.goldBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.GoldShortsword);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.PlatinumShortsword);
                }
            }

            nextSlot++;
        }

        private void shopBroadswords(Chest shop, ref int nextSlot)
        {
            if (WorldGen.copperBar > 0)
            {
                shop.item[nextSlot].SetDefaults(ItemID.CopperBroadsword);
            }
            else
            {
                shop.item[nextSlot].SetDefaults(ItemID.TinBroadsword);
            }

            if (NPC.downedSlimeKing)
            {
                if (WorldGen.ironBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.IronBroadsword);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.LeadBroadsword);
                }
            }

            if (NPC.downedBoss1)
            {
                if (WorldGen.silverBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.SilverBroadsword);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.TungstenBroadsword);
                }
            }

            if (NPC.downedGoblins)
            {
                if (WorldGen.goldBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.GoldBroadsword);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.PlatinumBroadsword);
                }
            }

            if (NPC.downedBoss2)
            {
                if (WorldGen.crimson)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.BloodButcherer);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.LightsBane);
                }
            }

            if (Utils.kills(NPCID.DD2DarkMageT1) > 0)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Arkhalis);
            }

            if (NPC.downedQueenBee)
            {
                shop.item[nextSlot].SetDefaults(ItemID.BeeKeeper);
            }

            if (Main.hardMode)
            {
                shop.item[nextSlot].SetDefaults(ItemID.BreakerBlade);
            }

            if (Utils.downedMechBosses() == 1)
            {
                shop.item[nextSlot].SetDefaults(ItemID.CobaltSword);
            }

            if (Utils.downedMechBosses() == 2)
            {
                shop.item[nextSlot].SetDefaults(ItemID.MythrilSword);
            }

            if (Utils.downedMechBosses() == 3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.TitaniumSword);
            }

            if (NPC.downedPlantBoss)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Seedler);
            }

            if (NPC.downedMoonlord)
            {
                shop.item[nextSlot].SetDefaults(ItemID.TerraBlade);
            }

            nextSlot++;
        }

        private void shopBows(Chest shop, ref int nextSlot)
        {
            if (WorldGen.copperBar > 0)
            {
                shop.item[nextSlot].SetDefaults(ItemID.CopperBow);
            }
            else
            {
                shop.item[nextSlot].SetDefaults(ItemID.TinBow);
            }

            if (NPC.downedSlimeKing)
            {
                if (WorldGen.ironBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.IronBow);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.LeadBow);
                }
            }

            if (NPC.downedBoss1)
            {
                if (WorldGen.silverBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.SilverBow);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.TungstenBow);
                }
            }

            if (NPC.downedGoblins)
            {
                if (WorldGen.goldBar > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.GoldBow);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.PlatinumBow);
                }
            }

            if (NPC.downedBoss2)
            {
                if (WorldGen.crimson)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.TendonBow);
                }
                else
                {
                    shop.item[nextSlot].SetDefaults(ItemID.DemonBow);
                }
            }

            if (NPC.downedQueenBee)
            {
                shop.item[nextSlot].SetDefaults(ItemID.BeesKnees);
            }

            if (NPC.downedBoss3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.MoltenFury);
            }

            if (Main.hardMode)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Marrow);
            }

            if (Utils.downedMechBosses() == 1)
            {
                shop.item[nextSlot].SetDefaults(ItemID.IceBow);
            }

            if (Utils.downedMechBosses() == 2)
            {
                shop.item[nextSlot].SetDefaults(ItemID.DaedalusStormbow);
            }

            if (Utils.downedMechBosses() == 3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.ShadowFlameBow);
            }

            if (NPC.downedPlantBoss)
            {
                shop.item[nextSlot].SetDefaults(ItemID.DD2PhoenixBow);
            }

            if (NPC.downedMoonlord)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Phantasm);
            }

            nextSlot++;
        }

        private void shopMageWep(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.WandofSparking);

            if (NPC.downedSlimeKing)
            {
                shop.item[nextSlot].SetDefaults(ItemID.EmeraldStaff);
            }

            if (NPC.downedBoss1)
            {
                shop.item[nextSlot].SetDefaults(ItemID.AmberStaff);
            }

            if (NPC.downedGoblins)
            {
                shop.item[nextSlot].SetDefaults(ItemID.DiamondStaff);
            }

            if (NPC.downedBoss2)
            {
                shop.item[nextSlot].SetDefaults(ItemID.SpaceGun);
            }

            if (NPC.downedQueenBee)
            {
                shop.item[nextSlot].SetDefaults(ItemID.BookofSkulls);
            }

            if (NPC.downedBoss3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.DemonScythe);
            }

            if (Main.hardMode)
            {
                shop.item[nextSlot].SetDefaults(ItemID.LaserRifle);
            }

            if (Utils.downedMechBosses() == 1)
            {
                shop.item[nextSlot].SetDefaults(ItemID.SkyFracture);
            }

            if (Utils.downedMechBosses() == 2)
            {
                shop.item[nextSlot].SetDefaults(ItemID.MagicDagger);
            }

            if (Utils.downedMechBosses() == 3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.FrostStaff);
            }

            if (NPC.downedPlantBoss)
            {
                shop.item[nextSlot].SetDefaults(ItemID.UnholyTrident);
            }

            if (NPC.downedGolemBoss)
            {
                shop.item[nextSlot].SetDefaults(ItemID.HeatRay);
            }

            if (NPC.downedFrost)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Razorpine);
            }

            if (Utils.kills(NPCID.DD2Betsy) > 0)
            {
                shop.item[nextSlot].SetDefaults(ItemID.ApprenticeStaffT3);
            }

            if (NPC.downedMartians)
            {
                shop.item[nextSlot].SetDefaults(ItemID.LaserMachinegun);
            }

            if (NPC.downedFishron)
            {
                shop.item[nextSlot].SetDefaults(ItemID.ChargedBlasterCannon);
            }

            if (NPC.downedAncientCultist)
            {
                shop.item[nextSlot].SetDefaults(ItemID.SpectreStaff);
            }

            if (NPC.downedMoonlord)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Phantasm);
            }

            nextSlot++;
        }

        private void shopSummonWep(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.SlimeStaff);

            if (NPC.downedQueenBee)
            {
                shop.item[nextSlot].SetDefaults(ItemID.HornetStaff);
            }

            if (NPC.downedBoss3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.ImpStaff);
            }

            if (Main.hardMode)
            {
                shop.item[nextSlot].SetDefaults(ItemID.SpiderStaff);
            }

            if (Utils.downedMechBosses() == 1)
            {
                shop.item[nextSlot].SetDefaults(ItemID.OpticStaff);
            }

            if (Utils.downedMechBosses() == 2)
            {
                shop.item[nextSlot].SetDefaults(ItemID.PygmyStaff);
            }

            if (Utils.downedMechBosses() == 3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.XenoStaff);
            }

            if (NPC.downedPlantBoss)
            {
                shop.item[nextSlot].SetDefaults(ItemID.RavenStaff);
            }

            if (NPC.downedGolemBoss)
            {
                shop.item[nextSlot].SetDefaults(ItemID.PirateStaff);
            }

            if (NPC.downedFrost)
            {
                shop.item[nextSlot].SetDefaults(ItemID.TempestStaff);
            }

            if (NPC.downedAncientCultist)
            {
                shop.item[nextSlot].SetDefaults(ItemID.DeadlySphereStaff);
            }

            if (NPC.downedMoonlord)
            {
                shop.item[nextSlot].SetDefaults(ItemID.StardustDragonStaff);
            }

            nextSlot++;
        }

        private void shopMount(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot++].SetDefaults(ItemID.FuzzyCarrot);

            if (Utils.kills(NPCID.KingSlime) >= 3)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.SlimySaddle);
            }

            if (Utils.kills(NPCID.EyeofCthulhu) >= 3)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.HardySaddle);
            }

            if (Utils.kills(NPCID.QueenBee) >= 3)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.HoneyedGoggles);
            }

            if (Main.hardMode)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.AncientHorn);
            }

            if (Utils.kills(NPCID.Retinazer) >= 3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.ReindeerBells);
            }

            if (Utils.kills(NPCID.TheDestroyer) >= 3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.ScalyTruffle);
            }

            if (Utils.kills(NPCID.SkeletronPrime) >= 3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.BrainScrambler);
            }

            if (Utils.kills(NPCID.Plantera) >= 3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.BlessedApple);
            }


            if (Utils.kills(NPCID.MartianSaucer) >= 3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.CosmicCarKey);
            }

            if (Utils.kills(NPCID.DukeFishron) >= 3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.ShrimpyTruffle);
            }

            if (Utils.kills(NPCID.MoonLordCore) >= 3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.DrillContainmentUnit);
            }
        }

        private void shopPets(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.DogWhistle);
            shop.item[nextSlot++].shopCustomPrice = 100000;
            shop.item[nextSlot].SetDefaults(ItemID.UnluckyYarn);
            shop.item[nextSlot++].shopCustomPrice = 100000;

            shop.item[nextSlot].SetDefaults(ItemID.Carrot);
            shop.item[nextSlot++].shopCustomPrice = 100000;

            shop.item[nextSlot++].SetDefaults(ItemID.AmberMosquito);
            shop.item[nextSlot++].SetDefaults(ItemID.Fish);
            shop.item[nextSlot++].SetDefaults(ItemID.BoneRattle);
            shop.item[nextSlot++].SetDefaults(ItemID.BoneKey);
            shop.item[nextSlot++].SetDefaults(ItemID.ParrotCracker);
            shop.item[nextSlot++].SetDefaults(ItemID.Seaweed);
            shop.item[nextSlot++].SetDefaults(ItemID.StrangeGlowingMushroom);
            shop.item[nextSlot++].SetDefaults(ItemID.ToySled);

            shop.item[nextSlot].SetDefaults(ItemID.EatersBone);
            shop.item[nextSlot++].shopCustomPrice = 100000;

            shop.item[nextSlot++].SetDefaults(ItemID.Nectar);
            shop.item[nextSlot++].SetDefaults(ItemID.LizardEgg);
            shop.item[nextSlot++].SetDefaults(ItemID.Seedling);
            shop.item[nextSlot++].SetDefaults(ItemID.TikiTotem);
            shop.item[nextSlot++].SetDefaults(ItemID.EyeSpring);
            shop.item[nextSlot++].SetDefaults(ItemID.MagicalPumpkinSeed);
            shop.item[nextSlot++].SetDefaults(ItemID.CursedSapling);
            shop.item[nextSlot++].SetDefaults(ItemID.SpiderEgg);

            shop.item[nextSlot].SetDefaults(ItemID.BabyGrinchMischiefWhistle);
            shop.item[nextSlot++].shopCustomPrice = 100000;

            shop.item[nextSlot++].SetDefaults(ItemID.TartarSauce);
            shop.item[nextSlot++].SetDefaults(ItemID.ZephyrFish);
            shop.item[nextSlot++].SetDefaults(ItemID.CompanionCube);
            shop.item[nextSlot++].SetDefaults(ItemID.DD2PetGato);
        }

        private void shopHealPotion(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot++].SetDefaults(ItemID.LesserHealingPotion);

            if (NPC.downedSlimeKing)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.Eggnog);
            }

            if (NPC.downedBoss1)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.LesserRestorationPotion);
            }

            if (NPC.downedBoss2)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.Honeyfin);
            }

            if (NPC.downedBoss3)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.HealingPotion);
            }

            if (Main.hardMode)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.RestorationPotion);
            }

            if (Utils.downedMechBosses() == 1)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.StrangeBrew);
            }

            if (Utils.downedMechBosses() == 2)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.GreaterHealingPotion);
            }

            if (NPC.downedMoonlord)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.SuperHealingPotion);
            }
        }

        private void shopManaPotion(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot++].SetDefaults(ItemID.LesserManaPotion);

            if (NPC.downedBoss1)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.ManaPotion);
            }

            if (NPC.downedBoss3)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.GreaterManaPotion);
            }

            if (NPC.downedMoonlord)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.SuperManaPotion);
            }
        }

        private void shopTorches(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.CactusCandle);
            shop.item[nextSlot].shopCustomPrice = 100;
            if (NPC.downedSlimeKing)
            {
                shop.item[nextSlot].SetDefaults(ItemID.RichMahoganyCandle);
            }
            if (NPC.downedBoss1)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Torch);
            }
            if (NPC.downedBoss3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.BoneTorch);
            }
            if (Main.hardMode)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.CursedTorch);
            }
            if (NPC.downedMoonlord)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.UltrabrightTorch);
            }
            nextSlot++;
        }

        private void shopArrows(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.WoodenArrow);
            if (NPC.downedSlimeKing)
            {
                shop.item[nextSlot].SetDefaults(ItemID.BoneArrow);
            }
            if (NPC.downedBoss1)
            {
                shop.item[nextSlot].SetDefaults(ItemID.FlamingArrow);
            }
            if (NPC.downedBoss2)
            {
                shop.item[nextSlot].SetDefaults(ItemID.FrostburnArrow);
            }
            if (NPC.downedBoss3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.JestersArrow);
            }
            if (Main.hardMode)
            {
                shop.item[nextSlot].SetDefaults(ItemID.UnholyArrow);
            }
            if (Utils.downedMechBosses() == 1)
            {
                shop.item[nextSlot].SetDefaults(ItemID.HolyArrow);
            }
            if (Utils.downedMechBosses() == 2)
            {
                shop.item[nextSlot].SetDefaults(ItemID.CursedArrow);
            }
            if (Utils.downedMechBosses() == 3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.IchorArrow);
            }
            if (NPC.downedPlantBoss)
            {
                shop.item[nextSlot].SetDefaults(ItemID.ChlorophyteArrow);
            }
            if (NPC.downedMoonlord)
            {
                shop.item[nextSlot].SetDefaults(ItemID.MoonlordArrow);
            }
            nextSlot++;
        }

        private void shopRope(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.VineRope);
            shop.item[nextSlot].shopCustomPrice = 1;
            if (NPC.downedSlimeKing)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Rope);
            }
            if (NPC.downedBoss3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Chain);
            }
            nextSlot++;
        }

        private void shopLightPet(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.FairyBell);
            if (Main.hardMode)
            {
                shop.item[nextSlot].SetDefaults(ItemID.WispinaBottle);
            }
            nextSlot++;
        }

        private void shopThrowerWep(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.Snowball);
            if (NPC.downedSlimeKing)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Shuriken);
            }
            if (NPC.downedBoss1)
            {
                shop.item[nextSlot].SetDefaults(ItemID.ThrowingKnife);
            }
            if (NPC.downedGoblins)
            {
                shop.item[nextSlot].SetDefaults(ItemID.PoisonedKnife);
            }
            if (NPC.downedBoss2)
            {
                shop.item[nextSlot].SetDefaults(ItemID.BoneDagger);
            }
            if (Utils.kills(NPCID.DD2DarkMageT1) > 0)
            {
                shop.item[nextSlot].SetDefaults(ItemID.SpikyBall);
            }
            if (NPC.downedQueenBee)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Javelin);
            }
            if (NPC.downedBoss3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Bone);
            }
            if (Main.hardMode)
            {
                shop.item[nextSlot].SetDefaults(ItemID.MolotovCocktail);
            }
            if (Utils.downedMechBosses() == 1)
            {
                shop.item[nextSlot].SetDefaults(ItemID.BoneJavelin);
            }
            nextSlot++;
        }

        private void shopHooks(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.GrapplingHook);
            if (NPC.downedSlimeKing)
            {
                shop.item[nextSlot].SetDefaults(ItemID.AmethystHook);
            }
            if (NPC.downedBoss1)
            {
                shop.item[nextSlot].SetDefaults(ItemID.TopazHook);
            }
            if (NPC.downedGoblins)
            {
                shop.item[nextSlot].SetDefaults(ItemID.SapphireHook);
            }
            if (NPC.downedBoss2)
            {
                shop.item[nextSlot].SetDefaults(ItemID.EmeraldHook);
            }
            if (Utils.kills(NPCID.DD2DarkMageT1) > 0)
            {
                shop.item[nextSlot].SetDefaults(ItemID.RubyHook);
            }
            if (NPC.downedQueenBee)
            {
                shop.item[nextSlot].SetDefaults(ItemID.DiamondHook);
            }
            if (NPC.downedBoss3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.SkeletronHand);
            }
            if (Main.hardMode)
            {
                shop.item[nextSlot].SetDefaults(ItemID.IvyWhip);
            }
            if (Utils.downedMechBosses() == 1)
            {
                shop.item[nextSlot].SetDefaults(ItemID.DualHook);
            }
            if (Utils.downedMechBosses() == 2)
            {
                shop.item[nextSlot].SetDefaults(ItemID.SpookyHook);
            }
            if (Utils.downedMechBosses() == 3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.ChristmasHook);
            }
            if (NPC.downedMoonlord)
            {
                shop.item[nextSlot].SetDefaults(ItemID.LunarHook);
            }
            nextSlot++;
        }

        private void shopBuffPotion(Chest shop, ref int nextSlot)
        {
            switch (Utils.getPlayerClass())
            {
                case "melee":
                    shop.item[nextSlot].SetDefaults(ItemID.ArcheryPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    break;
                case "ranged":
                    shop.item[nextSlot].SetDefaults(ItemID.ArcheryPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    break;
                case "mage":
                    shop.item[nextSlot].SetDefaults(ItemID.MagicPowerPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.ManaRegenerationPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    break;
                case "summoner":
                    break;
                case "thrower":
                    break;
            }
        }
    }
}
