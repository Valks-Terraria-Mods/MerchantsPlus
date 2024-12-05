namespace MerchantsPlus.Merchants;

public class ShopDyeTrader : Shop
{
    public override string[] Shops => [ 
        "Basic", 
        "Bright", 
        "Gradient", 
        "Compound", 
        "Strange", 
        "Lunar" ];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Lunar")
        {
            AddItem(ItemID.NebulaDye, Utils.UniversalDyeCost);
            AddItem(ItemID.SolarDye, Utils.UniversalDyeCost);
            AddItem(ItemID.StardustDye, Utils.UniversalDyeCost);
            AddItem(ItemID.VortexDye, Utils.UniversalDyeCost);
            return;
        }

        if (shop == "Strange")
        {
            AddItem(ItemID.AcidDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BlueAcidDye, Utils.UniversalDyeCost);
            AddItem(ItemID.RedAcidDye, Utils.UniversalDyeCost);
            AddItem(ItemID.ChlorophyteDye, Utils.UniversalDyeCost);
            AddItem(ItemID.GelDye, Utils.UniversalDyeCost);
            AddItem(ItemID.MushroomDye, Utils.UniversalDyeCost);
            AddItem(ItemID.GrimDye, Utils.UniversalDyeCost);
            AddItem(ItemID.HadesDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BurningHadesDye, Utils.UniversalDyeCost);
            AddItem(ItemID.ShadowDye, Utils.UniversalDyeCost);
            AddItem(ItemID.LivingOceanDye, Utils.UniversalDyeCost);
            AddItem(ItemID.LivingFlameDye, Utils.UniversalDyeCost);
            AddItem(ItemID.RainbowDye, Utils.UniversalDyeCost);
            AddItem(ItemID.MartianArmorDye, Utils.UniversalDyeCost);
            AddItem(ItemID.MidnightRainbowDye, Utils.UniversalDyeCost);
            AddItem(ItemID.MirageDye, Utils.UniversalDyeCost);
            AddItem(ItemID.NegativeDye, Utils.UniversalDyeCost);
            AddItem(ItemID.PixieDye, Utils.UniversalDyeCost);
            AddItem(ItemID.PhaseDye, Utils.UniversalDyeCost);
            AddItem(ItemID.PurpleOozeDye, Utils.UniversalDyeCost);
            AddItem(ItemID.ReflectiveDye, Utils.UniversalDyeCost);
            AddItem(ItemID.ReflectiveCopperDye, Utils.UniversalDyeCost);
            AddItem(ItemID.ReflectiveGoldDye, Utils.UniversalDyeCost);
            AddItem(ItemID.ReflectiveObsidianDye, Utils.UniversalDyeCost);
            AddItem(ItemID.ReflectiveMetalDye, Utils.UniversalDyeCost);
            AddItem(ItemID.ReflectiveSilverDye, Utils.UniversalDyeCost);
            AddItem(ItemID.ShadowDye, Utils.UniversalDyeCost);
            AddItem(ItemID.ShiftingSandsDye, Utils.UniversalDyeCost);
            AddItem(ItemID.DevDye, Utils.UniversalDyeCost);
            AddItem(ItemID.TwilightDye, Utils.UniversalDyeCost);
            AddItem(ItemID.WispDye, Utils.UniversalDyeCost);
            AddItem(ItemID.InfernalWispDye, Utils.UniversalDyeCost);
            AddItem(ItemID.UnicornWispDye, Utils.UniversalDyeCost);
            AddItem(ItemID.LokisDye, Utils.UniversalDyeCost);
            AddItem(ItemID.PinkGelDye, Utils.UniversalDyeCost);
            AddItem(ItemID.ShiftingPearlSandsDye, Utils.UniversalDyeCost);
            AddItem(ItemID.TeamDye, Utils.UniversalDyeCost);
            AddItem(ItemID.VoidDye, Utils.UniversalDyeCost);
            return;
        }

