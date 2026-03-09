using Magic = MerchantsPlus.ModDefs.MagicStorage;

namespace MerchantsPlus.Shops;

public static class ShopGolemCatalog
{
    public const string StorageShopName = "Storage";
    public static readonly string[] ShopNames = [StorageShopName];

    public static ModItem[] BaseStorageItems()
    {
        return
        [
            Magic.StorageHeart,
            Magic.CraftingAccess,
            Magic.StorageAccess,
            Magic.StorageUnitTiny,
            Magic.StorageUnit,
        ];
    }

    public static readonly ProgressionModShopTier[] StorageProgressionTiers =
    [
        new(1, Coins.Silver(3), EvilStorageItems),
        new(2, Coins.Silver(10), static () => [Magic.UpgradeHellstone, Magic.StorageUnitHellstone]),
        new(3, Coins.Silver(15), static () => [Magic.StorageUnitBlueChlorophyte]),
        new(4, Coins.Gold(), static () => [Magic.UpgradeHallowed, Magic.StorageUnitHallowed]),
        new(5, Coins.Gold(2), static () => [Magic.UpgradeLuminite, Magic.StorageUnitLuminite]),
        new(6, Coins.Gold(3), static () => [Magic.UpgradeTerra, Magic.StorageUnitTerra]),
        new(7, Coins.Gold(), static () => [Magic.RemoteAccess]),
    ];

    private static ModItem[] EvilStorageItems()
    {
        if (Config.Instance?.UnlockAllItems == true)
        {
            return [Magic.UpgradeCrimtane, Magic.StorageUnitCrimtane, Magic.UpgradeDemonite, Magic.StorageUnitDemonite];
        }

        return WorldGen.crimson
            ? [Magic.UpgradeCrimtane, Magic.StorageUnitCrimtane]
            : [Magic.UpgradeDemonite, Magic.StorageUnitDemonite];
    }
}
