using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MerchantsPlus
{
    class AntiVanillaConversion : ModWorld
    {
        class BlockVanilla : ModWorld
        {
            static string[] npcs = { "Squire", "Supplier", "Outfitter", "Manufacturer", "Explosives Expert",
        "Magician", "Bartender", "Hair Specialist", "Artist", "Fisherman", "Reforger", "Doctor", "Decorator",
        "Healer", "Guns Dealer", "Outcast", "Apprentice", "Business Man", "Mushroom", "Bandit", "Steampunk",
        "Robot", "Santa", "World Merchant", "Skeleton Dealer"};
            static bool[] conditions = new bool[npcs.Length];
            public override void PostUpdate()
            {
                conditions[0] = true;
                if (Main.worldRate > 0)
                {
                    for (int i = 0; i < Main.townNPCCanSpawn.Length; i++)
                    {
                        Main.townNPCCanSpawn[i] = false;
                    }
                    //WorldGen.prioritizedTownNPC = -1;
                    //Main.NewText(Main.time);
                    //Main.NewText(Main.dayTime);

                    if (Main.dayTime && Main.time % 1000 == 0)
                    {
                        for (int i = 0; i < npcs.Length; i++)
                        {
                            switch (npcs[i])
                            {
                                case "Squire":
                                    break;
                                case "Explosives Expert":
                                    if (!ConditionDemolitionist()) return;
                                    break;
                                case "Magician":
                                    if (!ConditionDyeTrader()) return;
                                    break;
                                case "Bartender":
                                    break;
                                case "Hair Specialist":
                                    break;
                                case "Artist":
                                    break;
                                case "Fisherman":
                                    break;
                                case "Reforger":
                                    if (!ConditionGoblinTinkerer()) return;
                                    break;
                                case "Doctor":
                                    if (!ConditionWitchDoctor()) return;
                                    break;
                                case "Decorator":
                                    break;
                                case "Supplier":
                                    if (!ConditionMerchant()) return;
                                    break;
                                case "Healer":
                                    if (!ConditionNurse()) return;
                                    break;
                                case "Guns Dealer":
                                    if (!ConditionArmsDealer()) return;
                                    break;
                                case "Outcast":
                                    if (!ConditionDryad()) return;
                                    break;
                                case "Apprentice":
                                    if (!Main.hardMode) return;
                                    break;
                                case "Business Man":
                                    if (!Main.hardMode) return;
                                    break;
                                case "Mushroom":
                                    if (!Main.hardMode) return;
                                    break;
                                case "Bandit":
                                    if (!ConditionPirate()) return;
                                    break;
                                case "Steampunk":
                                    if (!ConditionSteampunker()) return;
                                    break;
                                case "Robot":
                                    if (!ConditionCyborg()) return;
                                    break;
                                case "Santa":
                                    if (!ConditionSantaClaus()) return;
                                    break;
                                case "World Merchant":
                                    if (!Main.hardMode) return;
                                    break;
                                case "Sekelton Dealer":
                                    if (!Main.hardMode) return;
                                    break;
                            }
                            if (Main.netMode == NetmodeID.SinglePlayer)
                            {
                                if (!IsNPCInWorld(mod.NPCType(npcs[i])))
                                {
                                    Main.NewText("The " + npcs[i] + " has arrived!", Color.Orange);
                                    NPC.NewNPC((int)Main.LocalPlayer.position.X, (int)Main.LocalPlayer.position.Y, mod.NPCType(npcs[i]));
                                    return;
                                }
                            }
                            else
                            {
                                if (!IsNPCInWorld(mod.NPCType(npcs[i])))
                                {
                                    string name = "Guide";
                                    switch (npcs[i])
                                    {
                                        case "Squire":
                                            name = "Guide";
                                            break;
                                        case "Explosives Expert":
                                            name = "Demolitionist";
                                            break;
                                        case "Magician":
                                            name = "DyeTrader";
                                            break;
                                        case "Bartender":
                                            name = "Tavernkeep";
                                            break;
                                        case "Hair Specialist":
                                            name = "HairStylist";
                                            break;
                                        case "Artist":
                                            name = "Painter";
                                            break;
                                        case "Fisherman":
                                            name = "Angler";
                                            break;
                                        case "Reforger":
                                            name = "GoblinTinkerer";
                                            break;
                                        case "Doctor":
                                            name = "WitchDoctor";
                                            break;
                                        case "Decorator":
                                            name = "PartyGirl";
                                            break;
                                        case "Supplier":
                                            name = "Merchant";
                                            break;
                                        case "Healer":
                                            name = "Nurse";
                                            break;
                                        case "Guns Dealer":
                                            name = "ArmsDealer";
                                            break;
                                        case "Outcast":
                                            name = "Dryad";
                                            break;
                                        case "Apprentice":
                                            name = "Wizard";
                                            break;
                                        case "Business Man":
                                            name = "TaxCollector";
                                            break;
                                        case "Mushroom":
                                            name = "Truffle";
                                            break;
                                        case "Bandit":
                                            name = "Pirate";
                                            break;
                                        case "Steampunk":
                                            name = "Steampunker";
                                            break;
                                        case "Robot":
                                            name = "Cryborg";
                                            break;
                                        case "Santa":
                                            name = "SantaClaus";
                                            break;
                                        case "World Merchant":
                                            name = "TravellingMerchant";
                                            break;
                                        case "Sekelton Dealer":
                                            name = "SkeletonMerchant";
                                            break;
                                    }
                                    string key = "Mods.MerchantsPlus." + name;
                                    NetMessage.BroadcastChatMessage(NetworkText.FromKey(key), Color.Orange);
                                    NPC.NewNPC((int)Main.player[0].position.X, (int)Main.player[0].position.Y, mod.NPCType(npcs[i]));
                                    return;
                                }
                            }
                        }
                    }
                }
            }

            private bool ConditionSantaClaus()
            {
                return NPC.downedFrost && Main.hardMode;
            }

            private bool ConditionCyborg()
            {
                return NPC.downedPlantBoss && Main.hardMode;
            }

            private bool ConditionSteampunker()
            {
                return NPC.downedMechBossAny && Main.hardMode;
            }

            private bool ConditionPirate()
            {
                return NPC.downedPirates && Main.hardMode;
            }

            private bool ConditionGuide()
            {
                return true;
            }

            private bool ConditionMechanic()
            {
                return NPC.downedBoss3;
            }

            private bool ConditionClothier()
            {
                return NPC.downedBoss3;
            }

            private bool ConditionWitchDoctor()
            {
                return NPC.downedQueenBee;
            }

            private bool ConditionGoblinTinkerer()
            {
                return NPC.downedGoblins;
            }

            private bool ConditionTavernkeep()
            {
                return NPC.downedBoss2;
            }

            private bool ConditionDryad()
            {
                return NPC.downedBoss1 || NPC.downedBoss2 || NPC.downedBoss3 || NPC.downedQueenBee;
            }

            private bool ConditionDyeTrader()
            {
                return Utils.playersHaveItem(new short[] { ItemID.StrangePlant1, ItemID.StrangePlant2, ItemID.StrangePlant3, ItemID.StrangePlant4 });
            }

            private bool ConditionDemolitionist()
            {
                return Utils.playersHaveItem(new short[] { ItemID.Grenade, ItemID.BouncyGrenade, ItemID.StickyGrenade, ItemID.Bomb, ItemID.StickyBomb, ItemID.BouncyBomb, ItemID.Dynamite, ItemID.StickyDynamite, ItemID.BouncyDynamite });
            }

            private bool ConditionArmsDealer()
            {
                for (int k = 0; k < 255; k++)
                {
                    Player player = Main.player[k];
                    if (player.active)
                    {
                        for (int j = 0; j < player.inventory.Length; j++)
                        {
                            if (player.inventory[j].ranged)
                            {
                                return true;
                            }
                        }
                    }
                }
                return false;
            }

            private bool ConditionMerchant()
            {
                if (Main.netMode != NetmodeID.SinglePlayer)
                {
                    //TODO: Check if players have total of 50 silver coins combined.
                }
                return true;
            }

            private bool ConditionNurse()
            {
                if (Main.netMode != NetmodeID.SinglePlayer)
                {
                    for (int k = 0; k < 255; k++)
                    {
                        Player player = Main.player[k];
                        if (player.active)
                        {
                            if (player.statLifeMax > 100)
                            {
                                return true;
                            }
                        }
                    }
                }
                else
                {
                    return Main.LocalPlayer.statLifeMax > 100;
                }

                return false;
            }

            private bool IsNPCInWorld(int NPCType)
            {
                for (int i = 0; i < Main.npc.Length; i++)
                {
                    if (Main.npc[i].type == NPCType)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
