namespace MerchantsPlus.Shops;

public static class ShopTravellingMerchantCatalog
{
    public const string GearShopName = "Gear";
    public static readonly string[] ShopNames = [GearShopName];

    public static readonly ProgressionShopItem[] GearItems =
    [
        new(0, ItemID.GoldenKey, Coins.Gold(3)),
    ];

    public static readonly ConditionalShopOffer[] GearUnlocks =
    [
        new(() => Progression.Moonlord, ItemID.SuspiciousLookingTentacle),
    ];
}
