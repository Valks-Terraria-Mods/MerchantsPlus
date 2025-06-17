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

    public MagicStorage(Mod magicStorage)
    {
        if (magicStorage != null)
        {
            ModHelpers.SetModValues(this, magicStorage);
        }
    }
}
