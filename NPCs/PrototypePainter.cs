using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class PrototypePainter : ModNPC
    {
        static string[] shopNames = { "Basic" };
        static int shopCounter = 0;
        static string currentShop = shopNames[shopCounter];

        public override string Texture
        {
            get
            {
                return "Terraria/NPC_" + NPCID.Painter;
            }
        }

        public override bool Autoload(ref string name)
        {
            name = "Artist";
            return mod.Properties.Autoload;
        }

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Painter];
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
            animationType = NPCID.Painter;
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            return true;
        }


        public override string TownNPCName()
        {
            return "Valk";
        }

        public override string GetChat()
        {
            return Utils.dialog(new string[] { "I gotta' fresh load of white paint. Want some? :)" ,
                "All my paint is real good, I promise. ;)",
                Utils.dialogGift(npc, "Here, take this, it was given to me by my old grand father. Hope you make good use of it.", "Painting these walls day and night..", !Main.hardMode, 10, ItemID.PainterPaintballGun, 50000),
                Utils.isNPCHere(NPCID.PartyGirl) ? "Can you please tell " + Utils.getNPCName(NPCID.PartyGirl) + " to stop decorating my house!" : "I wonder where that party girl is at.",
                Utils.dialogGift(npc, "Have some free paint friend!", "Paint is the only thing I dream about at night.", true, 10, ItemID.RedPaint, 0),
                "You won't get any paint this good anywhere else. :)"});
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
