namespace MerchantsPlus.Shops;

public static class ShopPainterCatalog
{
    public const string ToolsShopName = "Tools";
    public const string PaintShopName = "Paint";
    public const string WallpaperShopName = "Wallpaper";
    public const string PaintingsVolumeOneShopName = "Paintings I";
    public const string PaintingsVolumeTwoShopName = "Paintings II";

    public static readonly string[] ShopNames =
    [
        ToolsShopName,
        PaintShopName,
        WallpaperShopName,
        PaintingsVolumeOneShopName,
        PaintingsVolumeTwoShopName,
    ];

    public static readonly int[] BuilderAccessories =
    [
        ItemID.Toolbelt,
        ItemID.Toolbox,
        ItemID.PaintSprayer,
        ItemID.ExtendoGrip,
        ItemID.PortableCementMixer,
        ItemID.BrickLayer,
    ];

    public static readonly int[] PaintingsVolumeTwo =
    [
        ItemID.TheDestroyer,
        ItemID.Dryadisque,
        ItemID.TheEyeSeestheEnd,
        ItemID.FacingtheCerebralMastermind,
        ItemID.GloryoftheFire,
        ItemID.GoblinsPlayingPoker,
        ItemID.GreatWave,
        ItemID.TheGuardiansGaze,
        ItemID.TheHangedMan,
        ItemID.Impact,
        ItemID.ThePersistencyofEyes,
        ItemID.PoweredbyBirds,
        ItemID.TheScreamer,
        ItemID.SkellingtonJSkellingsworth,
        ItemID.SparkyPainting,
        ItemID.SomethingEvilisWatchingYou,
        ItemID.StarryNight,
        ItemID.TrioSuperHeroes,
        ItemID.TheTwinsHaveAwoken,
        ItemID.UnicornCrossingtheHallows,
        ItemID.DarkSoulReaper,
        ItemID.Darkness,
        ItemID.DemonsEye,
        ItemID.FlowingMagma,
        ItemID.HandEarth,
        ItemID.ImpFace,
        ItemID.LakeofFire,
        ItemID.LivingGore,
        ItemID.OminousPresence,
        ItemID.ShiningMoon,
        ItemID.Skelehead,
        ItemID.TrappedGhost,
        ItemID.BitterHarvest,
        ItemID.BloodMoonCountess,
        ItemID.HallowsEve,
        ItemID.JackingSkeletron,
        ItemID.MorbidCuriosity,
        ItemID.PillaginMePixels,
    ];

    public static readonly int[] PaintingsVolumeOne =
    [
        ItemID.ColdWatersintheWhiteLand,
        ItemID.Daylight,
        ItemID.DeadlandComesAlive,
        ItemID.DoNotStepontheGrass,
        ItemID.EvilPresence,
        ItemID.FirstEncounter,
        ItemID.GoodMorning,
        ItemID.TheLandofDeceivingLooks,
        ItemID.LightlessChasms,
        ItemID.PlaceAbovetheClouds,
        ItemID.SecretoftheSands,
        ItemID.SkyGuardian,
        ItemID.ThroughtheWindow,
        ItemID.UndergroundReward,
        ItemID.PaintingAcorns,
        ItemID.PaintingCastleMarsberg,
        ItemID.PaintingColdSnap,
        ItemID.PaintingMartiaLisa,
        ItemID.PaintingTheSeason,
        ItemID.PaintingSnowfellas,
        ItemID.PaintingTheTruthIsUpThere,
        ItemID.AmericanExplosive,
        ItemID.CrownoDevoursHisLunch,
        ItemID.Discover,
        ItemID.FatherofSomeone,
        ItemID.FindingGold,
        ItemID.GloriousNight,
        ItemID.GuidePicasso,
        ItemID.Land,
        ItemID.TheMerchant,
        ItemID.NurseLisa,
        ItemID.OldMiner,
        ItemID.RareEnchantment,
        ItemID.Sunflowers,
        ItemID.TerrarianGothic,
        ItemID.Waldo,
        ItemID.BloodMoonRising,
        ItemID.BoneWarp,
        ItemID.TheCreationoftheGuide,
        ItemID.TheCursedMan,
    ];

    public static readonly int[] WallpaperCollection =
    [
        ItemID.BluegreenWallpaper,
        ItemID.BubbleWallpaper,
        ItemID.CandyCaneWallpaper,
        ItemID.ChristmasTreeWallpaper,
        ItemID.CopperPipeWallpaper,
        ItemID.DuckyWallpaper,
        ItemID.FancyGreyWallpaper,
        ItemID.FestiveWallpaper,
        ItemID.GrinchFingerWallpaper,
        ItemID.IceFloeWallpaper,
        ItemID.KrampusHornWallpaper,
        ItemID.MusicWallpaper,
        ItemID.OrnamentWallpaper,
        ItemID.PurpleRainWallpaper,
        ItemID.RainbowWallpaper,
        ItemID.SnowflakeWallpaper,
        ItemID.SparkleStoneWallpaper,
        ItemID.SquigglesWallpaper,
        ItemID.StarlitHeavenWallpaper,
        ItemID.StarsWallpaper,
    ];

    public static readonly int[] PaintCollection =
    [
        ItemID.BlackPaint,
        ItemID.GrayPaint,
        ItemID.GreenPaint,
        ItemID.LimePaint,
        ItemID.NegativePaint,
        ItemID.OrangePaint,
        ItemID.PinkPaint,
        ItemID.PurplePaint,
        ItemID.RedPaint,
        ItemID.ShadowPaint,
        ItemID.SkyBluePaint,
        ItemID.TealPaint,
        ItemID.VioletPaint,
        ItemID.WhitePaint,
        ItemID.YellowPaint,
        ItemID.BluePaint,
        ItemID.BrownPaint,
        ItemID.CyanPaint,
        ItemID.DeepBluePaint,
        ItemID.DeepCyanPaint,
        ItemID.DeepGreenPaint,
        ItemID.DeepLimePaint,
        ItemID.DeepOrangePaint,
        ItemID.DeepPinkPaint,
        ItemID.DeepPurplePaint,
        ItemID.DeepRedPaint,
        ItemID.DeepSkyBluePaint,
        ItemID.DeepTealPaint,
        ItemID.DeepVioletPaint,
        ItemID.DeepYellowPaint,
    ];

    public static readonly int[] PaintingTools =
    [
        ItemID.Paintbrush,
        ItemID.PaintRoller,
        ItemID.PaintScraper,
    ];

    public static readonly IReadOnlyDictionary<string, (int? Price, int[] ItemIds)[]> SectionsByShop =
        new Dictionary<string, (int? Price, int[] ItemIds)[]>
        {
            [ToolsShopName] =
            [
                (null, PaintingTools),
                (ItemCosts.Accessories, BuilderAccessories),
            ],
            [PaintShopName] =
            [
                (null, PaintCollection),
            ],
            [WallpaperShopName] =
            [
                (null, WallpaperCollection),
            ],
            [PaintingsVolumeOneShopName] =
            [
                (null, PaintingsVolumeOne),
            ],
            [PaintingsVolumeTwoShopName] =
            [
                (null, PaintingsVolumeTwo),
            ],
        };

}

