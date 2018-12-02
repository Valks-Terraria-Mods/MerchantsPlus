using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class GoblinTinkerer : ModNPC
    {
        static string[] shopNames = { "Reforge", "Workshop", "Movement", "Informational", "Combat", "Health and Mana", "Immunity", "Defensive", "Special", "Miscellaneous", "Calamity Special" };
        static int shopCounter = 0;
        static string currentShop = shopNames[shopCounter];
        static short npcid = NPCID.GoblinTinkerer;

        public override string Texture
        {
            get
            {
                return "Terraria/NPC_" + npcid;
            }
        }

        public override bool Autoload(ref string name)
        {
            name = "Reforger";
            return mod.Properties.Autoload;
        }

        public override void SetStaticDefaults()
        {
            //Main.npcFrameCount[npc.type] = Main.npcFrameCount[npcid];
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[npcid];
            NPCID.Sets.ExtraFramesCount[npc.type] = NPCID.Sets.ExtraFramesCount[npcid];
            NPCID.Sets.AttackFrameCount[npc.type] = NPCID.Sets.AttackFrameCount[npcid];
            NPCID.Sets.DangerDetectRange[npc.type] = NPCID.Sets.DangerDetectRange[npcid];
            NPCID.Sets.AttackType[npc.type] = NPCID.Sets.AttackType[npcid];
            NPCID.Sets.AttackTime[npc.type] = NPCID.Sets.AttackTime[npcid];
            NPCID.Sets.AttackAverageChance[npc.type] = NPCID.Sets.AttackAverageChance[npcid];
            NPCID.Sets.HatOffsetY[npc.type] = NPCID.Sets.HatOffsetY[npcid];
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
            return "Jeevan";
        }

        public override string GetChat()
        {
            return Utils.dialog(new string[] { "Were going to mod your gear right up baby. :)" ,
                "I got all the modifications you will ever need. >:)",
                "Did someone call for a modder? >:D"});
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
                if (currentShop == "Reforge")
                {
                    Main.playerInventory = true;
                    Main.npcChatText = "";
                    MerchantsPlus.instance.examplePersonUserInterface.SetState(new UI.GoblinTinkererUI());
                }
                else {
                    shop = true;
                }
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
            switch (currentShop) {
                case "Calamity Special":
                    if (MerchantsPlus.calamityLoaded)
                    {
                        Mod calamity = ModLoader.GetMod("CalamityMod");
                        //if (CalamityMod.CalamityWorld.downedCrabulon) {
                        //    shop.item[nextSlot++].SetDefaults(calamity.ItemType<CalamityMod.Items.Crabulon.FungalClump>());
                        //}
                        //if (CalamityMod.CalamityWorld.downedDesertScourge) {
                        //    shop.item[nextSlot++].SetDefaults(calamity.ItemType("OceanCrest"));
                        //}
                        shop.item[nextSlot++].SetDefaults(calamity.ItemType("BloodyWormTooth"));
                        shop.item[nextSlot++].SetDefaults(calamity.ItemType("RottenBrain"));
                        shop.item[nextSlot++].SetDefaults(calamity.ItemType("ManaOverloader"));
                        shop.item[nextSlot++].SetDefaults(calamity.ItemType("SoulofCryogen"));
                        shop.item[nextSlot++].SetDefaults(calamity.ItemType("Gehenna"));
                        shop.item[nextSlot++].SetDefaults(calamity.ItemType("AquaticEmblem"));
                        shop.item[nextSlot++].SetDefaults(calamity.ItemType("VoidofExtinction")); // VoidOfCalamity
                        shop.item[nextSlot++].SetDefaults(calamity.ItemType("LeviathanAmbergris"));
                        shop.item[nextSlot++].SetDefaults(calamity.ItemType("ToxicHeart"));
                        shop.item[nextSlot++].SetDefaults(calamity.ItemType("BloodflareCore"));
                        shop.item[nextSlot++].SetDefaults(calamity.ItemType("Affliction"));
                        shop.item[nextSlot++].SetDefaults(calamity.ItemType("NebulousCore"));
                        shop.item[nextSlot++].SetDefaults(calamity.ItemType("YharimsGift"));
                        shop.item[nextSlot++].SetDefaults(calamity.ItemType("TheCommunity"));
                        shop.item[nextSlot++].SetDefaults(calamity.ItemType("CounterScarf"));
                        shop.item[nextSlot++].SetDefaults(calamity.ItemType("CrownJewel"));
                        shop.item[nextSlot++].SetDefaults(calamity.ItemType("FrostFlare"));
                        shop.item[nextSlot++].SetDefaults(calamity.ItemType("HeartofDarkness"));
                        shop.item[nextSlot++].SetDefaults(calamity.ItemType("Laudanum"));
                        shop.item[nextSlot++].SetDefaults(calamity.ItemType("SirensHeart"));
                        shop.item[nextSlot++].SetDefaults(calamity.ItemType("StressPills"));
                    }
                    break;
                case "Miscellaneous":
                    if (NPC.downedPirates) {
                        shop.item[nextSlot].SetDefaults(ItemID.GoldRing);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.DiscountCard);
                        shop.item[nextSlot].SetDefaults(ItemID.LuckyCoin);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.FlowerBoots);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    if (Utils.multiKills(new short[] { NPCID.BlueJellyfish, NPCID.PinkJellyfish, NPCID.GreenJellyfish }) > 100){
                        shop.item[nextSlot].SetDefaults(ItemID.JellyfishNecklace);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (NPC.downedMechBoss1) {
                        shop.item[nextSlot].SetDefaults(ItemID.NeptunesShell);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    break;
                case "Special":
                    if (NPC.downedSlimeKing) shop.item[nextSlot++].SetDefaults(ItemID.RoyalGel);
                    if (NPC.downedBoss1) shop.item[nextSlot++].SetDefaults(ItemID.EoCShield);
                    if (NPC.downedBoss2) {
                        if (WorldGen.crimson)
                        {
                            shop.item[nextSlot++].SetDefaults(ItemID.BrainOfConfusion);
                        }
                        else {
                            shop.item[nextSlot++].SetDefaults(ItemID.WormScarf);
                        }
                    }
                    if (NPC.downedQueenBee) {
                        shop.item[nextSlot++].SetDefaults(ItemID.HiveBackpack);
                    }
                    if (NPC.downedPlantBoss) {
                        shop.item[nextSlot++].SetDefaults(ItemID.SporeSac);
                    }
                    if (NPC.downedGolemBoss) {
                        shop.item[nextSlot++].SetDefaults(ItemID.ShinyStone);
                    }
                    if (NPC.downedMoonlord) {
                        shop.item[nextSlot++].SetDefaults(ItemID.GravityGlobe);
                    }
                    break;
                case "Defensive":
                    if (NPC.downedBoss3) {
                        shop.item[nextSlot].SetDefaults(ItemID.CobaltShield);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (Utils.kills(NPCID.Zombie) > 100) {
                        shop.item[nextSlot].SetDefaults(ItemID.Shackle);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (Utils.kills(NPCID.BigMimicCrimson) > 0) {
                        shop.item[nextSlot].SetDefaults(ItemID.FleshKnuckles);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (Utils.kills(NPCID.IceTortoise) > 0) {
                        shop.item[nextSlot].SetDefaults(ItemID.FrozenTurtleShell);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    break;
                case "Immunity":
                    if (Main.hardMode) {
                        if (Utils.multiKills(new short[] { NPCID.RustyArmoredBonesAxe, NPCID.Werewolf, NPCID.AnglerFish }) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.AdhesiveBandage);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }
                        if (Utils.multiKills(new short[] { NPCID.ArmoredSkeleton, NPCID.BlueArmoredBones }) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.ArmorPolish);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }
                        if (Utils.kills(NPCID.ToxicSludge) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.Bezoar);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }
                        if (Utils.kills(NPCID.CorruptSlime) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.Blindfold);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }

                        if (Utils.multiKills(new short[] { NPCID.Pixie, NPCID.DarkMummy }) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.Megaphone);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }
                        if (Utils.kills(NPCID.Mimic) > 2)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.CrossNecklace);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }
                        if (Utils.kills(NPCID.Pixie) > 10)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.FastClock);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }
                        shop.item[nextSlot].SetDefaults(ItemID.HandWarmer);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        if (Main.hardMode)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.ObsidianRose);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }

                        if (Utils.kills(NPCID.Medusa) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.PocketMirror);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }


                        if (Utils.kills(NPCID.LightMummy) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.TrifoldMap);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }

                        if (Utils.kills(NPCID.Corruptor) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.Vitamins);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }
                        if (Utils.kills(NPCID.CursedSkull) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.Nazar);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }
                    }
                    break;
                case "Combat":
                    if (NPC.downedBoss2) {
                        shop.item[nextSlot].SetDefaults(ItemID.PanicNecklace);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (NPC.downedPlantBoss) {
                        shop.item[nextSlot].SetDefaults(ItemID.BlackBelt);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (NPC.downedQueenBee) {
                        shop.item[nextSlot].SetDefaults(ItemID.HoneyComb);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }

                    if (NPC.downedMechBoss1) {
                        shop.item[nextSlot].SetDefaults(ItemID.MoonCharm);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;

                        shop.item[nextSlot].SetDefaults(ItemID.FeralClaws);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.MagmaStone);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.EyeoftheGolem);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.MoonStone);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.MagicQuiver);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }

                    if (NPC.downedMechBoss2) {
                        shop.item[nextSlot].SetDefaults(ItemID.PaladinsShield);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.PutridScent);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.SharkToothNecklace);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.StarCloak);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.SunStone);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.TitanGlove);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }


                    if (NPC.downedMechBoss3) {
                        shop.item[nextSlot].SetDefaults(ItemID.ApprenticeScarf);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.SquireShield);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.HuntressBuckler);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.MonkBelt);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.HerculesBeetle);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.NecromanticScroll);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.PygmyNecklace);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    
                    break;
                case "Health and Mana":
                    if (NPC.downedBoss2) {
                        shop.item[nextSlot].SetDefaults(ItemID.BandofStarpower);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.BandofRegeneration);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.CelestialMagnet);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.NaturesGift);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        
                    }
                    if (Main.hardMode) {
                        shop.item[nextSlot].SetDefaults(ItemID.PhilosophersStone);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    break;
                case "Informational":
                    if (WorldGen.goldBar > 0) shop.item[nextSlot].SetDefaults(ItemID.GoldWatch); else shop.item[nextSlot].SetDefaults(ItemID.PlatinumWatch);
                    shop.item[nextSlot].SetDefaults(ItemID.DepthMeter);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.Compass);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.Ruler);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.MetalDetector);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.Stopwatch);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.DPSMeter);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.TallyCounter);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.LifeformAnalyzer);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.Radar);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.MechanicalLens);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.LaserRuler);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    break;
                case "Movement":
                    if (NPC.downedBoss1) {
                        shop.item[nextSlot].SetDefaults(ItemID.HermesBoots);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.WaterWalkingBoots);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.IceSkates);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (NPC.downedBoss2) {
                        shop.item[nextSlot].SetDefaults(ItemID.RocketBoots);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.CloudinaBottle);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.SandstorminaBottle);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.TsunamiInABottle);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (NPC.downedBoss3) {
                        shop.item[nextSlot].SetDefaults(ItemID.Aglet);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.ClimbingClaws);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.AnkletoftheWind);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.Flipper);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.ShoeSpikes);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.FlyingCarpet);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.DivingHelmet);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.ShinyRedBalloon);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.LuckyHorseshoe);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.LavaCharm);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (NPC.downedPlantBoss) {
                        shop.item[nextSlot].SetDefaults(ItemID.Tabi);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    } 
                    break;
                case "Workshop":
                    shop.item[nextSlot++].SetDefaults(ItemID.TinkerersWorkshop);
                    break;
                default:
                    break;
            }
            
        }

        public override void NPCLoot()
        {
            // Item.NewItem(npc.getRect(), ItemID.SlimeBanner);
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = ProjectileID.ThrowingKnife;
            if (NPC.downedBoss2)
            {
                projType = ProjectileID.PoisonedKnife;
            }
            if (Utils.downedMechBosses() == 1)
            {
                projType = ProjectileID.BoneJavelin;
            }
            attackDelay = 1;
        }

        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 20;
            knockback = 4f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 30;
            randExtraCooldown = 30;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 12f;
            randomOffset = 2f;
        }
    }
}
