using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;

namespace MerchantsPlus
{
    internal class Utils
    {
        public static int UniversalPotionCost = Coins(0, 0, 5);
        public static int UniversalAccessoryCost = Coins(0, 0, 20);
        public static int UniversalOreCost = Coins(0, 0, 1);
        public static int UniversalPetCost = Coins(0, 0, 5);
        public static int UniversalVanityCost = Coins(0, 0, 5);
        public static int UniversalSeedCost = Coins(0, 0, 1);
        public static int UniversalDyeCost = Coins(0, 0, 1);

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

        public static bool HasNPC(int npcID)
        {
            return NPC.AnyNPCs(npcID);
        }

        public static bool IsHardMode()
        {
            return Main.hardMode;
        }

        public static bool DownedWallOfFlesh()
        {
            return Main.hardMode;
        }

        public static bool DownedEyeOfCthulhu()
        {
            return NPC.downedBoss1;
        }

        public static bool DownedEaterOfWorlds()
        {
            return NPC.downedBoss2;
        }

        public static bool DownedBrainOfCthulhu()
        {
            return NPC.downedBoss2;
        }

        public static bool DownedSkeletron()
        {
            return NPC.downedBoss3;
        }

        public static int Coins(int copper = 0, int silver = 0, int gold = 0, int platinum = 0)
        {
            double total = 0;
            total += copper;
            total += silver * 100;
            total += gold * 10000;
            total += platinum * 1000000;
            total *= Config.ShopPriceMultiplier;
            return (int)total;
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

        public static string Dialog(string[] lines)
        {
            return lines[Main.rand.Next(lines.Length)];
        }

        public static int DownedMechBosses()
        {
            int count = 0;
            if (NPC.downedMechBoss1) count++;
            if (NPC.downedMechBoss2) count++;
            if (NPC.downedMechBoss3) count++;
            return count;
        }

        public static int Kills(short theNPC)
        {
            return NPC.killCount[Item.NPCtoBanner(theNPC)];
        }

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

        public static void DropItem(NPC npc, short npcID, short[] item, int chance)
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

        public static bool IsMerchant(int npcID)
        {
            switch (npcID)
            {
                case NPCID.Angler:
                case NPCID.ArmsDealer:
                case NPCID.Clothier:
                case NPCID.Cyborg:
                case NPCID.Demolitionist:
                case NPCID.Dryad:
                case NPCID.DyeTrader:
                case NPCID.GoblinTinkerer:
                case NPCID.Guide:
                case NPCID.Mechanic:
                case NPCID.Nurse:
                case NPCID.Painter:
                case NPCID.PartyGirl:
                case NPCID.Pirate:
                case NPCID.SantaClaus:
                case NPCID.SkeletonMerchant:
                case NPCID.Steampunker:
                case NPCID.Stylist:
                case NPCID.DD2Bartender:
                case NPCID.TaxCollector:
                case NPCID.TravellingMerchant:
                case NPCID.Truffle:
                case NPCID.WitchDoctor:
                case NPCID.Wizard:
                case NPCID.OldMan:
                case NPCID.BoundGoblin:
                case NPCID.BoundMechanic:
                case NPCID.BoundWizard:
                case NPCID.SleepingAngler:
                    return true;

                default:
                    return false;
            }
        }
    }
}