using Terraria.WorldBuilding;

namespace MerchantsPlus.Shops;

public class ShopMerchant : Shop
{
    private enum ShopNames
    {
        Gear,
        Potions,
        Ores,
        Pets,
        Mounts
    }
    
    public override List<string> Shops { get; } = [
        nameof(ShopNames.Gear),
        nameof(ShopNames.Potions),
        nameof(ShopNames.Ores),
        nameof(ShopNames.Pets),
        nameof(ShopNames.Mounts)
    ];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        switch (shop)
        {
            case nameof(ShopNames.Mounts):
                Mounts();
                return;
            case nameof(ShopNames.Pets):
                Pets();
                return;
            case nameof(ShopNames.Ores):
                Ores();
                return;
            case nameof(ShopNames.Gear):
                Gear();
                return;
            case nameof(ShopNames.Potions):
                Potions();
                return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.Merchant);
    }

    private void Potions()
    {
        AddItem(ItemID.RecallPotion, Coins.Silver());
        
        AddItem(ItemID.WormholePotion, Coins.Silver());
        AddItem(ItemID.StinkPotion, ItemCosts.Potions);
        AddItem(ItemID.GenderChangePotion, Coins.Copper());
        AddItem(ItemID.LovePotion, ItemCosts.Potions);
        AddItem(ItemID.CalmingPotion, ItemCosts.Potions);
        AddItem(ItemID.HeartreachPotion, ItemCosts.Potions);
        AddItem(Progression.EyeOfCthulhu, ItemID.ObsidianSkinPotion, ItemCosts.Potions);

        if (Progression.Hardmode)
        {
            AddItem(Progression.Cultist ? ItemID.LuckPotionGreater : ItemID.LuckPotion, ItemCosts.Potions);
        }
        else
        {
            AddItem(ItemID.LuckPotionLesser, ItemCosts.Potions);
        }

        if (WorldUtils.HasNpc(NPCID.Angler))
        {
            AddItem(ItemID.FlipperPotion, ItemCosts.Potions);
            AddItem(ItemID.WaterWalkingPotion, ItemCosts.Potions);
            AddItem(ItemID.GillsPotion, ItemCosts.Potions);
            AddItem(ItemID.SonarPotion, ItemCosts.Potions);
            AddItem(ItemID.CratePotion, ItemCosts.Potions);
            AddItem(ItemID.FishingPotion, ItemCosts.Potions);
        }
        
        AddItem(WorldUtils.HasNpc(NPCID.Painter), ItemID.BuilderPotion, ItemCosts.Potions);
        AddItem(WorldUtils.HasNpc(NPCID.ArmsDealer), ItemID.AmmoReservationPotion, ItemCosts.Potions);
        
        AddItem(Progression.LevelFull() > 0, ItemID.FeatherfallPotion, ItemCosts.Potions);
        AddItem(Progression.LevelFull() > 1, ItemID.ShinePotion, ItemCosts.Potions);
        AddItem(Progression.LevelFull() > 2, ItemID.NightOwlPotion, ItemCosts.Potions);
        AddItem(Progression.LevelFull() > 3, ItemID.HunterPotion, ItemCosts.Potions);
        AddItem(Progression.LevelFull() > 4, ItemID.MiningPotion, ItemCosts.Potions);
        AddItem(Progression.LevelFull() > 5, ItemID.SpelunkerPotion, ItemCosts.Potions);
        AddItem(Progression.LevelFull() > 6, ItemID.SwiftnessPotion, ItemCosts.Potions);
        AddItem(Progression.LevelFull() > 7, ItemID.TitanPotion, ItemCosts.Potions);
        AddItem(Progression.LevelFull() > 8, ItemID.ThornsPotion, ItemCosts.Potions);
        AddItem(Progression.LevelFull() > 9, ItemID.WarmthPotion, ItemCosts.Potions);
        AddItem(Progression.LevelFull() > 10, ItemID.WrathPotion, ItemCosts.Potions);
        AddItem(Progression.LevelFull() > 11, ItemID.EndurancePotion, ItemCosts.Potions);
        AddItem(Progression.LevelFull() > 12, ItemID.IronskinPotion, ItemCosts.Potions);
        AddItem(Progression.LevelFull() > 13, ItemID.LifeforcePotion, ItemCosts.Potions);
        AddItem(Progression.LevelFull() > 14, ItemID.RegenerationPotion, ItemCosts.Potions);
        AddItem(Progression.LevelFull() > 15, ItemID.TrapsightPotion, ItemCosts.Potions);
        AddItem(Progression.LevelFull() > 16, ItemID.InfernoPotion, ItemCosts.Potions);
        AddItem(Progression.LevelFull() > 17, ItemID.InvisibilityPotion, ItemCosts.Potions);
        AddItem(Progression.LevelFull() > 18, ItemID.RagePotion, ItemCosts.Potions);
        AddItem(Progression.LevelFull() > 19, ItemID.TeleportationPotion, Coins.Silver());
        AddItem(Progression.LevelFull() > 20, ItemID.GravitationPotion, ItemCosts.Potions);
        
        // Room for 3 more potions...
    }

    private void Wings()
    {
        if (!Config.Instance.DisablePrehardmodeWings)
        {
            ReplaceItem(ItemID.CreativeWings, Coins.Gold(20)); // Fledgling wings
        }

        ReplaceItem(Progression.Hardmode,           ItemID.AngelWings,    Coins.Platinum());
        ReplaceItem(Progression.DownedMechs(1),     ItemID.DTownsWings,   Coins.Platinum());
        ReplaceItem(Progression.DownedMechs(2),     ItemID.CrownosWings,  Coins.Platinum());
        ReplaceItem(Progression.DownedMechs(3),     ItemID.CenxsWings,    Coins.Platinum());
        ReplaceItem(Progression.Plantera,           ItemID.JimsWings,     Coins.Platinum());
        ReplaceItem(Progression.Golem,              ItemID.LeinforsWings, Coins.Platinum());
        ReplaceItem(Progression.Fishron,            ItemID.FishronWings,  Coins.Platinum());

        switch (PlayerUtils.GetPlayerClass())
        {
            case PlayerClass.Melee:
                ReplaceItem(Progression.Moonlord, ItemID.WingsSolar, Coins.Platinum());
                break;
            case PlayerClass.Ranger:
                ReplaceItem(Progression.Moonlord, ItemID.WingsVortex, Coins.Platinum());
                break;
            case PlayerClass.Mage:
                ReplaceItem(Progression.Moonlord, ItemID.WingsNebula, Coins.Platinum());
                break;
            case PlayerClass.Summoner:
                ReplaceItem(Progression.Moonlord, ItemID.WingsStardust, Coins.Platinum());
                break;
            default:
                ReplaceItem(Progression.Moonlord, ItemID.WingsStardust, Coins.Platinum());
                break;
        }

        NextSlot++;
    }

    private void Pickaxe()
    {
        if (GenVars.ironBar > 0)
        {
            ReplaceItem(ItemID.IronPickaxe);
        }
        else
        {
            ReplaceItem(ItemID.LeadPickaxe);
        }

        if (Progression.EyeOfCthulhu)
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

        if (Progression.BrainOrEater)
        {
            if (WorldGen.crimson)
            {
                ReplaceItem(ItemID.DeathbringerPickaxe);
            }
            else
            {
                ReplaceItem(ItemID.NightmarePickaxe);
            }
        }

        ReplaceItem(Progression.Skeletron,      ItemID.MoltenPickaxe);
        ReplaceItem(Progression.DownedMechs(1), ItemID.CobaltPickaxe);
        ReplaceItem(Progression.DownedMechs(2), ItemID.MythrilPickaxe);
        ReplaceItem(Progression.DownedMechs(3), ItemID.ChlorophytePickaxe);
        ReplaceItem(Progression.Plantera,       ItemID.PickaxeAxe);
        ReplaceItem(Progression.Golem,          ItemID.Picksaw);

        if (Progression.Moonlord)
        {
            switch (PlayerUtils.GetPlayerClass())
            {
                case PlayerClass.Melee:
                    ReplaceItem(ItemID.SolarFlarePickaxe);
                    break;

                case PlayerClass.Ranger:
                    ReplaceItem(ItemID.VortexPickaxe);
                    break;

                case PlayerClass.Mage:
                    ReplaceItem(ItemID.NebulaPickaxe);
                    break;

                case PlayerClass.Summoner:
                    ReplaceItem(ItemID.StardustPickaxe);
                    break;
            }
        }

        NextSlot++;
    }

    private void Axe()
    {
        if (GenVars.ironBar > 0)
        {
            ReplaceItem(ItemID.IronAxe);
        }
        else
        {
            ReplaceItem(ItemID.LeadAxe);
        }

        if (Progression.EyeOfCthulhu)
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

        if (Progression.BrainOrEater)
        {
            if (WorldGen.crimson)
            {
                ReplaceItem(ItemID.BloodLustCluster);
            }
            else
            {
                ReplaceItem(ItemID.WarAxeoftheNight);
            }
        }

        ReplaceItem(Progression.Hardmode,       ItemID.MoltenHamaxe);
        ReplaceItem(Progression.DownedMechs(1), ItemID.CobaltWaraxe);
        ReplaceItem(Progression.DownedMechs(2), ItemID.MythrilWaraxe);
        ReplaceItem(Progression.DownedMechs(3), ItemID.ChlorophyteGreataxe);

        if (Progression.Moonlord)
        {
            switch (PlayerUtils.GetPlayerClass())
            {
                case PlayerClass.Melee:
                    ReplaceItem(ItemID.LunarHamaxeSolar);
                    break;

                case PlayerClass.Ranger:
                    ReplaceItem(ItemID.LunarHamaxeVortex);
                    break;

                case PlayerClass.Mage:
                    ReplaceItem(ItemID.LunarHamaxeNebula);
                    break;

                case PlayerClass.Summoner:
                    ReplaceItem(ItemID.LunarHamaxeStardust);
                    break;
            }
        }
        NextSlot++;
    }

    private void Hammer()
    {
        if (GenVars.ironBar > 0)
        {
            ReplaceItem(ItemID.IronHammer);
        }
        else
        {
            ReplaceItem(ItemID.LeadHammer);
        }

        if (Progression.EyeOfCthulhu)
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

        if (Progression.BrainOrEater)
        {
            if (WorldGen.crimson)
            {
                ReplaceItem(ItemID.FleshGrinder);
            }
            else
            {
                ReplaceItem(ItemID.TheBreaker);
            }
        }

        ReplaceItem(Progression.Skeletron,      ItemID.MoltenHamaxe);
        ReplaceItem(Progression.DownedMechs(2), ItemID.Hammush);
        ReplaceItem(Progression.DownedMechs(3), ItemID.ChlorophyteJackhammer);

        if (Progression.Moonlord)
        {
            switch (PlayerUtils.GetPlayerClass())
            {
                case PlayerClass.Melee:
                    ReplaceItem(ItemID.LunarHamaxeSolar);
                    break;

                case PlayerClass.Ranger:
                    ReplaceItem(ItemID.LunarHamaxeVortex);
                    break;

                case PlayerClass.Mage:
                    ReplaceItem(ItemID.LunarHamaxeNebula);
                    break;

                case PlayerClass.Summoner:
                    ReplaceItem(ItemID.LunarHamaxeStardust);
                    break;
            }
        }

        NextSlot++;
    }

    private void Helmet()
    {
        if (GenVars.copperBar > 0)
        {
            ReplaceItem(ItemID.CopperHelmet);
        }
        else
        {
            ReplaceItem(ItemID.TinHelmet);
        }

        if (Progression.SlimeKing)
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

        if (Progression.EyeOfCthulhu)
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

        if (Progression.BrainOrEater)
        {
            if (WorldGen.crimson)
            {
                ReplaceItem(ItemID.CrimsonHelmet);
            }
            else
            {
                ReplaceItem(ItemID.ShadowHelmet);
            }
        }

        if (Progression.Skeletron)
        {
            switch (PlayerUtils.GetPlayerClass())
            {
                case PlayerClass.Melee:
                    ReplaceItem(ItemID.MoltenHelmet);
                    break;

                case PlayerClass.Ranger:
                    ReplaceItem(ItemID.NecroHelmet);
                    break;

                case PlayerClass.Mage:
                    ReplaceItem(ItemID.JungleHat);
                    break;

                case PlayerClass.Summoner:
                    ReplaceItem(ItemID.BeeHeadgear);
                    break;
            }
        }

        if (Progression.DownedMechs(1))
        {
            switch (PlayerUtils.GetPlayerClass())
            {
                case PlayerClass.Melee:
                    ReplaceItem(ItemID.CobaltHelmet);
                    break;

                case PlayerClass.Ranger:
                    ReplaceItem(ItemID.CobaltMask);
                    break;

                case PlayerClass.Mage:
                    ReplaceItem(ItemID.CobaltHat);
                    break;

                case PlayerClass.Summoner:
                    ReplaceItem(ItemID.SpiderMask);
                    break;
            }
        }

        if (Progression.DownedMechs(2))
        {
            switch (PlayerUtils.GetPlayerClass())
            {
                case PlayerClass.Melee:
                    ReplaceItem(ItemID.MythrilHelmet);
                    break;

                case PlayerClass.Ranger:
                    ReplaceItem(ItemID.MythrilHat);
                    break;

                case PlayerClass.Mage:
                    ReplaceItem(ItemID.MythrilHood);
                    break;

                case PlayerClass.Summoner:
                    ReplaceItem(ItemID.SpookyHelmet);
                    break;
            }
        }

        if (Progression.DownedMechs(3))
        {
            switch (PlayerUtils.GetPlayerClass())
            {
                case PlayerClass.Melee:
                    ReplaceItem(ItemID.ChlorophyteMask);
                    break;

                case PlayerClass.Ranger:
                    ReplaceItem(ItemID.ChlorophyteHelmet);
                    break;

                case PlayerClass.Mage:
                    ReplaceItem(ItemID.ChlorophyteHeadgear);
                    break;

                case PlayerClass.Summoner:
                    ReplaceItem(ItemID.TikiMask);
                    break;
            }
        }

        if (Progression.Moonlord)
        {
            switch (PlayerUtils.GetPlayerClass())
            {
                case PlayerClass.Melee:
                    ReplaceItem(ItemID.SolarFlareHelmet);
                    break;

                case PlayerClass.Ranger:
                    ReplaceItem(ItemID.VortexHelmet);
                    break;

                case PlayerClass.Mage:
                    ReplaceItem(ItemID.NebulaHelmet);
                    break;

                case PlayerClass.Summoner:
                    ReplaceItem(ItemID.StardustHelmet);
                    break;
            }
        }

        NextSlot++;
    }

    private void Breastplate()
    {
        if (GenVars.copperBar > 0)
        {
            ReplaceItem(ItemID.CopperChainmail);
        }
        else
        {
            ReplaceItem(ItemID.TinChainmail);
        }

        if (Progression.SlimeKing)
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

        if (Progression.EyeOfCthulhu)
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

        if (Progression.BrainOrEater)
        {
            if (WorldGen.crimson)
            {
                ReplaceItem(ItemID.CrimsonScalemail);
            }
            else
            {
                ReplaceItem(ItemID.ShadowScalemail);
            }
        }

        if (Progression.Skeletron)
        {
            switch (PlayerUtils.GetPlayerClass())
            {
                case PlayerClass.Melee:
                    ReplaceItem(ItemID.MoltenBreastplate);
                    break;

                case PlayerClass.Ranger:
                    ReplaceItem(ItemID.NecroBreastplate);
                    break;

                case PlayerClass.Mage:
                    ReplaceItem(ItemID.JungleShirt);
                    break;

                case PlayerClass.Summoner:
                    ReplaceItem(ItemID.BeeBreastplate);
                    break;
            }
        }

        if (Progression.DownedMechs(1))
        {
            switch (PlayerUtils.GetPlayerClass())
            {
                case PlayerClass.Melee:
                case PlayerClass.Ranger:
                case PlayerClass.Mage:
                    ReplaceItem(ItemID.CobaltBreastplate);
                    break;

                case PlayerClass.Summoner:
                    ReplaceItem(ItemID.SpiderBreastplate);
                    break;
            }
        }

        if (Progression.DownedMechs(2))
        {
            switch (PlayerUtils.GetPlayerClass())
            {
                case PlayerClass.Melee:
                case PlayerClass.Ranger:
                case PlayerClass.Mage:
                    ReplaceItem(ItemID.MythrilChainmail);
                    break;

                case PlayerClass.Summoner:
                    ReplaceItem(ItemID.SpookyBreastplate);
                    break;
            }
        }

        if (Progression.DownedMechs(3))
        {
            switch (PlayerUtils.GetPlayerClass())
            {
                case PlayerClass.Melee:
                case PlayerClass.Ranger:
                case PlayerClass.Mage:
                    ReplaceItem(ItemID.ChlorophytePlateMail);
                    break;

                case PlayerClass.Summoner:
                    ReplaceItem(ItemID.TikiShirt);
                    break;
            }
        }

        if (Progression.Moonlord)
        {
            switch (PlayerUtils.GetPlayerClass())
            {
                case PlayerClass.Melee:
                    ReplaceItem(ItemID.SolarFlareBreastplate);
                    break;

                case PlayerClass.Ranger:
                    ReplaceItem(ItemID.VortexBreastplate);
                    break;

                case PlayerClass.Mage:
                    ReplaceItem(ItemID.NebulaBreastplate);
                    break;

                case PlayerClass.Summoner:
                    ReplaceItem(ItemID.StardustBreastplate);
                    break;
            }
        }

        NextSlot++;
    }

    private void ShopGreaves()
    {
        if (GenVars.copperBar > 0)
        {
            ReplaceItem(ItemID.CopperGreaves);
        }
        else
        {
            ReplaceItem(ItemID.TinGreaves);
        }

        if (Progression.SlimeKing)
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

        if (Progression.EyeOfCthulhu)
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

        if (Progression.BrainOrEater)
        {
            if (WorldGen.crimson)
            {
                ReplaceItem(ItemID.CrimsonGreaves);
            }
            else
            {
                ReplaceItem(ItemID.ShadowGreaves);
            }
        }

        if (Progression.Skeletron)
        {
            switch (PlayerUtils.GetPlayerClass())
            {
                case PlayerClass.Melee:
                    ReplaceItem(ItemID.MoltenGreaves);
                    break;

                case PlayerClass.Ranger:
                    ReplaceItem(ItemID.NecroGreaves);
                    break;

                case PlayerClass.Mage:
                    ReplaceItem(ItemID.JunglePants);
                    break;

                case PlayerClass.Summoner:
                    ReplaceItem(ItemID.BeeGreaves);
                    break;
            }
        }

        if (Progression.DownedMechs(1))
        {
            switch (PlayerUtils.GetPlayerClass())
            {
                case PlayerClass.Melee:
                case PlayerClass.Ranger:
                case PlayerClass.Mage:
                    ReplaceItem(ItemID.CobaltLeggings);
                    break;

                case PlayerClass.Summoner:
                    ReplaceItem(ItemID.SpiderGreaves);
                    break;
            }
        }

        if (Progression.DownedMechs(2))
        {
            switch (PlayerUtils.GetPlayerClass())
            {
                case PlayerClass.Melee:
                case PlayerClass.Ranger:
                case PlayerClass.Mage:
                    ReplaceItem(ItemID.MythrilGreaves);
                    break;

                case PlayerClass.Summoner:
                    ReplaceItem(ItemID.SpookyLeggings);
                    break;
            }
        }

        if (Progression.DownedMechs(3))
        {
            switch (PlayerUtils.GetPlayerClass())
            {
                case PlayerClass.Melee:
                case PlayerClass.Ranger:
                case PlayerClass.Mage:
                    ReplaceItem(ItemID.ChlorophyteGreaves);
                    break;

                case PlayerClass.Summoner:
                    ReplaceItem(ItemID.TikiPants);
                    break;
            }
        }

        if (Progression.Moonlord)
        {
            switch (PlayerUtils.GetPlayerClass())
            {
                case PlayerClass.Melee:
                    ReplaceItem(ItemID.SolarFlareLeggings);
                    break;

                case PlayerClass.Ranger:
                    ReplaceItem(ItemID.VortexLeggings);
                    break;

                case PlayerClass.Mage:
                    ReplaceItem(ItemID.NebulaLeggings);
                    break;

                case PlayerClass.Summoner:
                    ReplaceItem(ItemID.StardustLeggings);
                    break;
            }
        }
        NextSlot++;
    }

    private void Shortswords()
    {
        if (GenVars.ironBar > 0)
        {
            ReplaceItem(ItemID.IronShortsword);
        }
        else
        {
            ReplaceItem(ItemID.LeadShortsword);
        }

        if (Progression.EyeOfCthulhu)
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

    private void Broadswords()
    {
        if (GenVars.ironBar > 0)
        {
            ReplaceItem(ItemID.IronBroadsword);
        }
        else
        {
            ReplaceItem(ItemID.LeadBroadsword);
        }

        if (Progression.EyeOfCthulhu)
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

        if (Progression.BrainOrEater)
        {
            if (WorldGen.crimson)
            {
                ReplaceItem(ItemID.BloodButcherer);
            }
            else
            {
                ReplaceItem(ItemID.LightsBane);
            }
        }

        ReplaceItem(WorldUtils.Kills(NPCID.DD2DarkMageT1) > 0, ItemID.Arkhalis);
        ReplaceItem(Progression.QueenBee,                 ItemID.BeeKeeper);
        ReplaceItem(Progression.Hardmode,                 ItemID.BreakerBlade);
        ReplaceItem(Progression.DownedMechs(1),       ItemID.CobaltSword);
        ReplaceItem(Progression.DownedMechs(2),       ItemID.MythrilSword);
        ReplaceItem(Progression.DownedMechs(3),       ItemID.TitaniumSword);
        ReplaceItem(Progression.Plantera,                 ItemID.Seedler);
        ReplaceItem(Progression.Moonlord,                 ItemID.TerraBlade);

        NextSlot++;
    }

    private void Bows()
    {
        if (GenVars.ironBar > 0)
        {
            ReplaceItem(ItemID.IronBow);
        }
        else
        {
            ReplaceItem(ItemID.LeadBow);
        }

        if (Progression.EyeOfCthulhu)
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

        if (Progression.BrainOrEater)
        {
            if (WorldGen.crimson)
            {
                ReplaceItem(ItemID.TendonBow);
            }
            else
            {
                ReplaceItem(ItemID.DemonBow);
            }
        }

        ReplaceItem(Progression.QueenBee,           ItemID.BeesKnees);
        ReplaceItem(Progression.Skeletron,          ItemID.MoltenFury);
        ReplaceItem(Progression.Hardmode,           ItemID.Marrow);
        ReplaceItem(Progression.DownedMechs(1), ItemID.IceBow);
        ReplaceItem(Progression.DownedMechs(2), ItemID.DaedalusStormbow);
        ReplaceItem(Progression.DownedMechs(3), ItemID.ShadowFlameBow);
        ReplaceItem(Progression.Plantera,           ItemID.DD2PhoenixBow);
        ReplaceItem(Progression.Moonlord,           ItemID.Phantasm);

        NextSlot++;
    }

    private void MageWeapon()
    {
        ReplaceItem(ItemID.WandofSparking);

        ReplaceItem(Progression.SlimeKing,           ItemID.EmeraldStaff);
        ReplaceItem(Progression.EyeOfCthulhu,        ItemID.AmberStaff);
        ReplaceItem(Progression.GoblinArmy,          ItemID.DiamondStaff);
        ReplaceItem(Progression.BrainOrEater,        ItemID.SpaceGun);
        ReplaceItem(Progression.QueenBee,            ItemID.BookofSkulls);
        ReplaceItem(Progression.Skeletron,           ItemID.DemonScythe);
        ReplaceItem(Progression.Hardmode,            ItemID.LaserRifle);
        ReplaceItem(Progression.DownedMechs(1),  ItemID.SkyFracture);
        ReplaceItem(Progression.DownedMechs(2),  ItemID.MagicDagger);
        ReplaceItem(Progression.DownedMechs(3),  ItemID.FrostStaff);
        ReplaceItem(Progression.Plantera,            ItemID.UnholyTrident);
        ReplaceItem(Progression.Golem,               ItemID.HeatRay);
        ReplaceItem(NPC.downedFrost,                 ItemID.Razorpine);
        ReplaceItem(WorldUtils.Kills(NPCID.DD2Betsy) > 0, ItemID.ApprenticeStaffT3);
        ReplaceItem(NPC.downedMartians,              ItemID.LaserMachinegun);
        ReplaceItem(NPC.downedFishron,               ItemID.ChargedBlasterCannon);
        ReplaceItem(NPC.downedAncientCultist,        ItemID.SpectreStaff);
        ReplaceItem(Progression.Moonlord,            ItemID.Phantasm);

        NextSlot++;
    }

    private void SummonerWeapon()
    {
        ReplaceItem(ItemID.SlimeStaff, Coins.Gold(2));
        ReplaceItem(Progression.BloodMoon,          ItemID.VampireFrogStaff);
        ReplaceItem(Progression.QueenBee,           ItemID.HornetStaff);
        ReplaceItem(Progression.Skeletron,          ItemID.ImpStaff);
        ReplaceItem(Progression.Hardmode,           ItemID.SpiderStaff);
        ReplaceItem(Progression.DownedMechs(1), ItemID.OpticStaff);
        ReplaceItem(Progression.DownedMechs(2), ItemID.PygmyStaff);
        ReplaceItem(Progression.DownedMechs(3), ItemID.XenoStaff);
        ReplaceItem(Progression.Plantera,           ItemID.RavenStaff);
        ReplaceItem(Progression.Golem,              ItemID.PirateStaff);
        ReplaceItem(NPC.downedFrost,                ItemID.TempestStaff);
        ReplaceItem(NPC.downedAncientCultist,       ItemID.DeadlySphereStaff);
        ReplaceItem(Progression.Moonlord,           ItemID.StardustDragonStaff);

        NextSlot++;
    }

    private void Mounts()
    {
        AddItem(ItemID.FuzzyCarrot, ItemCosts.Mounts);

        AddItem(WorldUtils.Kills(NPCID.KingSlime) >= 1,      ItemID.SlimySaddle,          ItemCosts.Mounts);
        AddItem(WorldUtils.Kills(NPCID.EyeofCthulhu) >= 1,   ItemID.HardySaddle,          ItemCosts.Mounts);
        AddItem(WorldUtils.Kills(NPCID.QueenBee) >= 1,       ItemID.HoneyedGoggles,       ItemCosts.Mounts);
        AddItem(Progression.Hardmode,                   ItemID.AncientHorn,          ItemCosts.Mounts);
        AddItem(WorldUtils.Kills(NPCID.Retinazer) >= 1,      ItemID.ReindeerBells,        ItemCosts.Mounts);
        AddItem(WorldUtils.Kills(NPCID.TheDestroyer) >= 1,   ItemID.ScalyTruffle,         ItemCosts.Mounts);
        AddItem(WorldUtils.Kills(NPCID.SkeletronPrime) >= 1, ItemID.BrainScrambler,       ItemCosts.Mounts);
        AddItem(WorldUtils.Kills(NPCID.Plantera) >= 1,       ItemID.BlessedApple,         ItemCosts.Mounts);
        AddItem(WorldUtils.Kills(NPCID.MartianSaucer) >= 1,  ItemID.CosmicCarKey,         ItemCosts.Mounts);
        AddItem(WorldUtils.Kills(NPCID.DukeFishron) >= 1,    ItemID.ShrimpyTruffle,       ItemCosts.Mounts);
        AddItem(WorldUtils.Kills(NPCID.MoonLordCore) >= 1,   ItemID.DrillContainmentUnit, ItemCosts.Mounts);
    }

    private void Pets()
    {
        AddItem(ItemID.Seedling,   ItemCosts.Pets);
        AddItem(ItemID.Carrot,     ItemCosts.Pets);
        AddItem(ItemID.DogWhistle, ItemCosts.Pets);

        AddItem(Progression.SlimeKing,    ItemID.Fish,                      ItemCosts.Pets);
        AddItem(Progression.SlimeKing,    ItemID.ZephyrFish,                ItemCosts.Pets);
        AddItem(Progression.EyeOfCthulhu, ItemID.EyeSpring,                 ItemCosts.Pets);
        AddItem(Progression.GoblinArmy,   ItemID.BabyGrinchMischiefWhistle, ItemCosts.Pets);
        AddItem(Progression.EyeOfCthulhu, ItemID.EatersBone,                ItemCosts.Pets);
        AddItem(Progression.EyeOfCthulhu, ItemID.BoneRattle,                ItemCosts.Pets);
        AddItem(Progression.Skeletron,    ItemID.BoneKey,                   ItemCosts.Pets);
        AddItem(Progression.Skeletron,    ItemID.TartarSauce,               ItemCosts.Pets);
        AddItem(Progression.QueenBee,     ItemID.Nectar,                    ItemCosts.Pets);
        AddItem(Progression.Hardmode,     ItemID.CompanionCube,             ItemCosts.Pets);
        AddItem(Progression.Hardmode,     ItemID.AmberMosquito,             ItemCosts.Pets);
        AddItem(Progression.Plantera,     ItemID.TikiTotem,                 ItemCosts.Pets);
        AddItem(Progression.Pirates,      ItemID.ParrotCracker,             ItemCosts.Pets);
        AddItem(Progression.Christmas,    ItemID.ToySled,                   ItemCosts.Pets);

        if (Progression.Halloween)
        {
            AddItem(ItemID.SpiderEgg,          ItemCosts.Pets);
            AddItem(ItemID.CursedSapling,      ItemCosts.Pets);
            AddItem(ItemID.UnluckyYarn,        ItemCosts.Pets);
            AddItem(ItemID.MagicalPumpkinSeed, ItemCosts.Pets);
        }

        AddItem(Progression.Fishron,  ItemID.Seaweed,                ItemCosts.Pets);
        AddItem(Progression.Fishron,  ItemID.LizardEgg,              ItemCosts.Pets);
        AddItem(Progression.Cultist,  ItemID.DD2PetDragon,           ItemCosts.Pets);
        AddItem(Progression.Cultist,  ItemID.DD2PetGato,             ItemCosts.Pets);
        AddItem(Progression.Moonlord, ItemID.StrangeGlowingMushroom, ItemCosts.Pets);
    }

    private void Ores()
    {
        AddItem(GenVars.copperBar > 0 ? ItemID.CopperBar : ItemID.TinBar, 50);

        if (Progression.SlimeKing)
        {
            AddItem(GenVars.ironBar > 0 ? ItemID.IronBar : ItemID.LeadBar, 100);
            AddItem(GenVars.silverBar > 0 ? ItemID.SilverBar : ItemID.TungstenBar, 150);
            AddItem(GenVars.goldBar > 0 ? ItemID.GoldBar : ItemID.PlatinumBar, 200);
        }

        if (Progression.EyeOfCthulhu)
        {
            AddItem(WorldGen.crimson ? ItemID.CrimtaneBar : ItemID.DemoniteBar, 250);
        }

        if (Progression.BrainOrEater)
        {
            AddItem(ItemID.MeteoriteBar, 300);
            AddItem(Progression.Hardmode, ItemID.HellstoneBar, 350);
        }

        if (Progression.DownedMechs(1))
        {
            AddItem(ItemID.PalladiumBar, 400);
            AddItem(ItemID.CobaltBar, 400);
        }

        if (Progression.DownedMechs(2))
        {
            AddItem(ItemID.MythrilBar, 450);
            AddItem(ItemID.OrichalcumBar, 450);
        }

        if (Progression.DownedMechs(3))
        {
            AddItem(ItemID.AdamantiteBar, 500);
            AddItem(ItemID.TitaniumBar, 500);

            AddItem(ItemID.HallowedBar, 550);
        }

        AddItem(Progression.Plantera, ItemID.ChlorophyteBar, 600);
        AddItem(Progression.Moonlord, ItemID.LunarBar, 650);
    }

    private void FishingRod()
    {
        ReplaceItem(ItemID.WoodFishingPole, Coins.Silver(10));

        int progression = Progression.LevelFull();

        ReplaceItem(progression > 0, ItemID.ReinforcedFishingPole, Coins.Silver(25));
        ReplaceItem(progression > 1, ItemID.FisherofSouls, Coins.Gold());
        ReplaceItem(progression > 2, ItemID.FiberglassFishingPole, Coins.Gold(10));
        ReplaceItem(progression > 3, ItemID.MechanicsRod, Coins.Gold(25));
        ReplaceItem(progression > 4, ItemID.SittingDucksFishingRod, Coins.Gold(50));
        ReplaceItem(progression > 5, ItemID.HotlineFishingHook, Coins.Platinum());
        ReplaceItem(progression > 6, ItemID.GoldenFishingRod, Coins.Platinum(2));

        NextSlot++;
    }

    private void Gear()
    {
        AddItem(ItemID.Sickle);

        if (!Main.hardMode)
        {
            AddItem(ItemID.BugNet);
        }
        else
        {
            AddItem(ItemID.GoldenBugNet);
        }

        FishingRod();
        Pickaxe();
        Axe();
        Hammer();
        Helmet();
        Breastplate();
        ShopGreaves();

        switch (PlayerUtils.GetPlayerClass())
        {
            case PlayerClass.Melee:
                if (!NPC.downedBoss2)
                {
                    Shortswords();
                }

                Broadswords();
                break;

            case PlayerClass.Ranger:
                Bows();
                break;

            case PlayerClass.Mage:
                MageWeapon();
                break;

            case PlayerClass.Summoner:
                SummonerWeapon();
                break;

            case PlayerClass.Thrower:
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
        Boots();

        AddItem(ItemID.PiggyBank);
        AddItem(ItemID.Safe, Coins.Gold());
        AddItem(ItemID.Wood, Coins.Silver());

        BuffPotion();

        AddItem(ItemID.EmptyBucket, Coins.Gold());

        Wings();
    }

    private void Boots()
    {
        ReplaceItem(ItemID.HermesBoots);

        ReplaceItem(Progression.EyeOfCthulhu, ItemID.FlurryBoots);
        ReplaceItem(Progression.BrainOrEater, ItemID.SailfishBoots);
        ReplaceItem(Progression.QueenBee, ItemID.SandBoots);
        ReplaceItem(Progression.Plantera, ItemID.AmphibianBoots);
        ReplaceItem(Progression.WallOfFlesh, ItemID.SpectreBoots);
        ReplaceItem(Progression.DownedMechs(1), ItemID.FairyBoots);
        ReplaceItem(Progression.DownedMechs(2), ItemID.HellfireTreads);
        ReplaceItem(Progression.DownedMechs(3), ItemID.LightningBoots);
        ReplaceItem(Progression.Golem, ItemID.FrostsparkBoots);
        ReplaceItem(Progression.Moonlord, ItemID.TerrasparkBoots);

        NextSlot++;
    }


    private void HealPotion()
    {
        ReplaceItem(ItemID.LesserHealingPotion);

        ReplaceItem(Progression.SlimeKing,          ItemID.Eggnog);
        ReplaceItem(Progression.EyeOfCthulhu,       ItemID.LesserRestorationPotion);
        ReplaceItem(Progression.BrainOrEater,       ItemID.Honeyfin);
        ReplaceItem(Progression.Skeletron,          ItemID.HealingPotion);
        ReplaceItem(Progression.Hardmode,           ItemID.RestorationPotion);
        ReplaceItem(Progression.DownedMechs(1), ItemID.StrangeBrew);
        ReplaceItem(Progression.DownedMechs(2), ItemID.GreaterHealingPotion);
        ReplaceItem(Progression.Moonlord,           ItemID.SuperHealingPotion);

        NextSlot++;
    }

    private void ManaPotion()
    {
        ReplaceItem(ItemID.LesserManaPotion);

        ReplaceItem(Progression.EyeOfCthulhu, ItemID.ManaPotion);
        ReplaceItem(Progression.Skeletron,    ItemID.GreaterManaPotion);
        ReplaceItem(Progression.Moonlord,     ItemID.SuperManaPotion);

        NextSlot++;
    }

    private void Torches()
    {
        ReplaceItem(ItemID.CactusCandle, Coins.Silver());

        ReplaceItem(Progression.SlimeKing,    ItemID.RichMahoganyCandle);
        ReplaceItem(Progression.EyeOfCthulhu, ItemID.Torch);
        ReplaceItem(Progression.Skeletron,    ItemID.BoneTorch);
        ReplaceItem(Progression.Hardmode,     ItemID.CursedTorch);
        ReplaceItem(Progression.Moonlord,     ItemID.UltrabrightTorch);

        NextSlot++;
    }

    private void Arrows()
    {
        ReplaceItem(ItemID.WoodenArrow);

        ReplaceItem(Progression.SlimeKing,          ItemID.BoneArrow);
        ReplaceItem(Progression.EyeOfCthulhu,       ItemID.FlamingArrow);
        ReplaceItem(Progression.BrainOrEater,       ItemID.FrostburnArrow);
        ReplaceItem(Progression.Skeletron,          ItemID.JestersArrow);
        ReplaceItem(Progression.Hardmode,           ItemID.UnholyArrow);
        ReplaceItem(Progression.DownedMechs(1), ItemID.HolyArrow);
        ReplaceItem(Progression.DownedMechs(2), ItemID.CursedArrow);
        ReplaceItem(Progression.DownedMechs(3), ItemID.IchorArrow);
        ReplaceItem(Progression.Plantera,           ItemID.ChlorophyteArrow);
        ReplaceItem(Progression.Moonlord,           ItemID.MoonlordArrow);

        NextSlot++;
    }

    private void Rope()
    {
        ReplaceItem(ItemID.VineRope, Coins.Copper());

        ReplaceItem(Progression.SlimeKing, ItemID.Rope);
        ReplaceItem(Progression.Skeletron, ItemID.Chain);

        NextSlot++;
    }

    private void LightPet()
    {
        ReplaceItem(ItemID.FairyBell, Coins.Gold(2));

        ReplaceItem(Progression.Hardmode, ItemID.WispinaBottle);

        NextSlot++;
    }

    private void ThrowerWep()
    {
        ReplaceItem(ItemID.Snowball);

        ReplaceItem(Progression.SlimeKing,                ItemID.Shuriken);
        ReplaceItem(Progression.EyeOfCthulhu,             ItemID.ThrowingKnife);
        ReplaceItem(Progression.GoblinArmy,               ItemID.PoisonedKnife);
        ReplaceItem(Progression.BrainOrEater,             ItemID.BoneDagger);
        ReplaceItem(WorldUtils.Kills(NPCID.DD2DarkMageT1) > 0, ItemID.SpikyBall);
        ReplaceItem(Progression.QueenBee,                 ItemID.Javelin);
        ReplaceItem(Progression.Skeletron,                ItemID.Bone);
        ReplaceItem(Progression.Hardmode,                 ItemID.MolotovCocktail);
        ReplaceItem(Progression.DownedMechs(1),       ItemID.BoneJavelin);

        NextSlot++;
    }

    private void Hooks()
    {
        ReplaceItem(ItemID.GrapplingHook);

        ReplaceItem(Progression.SlimeKing,                ItemID.AmethystHook);
        ReplaceItem(Progression.EyeOfCthulhu,             ItemID.TopazHook);
        ReplaceItem(Progression.GoblinArmy,               ItemID.SapphireHook);
        ReplaceItem(Progression.BrainOrEater,             ItemID.EmeraldHook);
        ReplaceItem(WorldUtils.Kills(NPCID.DD2DarkMageT1) > 0, ItemID.RubyHook);
        ReplaceItem(Progression.QueenBee,                 ItemID.DiamondHook);
        ReplaceItem(Progression.Skeletron,                ItemID.SkeletronHand);
        ReplaceItem(Progression.Hardmode,                 ItemID.IvyWhip);
        ReplaceItem(Progression.DownedMechs(1),       ItemID.DualHook);
        ReplaceItem(Progression.DownedMechs(2),       ItemID.SpookyHook);
        ReplaceItem(Progression.DownedMechs(3),       ItemID.ChristmasHook);
        ReplaceItem(Progression.Moonlord,                 ItemID.LunarHook);

        NextSlot++;
    }

    private void BuffPotion()
    {
        switch (PlayerUtils.GetPlayerClass())
        {
            case PlayerClass.Melee:
                AddItem(ItemID.ArcheryPotion, ItemCosts.Potions);
                break;

            case PlayerClass.Ranger:
                AddItem(ItemID.ArcheryPotion, ItemCosts.Potions);
                break;

            case PlayerClass.Mage:
                AddItem(ItemID.MagicPowerPotion, ItemCosts.Potions);
                AddItem(ItemID.ManaRegenerationPotion, ItemCosts.Potions);
                break;

            case PlayerClass.Summoner:
                break;

            case PlayerClass.Thrower:
                break;
        }
    }
}