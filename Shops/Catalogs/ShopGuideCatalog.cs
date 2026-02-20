namespace MerchantsPlus.Shops;

public static class ShopGuideCatalog
{
    public const string GearShopName = "Gear";
    public const string PylonsShopName = "Pylons";
    public const string VanillaShopName = "Vanilla";
    public const string CalamityShopName = "Calamity";
    public const string ThoriumShopName = "Thorium";
    public const string RedemptionShopName = "Redemption";

    public static readonly string[] ShopNames =
    [
        GearShopName,
        PylonsShopName,
        VanillaShopName,
    ];

    public static readonly int[] UtilityGear =
    [
        ItemID.MagicMirror,
        ItemID.CordageGuide,
    ];

    public static readonly int[] Pylons =
    [
        ItemID.TeleportationPylonVictory,
        ItemID.TeleportationPylonUnderground,
        ItemID.TeleportationPylonSnow,
        ItemID.TeleportationPylonPurity,
        ItemID.TeleportationPylonOcean,
        ItemID.TeleportationPylonMushroom,
        ItemID.TeleportationPylonJungle,
        ItemID.TeleportationPylonHallow,
        ItemID.TeleportationPylonDesert,
    ];

}

