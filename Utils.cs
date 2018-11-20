using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus
{
    class Utils
    {
        public static int kills(short theNPC) {
            return NPC.killCount[Item.NPCtoBanner(theNPC)];
        }

        public static string dialogGift(NPC npc, string moneyDialog, string noMoneyDialog, bool condition, int chance, short item, int price) {
            if (condition) {
                if (Main.rand.Next(0, 100) < chance)
                {
                    if (Main.LocalPlayer.BuyItem(price))
                    { // Take the gold. (1 is 1 copper) (100 is 1 silver) (1000 is 1 gold)
                        if (!Main.LocalPlayer.HasItem(item))
                        {
                            Item.NewItem(npc.position, item);
                            if (price < 100)
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
