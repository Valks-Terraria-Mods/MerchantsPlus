using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class PrototypeGoblinTinkerer : ModNPC
    {
        static string[] shopNames = { "Basic", "Accessories" };
        static int shopCounter = 0;
        static string currentShop = shopNames[shopCounter];
        static short npcid = NPCID.GoblinTinkerer;

        public override string Texture
        {
            get
            {
                return "Terraria/NPC_" + npcid;
            }
        }

        public override bool Autoload(ref string name)
        {
            name = "Reforger";
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
            return "Jeevan";
        }

        public override string GetChat()
        {
            return Utils.dialog(new string[] { "Were going to mod your gear right up baby. :)" ,
                "I got all the modifications you will ever need. >:)",
                "Did someone call for a modder? >:D"});
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
                case "Accessories":
                    if (Utils.kills(NPCID.BlueSlime) > 100) shop.item[nextSlot++].SetDefaults(ItemID.Aglet);
                    if (Utils.kills(NPCID.RedSlime) > 100) shop.item[nextSlot++].SetDefaults(ItemID.AnkletoftheWind);
                    if (Utils.kills(NPCID.PurpleSlime) > 100) shop.item[nextSlot++].SetDefaults(ItemID.Shackle);
                    if (Utils.kills(NPCID.DemonEye) > 100) shop.item[nextSlot++].SetDefaults(ItemID.CloudinaBottle);
                    if (Utils.kills(NPCID.DemonEye2) > 100) shop.item[nextSlot++].SetDefaults(ItemID.SandstorminaBottle);
                    if (Utils.kills(NPCID.Zombie) > 100) shop.item[nextSlot++].SetDefaults(ItemID.BlizzardinaBottle);
                    if (Utils.kills(NPCID.Zombie) > 150) shop.item[nextSlot++].SetDefaults(ItemID.ClimbingClaws);
                    if (Utils.kills(NPCID.PinkJellyfish) > 50) shop.item[nextSlot++].SetDefaults(ItemID.Flipper);
                    if (Utils.kills(NPCID.Antlion) > 50) shop.item[nextSlot++].SetDefaults(ItemID.FlyingCarpet);
                    if (Utils.kills(NPCID.BlueJellyfish) > 50) shop.item[nextSlot++].SetDefaults(ItemID.FrogLeg);
                    if (NPC.downedBoss3)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.HermesBoots);
                        shop.item[nextSlot++].SetDefaults(ItemID.IceSkates);
                        shop.item[nextSlot++].SetDefaults(ItemID.LavaCharm);
                        shop.item[nextSlot++].SetDefaults(ItemID.LuckyHorseshoe);
                        shop.item[nextSlot++].SetDefaults(ItemID.ShinyRedBalloon);
                    }

                    if (NPC.downedMechBoss1)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.Tabi);
                        shop.item[nextSlot++].SetDefaults(ItemID.BlackBelt);
                        shop.item[nextSlot++].SetDefaults(ItemID.MoonCharm);
                        shop.item[nextSlot++].SetDefaults(ItemID.CobaltShield);
                    }

                    if (NPC.downedMechBoss2)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.FleshKnuckles);
                        shop.item[nextSlot++].SetDefaults(ItemID.FrozenTurtleShell);
                        shop.item[nextSlot++].SetDefaults(ItemID.HandWarmer);
                        shop.item[nextSlot++].SetDefaults(ItemID.HoneyComb);
                    }

                    if (NPC.downedMechBoss3)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.MagmaStone);
                        shop.item[nextSlot++].SetDefaults(ItemID.PaladinsShield);
                        shop.item[nextSlot++].SetDefaults(ItemID.PutridScent);

                    }

                    if (NPC.downedPlantBoss)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.SharkToothNecklace);
                        shop.item[nextSlot++].SetDefaults(ItemID.StarCloak);
                        shop.item[nextSlot++].SetDefaults(ItemID.SunStone);
                        shop.item[nextSlot++].SetDefaults(ItemID.TitanGlove);
                        shop.item[nextSlot++].SetDefaults(ItemID.DiscountCard);
                        shop.item[nextSlot++].SetDefaults(ItemID.JellyfishNecklace);
                        shop.item[nextSlot++].SetDefaults(ItemID.LuckyCoin);
                        shop.item[nextSlot++].SetDefaults(ItemID.NeptunesShell);
                    }
                    break;
                default:
                    const int SLOT_BOOTS = 0;
                    const int SLOT_GRAPPLE = 3;

                    if (NPC.downedSlimeKing)
                    {
                        shop.item[SLOT_GRAPPLE].SetDefaults(ItemID.SlimeHook);
                    }

                    if (NPC.downedBoss1)
                    {
                        shop.item[SLOT_GRAPPLE].SetDefaults(ItemID.IvyWhip);
                    }

                    if (NPC.downedBoss2)
                    {

                    }

                    if (Main.hardMode)
                    {
                        shop.item[SLOT_GRAPPLE].SetDefaults(ItemID.DualHook);
                        shop.item[SLOT_BOOTS].SetDefaults(ItemID.LightningBoots);
                    }

                    if (Utils.downedMechBosses() == 3)
                    {
                        shop.item[SLOT_GRAPPLE].SetDefaults(ItemID.IlluminantHook);
                        shop.item[SLOT_BOOTS].SetDefaults(ItemID.FrostsparkBoots);
                    }

                    if (NPC.downedPlantBoss)
                    {
                        shop.item[SLOT_GRAPPLE].SetDefaults(ItemID.AntiGravityHook);
                    }

                    if (NPC.downedGolemBoss)
                    {
                        shop.item[SLOT_GRAPPLE].SetDefaults(ItemID.SpookyHook);
                    }

                    if (NPC.downedMoonlord)
                    {
                        shop.item[SLOT_GRAPPLE].SetDefaults(ItemID.LunarHook);
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
