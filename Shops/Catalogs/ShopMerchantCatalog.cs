using Terraria.WorldBuilding;

namespace MerchantsPlus.Shops;

public static class ShopMerchantCatalog
{
    public const string GearShopName = "Gear";
    public const string PotionsShopName = "Potions";
    public const string OresShopName = "Ores";
    public const string PetsShopName = "Pets";
    public const string MountsShopName = "Mounts";

    public const int GenderChangePotionItemId = ItemID.GenderChangePotion;
    public const int ObsidianSkinPotionItemId = ItemID.ObsidianSkinPotion;
    public const int LuckPotionGreaterItemId = ItemID.LuckPotionGreater;
    public const int LuckPotionItemId = ItemID.LuckPotion;
    public const int LuckPotionLesserItemId = ItemID.LuckPotionLesser;
    public const int BuilderPotionItemId = ItemID.BuilderPotion;
    public const int AmmoReservationPotionItemId = ItemID.AmmoReservationPotion;

    public const int MeteoriteOreItemId = ItemID.MeteoriteBar;
    public const int HellstoneOreItemId = ItemID.HellstoneBar;
    public const int HallowedOreItemId = ItemID.HallowedBar;
    public const int ChlorophyteOreItemId = ItemID.ChlorophyteBar;
    public const int LunarOreItemId = ItemID.LunarBar;

    public const int PreHardmodeBugNetItemId = ItemID.BugNet;
    public const int HardmodeBugNetItemId = ItemID.GoldenBugNet;
    public const int PiggyBankItemId = ItemID.PiggyBank;
    public const int SafeItemId = ItemID.Safe;
    public const int WoodItemId = ItemID.Wood;
    public const int EmptyBucketItemId = ItemID.EmptyBucket;
    public const int ArcheryPotionItemId = ItemID.ArcheryPotion;
    public const int WoodFishingPoleItemId = ItemID.WoodFishingPole;

    public static readonly string[] ShopNames =
    [
        GearShopName,
        PotionsShopName,
        OresShopName,
        PetsShopName,
        MountsShopName,
    ];

    public static readonly int[] SilverPotions =
    [
        ItemID.RecallPotion,
        ItemID.WormholePotion,
    ];

    public static readonly int[] BasicPotions =
    [
        ItemID.StinkPotion,
    ];

    public static readonly ProgressionShopItem[] ProgressionPotions =
    [
        new(1, ItemID.FeatherfallPotion, ItemCosts.Potions),
        new(2, ItemID.ShinePotion, ItemCosts.Potions),
        new(3, ItemID.NightOwlPotion, ItemCosts.Potions),
        new(4, ItemID.HunterPotion, ItemCosts.Potions),
        new(5, ItemID.MiningPotion, ItemCosts.Potions),
        new(6, ItemID.SpelunkerPotion, ItemCosts.Potions),
        new(7, ItemID.SwiftnessPotion, ItemCosts.Potions),
        new(8, ItemID.TitanPotion, ItemCosts.Potions),
        new(9, ItemID.ThornsPotion, ItemCosts.Potions),
        new(10, ItemID.WarmthPotion, ItemCosts.Potions),
        new(11, ItemID.WrathPotion, ItemCosts.Potions),
        new(12, ItemID.EndurancePotion, ItemCosts.Potions),
        new(13, ItemID.IronskinPotion, ItemCosts.Potions),
        new(14, ItemID.LifeforcePotion, ItemCosts.Potions),
        new(15, ItemID.RegenerationPotion, ItemCosts.Potions),
        new(16, ItemID.TrapsightPotion, ItemCosts.Potions),
        new(17, ItemID.InfernoPotion, ItemCosts.Potions),
        new(18, ItemID.InvisibilityPotion, ItemCosts.Potions),
        new(19, ItemID.RagePotion, ItemCosts.Potions),
        new(20, ItemID.TeleportationPotion, Coins.Silver()),
        new(21, ItemID.GravitationPotion, ItemCosts.Potions),
    ];

