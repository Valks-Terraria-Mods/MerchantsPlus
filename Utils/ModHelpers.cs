using System.Reflection;
using MerchantsPlus.ModDefs;

namespace MerchantsPlus;

public static class ModHelpers
{
    public static void SetModValues(object instance, Mod mod)
    {
        SetPropValues<MagicStorage, ModNPC>(instance, name => TryGetNpc(mod, name));
        SetPropValues<MagicStorage, ModItem>(instance, name => TryGetItem(mod, name));
    }

    private static ModNPC TryGetNpc(Mod mod, string name)
    {
        return mod.TryFind(name, out ModNPC npc) ? npc : null;
    }

    private static ModItem TryGetItem(Mod mod, string name)
    {
        return mod.TryFind(name, out ModItem item) ? item : null;
    }

    /// <summary>
    /// <para>
    /// Loop through all the properties of type 'PropType' in a class where
    /// these properties are defined 'DefClass' and set them to the object
    /// value returned by 'propFunc'.
    /// </para>
    /// 
    /// <para>
    /// Note that this function is specifically used for setting properties like
    /// ModItem and ModNPC, thus the reason why 'propFunc' takes in a string param.
    /// </para>
    /// </summary>
    /// <typeparam name="TDefClass">The class the properties are defined in</typeparam>
    /// <typeparam name="TPropType">The type of properties to look for</typeparam>
    /// <param name="defClass">The class the properties are defined in</param>
    /// <param name="propFunc">The function to set the value for each property</param>
    private static void SetPropValues<TDefClass, TPropType>(object defClass, Func<string, object> propFunc)
    {
        PropertyInfo[] properties = typeof(TDefClass).GetProperties();

        foreach (PropertyInfo prop in properties)
        {
            if (prop.PropertyType == typeof(TPropType))
            {
                prop.SetValue(defClass, propFunc(prop.Name));
            }
        }
    }
}