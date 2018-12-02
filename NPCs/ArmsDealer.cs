using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class ArmsDealer : ModNPC
    {
        static string[] shopNames = { "Guns", "Msc" };
        static int shopCounter = 0;
        static string currentShop = shopNames[shopCounter];
        static short npcid = NPCID.ArmsDealer;

        public override string Texture
        {
            get
            {
                return "Terraria/NPC_" + npcid;
            }
        }

        public override bool Autoload(ref string name)
        {
            name = "Guns Dealer";
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
            return "Mark";
        }

        public override string GetChat()
        {
            return Utils.dialog(new string[] { "GET UR EEPIC GUNS NOW",
                "EPIC GUNS FER SALE BRUH",
                "IM 5 YEARS OLD DEAL WITH IT BRAH",
                "YOU NEED A GUN BRAH?",
                "GET YA GUNS TODAY BRAH",
                "GUNS FOR SALE BRAH!",
                "BRAH YOU GONNA' BUY SOMETIN OR WHAT",
                "BRAH I DON'T GOT ALL DAY",
                "EPIC GUNS BRAH",
                "BRAH IT LOOKS LIKE YOU NEED A GUN!",
                "NEED A GUN BRAH?",
                Utils.isNPCHere(NPCID.Pirate) ? "TELL YE PIRATE DUDE TO STOP SHOOTIN' CANNON BALLS AT ME" : "WONDER WHERE THAT PIRATE DUDE IS AT, HE OWES MEH GUNNNZZ"});
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

        private void shopBulletMain(Chest shop, ref int nextSlot) {
            shop.item[nextSlot].SetDefaults(ItemID.MusketBall);
            if (NPC.downedBoss1) shop.item[nextSlot].SetDefaults(ItemID.SilverBullet);
            if (NPC.downedBoss2) shop.item[nextSlot].SetDefaults(ItemID.MeteorShot);
            if (Utils.downedMechBosses() == 1) shop.item[nextSlot].SetDefaults(ItemID.CursedBullet);
            if (Utils.downedMechBosses() == 2) shop.item[nextSlot].SetDefaults(ItemID.IchorBullet);
            if (Utils.downedMechBosses() == 3) shop.item[nextSlot].SetDefaults(ItemID.CrystalBullet);
            if (NPC.downedPlantBoss) shop.item[nextSlot].SetDefaults(ItemID.ChlorophyteBullet);
            if (NPC.downedMoonlord) shop.item[nextSlot].SetDefaults(ItemID.MoonlordBullet);
            nextSlot++;
        }

        private void shopBulletOther(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.PartyBullet);
            shop.item[nextSlot].shopCustomPrice = 100;
            if (NPC.downedSlimeKing) shop.item[nextSlot].shopCustomPrice = 50;
            if (NPC.downedBoss1) shop.item[nextSlot].shopCustomPrice = 25;
            if (NPC.downedBoss2) shop.item[nextSlot].shopCustomPrice = 5;
            if (NPC.downedQueenBee) shop.item[nextSlot].shopCustomPrice = 1;
            if (NPC.downedBoss3) shop.item[nextSlot].SetDefaults(ItemID.ExplodingBullet);
            if (Utils.downedMechBosses() == 1) shop.item[nextSlot].SetDefaults(ItemID.GoldenBullet);
            if (Utils.downedMechBosses() == 2) shop.item[nextSlot].SetDefaults(ItemID.NanoBullet);
            if (Utils.downedMechBosses() == 3) shop.item[nextSlot].SetDefaults(ItemID.HighVelocityBullet);
            if (NPC.downedPlantBoss) shop.item[nextSlot].SetDefaults(ItemID.VenomBullet);
            nextSlot++;
        }

        private void shopPistol(Chest shop, ref int nextSlot) {
            shop.item[nextSlot].SetDefaults(ItemID.FlintlockPistol);
            if (NPC.downedSlimeKing) shop.item[nextSlot].SetDefaults(ItemID.TheUndertaker);
            if (NPC.downedBoss1) shop.item[nextSlot].SetDefaults(ItemID.Revolver);
            if (NPC.downedBoss2) shop.item[nextSlot].SetDefaults(ItemID.Handgun);
            if (NPC.downedQueenBee) shop.item[nextSlot].SetDefaults(ItemID.PhoenixBlaster);
            if (Main.hardMode) shop.item[nextSlot].SetDefaults(ItemID.Uzi);
            if (Utils.downedMechBosses() == 3) shop.item[nextSlot].SetDefaults(ItemID.VenusMagnum);
            nextSlot++;
        }

        private void shopRifle(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.RedRyder);
            if (NPC.downedBoss1) shop.item[nextSlot].SetDefaults(ItemID.Musket);
            if (NPC.downedBoss2) shop.item[nextSlot].SetDefaults(ItemID.Minishark);
            if (Main.hardMode) shop.item[nextSlot].SetDefaults(ItemID.ClockworkAssaultRifle);
            if (Utils.downedMechBosses() == 1) shop.item[nextSlot].SetDefaults(ItemID.Gatligator);
            if (Utils.downedMechBosses() == 2) shop.item[nextSlot].SetDefaults(ItemID.Megashark);
            if (NPC.downedAncientCultist) shop.item[nextSlot].SetDefaults(ItemID.VortexBeater);
            if (NPC.downedMoonlord) shop.item[nextSlot].SetDefaults(ItemID.SDMG);
            nextSlot++;
        }

        private void shopShotgun(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.Boomstick);
            if (Main.hardMode) shop.item[nextSlot].SetDefaults(ItemID.Shotgun);
            if (Utils.downedMechBosses() == 1) shop.item[nextSlot].SetDefaults(ItemID.OnyxBlaster);
            if (NPC.downedPlantBoss) shop.item[nextSlot].SetDefaults(ItemID.TacticalShotgun);
            if ((NPC.downedFishron || NPC.downedMoonlord) && MerchantsPlus.overhaulLoaded) {
                Mod overhaul = ModLoader.GetMod("TerrariaOverhaul");
                shop.item[nextSlot].SetDefaults(overhaul.ItemType("SuperShotgun"));
            }
            nextSlot++;
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            switch (currentShop) {
                case "Msc":
                    if (NPC.downedPlantBoss)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.SniperRifle);
                        shop.item[nextSlot++].SetDefaults(ItemID.RifleScope);
                    }
                    if (Main.dayTime) shop.item[nextSlot++].SetDefaults(ItemID.IllegalGunParts);
                    if (Main.hardMode) shop.item[nextSlot++].SetDefaults(ItemID.EmptyBullet);
                    shop.item[nextSlot++].SetDefaults(ItemID.AmmoBox);
                    shop.item[nextSlot].SetDefaults(ItemID.AmmoReservationPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    break;
                default:
                    shopBulletMain(shop, ref nextSlot);
                    shopBulletOther(shop, ref nextSlot);
                    shopPistol(shop, ref nextSlot);
                    shopRifle(shop, ref nextSlot);
                    shopShotgun(shop, ref nextSlot);
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
            if (NPC.downedSlimeKing)
            {
                projType = ProjectileID.GoldenBullet;
            }
            if (NPC.downedBoss2)
            {
                projType = ProjectileID.MeteorShot;
            }
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
