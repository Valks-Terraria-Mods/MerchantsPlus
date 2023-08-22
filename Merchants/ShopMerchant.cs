using Terraria.WorldBuilding;

namespace MerchantsPlus.Merchants;

internal class ShopMerchant : Shop
{
    public override string[] Shops => new string[] { 
        "Gear", 
        "Ores", 
        "Pets", 
        "Mounts" };

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        switch (shop)
        {
            case "Mounts":
                Mounts();
                return;
            case "Pets":
                Pets();
                return;
            case "Ores":
                Ores();
                return;
            case "Gear":
                Gear();
                return;
        }

        // Default Shop
        Inv.SetupShop(1);
    }

    void Wings()
    {
        ReplaceItem(ItemID.AngelWings, Utils.Coins(0, 0, 0, 10));
        if (NPC.downedSlimeKing) ReplaceItem(ItemID.DemonWings, Utils.Coins(0, 0, 0, 10));
        if (Utils.DownedEyeOfCthulhu()) ReplaceItem(ItemID.LeafWings, Utils.Coins(0, 0, 0, 10));
        if (NPC.downedGoblins) ReplaceItem(ItemID.HarpyWings, Utils.Coins(0, 0, 0, 10));
        if (Utils.DownedBrainOfCthulhu()) ReplaceItem(ItemID.FrozenWings, Utils.Coins(0, 0, 0, 10));
        if (NPC.downedQueenBee) ReplaceItem(ItemID.FinWings, Utils.Coins(0, 0, 0, 10));
        if (Utils.DownedSkeletron()) ReplaceItem(ItemID.FairyWings, Utils.Coins(0, 0, 0, 10));
        if (Main.hardMode) ReplaceItem(ItemID.ArkhalisWings, Utils.Coins(0, 0, 0, 10));
        if (Utils.DownedMechBosses() == 1) ReplaceItem(ItemID.DTownsWings, Utils.Coins(0, 0, 0, 2));
        if (Utils.DownedMechBosses() == 2) ReplaceItem(ItemID.CrownosWings, Utils.Coins(0, 0, 0, 2));
        if (Utils.DownedMechBosses() == 3) ReplaceItem(ItemID.CenxsWings, Utils.Coins(0, 0, 0, 2));
        if (NPC.downedPlantBoss) ReplaceItem(ItemID.JimsWings, Utils.Coins(0, 0, 0, 2));
        if (NPC.downedGolemBoss) ReplaceItem(ItemID.LeinforsWings, Utils.Coins(0, 0, 0, 2));
        if (NPC.downedFishron) ReplaceItem(ItemID.FishronWings, Utils.Coins(0, 0, 0, 2));
        if (NPC.downedMoonlord) ReplaceItem(ItemID.WingsStardust, Utils.Coins(0, 0, 0, 2));

        NextSlot++;
    }

    void Pickaxe()
    {
        {
            if (GenVars.copperBar > 0)
            {
                ReplaceItem(ItemID.CopperPickaxe);
            }
            else
            {
                ReplaceItem(ItemID.TinPickaxe);
            }
        }

        if (NPC.downedSlimeKing)
        {
            if (GenVars.ironBar > 0)
            {
                ReplaceItem(ItemID.IronPickaxe);
            }
            else
            {
                ReplaceItem(ItemID.LeadPickaxe);
            }
        }

        if (NPC.downedBoss1)
        {
            if (GenVars.silverBar > 0)
            {
                ReplaceItem(ItemID.SilverPickaxe);
            }
            else
            {
                ReplaceItem(ItemID.TungstenPickaxe);
            }
        }

        if (NPC.downedGoblins)
        {
            if (GenVars.goldBar > 0)
            {
                ReplaceItem(ItemID.GoldPickaxe);
            }
            else
            {
                ReplaceItem(ItemID.PlatinumPickaxe);
            }
        }

        if (NPC.downedBoss2)
        {
            if (GenVars.crimsonLeft)
            {
                ReplaceItem(ItemID.DeathbringerPickaxe);
            }
            else
            {
                ReplaceItem(ItemID.NightmarePickaxe);
            }
        }

        if (NPC.downedBoss3)
        {
            ReplaceItem(ItemID.MoltenPickaxe);
        }

        if (Utils.DownedMechBosses() == 1)
        {
            ReplaceItem(ItemID.CobaltPickaxe);
        }

        if (Utils.DownedMechBosses() == 2)
        {
            ReplaceItem(ItemID.MythrilPickaxe);
        }

        if (Utils.DownedMechBosses() == 3)
        {
            ReplaceItem(ItemID.TitaniumPickaxe);
        }

        if (NPC.downedPlantBoss)
        {
            ReplaceItem(ItemID.ChlorophytePickaxe);
        }

        if (NPC.downedGolemBoss)
        {
            ReplaceItem(ItemID.Picksaw);
        }

        if (NPC.downedMoonlord)
        {
            switch (Utils.GetPlayerClass())
            {
                case "melee":
                    ReplaceItem(ItemID.SolarFlarePickaxe);
                    break;

                case "ranged":
                    ReplaceItem(ItemID.VortexPickaxe);
                    break;

                case "mage":
                    ReplaceItem(ItemID.NebulaPickaxe);
                    break;

                case "summoner":
                    ReplaceItem(ItemID.StardustPickaxe);
                    break;
            }
        }
        NextSlot++;
    }

    void Axe()
    {
        {
            if (GenVars.copperBar > 0)
            {
                ReplaceItem(ItemID.CopperAxe);
            }
            else
            {
                ReplaceItem(ItemID.TinAxe);
            }
        }

        if (NPC.downedSlimeKing)
        {
            if (GenVars.ironBar > 0)
            {
                ReplaceItem(ItemID.IronAxe);
            }
            else
            {
                ReplaceItem(ItemID.LeadAxe);
            }
        }

        if (NPC.downedBoss1)
        {
            if (GenVars.silverBar > 0)
            {
                ReplaceItem(ItemID.SilverAxe);
            }
            else
            {
                ReplaceItem(ItemID.TungstenAxe);
            }
        }

        if (NPC.downedGoblins)
        {
            if (GenVars.goldBar > 0)
            {
                ReplaceItem(ItemID.GoldAxe);
            }
            else
            {
                ReplaceItem(ItemID.PlatinumAxe);
            }
        }

        if (NPC.downedBoss2)
        {
            if (GenVars.crimsonLeft)
            {
                ReplaceItem(ItemID.BloodLustCluster);
            }
            else
            {
                ReplaceItem(ItemID.WarAxeoftheNight);
            }
        }

        if (NPC.downedBoss3)
        {
            ReplaceItem(ItemID.MoltenHamaxe);
        }

        if (Utils.DownedMechBosses() == 1)
        {
            ReplaceItem(ItemID.CobaltWaraxe);
        }

        if (Utils.DownedMechBosses() == 2)
        {
            ReplaceItem(ItemID.MythrilWaraxe);
        }

        if (Utils.DownedMechBosses() == 3)
        {
            ReplaceItem(ItemID.TitaniumWaraxe);
        }

        if (NPC.downedPlantBoss)
        {
            ReplaceItem(ItemID.ChlorophyteGreataxe);
        }

        if (NPC.downedGolemBoss)
        {
        }

        if (NPC.downedMoonlord)
        {
            switch (Utils.GetPlayerClass())
            {
                case "melee":
                    ReplaceItem(ItemID.LunarHamaxeSolar);
                    break;

                case "ranged":
                    ReplaceItem(ItemID.LunarHamaxeVortex);
                    break;

                case "mage":
                    ReplaceItem(ItemID.LunarHamaxeNebula);
                    break;

                case "summoner":
                    ReplaceItem(ItemID.LunarHamaxeStardust);
                    break;
            }
        }
        NextSlot++;
    }

    void Hammer()
    {
        if (GenVars.copperBar > 0)
        {
            ReplaceItem(ItemID.CopperHammer);
        }
        else
        {
            ReplaceItem(ItemID.TinHammer);
        }

        if (NPC.downedSlimeKing)
        {
            if (GenVars.ironBar > 0)
            {
                ReplaceItem(ItemID.IronHammer);
            }
            else
            {
                ReplaceItem(ItemID.LeadHammer);
            }
        }

        if (NPC.downedBoss1)
        {
            if (GenVars.silverBar > 0)
            {
                ReplaceItem(ItemID.SilverHammer);
            }
            else
            {
                ReplaceItem(ItemID.TungstenHammer);
            }
        }

        if (NPC.downedGoblins)
        {
            if (GenVars.goldBar > 0)
            {
                ReplaceItem(ItemID.GoldHammer);
            }
            else
            {
                ReplaceItem(ItemID.PlatinumHammer);
            }
        }

        if (NPC.downedBoss2)
        {
            if (GenVars.crimsonLeft)
            {
                ReplaceItem(ItemID.FleshGrinder);
            }
            else
            {
                ReplaceItem(ItemID.TheBreaker);
            }
        }

        if (NPC.downedBoss3)
        {
            ReplaceItem(ItemID.MoltenHamaxe);
        }

        if (Utils.DownedMechBosses() == 1)
        {
        }

        if (Utils.DownedMechBosses() == 2)
        {
        }

        if (Utils.DownedMechBosses() == 3)
        {
            ReplaceItem(ItemID.Hammush);
        }

        if (NPC.downedPlantBoss)
        {
            ReplaceItem(ItemID.ChlorophyteJackhammer);
        }

        if (NPC.downedGolemBoss)
        {
        }

        if (NPC.downedMoonlord)
        {
            switch (Utils.GetPlayerClass())
            {
                case "melee":
                    ReplaceItem(ItemID.LunarHamaxeSolar);
                    break;

                case "ranged":
                    ReplaceItem(ItemID.LunarHamaxeVortex);
                    break;

                case "mage":
                    ReplaceItem(ItemID.LunarHamaxeNebula);
                    break;

                case "summoner":
                    ReplaceItem(ItemID.LunarHamaxeStardust);
                    break;
            }
        }
        NextSlot++;
    }

    void Helmet()
    {
        if (GenVars.copperBar > 0)
        {
            ReplaceItem(ItemID.CopperHelmet);
        }
        else
        {
            ReplaceItem(ItemID.TinHelmet);
        }

        if (NPC.downedSlimeKing)
        {
            if (GenVars.ironBar > 0)
            {
                ReplaceItem(ItemID.IronHelmet);
            }
            else
            {
                ReplaceItem(ItemID.LeadHelmet);
            }
        }

        if (NPC.downedBoss1)
        {
            if (GenVars.silverBar > 0)
            {
                ReplaceItem(ItemID.SilverHelmet);
            }
            else
            {
                ReplaceItem(ItemID.TungstenHelmet);
            }
        }

        if (NPC.downedGoblins)
        {
            if (GenVars.goldBar > 0)
            {
                ReplaceItem(ItemID.GoldHelmet);
            }
            else
            {
                ReplaceItem(ItemID.PlatinumHelmet);
            }
        }

        if (NPC.downedBoss2)
        {
            if (GenVars.crimsonLeft)
            {
                ReplaceItem(ItemID.CrimsonHelmet);
            }
            else
            {
                ReplaceItem(ItemID.ShadowHelmet);
            }
        }

        if (NPC.downedBoss3)
        {
            switch (Utils.GetPlayerClass())
            {
                case "melee":
                    ReplaceItem(ItemID.MoltenHelmet);
                    break;

                case "ranged":
                    ReplaceItem(ItemID.NecroHelmet);
                    break;

                case "mage":
                    ReplaceItem(ItemID.JungleHat);
                    break;

                case "summoner":
                    ReplaceItem(ItemID.BeeGreaves);
                    break;
            }
        }

        if (Utils.DownedMechBosses() == 1)
        {
            switch (Utils.GetPlayerClass())
            {
                case "melee":
                    ReplaceItem(ItemID.CobaltHelmet);
                    break;

                case "ranged":
                    ReplaceItem(ItemID.CobaltMask);
                    break;

                case "mage":
                    ReplaceItem(ItemID.CobaltHat);
                    break;

                case "summoner":
                    ReplaceItem(ItemID.SpiderMask);
                    break;
            }
        }

        if (Utils.DownedMechBosses() == 2)
        {
            switch (Utils.GetPlayerClass())
            {
                case "melee":
                    ReplaceItem(ItemID.MythrilHelmet);
                    break;

                case "ranged":
                    ReplaceItem(ItemID.MythrilHat);
                    break;

                case "mage":
                    ReplaceItem(ItemID.MythrilHood);
                    break;

                case "summoner":
                    ReplaceItem(ItemID.SpookyHelmet);
                    break;
            }
        }

        if (Utils.DownedMechBosses() == 3)
        {
            switch (Utils.GetPlayerClass())
            {
                case "melee":
                    ReplaceItem(ItemID.TitaniumMask);
                    break;

                case "ranged":
                    ReplaceItem(ItemID.TitaniumHelmet);
                    break;

                case "mage":
                    ReplaceItem(ItemID.TitaniumHeadgear);
                    break;

                case "summoner":
                    ReplaceItem(ItemID.TikiMask);
                    break;
            }
        }

        if (NPC.downedPlantBoss)
        {
            switch (Utils.GetPlayerClass())
            {
                case "melee":
                    ReplaceItem(ItemID.ChlorophyteMask);
                    break;

                case "ranged":
                    ReplaceItem(ItemID.ChlorophyteHelmet);
                    break;

                case "mage":
                    ReplaceItem(ItemID.ChlorophyteHeadgear);
                    break;

                case "summoner":
                    ReplaceItem(ItemID.TikiMask);
                    break;
            }
        }

        if (NPC.downedGolemBoss)
        {
        }

        if (NPC.downedMoonlord)
        {
            switch (Utils.GetPlayerClass())
            {
                case "melee":
                    ReplaceItem(ItemID.SolarFlareHelmet);
                    break;

                case "ranged":
                    ReplaceItem(ItemID.VortexHelmet);
                    break;

                case "mage":
                    ReplaceItem(ItemID.NebulaHelmet);
                    break;

                case "summoner":
                    ReplaceItem(ItemID.StardustHelmet);
                    break;
            }
        }
        NextSlot++;
    }

    void Breastplate()
    {
        if (GenVars.copperBar > 0)
        {
            ReplaceItem(ItemID.CopperChainmail);
        }
        else
        {
            ReplaceItem(ItemID.TinChainmail);
        }

        if (NPC.downedSlimeKing)
        {
            if (GenVars.ironBar > 0)
            {
                ReplaceItem(ItemID.IronChainmail);
            }
            else
            {
                ReplaceItem(ItemID.LeadChainmail);
            }
        }

        if (NPC.downedBoss1)
        {
            if (GenVars.silverBar > 0)
            {
                ReplaceItem(ItemID.SilverChainmail);
            }
            else
            {
                ReplaceItem(ItemID.TungstenChainmail);
            }
        }

        if (NPC.downedGoblins)
        {
            if (GenVars.goldBar > 0)
            {
                ReplaceItem(ItemID.GoldChainmail);
            }
            else
            {
                ReplaceItem(ItemID.PlatinumChainmail);
            }
        }

        if (NPC.downedBoss2)
        {
            if (GenVars.crimsonLeft)
            {
                ReplaceItem(ItemID.CrimsonScalemail);
            }
            else
            {
                ReplaceItem(ItemID.ShadowScalemail);
            }
        }

        if (NPC.downedBoss3)
        {
            switch (Utils.GetPlayerClass())
            {
                case "melee":
                    ReplaceItem(ItemID.MoltenBreastplate);
                    break;

                case "ranged":
                    ReplaceItem(ItemID.NecroBreastplate);
                    break;

                case "mage":
                    ReplaceItem(ItemID.JungleShirt);
                    break;

                case "summoner":
                    ReplaceItem(ItemID.BeeBreastplate);
                    break;
            }
        }

        if (Utils.DownedMechBosses() == 1)
        {
            switch (Utils.GetPlayerClass())
            {
                case "melee":
                case "ranged":
                case "mage":
                    ReplaceItem(ItemID.CobaltBreastplate);
                    break;

                case "summoner":
                    ReplaceItem(ItemID.SpiderBreastplate);
                    break;
            }
        }

        if (Utils.DownedMechBosses() == 2)
        {
            switch (Utils.GetPlayerClass())
            {
                case "melee":
                case "ranged":
                case "mage":
                    ReplaceItem(ItemID.MythrilChainmail);
                    break;

                case "summoner":
                    ReplaceItem(ItemID.SpookyBreastplate);
                    break;
            }
        }

        if (Utils.DownedMechBosses() == 3)
        {
            switch (Utils.GetPlayerClass())
            {
                case "melee":
                case "ranged":
                case "mage":
                    ReplaceItem(ItemID.TitaniumBreastplate);
                    break;

                case "summoner":
                    ReplaceItem(ItemID.TikiShirt);
                    break;
            }
        }

        if (NPC.downedPlantBoss)
        {
            switch (Utils.GetPlayerClass())
            {
                case "melee":
                case "ranged":
                case "mage":
                    ReplaceItem(ItemID.ChlorophytePlateMail);
                    break;

                case "summoner":
                    ReplaceItem(ItemID.TikiShirt);
                    break;
            }
        }

        if (NPC.downedGolemBoss)
        {
        }

        if (NPC.downedMoonlord)
        {
            switch (Utils.GetPlayerClass())
            {
                case "melee":
                    ReplaceItem(ItemID.SolarFlareBreastplate);
                    break;

                case "ranged":
                    ReplaceItem(ItemID.VortexBreastplate);
                    break;

                case "mage":
                    ReplaceItem(ItemID.NebulaBreastplate);
                    break;

                case "summoner":
                    ReplaceItem(ItemID.StardustBreastplate);
                    break;
            }
        }
        NextSlot++;
    }

    void ShopGreaves()
    {
        if (GenVars.copperBar > 0)
        {
            ReplaceItem(ItemID.CopperGreaves);
        }
        else
        {
            ReplaceItem(ItemID.TinGreaves);
        }

        if (NPC.downedSlimeKing)
        {
            if (GenVars.ironBar > 0)
            {
                ReplaceItem(ItemID.IronGreaves);
            }
            else
            {
                ReplaceItem(ItemID.LeadGreaves);
            }
        }

        if (NPC.downedBoss1)
        {
            if (GenVars.silverBar > 0)
            {
                ReplaceItem(ItemID.SilverGreaves);
            }
            else
            {
                ReplaceItem(ItemID.TungstenGreaves);
            }
        }

        if (NPC.downedGoblins)
        {
            if (GenVars.goldBar > 0)
            {
                ReplaceItem(ItemID.GoldGreaves);
            }
            else
            {
                ReplaceItem(ItemID.PlatinumGreaves);
            }
        }

        if (NPC.downedBoss2)
        {
            if (GenVars.crimsonLeft)
            {
                ReplaceItem(ItemID.CrimsonGreaves);
            }
            else
            {
                ReplaceItem(ItemID.ShadowGreaves);
            }
        }

        if (NPC.downedBoss3)
        {
            switch (Utils.GetPlayerClass())
            {
                case "melee":
                    ReplaceItem(ItemID.MoltenGreaves);
                    break;

                case "ranged":
                    ReplaceItem(ItemID.NecroGreaves);
                    break;

                case "mage":
                    ReplaceItem(ItemID.JunglePants);
                    break;

                case "summoner":
                    ReplaceItem(ItemID.BeeGreaves);
                    break;
            }
        }

        if (Utils.DownedMechBosses() == 1)
        {
            switch (Utils.GetPlayerClass())
            {
                case "melee":
                case "ranged":
                case "mage":
                    ReplaceItem(ItemID.CobaltLeggings);
                    break;

                case "summoner":
                    ReplaceItem(ItemID.SpiderGreaves);
                    break;
            }
        }

        if (Utils.DownedMechBosses() == 2)
        {
            switch (Utils.GetPlayerClass())
            {
                case "melee":
                case "ranged":
                case "mage":
                    ReplaceItem(ItemID.MythrilGreaves);
                    break;

                case "summoner":
                    ReplaceItem(ItemID.SpookyLeggings);
                    break;
            }
        }

        if (Utils.DownedMechBosses() == 3)
        {
            switch (Utils.GetPlayerClass())
            {
                case "melee":
                case "ranged":
                case "mage":
                    ReplaceItem(ItemID.TitaniumLeggings);
                    break;

                case "summoner":
                    ReplaceItem(ItemID.TikiPants);
                    break;
            }
        }

        if (NPC.downedPlantBoss)
        {
            switch (Utils.GetPlayerClass())
            {
                case "melee":
                case "ranged":
                case "mage":
                    ReplaceItem(ItemID.ChlorophyteGreaves);
                    break;

                case "summoner":
                    ReplaceItem(ItemID.TikiPants);
                    break;
            }
        }

        if (NPC.downedGolemBoss)
        {
        }

        if (NPC.downedMoonlord)
        {
            switch (Utils.GetPlayerClass())
            {
                case "melee":
                    ReplaceItem(ItemID.SolarFlareLeggings);
                    break;

                case "ranged":
                    ReplaceItem(ItemID.VortexLeggings);
                    break;

                case "mage":
                    ReplaceItem(ItemID.NebulaLeggings);
                    break;

                case "summoner":
                    ReplaceItem(ItemID.StardustLeggings);
                    break;
            }
        }
        NextSlot++;
    }

    void Shortswords()
    {
        if (GenVars.copperBar > 0)
        {
            ReplaceItem(ItemID.CopperShortsword);
        }
        else
        {
            ReplaceItem(ItemID.TinShortsword);
        }

        if (NPC.downedSlimeKing)
        {
            if (GenVars.ironBar > 0)
            {
                ReplaceItem(ItemID.IronShortsword);
            }
            else
            {
                ReplaceItem(ItemID.LeadShortsword);
            }
        }

        if (NPC.downedBoss1)
        {
            if (GenVars.silverBar > 0)
            {
                ReplaceItem(ItemID.SilverShortsword);
            }
            else
            {
                ReplaceItem(ItemID.TungstenShortsword);
            }
        }

        if (NPC.downedGoblins)
        {
            if (GenVars.goldBar > 0)
            {
                ReplaceItem(ItemID.GoldShortsword);
            }
            else
            {
                ReplaceItem(ItemID.PlatinumShortsword);
            }
        }

        NextSlot++;
    }

    void Broadswords()
    {
        if (GenVars.copperBar > 0)
        {
            ReplaceItem(ItemID.CopperBroadsword);
        }
        else
        {
            ReplaceItem(ItemID.TinBroadsword);
        }

        if (NPC.downedSlimeKing)
        {
            if (GenVars.ironBar > 0)
            {
                ReplaceItem(ItemID.IronBroadsword);
            }
            else
            {
                ReplaceItem(ItemID.LeadBroadsword);
            }
        }

        if (NPC.downedBoss1)
        {
            if (GenVars.silverBar > 0)
            {
                ReplaceItem(ItemID.SilverBroadsword);
            }
            else
            {
                ReplaceItem(ItemID.TungstenBroadsword);
            }
        }

        if (NPC.downedGoblins)
        {
            if (GenVars.goldBar > 0)
            {
                ReplaceItem(ItemID.GoldBroadsword);
            }
            else
            {
                ReplaceItem(ItemID.PlatinumBroadsword);
            }
        }

        if (NPC.downedBoss2)
        {
            if (GenVars.crimsonLeft)
            {
                ReplaceItem(ItemID.BloodButcherer);
            }
            else
            {
                ReplaceItem(ItemID.LightsBane);
            }
        }

        if (Utils.Kills(NPCID.DD2DarkMageT1) > 0)
        {
            ReplaceItem(ItemID.Arkhalis);
        }

        if (NPC.downedQueenBee)
        {
            ReplaceItem(ItemID.BeeKeeper);
        }

        if (Main.hardMode)
        {
            ReplaceItem(ItemID.BreakerBlade);
        }

        if (Utils.DownedMechBosses() == 1)
        {
            ReplaceItem(ItemID.CobaltSword);
        }

        if (Utils.DownedMechBosses() == 2)
        {
            ReplaceItem(ItemID.MythrilSword);
        }

        if (Utils.DownedMechBosses() == 3)
        {
            ReplaceItem(ItemID.TitaniumSword);
        }

        if (NPC.downedPlantBoss)
        {
            ReplaceItem(ItemID.Seedler);
        }

        if (NPC.downedMoonlord)
        {
            ReplaceItem(ItemID.TerraBlade);
        }

        NextSlot++;
    }

    void Bows()
    {
        if (GenVars.copperBar > 0)
        {
            ReplaceItem(ItemID.CopperBow);
        }
        else
        {
            ReplaceItem(ItemID.TinBow);
        }

        if (NPC.downedSlimeKing)
        {
            if (GenVars.ironBar > 0)
            {
                ReplaceItem(ItemID.IronBow);
            }
            else
            {
                ReplaceItem(ItemID.LeadBow);
            }
        }

        if (NPC.downedBoss1)
        {
            if (GenVars.silverBar > 0)
            {
                ReplaceItem(ItemID.SilverBow);
            }
            else
            {
                ReplaceItem(ItemID.TungstenBow);
            }
        }

        if (NPC.downedGoblins)
        {
            if (GenVars.goldBar > 0)
            {
                ReplaceItem(ItemID.GoldBow);
            }
            else
            {
                ReplaceItem(ItemID.PlatinumBow);
            }
        }

        if (NPC.downedBoss2)
        {
            if (GenVars.crimsonLeft)
            {
                ReplaceItem(ItemID.TendonBow);
            }
            else
            {
                ReplaceItem(ItemID.DemonBow);
            }
        }

        if (NPC.downedQueenBee)
        {
            ReplaceItem(ItemID.BeesKnees);
        }

        if (NPC.downedBoss3)
        {
            ReplaceItem(ItemID.MoltenFury);
        }

        if (Main.hardMode)
        {
            ReplaceItem(ItemID.Marrow);
        }

        if (Utils.DownedMechBosses() == 1)
        {
            ReplaceItem(ItemID.IceBow);
        }

        if (Utils.DownedMechBosses() == 2)
        {
            ReplaceItem(ItemID.DaedalusStormbow);
        }

        if (Utils.DownedMechBosses() == 3)
        {
            ReplaceItem(ItemID.ShadowFlameBow);
        }

        if (NPC.downedPlantBoss)
        {
            ReplaceItem(ItemID.DD2PhoenixBow);
        }

        if (NPC.downedMoonlord)
        {
            ReplaceItem(ItemID.Phantasm);
        }

        NextSlot++;
    }

    void MageWeapon()
    {
        ReplaceItem(ItemID.WandofSparking);

        if (NPC.downedSlimeKing)
        {
            ReplaceItem(ItemID.EmeraldStaff);
        }

        if (NPC.downedBoss1)
        {
            ReplaceItem(ItemID.AmberStaff);
        }

        if (NPC.downedGoblins)
        {
            ReplaceItem(ItemID.DiamondStaff);
        }

        if (NPC.downedBoss2)
        {
            ReplaceItem(ItemID.SpaceGun);
        }

        if (NPC.downedQueenBee)
        {
            ReplaceItem(ItemID.BookofSkulls);
        }

        if (NPC.downedBoss3)
        {
            ReplaceItem(ItemID.DemonScythe);
        }

        if (Main.hardMode)
        {
            ReplaceItem(ItemID.LaserRifle);
        }

        if (Utils.DownedMechBosses() == 1)
        {
            ReplaceItem(ItemID.SkyFracture);
        }

        if (Utils.DownedMechBosses() == 2)
        {
            ReplaceItem(ItemID.MagicDagger);
        }

        if (Utils.DownedMechBosses() == 3)
        {
            ReplaceItem(ItemID.FrostStaff);
        }

        if (NPC.downedPlantBoss)
        {
            ReplaceItem(ItemID.UnholyTrident);
        }

        if (NPC.downedGolemBoss)
        {
            ReplaceItem(ItemID.HeatRay);
        }

        if (NPC.downedFrost)
        {
            ReplaceItem(ItemID.Razorpine);
        }

        if (Utils.Kills(NPCID.DD2Betsy) > 0)
        {
            ReplaceItem(ItemID.ApprenticeStaffT3);
        }

        if (NPC.downedMartians)
        {
            ReplaceItem(ItemID.LaserMachinegun);
        }

        if (NPC.downedFishron)
        {
            ReplaceItem(ItemID.ChargedBlasterCannon);
        }

        if (NPC.downedAncientCultist)
        {
            ReplaceItem(ItemID.SpectreStaff);
        }

        if (NPC.downedMoonlord)
        {
            ReplaceItem(ItemID.Phantasm);
        }

        NextSlot++;
    }

    void SummonerWeapon()
    {
        ReplaceItem(ItemID.SlimeStaff);

        if (NPC.downedQueenBee)
        {
            ReplaceItem(ItemID.HornetStaff);
        }

        if (NPC.downedBoss3)
        {
            ReplaceItem(ItemID.ImpStaff);
        }

        if (Main.hardMode)
        {
            ReplaceItem(ItemID.SpiderStaff);
        }

        if (Utils.DownedMechBosses() == 1)
        {
            ReplaceItem(ItemID.OpticStaff);
        }

        if (Utils.DownedMechBosses() == 2)
        {
            ReplaceItem(ItemID.PygmyStaff);
        }

        if (Utils.DownedMechBosses() == 3)
        {
            ReplaceItem(ItemID.XenoStaff);
        }

        if (NPC.downedPlantBoss)
        {
            ReplaceItem(ItemID.RavenStaff);
        }

        if (NPC.downedGolemBoss)
        {
            ReplaceItem(ItemID.PirateStaff);
        }

        if (NPC.downedFrost)
        {
            ReplaceItem(ItemID.TempestStaff);
        }

        if (NPC.downedAncientCultist)
        {
            ReplaceItem(ItemID.DeadlySphereStaff);
        }

        if (NPC.downedMoonlord)
        {
            ReplaceItem(ItemID.StardustDragonStaff);
        }

        NextSlot++;
    }

    void Mounts()
    {
        AddItem(ItemID.FuzzyCarrot);

        if (Utils.Kills(NPCID.KingSlime) >= 3)
        {
            AddItem(ItemID.SlimySaddle);
        }

        if (Utils.Kills(NPCID.EyeofCthulhu) >= 3)
        {
            AddItem(ItemID.HardySaddle);
        }

        if (Utils.Kills(NPCID.QueenBee) >= 3)
        {
            AddItem(ItemID.HoneyedGoggles);
        }

        if (Main.hardMode)
        {
            AddItem(ItemID.AncientHorn);
        }

        if (Utils.Kills(NPCID.Retinazer) >= 3)
        {
            AddItem(ItemID.ReindeerBells);
        }

        if (Utils.Kills(NPCID.TheDestroyer) >= 3)
        {
            AddItem(ItemID.ScalyTruffle);
        }

        if (Utils.Kills(NPCID.SkeletronPrime) >= 3)
        {
            AddItem(ItemID.BrainScrambler);
        }

        if (Utils.Kills(NPCID.Plantera) >= 3)
        {
            AddItem(ItemID.BlessedApple);
        }

        if (Utils.Kills(NPCID.MartianSaucer) >= 3)
        {
            AddItem(ItemID.CosmicCarKey);
        }

        if (Utils.Kills(NPCID.DukeFishron) >= 3)
        {
            AddItem(ItemID.ShrimpyTruffle);
        }

        if (Utils.Kills(NPCID.MoonLordCore) >= 3)
        {
            AddItem(ItemID.DrillContainmentUnit);
        }
    }

    void Pets()
    {
        AddItem(ItemID.Seedling, Utils.UniversalPetCost);

        AddItem(ItemID.Carrot, Utils.UniversalPetCost);

        AddItem(ItemID.DogWhistle, Utils.UniversalPetCost);

        if (NPC.downedSlimeKing)
        {
            AddItem(ItemID.Fish, Utils.UniversalPetCost);

            AddItem(ItemID.ZephyrFish, Utils.UniversalPetCost);
        }

        if (Utils.DownedEyeOfCthulhu())
        {
            AddItem(ItemID.EyeSpring, Utils.UniversalPetCost);
        }

        if (NPC.downedGoblins)
        {
            AddItem(ItemID.BabyGrinchMischiefWhistle, Utils.UniversalPetCost);
        }

        if (Utils.DownedBrainOfCthulhu())
        {
            AddItem(ItemID.EatersBone, Utils.UniversalPetCost);

            AddItem(ItemID.BoneRattle, Utils.UniversalPetCost);
        }

        if (Utils.DownedSkeletron())
        {
            AddItem(ItemID.BoneKey, Utils.UniversalPetCost);

            AddItem(ItemID.TartarSauce, Utils.UniversalPetCost);
        }

        if (NPC.downedQueenBee)
        {
            AddItem(ItemID.Nectar, Utils.UniversalPetCost);
        }

        if (Main.hardMode)
        {
            AddItem(ItemID.CompanionCube, Utils.UniversalPetCost);

            AddItem(ItemID.AmberMosquito, Utils.UniversalPetCost);
        }

        if (NPC.downedPlantBoss)
        {
            AddItem(ItemID.TikiTotem, Utils.UniversalPetCost);
        }

        if (NPC.downedPirates)
        {
            AddItem(ItemID.ParrotCracker, Utils.UniversalPetCost);
        }

        if (NPC.downedFrost)
        {
            AddItem(ItemID.ToySled, Utils.UniversalPetCost);
        }

        if (NPC.downedHalloweenTree)
        {
            AddItem(ItemID.SpiderEgg, Utils.UniversalPetCost);

            AddItem(ItemID.CursedSapling, Utils.UniversalPetCost);
        }

        if (NPC.downedHalloweenKing)
        {
            AddItem(ItemID.UnluckyYarn, Utils.UniversalPetCost);

            AddItem(ItemID.MagicalPumpkinSeed, Utils.UniversalPetCost);
        }

        if (NPC.downedFishron)
        {
            AddItem(ItemID.Seaweed, Utils.UniversalPetCost);

            AddItem(ItemID.LizardEgg, Utils.UniversalPetCost);
        }

        if (NPC.downedAncientCultist)
        {
            AddItem(ItemID.DD2PetDragon, Utils.UniversalPetCost);

            AddItem(ItemID.DD2PetGato, Utils.UniversalPetCost);
        }

        if (NPC.downedMoonlord)
        {
            AddItem(ItemID.StrangeGlowingMushroom, Utils.UniversalPetCost);
        }
    }

    void Ores()
    {
        if (GenVars.copperBar > 0)
        {
            AddItem(ItemID.CopperOre, Utils.UniversalOreCost);
        }
        else
        {
            AddItem(ItemID.TinOre, Utils.UniversalOreCost);
        }

        if (NPC.downedSlimeKing)
        {
            if (GenVars.ironBar > 0)
            {
                AddItem(ItemID.IronOre, Utils.UniversalOreCost);
            }
            else
            {
                AddItem(ItemID.LeadOre, Utils.UniversalOreCost);
            }
        }

        if (NPC.downedBoss1)
        {
            if (GenVars.silverBar > 0)
            {
                AddItem(ItemID.SilverOre, Utils.UniversalOreCost);
            }
            else
            {
                AddItem(ItemID.TungstenOre, Utils.UniversalOreCost);
            }
        }

        if (NPC.downedBoss2)
        {
            if (GenVars.goldBar > 0)
            {
                AddItem(ItemID.GoldOre, Utils.UniversalOreCost);
            }
            else
            {
                AddItem(ItemID.PlatinumOre, Utils.UniversalOreCost);
            }
            AddItem(ItemID.Meteorite, Utils.UniversalOreCost);
        }

        if (NPC.downedBoss3)
        {
            if (GenVars.crimsonLeft)
            {
                AddItem(ItemID.CrimtaneOre, Utils.UniversalOreCost);
            }
            else
            {
                AddItem(ItemID.DemoniteOre, Utils.UniversalOreCost);
            }
        }

        if (Main.hardMode)
        {
            AddItem(ItemID.Hellstone, Utils.UniversalOreCost);
        }

        if (Utils.DownedMechBosses() == 1)
        {
            AddItem(ItemID.PalladiumOre, Utils.UniversalOreCost * 2);
            AddItem(ItemID.CobaltOre, Utils.UniversalOreCost * 2);
        }

        if (Utils.DownedMechBosses() == 2)
        {
            AddItem(ItemID.MythrilOre, Utils.UniversalOreCost * 3);
            AddItem(ItemID.OrichalcumOre, Utils.UniversalOreCost * 3);
        }

        if (Utils.DownedMechBosses() == 3)
        {
            AddItem(ItemID.AdamantiteOre, Utils.UniversalOreCost * 4);
            AddItem(ItemID.TitaniumOre, Utils.UniversalOreCost * 4);

            AddItem(ItemID.HallowedBar, Utils.UniversalOreCost * 5);
        }

        if (NPC.downedPlantBoss)
        {
            AddItem(ItemID.ChlorophyteOre, Utils.UniversalOreCost * 10);
        }

        if (NPC.downedMoonlord)
        {
            AddItem(ItemID.LunarOre, Utils.UniversalOreCost * 100);
        }
    }

    void Gear()
    {
        AddItem(ItemID.Sickle);
        if (!Main.hardMode)
            AddItem(ItemID.BugNet);
        else
            AddItem(ItemID.GoldenBugNet);
        Pickaxe();
        Axe();
        Hammer();
        Helmet();
        Breastplate();
        ShopGreaves();
        switch (Utils.GetPlayerClass())
        {
            case "melee":
                if (!NPC.downedBoss2)
                    Shortswords();
                Broadswords();
                break;

            case "ranged":
                Bows();
                break;

            case "mage":
                MageWeapon();
                break;

            case "summoner":
                SummonerWeapon();
                break;

            case "thrower":
                ThrowerWep();
                break;
        }
        HealPotion();
        ManaPotion();
        Torches();
        Arrows();
        Rope();
        LightPet();
        Hooks();
        AddItem(ItemID.PiggyBank);
        AddItem(ItemID.Safe);
        AddItem(ItemID.Wood, Utils.Coins(0, 1));
        BuffPotion();
        AddItem(ItemID.EmptyBucket, Utils.Coins(0, 0, 1));
        Wings();
    }

    void HealPotion()
    {
        ReplaceItem(ItemID.LesserHealingPotion);

        if (NPC.downedSlimeKing)
        {
            ReplaceItem(ItemID.Eggnog);
        }

        if (NPC.downedBoss1)
        {
            ReplaceItem(ItemID.LesserRestorationPotion);
        }

        if (NPC.downedBoss2)
        {
            ReplaceItem(ItemID.Honeyfin);
        }

        if (NPC.downedBoss3)
        {
            ReplaceItem(ItemID.HealingPotion);
        }

        if (Main.hardMode)
        {
            ReplaceItem(ItemID.RestorationPotion);
        }

        if (Utils.DownedMechBosses() == 1)
        {
            ReplaceItem(ItemID.StrangeBrew);
        }

        if (Utils.DownedMechBosses() == 2)
        {
            ReplaceItem(ItemID.GreaterHealingPotion);
        }

        if (NPC.downedMoonlord)
        {
            ReplaceItem(ItemID.SuperHealingPotion);
        }

        NextSlot++;
    }

    void ManaPotion()
    {
        ReplaceItem(ItemID.LesserManaPotion);

        if (NPC.downedBoss1)
        {
            ReplaceItem(ItemID.ManaPotion);
        }

        if (NPC.downedBoss3)
        {
            ReplaceItem(ItemID.GreaterManaPotion);
        }

        if (NPC.downedMoonlord)
        {
            ReplaceItem(ItemID.SuperManaPotion);
        }

        NextSlot++;
    }

    void Torches()
    {
        ReplaceItem(ItemID.CactusCandle, Utils.Coins(0, 1));
        if (NPC.downedSlimeKing)
        {
            ReplaceItem(ItemID.RichMahoganyCandle);
        }
        if (NPC.downedBoss1)
        {
            ReplaceItem(ItemID.Torch);
        }
        if (NPC.downedBoss3)
        {
            ReplaceItem(ItemID.BoneTorch);
        }
        if (Main.hardMode)
        {
            ReplaceItem(ItemID.CursedTorch);
        }
        if (NPC.downedMoonlord)
        {
            ReplaceItem(ItemID.UltrabrightTorch);
        }
        NextSlot++;
    }

    void Arrows()
    {
        ReplaceItem(ItemID.WoodenArrow);
        if (NPC.downedSlimeKing)
        {
            ReplaceItem(ItemID.BoneArrow);
        }
        if (NPC.downedBoss1)
        {
            ReplaceItem(ItemID.FlamingArrow);
        }
        if (NPC.downedBoss2)
        {
            ReplaceItem(ItemID.FrostburnArrow);
        }
        if (NPC.downedBoss3)
        {
            ReplaceItem(ItemID.JestersArrow);
        }
        if (Main.hardMode)
        {
            ReplaceItem(ItemID.UnholyArrow);
        }
        if (Utils.DownedMechBosses() == 1)
        {
            ReplaceItem(ItemID.HolyArrow);
        }
        if (Utils.DownedMechBosses() == 2)
        {
            ReplaceItem(ItemID.CursedArrow);
        }
        if (Utils.DownedMechBosses() == 3)
        {
            ReplaceItem(ItemID.IchorArrow);
        }
        if (NPC.downedPlantBoss)
        {
            ReplaceItem(ItemID.ChlorophyteArrow);
        }
        if (NPC.downedMoonlord)
        {
            ReplaceItem(ItemID.MoonlordArrow);
        }
        NextSlot++;
    }

    void Rope()
    {
        ReplaceItem(ItemID.VineRope, Utils.Coins(1));
        if (NPC.downedSlimeKing)
        {
            ReplaceItem(ItemID.Rope);
        }
        if (NPC.downedBoss3)
        {
            ReplaceItem(ItemID.Chain);
        }
        NextSlot++;
    }

    void LightPet()
    {
        ReplaceItem(ItemID.FairyBell);
        if (Main.hardMode)
        {
            ReplaceItem(ItemID.WispinaBottle);
        }
        NextSlot++;
    }

    void ThrowerWep()
    {
        ReplaceItem(ItemID.Snowball);
        if (NPC.downedSlimeKing)
        {
            ReplaceItem(ItemID.Shuriken);
        }
        if (NPC.downedBoss1)
        {
            ReplaceItem(ItemID.ThrowingKnife);
        }
        if (NPC.downedGoblins)
        {
            ReplaceItem(ItemID.PoisonedKnife);
        }
        if (NPC.downedBoss2)
        {
            ReplaceItem(ItemID.BoneDagger);
        }
        if (Utils.Kills(NPCID.DD2DarkMageT1) > 0)
        {
            ReplaceItem(ItemID.SpikyBall);
        }
        if (NPC.downedQueenBee)
        {
            ReplaceItem(ItemID.Javelin);
        }
        if (NPC.downedBoss3)
        {
            ReplaceItem(ItemID.Bone);
        }
        if (Main.hardMode)
        {
            ReplaceItem(ItemID.MolotovCocktail);
        }
        if (Utils.DownedMechBosses() == 1)
        {
            ReplaceItem(ItemID.BoneJavelin);
        }
        NextSlot++;
    }

    void Hooks()
    {
        ReplaceItem(ItemID.GrapplingHook);
        if (NPC.downedSlimeKing)
        {
            ReplaceItem(ItemID.AmethystHook);
        }
        if (NPC.downedBoss1)
        {
            ReplaceItem(ItemID.TopazHook);
        }
        if (NPC.downedGoblins)
        {
            ReplaceItem(ItemID.SapphireHook);
        }
        if (NPC.downedBoss2)
        {
            ReplaceItem(ItemID.EmeraldHook);
        }
        if (Utils.Kills(NPCID.DD2DarkMageT1) > 0)
        {
            ReplaceItem(ItemID.RubyHook);
        }
        if (NPC.downedQueenBee)
        {
            ReplaceItem(ItemID.DiamondHook);
        }
        if (NPC.downedBoss3)
        {
            ReplaceItem(ItemID.SkeletronHand);
        }
        if (Main.hardMode)
        {
            ReplaceItem(ItemID.IvyWhip);
        }
        if (Utils.DownedMechBosses() == 1)
        {
            ReplaceItem(ItemID.DualHook);
        }
        if (Utils.DownedMechBosses() == 2)
        {
            ReplaceItem(ItemID.SpookyHook);
        }
        if (Utils.DownedMechBosses() == 3)
        {
            ReplaceItem(ItemID.ChristmasHook);
        }
        if (NPC.downedMoonlord)
        {
            ReplaceItem(ItemID.LunarHook);
        }
        NextSlot++;
    }

    void BuffPotion()
    {
        switch (Utils.GetPlayerClass())
        {
            case "melee":
                AddItem(ItemID.ArcheryPotion, Utils.UniversalPotionCost);
                break;

            case "ranged":
                AddItem(ItemID.ArcheryPotion, Utils.UniversalPotionCost);
                break;

            case "mage":
                AddItem(ItemID.MagicPowerPotion, Utils.UniversalPotionCost);
                AddItem(ItemID.ManaRegenerationPotion, Utils.UniversalPotionCost);
                break;

            case "summoner":
                break;

            case "thrower":
                break;
        }
    }
}