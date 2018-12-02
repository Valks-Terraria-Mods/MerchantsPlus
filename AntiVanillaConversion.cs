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
            static string[] npcs = { "Squire", 
            "Supplier", 
            "Fisherman", 
            "Hair Specialist", 
            "Decorator", 
            "Artist", 
            "Bartender", 
            "Guns Dealer", 
            "Outfitter", 
            "Manufacturer", 
            "Explosives Expert",
            "Magician", 
            "Reforger", 
            "Doctor",
            "Healer", 
            "Outcast", 
            "Apprentice", 
            "Business Man", 
            "Mushroom", 
            "Bandit", 
            "Steampunk",
            "Robot", 
            "Santa", 
            "World Merchant", 
            "Skeleton Dealer"};
            public override void PostUpdate()
            {
                if (Main.worldRate > 0) {
                    for (int i = 0; i < 580; i++)
                    {
                        Main.townNPCCanSpawn[i] = false;
                    }
                }
            }
            public override void PreUpdate()
            {
                if (Main.worldRate > 0)
                {
                    for (int i = 0; i < 580; i++)
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
                                case "Supplier":
                                case "Fisherman":
                                case "Hair Specialist":
                                case "Artist":
                                case "Bartender":
                                case "Decorator":
                                    if (spawnCustomMerchant(npcs[i])) {
                                        return;
                                    }
                                    break;
                                case "Guns Dealer":
                                    if (ConditionArmsDealer()) {
                                        if (spawnCustomMerchant(npcs[i])) {
                                            return;
                                        }
                                    }
                                    break;
                                case "Manufacturer":
                                    if (ConditionMechanic()) {
                                        if (spawnCustomMerchant(npcs[i])) {
                                            return;
                                        }
                                    }
                                    break;
                                case "Explosives Expert":
                                    if (ConditionDemolitionist()) {
                                        if (spawnCustomMerchant(npcs[i])) {
                                            return;
                                        }
                                    }
                                    break;
                                case "Magician":
                                    if (ConditionDyeTrader()) {
                                        if (spawnCustomMerchant(npcs[i])) {
                                            return;
                                        }
                                    }
                                    break;
                                case "Outfitter":
                                    if (ConditionClothier()) {
                                        if (spawnCustomMerchant(npcs[i])) {
                                            return;
                                        }
                                    }
                                    break;
                                case "Reforger":
                                    if (ConditionGoblinTinkerer()) {
                                        if (spawnCustomMerchant(npcs[i])) {
                                            return;
                                        }
                                    }
                                    break;
                                case "Doctor":
                                    if (ConditionWitchDoctor()) {
                                        if (spawnCustomMerchant(npcs[i])) {
                                            return;
                                        }
                                    }
                                    break;
                                case "Healer":
                                    if (ConditionNurse()) {
                                        if (spawnCustomMerchant(npcs[i])) {
                                            return;
                                        }
                                    }
                                    break;
                                case "Outcast":
                                    if (ConditionDryad()) {
                                        if (spawnCustomMerchant(npcs[i])) {
                                            return;
                                        }
                                    }
                                    break;
                                case "Apprentice":
                                case "Business Man":
                                case "Mushroom":
                                    if (Main.hardMode) {
                                        if (spawnCustomMerchant(npcs[i])) {
                                            return;
                                        }
                                    }
                                    break;
                                case "Bandit":
                                    if (ConditionPirate()) {
                                        if (spawnCustomMerchant(npcs[i])) {
                                            return;
                                        }
                                    }
                                    break;
                                case "Steampunk":
                                    if (ConditionSteampunker()) {
                                        if (spawnCustomMerchant(npcs[i])) {
                                            return;
                                        }
                                    }
                                    break;
                                case "Robot":
                                    if (ConditionCyborg()) {
                                        if (spawnCustomMerchant(npcs[i])) {
                                            return;
                                        }
                                    }
                                    break;
                                case "Santa":
                                    if (ConditionSantaClaus()) {
                                        if (spawnCustomMerchant(npcs[i])) {
                                            return;
                                        }
                                    }
                                    break;
                                case "World Merchant":
                                    if (Main.hardMode) {
                                        if (spawnCustomMerchant(npcs[i])) {
                                            return;
                                        }
                                    }
                                    break;
                                case "Skeleton Dealer":
                                    if (Main.hardMode) {
                                        if (spawnCustomMerchant(npcs[i])) {
                                            return;
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                }
            }

            private bool spawnCustomMerchant(string npc) {
                if (Main.netMode == NetmodeID.SinglePlayer)
                {
                    if (!IsNPCInWorld(mod.NPCType(npc)))
                    {
                        Main.NewText("The " + npc + " has arrived!", Color.Orange);
                        NPC.NewNPC((int)Main.LocalPlayer.position.X, (int)Main.LocalPlayer.position.Y, mod.NPCType(npc));
                        return true;
                    }
                }
                else
                {
                    if (!IsNPCInWorld(mod.NPCType(npc)))
                    {
                        string name = "Guide";
                        switch (npc)
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
                        NPC.NewNPC((int)Main.player[0].position.X, (int)Main.player[0].position.Y, mod.NPCType(npc));
                        return true;
                    }
                }
                return false;
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
                return Utils.playersHaveItem(new short[] { ItemID.Musket, ItemID.MusketBall, ItemID.TheUndertaker, ItemID.Revolver, ItemID.RedRyder, ItemID.Boomstick, ItemID.SilverBullet});
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
