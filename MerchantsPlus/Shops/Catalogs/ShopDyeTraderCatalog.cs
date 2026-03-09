namespace MerchantsPlus.Shops;

public static class ShopDyeTraderCatalog
{
    public const string BasicShopName = "Basic";
    public const string BrightShopName = "Bright";
    public const string GradientShopName = "Gradient";
    public const string CompoundShopName = "Compound";
    public const string StrangeShopName = "Strange";
    public const string LunarShopName = "Lunar";

    public static readonly string[] ShopNames =
    [
        BasicShopName,
        BrightShopName,
        GradientShopName,
        CompoundShopName,
        StrangeShopName,
        LunarShopName,
    ];

    public static readonly int[] LunarDyes =
    [
        ItemID.NebulaDye,
        ItemID.SolarDye,
        ItemID.StardustDye,
        ItemID.VortexDye,
    ];

    public static readonly int[] StrangeDyes =
    [
        ItemID.AcidDye,
        ItemID.BlueAcidDye,
        ItemID.RedAcidDye,
        ItemID.ChlorophyteDye,
        ItemID.GelDye,
        ItemID.MushroomDye,
        ItemID.GrimDye,
        ItemID.HadesDye,
        ItemID.BurningHadesDye,
        ItemID.ShadowDye,
        ItemID.LivingOceanDye,
        ItemID.LivingFlameDye,
        ItemID.RainbowDye,
        ItemID.MartianArmorDye,
        ItemID.MidnightRainbowDye,
        ItemID.MirageDye,
        ItemID.NegativeDye,
        ItemID.PixieDye,
        ItemID.PhaseDye,
        ItemID.PurpleOozeDye,
        ItemID.ReflectiveDye,
        ItemID.ReflectiveCopperDye,
        ItemID.ReflectiveGoldDye,
        ItemID.ReflectiveObsidianDye,
        ItemID.ReflectiveMetalDye,
        ItemID.ReflectiveSilverDye,
        ItemID.ShadowDye,
        ItemID.ShiftingSandsDye,
        ItemID.DevDye,
        ItemID.TwilightDye,
        ItemID.WispDye,
        ItemID.InfernalWispDye,
        ItemID.UnicornWispDye,
        ItemID.LokisDye,
        ItemID.PinkGelDye,
        ItemID.ShiftingPearlSandsDye,
        ItemID.TeamDye,
        ItemID.VoidDye,
    ];

    public static readonly int[] CompoundDyes =
    [
        ItemID.RedandBlackDye,
        ItemID.OrangeandBlackDye,
        ItemID.YellowandBlackDye,
        ItemID.LimeandBlackDye,
        ItemID.GreenandBlackDye,
        ItemID.TealandBlackDye,
        ItemID.CyanandBlackDye,
        ItemID.SkyBlueandBlackDye,
        ItemID.BlueandBlackDye,
        ItemID.PurpleandBlackDye,
        ItemID.VioletandBlackDye,
        ItemID.PinkandBlackDye,
        ItemID.BrownAndBlackDye,
        ItemID.SilverAndBlackDye,
        ItemID.FlameAndBlackDye,
        ItemID.FlameAndBlackDye,
        ItemID.GreenFlameAndBlackDye,
        ItemID.BlueFlameAndBlackDye,
        ItemID.RedandSilverDye,
        ItemID.OrangeandSilverDye,
        ItemID.YellowandSilverDye,
        ItemID.LimeandSilverDye,
        ItemID.GreenandSilverDye,
        ItemID.TealandSilverDye,
        ItemID.CyanandSilverDye,
        ItemID.SkyBlueandSilverDye,
        ItemID.BlueandSilverDye,
        ItemID.PurpleandSilverDye,
        ItemID.VioletandSilverDye,
        ItemID.PinkandSilverDye,
        ItemID.BrownAndSilverDye,
        ItemID.BlackAndWhiteDye,
        ItemID.FlameAndSilverDye,
        ItemID.GreenFlameAndSilverDye,
        ItemID.BlueFlameAndSilverDye,
    ];

    public static readonly int[] GradientDyes =
    [
        ItemID.FlameDye,
        ItemID.GreenFlameDye,
        ItemID.BlueFlameDye,
        ItemID.YellowGradientDye,
        ItemID.CyanGradientDye,
        ItemID.VioletGradientDye,
        ItemID.RainbowDye,
        ItemID.IntenseFlameDye,
        ItemID.IntenseGreenFlameDye,
        ItemID.IntenseBlueFlameDye,
        ItemID.IntenseRainbowDye,
    ];

    public static readonly int[] BrightDyes =
    [
        ItemID.BrightRedDye,
        ItemID.BrightOrangeDye,
        ItemID.BrightYellowDye,
        ItemID.BrightLimeDye,
        ItemID.BrightGreenDye,
        ItemID.BrightTealDye,
        ItemID.BrightCyanDye,
        ItemID.BrightSkyBlueDye,
        ItemID.BrightBlueDye,
        ItemID.BrightPurpleDye,
        ItemID.BrightVioletDye,
        ItemID.BrightPinkDye,
        ItemID.BrightBrownDye,
        ItemID.BrightSilverDye,
    ];

    public static readonly int[] BasicDyes =
    [
        ItemID.RedDye,
        ItemID.OrangeDye,
        ItemID.YellowDye,
        ItemID.LimeDye,
        ItemID.GreenDye,
        ItemID.TealDye,
        ItemID.SkyBlueDye,
        ItemID.BlueDye,
        ItemID.PurpleDye,
        ItemID.VioletDye,
        ItemID.PinkDye,
        ItemID.BlackDye,
        ItemID.BrownDye,
        ItemID.SilverDye,
    ];

    public static readonly IReadOnlyDictionary<string, int[]> DyesByShop = new Dictionary<string, int[]>
    {
        [BasicShopName] = BasicDyes,
        [BrightShopName] = BrightDyes,
        [GradientShopName] = GradientDyes,
        [CompoundShopName] = CompoundDyes,
        [StrangeShopName] = StrangeDyes,
        [LunarShopName] = LunarDyes,
    };

}

