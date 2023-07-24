global using log4net;
global using MerchantsPlus.UI;
global using Microsoft.Xna.Framework;
global using System.Collections.Generic;
global using Terraria;
global using Terraria.ModLoader;
global using Terraria.UI;

using System.Diagnostics.CodeAnalysis;

namespace MerchantsPlus;

internal class MerchantsPlus : Mod
{
    public static MerchantsPlus Instance { get; set; }
    public static ILog Console { get; set; }
    
    public override void Load()
    {
        Instance = this;
        Console = this.Logger;
        Config.Load();
    }

    [SuppressMessage("Style", "IDE0022:Use expression body for method", 
        Justification = "More code could be added")]
    public override void Unload()
    {
        Instance = null;
    }
}