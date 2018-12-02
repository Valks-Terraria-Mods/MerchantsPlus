using System.Linq;
using Terraria;

namespace MerchantsPlus
{
    class Utils
    {
        public static bool playersHaveItem(short[] items) {
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
        public static string getPlayerClass()
        {
            Player p = Main.LocalPlayer;
            
            if (p.HeldItem != null && p.HeldItem.damage > 0)
            {
                Item heldItem = p.HeldItem;
                if (heldItem.melee) return "melee";
                if (heldItem.ranged) return "ranged";
                if (heldItem.magic) return "mage";
                if (heldItem.summon) return "summoner";
                if (heldItem.thrown) return "thrower";
                return "melee";
            }
            else 
            {
                float[] damages = { p.meleeDamage, p.arrowDamage, p.bulletDamage, p.rocketDamage, p.thrownDamage, p.magicDamage, p.minionDamage };

                float maxValue = damages.Max();
                int maxIndex = damages.ToList().IndexOf(maxValue);

                switch (maxIndex)
                {
                    case 0:
                        return "melee";
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        return "ranged";
                    case 5:
                        return "mage";
                    case 6:
                        return "summoner";
                    default:
                        return "melee";
                }
            }
        }

        public static string dialog(string[] lines)
        {
            return lines[Main.rand.Next(lines.Length)];
        }

        public static int downedMechBosses()
        {
            int count = 0;
            if (NPC.downedMechBoss1) count++;
            if (NPC.downedMechBoss2) count++;
            if (NPC.downedMechBoss3) count++;
            return count;
        }

        public static int kills(short theNPC)
        {
            return NPC.killCount[Item.NPCtoBanner(theNPC)];
        }

        public static int multiKills(short[] npcs) {
            int kills = 0;
            for (int i = 0; i < npcs.Length; i++) {
                kills += NPC.killCount[Item.NPCtoBanner(npcs[i])];
            }
            return kills;
        }

        public static bool isNPCHere(short npc)
        {
            int theNPC = NPC.FindFirstNPC(npc);
            if (theNPC >= 0)
            {
                return true;
            }
            return false;
        }

        public static string getNPCName(short npc)
        {
            int theNPC = NPC.FindFirstNPC(npc);
            if (isNPCHere(npc))
            {
                return Main.npc[theNPC].GivenName;
            }
            else
            {
                return "someone";
            }
        }

        public static void dropItem(NPC npc, short npcID, short[] item, int chance)
        {
            if (Main.rand.Next(1, 100) < chance)
            {
                if (npc.type == npcID)
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        Item.NewItem(npc.position, item[i]);
                    }
                }
            }
        }

        public static string dialogGift(NPC npc, string moneyDialog, string noMoneyDialog, bool condition, int chance, short item, int price)
        {
            if (condition)
            {
                if (Main.rand.Next(0, 100) < chance)
                {
                    if (Main.LocalPlayer.BuyItem(price))
                    { // Take the gold. (1 is 1 copper) (100 is 1 silver) (1000 is 1 gold)
                        if (!Main.LocalPlayer.HasItem(item))
                        {
                            Item.NewItem(npc.position, item);
                            if (price <= 0)
                            {
                                return moneyDialog;
                            }
                            else if (price < 100)
                            {
                                return moneyDialog + " " + price + " copper was removed from your inventory";
                            }
                            else if (price >= 100 && price < 1000)
                            {
                                return moneyDialog + " " + (price / 100) + " silver was removed from your inventory";
                            }
                            else if (price >= 1000 && price < 10000)
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
}
