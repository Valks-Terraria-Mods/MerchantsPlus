namespace MerchantsPlus.Shops;

public static class ShopWitchDoctorCatalog
{
    public const string GearShopName = "Gear";
    public const string FlasksShopName = "Flasks";
    public const string WingsShopName = "Wings";
    public const int PrehardmodeWingItemId = ItemID.CreativeWings;

    public static readonly string[] ShopNames =
    [
        GearShopName,
        FlasksShopName,
        WingsShopName,
    ];

    public static readonly int[] GearItems =
    [
        ItemID.HerculesBeetle,
    ];

    public static readonly ConditionalShopOffer[] GearUnlocks =
    [
        new(() => Progression.Halloween, ItemID.NecromanticScroll),
        new(() => Progression.Plantera, ItemID.PygmyNecklace),
    ];

    public static readonly int[] FlaskItems =
    [
        ItemID.FlaskofNanites,
    ];

    public static readonly ConditionalShopOffer[] FlaskUnlocks =
    [
        new(() => Progression.LevelFull() > 8, ItemID.FlaskofFire),
        new(() => Progression.LevelFull() > 9, ItemID.FlaskofGold),
        new(() => Progression.LevelFull() > 10, ItemID.FlaskofIchor),
        new(() => Progression.LevelFull() > 11, ItemID.FlaskofCursedFlames),
        new(() => Progression.LevelFull() > 12, ItemID.FlaskofParty),
        new(() => Progression.LevelFull() > 13, ItemID.FlaskofPoison),
        new(() => Progression.LevelFull() > 14, ItemID.FlaskofVenom),
    ];

    public static readonly ConditionalShopOffer[] WingUnlocks =
    [
        new(() => Progression.Hardmode, Coins.Platinum(2), ItemID.AngelWings),
        new(() => Progression.Hardmode && WorldUtils.Kills(NPCID.Demon) >= 3, Coins.Platinum(2), ItemID.DemonWings),
        new(() => Progression.Hardmode && WorldUtils.Kills(NPCID.Shark) >= 3, Coins.Platinum(2), ItemID.FinWings),
        new(() => Progression.Hardmode && NPC.downedMechBossAny, Coins.Platinum(2), HardmodeWings),
        new(() => Progression.Hardmode && NPC.downedChristmasIceQueen, Coins.Platinum(2), ItemID.FestiveWings),
        new(() => Progression.Hardmode && NPC.downedHalloweenKing, Coins.Platinum(2), ItemID.SpookyWings),
        new(() => Progression.Hardmode && WorldUtils.IsNpcHere(NPCID.Steampunker), Coins.Platinum(2), ItemID.SteampunkWings),
        new(() => Progression.Hardmode && NPC.downedFishron, Coins.Platinum(2), ItemID.FishronWings),
        new(() => Progression.Hardmode && Progression.Moonlord, Coins.Platinum(2), LunarWings),
    ];

    public static readonly int[] HardmodeWings =
    [
        ItemID.Jetpack,
        ItemID.BeeWings,
        ItemID.ButterflyWings,
        ItemID.FairyWings,
        ItemID.BatWings,
        ItemID.HarpyWings,
        ItemID.BoneWings,
        ItemID.WillsWings,
        ItemID.CrownosWings,
        ItemID.DTownsWings,
        ItemID.CenxsWings,
        ItemID.Yoraiz0rDarkness,
        ItemID.LokisWings,
        ItemID.BejeweledValkyrieWing,
        ItemID.JimsWings,
        ItemID.SkiphsWings,
        ItemID.RedsWings,
        ItemID.MothronWings,
        ItemID.LeafWings,
        ItemID.FrozenWings,
        ItemID.FlameWings,
        ItemID.BeetleWings,
        ItemID.Hoverboard,
    ];

    public static readonly int[] LunarWings =
    [
        ItemID.WingsStardust,
        ItemID.WingsVortex,
        ItemID.WingsNebula,
        ItemID.WingsSolar,
    ];

}

