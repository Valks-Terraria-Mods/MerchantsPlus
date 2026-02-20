namespace MerchantsPlus.Shops;

public static class ShopArmsDealerCatalog
{
    public const string GunsShopName = "Guns";
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

}

