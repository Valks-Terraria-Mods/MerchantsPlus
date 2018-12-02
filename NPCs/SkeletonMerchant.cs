using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class SkeletonMerchant : ModNPC
    {
        static string[] shopNames = { "Gear", "Music Boxes" };
        static int shopCounter = 0;
        static string currentShop = shopNames[shopCounter];
        static short npcid = NPCID.SkeletonMerchant;

        public override string Texture
        {
            get
            {
                return "Terraria/NPC_" + npcid;
            }
        }

        public override bool Autoload(ref string name)
        {
            name = "Skeleton Dealer";
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
            npc.lifeMax = 2000;
            npc.scale = 1.5f;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            animationType = npcid;
        }

        public override void DrawEffects(ref Color drawColor)
        {
            Lighting.AddLight(npc.position, new Vector3(0.7f, 0, 0.5f));
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            return true;
        }


        public override string TownNPCName()
        {
            return "Skele";
        }

        public override string GetChat()
        {
            return Utils.dialog(new string[] { "(You hear a small crackling noise..)" ,
                "(The skeleton stares blankly at you..)",
                "(The skeleton seems to be getting impatient..)"});
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
            switch (currentShop) {
                case "Music Boxes":
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxAltOverworldDay);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxAltUnderground);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxBoss1);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxBoss2);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxBoss3);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxBoss4);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxBoss5);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxCorruption);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxCrimson);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxDD2);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxDesert);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxDungeon);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxEclipse);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxEerie);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxFrostMoon);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxGoblins);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxIce);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxJungle);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxLunarBoss);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxMartians);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxMushrooms);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxNight);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxOcean);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxOverworldDay);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxPlantera);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxPumpkinMoon);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxRain);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxSandstorm);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxSnow);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxSpace);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxTemple);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxTheHallow);
                    break;
                default:
                    shop.item[nextSlot++].SetDefaults(ItemID.PinkString);
                    shop.item[nextSlot++].SetDefaults(ItemID.PurpleCounterweight);
                    shop.item[nextSlot++].SetDefaults(ItemID.YoYoGlove);
                    if (Main.hardMode) {
                        if (Utils.kills(NPCID.WyvernHead) > 0) shop.item[nextSlot++].SetDefaults(ItemID.SoulofFlight);
                        if (NPC.downedMechBoss3) shop.item[nextSlot++].SetDefaults(ItemID.SoulofFright);
                        if (Utils.kills(NPCID.IlluminantSlime) > 0) shop.item[nextSlot++].SetDefaults(ItemID.SoulofLight);
                        if (NPC.downedMechBoss2) shop.item[nextSlot++].SetDefaults(ItemID.SoulofMight);
                        if (Utils.kills(NPCID.Clinger) > 0 || Utils.kills(NPCID.IchorSticker) > 0) shop.item[nextSlot++].SetDefaults(ItemID.SoulofNight);
                        if (NPC.downedMechBoss1) shop.item[nextSlot++].SetDefaults(ItemID.SoulofSight);
                        shop.item[nextSlot].SetDefaults(ItemID.RagePotion);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    }
                    break;
            }
        }

        public override void NPCLoot()
        {
            // Item.NewItem(npc.getRect(), ItemID.SlimeBanner);
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            attackDelay = 1;
            projType = ProjectileID.GreenLaser;
        }

        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage += 50;
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
