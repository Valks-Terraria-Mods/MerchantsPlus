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
        if (ModLoader.TryGetMod("MagicStorage", out Mod mod))
        {
            MagicStorage.Load(mod);
            ShopUI.Shops.Add(MagicStorage.Golem.Type, new ShopGolem());
        }
    }
}
