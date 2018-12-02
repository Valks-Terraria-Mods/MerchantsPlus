using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Wizard : ModNPC
    {
        static string[] shopNames = { "Gear" };
        static int shopCounter = 0;
        static string currentShop = shopNames[shopCounter];
        static short npcid = NPCID.Wizard;

        public override string Texture
        {
            get
            {
                return "Terraria/NPC_" + npcid;
            }
        }

        public override bool Autoload(ref string name)
        {
            name = "Apprentice";
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
            return "Ynn";
        }

        public override string GetChat()
        {
            return Utils.dialog(new string[] { "Gandolf? Is that you?",
                "My magic is more then you think young one.",
                "It is dangerous to go alone little one. Bring friends on your journey.",
                "The dungeon is a dark place litte one, be careful.",
                "Some say a lord possesses this world.",
                Utils.dialogGift(npc, "Here take this little one, you may need this on your journey.", "Be safe on your journey.", true, 10, ItemID.MagicDagger, 50000),
                "The world is a big place little one."});
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
            shop.item[nextSlot++].SetDefaults(ItemID.IceRod);
            shop.item[nextSlot++].SetDefaults(ItemID.SpellTome);
            shop.item[nextSlot++].SetDefaults(ItemID.GreaterManaPotion);
            shop.item[nextSlot++].SetDefaults(ItemID.MusicBox);
            shop.item[nextSlot++].SetDefaults(ItemID.Bell);
            shop.item[nextSlot++].SetDefaults(ItemID.Harp);
            shop.item[nextSlot++].SetDefaults(ItemID.CrystalBall);
            shop.item[nextSlot++].SetDefaults(ItemID.EmptyDropper);
        }

        public override void NPCLoot()
        {
            // Item.NewItem(npc.getRect(), ItemID.SlimeBanner);
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            attackDelay = 1;
            projType = ProjectileID.RainbowCrystalExplosion;
            if (Utils.downedMechBosses() == 1)
            {
                projType = ProjectileID.BallofFire;
            }
            if (Utils.downedMechBosses() == 2)
            {
                projType = ProjectileID.BallofFrost;
            }
            if (Utils.downedMechBosses() == 3)
            {
                projType = ProjectileID.MagnetSphereBall;
            }
            if (NPC.downedPlantBoss)
            {
                projType = ProjectileID.RainbowRodBullet;
            }
            if (NPC.downedGolemBoss)
            {
                projType = ProjectileID.RainbowBack;
            }
            if (NPC.downedFishron)
            {
                projType = ProjectileID.RainbowFront;
            }
            if (NPC.downedMoonlord)
            {
                projType = ProjectileID.RainbowCrystal;
            }
        }

        public override void TownNPCAttackMagic(ref float auraLightMultiplier)
        {
            auraLightMultiplier *= 2;
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
