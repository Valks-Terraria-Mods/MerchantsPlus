using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    internal class ShopPainter : Shop
    {
        public ShopPainter(bool merchant, params string[] shops) : base(merchant, shops)
        {
        }

        public override void OpenShop(string shop)
        {
            base.OpenShop(shop);

            if (shop == "Paintings II")
            {
                AddItem(ItemID.TheDestroyer);
                AddItem(ItemID.Dryadisque);
                AddItem(ItemID.TheEyeSeestheEnd);
                AddItem(ItemID.FacingtheCerebralMastermind);
                AddItem(ItemID.GloryoftheFire);
                AddItem(ItemID.GoblinsPlayingPoker);
                AddItem(ItemID.GreatWave);
                AddItem(ItemID.TheGuardiansGaze);
                AddItem(ItemID.TheHangedMan);
                AddItem(ItemID.Impact);
                AddItem(ItemID.ThePersistencyofEyes);
                AddItem(ItemID.PoweredbyBirds);
                AddItem(ItemID.TheScreamer);
                AddItem(ItemID.SkellingtonJSkellingsworth);
                AddItem(ItemID.SparkyPainting);
                AddItem(ItemID.SomethingEvilisWatchingYou);
                AddItem(ItemID.StarryNight);
                AddItem(ItemID.TrioSuperHeroes);
                AddItem(ItemID.TheTwinsHaveAwoken);
                AddItem(ItemID.UnicornCrossingtheHallows);
                AddItem(ItemID.DarkSoulReaper);
                AddItem(ItemID.Darkness);
                AddItem(ItemID.DemonsEye);
                AddItem(ItemID.FlowingMagma);
                AddItem(ItemID.HandEarth);
                AddItem(ItemID.ImpFace);
                AddItem(ItemID.LakeofFire);
                AddItem(ItemID.LivingGore);
                AddItem(ItemID.OminousPresence);
                AddItem(ItemID.ShiningMoon);
                AddItem(ItemID.Skelehead);
                AddItem(ItemID.TrappedGhost);
                AddItem(ItemID.BitterHarvest);
                AddItem(ItemID.BloodMoonCountess);
                AddItem(ItemID.HallowsEve);
                AddItem(ItemID.JackingSkeletron);
                AddItem(ItemID.MorbidCuriosity);
                AddItem(ItemID.PillaginMePixels);
                return;
            }

            if (shop == "Paintings I")
            {
                AddItem(ItemID.ColdWatersintheWhiteLand);
                AddItem(ItemID.Daylight);
                AddItem(ItemID.DeadlandComesAlive);
                AddItem(ItemID.DoNotStepontheGrass);
                AddItem(ItemID.EvilPresence);
                AddItem(ItemID.FirstEncounter);
                AddItem(ItemID.GoodMorning);
                AddItem(ItemID.TheLandofDeceivingLooks);
                AddItem(ItemID.LightlessChasms);
                AddItem(ItemID.PlaceAbovetheClouds);
                AddItem(ItemID.SecretoftheSands);
                AddItem(ItemID.SkyGuardian);
                AddItem(ItemID.ThroughtheWindow);
                AddItem(ItemID.UndergroundReward);
                AddItem(ItemID.PaintingAcorns);
                AddItem(ItemID.PaintingCastleMarsberg);
                AddItem(ItemID.PaintingColdSnap);
                AddItem(ItemID.PaintingMartiaLisa);
                AddItem(ItemID.PaintingTheSeason);
                AddItem(ItemID.PaintingSnowfellas);
                AddItem(ItemID.PaintingTheTruthIsUpThere);
                AddItem(ItemID.AmericanExplosive);
                AddItem(ItemID.CrownoDevoursHisLunch);
                AddItem(ItemID.Discover);
                AddItem(ItemID.FatherofSomeone);
                AddItem(ItemID.FindingGold);
                AddItem(ItemID.GloriousNight);
                AddItem(ItemID.GuidePicasso);
                AddItem(ItemID.Land);
                AddItem(ItemID.TheMerchant);
                AddItem(ItemID.NurseLisa);
                AddItem(ItemID.OldMiner);
                AddItem(ItemID.RareEnchantment);
                AddItem(ItemID.Sunflowers);
                AddItem(ItemID.TerrarianGothic);
                AddItem(ItemID.Waldo);
                AddItem(ItemID.BloodMoonRising);
                AddItem(ItemID.BoneWarp);
                AddItem(ItemID.TheCreationoftheGuide);
                AddItem(ItemID.TheCursedMan);
                return;
            }

            if (shop == "Wallpaper")
            {
                AddItem(ItemID.BluegreenWallpaper);
                AddItem(ItemID.BubbleWallpaper);
                AddItem(ItemID.CandyCaneWallpaper);
                AddItem(ItemID.ChristmasTreeWallpaper);
                AddItem(ItemID.CopperPipeWallpaper);
                AddItem(ItemID.DuckyWallpaper);
                AddItem(ItemID.FancyGreyWallpaper);
                AddItem(ItemID.FestiveWallpaper);
                AddItem(ItemID.GrinchFingerWallpaper);
                AddItem(ItemID.IceFloeWallpaper);
                AddItem(ItemID.KrampusHornWallpaper);
                AddItem(ItemID.MusicWallpaper);
                AddItem(ItemID.OrnamentWallpaper);
                AddItem(ItemID.PurpleRainWallpaper);
                AddItem(ItemID.RainbowWallpaper);
                AddItem(ItemID.SnowflakeWallpaper);
                AddItem(ItemID.SparkleStoneWallpaper);
                AddItem(ItemID.SquigglesWallpaper);
                AddItem(ItemID.StarlitHeavenWallpaper);
                AddItem(ItemID.StarsWallpaper);
                return;
            }

            if (shop == "Paint")
            {
                AddItem(ItemID.BlackPaint);
                AddItem(ItemID.GrayPaint);
                AddItem(ItemID.GreenPaint);
                AddItem(ItemID.LimePaint);
                AddItem(ItemID.NegativePaint);
                AddItem(ItemID.OrangePaint);
                AddItem(ItemID.PinkPaint);
                AddItem(ItemID.PurplePaint);
                AddItem(ItemID.RedPaint);
                AddItem(ItemID.ShadowPaint);
                AddItem(ItemID.SkyBluePaint);
                AddItem(ItemID.TealPaint);
                AddItem(ItemID.VioletPaint);
                AddItem(ItemID.WhitePaint);
                AddItem(ItemID.YellowPaint);
                AddItem(ItemID.BluePaint);
                AddItem(ItemID.BrownPaint);
                AddItem(ItemID.CyanPaint);
                AddItem(ItemID.DeepBluePaint);
                AddItem(ItemID.DeepCyanPaint);
                AddItem(ItemID.DeepGreenPaint);
                AddItem(ItemID.DeepLimePaint);
                AddItem(ItemID.DeepOrangePaint);
                AddItem(ItemID.DeepPinkPaint);
                AddItem(ItemID.DeepPurplePaint);
                AddItem(ItemID.DeepRedPaint);
                AddItem(ItemID.DeepSkyBluePaint);
                AddItem(ItemID.DeepTealPaint);
                AddItem(ItemID.DeepVioletPaint);
                AddItem(ItemID.DeepYellowPaint);
                return;
            }

            if (shop == "Tools")
            {
                AddItem(ItemID.Paintbrush);
                AddItem(ItemID.PaintRoller);
                AddItem(ItemID.PaintScraper);
                AddItem(ItemID.BuilderPotion, Utils.UniversalPotionCost);
                AddItem(ItemID.Toolbelt, Utils.UniversalAccessoryCost);
                AddItem(ItemID.Toolbox, Utils.UniversalAccessoryCost);
                
                AddItem(ItemID.PaintSprayer, Utils.UniversalAccessoryCost);
                
                AddItem(ItemID.ExtendoGrip, Utils.UniversalAccessoryCost);
                
                AddItem(ItemID.PortableCementMixer, Utils.UniversalAccessoryCost);
                
                AddItem(ItemID.BrickLayer, Utils.UniversalAccessoryCost);
                
                return;
            }

            // Default Shop
            Inv.SetupShop(15);
        }
    }
}