    public static readonly ProgressionShopItem[] FishingRodProgression =
    [
        new(1, ItemID.ReinforcedFishingPole, Coins.Silver(25)),
        new(2, ItemID.FisherofSouls, Coins.Gold()),
        new(3, ItemID.FiberglassFishingPole, Coins.Gold(10)),
        new(4, ItemID.MechanicsRod, Coins.Gold(25)),
        new(5, ItemID.SittingDucksFishingRod, Coins.Gold(50)),
        new(6, ItemID.HotlineFishingHook, Coins.Platinum()),
        new(7, ItemID.GoldenFishingRod, Coins.Platinum(2)),
    ];

    public static readonly ConditionalShopOffer[] WingReplacements =
    [
        new(() => !Config.Instance.DisablePrehardmodeWings, ItemID.CreativeWings),
        new(() => Progression.Hardmode, ItemID.AngelWings),
        new(() => Progression.DownedMechs(1), ItemID.DTownsWings),
        new(() => Progression.DownedMechs(2), ItemID.CrownosWings),
        new(() => Progression.DownedMechs(3), ItemID.CenxsWings),
        new(() => Progression.Plantera, ItemID.JimsWings),
        new(() => Progression.Golem, ItemID.LeinforsWings),
        new(() => Progression.Fishron, ItemID.FishronWings),
    ];

    public static readonly ConditionalShopOffer[] PickaxeReplacements =
    [
        new(() => Progression.Skeletron, ItemID.MoltenPickaxe),
        new(() => Progression.DownedMechs(1), ItemID.CobaltPickaxe),
        new(() => Progression.DownedMechs(2), ItemID.MythrilPickaxe),
        new(() => Progression.DownedMechs(3), ItemID.ChlorophytePickaxe),
        new(() => Progression.Plantera, ItemID.PickaxeAxe),
        new(() => Progression.Golem, ItemID.Picksaw),
    ];

    public static readonly ConditionalShopOffer[] AxeReplacements =
    [
        new(() => Progression.Hardmode, ItemID.MoltenHamaxe),
        new(() => Progression.DownedMechs(1), ItemID.CobaltWaraxe),
        new(() => Progression.DownedMechs(2), ItemID.MythrilWaraxe),
        new(() => Progression.DownedMechs(3), ItemID.ChlorophyteGreataxe),
    ];

    public static readonly ConditionalShopOffer[] HammerReplacements =
    [
        new(() => Progression.Skeletron, ItemID.MoltenHamaxe),
        new(() => Progression.DownedMechs(2), ItemID.Hammush),
        new(() => Progression.DownedMechs(3), ItemID.ChlorophyteJackhammer),
    ];

    public static readonly ClassItemSet MoonlordWings = new(ItemID.WingsSolar, ItemID.WingsVortex, ItemID.WingsNebula, ItemID.WingsStardust, defaultItemId: ItemID.WingsStardust);
    public static readonly ClassItemSet MoonlordPickaxes = new(ItemID.SolarFlarePickaxe, ItemID.VortexPickaxe, ItemID.NebulaPickaxe, ItemID.StardustPickaxe);
    public static readonly ClassItemSet MoonlordHamaxes = new(ItemID.LunarHamaxeSolar, ItemID.LunarHamaxeVortex, ItemID.LunarHamaxeNebula, ItemID.LunarHamaxeStardust);

    public static readonly ClassItemSet SkeletronHelmets = new(ItemID.MoltenHelmet, ItemID.NecroHelmet, ItemID.JungleHat, ItemID.BeeHeadgear);
    public static readonly ClassItemSet MechTierOneHelmets = new(ItemID.CobaltHelmet, ItemID.CobaltMask, ItemID.CobaltHat, ItemID.SpiderMask);
    public static readonly ClassItemSet MechTierTwoHelmets = new(ItemID.MythrilHelmet, ItemID.MythrilHat, ItemID.MythrilHood, ItemID.SpookyHelmet);
    public static readonly ClassItemSet MechTierThreeHelmets = new(ItemID.ChlorophyteMask, ItemID.ChlorophyteHelmet, ItemID.ChlorophyteHeadgear, ItemID.TikiMask);
    public static readonly ClassItemSet MoonlordHelmets = new(ItemID.SolarFlareHelmet, ItemID.VortexHelmet, ItemID.NebulaHelmet, ItemID.StardustHelmet);

