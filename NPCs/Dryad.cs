using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Dryad : ModNPC
    {
        static string[] shopNames = { "Nature", "Seeds", "Msc" };
        static int shopCounter = 0;
        static string currentShop = shopNames[shopCounter];
        static short npcid = NPCID.Dryad;

        public override string Texture
        {
            get
            {
                return "Terraria/NPC_" + npcid;
            }
        }

        public override bool Autoload(ref string name)
        {
            name = "Outcast";
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
            return "Kai";
        }

        public override string GetChat()
        {
            return Utils.dialog(new string[] { "I will protect you from the darkness!",
                "I will do whatever it takes to protect you!",
                "If it's the last thing I'll do, I'll protect you!"});
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
                case "Msc":
                    shop.item[nextSlot].SetDefaults(ItemID.CalmingPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.FeatherfallPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    break;
                case "Seeds":
                    shop.item[nextSlot++].SetDefaults(ItemID.CorruptSeeds);
                    shop.item[nextSlot++].SetDefaults(ItemID.HallowedSeeds);
                    shop.item[nextSlot++].SetDefaults(ItemID.GrassSeeds);
                    shop.item[nextSlot++].SetDefaults(ItemID.MushroomGrassSeeds);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrimsonSeeds);
                    shop.item[nextSlot++].SetDefaults(ItemID.BlinkrootSeeds);
                    shop.item[nextSlot++].SetDefaults(ItemID.DaybloomSeeds);
                    shop.item[nextSlot++].SetDefaults(ItemID.DeathweedSeeds);
                    shop.item[nextSlot++].SetDefaults(ItemID.FireblossomSeeds);
                    shop.item[nextSlot++].SetDefaults(ItemID.MoonglowSeeds);
                    shop.item[nextSlot++].SetDefaults(ItemID.WaterleafSeeds);
                    shop.item[nextSlot++].SetDefaults(ItemID.ShiverthornSeeds);
                    break;
                default:
                    shop.item[nextSlot++].SetDefaults(ItemID.BlinkrootPlanterBox);
                    shop.item[nextSlot++].SetDefaults(ItemID.CorruptPlanterBox);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrimsonPlanterBox);
                    shop.item[nextSlot++].SetDefaults(ItemID.DayBloomPlanterBox);
                    shop.item[nextSlot++].SetDefaults(ItemID.FireBlossomPlanterBox);
                    shop.item[nextSlot++].SetDefaults(ItemID.MoonglowPlanterBox);
                    shop.item[nextSlot++].SetDefaults(ItemID.ShiverthornPlanterBox);
                    shop.item[nextSlot++].SetDefaults(ItemID.WaterleafPlanterBox);
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
