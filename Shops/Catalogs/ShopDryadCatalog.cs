namespace MerchantsPlus.Shops;

public static class ShopDryadCatalog
{
    public const string SeedsShopName = "Seeds";
    public static readonly string[] ShopNames = [SeedsShopName];

    public static readonly int[] SeedStock =
    [
        ItemID.GrassSeeds,
        ItemID.CorruptSeeds,
        ItemID.HallowedSeeds,
        ItemID.MushroomGrassSeeds,
        ItemID.CrimsonSeeds,
        ItemID.BlinkrootSeeds,
        ItemID.DaybloomSeeds,
        ItemID.DeathweedSeeds,
        ItemID.FireblossomSeeds,
        ItemID.MoonglowSeeds,
        ItemID.WaterleafSeeds,
        ItemID.ShiverthornSeeds,
    ];

    public static readonly ConditionalShopOffer[] SeedUnlocks =
    [
        new(() => !WorldGen.crimson, ItemCosts.Seeds, ItemID.VilePowder),
    ];

}

