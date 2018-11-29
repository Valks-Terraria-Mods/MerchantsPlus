using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class PrototypeDryad : ModNPC
    {
        static string[] shopNames = { "Basic" };
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

            if (Main.hardMode)
            {
                if (Utils.kills(NPCID.JungleSlime) > 5)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.NaturesGift);
                }
                if (NPC.downedBoss1)
                {
                    if (Utils.kills(NPCID.DemonEye) > 15)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.BandofRegeneration);
                    }
                }
                if (NPC.downedBoss2)
                {
                    if (Utils.kills(NPCID.EaterofSouls) > 15)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.BandofStarpower);
                    }

                    if (Utils.kills(NPCID.BloodCrawler) > 15)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.PanicNecklace);
                    }
                }
                if (Utils.kills(NPCID.Mimic) > 5)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.PhilosophersStone);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrossNecklace);
                }
                if (Utils.kills(NPCID.Werewolf) > 10)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.AdhesiveBandage);
                }
                if (Utils.kills(NPCID.BlueArmoredBones) > 10 || Utils.kills(NPCID.ArmoredSkeleton) > 10)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.ArmorPolish);
                }
                if (Utils.kills(NPCID.ToxicSludge) > 10)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.Bezoar);
                }
                if (Utils.kills(NPCID.Hornet) > 10)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.FeralClaws);
                }
                if (Utils.kills(NPCID.CursedSkull) > 10)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.Nazar);
                }
                if (Utils.kills(NPCID.CorruptSlime) > 10)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.Blindfold);
                }
                if (Utils.kills(NPCID.Mummy) > 10)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.TrifoldMap);
                }
                if (Utils.kills(NPCID.Corruptor) > 10)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.Vitamins);
                }
                if (Utils.kills(NPCID.Pixie) > 10)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.FastClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.Megaphone);
                }
                if (Utils.kills(NPCID.Vampire) > 10)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.MoonStone);
                }
                if (Utils.kills(NPCID.Medusa) > 2)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.PocketMirror);
                }
                if (Utils.kills(NPCID.FireImp) > 10)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.ObsidianRose);
                }
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
