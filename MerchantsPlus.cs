global using log4net;
global using MerchantsPlus.UI;
global using Microsoft.Xna.Framework;
global using System.Collections.Generic;
global using Terraria;
global using Terraria.ModLoader;
global using Terraria.UI;

namespace MerchantsPlus;

internal class MerchantsPlus : Mod
{
    public static MerchantsPlus Instance { get; private set; }
    public static ILog Console { get; private set; }
    
    public override void Load()
    {
        Instance = this;
        Console = this.Logger;
        Config.Load();
    }

    public override void Unload()
    {
        Instance = null;
    }
}