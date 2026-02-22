using Terraria.WorldBuilding;

namespace MerchantsPlus.Shops;

public static class ShopGoblinTinkererCatalog
{
    public const string MovementShopName = "Movement";
    public const string InformationalShopName = "Informational";
    public const string CombatShopName = "Combat";
    public const string HealthAndManaShopName = "Health and Mana";
    public const string ImmunityShopName = "Immunity";
    public const string DefensiveShopName = "Defensive";
    public const string SpecialShopName = "Special";
    public const string MiscellaneousShopName = "Miscellaneous";

    public static readonly string[] ShopNames =
    [
        MovementShopName,
        InformationalShopName,
        CombatShopName,
        HealthAndManaShopName,
        ImmunityShopName,
        DefensiveShopName,
        SpecialShopName,
        MiscellaneousShopName,
    ];

    public static readonly int[] PirateInvasionAccessories =
    [
        ItemID.GoldRing,
        ItemID.DiscountCard,
        ItemID.LuckyCoin,
    ];

    public static readonly int[] DefenseAccessories =
    [
        ItemID.PaladinsShield,
        ItemID.SquireShield,
        ItemID.HuntressBuckler,
        ItemID.MonkBelt,
        ItemID.TitanGlove,
    ];

    public static readonly int[] MovementBaseAccessories =
    [
        ItemID.WaterWalkingBoots,
    ];

    public static readonly ProgressionShopItem[] MovementProgressionItems =
    [
        new(1, ItemID.HermesBoots, ItemCosts.Accessories),
        new(2, ItemID.CloudinaBottle, ItemCosts.Accessories),
        new(2, ItemID.SandstorminaBottle, ItemCosts.Accessories),
        new(2, ItemID.TsunamiInABottle, ItemCosts.Accessories),
        new(3, ItemID.Aglet, ItemCosts.Accessories),
        new(4, ItemID.AnkletoftheWind, ItemCosts.Accessories),
        new(5, ItemID.RocketBoots, ItemCosts.Accessories),
        new(6, ItemID.IceSkates, ItemCosts.Accessories),
        new(7, ItemID.Flipper, ItemCosts.Accessories),
        new(8, ItemID.ClimbingClaws, ItemCosts.Accessories),
        new(9, ItemID.ShoeSpikes, ItemCosts.Accessories),
        new(10, ItemID.DivingHelmet, ItemCosts.Accessories),
        new(11, ItemID.ShinyRedBalloon, ItemCosts.Accessories),
        new(12, ItemID.FlyingCarpet, ItemCosts.Accessories),
        new(13, ItemID.LavaCharm, ItemCosts.Accessories),
        new(14, ItemID.LuckyHorseshoe, ItemCosts.Accessories),
        new(15, ItemID.Tabi, ItemCosts.Accessories),
    ];

    public static readonly ProgressionShopItem[] InformationalProgressionItems =
    [
        new(1, ItemID.DepthMeter, ItemCosts.Accessories),
        new(2, ItemID.Compass, ItemCosts.Accessories),
        new(3, ItemID.Stopwatch, ItemCosts.Accessories),
        new(4, ItemID.TallyCounter, ItemCosts.Accessories),
        new(5, ItemID.LifeformAnalyzer, ItemCosts.Accessories),
        new(6, ItemID.DPSMeter, ItemCosts.Accessories),
        new(7, ItemID.MetalDetector, ItemCosts.Accessories),
        new(8, ItemID.Radar, ItemCosts.Accessories),
        new(9, ItemID.Ruler, ItemCosts.Accessories),
        new(10, ItemID.MechanicalLens, ItemCosts.Accessories),
        new(11, ItemID.LaserRuler, ItemCosts.Accessories),
    ];

    public static readonly int[] CombatBaseAccessories =
    [
        ItemID.SharkToothNecklace,
    ];

    public static readonly ProgressionShopItem[] CombatEarlyProgressionItems =
    [
        new(1, ItemID.FeralClaws, ItemCosts.Accessories),
    ];

    public static readonly ConditionalShopOffer[] CombatEarlyConditionalOffers =
    [
        new(() => Progression.BrainOfCthulhu, ItemCosts.Accessories, ItemID.PanicNecklace),
        new(() => Progression.QueenBee, ItemCosts.Accessories, ItemID.HoneyComb),
    ];

    public static readonly ProgressionShopItem[] CombatMidProgressionItems =
    [
        new(9, ItemID.MagicQuiver, ItemCosts.Accessories),
        new(10, ItemID.MoonCharm, ItemCosts.Accessories),
        new(11, ItemID.MoonStone, ItemCosts.Accessories),
        new(12, ItemID.SunStone, ItemCosts.Accessories),
        new(13, ItemID.MagmaStone, ItemCosts.Accessories),
        new(13, ItemID.StarCloak, ItemCosts.Accessories),
        new(14, ItemID.EyeoftheGolem, ItemCosts.Accessories),
    ];

    public static readonly ConditionalShopOffer[] CombatLateConditionalOffers =
    [
        new(() => Progression.Plantera, ItemCosts.Accessories, ItemID.BlackBelt),
    ];

    public static readonly ProgressionShopItem[] CombatLateProgressionItems =
    [
        new(16, ItemID.ApprenticeScarf, ItemCosts.Accessories),
        new(17, ItemID.PutridScent, ItemCosts.Accessories),
        new(18, ItemID.HerculesBeetle, ItemCosts.Accessories),
        new(19, ItemID.NecromanticScroll, ItemCosts.Accessories),
        new(20, ItemID.PygmyNecklace, ItemCosts.Accessories),
    ];

