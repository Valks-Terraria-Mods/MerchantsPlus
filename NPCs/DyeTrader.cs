using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class DyeTrader : ModNPC
    {
        static string[] shopNames = { "Strange Plants", "Color" };
        static int shopCounter = 0;
        static string currentShop = shopNames[shopCounter];
        static short npcid = NPCID.DyeTrader;

        public override string Texture
        {
            get
            {
                return "Terraria/NPC_" + npcid;
            }
        }

        public override bool Autoload(ref string name)
        {
            name = "Magician";
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
            return "Jarold";
        }

        public override string GetChat()
        {
            return Utils.dialog(new string[] { "Modder still working on my dialog." });
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
                if (currentShop == "Strange Plants")
                {
                    int[] plants = { ItemID.StrangePlant1, ItemID.StrangePlant2, ItemID.StrangePlant3, ItemID.StrangePlant4 };
                    Item[] inventory = Main.LocalPlayer.inventory;
                    for (int p = 0; p < plants.Length; p++) {
                        for (int i = 0; i < inventory.Length; i++)
                        {
                            if (inventory[i].type == plants[p]) {
                                inventory[i].stack--;
                                if (!Main.hardMode)
                                {
                                    int[] dyes = { ItemID.AcidDye, ItemID.RedAcidDye, ItemID.BlueAcidDye, ItemID.GlowingMushroom, ItemID.PurpleOozeDye, ItemID.ReflectiveDye, ItemID.ReflectiveSilverDye, ItemID.ReflectiveGoldDye, ItemID.ReflectiveObsidianDye, ItemID.ReflectiveCopperDye, ItemID.ReflectiveMetalDye, ItemID.NegativeDye, ItemID.ShadowDye, ItemID.MirageDye };
                                    Main.LocalPlayer.QuickSpawnItem(dyes[new Random().Next(0, dyes.Length)], 3);
                                }
                                else {
                                    int[] dyes = {ItemID.TwilightDye, ItemID.HadesDye, ItemID.BurningHadesDye, ItemID.ShadowflameHadesDye, ItemID.GrimDye, ItemID.PhaseDye, ItemID.ShiftingSandsDye, ItemID.GelDye, ItemID.ChlorophyteDye, ItemID.LivingFlameDye, ItemID.LivingRainbowDye, ItemID.LivingOceanDye, ItemID.WispDye, ItemID.PixieDye, ItemID.UnicornWispDye, ItemID.InfernalWispDye, ItemID.MartianArmorDye, ItemID.MidnightRainbowDye, ItemID.DevDye};
                                    Main.LocalPlayer.QuickSpawnItem(dyes[new Random().Next(0, dyes.Length)], 3);
                                }
                                
                                return;
                            }
                        }
                    }
                        
                    
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
            shop.item[nextSlot++].SetDefaults(ItemID.DyeVat);
            shop.item[nextSlot++].SetDefaults(ItemID.SilverDye);
            shop.item[nextSlot++].SetDefaults(ItemID.TeamDye);
            shop.item[nextSlot++].SetDefaults(ItemID.BrownDye);
            if (NPC.downedSlimeKing)
            {
                if (Utils.kills(NPCID.BlueSlime) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightBlueDye);
                if (Utils.kills(NPCID.BlueSlime) > 10) shop.item[nextSlot++].SetDefaults(ItemID.BlueDye);
                if (Utils.kills(NPCID.Harpy) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightSkyBlueDye);
                if (Utils.kills(NPCID.Harpy) > 10) shop.item[nextSlot++].SetDefaults(ItemID.SkyBlueDye);
            }

            if (NPC.downedBoss1)
            { //eye
                if (Utils.kills(NPCID.RedSlime) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightRedDye);
                if (Utils.kills(NPCID.RedSlime) > 10) shop.item[nextSlot++].SetDefaults(ItemID.RedDye);
                if (Utils.kills(NPCID.PinkJellyfish) > 10) shop.item[nextSlot++].SetDefaults(ItemID.BrightPinkDye);
                if (Utils.kills(NPCID.Pinky) > 1) shop.item[nextSlot++].SetDefaults(ItemID.PinkDye);
                if (Utils.kills(NPCID.PurpleSlime) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightPurpleDye);
                if (Utils.kills(NPCID.PurpleSlime) > 10) shop.item[nextSlot++].SetDefaults(ItemID.PurpleDye);
                if (Utils.kills(NPCID.DemonEye) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightVioletDye);
                if (Utils.kills(NPCID.DemonEye) > 10) shop.item[nextSlot++].SetDefaults(ItemID.VioletDye);
                if (Utils.kills(NPCID.Zombie) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BlackDye);
            }

            if (NPC.downedBoss2)
            { // brain / worm 
                if (Utils.kills(NPCID.EaterofSouls) > 20 || (Utils.kills(NPCID.BloodCrawler) > 20)) shop.item[nextSlot++].SetDefaults(ItemID.BrightGreenDye);
                if (Utils.kills(NPCID.EaterofSouls) > 10 || (Utils.kills(NPCID.BloodCrawler) > 10)) shop.item[nextSlot++].SetDefaults(ItemID.GreenDye);
                if (Utils.kills(NPCID.DevourerBody) > 20 || (Utils.kills(NPCID.FaceMonster) > 20)) shop.item[nextSlot++].SetDefaults(ItemID.BrightLimeDye);
                if (Utils.kills(NPCID.DevourerBody) > 10 || (Utils.kills(NPCID.FaceMonster) > 10)) shop.item[nextSlot++].SetDefaults(ItemID.LimeDye);
            }

            if (NPC.downedQueenBee)
            {
                if (Utils.kills(NPCID.AngryTrapper) > 10) shop.item[nextSlot++].SetDefaults(ItemID.BrightCyanDye);
                if (Utils.kills(NPCID.AngryTrapper) > 5) shop.item[nextSlot++].SetDefaults(ItemID.CyanDye);
                if (Utils.kills(NPCID.JungleSlime) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightTealDye);
                if (Utils.kills(NPCID.JungleSlime) > 10) shop.item[nextSlot++].SetDefaults(ItemID.TealDye);
                if (Utils.kills(NPCID.Hornet) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightYellowDye);
                if (Utils.kills(NPCID.Hornet) > 10) shop.item[nextSlot++].SetDefaults(ItemID.YellowDye);
                if (Utils.kills(NPCID.JungleBat) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightOrangeDye);
                if (Utils.kills(NPCID.JungleBat) > 10) shop.item[nextSlot++].SetDefaults(ItemID.OrangeDye);
            }

            if (NPC.downedBoss3)
            { // skeletron
                if (Utils.kills(NPCID.AngryBones) > 10) shop.item[nextSlot++].SetDefaults(ItemID.PurpleOozeDye);
                if (Utils.kills(NPCID.DarkCaster) > 10) shop.item[nextSlot++].SetDefaults(ItemID.ReflectiveMetalDye);
                if (Utils.kills(NPCID.CursedSkull) > 10) shop.item[nextSlot++].SetDefaults(ItemID.ShadowDye);
                if (Utils.kills(NPCID.DungeonSlime) > 10) shop.item[nextSlot++].SetDefaults(ItemID.StardustDye);
                if (Utils.kills(NPCID.AngryBones) > 20) shop.item[nextSlot++].SetDefaults(ItemID.GrimDye);
                if (Utils.kills(NPCID.DarkCaster) > 20) shop.item[nextSlot++].SetDefaults(ItemID.HadesDye);
                if (Utils.kills(NPCID.CursedSkull) > 20) shop.item[nextSlot++].SetDefaults(ItemID.LivingFlameDye);
                if (Utils.kills(NPCID.DungeonSlime) > 20) shop.item[nextSlot++].SetDefaults(ItemID.MartianArmorDye);
            }

            if (Main.hardMode)
            {
                if (Utils.kills(NPCID.PossessedArmor) > 10) shop.item[nextSlot++].SetDefaults(ItemID.ShadowflameHadesDye);
                if (Utils.kills(NPCID.WanderingEye) > 10) shop.item[nextSlot++].SetDefaults(ItemID.PhaseDye);
                if (Utils.kills(NPCID.Wraith) > 10) shop.item[nextSlot++].SetDefaults(ItemID.TwilightDye);
            }
        }

        public override void NPCLoot()
        {
            // Item.NewItem(npc.getRect(), ItemID.SlimeBanner);
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            attackDelay = 1;
            projType = ProjectileID.ThrowingKnife;
            if (NPC.downedBoss2)
            {
                projType = ProjectileID.PoisonedKnife;
            }
            if (Utils.downedMechBosses() == 1)
            {
                projType = ProjectileID.BoneJavelin;
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
