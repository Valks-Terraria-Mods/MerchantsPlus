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

        Action openShop = shop switch
        {
            nameof(ShopNames.Mounts) => Mounts,
            nameof(ShopNames.Pets) => Pets,
            nameof(ShopNames.Ores) => Ores,
            nameof(ShopNames.Gear) => Gear,
            nameof(ShopNames.Potions) => Potions,
            _ => () => Inv.SetupShop(ShopType.Merchant)
        };
        openShop();
    }

    private void Potions()
    {
        int progression = Progression.LevelFull();

        AddItem(ItemID.RecallPotion, Coins.Silver());

        AddItem(ItemID.WormholePotion, Coins.Silver());
        AddItem(ItemID.StinkPotion, ItemCosts.Potions);
        AddItem(ItemID.GenderChangePotion, Coins.Copper());
        AddItemsAtPrice(ItemCosts.Potions, ShopMerchantCatalog.SupportPotions);
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
            AddItemsAtPrice(ItemCosts.Potions, ShopMerchantCatalog.FishingPotions);
        }

        AddItem(WorldUtils.HasNpc(NPCID.Painter), ItemID.BuilderPotion, ItemCosts.Potions);
        AddItem(WorldUtils.HasNpc(NPCID.ArmsDealer), ItemID.AmmoReservationPotion, ItemCosts.Potions);
        AddProgressionItems(progression, ShopMerchantCatalog.ProgressionPotions);

        // Room for 3 more potions...
    }

    private void Wings()
    {
        if (!Config.Instance.DisablePrehardmodeWings)
        {
            ReplaceItem(ItemID.CreativeWings, Coins.Gold(20)); // Fledgling wings
        }

        ReplaceItem(Progression.Hardmode, ItemID.AngelWings, Coins.Platinum());
        ReplaceItem(Progression.DownedMechs(1), ItemID.DTownsWings, Coins.Platinum());
        ReplaceItem(Progression.DownedMechs(2), ItemID.CrownosWings, Coins.Platinum());
        ReplaceItem(Progression.DownedMechs(3), ItemID.CenxsWings, Coins.Platinum());
        ReplaceItem(Progression.Plantera, ItemID.JimsWings, Coins.Platinum());
        ReplaceItem(Progression.Golem, ItemID.LeinforsWings, Coins.Platinum());
        ReplaceItem(Progression.Fishron, ItemID.FishronWings, Coins.Platinum());
        ReplaceItem(Progression.Moonlord, GetClassItem(ShopMerchantCatalog.MoonlordWings), Coins.Platinum());

        NextSlot++;
    }

    private void Pickaxe()
    {
        ReplaceItem(IronOrLead(ItemID.IronPickaxe, ItemID.LeadPickaxe));
        ReplaceItem(Progression.EyeOfCthulhu, GoldOrPlatinum(ItemID.GoldPickaxe, ItemID.PlatinumPickaxe));
        ReplaceItem(Progression.BrainOrEater, CorruptionOrCrimson(ItemID.NightmarePickaxe, ItemID.DeathbringerPickaxe));

        ReplaceItem(Progression.Skeletron, ItemID.MoltenPickaxe);
        ReplaceItem(Progression.DownedMechs(1), ItemID.CobaltPickaxe);
        ReplaceItem(Progression.DownedMechs(2), ItemID.MythrilPickaxe);
        ReplaceItem(Progression.DownedMechs(3), ItemID.ChlorophytePickaxe);
        ReplaceItem(Progression.Plantera, ItemID.PickaxeAxe);
        ReplaceItem(Progression.Golem, ItemID.Picksaw);
        ReplaceClassItem(Progression.Moonlord, ShopMerchantCatalog.MoonlordPickaxes);

        NextSlot++;
    }

    private void Axe()
    {
        ReplaceItem(IronOrLead(ItemID.IronAxe, ItemID.LeadAxe));
        ReplaceItem(Progression.EyeOfCthulhu, GoldOrPlatinum(ItemID.GoldAxe, ItemID.PlatinumAxe));
        ReplaceItem(Progression.BrainOrEater, CorruptionOrCrimson(ItemID.WarAxeoftheNight, ItemID.BloodLustCluster));

        ReplaceItem(Progression.Hardmode, ItemID.MoltenHamaxe);
        ReplaceItem(Progression.DownedMechs(1), ItemID.CobaltWaraxe);
        ReplaceItem(Progression.DownedMechs(2), ItemID.MythrilWaraxe);
        ReplaceItem(Progression.DownedMechs(3), ItemID.ChlorophyteGreataxe);
        ReplaceClassItem(Progression.Moonlord, ShopMerchantCatalog.MoonlordHamaxes);
        NextSlot++;
    }

    private void Hammer()
    {
        ReplaceItem(IronOrLead(ItemID.IronHammer, ItemID.LeadHammer));
        ReplaceItem(Progression.EyeOfCthulhu, GoldOrPlatinum(ItemID.GoldHammer, ItemID.PlatinumHammer));
        ReplaceItem(Progression.BrainOrEater, CorruptionOrCrimson(ItemID.TheBreaker, ItemID.FleshGrinder));

        ReplaceItem(Progression.Skeletron, ItemID.MoltenHamaxe);
        ReplaceItem(Progression.DownedMechs(2), ItemID.Hammush);
        ReplaceItem(Progression.DownedMechs(3), ItemID.ChlorophyteJackhammer);
        ReplaceClassItem(Progression.Moonlord, ShopMerchantCatalog.MoonlordHamaxes);

        NextSlot++;
    }

    private void Helmet()
    {
        ReplaceItem(CopperOrTin(ItemID.CopperHelmet, ItemID.TinHelmet));
        ReplaceItem(Progression.SlimeKing, IronOrLead(ItemID.IronHelmet, ItemID.LeadHelmet));
        ReplaceItem(Progression.EyeOfCthulhu, GoldOrPlatinum(ItemID.GoldHelmet, ItemID.PlatinumHelmet));
        ReplaceItem(Progression.BrainOrEater, CorruptionOrCrimson(ItemID.ShadowHelmet, ItemID.CrimsonHelmet));

        ReplaceClassItem(Progression.Skeletron, ShopMerchantCatalog.SkeletronHelmets);
        ReplaceClassItem(Progression.DownedMechs(1), ShopMerchantCatalog.MechTierOneHelmets);
        ReplaceClassItem(Progression.DownedMechs(2), ShopMerchantCatalog.MechTierTwoHelmets);
        ReplaceClassItem(Progression.DownedMechs(3), ShopMerchantCatalog.MechTierThreeHelmets);
        ReplaceClassItem(Progression.Moonlord, ShopMerchantCatalog.MoonlordHelmets);

        NextSlot++;
    }

    private void Breastplate()
    {
        ReplaceItem(CopperOrTin(ItemID.CopperChainmail, ItemID.TinChainmail));
        ReplaceItem(Progression.SlimeKing, IronOrLead(ItemID.IronChainmail, ItemID.LeadChainmail));
        ReplaceItem(Progression.EyeOfCthulhu, GoldOrPlatinum(ItemID.GoldChainmail, ItemID.PlatinumChainmail));
        ReplaceItem(Progression.BrainOrEater, CorruptionOrCrimson(ItemID.ShadowScalemail, ItemID.CrimsonScalemail));

        ReplaceClassItem(Progression.Skeletron, ShopMerchantCatalog.SkeletronBreastplates);
        ReplaceClassItem(Progression.DownedMechs(1), ShopMerchantCatalog.MechTierOneBreastplates);
        ReplaceClassItem(Progression.DownedMechs(2), ShopMerchantCatalog.MechTierTwoBreastplates);
        ReplaceClassItem(Progression.DownedMechs(3), ShopMerchantCatalog.MechTierThreeBreastplates);
        ReplaceClassItem(Progression.Moonlord, ShopMerchantCatalog.MoonlordBreastplates);

        NextSlot++;
    }

    private void ShopGreaves()
    {
        ReplaceItem(CopperOrTin(ItemID.CopperGreaves, ItemID.TinGreaves));
        ReplaceItem(Progression.SlimeKing, IronOrLead(ItemID.IronGreaves, ItemID.LeadGreaves));
        ReplaceItem(Progression.EyeOfCthulhu, GoldOrPlatinum(ItemID.GoldGreaves, ItemID.PlatinumGreaves));
        ReplaceItem(Progression.BrainOrEater, CorruptionOrCrimson(ItemID.ShadowGreaves, ItemID.CrimsonGreaves));

        ReplaceClassItem(Progression.Skeletron, ShopMerchantCatalog.SkeletronGreaves);
        ReplaceClassItem(Progression.DownedMechs(1), ShopMerchantCatalog.MechTierOneGreaves);
        ReplaceClassItem(Progression.DownedMechs(2), ShopMerchantCatalog.MechTierTwoGreaves);
        ReplaceClassItem(Progression.DownedMechs(3), ShopMerchantCatalog.MechTierThreeGreaves);
        ReplaceClassItem(Progression.Moonlord, ShopMerchantCatalog.MoonlordGreaves);

        NextSlot++;
    }

    private void Shortswords()
    {
        ReplaceItem(IronOrLead(ItemID.IronShortsword, ItemID.LeadShortsword));
        ReplaceItem(Progression.EyeOfCthulhu, GoldOrPlatinum(ItemID.GoldShortsword, ItemID.PlatinumShortsword));

        NextSlot++;
    }

    private void Broadswords()
    {
        ReplaceItem(IronOrLead(ItemID.IronBroadsword, ItemID.LeadBroadsword));
        ReplaceItem(Progression.EyeOfCthulhu, GoldOrPlatinum(ItemID.GoldBroadsword, ItemID.PlatinumBroadsword));
        ReplaceItem(Progression.BrainOrEater, CorruptionOrCrimson(ItemID.LightsBane, ItemID.BloodButcherer));

        ReplaceItem(WorldUtils.Kills(NPCID.DD2DarkMageT1) > 0, ItemID.Arkhalis);
        ReplaceItem(Progression.QueenBee, ItemID.BeeKeeper);
        ReplaceItem(Progression.Hardmode, ItemID.BreakerBlade);
        ReplaceItem(Progression.DownedMechs(1), ItemID.CobaltSword);
        ReplaceItem(Progression.DownedMechs(2), ItemID.MythrilSword);
        ReplaceItem(Progression.DownedMechs(3), ItemID.TitaniumSword);
        ReplaceItem(Progression.Plantera, ItemID.Seedler);
        ReplaceItem(Progression.Moonlord, ItemID.TerraBlade);

        NextSlot++;
    }

    private void Bows()
    {
        ReplaceItem(IronOrLead(ItemID.IronBow, ItemID.LeadBow));
        ReplaceItem(Progression.EyeOfCthulhu, GoldOrPlatinum(ItemID.GoldBow, ItemID.PlatinumBow));
        ReplaceItem(Progression.BrainOrEater, CorruptionOrCrimson(ItemID.DemonBow, ItemID.TendonBow));

        ReplaceItem(Progression.QueenBee, ItemID.BeesKnees);
        ReplaceItem(Progression.Skeletron, ItemID.MoltenFury);
        ReplaceItem(Progression.Hardmode, ItemID.Marrow);
        ReplaceItem(Progression.DownedMechs(1), ItemID.IceBow);
        ReplaceItem(Progression.DownedMechs(2), ItemID.DaedalusStormbow);
        ReplaceItem(Progression.DownedMechs(3), ItemID.ShadowFlameBow);
        ReplaceItem(Progression.Plantera, ItemID.DD2PhoenixBow);
        ReplaceItem(Progression.Moonlord, ItemID.Phantasm);

        NextSlot++;
    }

    private void MageWeapon()
    {
        ReplaceItem(ItemID.WandofSparking);

        ReplaceItem(Progression.SlimeKing, ItemID.EmeraldStaff);
        ReplaceItem(Progression.EyeOfCthulhu, ItemID.AmberStaff);
        ReplaceItem(Progression.GoblinArmy, ItemID.DiamondStaff);
        ReplaceItem(Progression.BrainOrEater, ItemID.SpaceGun);
        ReplaceItem(Progression.QueenBee, ItemID.BookofSkulls);
        ReplaceItem(Progression.Skeletron, ItemID.DemonScythe);
        ReplaceItem(Progression.Hardmode, ItemID.LaserRifle);
        ReplaceItem(Progression.DownedMechs(1), ItemID.SkyFracture);
        ReplaceItem(Progression.DownedMechs(2), ItemID.MagicDagger);
        ReplaceItem(Progression.DownedMechs(3), ItemID.FrostStaff);
        ReplaceItem(Progression.Plantera, ItemID.UnholyTrident);
        ReplaceItem(Progression.Golem, ItemID.HeatRay);
        ReplaceItem(NPC.downedFrost, ItemID.Razorpine);
        ReplaceItem(WorldUtils.Kills(NPCID.DD2Betsy) > 0, ItemID.ApprenticeStaffT3);
        ReplaceItem(NPC.downedMartians, ItemID.LaserMachinegun);
        ReplaceItem(NPC.downedFishron, ItemID.ChargedBlasterCannon);
        ReplaceItem(NPC.downedAncientCultist, ItemID.SpectreStaff);
        ReplaceItem(Progression.Moonlord, ItemID.Phantasm);

        NextSlot++;
    }

    private void SummonerWeapon()
    {
        ReplaceItem(ItemID.SlimeStaff, Coins.Gold(2));
        ReplaceItem(Progression.BloodMoon, ItemID.VampireFrogStaff);
        ReplaceItem(Progression.QueenBee, ItemID.HornetStaff);
        ReplaceItem(Progression.Skeletron, ItemID.ImpStaff);
        ReplaceItem(Progression.Hardmode, ItemID.SpiderStaff);
        ReplaceItem(Progression.DownedMechs(1), ItemID.OpticStaff);
        ReplaceItem(Progression.DownedMechs(2), ItemID.PygmyStaff);
        ReplaceItem(Progression.DownedMechs(3), ItemID.XenoStaff);
        ReplaceItem(Progression.Plantera, ItemID.RavenStaff);
        ReplaceItem(Progression.Golem, ItemID.PirateStaff);
        ReplaceItem(NPC.downedFrost, ItemID.TempestStaff);
        ReplaceItem(NPC.downedAncientCultist, ItemID.DeadlySphereStaff);
        ReplaceItem(Progression.Moonlord, ItemID.StardustDragonStaff);

        NextSlot++;
    }

    private void Mounts()
    {
        AddItem(ItemID.FuzzyCarrot, ItemCosts.Mounts);

        AddItem(WorldUtils.Kills(NPCID.KingSlime) >= 1, ItemID.SlimySaddle, ItemCosts.Mounts);
        AddItem(WorldUtils.Kills(NPCID.EyeofCthulhu) >= 1, ItemID.HardySaddle, ItemCosts.Mounts);
        AddItem(WorldUtils.Kills(NPCID.QueenBee) >= 1, ItemID.HoneyedGoggles, ItemCosts.Mounts);
        AddItem(Progression.Hardmode, ItemID.AncientHorn, ItemCosts.Mounts);
        AddItem(WorldUtils.Kills(NPCID.Retinazer) >= 1, ItemID.ReindeerBells, ItemCosts.Mounts);
        AddItem(WorldUtils.Kills(NPCID.TheDestroyer) >= 1, ItemID.ScalyTruffle, ItemCosts.Mounts);
        AddItem(WorldUtils.Kills(NPCID.SkeletronPrime) >= 1, ItemID.BrainScrambler, ItemCosts.Mounts);
        AddItem(WorldUtils.Kills(NPCID.Plantera) >= 1, ItemID.BlessedApple, ItemCosts.Mounts);
        AddItem(WorldUtils.Kills(NPCID.MartianSaucer) >= 1, ItemID.CosmicCarKey, ItemCosts.Mounts);
        AddItem(WorldUtils.Kills(NPCID.DukeFishron) >= 1, ItemID.ShrimpyTruffle, ItemCosts.Mounts);
        AddItem(WorldUtils.Kills(NPCID.MoonLordCore) >= 1, ItemID.DrillContainmentUnit, ItemCosts.Mounts);
    }

    private void Pets()
    {
        AddItemsAtPrice(ItemCosts.Pets, ShopMerchantCatalog.PetLicenses);

        AddItem(Progression.SlimeKing, ItemID.Fish, ItemCosts.Pets);
        AddItem(Progression.SlimeKing, ItemID.ZephyrFish, ItemCosts.Pets);
        AddItem(Progression.EyeOfCthulhu, ItemID.EyeSpring, ItemCosts.Pets);
        AddItem(Progression.GoblinArmy, ItemID.BabyGrinchMischiefWhistle, ItemCosts.Pets);
        AddItem(Progression.EyeOfCthulhu, ItemID.EatersBone, ItemCosts.Pets);
        AddItem(Progression.EyeOfCthulhu, ItemID.BoneRattle, ItemCosts.Pets);
        AddItem(Progression.Skeletron, ItemID.BoneKey, ItemCosts.Pets);
        AddItem(Progression.Skeletron, ItemID.TartarSauce, ItemCosts.Pets);
        AddItem(Progression.QueenBee, ItemID.Nectar, ItemCosts.Pets);
        AddItem(Progression.Hardmode, ItemID.CompanionCube, ItemCosts.Pets);
        AddItem(Progression.Hardmode, ItemID.AmberMosquito, ItemCosts.Pets);
        AddItem(Progression.Plantera, ItemID.TikiTotem, ItemCosts.Pets);
        AddItem(Progression.Pirates, ItemID.ParrotCracker, ItemCosts.Pets);
        AddItem(Progression.Christmas, ItemID.ToySled, ItemCosts.Pets);

        if (Progression.Halloween)
        {
            AddItemsAtPrice(ItemCosts.Pets, ShopMerchantCatalog.HalloweenPets);
        }

        AddItem(Progression.Fishron, ItemID.Seaweed, ItemCosts.Pets);
        AddItem(Progression.Fishron, ItemID.LizardEgg, ItemCosts.Pets);
        AddItem(Progression.Cultist, ItemID.DD2PetDragon, ItemCosts.Pets);
        AddItem(Progression.Cultist, ItemID.DD2PetGato, ItemCosts.Pets);
        AddItem(Progression.Moonlord, ItemID.StrangeGlowingMushroom, ItemCosts.Pets);
    }

    private void Ores()
    {
        AddItem(CopperOrTin(ItemID.CopperBar, ItemID.TinBar), 50);

        if (Progression.SlimeKing)
        {
            AddItem(IronOrLead(ItemID.IronBar, ItemID.LeadBar), 100);
            AddItem(SilverOrTungsten(ItemID.SilverBar, ItemID.TungstenBar), 150);
            AddItem(GoldOrPlatinum(ItemID.GoldBar, ItemID.PlatinumBar), 200);
        }

        if (Progression.EyeOfCthulhu)
        {
            AddItem(CorruptionOrCrimson(ItemID.DemoniteBar, ItemID.CrimtaneBar), 250);
        }

        if (Progression.BrainOrEater)
        {
            AddItem(ItemID.MeteoriteBar, 300);
            AddItem(Progression.Hardmode, ItemID.HellstoneBar, 350);
        }

        if (Progression.DownedMechs(1))
        {
            AddItemsAtPrice(400, ShopMerchantCatalog.HardmodeBarsTier1);
        }

        if (Progression.DownedMechs(2))
        {
            AddItemsAtPrice(450, ShopMerchantCatalog.HardmodeBarsTier2);
        }

        if (Progression.DownedMechs(3))
        {
            AddItemsAtPrice(500, ShopMerchantCatalog.HardmodeBarsTier3);

            AddItem(ItemID.HallowedBar, 550);
        }

        AddItem(Progression.Plantera, ItemID.ChlorophyteBar, 600);
        AddItem(Progression.Moonlord, ItemID.LunarBar, 650);
    }

    private void FishingRod()
    {
        ReplaceItem(ItemID.WoodFishingPole, Coins.Silver(10));
        ReplaceProgressionItems(Progression.LevelFull(), ShopMerchantCatalog.FishingRodProgression);

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
        AddClassWeapons();

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

    private void AddClassWeapons()
    {
        switch (PlayerUtils.GetPlayerClass())
        {
            case PlayerClass.Melee:
                if (!NPC.downedBoss2)
                {
                    Shortswords();
                }

                Broadswords();
                return;
            case PlayerClass.Ranger:
                Bows();
                return;
            case PlayerClass.Mage:
                MageWeapon();
                return;
            case PlayerClass.Summoner:
                SummonerWeapon();
                return;
            case PlayerClass.Thrower:
                ThrowerWep();
                return;
        }
    }

    private void ReplaceProgressionItems(int progression, IReadOnlyList<ProgressionShopItem> items)
    {
        foreach (ProgressionShopItem item in items)
        {
            ReplaceItem(item.IsUnlocked(progression), item.ItemId, item.Price);
        }
    }

    private void ReplaceClassItem(bool condition, ClassItemSet classItemSet)
    {
        int classItemId = GetClassItem(classItemSet);
        ReplaceItem(condition && classItemId > ItemID.None, classItemId);
    }

    private static int GetClassItem(ClassItemSet classItemSet)
    {
        return classItemSet.GetItemId(PlayerUtils.GetPlayerClass());
    }

    private static int CopperOrTin(int copperItemId, int tinItemId)
    {
        return GenVars.copperBar > 0 ? copperItemId : tinItemId;
    }

    private static int IronOrLead(int ironItemId, int leadItemId)
    {
        return GenVars.ironBar > 0 ? ironItemId : leadItemId;
    }

    private static int SilverOrTungsten(int silverItemId, int tungstenItemId)
    {
        return GenVars.silverBar > 0 ? silverItemId : tungstenItemId;
    }

    private static int GoldOrPlatinum(int goldItemId, int platinumItemId)
    {
        return GenVars.goldBar > 0 ? goldItemId : platinumItemId;
    }

    private static int CorruptionOrCrimson(int corruptionItemId, int crimsonItemId)
    {
        return WorldGen.crimson ? crimsonItemId : corruptionItemId;
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

        ReplaceItem(Progression.SlimeKing, ItemID.Eggnog);
        ReplaceItem(Progression.EyeOfCthulhu, ItemID.LesserRestorationPotion);
        ReplaceItem(Progression.BrainOrEater, ItemID.Honeyfin);
        ReplaceItem(Progression.Skeletron, ItemID.HealingPotion);
        ReplaceItem(Progression.Hardmode, ItemID.RestorationPotion);
        ReplaceItem(Progression.DownedMechs(1), ItemID.StrangeBrew);
        ReplaceItem(Progression.DownedMechs(2), ItemID.GreaterHealingPotion);
        ReplaceItem(Progression.Moonlord, ItemID.SuperHealingPotion);

        NextSlot++;
    }

    private void ManaPotion()
    {
        ReplaceItem(ItemID.LesserManaPotion);

        ReplaceItem(Progression.EyeOfCthulhu, ItemID.ManaPotion);
        ReplaceItem(Progression.Skeletron, ItemID.GreaterManaPotion);
        ReplaceItem(Progression.Moonlord, ItemID.SuperManaPotion);

        NextSlot++;
    }

    private void Torches()
    {
        ReplaceItem(ItemID.CactusCandle, Coins.Silver());

        ReplaceItem(Progression.SlimeKing, ItemID.RichMahoganyCandle);
        ReplaceItem(Progression.EyeOfCthulhu, ItemID.Torch);
        ReplaceItem(Progression.Skeletron, ItemID.BoneTorch);
        ReplaceItem(Progression.Hardmode, ItemID.CursedTorch);
        ReplaceItem(Progression.Moonlord, ItemID.UltrabrightTorch);

        NextSlot++;
    }

    private void Arrows()
    {
        ReplaceItem(ItemID.WoodenArrow);

        ReplaceItem(Progression.SlimeKing, ItemID.BoneArrow);
        ReplaceItem(Progression.EyeOfCthulhu, ItemID.FlamingArrow);
        ReplaceItem(Progression.BrainOrEater, ItemID.FrostburnArrow);
        ReplaceItem(Progression.Skeletron, ItemID.JestersArrow);
        ReplaceItem(Progression.Hardmode, ItemID.UnholyArrow);
        ReplaceItem(Progression.DownedMechs(1), ItemID.HolyArrow);
        ReplaceItem(Progression.DownedMechs(2), ItemID.CursedArrow);
        ReplaceItem(Progression.DownedMechs(3), ItemID.IchorArrow);
        ReplaceItem(Progression.Plantera, ItemID.ChlorophyteArrow);
        ReplaceItem(Progression.Moonlord, ItemID.MoonlordArrow);

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

        ReplaceItem(Progression.SlimeKing, ItemID.Shuriken);
        ReplaceItem(Progression.EyeOfCthulhu, ItemID.ThrowingKnife);
        ReplaceItem(Progression.GoblinArmy, ItemID.PoisonedKnife);
        ReplaceItem(Progression.BrainOrEater, ItemID.BoneDagger);
        ReplaceItem(WorldUtils.Kills(NPCID.DD2DarkMageT1) > 0, ItemID.SpikyBall);
        ReplaceItem(Progression.QueenBee, ItemID.Javelin);
        ReplaceItem(Progression.Skeletron, ItemID.Bone);
        ReplaceItem(Progression.Hardmode, ItemID.MolotovCocktail);
        ReplaceItem(Progression.DownedMechs(1), ItemID.BoneJavelin);

        NextSlot++;
    }

    private void Hooks()
    {
        ReplaceItem(ItemID.GrapplingHook);

        ReplaceItem(Progression.SlimeKing, ItemID.AmethystHook);
        ReplaceItem(Progression.EyeOfCthulhu, ItemID.TopazHook);
        ReplaceItem(Progression.GoblinArmy, ItemID.SapphireHook);
        ReplaceItem(Progression.BrainOrEater, ItemID.EmeraldHook);
        ReplaceItem(WorldUtils.Kills(NPCID.DD2DarkMageT1) > 0, ItemID.RubyHook);
        ReplaceItem(Progression.QueenBee, ItemID.DiamondHook);
        ReplaceItem(Progression.Skeletron, ItemID.SkeletronHand);
        ReplaceItem(Progression.Hardmode, ItemID.IvyWhip);
        ReplaceItem(Progression.DownedMechs(1), ItemID.DualHook);
        ReplaceItem(Progression.DownedMechs(2), ItemID.SpookyHook);
        ReplaceItem(Progression.DownedMechs(3), ItemID.ChristmasHook);
        ReplaceItem(Progression.Moonlord, ItemID.LunarHook);

        NextSlot++;
    }

    private void BuffPotion()
    {
        PlayerClass playerClass = PlayerUtils.GetPlayerClass();

        if (playerClass == PlayerClass.Mage)
        {
            AddItemsAtPrice(ItemCosts.Potions, ShopMerchantCatalog.MagePotions);
            return;
        }

        if (playerClass is PlayerClass.Melee or PlayerClass.Ranger)
        {
            AddItem(ItemID.ArcheryPotion, ItemCosts.Potions);
        }
    }
}



