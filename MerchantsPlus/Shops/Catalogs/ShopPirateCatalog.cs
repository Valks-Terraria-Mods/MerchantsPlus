namespace MerchantsPlus.Shops;

public static class ShopPirateCatalog
{
    public const string ArrrShopName = "Arrr";
    public static readonly string[] ShopNames = [ArrrShopName];

    public static readonly int[] ClassEmblems =
    [
        ItemID.RangerEmblem,
        ItemID.SorcererEmblem,
        ItemID.SummonerEmblem,
        ItemID.WarriorEmblem,
    ];

    public static readonly int[] PirateSupplies =
    [
        ItemID.Sail,
        ItemID.ParrotCracker,
        ItemID.BunnyCannon,
    ];

    public static readonly IReadOnlyDictionary<string, (int? Price, int[] ItemIds)[]> SectionsByShop =
        new Dictionary<string, (int? Price, int[] ItemIds)[]>
        {
            [ArrrShopName] =
            [
                (null, PirateSupplies),
                (Coins.Platinum(), ClassEmblems),
            ],
        };

}

