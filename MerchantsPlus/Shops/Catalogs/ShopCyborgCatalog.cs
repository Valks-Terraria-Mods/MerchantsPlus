namespace MerchantsPlus.Shops;

public static class ShopCyborgCatalog
{
    public const string RoboticsShopName = "Robotics";
    public static readonly string[] ShopNames = [RoboticsShopName];

    public static readonly int[] RoboticsGear =
    [
        ItemID.ProximityMineLauncher,
        ItemID.Nanites,
        ItemID.PortalGun,
        ItemID.PortalGunStation,
    ];

    public static readonly ConditionalShopOffer[] RoboticsUnlocks =
    [
        new(() => Progression.Golem, ItemID.ElectrosphereLauncher),
        new(() => NPC.downedFishron, ItemID.RocketLauncher),
        new(() => NPC.downedAncientCultist, ItemID.SnowmanCannon),
        new(() => NPC.downedTowerVortex, ItemID.NailGun),
    ];

}

