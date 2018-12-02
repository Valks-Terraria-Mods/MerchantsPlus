using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class SantaClaus : ModNPC
    {
        static string[] shopNames = { "Decor", "Bulbs", "Lights", "Potions" };
        static int shopCounter = 0;
        static string currentShop = shopNames[shopCounter];
        static short npcid = NPCID.SantaClaus;

        public override string Texture
        {
            get
            {
                return "Terraria/NPC_" + npcid;
            }
        }

        public override bool Autoload(ref string name)
        {
            name = "Santa";
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
            return "Bart";
        }

        public override string GetChat()
        {
            return Utils.dialog(new string[] { "HOHOHOOOOOHOOOOOO",
                "HOOOOOOOO HOOOOOO HOOOOOOOO",
                "You were a good lil' kid wern't ya buddy? HOOOOOOOOO HOOOOOOO HOOOOOOOOOO",
                "HOOOOOOOOOOOOOOOO HOOOOOOOOOOOO HOOOOOOOOOOOOO"});
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
                case "Potions":
                    shop.item[nextSlot].SetDefaults(ItemID.InvisibilityPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.GenderChangePotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.RecallPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.TeleportationPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.WormholePotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    break;
                case "Lights":
                    shop.item[nextSlot++].SetDefaults(ItemID.RedLight);
                    shop.item[nextSlot++].SetDefaults(ItemID.GreenLight);
                    shop.item[nextSlot++].SetDefaults(ItemID.BlueLight);
                    shop.item[nextSlot++].SetDefaults(ItemID.StarTopper1);
                    shop.item[nextSlot++].SetDefaults(ItemID.StarTopper2);
                    shop.item[nextSlot++].SetDefaults(ItemID.StarTopper3);
                    shop.item[nextSlot++].SetDefaults(ItemID.MulticoloredLights);
                    shop.item[nextSlot++].SetDefaults(ItemID.RedLights);
                    shop.item[nextSlot++].SetDefaults(ItemID.GreenLights);
                    shop.item[nextSlot++].SetDefaults(ItemID.BlueLights);
                    shop.item[nextSlot++].SetDefaults(ItemID.YellowLights);
                    shop.item[nextSlot++].SetDefaults(ItemID.RedAndYellowLights);
                    shop.item[nextSlot++].SetDefaults(ItemID.RedAndGreenLights);
                    shop.item[nextSlot++].SetDefaults(ItemID.YellowAndGreenLights);
                    shop.item[nextSlot++].SetDefaults(ItemID.BlueAndGreenLights);
                    shop.item[nextSlot++].SetDefaults(ItemID.RedAndBlueLights);
                    shop.item[nextSlot++].SetDefaults(ItemID.BlueAndYellowLights);
                    break;
                case "Bulbs":
                    shop.item[nextSlot++].SetDefaults(ItemID.RedBulb);
                    shop.item[nextSlot++].SetDefaults(ItemID.YellowBulb);
                    shop.item[nextSlot++].SetDefaults(ItemID.RedAndGreenBulb);
                    shop.item[nextSlot++].SetDefaults(ItemID.YellowAndGreenBulb);
                    shop.item[nextSlot++].SetDefaults(ItemID.RedAndYellowBulb);
                    shop.item[nextSlot++].SetDefaults(ItemID.WhiteBulb);
                    shop.item[nextSlot++].SetDefaults(ItemID.WhiteAndRedBulb);
                    shop.item[nextSlot++].SetDefaults(ItemID.WhiteAndYellowBulb);
                    shop.item[nextSlot++].SetDefaults(ItemID.WhiteAndGreenBulb);
                    break;
                default:
                    shop.item[nextSlot++].SetDefaults(ItemID.ChristmasTree);
                    shop.item[nextSlot++].SetDefaults(ItemID.BowTopper);
                    shop.item[nextSlot++].SetDefaults(ItemID.WhiteGarland);
                    shop.item[nextSlot++].SetDefaults(ItemID.WhiteAndRedGarland);
                    shop.item[nextSlot++].SetDefaults(ItemID.RedGardland);
                    shop.item[nextSlot++].SetDefaults(ItemID.GreenGardland);
                    shop.item[nextSlot++].SetDefaults(ItemID.GreenAndWhiteGarland);
                    shop.item[nextSlot++].SetDefaults(ItemID.MulticoloredBulb);
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
