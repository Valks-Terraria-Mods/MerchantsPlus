global using MerchantsPlus.UI;
global using Microsoft.Xna.Framework;
global using System.Collections.Generic;
global using Terraria;
global using Terraria.ModLoader;
global using Terraria.UI;

using MerchantsPlus.Merchants;
using System;
using System.Linq;
using System.Reflection;

namespace MerchantsPlus;

internal class MerchantsPlus : Mod
{
    public static MagicStorageDefs MagicStorageDefs { get; private set; }
    public static bool IsMagicStorageLoaded() => MagicStorageDefs != null;

    public override void Load()
    {
        if (ModLoader.TryGetMod("MagicStorage", out Mod magicStorage))
        {
            MagicStorageDefs = new(magicStorage);
            AddShopForModdedNPC(MagicStorageDefs.Golem.Type, 
                new ShopGolem("Storage"));
        }
    }

    void AddShopForModdedNPC(int type, Shop shop)
    {
        UIEvents.ShopNPCs.Add(type);
        ShopUI.Shops.Add(type, shop);
    }
}

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
    public static ModItem StorageUnitLuminite { get; private set; }
    public static ModItem StorageUnitTerra { get; private set; }
    public static ModItem StorageUnitTiny { get; private set; }
    public static ModItem StorageDeactivator { get; private set; }
    public static ModItem StorageConnector { get; private set; }
    public static ModItem RemoteAccess { get; private set; }

    readonly Mod magicStorage;

    public MagicStorageDefs(Mod magicStorage)
    {
        this.magicStorage = magicStorage;

        if (magicStorage == null)
            return;

        Golem = TryGetNPC(nameof(Golem));

        PropertyInfo[] props = typeof(MagicStorageDefs).GetProperties();

        foreach (PropertyInfo prop in props)
            if (prop.PropertyType == typeof(ModItem))
                prop.SetValue(this, TryGetItem(prop.Name));
    }

    ModNPC TryGetNPC(string name)
    {
        if (magicStorage.TryFind(name, out ModNPC npc))
            return npc;

        return null;
    }

    ModItem TryGetItem(string name)
    {
        if (magicStorage.TryFind(name, out ModItem item))
            return item;

        return null;
    }
}
