global using MerchantsPlus.UI;
global using Microsoft.Xna.Framework;
global using System.Collections.Generic;
global using Terraria;
global using Terraria.ModLoader;
global using Terraria.UI;

using MerchantsPlus.Merchants;

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
