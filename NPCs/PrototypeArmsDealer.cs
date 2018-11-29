using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class PrototypeArmsDealer : ModNPC
    {
        static string[] shopNames = { "Basic" };
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
                Utils.dialogGift(npc, "TAKE THIS GUN BRAH", "BRAH", true, 5, ItemID.FlintlockPistol, 10),
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

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            if (!Main.hardMode)
            { // If not in hardmode.
                if (NPC.downedSlimeKing) // If the slime king was killed.
                {

                    shop.item[1].SetDefaults(ItemID.TheUndertaker); // Replace default flintlock pistol with the undertaker
                    shop.item[nextSlot++].SetDefaults(ItemID.RedRyder); // Add red ryder as an additional item to the shop
                }

                if (NPC.downedBoss1) // If the eye of cthulu was killed
                {
                    shop.item[0].SetDefaults(ItemID.SilverBullet);
                    shop.item[1].SetDefaults(ItemID.Revolver); // Replace undertaker with revolver
                    shop.item[nextSlot++].SetDefaults(ItemID.MusketBall);
                    shop.item[nextSlot++].SetDefaults(ItemID.Boomstick); // Add boom stick as an additional item to the shop
                }

                if (NPC.downedBoss2) // If the eater of worlds or the brain of cthulu was killed
                {
                    shop.item[0].SetDefaults(ItemID.MeteorShot);
                    shop.item[1].SetDefaults(ItemID.Handgun); // Replace revolver with handgun
                    shop.item[nextSlot++].SetDefaults(ItemID.Musket); // Add musket as an additional item to the shop
                }

                if (NPC.downedQueenBee) // If the queen bee was killed
                {
                    shop.item[1].SetDefaults(ItemID.PhoenixBlaster); // Replace handgun with phoenix blaster
                }

                if (NPC.downedBoss3) // If skeletron was killed
                {

                }
            }

            if (Main.hardMode)
            { // If in hardmode
                shop.item[0].SetDefaults(ItemID.MeteorShot);
                shop.item[1].SetDefaults(ItemID.GoldenBullet);
                shop.item[2].SetDefaults(ItemID.MusketBall);
                shop.item[3].SetDefaults(ItemID.Uzi); // Pistol slot
                shop.item[4].SetDefaults(ItemID.ClockworkAssaultRifle); // Replace with rifle
                shop.item[nextSlot++].SetDefaults(ItemID.OnyxBlaster);
                shop.item[nextSlot++].SetDefaults(ItemID.PartyBullet);

                if (NPC.downedMechBossAny) // If any mech boss was killed
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.Gatligator);
                }

                if (Utils.downedMechBosses() == 1)
                {
                    shop.item[0].SetDefaults(ItemID.CursedBullet);
                    shop.item[1].SetDefaults(ItemID.NanoBullet);
                }

                if (Utils.downedMechBosses() == 2)
                {
                    shop.item[0].SetDefaults(ItemID.IchorBullet);
                    shop.item[1].SetDefaults(ItemID.HighVelocityBullet);
                }

                if (Utils.downedMechBosses() == 3)
                {
                    shop.item[0].SetDefaults(ItemID.CrystalBullet);
                    shop.item[1].SetDefaults(ItemID.VenomBullet);
                    shop.item[3].SetDefaults(ItemID.VenusMagnum);
                    shop.item[4].SetDefaults(ItemID.Megashark);
                    shop.item[5].SetDefaults(ItemID.TacticalShotgun);
                    shop.item[nextSlot++].SetDefaults(ItemID.SniperRifle);
                    shop.item[nextSlot++].SetDefaults(ItemID.RifleScope);
                    shop.item[nextSlot++].SetDefaults(ItemID.Xenopopper);
                    shop.item[nextSlot++].SetDefaults(ItemID.ChainGun);
                }

                if (NPC.downedPlantBoss)
                {
                    shop.item[0].SetDefaults(ItemID.ChlorophyteBullet);
                    shop.item[4].SetDefaults(ItemID.VortexBeater);
                }

                if (NPC.downedGolemBoss)
                {

                }

                if (NPC.downedFishron)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.CandyCornRifle);
                }

                if (NPC.downedMoonlord)
                {
                    shop.item[0].SetDefaults(ItemID.MoonlordBullet);
                    shop.item[nextSlot++].SetDefaults(ItemID.SDMG);
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
