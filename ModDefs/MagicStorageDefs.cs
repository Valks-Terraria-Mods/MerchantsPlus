namespace MerchantsPlus;

public class MagicStorageDefs
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

    private readonly Mod magicStorage;

    public MagicStorageDefs(Mod magicStorage)
    {
        this.magicStorage = magicStorage;

        if (magicStorage == null)
        {
            return;
        }

        Utils.SetPropValues<MagicStorageDefs, ModNPC>(this, TryGetNPC);
        Utils.SetPropValues<MagicStorageDefs, ModItem>(this, TryGetItem);
    }

    private ModNPC TryGetNPC(string name)
    {
        if (magicStorage.TryFind(name, out ModNPC npc))
        {
            return npc;
        }

        return null;
    }

    private ModItem TryGetItem(string name)
    {
        if (magicStorage.TryFind(name, out ModItem item))
        {
            return item;
        }

        return null;
    }
}
