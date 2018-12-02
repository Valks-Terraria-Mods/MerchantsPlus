using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Pirate : ModNPC
    {
        static string[] shopNames = { "Arrr", "Potions" };
        static int shopCounter = 0;
        static string currentShop = shopNames[shopCounter];
        static int npcid = NPCID.Pirate;

        public override string Texture
        {
            get
            {
                return "Terraria/NPC_" + NPCID.Pirate;
            }
        }

        public override bool Autoload(ref string name)
        {
            name = "Bandit";
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
            animationType = NPCID.Pirate;
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            return true;
        }


        public override string TownNPCName()
        {
            return "Gord";
        }

        public override string GetChat()
        {
            return Utils.dialog(new string[] { Utils.dialogGift(npc, "Oh ye rich friend? Take a cannonball arr.", "Arrrrr", true, 5, ItemID.Cannonball, 100000),
                "Arr?"});
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
                    shop.item[nextSlot].SetDefaults(ItemID.TrapsightPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.HunterPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.InfernoPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    break;
                default:
                    shop.item[nextSlot++].SetDefaults(ItemID.Sail);
                    shop.item[nextSlot++].SetDefaults(ItemID.ParrotCracker);
                    shop.item[nextSlot++].SetDefaults(ItemID.BunnyCannon);
                    shop.item[nextSlot++].SetDefaults(ItemID.RangerEmblem);
                    shop.item[nextSlot++].SetDefaults(ItemID.SorcererEmblem);
                    shop.item[nextSlot++].SetDefaults(ItemID.SummonerEmblem);
                    shop.item[nextSlot++].SetDefaults(ItemID.WarriorEmblem);
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
            projType = ProjectileID.Bullet;
            if (Utils.downedMechBosses() == 1)
            {
                projType = ProjectileID.CursedBullet;
            }
            if (Utils.downedMechBosses() == 2)
            {
                projType = ProjectileID.IchorBullet;
            }
            if (Utils.downedMechBosses() == 3)
            {
                projType = ProjectileID.CrystalBullet;
            }
            if (NPC.downedPlantBoss)
            {
                projType = ProjectileID.ChlorophyteBullet;
            }
            if (NPC.downedMoonlord)
            {
                projType = ProjectileID.MoonlordBullet;
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