    public static readonly ClassItemSet SkeletronBreastplates = new(ItemID.MoltenBreastplate, ItemID.NecroBreastplate, ItemID.JungleShirt, ItemID.BeeBreastplate);
    public static readonly ClassItemSet MechTierOneBreastplates = new(ItemID.CobaltBreastplate, ItemID.CobaltBreastplate, ItemID.CobaltBreastplate, ItemID.SpiderBreastplate);
    public static readonly ClassItemSet MechTierTwoBreastplates = new(ItemID.MythrilChainmail, ItemID.MythrilChainmail, ItemID.MythrilChainmail, ItemID.SpookyBreastplate);
    public static readonly ClassItemSet MechTierThreeBreastplates = new(ItemID.ChlorophytePlateMail, ItemID.ChlorophytePlateMail, ItemID.ChlorophytePlateMail, ItemID.TikiShirt);
    public static readonly ClassItemSet MoonlordBreastplates = new(ItemID.SolarFlareBreastplate, ItemID.VortexBreastplate, ItemID.NebulaBreastplate, ItemID.StardustBreastplate);

    public static readonly ClassItemSet SkeletronGreaves = new(ItemID.MoltenGreaves, ItemID.NecroGreaves, ItemID.JunglePants, ItemID.BeeGreaves);
    public static readonly ClassItemSet MechTierOneGreaves = new(ItemID.CobaltLeggings, ItemID.CobaltLeggings, ItemID.CobaltLeggings, ItemID.SpiderGreaves);
    public static readonly ClassItemSet MechTierTwoGreaves = new(ItemID.MythrilGreaves, ItemID.MythrilGreaves, ItemID.MythrilGreaves, ItemID.SpookyLeggings);
    public static readonly ClassItemSet MechTierThreeGreaves = new(ItemID.ChlorophyteGreaves, ItemID.ChlorophyteGreaves, ItemID.ChlorophyteGreaves, ItemID.TikiPants);
    public static readonly ClassItemSet MoonlordGreaves = new(ItemID.SolarFlareLeggings, ItemID.VortexLeggings, ItemID.NebulaLeggings, ItemID.StardustLeggings);

    public static readonly ConditionalShopOffer[] BroadswordReplacements =
    [
        new(() => WorldUtils.Kills(NPCID.DD2DarkMageT1) > 0, ItemID.Arkhalis),
        new(() => Progression.QueenBee, ItemID.BeeKeeper),
        new(() => Progression.Hardmode, ItemID.BreakerBlade),
        new(() => Progression.DownedMechs(1), ItemID.CobaltSword),
        new(() => Progression.DownedMechs(2), ItemID.MythrilSword),
        new(() => Progression.DownedMechs(3), ItemID.TitaniumSword),
        new(() => Progression.Plantera, ItemID.Seedler),
        new(() => Progression.Moonlord, ItemID.TerraBlade),
    ];

    public static readonly ConditionalShopOffer[] BowReplacements =
    [
        new(() => Progression.QueenBee, ItemID.BeesKnees),
        new(() => Progression.Skeletron, ItemID.MoltenFury),
        new(() => Progression.Hardmode, ItemID.Marrow),
        new(() => Progression.DownedMechs(1), ItemID.IceBow),
        new(() => Progression.DownedMechs(2), ItemID.DaedalusStormbow),
        new(() => Progression.DownedMechs(3), ItemID.ShadowFlameBow),
        new(() => Progression.Plantera, ItemID.DD2PhoenixBow),
        new(() => Progression.Moonlord, ItemID.Phantasm),
    ];

    public static readonly ConditionalShopOffer[] MageWeaponReplacements =
    [
        new(static () => true, ItemID.WandofSparking),
        new(() => Progression.SlimeKing, ItemID.EmeraldStaff),
        new(() => Progression.EyeOfCthulhu, ItemID.AmberStaff),
        new(() => Progression.GoblinArmy, ItemID.DiamondStaff),
        new(() => Progression.BrainOrEater, ItemID.SpaceGun),
        new(() => Progression.QueenBee, ItemID.BookofSkulls),
        new(() => Progression.Skeletron, ItemID.DemonScythe),
        new(() => Progression.Hardmode, ItemID.LaserRifle),
        new(() => Progression.DownedMechs(1), ItemID.SkyFracture),
        new(() => Progression.DownedMechs(2), ItemID.MagicDagger),
        new(() => Progression.DownedMechs(3), ItemID.FrostStaff),
        new(() => Progression.Plantera, ItemID.UnholyTrident),
        new(() => Progression.Golem, ItemID.HeatRay),
        new(() => NPC.downedFrost, ItemID.Razorpine),
        new(() => WorldUtils.Kills(NPCID.DD2Betsy) > 0, ItemID.ApprenticeStaffT3),
        new(() => NPC.downedMartians, ItemID.LaserMachinegun),
        new(() => NPC.downedFishron, ItemID.ChargedBlasterCannon),
        new(() => NPC.downedAncientCultist, ItemID.SpectreStaff),
        new(() => Progression.Moonlord, ItemID.Phantasm),
    ];

