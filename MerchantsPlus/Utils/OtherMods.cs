using System.Reflection;

namespace MerchantsPlus.Utils;

public static class OtherMods
{
    private static bool TryGetMod(string modName, out Mod mod)
    {
        return ModLoader.TryGetMod(modName, out mod);
    }

    private static bool TryGetModType(string modName, string typeName, out Type type)
    {
        type = null;

        if (!TryGetMod(modName, out Mod mod) || mod.Code is null)
        {
            return false;
        }

        type = mod.Code.GetType(typeName);
        return type is not null;
    }

    public static ModItem TryFindItem(Mod mod, string name)
    {
        return mod.TryFind(name, out ModItem item) ? item : null;
    }

    public static ModNPC TryFindNpc(Mod mod, string name)
    {
        return mod.TryFind(name, out ModNPC npc) ? npc : null;
    }

    public static int TryFindItemType(string modName, string itemName)
    {
        if (!TryGetMod(modName, out Mod mod))
        {
            return ItemID.None;
        }

        return mod.TryFind(itemName, out ModItem item) ? item.Type : ItemID.None;
    }

    public static bool TryGetStaticBoolField(string modName, string typeName, string fieldName)
    {
        if (!TryGetModType(modName, typeName, out Type type))
        {
            return false;
        }

        FieldInfo field = type.GetField(fieldName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
        return field?.GetValue(null) is bool value && value;
    }

    public static bool TryInvokeBoolMember(string modName, string typeName, string memberName, string methodName)
    {
        if (!TryGetModType(modName, typeName, out Type type))
        {
            return false;
        }

        BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
        object memberValue = type.GetProperty(memberName, bindingFlags)?.GetValue(null)
            ?? type.GetField(memberName, bindingFlags)?.GetValue(null);
        if (memberValue is null)
        {
            return false;
        }

        MethodInfo method = memberValue.GetType().GetMethod(methodName, BindingFlags.Public | BindingFlags.Instance);
        return method?.Invoke(memberValue, null) is bool value && value;
    }
}
