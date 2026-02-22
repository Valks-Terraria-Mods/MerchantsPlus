namespace MerchantsPlus.Shops;

public static class ShopArmsDealerCatalog
{
    public const string GunsShopName = "Guns";
    public const int AmmoBoxItemId = ItemID.AmmoBox;
    public static readonly string[] ShopNames = [GunsShopName];

    public static readonly int[] PlanteraSniperGear =
    [
        ItemID.SniperRifle,
        ItemID.RifleScope,
    ];

    public static readonly ConditionalShopOffer[] GunUnlocks =
    [
        new(() => Progression.Plantera, PlanteraSniperGear),
        new(() => !Main.dayTime, ItemID.IllegalGunParts),
        new(() => Progression.Hardmode, ItemID.EmptyBullet),
    ];

    public static readonly ConditionalShopOffer[] BulletMainReplacements =
    [
        new(static () => true, ItemID.MusketBall),
        new(() => Progression.EyeOfCthulhu, ItemID.SilverBullet),
        new(() => Progression.BrainOrEater, ItemID.MeteorShot),
        new(() => Progression.WallOfFlesh, ItemID.CursedBullet),
        new(() => Progression.DownedMechs(1), ItemID.IchorBullet),
        new(() => Progression.DownedMechs(2), ItemID.CrystalBullet),
        new(() => Progression.DownedMechs(3), ItemID.ChlorophyteBullet),
        new(() => Progression.Moonlord, ItemID.MoonlordBullet),
    ];

    public static readonly ConditionalShopOffer[] BulletOtherReplacements =
    [
        new(static () => true, ItemID.PartyBullet),
        new(() => Progression.Skeletron, ItemID.ExplodingBullet),
        new(() => Progression.DownedMechs(1), ItemID.GoldenBullet),
        new(() => Progression.DownedMechs(2), ItemID.NanoBullet),
        new(() => Progression.DownedMechs(3), ItemID.HighVelocityBullet),
        new(() => Progression.Plantera, ItemID.VenomBullet),
    ];

    public static readonly ConditionalShopOffer[] PistolReplacements =
    [
        new(static () => true, ItemID.FlintlockPistol),
        new(() => Progression.SlimeKing, ItemID.TheUndertaker),
        new(() => Progression.EyeOfCthulhu, ItemID.Revolver),
        new(() => Progression.BrainOrEater, ItemID.Handgun),
        new(() => Progression.QueenBee, ItemID.PhoenixBlaster),
        new(() => Progression.Hardmode, ItemID.Uzi),
        new(() => Progression.DownedMechs(3), ItemID.VenusMagnum),
    ];

    public static readonly ConditionalShopOffer[] RifleReplacements =
    [
        new(static () => true, ItemID.RedRyder),
        new(() => Progression.EyeOfCthulhu, ItemID.Musket),
        new(() => Progression.BrainOrEater, ItemID.Minishark),
        new(() => Progression.Hardmode, ItemID.ClockworkAssaultRifle),
        new(() => Progression.DownedMechs(1), ItemID.Gatligator),
        new(() => Progression.DownedMechs(2), ItemID.Megashark),
        new(() => NPC.downedAncientCultist, ItemID.VortexBeater),
        new(() => Progression.Moonlord, ItemID.SDMG),
    ];

    public static readonly ConditionalShopOffer[] ShotgunReplacements =
    [
        new(static () => true, ItemID.Boomstick),
        new(() => Progression.Hardmode, ItemID.Shotgun),
        new(() => Progression.DownedMechs(1), ItemID.OnyxBlaster),
        new(() => Progression.Plantera, ItemID.TacticalShotgun),
    ];
}