    public static readonly ConditionalShopOffer[] SummonerWeaponReplacements =
    [
        new(static () => true, ItemID.SlimeStaff),
        new(() => Progression.BloodMoon, ItemID.VampireFrogStaff),
        new(() => Progression.QueenBee, ItemID.HornetStaff),
        new(() => Progression.Skeletron, ItemID.ImpStaff),
        new(() => Progression.Hardmode, ItemID.SpiderStaff),
        new(() => Progression.DownedMechs(1), ItemID.OpticStaff),
        new(() => Progression.DownedMechs(2), ItemID.PygmyStaff),
        new(() => Progression.DownedMechs(3), ItemID.XenoStaff),
        new(() => Progression.Plantera, ItemID.RavenStaff),
        new(() => Progression.Golem, ItemID.PirateStaff),
        new(() => NPC.downedFrost, ItemID.TempestStaff),
        new(() => NPC.downedAncientCultist, ItemID.DeadlySphereStaff),
        new(() => Progression.Moonlord, ItemID.StardustDragonStaff),
    ];

    public static readonly int[] BaseMounts =
    [
        ItemID.FuzzyCarrot,
    ];

    public static readonly ConditionalShopOffer[] MountUnlocks =
    [
        new(() => WorldUtils.Kills(NPCID.KingSlime) >= 1, ItemID.SlimySaddle),
        new(() => WorldUtils.Kills(NPCID.EyeofCthulhu) >= 1, ItemID.HardySaddle),
        new(() => WorldUtils.Kills(NPCID.QueenBee) >= 1, ItemID.HoneyedGoggles),
        new(() => Progression.Hardmode, ItemID.AncientHorn),
        new(() => WorldUtils.Kills(NPCID.Retinazer) >= 1, ItemID.ReindeerBells),
        new(() => WorldUtils.Kills(NPCID.TheDestroyer) >= 1, ItemID.ScalyTruffle),
        new(() => WorldUtils.Kills(NPCID.SkeletronPrime) >= 1, ItemID.BrainScrambler),
        new(() => WorldUtils.Kills(NPCID.Plantera) >= 1, ItemID.BlessedApple),
        new(() => WorldUtils.Kills(NPCID.MartianSaucer) >= 1, ItemID.CosmicCarKey),
        new(() => WorldUtils.Kills(NPCID.DukeFishron) >= 1, ItemID.ShrimpyTruffle),
        new(() => WorldUtils.Kills(NPCID.MoonLordCore) >= 1, ItemID.DrillContainmentUnit),
    ];

    public static readonly int[] FishingPotions =
    [
        ItemID.FlipperPotion,
        ItemID.WaterWalkingPotion,
        ItemID.GillsPotion,
        ItemID.SonarPotion,
        ItemID.CratePotion,
        ItemID.FishingPotion,
    ];

    public static readonly int[] PetLicenses =
    [
        ItemID.Seedling,
        ItemID.Carrot,
        ItemID.DogWhistle,
    ];

    public static readonly int[] HalloweenPets =
    [
        ItemID.SpiderEgg,
        ItemID.CursedSapling,
        ItemID.UnluckyYarn,
        ItemID.MagicalPumpkinSeed,
    ];

