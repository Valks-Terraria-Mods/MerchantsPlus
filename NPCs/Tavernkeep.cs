using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Tavernkeep : ModNPC
    {
        static string[] shopNames = { "Gear" };
        static int shopCounter = 0;
        static string currentShop = shopNames[shopCounter];
        static short npcid = NPCID.DD2Bartender;

        public override string Texture
        {
            get
            {
                return "Terraria/NPC_" + npcid;
            }
        }

        public override bool Autoload(ref string name)
        {
            name = "Bartender";
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
            return "Sean";
        }

        public override string GetChat()
        {
            return Utils.dialog(new string[] {"...", "...", "...", "...", "...",
                "I AIN'T TELLIN' YOU NOTHIN'"});
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

        private void shopFlameburst(Chest shop, ref int nextSlot) {
            shop.item[nextSlot].SetDefaults(ItemID.DD2FlameburstTowerT1Popper);
            if (Utils.downedMechBosses() == 1) shop.item[nextSlot].SetDefaults(ItemID.DD2FlameburstTowerT2Popper);
            if (NPC.downedGolemBoss) shop.item[nextSlot].SetDefaults(ItemID.DD2FlameburstTowerT3Popper);
            nextSlot++;
        }

        private void shopBallista(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.DD2BallistraTowerT1Popper);
            if (Utils.downedMechBosses() == 1) shop.item[nextSlot].SetDefaults(ItemID.DD2BallistraTowerT2Popper);
            if (NPC.downedGolemBoss) shop.item[nextSlot].SetDefaults(ItemID.DD2BallistraTowerT3Popper);
            nextSlot++;
        }

        private void shopLightning(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.DD2LightningAuraT1Popper);
            if (Utils.downedMechBosses() == 1) shop.item[nextSlot].SetDefaults(ItemID.DD2LightningAuraT2Popper);
            if (NPC.downedGolemBoss) shop.item[nextSlot].SetDefaults(ItemID.DD2LightningAuraT3Popper);
            nextSlot++;
        }

        private void shopExplosive(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.DD2ExplosiveTrapT1Popper);
            if (Utils.downedMechBosses() == 1) shop.item[nextSlot].SetDefaults(ItemID.DD2ExplosiveTrapT2Popper);
            if (NPC.downedGolemBoss) shop.item[nextSlot].SetDefaults(ItemID.DD2ExplosiveTrapT3Popper);
            nextSlot++;
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot++].SetDefaults(ItemID.Ale);
            shop.item[nextSlot++].SetDefaults(ItemID.DD2ElderCrystal);
            shop.item[nextSlot++].SetDefaults(ItemID.DD2ElderCrystalStand);
            shop.item[nextSlot++].SetDefaults(ItemID.DefendersForge);
            shopBallista(shop, ref nextSlot);
            shopExplosive(shop, ref nextSlot);
            shopLightning(shop, ref nextSlot);
            shopFlameburst(shop, ref nextSlot);
            shop.item[nextSlot++].SetDefaults(ItemID.ApprenticeScarf);
            shop.item[nextSlot++].SetDefaults(ItemID.SquireShield);
            shop.item[nextSlot++].SetDefaults(ItemID.HuntressBuckler);
            shop.item[nextSlot++].SetDefaults(ItemID.MonkBelt);
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
