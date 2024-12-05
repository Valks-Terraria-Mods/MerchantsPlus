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
    public static MagicStorage MagicStorage { get; private set; }

    public override void Load()
    {
        if (ModLoader.TryGetMod("MagicStorage", out Mod magicStorage))
        {
            MagicStorage = new(magicStorage);
            AddShopForModdedNPC(MagicStorage.Golem.Type, new ShopGolem());
        }

        if (ModLoader.TryGetMod("Calamity", out Mod calamity))
        {

        }
    }

    private static void AddShopForModdedNPC(int type, Shop shop)
    {
        ShopUI.Shops.Add(type, shop);
    }
}