    public static readonly ConditionalShopOffer[] PetUnlocks =
    [
        new(() => Progression.SlimeKing, ItemID.Fish, ItemID.ZephyrFish),
        new(() => Progression.EyeOfCthulhu, ItemID.EyeSpring, ItemID.EatersBone, ItemID.BoneRattle),
        new(() => Progression.GoblinArmy, ItemID.BabyGrinchMischiefWhistle),
        new(() => Progression.Skeletron, ItemID.BoneKey, ItemID.TartarSauce),
        new(() => Progression.QueenBee, ItemID.Nectar),
        new(() => Progression.Hardmode, ItemID.CompanionCube, ItemID.AmberMosquito),
        new(() => Progression.Plantera, ItemID.TikiTotem),
        new(() => Progression.Pirates, ItemID.ParrotCracker),
        new(() => Progression.Christmas, ItemID.ToySled),
        new(() => Progression.Halloween, HalloweenPets),
        new(() => Progression.Fishron, ItemID.Seaweed, ItemID.LizardEgg),
        new(() => Progression.Cultist, ItemID.DD2PetDragon, ItemID.DD2PetGato),
        new(() => Progression.Moonlord, ItemID.StrangeGlowingMushroom),
    ];

    public static readonly int[] HardmodeBarsTier1 =
    [
        ItemID.PalladiumBar,
        ItemID.CobaltBar,
    ];

    public static readonly int[] HardmodeBarsTier2 =
    [
        ItemID.MythrilBar,
        ItemID.OrichalcumBar,
    ];

    public static readonly int[] HardmodeBarsTier3 =
    [
        ItemID.AdamantiteBar,
        ItemID.TitaniumBar,
    ];

    public static readonly int[] GearBasics =
    [
        ItemID.Sickle,
    ];

    public static readonly ConditionalShopOffer[] BootReplacements =
    [
        new(static () => true, ItemID.HermesBoots),
        new(() => Progression.EyeOfCthulhu, ItemID.FlurryBoots),
        new(() => Progression.BrainOrEater, ItemID.SailfishBoots),
        new(() => Progression.QueenBee, ItemID.SandBoots),
        new(() => Progression.Plantera, ItemID.AmphibianBoots),
        new(() => Progression.WallOfFlesh, ItemID.SpectreBoots),
        new(() => Progression.DownedMechs(1), ItemID.FairyBoots),
        new(() => Progression.DownedMechs(2), ItemID.HellfireTreads),
        new(() => Progression.DownedMechs(3), ItemID.LightningBoots),
        new(() => Progression.Golem, ItemID.FrostsparkBoots),
        new(() => Progression.Moonlord, ItemID.TerrasparkBoots),
    ];

    public static readonly ConditionalShopOffer[] HealingPotionReplacements =
    [
        new(static () => true, ItemID.LesserHealingPotion),
        new(() => Progression.SlimeKing, ItemID.Eggnog),
        new(() => Progression.EyeOfCthulhu, ItemID.LesserRestorationPotion),
        new(() => Progression.BrainOrEater, ItemID.Honeyfin),
        new(() => Progression.Skeletron, ItemID.HealingPotion),
        new(() => Progression.Hardmode, ItemID.RestorationPotion),
        new(() => Progression.DownedMechs(1), ItemID.StrangeBrew),
        new(() => Progression.DownedMechs(2), ItemID.GreaterHealingPotion),
        new(() => Progression.Moonlord, ItemID.SuperHealingPotion),
    ];

    public static readonly ConditionalShopOffer[] ManaPotionReplacements =
    [
        new(static () => true, ItemID.LesserManaPotion),
        new(() => Progression.EyeOfCthulhu, ItemID.ManaPotion),
        new(() => Progression.Skeletron, ItemID.GreaterManaPotion),
        new(() => Progression.Moonlord, ItemID.SuperManaPotion),
    ];

    public static readonly ConditionalShopOffer[] TorchReplacements =
    [
        new(static () => true, ItemID.CactusCandle),
        new(() => Progression.SlimeKing, ItemID.RichMahoganyCandle),
        new(() => Progression.EyeOfCthulhu, ItemID.Torch),
        new(() => Progression.Skeletron, ItemID.BoneTorch),
        new(() => Progression.Hardmode, ItemID.CursedTorch),
        new(() => Progression.Moonlord, ItemID.UltrabrightTorch),
    ];

