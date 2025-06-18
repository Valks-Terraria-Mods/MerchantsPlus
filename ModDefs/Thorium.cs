namespace MerchantsPlus.ModDefs;

public class Thorium
{
    public static bool ModLoaded { get; private set; }
    
    public static ModItem GrandFlareGun { get; private set; }
    public static ModItem StormFlare { get; private set; }

    public static void Load(Mod mod)
    {
        ModLoaded = true;
        
        GrandFlareGun = OtherMods.TryFindItem(mod, nameof(GrandFlareGun));
        StormFlare = OtherMods.TryFindItem(mod, nameof(StormFlare));
    }
}
