namespace MerchantsPlus.Shops;

public static class ShopNurseCatalog
{
    public const string LifeShopName = "Life";
    public static readonly string[] ShopNames = [LifeShopName];

    public static readonly int LifeItemPrice = Coins.Gold(10);

    public static readonly int[] LifeItems =
    [
        ItemID.LifeCrystal,
        ItemID.HeartLantern,
    ];

    public static readonly ConditionalShopOffer[] LifeUnlocks =
    [
        new(() => Progression.DownedMechs(3), LifeItemPrice, ItemID.LifeFruit),
    ];
}
