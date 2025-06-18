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

    public static void Load(Mod magicStorage)
    {
        Golem = ExternalModUtils.TryFindNpc(magicStorage, nameof(Golem));
        StorageComponent = ExternalModUtils.TryFindItem(magicStorage, nameof(StorageComponent));
        StorageAccess = ExternalModUtils.TryFindItem(magicStorage, nameof(StorageAccess));
        StorageHeart = ExternalModUtils.TryFindItem(magicStorage, nameof(StorageHeart));
        StorageUnit = ExternalModUtils.TryFindItem(magicStorage, nameof(StorageUnit));
        CraftingAccess = ExternalModUtils.TryFindItem(magicStorage, nameof(CraftingAccess));
        StorageUnitCrimtane = ExternalModUtils.TryFindItem(magicStorage, nameof(StorageUnitCrimtane));
        StorageUnitDemonite = ExternalModUtils.TryFindItem(magicStorage, nameof(StorageUnitDemonite));
        StorageUnitHallowed = ExternalModUtils.TryFindItem(magicStorage, nameof(StorageUnitHallowed));
        StorageUnitHellstone = ExternalModUtils.TryFindItem(magicStorage, nameof(StorageUnitHellstone));
        StorageUnitBlueChlorophyte = ExternalModUtils.TryFindItem(magicStorage, nameof(StorageUnitBlueChlorophyte));
        StorageUnitLuminite = ExternalModUtils.TryFindItem(magicStorage, nameof(StorageUnitLuminite));
        StorageUnitTerra = ExternalModUtils.TryFindItem(magicStorage, nameof(StorageUnitTerra));
        StorageUnitTiny = ExternalModUtils.TryFindItem(magicStorage, nameof(StorageUnitTiny));
        StorageDeactivator = ExternalModUtils.TryFindItem(magicStorage, nameof(StorageDeactivator));
        StorageConnector = ExternalModUtils.TryFindItem(magicStorage, nameof(StorageConnector));
        RemoteAccess = ExternalModUtils.TryFindItem(magicStorage, nameof(RemoteAccess));
        UpgradeCrimtane = ExternalModUtils.TryFindItem(magicStorage, nameof(UpgradeCrimtane));
        UpgradeDemonite = ExternalModUtils.TryFindItem(magicStorage, nameof(UpgradeDemonite));
        UpgradeHallowed = ExternalModUtils.TryFindItem(magicStorage, nameof(UpgradeHallowed));
        UpgradeHellstone = ExternalModUtils.TryFindItem(magicStorage, nameof(UpgradeHellstone));
        UpgradeLuminite = ExternalModUtils.TryFindItem(magicStorage, nameof(UpgradeLuminite));
        UpgradeTerra = ExternalModUtils.TryFindItem(magicStorage, nameof(UpgradeTerra));
    }
}