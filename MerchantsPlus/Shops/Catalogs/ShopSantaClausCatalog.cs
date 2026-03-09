namespace MerchantsPlus.Shops;

public static class ShopSantaClausCatalog
{
    public const string DecorShopName = "Decor";
    public const string BulbsShopName = "Bulbs";
    public const string LightsShopName = "Lights";

    public static readonly string[] ShopNames =
    [
        DecorShopName,
        BulbsShopName,
        LightsShopName,
    ];

    public static readonly int[] HolidayLights =
    [
        ItemID.RedLight,
        ItemID.GreenLight,
        ItemID.BlueLight,
        ItemID.StarTopper1,
        ItemID.StarTopper2,
        ItemID.StarTopper3,
        ItemID.MulticoloredLights,
        ItemID.RedLights,
        ItemID.GreenLights,
        ItemID.BlueLights,
        ItemID.YellowLights,
        ItemID.RedAndYellowLights,
        ItemID.RedAndGreenLights,
        ItemID.YellowAndGreenLights,
        ItemID.BlueAndGreenLights,
        ItemID.RedAndBlueLights,
        ItemID.BlueAndYellowLights,
    ];

    public static readonly int[] HolidayBulbs =
    [
        ItemID.RedBulb,
        ItemID.YellowBulb,
        ItemID.RedAndGreenBulb,
        ItemID.YellowAndGreenBulb,
        ItemID.RedAndYellowBulb,
        ItemID.WhiteBulb,
        ItemID.WhiteAndRedBulb,
        ItemID.WhiteAndYellowBulb,
        ItemID.WhiteAndGreenBulb,
    ];

    public static readonly int[] HolidayDecor =
    [
        ItemID.ChristmasTree,
        ItemID.BowTopper,
        ItemID.WhiteGarland,
        ItemID.WhiteAndRedGarland,
        ItemID.RedGardland,
        ItemID.GreenGardland,
        ItemID.GreenAndWhiteGarland,
        ItemID.MulticoloredBulb,
    ];

    public static readonly IReadOnlyDictionary<string, int[]> ItemsByShop = new Dictionary<string, int[]>
    {
        [DecorShopName] = HolidayDecor,
        [BulbsShopName] = HolidayBulbs,
        [LightsShopName] = HolidayLights,
    };

}

