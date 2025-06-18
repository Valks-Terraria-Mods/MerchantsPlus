global using MerchantsPlus.UI;
global using Microsoft.Xna.Framework;
global using System.Collections.Generic;
global using Terraria;
global using Terraria.ModLoader;
global using Terraria.UI;
global using Terraria.ID;
global using System;
using MerchantsPlus.Shops;
using MerchantsPlus.ModDefs;

namespace MerchantsPlus;

public class MerchantsPlus : Mod
{
    public override void Load()
    {
        if (ModLoader.TryGetMod("MagicStorage", out Mod magicStorage))
        {
            _ = new MagicStorage(magicStorage);
            AddShopForModdedNpc(MagicStorage.Golem.Type, new ShopGolem());
        }
    }

    private static void AddShopForModdedNpc(int type, Shop shop)
    {
        ShopUI.Shops.Add(type, shop);
    }
}