        if (shop == "Compound")
        {
            AddItem(ItemID.RedandBlackDye, Utils.UniversalDyeCost);
            AddItem(ItemID.OrangeandBlackDye, Utils.UniversalDyeCost);
            AddItem(ItemID.YellowandBlackDye, Utils.UniversalDyeCost);
            AddItem(ItemID.LimeandBlackDye, Utils.UniversalDyeCost);
            AddItem(ItemID.GreenandBlackDye, Utils.UniversalDyeCost);
            AddItem(ItemID.TealandBlackDye, Utils.UniversalDyeCost);
            AddItem(ItemID.CyanandBlackDye, Utils.UniversalDyeCost);
            AddItem(ItemID.SkyBlueandBlackDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BlueandBlackDye, Utils.UniversalDyeCost);
            AddItem(ItemID.PurpleandBlackDye, Utils.UniversalDyeCost);
            AddItem(ItemID.VioletandBlackDye, Utils.UniversalDyeCost);
            AddItem(ItemID.PinkandBlackDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BrownAndBlackDye, Utils.UniversalDyeCost);
            AddItem(ItemID.SilverAndBlackDye, Utils.UniversalDyeCost);
            AddItem(ItemID.FlameAndBlackDye, Utils.UniversalDyeCost);
            AddItem(ItemID.FlameAndBlackDye, Utils.UniversalDyeCost);
            AddItem(ItemID.GreenFlameAndBlackDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BlueFlameAndBlackDye, Utils.UniversalDyeCost);
            AddItem(ItemID.RedandSilverDye, Utils.UniversalDyeCost);
            AddItem(ItemID.OrangeandSilverDye, Utils.UniversalDyeCost);
            AddItem(ItemID.YellowandSilverDye, Utils.UniversalDyeCost);
            AddItem(ItemID.LimeandSilverDye, Utils.UniversalDyeCost);
            AddItem(ItemID.GreenandSilverDye, Utils.UniversalDyeCost);
            AddItem(ItemID.TealandSilverDye, Utils.UniversalDyeCost);
            AddItem(ItemID.CyanandSilverDye, Utils.UniversalDyeCost);
            AddItem(ItemID.SkyBlueandSilverDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BlueandSilverDye, Utils.UniversalDyeCost);
            AddItem(ItemID.PurpleandSilverDye, Utils.UniversalDyeCost);
            AddItem(ItemID.VioletandSilverDye, Utils.UniversalDyeCost);
            AddItem(ItemID.PinkandSilverDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BrownAndSilverDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BlackAndWhiteDye, Utils.UniversalDyeCost);
            AddItem(ItemID.FlameAndSilverDye, Utils.UniversalDyeCost);
            AddItem(ItemID.GreenFlameAndSilverDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BlueFlameAndSilverDye, Utils.UniversalDyeCost);
            return;
        }

        if (shop == "Gradient")
        {
            AddItem(ItemID.FlameDye, Utils.UniversalDyeCost);
            AddItem(ItemID.GreenFlameDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BlueFlameDye, Utils.UniversalDyeCost);
            AddItem(ItemID.YellowGradientDye, Utils.UniversalDyeCost);
            AddItem(ItemID.CyanGradientDye, Utils.UniversalDyeCost);
            AddItem(ItemID.VioletGradientDye, Utils.UniversalDyeCost);
            AddItem(ItemID.RainbowDye, Utils.UniversalDyeCost);
            AddItem(ItemID.IntenseFlameDye, Utils.UniversalDyeCost);
            AddItem(ItemID.IntenseGreenFlameDye, Utils.UniversalDyeCost);
            AddItem(ItemID.IntenseBlueFlameDye, Utils.UniversalDyeCost);
            AddItem(ItemID.IntenseRainbowDye, Utils.UniversalDyeCost);
            return;
        }

        if (shop == "Bright")
        {
            AddItem(ItemID.BrightRedDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BrightOrangeDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BrightYellowDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BrightLimeDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BrightGreenDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BrightTealDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BrightCyanDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BrightSkyBlueDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BrightBlueDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BrightPurpleDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BrightVioletDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BrightPinkDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BrightBrownDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BrightSilverDye, Utils.UniversalDyeCost);
            return;
        }

        if (shop == "Basic")
        {
            AddItem(ItemID.RedDye, Utils.UniversalDyeCost);
            AddItem(ItemID.OrangeDye, Utils.UniversalDyeCost);
            AddItem(ItemID.YellowDye, Utils.UniversalDyeCost);
            AddItem(ItemID.LimeDye, Utils.UniversalDyeCost);
            AddItem(ItemID.GreenDye, Utils.UniversalDyeCost);
            AddItem(ItemID.TealDye, Utils.UniversalDyeCost);
            AddItem(ItemID.SkyBlueDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BlueDye, Utils.UniversalDyeCost);
            AddItem(ItemID.PurpleDye, Utils.UniversalDyeCost);
            AddItem(ItemID.VioletDye, Utils.UniversalDyeCost);
            AddItem(ItemID.PinkDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BlackDye, Utils.UniversalDyeCost);
            AddItem(ItemID.BrownDye, Utils.UniversalDyeCost);
            AddItem(ItemID.SilverDye, Utils.UniversalDyeCost);

            return;
        }

        // Default Shop
        Inv.SetupShop(12);
    }
}