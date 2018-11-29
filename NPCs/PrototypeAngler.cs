using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class PrototypeAngler : ModNPC
    {
        static string[] shopNames = { "Basic" };
        static int shopCounter = 0;
        static string currentShop = shopNames[shopCounter];
        static short npcid = NPCID.Angler;

        public override string Texture
        {
            get
            {
                return "Terraria/NPC_" + npcid;
            }
        }

        public override bool Autoload(ref string name)
        {
            name = "Fisherman";
            return mod.Properties.Autoload;
        }

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[npcid];
        }

        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 40;
            npc.aiStyle = 7;
            npc.damage = 10;
            npc.defense = 15;
            npc.lifeMax = 300;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            animationType = npcid;
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            return true;
        }


        public override string TownNPCName()
        {
            return "Alex";
        }

        public override string GetChat()
        {
            return Utils.dialog(new string[]{"Hey want to do a contest? Whoever gets the most fish wins!",
            "I have more fish than you will ever have in a lifetime!",
            "Did you hear? There's a big monster in the sea and one day I'm going to release him on you. ;)",
            "The bigger the fish the better.",
            "Can't wait to see what you caught today!",
            "Oh you're back for more? Were just getting started!",
            "I wish I was the ultimate fish with the ultimate powers.",
            "Don't talk to me about anything else besides fish!",
            "Not now, I'm thinking of another quest for you! Eeek!",
            "Fish are so rare these days!",
            "Oh what did you catch today?!",
            "Is that for me?!",
            "Is that a fish you got there?",
            "Don't really like sharks but other than that I like every other fish!",
            "Sometimes the sea glares at me..",
            "Sometimes that sea scares me, I don't know why.",
            "I wonder what's at the bottom of the ocean.. FISH OF COURSE!",
            "You got a fish in your inventory, I'm a physic.",
            "No fish will ever get me alive!",
            "I am the fastest swimmer!",
            "Are you getting tired yet? Don't stop now, we have to get more fish!"});
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = currentShop;
            button2 = "Cycle Shop";
        }

        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            if (firstButton)
            {
                shop = true;

            }
            else
            {
                if (shopCounter >= shopNames.Length - 1)
                {
                    currentShop = shopNames[0];
                    shopCounter = 0;
                }
                else
                {
                    currentShop = shopNames[++shopCounter];
                }
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            switch (currentShop)
            {
                case "Crates":
                    shop.item[nextSlot].SetDefaults(ItemID.WoodenCrate);
                    shop.item[nextSlot++].shopCustomPrice = 30000;
                    if (NPC.downedSlimeKing)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.IronCrate);
                        shop.item[nextSlot++].shopCustomPrice = 100000;
                    }
                    if (NPC.downedBoss1)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.JungleFishingCrate);
                        shop.item[nextSlot++].shopCustomPrice = 250000;
                        shop.item[nextSlot].SetDefaults(ItemID.FloatingIslandFishingCrate);
                        shop.item[nextSlot++].shopCustomPrice = 250000;
                        if (NPC.downedBoss2)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.CorruptFishingCrate);
                            shop.item[nextSlot++].shopCustomPrice = 250000;
                            shop.item[nextSlot].SetDefaults(ItemID.CrimsonFishingCrate);
                            shop.item[nextSlot++].shopCustomPrice = 250000;
                        }
                        if (Main.hardMode)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.HallowedFishingCrate);
                            shop.item[nextSlot++].shopCustomPrice = 250000;
                        }
                        if (NPC.downedBoss3)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.DungeonFishingCrate);
                            shop.item[nextSlot++].shopCustomPrice = 250000;
                        }
                    }
                    if (Main.hardMode)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.GoldenCrate);
                        shop.item[nextSlot++].shopCustomPrice = 1000000;
                    }
                    break;
                case "Bait":
                    shop.item[nextSlot++].SetDefaults(ItemID.MonarchButterfly);
                    if (NPC.downedSlimeKing)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.SulphurButterfly);
                        shop.item[nextSlot++].SetDefaults(ItemID.Scorpion);
                        shop.item[nextSlot++].SetDefaults(ItemID.Snail);
                        shop.item[nextSlot++].SetDefaults(ItemID.Grasshopper);
                    }
                    if (NPC.downedBoss1)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.ApprenticeBait);
                        shop.item[nextSlot++].SetDefaults(ItemID.BlueJellyfish);
                        shop.item[nextSlot++].SetDefaults(ItemID.GreenJellyfish);
                        shop.item[nextSlot++].SetDefaults(ItemID.PinkJellyfish);
                        shop.item[nextSlot++].SetDefaults(ItemID.JuliaButterfly);
                        shop.item[nextSlot++].SetDefaults(ItemID.UlyssesButterfly);
                        shop.item[nextSlot++].SetDefaults(ItemID.ZebraSwallowtailButterfly);
                        shop.item[nextSlot++].SetDefaults(ItemID.Firefly);
                        shop.item[nextSlot++].SetDefaults(ItemID.BlackScorpion);
                        shop.item[nextSlot++].SetDefaults(ItemID.Worm);
                        shop.item[nextSlot++].SetDefaults(ItemID.GlowingSnail);
                        shop.item[nextSlot++].SetDefaults(ItemID.Sluggy);
                        shop.item[nextSlot++].SetDefaults(ItemID.Grubby);
                    }
                    if (NPC.downedBoss2)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.JourneymanBait);
                        shop.item[nextSlot++].SetDefaults(ItemID.PurpleEmperorButterfly);
                        shop.item[nextSlot++].SetDefaults(ItemID.RedAdmiralButterfly);
                        shop.item[nextSlot++].SetDefaults(ItemID.LightningBug);
                        shop.item[nextSlot++].SetDefaults(ItemID.EnchantedNightcrawler);
                        shop.item[nextSlot++].SetDefaults(ItemID.Buggy);
                    }
                    if (NPC.downedBoss3)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.MasterBait);
                        shop.item[nextSlot++].SetDefaults(ItemID.TreeNymphButterfly);
                        shop.item[nextSlot++].SetDefaults(ItemID.GoldButterfly);
                        shop.item[nextSlot++].SetDefaults(ItemID.GoldWorm);
                        shop.item[nextSlot++].SetDefaults(ItemID.GoldGrasshopper);
                    }
                    if (NPC.downedGolemBoss)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.TruffleWorm);
                    }
                    break;
                default:
                    shop.item[0].SetDefaults(ItemID.WoodFishingPole);
                    nextSlot++;
                    if (NPC.downedSlimeKing)
                    {
                        shop.item[0].SetDefaults(ItemID.ReinforcedFishingPole);
                    }
                    if (NPC.downedBoss1)
                    {
                        shop.item[0].SetDefaults(ItemID.FisherofSouls);
                    }
                    if (NPC.downedBoss2)
                    {
                        shop.item[0].SetDefaults(ItemID.FiberglassFishingPole);
                    }
                    if (NPC.downedBoss3)
                    {
                        shop.item[0].SetDefaults(ItemID.MechanicsRod);
                    }
                    if (Main.hardMode)
                    {
                        shop.item[0].SetDefaults(ItemID.SittingDucksFishingRod);
                    }
                    if (Utils.downedMechBosses() == 1)
                    {
                        shop.item[0].SetDefaults(ItemID.HotlineFishingHook);
                    }
                    if (Utils.downedMechBosses() == 2)
                    {
                        shop.item[0].SetDefaults(ItemID.GoldenFishingRod);
                    }

                    shop.item[nextSlot++].SetDefaults(ItemID.HighTestFishingLine);
                    shop.item[nextSlot++].SetDefaults(ItemID.AnglerEarring);
                    shop.item[nextSlot++].SetDefaults(ItemID.TackleBox);
                    shop.item[nextSlot++].SetDefaults(ItemID.FishingPotion);
                    shop.item[nextSlot++].SetDefaults(ItemID.CratePotion);
                    shop.item[nextSlot++].SetDefaults(ItemID.SonarPotion);
                    shop.item[nextSlot++].SetDefaults(ItemID.AnglerHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.AnglerVest);
                    shop.item[nextSlot++].SetDefaults(ItemID.AnglerPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.FishermansGuide);
                    shop.item[nextSlot++].SetDefaults(ItemID.WeatherRadio);
                    shop.item[nextSlot++].SetDefaults(ItemID.Sextant);
                    shop.item[nextSlot++].SetDefaults(ItemID.FishFinder);
                    shop.item[nextSlot++].SetDefaults(ItemID.CookedFish);
                    shop.item[nextSlot++].SetDefaults(ItemID.CookedShrimp);
                    shop.item[nextSlot++].SetDefaults(ItemID.Sashimi);
                    break;
            }
        }

        public override void NPCLoot()
        {
            Utils.dropItem(npc, NPCID.Angler, new short[] { ItemID.IronBow }, 25);
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            attackDelay = 1;
            projType = ProjectileID.FrostDaggerfish;
            if (NPC.downedSlimeKing)
            {
                projType = ProjectileID.IceSickle;
            }
            if (NPC.downedBoss1)
            {
                projType = ProjectileID.Blizzard;
            }
            if (NPC.downedBoss2)
            {
                projType = ProjectileID.InfluxWaver;
            }
        }

        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 20;
            knockback = 4f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 0;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 12f;
            randomOffset = 2f;
        }
    }
}
