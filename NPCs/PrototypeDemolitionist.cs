using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class PrototypeDemolitionist : ModNPC
    {
        static string[] shopNames = { "Basic" };
        static int shopCounter = 0;
        static string currentShop = shopNames[shopCounter];
        static short npcid = NPCID.Demolitionist;

        public override string Texture
        {
            get
            {
                return "Terraria/NPC_" + npcid;
            }
        }

        public override bool Autoload(ref string name)
        {
            name = "Explosives Expert";
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
            return "Jake";
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
            if (NPC.AnyNPCs(NPCID.PartyGirl))
            {
                shop.item[nextSlot++].SetDefaults(ItemID.PartyGirlGrenade);
            }

            if (NPC.downedSlimeKing)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.StickyGrenade);
                shop.item[nextSlot++].SetDefaults(ItemID.StickyBomb);
                shop.item[nextSlot++].SetDefaults(ItemID.StickyDynamite);
                shop.item[nextSlot++].SetDefaults(ItemID.BouncyGrenade);
                shop.item[nextSlot++].SetDefaults(ItemID.BouncyBomb);
                shop.item[nextSlot++].SetDefaults(ItemID.BouncyDynamite);
            }

            if (NPC.downedBoss1)
            { // eye of chulutu
                shop.item[nextSlot++].SetDefaults(ItemID.Explosives);
            }

            if (NPC.AnyNPCs(NPCID.Angler))
            {
                shop.item[nextSlot++].SetDefaults(ItemID.BombFish);
            }

            if (NPC.downedQueenBee)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.Beenade);
            }

            if (NPC.downedBoss3)
            { // skeletron
                shop.item[nextSlot++].SetDefaults(ItemID.ExplosiveBunny);
            }

            if (NPC.downedClown)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.ExplosiveJackOLantern);
            }

            if (NPC.downedMoonlord)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.LandMine);
            }
        }

        public override void NPCLoot()
        {
            // Item.NewItem(npc.getRect(), ItemID.SlimeBanner);
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            attackDelay = 1;
            projType = ProjectileID.Grenade;
            if (NPC.downedSlimeKing)
            {
                projType = ProjectileID.StickyGrenade;
            }
            if (NPC.downedBoss1)
            {
                projType = ProjectileID.BouncyGrenade;
            }
            if (NPC.downedBoss2)
            {
                projType = ProjectileID.HappyBomb;
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
