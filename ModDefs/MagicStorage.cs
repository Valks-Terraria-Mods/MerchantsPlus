using MerchantsPlus.Utils;

namespace MerchantsPlus.ModDefs;

public class MagicStorage
{
    // ModNPC
    public static ModNPC Golem { get; private set; }

    // ModItem
    public static ModItem StorageComponent { get; private set; }
    public static ModItem StorageAccess { get; private set; }
    public static ModItem StorageHeart { get; private set; }
    public static ModItem StorageUnit { get; private set; }
    public static ModItem CraftingAccess { get; private set; }
    public static ModItem StorageUnitCrimtane { get; private set; }
    public static ModItem StorageUnitDemonite { get; private set; }
    public static ModItem StorageUnitHallowed { get; private set; }
    public static ModItem StorageUnitHellstone { get; private set; }
    public static ModItem StorageUnitBlueChlorophyte { get; private set; }
    public static ModItem StorageUnitLuminite { get; private set; }
    public static ModItem StorageUnitTerra { get; private set; }
    public static ModItem StorageUnitTiny { get; private set; }
    public static ModItem StorageDeactivator { get; private set; }
    public static ModItem StorageConnector { get; private set; }
    public static ModItem RemoteAccess { get; private set; }
    public static ModItem UpgradeCrimtane { get; private set; }
    public static ModItem UpgradeDemonite { get; private set; }
    public static ModItem UpgradeHallowed { get; private set; }
    public static ModItem UpgradeHellstone { get; private set; }
    public static ModItem UpgradeLuminite { get; private set; }
    public static ModItem UpgradeTerra { get; private set; }

    public static void Load(Mod mod)
    {
        Golem = OtherMods.TryFindNpc(mod, nameof(Golem));
        StorageComponent = OtherMods.TryFindItem(mod, nameof(StorageComponent));
        StorageAccess = OtherMods.TryFindItem(mod, nameof(StorageAccess));
        StorageHeart = OtherMods.TryFindItem(mod, nameof(StorageHeart));
        StorageUnit = OtherMods.TryFindItem(mod, nameof(StorageUnit));
        CraftingAccess = OtherMods.TryFindItem(mod, nameof(CraftingAccess));
        StorageUnitCrimtane = OtherMods.TryFindItem(mod, nameof(StorageUnitCrimtane));
        StorageUnitDemonite = OtherMods.TryFindItem(mod, nameof(StorageUnitDemonite));
        StorageUnitHallowed = OtherMods.TryFindItem(mod, nameof(StorageUnitHallowed));
        StorageUnitHellstone = OtherMods.TryFindItem(mod, nameof(StorageUnitHellstone));
        StorageUnitBlueChlorophyte = OtherMods.TryFindItem(mod, nameof(StorageUnitBlueChlorophyte));
        StorageUnitLuminite = OtherMods.TryFindItem(mod, nameof(StorageUnitLuminite));
        StorageUnitTerra = OtherMods.TryFindItem(mod, nameof(StorageUnitTerra));
        StorageUnitTiny = OtherMods.TryFindItem(mod, nameof(StorageUnitTiny));
        StorageDeactivator = OtherMods.TryFindItem(mod, nameof(StorageDeactivator));
        StorageConnector = OtherMods.TryFindItem(mod, nameof(StorageConnector));
        RemoteAccess = OtherMods.TryFindItem(mod, nameof(RemoteAccess));
        UpgradeCrimtane = OtherMods.TryFindItem(mod, nameof(UpgradeCrimtane));
        UpgradeDemonite = OtherMods.TryFindItem(mod, nameof(UpgradeDemonite));
        UpgradeHallowed = OtherMods.TryFindItem(mod, nameof(UpgradeHallowed));
        UpgradeHellstone = OtherMods.TryFindItem(mod, nameof(UpgradeHellstone));
        UpgradeLuminite = OtherMods.TryFindItem(mod, nameof(UpgradeLuminite));
        UpgradeTerra = OtherMods.TryFindItem(mod, nameof(UpgradeTerra));
    }
}