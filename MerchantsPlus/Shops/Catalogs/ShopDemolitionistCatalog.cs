namespace MerchantsPlus.Shops;

public static class ShopDemolitionistCatalog
{
    public const string ExplosivesShopName = "Explosives";
    public static readonly string[] ShopNames = [ExplosivesShopName];

    public static readonly int[] BaseExplosives =
    [
        ItemID.Grenade,
    ];

    public static readonly int[] HardmodeExplosives =
    [
        ItemID.Explosives,
        ItemID.StickyGrenade,
        ItemID.StickyBomb,
        ItemID.StickyDynamite,
        ItemID.BouncyGrenade,
        ItemID.BouncyBomb,
        ItemID.BouncyDynamite,
    ];

    public static readonly ConditionalShopOffer[] ExplosiveUnlocks =
    [
        new(() => NPC.AnyNPCs(NPCID.PartyGirl), ItemID.PartyGirlGrenade),
        new(() => Progression.SlimeKing, ItemID.Bomb),
        new(() => Progression.EyeOfCthulhu, ItemID.Dynamite),
        new(() => WorldUtils.HasNpc(NPCID.Angler), ItemID.BombFish),
        new(() => Progression.QueenBee, ItemID.Beenade),
        new(() => Progression.Skeletron, ItemID.ExplosiveBunny),
        new(() => Progression.Hardmode, HardmodeExplosives),
        new(() => Progression.BloodMoon, ItemID.ExplosiveJackOLantern),
        new(() => Progression.Moonlord, ItemID.LandMine),
    ];

}

