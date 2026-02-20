namespace MerchantsPlus.Shops;

public static class ShopMerchantCatalog
{
    public const string GearShopName = "Gear";
    public const string PotionsShopName = "Potions";
    public const string OresShopName = "Ores";
    public const string PetsShopName = "Pets";
    public const string MountsShopName = "Mounts";

    public static readonly string[] ShopNames =
    [
        GearShopName,
        PotionsShopName,
        OresShopName,
        PetsShopName,
        MountsShopName,
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

    public static readonly int[] SupportPotions =
    [
        ItemID.LovePotion,
        ItemID.CalmingPotion,
        ItemID.HeartreachPotion,
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

    public static readonly int[] MagePotions =
    [
        ItemID.MagicPowerPotion,
        ItemID.ManaRegenerationPotion,
    ];

}

