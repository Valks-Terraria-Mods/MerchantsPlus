using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    internal class ShopAngler
    {
        private Chest shop;
        private int nextSlot;

        public ShopAngler(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            int progression = Utils.Progression();

            if (currentShop == "Buffs")
            {
                shop.item[nextSlot].SetDefaults(ItemID.FlipperPotion);
                shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;

                if (progression > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.WaterWalkingPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                }

                if (progression > 1)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.GillsPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                }

                if (progression > 2)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.Sashimi);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.CookedFish);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.CookedShrimp);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                }

                if (progression > 3)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.SonarPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                }

                if (progression > 4)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.CratePotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.FishingPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                }

                return;
            }

            if (currentShop == "Crates")
            {
                shop.item[nextSlot].SetDefaults(ItemID.WoodenCrate);
                shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 0, 10);

                if (progression > 0)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.IronCrate);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 0, 15);
                }

                if (progression > 1)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.JungleFishingCrate);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 0, 10);
                    shop.item[nextSlot].SetDefaults(ItemID.FloatingIslandFishingCrate);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 0, 10);
                }

                if (progression > 2)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.CorruptFishingCrate);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 0, 10);
                    shop.item[nextSlot].SetDefaults(ItemID.CrimsonFishingCrate);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 0, 10);
                }

                if (progression > 3)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.DungeonFishingCrate);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 0, 25);
                }

                if (progression > 4)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.GoldenCrate);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 0, 30);
                }

                if (progression > 5)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.HallowedFishingCrate);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 0, 25);
                }
                return;
            }

            if (currentShop == "Bait")
            {
                // 5% Bait Power
                shop.item[nextSlot].SetDefaults(ItemID.MonarchButterfly);
                shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 10);

                if (progression > 0)
                {
                    // 10% Bait Power
                    shop.item[nextSlot].SetDefaults(ItemID.SulphurButterfly);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 20);
                    shop.item[nextSlot].SetDefaults(ItemID.Scorpion);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 20);
                    shop.item[nextSlot].SetDefaults(ItemID.Snail);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 20);
                    shop.item[nextSlot].SetDefaults(ItemID.Grasshopper);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 20);
                }

                if (progression > 1)
                {
                    // 15% Bait Power
                    shop.item[nextSlot].SetDefaults(ItemID.ApprenticeBait);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 30);
                    shop.item[nextSlot].SetDefaults(ItemID.ZebraSwallowtailButterfly);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 30);
                    shop.item[nextSlot].SetDefaults(ItemID.BlackScorpion);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 30);
                    shop.item[nextSlot].SetDefaults(ItemID.GlowingSnail);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 30);
                    shop.item[nextSlot].SetDefaults(ItemID.Grubby);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 30);
                }

                if (progression > 2)
                {
                    // 20% Bait Power
                    shop.item[nextSlot].SetDefaults(ItemID.Firefly);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 40);
                    shop.item[nextSlot].SetDefaults(ItemID.UlyssesButterfly);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 40);
                    shop.item[nextSlot].SetDefaults(ItemID.BlueJellyfish);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 40);
                    shop.item[nextSlot].SetDefaults(ItemID.GreenJellyfish);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 40);
                    shop.item[nextSlot].SetDefaults(ItemID.PinkJellyfish);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 40);
                }

                if (progression > 3)
                {
                    // 25% Bait Power
                    shop.item[nextSlot].SetDefaults(ItemID.JuliaButterfly);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 50);
                    shop.item[nextSlot].SetDefaults(ItemID.Worm);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 50);
                    shop.item[nextSlot].SetDefaults(ItemID.Sluggy);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 50);
                }

                if (progression > 4)
                {
                    // 30% Bait Power
                    shop.item[nextSlot].SetDefaults(ItemID.JourneymanBait);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 60);
                    shop.item[nextSlot].SetDefaults(ItemID.RedAdmiralButterfly);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 60);
                }

                if (progression > 5)
                {
                    // 35% Bait Power
                    shop.item[nextSlot].SetDefaults(ItemID.PurpleEmperorButterfly);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 70);
                    shop.item[nextSlot].SetDefaults(ItemID.LightningBug);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 70);
                    shop.item[nextSlot].SetDefaults(ItemID.EnchantedNightcrawler);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 70);
                }

                if (progression > 6)
                {
                    // 40% Bait Power
                    shop.item[nextSlot].SetDefaults(ItemID.Buggy);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 80);
                }

                if (progression > 7)
                {
                    // 50% Bait Power
                    shop.item[nextSlot].SetDefaults(ItemID.MasterBait);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 0, 1);
                    shop.item[nextSlot].SetDefaults(ItemID.TreeNymphButterfly);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 0, 1);
                    shop.item[nextSlot].SetDefaults(ItemID.GoldButterfly);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 0, 1);
                    shop.item[nextSlot].SetDefaults(ItemID.GoldWorm);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 0, 1);
                    shop.item[nextSlot].SetDefaults(ItemID.GoldGrasshopper);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 0, 1);
                }

                if (progression > 8)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.TruffleWorm);
                    shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 0, 0, 1);
                }
                return;
            }

            // Default Shop
            ShopFishingPole(shop, ref nextSlot, progression);

            if (progression > 0)
            {
                shop.item[nextSlot].SetDefaults(ItemID.AnglerPants);
                shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 0, 15);
            }

            if (progression > 1)
            {
                shop.item[nextSlot].SetDefaults(ItemID.AnglerVest);
                shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 0, 15);
            }

            if (progression > 2)
            {
                shop.item[nextSlot].SetDefaults(ItemID.AnglerHat);
                shop.item[nextSlot++].shopCustomPrice = Utils.Coins(0, 0, 15);
            }

            if (progression > 3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.FishFinder);
                shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
            }

            if (progression > 4)
            {
                shop.item[nextSlot].SetDefaults(ItemID.AnglerEarring);
                shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
            }

            if (progression > 5)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Sextant);
                shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
            }

            if (progression > 6)
            {
                shop.item[nextSlot].SetDefaults(ItemID.WeatherRadio);
                shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
            }

            if (progression > 7)
            {
                shop.item[nextSlot].SetDefaults(ItemID.FishermansGuide);
                shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
            }

            if (progression > 8)
            {
                shop.item[nextSlot].SetDefaults(ItemID.TackleBox);
                shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
            }

            if (progression > 9)
            {
                shop.item[nextSlot].SetDefaults(ItemID.HighTestFishingLine);
                shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
            }
        }

        private void ShopFishingPole(Chest shop, ref int nextSlot, int progression)
        {
            shop.item[nextSlot].SetDefaults(ItemID.WoodFishingPole);
            shop.item[nextSlot].shopCustomPrice = Utils.Coins(0, 10);

            if (progression > 0)
            {
                shop.item[nextSlot].SetDefaults(ItemID.ReinforcedFishingPole);
                shop.item[nextSlot].shopCustomPrice = Utils.Coins(0, 25);
            }
            if (progression > 1)
            {
                shop.item[nextSlot].SetDefaults(ItemID.FisherofSouls);
                shop.item[nextSlot].shopCustomPrice = Utils.Coins(0, 0, 1);
            }
            if (progression > 2)
            {
                shop.item[nextSlot].SetDefaults(ItemID.FiberglassFishingPole);
                shop.item[nextSlot].shopCustomPrice = Utils.Coins(0, 0, 10);
            }
            if (progression > 3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.MechanicsRod);
                shop.item[nextSlot].shopCustomPrice = Utils.Coins(0, 0, 25);
            }
            if (progression > 4)
            {
                shop.item[nextSlot].SetDefaults(ItemID.SittingDucksFishingRod);
                shop.item[nextSlot].shopCustomPrice = Utils.Coins(0, 0, 50);
            }

            if (progression > 5)
            {
                shop.item[nextSlot].SetDefaults(ItemID.HotlineFishingHook);
                shop.item[nextSlot].shopCustomPrice = Utils.Coins(0, 0, 0, 1);
            }

            if (progression > 6)
            {
                shop.item[nextSlot].SetDefaults(ItemID.GoldenFishingRod);
                shop.item[nextSlot].shopCustomPrice = Utils.Coins(0, 0, 0, 2);
            }
            nextSlot++;
        }
    }
}