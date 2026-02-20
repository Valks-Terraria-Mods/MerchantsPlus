namespace MerchantsPlus.Shops;

public static class ShopSkeletonMerchantCatalog
{
    public const string GearShopName = "Gear";
    public const string MusicBoxesShopName = "Music Boxes";

    public static readonly string[] ShopNames =
    [
        GearShopName,
        MusicBoxesShopName,
    ];

    public static readonly int[] MusicBoxes =
    [
        ItemID.MusicBoxAltOverworldDay,
        ItemID.MusicBoxAltUnderground,
        ItemID.MusicBoxBoss1,
        ItemID.MusicBoxBoss2,
        ItemID.MusicBoxBoss3,
        ItemID.MusicBoxBoss4,
        ItemID.MusicBoxBoss5,
        ItemID.MusicBoxCorruption,
        ItemID.MusicBoxCrimson,
        ItemID.MusicBoxDD2,
        ItemID.MusicBoxDesert,
        ItemID.MusicBoxDungeon,
        ItemID.MusicBoxEclipse,
        ItemID.MusicBoxEerie,
        ItemID.MusicBoxFrostMoon,
        ItemID.MusicBoxGoblins,
        ItemID.MusicBoxIce,
        ItemID.MusicBoxJungle,
        ItemID.MusicBoxLunarBoss,
        ItemID.MusicBoxMartians,
        ItemID.MusicBoxMushrooms,
        ItemID.MusicBoxNight,
        ItemID.MusicBoxOcean,
        ItemID.MusicBoxOverworldDay,
        ItemID.MusicBoxPlantera,
        ItemID.MusicBoxPumpkinMoon,
        ItemID.MusicBoxRain,
        ItemID.MusicBoxSandstorm,
        ItemID.MusicBoxSnow,
        ItemID.MusicBoxSpace,
        ItemID.MusicBoxTemple,
        ItemID.MusicBoxTheHallow,
    ];

    public static readonly int[] YoyoAccessories =
    [
        ItemID.PinkString,
        ItemID.PurpleCounterweight,
        ItemID.YoYoGlove,
    ];

    public static readonly ConditionalShopOffer[] GearSoulOffers =
    [
        new(() => Progression.Hardmode && WorldUtils.Kills(NPCID.WyvernHead) > 0, ItemID.SoulofFlight),
        new(() => Progression.Hardmode && NPC.downedMechBoss3, ItemID.SoulofFright),
        new(() => Progression.Hardmode && WorldUtils.Kills(NPCID.IlluminantSlime) > 0, ItemID.SoulofLight),
        new(() => Progression.Hardmode && NPC.downedMechBoss2, ItemID.SoulofMight),
        new(() => Progression.Hardmode && (WorldUtils.Kills(NPCID.Clinger) > 0 || WorldUtils.Kills(NPCID.IchorSticker) > 0), ItemID.SoulofNight),
        new(() => Progression.Hardmode && NPC.downedMechBoss1, ItemID.SoulofSight),
    ];

}