    public static readonly ConditionalShopOffer[] ArrowReplacements =
    [
        new(static () => true, ItemID.WoodenArrow),
        new(() => Progression.SlimeKing, ItemID.BoneArrow),
        new(() => Progression.EyeOfCthulhu, ItemID.FlamingArrow),
        new(() => Progression.BrainOrEater, ItemID.FrostburnArrow),
        new(() => Progression.Skeletron, ItemID.JestersArrow),
        new(() => Progression.Hardmode, ItemID.UnholyArrow),
        new(() => Progression.DownedMechs(1), ItemID.HolyArrow),
        new(() => Progression.DownedMechs(2), ItemID.CursedArrow),
        new(() => Progression.DownedMechs(3), ItemID.IchorArrow),
        new(() => Progression.Plantera, ItemID.ChlorophyteArrow),
        new(() => Progression.Moonlord, ItemID.MoonlordArrow),
    ];

    public static readonly ConditionalShopOffer[] RopeReplacements =
    [
        new(static () => true, ItemID.VineRope),
        new(() => Progression.SlimeKing, ItemID.Rope),
        new(() => Progression.Skeletron, ItemID.Chain),
    ];

    public static readonly ConditionalShopOffer[] LightPetReplacements =
    [
        new(static () => true, ItemID.FairyBell),
        new(() => Progression.Hardmode, ItemID.WispinaBottle),
    ];

    public static readonly ConditionalShopOffer[] ThrowerReplacements =
    [
        new(static () => true, ItemID.Snowball),
        new(() => Progression.SlimeKing, ItemID.Shuriken),
        new(() => Progression.EyeOfCthulhu, ItemID.ThrowingKnife),
        new(() => Progression.GoblinArmy, ItemID.PoisonedKnife),
        new(() => Progression.BrainOrEater, ItemID.BoneDagger),
        new(() => WorldUtils.Kills(NPCID.DD2DarkMageT1) > 0, ItemID.SpikyBall),
        new(() => Progression.QueenBee, ItemID.Javelin),
        new(() => Progression.Skeletron, ItemID.Bone),
        new(() => Progression.Hardmode, ItemID.MolotovCocktail),
        new(() => Progression.DownedMechs(1), ItemID.BoneJavelin),
    ];

    public static readonly ConditionalShopOffer[] HookReplacements =
    [
        new(static () => true, ItemID.GrapplingHook),
        new(() => Progression.SlimeKing, ItemID.AmethystHook),
        new(() => Progression.EyeOfCthulhu, ItemID.TopazHook),
        new(() => Progression.GoblinArmy, ItemID.SapphireHook),
        new(() => Progression.BrainOrEater, ItemID.EmeraldHook),
        new(() => WorldUtils.Kills(NPCID.DD2DarkMageT1) > 0, ItemID.RubyHook),
        new(() => Progression.QueenBee, ItemID.DiamondHook),
        new(() => Progression.Skeletron, ItemID.SkeletronHand),
        new(() => Progression.Hardmode, ItemID.IvyWhip),
        new(() => Progression.DownedMechs(1), ItemID.DualHook),
        new(() => Progression.DownedMechs(2), ItemID.SpookyHook),
        new(() => Progression.DownedMechs(3), ItemID.ChristmasHook),
        new(() => Progression.Moonlord, ItemID.LunarHook),
    ];

    public static readonly int[] MagePotions =
    [
        ItemID.MagicPowerPotion,
        ItemID.ManaRegenerationPotion,
    ];

    public static readonly int[] BasePickaxes =
    [
        ItemID.IronPickaxe,
        ItemID.LeadPickaxe,
    ];

    public static readonly int[] EyePickaxes =
    [
        ItemID.GoldPickaxe,
        ItemID.PlatinumPickaxe,
    ];

    public static readonly int[] EvilPickaxes =
    [
        ItemID.DeathbringerPickaxe,
        ItemID.NightmarePickaxe,
    ];

    public static readonly int[] BaseAxes =
    [
        ItemID.IronAxe,
        ItemID.LeadAxe,
    ];

    public static readonly int[] EyeAxes =
    [
        ItemID.GoldAxe,
        ItemID.PlatinumAxe,
    ];

    public static readonly int[] EvilAxes =
    [
        ItemID.BloodLustCluster,
        ItemID.WarAxeoftheNight,
    ];

    public static readonly int[] BaseHammers =
    [
        ItemID.IronHammer,
        ItemID.LeadHammer,
    ];

