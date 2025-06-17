namespace MerchantsPlus.Shops;

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
            AddItem(ItemID.NebulaDye, ItemCosts.Dyes);
            AddItem(ItemID.SolarDye, ItemCosts.Dyes);
            AddItem(ItemID.StardustDye, ItemCosts.Dyes);
            AddItem(ItemID.VortexDye, ItemCosts.Dyes);
            return;
        }

        if (shop == "Strange")
        {
            AddItem(ItemID.AcidDye, ItemCosts.Dyes);
            AddItem(ItemID.BlueAcidDye, ItemCosts.Dyes);
            AddItem(ItemID.RedAcidDye, ItemCosts.Dyes);
            AddItem(ItemID.ChlorophyteDye, ItemCosts.Dyes);
            AddItem(ItemID.GelDye, ItemCosts.Dyes);
            AddItem(ItemID.MushroomDye, ItemCosts.Dyes);
            AddItem(ItemID.GrimDye, ItemCosts.Dyes);
            AddItem(ItemID.HadesDye, ItemCosts.Dyes);
            AddItem(ItemID.BurningHadesDye, ItemCosts.Dyes);
            AddItem(ItemID.ShadowDye, ItemCosts.Dyes);
            AddItem(ItemID.LivingOceanDye, ItemCosts.Dyes);
            AddItem(ItemID.LivingFlameDye, ItemCosts.Dyes);
            AddItem(ItemID.RainbowDye, ItemCosts.Dyes);
            AddItem(ItemID.MartianArmorDye, ItemCosts.Dyes);
            AddItem(ItemID.MidnightRainbowDye, ItemCosts.Dyes);
            AddItem(ItemID.MirageDye, ItemCosts.Dyes);
            AddItem(ItemID.NegativeDye, ItemCosts.Dyes);
            AddItem(ItemID.PixieDye, ItemCosts.Dyes);
            AddItem(ItemID.PhaseDye, ItemCosts.Dyes);
            AddItem(ItemID.PurpleOozeDye, ItemCosts.Dyes);
            AddItem(ItemID.ReflectiveDye, ItemCosts.Dyes);
            AddItem(ItemID.ReflectiveCopperDye, ItemCosts.Dyes);
            AddItem(ItemID.ReflectiveGoldDye, ItemCosts.Dyes);
            AddItem(ItemID.ReflectiveObsidianDye, ItemCosts.Dyes);
            AddItem(ItemID.ReflectiveMetalDye, ItemCosts.Dyes);
            AddItem(ItemID.ReflectiveSilverDye, ItemCosts.Dyes);
            AddItem(ItemID.ShadowDye, ItemCosts.Dyes);
            AddItem(ItemID.ShiftingSandsDye, ItemCosts.Dyes);
            AddItem(ItemID.DevDye, ItemCosts.Dyes);
            AddItem(ItemID.TwilightDye, ItemCosts.Dyes);
            AddItem(ItemID.WispDye, ItemCosts.Dyes);
            AddItem(ItemID.InfernalWispDye, ItemCosts.Dyes);
            AddItem(ItemID.UnicornWispDye, ItemCosts.Dyes);
            AddItem(ItemID.LokisDye, ItemCosts.Dyes);
            AddItem(ItemID.PinkGelDye, ItemCosts.Dyes);
            AddItem(ItemID.ShiftingPearlSandsDye, ItemCosts.Dyes);
            AddItem(ItemID.TeamDye, ItemCosts.Dyes);
            AddItem(ItemID.VoidDye, ItemCosts.Dyes);
            return;
        }

        if (shop == "Compound")
        {
            AddItem(ItemID.RedandBlackDye, ItemCosts.Dyes);
            AddItem(ItemID.OrangeandBlackDye, ItemCosts.Dyes);
            AddItem(ItemID.YellowandBlackDye, ItemCosts.Dyes);
            AddItem(ItemID.LimeandBlackDye, ItemCosts.Dyes);
            AddItem(ItemID.GreenandBlackDye, ItemCosts.Dyes);
            AddItem(ItemID.TealandBlackDye, ItemCosts.Dyes);
            AddItem(ItemID.CyanandBlackDye, ItemCosts.Dyes);
            AddItem(ItemID.SkyBlueandBlackDye, ItemCosts.Dyes);
            AddItem(ItemID.BlueandBlackDye, ItemCosts.Dyes);
            AddItem(ItemID.PurpleandBlackDye, ItemCosts.Dyes);
            AddItem(ItemID.VioletandBlackDye, ItemCosts.Dyes);
            AddItem(ItemID.PinkandBlackDye, ItemCosts.Dyes);
            AddItem(ItemID.BrownAndBlackDye, ItemCosts.Dyes);
            AddItem(ItemID.SilverAndBlackDye, ItemCosts.Dyes);
            AddItem(ItemID.FlameAndBlackDye, ItemCosts.Dyes);
            AddItem(ItemID.FlameAndBlackDye, ItemCosts.Dyes);
            AddItem(ItemID.GreenFlameAndBlackDye, ItemCosts.Dyes);
            AddItem(ItemID.BlueFlameAndBlackDye, ItemCosts.Dyes);
            AddItem(ItemID.RedandSilverDye, ItemCosts.Dyes);
            AddItem(ItemID.OrangeandSilverDye, ItemCosts.Dyes);
            AddItem(ItemID.YellowandSilverDye, ItemCosts.Dyes);
            AddItem(ItemID.LimeandSilverDye, ItemCosts.Dyes);
            AddItem(ItemID.GreenandSilverDye, ItemCosts.Dyes);
            AddItem(ItemID.TealandSilverDye, ItemCosts.Dyes);
            AddItem(ItemID.CyanandSilverDye, ItemCosts.Dyes);
            AddItem(ItemID.SkyBlueandSilverDye, ItemCosts.Dyes);
            AddItem(ItemID.BlueandSilverDye, ItemCosts.Dyes);
            AddItem(ItemID.PurpleandSilverDye, ItemCosts.Dyes);
            AddItem(ItemID.VioletandSilverDye, ItemCosts.Dyes);
            AddItem(ItemID.PinkandSilverDye, ItemCosts.Dyes);
            AddItem(ItemID.BrownAndSilverDye, ItemCosts.Dyes);
            AddItem(ItemID.BlackAndWhiteDye, ItemCosts.Dyes);
            AddItem(ItemID.FlameAndSilverDye, ItemCosts.Dyes);
            AddItem(ItemID.GreenFlameAndSilverDye, ItemCosts.Dyes);
            AddItem(ItemID.BlueFlameAndSilverDye, ItemCosts.Dyes);
            return;
        }

        if (shop == "Gradient")
        {
            AddItem(ItemID.FlameDye, ItemCosts.Dyes);
            AddItem(ItemID.GreenFlameDye, ItemCosts.Dyes);
            AddItem(ItemID.BlueFlameDye, ItemCosts.Dyes);
            AddItem(ItemID.YellowGradientDye, ItemCosts.Dyes);
            AddItem(ItemID.CyanGradientDye, ItemCosts.Dyes);
            AddItem(ItemID.VioletGradientDye, ItemCosts.Dyes);
            AddItem(ItemID.RainbowDye, ItemCosts.Dyes);
            AddItem(ItemID.IntenseFlameDye, ItemCosts.Dyes);
            AddItem(ItemID.IntenseGreenFlameDye, ItemCosts.Dyes);
            AddItem(ItemID.IntenseBlueFlameDye, ItemCosts.Dyes);
            AddItem(ItemID.IntenseRainbowDye, ItemCosts.Dyes);
            return;
        }

        if (shop == "Bright")
        {
            AddItem(ItemID.BrightRedDye, ItemCosts.Dyes);
            AddItem(ItemID.BrightOrangeDye, ItemCosts.Dyes);
            AddItem(ItemID.BrightYellowDye, ItemCosts.Dyes);
            AddItem(ItemID.BrightLimeDye, ItemCosts.Dyes);
            AddItem(ItemID.BrightGreenDye, ItemCosts.Dyes);
            AddItem(ItemID.BrightTealDye, ItemCosts.Dyes);
            AddItem(ItemID.BrightCyanDye, ItemCosts.Dyes);
            AddItem(ItemID.BrightSkyBlueDye, ItemCosts.Dyes);
            AddItem(ItemID.BrightBlueDye, ItemCosts.Dyes);
            AddItem(ItemID.BrightPurpleDye, ItemCosts.Dyes);
            AddItem(ItemID.BrightVioletDye, ItemCosts.Dyes);
            AddItem(ItemID.BrightPinkDye, ItemCosts.Dyes);
            AddItem(ItemID.BrightBrownDye, ItemCosts.Dyes);
            AddItem(ItemID.BrightSilverDye, ItemCosts.Dyes);
            return;
        }

        if (shop == "Basic")
        {
            AddItem(ItemID.RedDye, ItemCosts.Dyes);
            AddItem(ItemID.OrangeDye, ItemCosts.Dyes);
            AddItem(ItemID.YellowDye, ItemCosts.Dyes);
            AddItem(ItemID.LimeDye, ItemCosts.Dyes);
            AddItem(ItemID.GreenDye, ItemCosts.Dyes);
            AddItem(ItemID.TealDye, ItemCosts.Dyes);
            AddItem(ItemID.SkyBlueDye, ItemCosts.Dyes);
            AddItem(ItemID.BlueDye, ItemCosts.Dyes);
            AddItem(ItemID.PurpleDye, ItemCosts.Dyes);
            AddItem(ItemID.VioletDye, ItemCosts.Dyes);
            AddItem(ItemID.PinkDye, ItemCosts.Dyes);
            AddItem(ItemID.BlackDye, ItemCosts.Dyes);
            AddItem(ItemID.BrownDye, ItemCosts.Dyes);
            AddItem(ItemID.SilverDye, ItemCosts.Dyes);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.DyeTrader);
    }
}