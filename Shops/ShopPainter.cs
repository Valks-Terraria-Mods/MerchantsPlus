using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    class ShopPainter
    {
        private Chest shop;
        private int nextSlot;

        public ShopPainter(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            switch (currentShop)
            {
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
                case "Tools":
                    shop.item[nextSlot++].SetDefaults(ItemID.Paintbrush);
                    shop.item[nextSlot++].SetDefaults(ItemID.PaintRoller);
                    shop.item[nextSlot++].SetDefaults(ItemID.PaintScraper);
                    shop.item[nextSlot++].SetDefaults(ItemID.BuilderPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot++].SetDefaults(ItemID.Toolbelt);
                    shop.item[nextSlot++].SetDefaults(ItemID.Toolbox);
                    shop.item[nextSlot++].SetDefaults(ItemID.PaintSprayer);
                    shop.item[nextSlot++].SetDefaults(ItemID.ExtendoGrip);
                    shop.item[nextSlot++].SetDefaults(ItemID.PortableCementMixer);
                    shop.item[nextSlot++].SetDefaults(ItemID.BrickLayer);
                    break;
                default:
                    shop.SetupShop(15);
                    break;
            }
        }
    }
}
