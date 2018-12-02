using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Steampunker : ModNPC
    {
        static string[] shopNames = { "Gear", "Solutions", "Logic" };
        static int shopCounter = 0;
        static string currentShop = shopNames[shopCounter];
        static short npcid = NPCID.Steampunker;

        public override string Texture
        {
            get
            {
                return "Terraria/NPC_" + npcid;
            }
        }

        public override bool Autoload(ref string name)
        {
            name = "Steampunk";
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
            return "Jessica";
        }

        public override string GetChat()
        {
            return Utils.dialog(new string[] { "The author of the mod forgot about me. ;(" ,
                "I don't really have much to say, like I said I'm a forgotten little someone. :(",
                "Hey, maybe the author of the mod will give me better dialog in the next update! :/",
                "Oh someone cares about me? <3"});
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
                case "Logic":
                    shop.item[nextSlot++].SetDefaults(ItemID.LogicGateLamp_Faulty);
                    shop.item[nextSlot++].SetDefaults(ItemID.LogicGateLamp_Off);
                    shop.item[nextSlot++].SetDefaults(ItemID.LogicGate_AND);
                    shop.item[nextSlot++].SetDefaults(ItemID.LogicGate_NAND);
                    shop.item[nextSlot++].SetDefaults(ItemID.LogicGate_NOR);
                    shop.item[nextSlot++].SetDefaults(ItemID.LogicGate_NXOR);
                    shop.item[nextSlot++].SetDefaults(ItemID.LogicGate_OR);
                    shop.item[nextSlot++].SetDefaults(ItemID.LogicGate_XOR);
                    shop.item[nextSlot].SetDefaults(ItemID.LogicSensor_Above);
                    shop.item[nextSlot++].shopCustomPrice = 20000;
                    shop.item[nextSlot].SetDefaults(ItemID.LogicSensor_Honey);
                    shop.item[nextSlot++].shopCustomPrice = 20000;
                    shop.item[nextSlot].SetDefaults(ItemID.LogicSensor_Lava);
                    shop.item[nextSlot++].shopCustomPrice = 20000;
                    shop.item[nextSlot].SetDefaults(ItemID.LogicSensor_Liquid);
                    shop.item[nextSlot++].shopCustomPrice = 20000;
                    shop.item[nextSlot].SetDefaults(ItemID.LogicSensor_Moon);
                    shop.item[nextSlot++].shopCustomPrice = 20000;
                    shop.item[nextSlot].SetDefaults(ItemID.LogicSensor_Sun);
                    shop.item[nextSlot++].shopCustomPrice = 20000;
                    shop.item[nextSlot].SetDefaults(ItemID.LogicSensor_Water);
                    shop.item[nextSlot++].shopCustomPrice = 20000;
                    break;
                case "Solutions":
                    shop.item[nextSlot++].SetDefaults(ItemID.Clentaminator);
                    shop.item[nextSlot++].SetDefaults(ItemID.PurpleSolution);
                    shop.item[nextSlot++].SetDefaults(ItemID.RedSolution);
                    shop.item[nextSlot++].SetDefaults(ItemID.GreenSolution);
                    shop.item[nextSlot++].SetDefaults(ItemID.DarkBlueSolution);
                    shop.item[nextSlot++].SetDefaults(ItemID.BlueSolution);
                    break;
                default:
                    shop.item[nextSlot++].SetDefaults(ItemID.Teleporter);
                    shop.item[nextSlot++].SetDefaults(ItemID.Jetpack);
                    shop.item[nextSlot++].SetDefaults(ItemID.Solidifier);
                    shop.item[nextSlot++].SetDefaults(ItemID.BlendOMatic);
                    shop.item[nextSlot++].SetDefaults(ItemID.FleshCloningVaat);
                    shop.item[nextSlot++].SetDefaults(ItemID.SteampunkBoiler);
                    shop.item[nextSlot++].SetDefaults(ItemID.Cog);
                    shop.item[nextSlot++].SetDefaults(ItemID.StaticHook);
                    shop.item[nextSlot++].SetDefaults(ItemID.ConveyorBeltRight);
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