    public static readonly int[] EyeHammers =
    [
        ItemID.GoldHammer,
        ItemID.PlatinumHammer,
    ];

    public static readonly int[] EvilHammers =
    [
        ItemID.FleshGrinder,
        ItemID.TheBreaker,
    ];

    public static readonly int[] BaseHelmets =
    [
        ItemID.CopperHelmet,
        ItemID.TinHelmet,
    ];

    public static readonly int[] SlimeHelmets =
    [
        ItemID.IronHelmet,
        ItemID.LeadHelmet,
    ];

    public static readonly int[] EyeHelmets =
    [
        ItemID.GoldHelmet,
        ItemID.PlatinumHelmet,
    ];

    public static readonly int[] EvilHelmets =
    [
        ItemID.CrimsonHelmet,
        ItemID.ShadowHelmet,
    ];

    public static readonly int[] BaseBreastplates =
    [
        ItemID.CopperChainmail,
        ItemID.TinChainmail,
    ];

    public static readonly int[] SlimeBreastplates =
    [
        ItemID.IronChainmail,
        ItemID.LeadChainmail,
    ];

    public static readonly int[] EyeBreastplates =
    [
        ItemID.GoldChainmail,
        ItemID.PlatinumChainmail,
    ];

    public static readonly int[] EvilBreastplates =
    [
        ItemID.CrimsonScalemail,
        ItemID.ShadowScalemail,
    ];

    public static readonly int[] BaseGreaves =
    [
        ItemID.CopperGreaves,
        ItemID.TinGreaves,
    ];

    public static readonly int[] SlimeGreaves =
    [
        ItemID.IronGreaves,
        ItemID.LeadGreaves,
    ];

    public static readonly int[] EyeGreaves =
    [
        ItemID.GoldGreaves,
        ItemID.PlatinumGreaves,
    ];

    public static readonly int[] EvilGreaves =
    [
        ItemID.CrimsonGreaves,
        ItemID.ShadowGreaves,
    ];

    public static readonly int[] BaseShortswords =
    [
        ItemID.IronShortsword,
        ItemID.LeadShortsword,
    ];

    public static readonly int[] EyeShortswords =
    [
        ItemID.GoldShortsword,
        ItemID.PlatinumShortsword,
    ];

    public static readonly int[] BaseBroadswords =
    [
        ItemID.IronBroadsword,
        ItemID.LeadBroadsword,
    ];

    public static readonly int[] EyeBroadswords =
    [
        ItemID.GoldBroadsword,
        ItemID.PlatinumBroadsword,
    ];

    public static readonly int[] EvilBroadswords =
    [
        ItemID.BloodButcherer,
        ItemID.LightsBane,
    ];

    public static readonly int[] BaseBows =
    [
        ItemID.IronBow,
        ItemID.LeadBow,
    ];

    public static readonly int[] EyeBows =
    [
        ItemID.GoldBow,
        ItemID.PlatinumBow,
    ];

    public static readonly int[] EvilBows =
    [
        ItemID.TendonBow,
        ItemID.DemonBow,
    ];

    public static readonly int[] BaseOreBars =
    [
        ItemID.CopperBar,
        ItemID.TinBar,
    ];

    public static readonly int[] TierOneOreBars =
    [
        ItemID.IronBar,
        ItemID.LeadBar,
    ];

    public static readonly int[] TierTwoOreBars =
    [
        ItemID.SilverBar,
        ItemID.TungstenBar,
    ];

    public static readonly int[] TierThreeOreBars =
    [
        ItemID.GoldBar,
        ItemID.PlatinumBar,
    ];

    public static readonly int[] EvilOreBars =
    [
        ItemID.CrimtaneBar,
        ItemID.DemoniteBar,
    ];

    public static int GetBasePickaxe() => GenVars.ironBar > 0 ? ItemID.IronPickaxe : ItemID.LeadPickaxe;
    public static int GetEyePickaxe() => GenVars.goldBar > 0 ? ItemID.GoldPickaxe : ItemID.PlatinumPickaxe;
    public static int GetEvilPickaxe() => WorldGen.crimson ? ItemID.DeathbringerPickaxe : ItemID.NightmarePickaxe;

