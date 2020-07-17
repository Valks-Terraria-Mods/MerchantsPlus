using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    internal class ShopGoblinTinkerer
    {
        private Chest shop;
        private int nextSlot;

        public ShopGoblinTinkerer(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            int progression = Utils.Progression();

            if (currentShop == "Miscellaneous")
            {
                shop.item[nextSlot].SetDefaults(ItemID.FlowerBoots);
                shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;

                if (NPC.downedPirates)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.GoldRing);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.DiscountCard);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.LuckyCoin);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                
                if (Utils.MultiKills(new short[] { NPCID.BlueJellyfish, NPCID.PinkJellyfish, NPCID.GreenJellyfish }) > 100)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.JellyfishNecklace);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (NPC.downedMechBoss1)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.NeptunesShell);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                return;
            }

            if (currentShop == "Special") {
                if (NPC.downedSlimeKing) { shop.item[nextSlot].SetDefaults(ItemID.RoyalGel); shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost; }
                if (NPC.downedBoss1) { shop.item[nextSlot].SetDefaults(ItemID.EoCShield); shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost; }
                if (NPC.downedBoss2)
                {
                    if (WorldGen.crimson)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.BrainOfConfusion);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    else
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.WormScarf);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                }
                if (NPC.downedQueenBee)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.HiveBackpack);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                if (NPC.downedPlantBoss)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.SporeSac);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                if (NPC.downedGolemBoss)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.ShinyStone);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                if (NPC.downedMoonlord)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.GravityGlobe);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                return;
            }

            if (currentShop == "Defensive") {
                if (NPC.downedBoss3)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.CobaltShield);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                if (Utils.Kills(NPCID.Zombie) > 100)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.Shackle);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                if (Utils.Kills(NPCID.BigMimicCrimson) > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.FleshKnuckles);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                if (Utils.Kills(NPCID.IceTortoise) > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.FrozenTurtleShell);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                return;
            }

            if (currentShop == "Immunity") {
                if (Main.hardMode)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.HandWarmer);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;

                    if (Utils.MultiKills(new short[] { NPCID.RustyArmoredBonesAxe, NPCID.Werewolf, NPCID.AnglerFish }) > 0)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.AdhesiveBandage);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (Utils.MultiKills(new short[] { NPCID.ArmoredSkeleton, NPCID.BlueArmoredBones }) > 0)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ArmorPolish);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (Utils.Kills(NPCID.ToxicSludge) > 0)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.Bezoar);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (Utils.Kills(NPCID.CorruptSlime) > 0)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.Blindfold);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }

                    if (Utils.MultiKills(new short[] { NPCID.Pixie, NPCID.DarkMummy }) > 0)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.Megaphone);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (Utils.Kills(NPCID.Mimic) > 2)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.CrossNecklace);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (Utils.Kills(NPCID.Pixie) > 10)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.FastClock);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    
                    if (Main.hardMode)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ObsidianRose);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }

                    if (Utils.Kills(NPCID.Medusa) > 0)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PocketMirror);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }

                    if (Utils.Kills(NPCID.LightMummy) > 0)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.TrifoldMap);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }

                    if (Utils.Kills(NPCID.Corruptor) > 0)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.Vitamins);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (Utils.Kills(NPCID.CursedSkull) > 0)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.Nazar);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                }

                return;
            }

            if (currentShop == "Combat") {
                shop.item[nextSlot].SetDefaults(ItemID.SharkToothNecklace);
                shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                if (progression > 0) {
                    shop.item[nextSlot].SetDefaults(ItemID.FeralClaws);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > (int) Utils.Progress.BRAIN_OF_CTHULU)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.PanicNecklace);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > (int)Utils.Progress.QUEEN_BEE) {
                    shop.item[nextSlot].SetDefaults(ItemID.HoneyComb);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > 8) {
                    shop.item[nextSlot].SetDefaults(ItemID.MagicQuiver);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                if (progression > 9) {
                    shop.item[nextSlot].SetDefaults(ItemID.MoonCharm);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                if (progression > 10)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.MoonStone);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                if (progression > 11)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.SunStone);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                if (progression > 12)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.MagmaStone);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.StarCloak);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                if (progression > 13)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.EyeoftheGolem);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > (int)Utils.Progress.PLANT_BOSS)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.BlackBelt);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                
                if (progression > 15)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.ApprenticeScarf);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    
                }
                if (progression > 16)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.PutridScent);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > 17) {
                    shop.item[nextSlot].SetDefaults(ItemID.HerculesBeetle);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > 18) {
                    shop.item[nextSlot].SetDefaults(ItemID.NecromanticScroll);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > 19) {
                    shop.item[nextSlot].SetDefaults(ItemID.PygmyNecklace);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > 20) {
                    shop.item[nextSlot].SetDefaults(ItemID.PaladinsShield);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > 21) {
                    shop.item[nextSlot].SetDefaults(ItemID.SquireShield);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > 22)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.HuntressBuckler);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > 23)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.MonkBelt);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > 24) {
                    shop.item[nextSlot].SetDefaults(ItemID.TitanGlove);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                return;
            }

            if (currentShop == "Health and Mana")
            {
                shop.item[nextSlot].SetDefaults(ItemID.NaturesGift);
                shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                if (NPC.downedBoss2)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.BandofStarpower);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.BandofRegeneration);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                if (progression > 4)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.CelestialMagnet);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                if (Main.hardMode)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.PhilosophersStone);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                return;
            }

            if (currentShop == "Informational") {
                if (WorldGen.goldBar > 0) shop.item[nextSlot].SetDefaults(ItemID.GoldWatch); else shop.item[nextSlot].SetDefaults(ItemID.PlatinumWatch);
                if (progression > 0) {
                    shop.item[nextSlot].SetDefaults(ItemID.DepthMeter);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                if (progression > 1)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.Compass);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                if (progression > 2)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.Stopwatch);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                if (progression > 3)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.TallyCounter);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                if (progression > 4)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.LifeformAnalyzer);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                if (progression > 5)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.DPSMeter);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                if (progression > 6)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.MetalDetector);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                if (progression > 7)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.Radar);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                if (progression > 8)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.Ruler);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                if (progression > 9)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.MechanicalLens);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                if (progression > 10)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.LaserRuler);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }
                return;
            }

            if (currentShop == "Movement") {
                shop.item[nextSlot].SetDefaults(ItemID.WaterWalkingBoots);
                shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;

                if (progression > 0) {
                    shop.item[nextSlot].SetDefaults(ItemID.HermesBoots);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > 1) {
                    shop.item[nextSlot].SetDefaults(ItemID.CloudinaBottle);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.SandstorminaBottle);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.TsunamiInABottle);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > 2) {
                    shop.item[nextSlot].SetDefaults(ItemID.Aglet);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > 3)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.AnkletoftheWind);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > 4)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.RocketBoots);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > 5)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.IceSkates);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > 6)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.Flipper);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > 7) {
                    shop.item[nextSlot].SetDefaults(ItemID.ClimbingClaws);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > 8) {
                    shop.item[nextSlot].SetDefaults(ItemID.ShoeSpikes);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > 9)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.DivingHelmet);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > 10)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.ShinyRedBalloon);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > 11)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.FlyingCarpet);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > 12)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.LavaCharm);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > 13)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.LuckyHorseshoe);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                if (progression > 14)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.Tabi);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                }

                return;
            }

            // Default Shop
            shop.SetupShop(6);
        }
    }
}