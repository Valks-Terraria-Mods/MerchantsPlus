using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class PrototypeCyborg : ModNPC
    {
        static string[] shopNames = { "Basic" };
        static int shopCounter = 0;
        static string currentShop = shopNames[shopCounter];
        static short npcid = NPCID.Cyborg;

        public override string Texture
        {
            get
            {
                return "Terraria/NPC_" + npcid;
            }
        }

        public override bool Autoload(ref string name)
        {
            name = "Robot";
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
            return "Max";
        }

        public override string GetChat()
        {
            return Utils.dialog(new string[] {"Don't set off those explosives off I have behind you.",
            "Anything that moves in the sky, I see it.",
            "Rocketry is a very delicate task, it requires alot of focus.",
            "Aim. Shoot. Kill.",
            Main.eclipse ? "Are you afraid of a mere eclipse? I'm not!" : "Always keep your wits about you.",
            Main.raining ? "This rain is bad for my circuits." : "A bright day is my day.",
            Main.hardMode ? "The world feels a lot more tougher than it use to be." : "This world is weak."});
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
            if (NPC.downedGolemBoss)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.ElectrosphereLauncher);
            }

            if (NPC.downedFishron)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.RocketLauncher);
            }

            if (NPC.downedAncientCultist)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.SnowmanCannon);
            }

            if (NPC.downedTowerVortex)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.NailGun);
            }
        }

        public override void NPCLoot()
        {
            // Item.NewItem(npc.getRect(), ItemID.SlimeBanner);
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            attackDelay = 1;
            projType = ProjectileID.RocketI;
            if (NPC.downedSlimeKing)
            {
                projType = ProjectileID.RocketII;
            }
            if (NPC.downedBoss1)
            {
                projType = ProjectileID.RocketIII;
            }
            if (NPC.downedBoss2)
            {
                projType = ProjectileID.RocketIV;
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