    public static readonly ProgressionShopTier[] CombatDefenseAccessoryTiers =
    [
        new(21, ItemCosts.Accessories, DefenseAccessories),
    ];

    public static readonly int[] HealthAndManaBaseAccessories =
    [
        ItemID.NaturesGift,
    ];

    public static readonly ConditionalShopOffer[] HealthAndManaPreProgressionOffers =
    [
        new(() => Progression.BrainOrEater, ItemCosts.Accessories, ItemID.BandofStarpower, ItemID.BandofRegeneration),
    ];

    public static readonly ProgressionShopItem[] HealthAndManaProgressionItems =
    [
        new(5, ItemID.CelestialMagnet, ItemCosts.Accessories),
    ];

    public static readonly ConditionalShopOffer[] HealthAndManaPostProgressionOffers =
    [
        new(() => Progression.Hardmode, ItemCosts.Accessories, ItemID.PhilosophersStone),
    ];

    public static readonly ConditionalShopOffer[] ImmunityOffers =
    [
        new(() => Progression.Hardmode, ItemCosts.Accessories, ItemID.HandWarmer),
        new(() => Progression.Hardmode && WorldUtils.MultiKills([NPCID.RustyArmoredBonesAxe, NPCID.Werewolf, NPCID.AnglerFish]) > 0, ItemCosts.Accessories, ItemID.AdhesiveBandage),
        new(() => Progression.Hardmode && WorldUtils.MultiKills([NPCID.ArmoredSkeleton, NPCID.BlueArmoredBones]) > 0, ItemCosts.Accessories, ItemID.ArmorPolish),
        new(() => Progression.Hardmode && WorldUtils.Kills(NPCID.ToxicSludge) > 0, ItemCosts.Accessories, ItemID.Bezoar),
        new(() => Progression.Hardmode && WorldUtils.Kills(NPCID.CorruptSlime) > 0, ItemCosts.Accessories, ItemID.Blindfold),
        new(() => Progression.Hardmode && WorldUtils.MultiKills([NPCID.Pixie, NPCID.DarkMummy]) > 0, ItemCosts.Accessories, ItemID.Megaphone),
        new(() => Progression.Hardmode && WorldUtils.Kills(NPCID.Mimic) > 2, ItemCosts.Accessories, ItemID.CrossNecklace),
        new(() => Progression.Hardmode && WorldUtils.Kills(NPCID.Pixie) > 10, ItemCosts.Accessories, ItemID.FastClock),
        new(() => Progression.Hardmode, ItemCosts.Accessories, ItemID.ObsidianRose),
        new(() => Progression.Hardmode && WorldUtils.Kills(NPCID.Medusa) > 0, ItemCosts.Accessories, ItemID.PocketMirror),
        new(() => Progression.Hardmode && WorldUtils.Kills(NPCID.LightMummy) > 0, ItemCosts.Accessories, ItemID.TrifoldMap),
        new(() => Progression.Hardmode && WorldUtils.Kills(NPCID.Corruptor) > 0, ItemCosts.Accessories, ItemID.Vitamins),
        new(() => Progression.Hardmode && WorldUtils.Kills(NPCID.CursedSkull) > 0, ItemCosts.Accessories, ItemID.Nazar),
    ];

    public static readonly ConditionalShopOffer[] DefensiveOffers =
    [
        new(() => Progression.Skeletron, ItemCosts.Accessories, ItemID.CobaltShield),
        new(() => WorldUtils.Kills(NPCID.Zombie) > 100, ItemCosts.Accessories, ItemID.Shackle),
        new(() => WorldUtils.Kills(NPCID.BigMimicCrimson) > 0, ItemCosts.Accessories, ItemID.FleshKnuckles),
        new(() => WorldUtils.Kills(NPCID.IceTortoise) > 0, ItemCosts.Accessories, ItemID.FrozenTurtleShell),
    ];

    public static readonly ConditionalShopOffer[] SpecialPreBrainOffers =
    [
        new(() => Progression.SlimeKing, ItemCosts.Accessories, ItemID.RoyalGel),
        new(() => Progression.EyeOfCthulhu, ItemCosts.Accessories, ItemID.EoCShield),
    ];

    public static readonly ConditionalShopOffer[] SpecialPostBrainOffers =
    [
        new(() => Progression.QueenBee, ItemCosts.Accessories, ItemID.HiveBackpack),
        new(() => Progression.Plantera, ItemCosts.Accessories, ItemID.SporeSac),
        new(() => Progression.Golem, ItemCosts.Accessories, ItemID.ShinyStone),
        new(() => Progression.Moonlord, ItemCosts.Accessories, ItemID.GravityGlobe),
    ];

    public static readonly int[] MiscellaneousBaseAccessories =
    [
        ItemID.FlowerBoots,
    ];

    public static readonly ConditionalShopOffer[] MiscellaneousOffers =
    [
        new(() => NPC.downedPirates, ItemCosts.Accessories, PirateInvasionAccessories),
        new(() => WorldUtils.MultiKills([NPCID.BlueJellyfish, NPCID.PinkJellyfish, NPCID.GreenJellyfish]) > 100, ItemCosts.Accessories, ItemID.JellyfishNecklace),
        new(() => NPC.downedMechBoss1, ItemCosts.Accessories, ItemID.NeptunesShell),
    ];

    public static int GetWatchByWorldOre()
    {
        return GenVars.goldBar > 0 ? ItemID.GoldWatch : ItemID.PlatinumWatch;
    }

    public static int GetEvilBossAccessory()
    {
        return WorldGen.crimson ? ItemID.BrainOfConfusion : ItemID.WormScarf;
    }
}

