using System.Linq;
using System.Reflection;

namespace MerchantsPlus;

public static class ExtensionsString
{
    public static string AddSpaceBeforeEachCapital(this string v) =>
        string.Concat(v.Select(x => char.IsUpper(x) ? " " + x : x.ToString())).TrimStart(' ');
}

internal static class Utils
{
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
    public static void SetPropValues<DefClass, PropType>(object defClass, 
        Func<string, object> propFunc)
    {
        PropertyInfo[] properties = typeof(DefClass).GetProperties();

        foreach (PropertyInfo prop in properties)
            if (prop.PropertyType == typeof(PropType))
                prop.SetValue(defClass, propFunc(prop.Name));
    }

    public static int UniversalPotionCost = Coins(0, 0, 5);
    public static int UniversalAccessoryCost = Coins(0, 0, 20);
    public static int UniversalOreCost = Coins(0, 0, 1);
    public static int UniversalPetCost = Coins(0, 0, 5);
    public static int UniversalVanityCost = Coins(0, 0, 5);
    public static int UniversalSeedCost = Coins(0, 0, 1);
    public static int UniversalDyeCost = Coins(0, 0, 1);

    public static bool TalkingToNPC() => Main.LocalPlayer.talkNPC > 0;

    public static void QuestKills(List<string> dialog, string enemy, int curKills, int targetKills)
    {
        if (curKills < targetKills)
            dialog.Add($"Quest: Kill {targetKills - curKills} more {enemy}");
    }

    public enum Progress
    {
        SLIME_KING,
        EYE_OF_CTHULU,
        GOBLIN_ARMY,
        BRAIN_OF_CTHULU,
        QUEEN_BEE,
        SKELETRON,
        WALL_OF_FLESH,
        PIRATES,
        CLOWN,
        MECH_BOSS_1,
        MECH_BOSS_2,
        MECH_BOSS_3,
        HALLOWEEN_TREE,
        HALLOWEEN_KING,
        PLANT_BOSS,
        GOLEM,
        FISHRON,
        CHRISTMAS_ICE_QUEEN,
        CHRISTMAS_SANTA_TANK,
        CHRISTMAS_TREE,
        FROST,
        MARTIANS,
        ANCIENT_CULTIST,
        TOWERS,
        MOONLORD
    }

    /// <summary>
    /// The players progression, the first 7 levels are prehardmode and
    /// the 18 other levels are hardmode. (Making a total of 25 progression
    /// levels.
    /// </summary>
    /// <returns>Returns the players progression level.</returns>
    public static int Progression()
    {
        int progression = 0;

        // Pre
        if (NPC.downedSlimeKing) progression++;
        if (DownedEyeOfCthulhu()) progression++;
        if (NPC.downedGoblins) progression++;
        if (DownedBrainOfCthulhu() || DownedEaterOfWorlds()) progression++;
        if (NPC.downedQueenBee) progression++;
        if (DownedSkeletron()) progression++;
        if (DownedWallOfFlesh()) progression++;

        // Post
        if (NPC.downedPirates) progression++;
        if (NPC.downedClown) progression++;
        if (NPC.downedMechBoss1) progression++;
        if (NPC.downedMechBoss2) progression++;
        if (NPC.downedMechBoss3) progression++;
        if (NPC.downedHalloweenTree) progression++;
        if (NPC.downedHalloweenKing) progression++;
        if (NPC.downedPlantBoss) progression++;
        if (NPC.downedGolemBoss) progression++;
        if (NPC.downedFishron) progression++;
        if (NPC.downedChristmasIceQueen) progression++;
        if (NPC.downedChristmasSantank) progression++;
        if (NPC.downedChristmasTree) progression++;
        if (NPC.downedFrost) progression++;
        if (NPC.downedMartians) progression++;
        if (NPC.downedAncientCultist) progression++;
        if (NPC.downedTowers) progression++;
        if (NPC.downedMoonlord) progression++;

        return progression;
    }

    public static bool HasNPC(int npcID) => NPC.AnyNPCs(npcID);
    public static bool IsHardMode() => Main.hardMode;
    public static bool DownedWallOfFlesh() => Main.hardMode;
    public static bool DownedEyeOfCthulhu() => NPC.downedBoss1;
    public static bool DownedEaterOfWorlds() => NPC.downedBoss2;
    public static bool DownedBrainOfCthulhu() => NPC.downedBoss2;
    public static bool DownedSkeletron() => NPC.downedBoss3;

    public static int Coins() => 
        (int)(Item.sellPrice(0, 1) * Config.Instance.ShopPriceMultiplier);

    public static int Coins(int copper, int silver = 0, int gold = 0, int platinum = 0)
    {
        float basePrice = Item.sellPrice(platinum, gold, silver, copper);

        return (int)(basePrice * Config.Instance.ShopPriceMultiplier);
    }

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

    public static string GetPlayerClass()
    {
        Player p = Main.LocalPlayer;

        if (p.HeldItem != null && p.HeldItem.damage > 0)
        {
            Item heldItem = p.HeldItem;
            if (heldItem.CountsAsClass(DamageClass.Melee)) return "melee";
            if (heldItem.CountsAsClass(DamageClass.Ranged)) return "ranged";
            if (heldItem.CountsAsClass(DamageClass.Magic)) return "mage";
            if (heldItem.CountsAsClass(DamageClass.Summon)) return "summoner";
            if (heldItem.CountsAsClass(DamageClass.Throwing)) return "thrower";
        }

        return "melee";
    }

    public static string Dialog(string[] lines) => 
        lines[Main.rand.Next(lines.Length)];

    public static int DownedMechBosses()
    {
        int count = 0;
        if (NPC.downedMechBoss1) count++;
        if (NPC.downedMechBoss2) count++;
        if (NPC.downedMechBoss3) count++;
        return count;
    }

    public static int Kills(short theNPC) => 
        NPC.killCount[Item.NPCtoBanner(theNPC)];

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
                        Item.NewItem(NPC.GetSource_NaturalSpawn(), npc.position, item);
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

    public static bool IsMerchant(int npcID) => npcID switch
    {
        NPCID.Angler or
        NPCID.ArmsDealer or
        NPCID.Clothier or
        NPCID.Cyborg or
        NPCID.Demolitionist or
        NPCID.Dryad or
        NPCID.DyeTrader or
        NPCID.GoblinTinkerer or
        NPCID.Guide or
        NPCID.Mechanic or
        NPCID.Nurse or
        NPCID.Painter or
        NPCID.PartyGirl or
        NPCID.Pirate or
        NPCID.SantaClaus or
        NPCID.SkeletonMerchant or
        NPCID.Steampunker or
        NPCID.Stylist or
        NPCID.DD2Bartender or
        NPCID.TaxCollector or
        NPCID.TravellingMerchant or
        NPCID.Truffle or
        NPCID.WitchDoctor or
        NPCID.Wizard or
        NPCID.OldMan or
        NPCID.BoundGoblin or
        NPCID.BoundMechanic or
        NPCID.BoundWizard or
        NPCID.SleepingAngler => true,
        _ => false,
    };
}