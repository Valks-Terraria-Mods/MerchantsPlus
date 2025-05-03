using MerchantsPlus.ModDefs;
using System.Reflection;

namespace MerchantsPlus;

public static class Utils
{
    public static void SetModValues(object instance, Mod mod)
    {
        SetPropValues<MagicStorage, ModNPC>(instance, (string name) => TryGetNPC(mod, name));
        SetPropValues<MagicStorage, ModItem>(instance, (string name) => TryGetItem(mod, name));
    }

    private static ModNPC TryGetNPC(Mod mod, string name)
    {
        if (mod.TryFind(name, out ModNPC npc))
        {
            return npc;
        }

        return null;
    }

    private static ModItem TryGetItem(Mod mod, string name)
    {
        if (mod.TryFind(name, out ModItem item))
        {
            return item;
        }

        return null;
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
    /// <typeparam name="DefClass">The class the properties are defined in</typeparam>
    /// <typeparam name="PropType">The type of properties to look for</typeparam>
    /// <param name="defClass">The class the properties are defined in</param>
    /// <param name="propFunc">The function to set the value for each property</param>
    public static void SetPropValues<DefClass, PropType>(object defClass, Func<string, object> propFunc)
    {
        PropertyInfo[] properties = typeof(DefClass).GetProperties();

        foreach (PropertyInfo prop in properties)
        {
            if (prop.PropertyType == typeof(PropType))
            {
                prop.SetValue(defClass, propFunc(prop.Name));
            }
        }
    }

    public static int UniversalPotionCost    { get; } = Coins.Gold(1);
    public static int UniversalAccessoryCost { get; } = Coins.Gold(1);
    public static int UniversalOreCost       { get; } = Coins.Gold(1);
    public static int UniversalPetCost       { get; } = Coins.Gold(1);
    public static int UniversalMountCost     { get; } = Coins.Gold(5);
    public static int UniversalVanityCost    { get; } = Coins.Gold(1);
    public static int UniversalSeedCost      { get; } = Coins.Gold(1);
    public static int UniversalDyeCost       { get; } = Coins.Gold(1);

    public static bool TalkingToNPC() => Main.LocalPlayer.talkNPC >= 0;

    public static void QuestKills(List<string> dialog, string enemy, int curKills, int targetKills)
    {
        if (curKills < targetKills)
        {
            dialog.Add($"Quest: Kill {targetKills - curKills} more {enemy}");
        }
    }

    public static bool HasNPC(int npcID) => NPC.AnyNPCs(npcID);

    public static bool PlayersHaveItem(short[] items)
    {
        for (int k = 0; k < 255; k++)
        {
            Player player = Main.player[k];
            if (player.active)
            {
                for (int j = 0; j < player.inventory.Length; j++)
                {
                    for (int i = 0; i < items.Length; i++)
                    {
                        if (player.inventory[j].type == items[i])
                        {
                            return true;
                        }
                    }
                }
            }
        }
        return false;
    }

    public static PlayerClass GetPlayerClass()
    {
        Player p = Main.LocalPlayer;

        if (p.HeldItem != null && p.HeldItem.damage > 0)
        {
            Item heldItem = p.HeldItem;

            if (heldItem.CountsAsClass(DamageClass.Melee))
            {
                return PlayerClass.Melee;
            }

            if (heldItem.CountsAsClass(DamageClass.Ranged))
            {
                return PlayerClass.Ranger;
            }

            if (heldItem.CountsAsClass(DamageClass.Magic))
            {
                return PlayerClass.Mage;
            }

            if (heldItem.CountsAsClass(DamageClass.Summon))
            {
                return PlayerClass.Summoner;
            }

            if (heldItem.CountsAsClass(DamageClass.Throwing))
            {
                return PlayerClass.Thrower;
            }
        }

        return PlayerClass.Melee;
    }

    public static string Dialog(string[] lines) => lines[Main.rand.Next(lines.Length)];

    public static int Kills(short theNPC) => NPC.killCount[Item.NPCtoBanner(theNPC)];

    public static int MultiKills(short[] npcs)
    {
        int Kills = 0;
        for (int i = 0; i < npcs.Length; i++)
        {
            Kills += NPC.killCount[Item.NPCtoBanner(npcs[i])];
        }
        return Kills;
    }

    public static bool IsNPCHere(short npc)
    {
        int theNPC = NPC.FindFirstNPC(npc);
        if (theNPC >= 0)
        {
            return true;
        }
        return false;
    }

    public static string GetNPCName(short npc)
    {
        int theNPC = NPC.FindFirstNPC(npc);

        if (IsNPCHere(npc))
        {
            return Main.npc[theNPC].GivenName;
        }
        else
        {
            return "someone";
        }
    }

    public static string DialogGift(NPC npc, string moneyDialog, string noMoneyDialog, bool condition, int chance, short item, int price)
    {
        if (condition)
        {
            if (Main.rand.Next(0, 100) < chance)
            {
                if (Main.LocalPlayer.BuyItem(price))
                { // Take the gold. (1 is 1 copper) (100 is 1 silver) (1000 is 1 gold)
                    if (!Main.LocalPlayer.HasItem(item))
                    {
                        _ = Item.NewItem(NPC.GetSource_NaturalSpawn(), npc.position, item);

                        if (price <= 0)
                        {
                            return moneyDialog;
                        }
                        else if (price < 100)
                        {
                            return moneyDialog + " " + price + " copper was removed from your inventory";
                        }
                        else if (price is >= 100 and < 1000)
                        {
                            return moneyDialog + " " + (price / 100) + " silver was removed from your inventory";
                        }
                        else if (price is >= 1000 and < 10000)
                        {
                            return moneyDialog + " " + (price / 1000) + " gold was removed from your inventory";
                        }
                        else
                        {
                            return moneyDialog + " " + (price / 10000) + " platinum was removed from your inventory";
                        }
                    }
                }
            }
        }

        // Not enough money.
        return noMoneyDialog;
    }
}
