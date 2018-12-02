using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Painter : ModNPC
    {
        static string[] shopNames = { "Tools", "Paint", "Wallpaper", "Paintings 1", "Paintings 2" };
        static int shopCounter = 0;
        static string currentShop = shopNames[shopCounter];
        static int npcid = NPCID.Painter;

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
            animationType = NPCID.Painter;
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            return true;
        }


        public override string TownNPCName()
        {
            return "Marbles";
        }

        public override string GetChat()
        {
            return Utils.dialog(new string[] { "I gotta' fresh load of white paint. Want some? :)" ,
                "All my paint is real good, I promise. ;)",
                Utils.dialogGift(npc, "Here, take this, it was given to me by my old grand father. Hope you make good use of it.", "Painting these walls day and night..", !Main.hardMode, 1, ItemID.PainterPaintballGun, 50000),
                Utils.isNPCHere(NPCID.PartyGirl) ? "Can you please tell " + Utils.getNPCName(NPCID.PartyGirl) + " to stop decorating my house!" : "I wonder where that party girl is at.",
                Utils.dialogGift(npc, "Have some free paint friend!", "Paint is the only thing I dream about at night.", true, 1, ItemID.RedPaint, 0),
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
            switch (currentShop) {
                case "Paintings 2":
                    shop.item[nextSlot++].SetDefaults(ItemID.TheDestroyer);
                    shop.item[nextSlot++].SetDefaults(ItemID.Dryadisque);
                    shop.item[nextSlot++].SetDefaults(ItemID.TheEyeSeestheEnd);
                    shop.item[nextSlot++].SetDefaults(ItemID.FacingtheCerebralMastermind);
                    shop.item[nextSlot++].SetDefaults(ItemID.GloryoftheFire);
                    shop.item[nextSlot++].SetDefaults(ItemID.GoblinsPlayingPoker);
                    shop.item[nextSlot++].SetDefaults(ItemID.GreatWave);
                    shop.item[nextSlot++].SetDefaults(ItemID.TheGuardiansGaze);
                    shop.item[nextSlot++].SetDefaults(ItemID.TheHangedMan);
                    shop.item[nextSlot++].SetDefaults(ItemID.Impact);
                    shop.item[nextSlot++].SetDefaults(ItemID.ThePersistencyofEyes);
                    shop.item[nextSlot++].SetDefaults(ItemID.PoweredbyBirds);
                    shop.item[nextSlot++].SetDefaults(ItemID.TheScreamer);
                    shop.item[nextSlot++].SetDefaults(ItemID.SkellingtonJSkellingsworth);
                    shop.item[nextSlot++].SetDefaults(ItemID.SparkyPainting);
                    shop.item[nextSlot++].SetDefaults(ItemID.SomethingEvilisWatchingYou);
                    shop.item[nextSlot++].SetDefaults(ItemID.StarryNight);
                    shop.item[nextSlot++].SetDefaults(ItemID.TrioSuperHeroes);
                    shop.item[nextSlot++].SetDefaults(ItemID.TheTwinsHaveAwoken);
                    shop.item[nextSlot++].SetDefaults(ItemID.UnicornCrossingtheHallows);
                    shop.item[nextSlot++].SetDefaults(ItemID.DarkSoulReaper);
                    shop.item[nextSlot++].SetDefaults(ItemID.Darkness);
                    shop.item[nextSlot++].SetDefaults(ItemID.DemonsEye);
                    shop.item[nextSlot++].SetDefaults(ItemID.FlowingMagma);
                    shop.item[nextSlot++].SetDefaults(ItemID.HandEarth);
                    shop.item[nextSlot++].SetDefaults(ItemID.ImpFace);
                    shop.item[nextSlot++].SetDefaults(ItemID.LakeofFire);
                    shop.item[nextSlot++].SetDefaults(ItemID.LivingGore);
                    shop.item[nextSlot++].SetDefaults(ItemID.OminousPresence);
                    shop.item[nextSlot++].SetDefaults(ItemID.ShiningMoon);
                    shop.item[nextSlot++].SetDefaults(ItemID.Skelehead);
                    shop.item[nextSlot++].SetDefaults(ItemID.TrappedGhost);
                    shop.item[nextSlot++].SetDefaults(ItemID.BitterHarvest);
                    shop.item[nextSlot++].SetDefaults(ItemID.BloodMoonCountess);
                    shop.item[nextSlot++].SetDefaults(ItemID.HallowsEve);
                    shop.item[nextSlot++].SetDefaults(ItemID.JackingSkeletron);
                    shop.item[nextSlot++].SetDefaults(ItemID.MorbidCuriosity);
                    shop.item[nextSlot++].SetDefaults(ItemID.PillaginMePixels);
                    break;
                case "Paintings 1":
                    shop.item[nextSlot++].SetDefaults(ItemID.ColdWatersintheWhiteLand);
                    shop.item[nextSlot++].SetDefaults(ItemID.Daylight);
                    shop.item[nextSlot++].SetDefaults(ItemID.DeadlandComesAlive);
                    shop.item[nextSlot++].SetDefaults(ItemID.DoNotStepontheGrass);
                    shop.item[nextSlot++].SetDefaults(ItemID.EvilPresence);
                    shop.item[nextSlot++].SetDefaults(ItemID.FirstEncounter);
                    shop.item[nextSlot++].SetDefaults(ItemID.GoodMorning);
                    shop.item[nextSlot++].SetDefaults(ItemID.TheLandofDeceivingLooks);
                    shop.item[nextSlot++].SetDefaults(ItemID.LightlessChasms);
                    shop.item[nextSlot++].SetDefaults(ItemID.PlaceAbovetheClouds);
                    shop.item[nextSlot++].SetDefaults(ItemID.SecretoftheSands);
                    shop.item[nextSlot++].SetDefaults(ItemID.SkyGuardian);
                    shop.item[nextSlot++].SetDefaults(ItemID.ThroughtheWindow);
                    shop.item[nextSlot++].SetDefaults(ItemID.UndergroundReward);
                    shop.item[nextSlot++].SetDefaults(ItemID.PaintingAcorns);
                    shop.item[nextSlot++].SetDefaults(ItemID.PaintingCastleMarsberg);
                    shop.item[nextSlot++].SetDefaults(ItemID.PaintingColdSnap);
                    shop.item[nextSlot++].SetDefaults(ItemID.PaintingMartiaLisa);
                    shop.item[nextSlot++].SetDefaults(ItemID.PaintingTheSeason);
                    shop.item[nextSlot++].SetDefaults(ItemID.PaintingSnowfellas);
                    shop.item[nextSlot++].SetDefaults(ItemID.PaintingTheTruthIsUpThere);
                    shop.item[nextSlot++].SetDefaults(ItemID.AmericanExplosive);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrownoDevoursHisLunch);
                    shop.item[nextSlot++].SetDefaults(ItemID.Discover);
                    shop.item[nextSlot++].SetDefaults(ItemID.FatherofSomeone);
                    shop.item[nextSlot++].SetDefaults(ItemID.FindingGold);
                    shop.item[nextSlot++].SetDefaults(ItemID.GloriousNight);
                    shop.item[nextSlot++].SetDefaults(ItemID.GuidePicasso);
                    shop.item[nextSlot++].SetDefaults(ItemID.Land);
                    shop.item[nextSlot++].SetDefaults(ItemID.TheMerchant);
                    shop.item[nextSlot++].SetDefaults(ItemID.NurseLisa);
                    shop.item[nextSlot++].SetDefaults(ItemID.OldMiner);
                    shop.item[nextSlot++].SetDefaults(ItemID.RareEnchantment);
                    shop.item[nextSlot++].SetDefaults(ItemID.Sunflowers);
                    shop.item[nextSlot++].SetDefaults(ItemID.TerrarianGothic);
                    shop.item[nextSlot++].SetDefaults(ItemID.Waldo);
                    shop.item[nextSlot++].SetDefaults(ItemID.BloodMoonRising);
                    shop.item[nextSlot++].SetDefaults(ItemID.BoneWarp);
                    shop.item[nextSlot++].SetDefaults(ItemID.TheCreationoftheGuide);
                    shop.item[nextSlot++].SetDefaults(ItemID.TheCursedMan);
                    break;
                case "Wallpaper":
                    shop.item[nextSlot++].SetDefaults(ItemID.BluegreenWallpaper);
                    shop.item[nextSlot++].SetDefaults(ItemID.BubbleWallpaper);
                    shop.item[nextSlot++].SetDefaults(ItemID.CandyCaneWallpaper);
                    shop.item[nextSlot++].SetDefaults(ItemID.ChristmasTreeWallpaper);
                    shop.item[nextSlot++].SetDefaults(ItemID.CopperPipeWallpaper);
                    shop.item[nextSlot++].SetDefaults(ItemID.DuckyWallpaper);
                    shop.item[nextSlot++].SetDefaults(ItemID.FancyGreyWallpaper);
                    shop.item[nextSlot++].SetDefaults(ItemID.FestiveWallpaper);
                    shop.item[nextSlot++].SetDefaults(ItemID.GrinchFingerWallpaper);
                    shop.item[nextSlot++].SetDefaults(ItemID.IceFloeWallpaper);
                    shop.item[nextSlot++].SetDefaults(ItemID.KrampusHornWallpaper);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicWallpaper);
                    shop.item[nextSlot++].SetDefaults(ItemID.OrnamentWallpaper);
                    shop.item[nextSlot++].SetDefaults(ItemID.PurpleRainWallpaper);
                    shop.item[nextSlot++].SetDefaults(ItemID.RainbowWallpaper);
                    shop.item[nextSlot++].SetDefaults(ItemID.SnowflakeWallpaper);
                    shop.item[nextSlot++].SetDefaults(ItemID.SparkleStoneWallpaper);
                    shop.item[nextSlot++].SetDefaults(ItemID.SquigglesWallpaper);
                    shop.item[nextSlot++].SetDefaults(ItemID.StarlitHeavenWallpaper);
                    shop.item[nextSlot++].SetDefaults(ItemID.StarsWallpaper);
                    break;
                case "Paint":
                    shop.item[nextSlot++].SetDefaults(ItemID.BlackPaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.GrayPaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.GreenPaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.LimePaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.NegativePaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.OrangePaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.PinkPaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.PurplePaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.RedPaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.ShadowPaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.SkyBluePaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.TealPaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.VioletPaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.WhitePaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.YellowPaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.BluePaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.BrownPaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.CyanPaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.DeepBluePaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.DeepCyanPaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.DeepGreenPaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.DeepLimePaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.DeepOrangePaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.DeepPinkPaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.DeepPurplePaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.DeepRedPaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.DeepSkyBluePaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.DeepTealPaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.DeepVioletPaint);
                    shop.item[nextSlot++].SetDefaults(ItemID.DeepYellowPaint);
                    break;
                default:
                    shop.item[nextSlot++].SetDefaults(ItemID.Paintbrush);
                    shop.item[nextSlot++].SetDefaults(ItemID.PaintRoller);
                    shop.item[nextSlot++].SetDefaults(ItemID.PaintScraper);
                    shop.item[nextSlot].SetDefaults(ItemID.BuilderPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.Toolbelt);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.Toolbox);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.PaintSprayer);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.ExtendoGrip);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.PortableCementMixer);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.BrickLayer);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
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