    public static int GetBaseAxe() => GenVars.ironBar > 0 ? ItemID.IronAxe : ItemID.LeadAxe;
    public static int GetEyeAxe() => GenVars.goldBar > 0 ? ItemID.GoldAxe : ItemID.PlatinumAxe;
    public static int GetEvilAxe() => WorldGen.crimson ? ItemID.BloodLustCluster : ItemID.WarAxeoftheNight;

    public static int GetBaseHammer() => GenVars.ironBar > 0 ? ItemID.IronHammer : ItemID.LeadHammer;
    public static int GetEyeHammer() => GenVars.goldBar > 0 ? ItemID.GoldHammer : ItemID.PlatinumHammer;
    public static int GetEvilHammer() => WorldGen.crimson ? ItemID.FleshGrinder : ItemID.TheBreaker;

    public static int GetBaseHelmet() => GenVars.copperBar > 0 ? ItemID.CopperHelmet : ItemID.TinHelmet;
    public static int GetSlimeHelmet() => GenVars.ironBar > 0 ? ItemID.IronHelmet : ItemID.LeadHelmet;
    public static int GetEyeHelmet() => GenVars.goldBar > 0 ? ItemID.GoldHelmet : ItemID.PlatinumHelmet;
    public static int GetEvilHelmet() => WorldGen.crimson ? ItemID.CrimsonHelmet : ItemID.ShadowHelmet;

    public static int GetBaseBreastplate() => GenVars.copperBar > 0 ? ItemID.CopperChainmail : ItemID.TinChainmail;
    public static int GetSlimeBreastplate() => GenVars.ironBar > 0 ? ItemID.IronChainmail : ItemID.LeadChainmail;
    public static int GetEyeBreastplate() => GenVars.goldBar > 0 ? ItemID.GoldChainmail : ItemID.PlatinumChainmail;
    public static int GetEvilBreastplate() => WorldGen.crimson ? ItemID.CrimsonScalemail : ItemID.ShadowScalemail;

    public static int GetBaseGreaves() => GenVars.copperBar > 0 ? ItemID.CopperGreaves : ItemID.TinGreaves;
    public static int GetSlimeGreaves() => GenVars.ironBar > 0 ? ItemID.IronGreaves : ItemID.LeadGreaves;
    public static int GetEyeGreaves() => GenVars.goldBar > 0 ? ItemID.GoldGreaves : ItemID.PlatinumGreaves;
    public static int GetEvilGreaves() => WorldGen.crimson ? ItemID.CrimsonGreaves : ItemID.ShadowGreaves;

    public static int GetBaseShortsword() => GenVars.ironBar > 0 ? ItemID.IronShortsword : ItemID.LeadShortsword;
    public static int GetEyeShortsword() => GenVars.goldBar > 0 ? ItemID.GoldShortsword : ItemID.PlatinumShortsword;

    public static int GetBaseBroadsword() => GenVars.ironBar > 0 ? ItemID.IronBroadsword : ItemID.LeadBroadsword;
    public static int GetEyeBroadsword() => GenVars.goldBar > 0 ? ItemID.GoldBroadsword : ItemID.PlatinumBroadsword;
    public static int GetEvilBroadsword() => WorldGen.crimson ? ItemID.BloodButcherer : ItemID.LightsBane;

    public static int GetBaseBow() => GenVars.ironBar > 0 ? ItemID.IronBow : ItemID.LeadBow;
    public static int GetEyeBow() => GenVars.goldBar > 0 ? ItemID.GoldBow : ItemID.PlatinumBow;
    public static int GetEvilBow() => WorldGen.crimson ? ItemID.TendonBow : ItemID.DemonBow;

    public static int GetBaseOre() => GenVars.copperBar > 0 ? ItemID.CopperBar : ItemID.TinBar;
    public static int GetTierOneOre() => GenVars.ironBar > 0 ? ItemID.IronBar : ItemID.LeadBar;
    public static int GetTierTwoOre() => GenVars.silverBar > 0 ? ItemID.SilverBar : ItemID.TungstenBar;
    public static int GetTierThreeOre() => GenVars.goldBar > 0 ? ItemID.GoldBar : ItemID.PlatinumBar;
    public static int GetEvilOre() => WorldGen.crimson ? ItemID.CrimtaneBar : ItemID.DemoniteBar;
}
