namespace MerchantsPlus.Utils;

public class OtherMods
{
    public static ModItem TryFindItem(Mod mod, string name)
    {
        return mod.TryFind(name, out ModItem item) ? item : null;
    }

    public static ModNPC TryFindNpc(Mod mod, string name)
    {
        return mod.TryFind(name, out ModNPC npc) ? npc : null;
    }
}