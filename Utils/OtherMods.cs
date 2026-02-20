using System.Reflection;

namespace MerchantsPlus.Utils;

public static class OtherMods
{
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
        if (!ModLoader.TryGetMod(modName, out Mod mod))
        {
            return ItemID.None;
        }

        return mod.TryFind(itemName, out ModItem item) ? item.Type : ItemID.None;
    }

    public static bool TryGetStaticBoolField(string modName, string typeName, string fieldName)
    {
        if (!ModLoader.TryGetMod(modName, out Mod mod) || mod.Code is null)
        {
            return false;
        }

        Type type = mod.Code.GetType(typeName);
        if (type is null)
        {
            return false;
        }

        FieldInfo field = type.GetField(fieldName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
        return field?.GetValue(null) is bool value && value;
    }

    public static bool TryInvokeBoolMember(string modName, string typeName, string memberName, string methodName)
    {
        if (!ModLoader.TryGetMod(modName, out Mod mod) || mod.Code is null)
        {
            return false;
        }

        Type type = mod.Code.GetType(typeName);
        if (type is null)
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
