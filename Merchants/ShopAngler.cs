using Terraria.ID;

namespace MerchantsPlus.Merchants
{
    internal class ShopAngler : Shop
    {
        public ShopAngler(bool merchant, params string[] shops) : base(merchant, shops)
        {
        }

        public override void OpenShop(string shop)
        {
            base.OpenShop(shop);

            int progression = Utils.Progression();

            if (shop == "Buffs")
            {
                AddItem(ItemID.FlipperPotion, Utils.UniversalPotionCost);

                if (progression > 0)
                {
                    AddItem(ItemID.WaterWalkingPotion, Utils.UniversalPotionCost);
                }

                if (progression > 1)
                {
                    AddItem(ItemID.GillsPotion, Utils.UniversalPotionCost);
                }

                if (progression > 2)
                {
                    AddItem(ItemID.Sashimi, Utils.UniversalPotionCost);
                    AddItem(ItemID.CookedFish, Utils.UniversalPotionCost);
                    AddItem(ItemID.CookedShrimp, Utils.UniversalPotionCost);
                }

                if (progression > 3)
                {
                    AddItem(ItemID.SonarPotion, Utils.UniversalPotionCost);
                }

                if (progression > 4)
                {
                    AddItem(ItemID.CratePotion, Utils.UniversalPotionCost);
                    AddItem(ItemID.FishingPotion, Utils.UniversalPotionCost);
                }

                return;
            }

            if (shop == "Crates")
            {
                AddItem(ItemID.WoodenCrate, Utils.Coins(0, 0, 10));

                if (progression > 0)
                {
                    AddItem(ItemID.IronCrate, Utils.Coins(0, 0, 15));
                }

                if (progression > 1)
                {
                    AddItem(ItemID.JungleFishingCrate, Utils.Coins(0, 0, 10));
                    AddItem(ItemID.FloatingIslandFishingCrate, Utils.Coins(0, 0, 10));
                }

                if (progression > 2)
                {
                    AddItem(ItemID.CorruptFishingCrate, Utils.Coins(0, 0, 10));
                    AddItem(ItemID.CrimsonFishingCrate, Utils.Coins(0, 0, 10));
                }

                if (progression > 3)
                {
                    AddItem(ItemID.DungeonFishingCrate, Utils.Coins(0, 0, 25));
                }

                if (progression > 4)
                {
                    AddItem(ItemID.GoldenCrate, Utils.Coins(0, 0, 30));
                }

                if (progression > 5)
                {
                    AddItem(ItemID.HallowedFishingCrate, Utils.Coins(0, 0, 30));
                }
                return;
            }

            if (shop == "Bait")
            {
                // 5% Bait Power
                AddItem(ItemID.MonarchButterfly, Utils.Coins(0, 10));

                if (progression > 0)
                {
                    // 10% Bait Power
                    AddItem(ItemID.SulphurButterfly, Utils.Coins(0, 20));
                    AddItem(ItemID.Scorpion, Utils.Coins(0, 20));
                    AddItem(ItemID.Snail, Utils.Coins(0, 20));
                    AddItem(ItemID.Grasshopper, Utils.Coins(0, 20));
                }

                if (progression > 1)
                {
                    // 15% Bait Power
                    AddItem(ItemID.ApprenticeBait, Utils.Coins(0, 30));
                    AddItem(ItemID.ZebraSwallowtailButterfly, Utils.Coins(0, 30));
                    AddItem(ItemID.BlackScorpion, Utils.Coins(0, 30));
                    AddItem(ItemID.GlowingSnail, Utils.Coins(0, 30));
                    AddItem(ItemID.Grubby, Utils.Coins(0, 30));
                }

                if (progression > 2)
                {
                    // 20% Bait Power
                    AddItem(ItemID.Firefly, Utils.Coins(0, 40));
                    AddItem(ItemID.UlyssesButterfly, Utils.Coins(0, 40));
                    AddItem(ItemID.BlueJellyfish, Utils.Coins(0, 40));
                    AddItem(ItemID.GreenJellyfish, Utils.Coins(0, 40));
                    AddItem(ItemID.PinkJellyfish, Utils.Coins(0, 40));
                }

                if (progression > 3)
                {
                    // 25% Bait Power
                    AddItem(ItemID.JuliaButterfly, Utils.Coins(0, 50));
                    AddItem(ItemID.Worm, Utils.Coins(0, 50));
                    AddItem(ItemID.Sluggy, Utils.Coins(0, 50));
                }

                if (progression > 4)
                {
                    // 30% Bait Power
                    AddItem(ItemID.JourneymanBait, Utils.Coins(0, 60));
                    AddItem(ItemID.RedAdmiralButterfly, Utils.Coins(0, 60));
                }

                if (progression > 5)
                {
                    // 35% Bait Power
                    AddItem(ItemID.PurpleEmperorButterfly, Utils.Coins(0, 70));
                    AddItem(ItemID.LightningBug, Utils.Coins(0, 70));
                    AddItem(ItemID.EnchantedNightcrawler, Utils.Coins(0, 70));
                }

                if (progression > 6)
                {
                    // 40% Bait Power
                    AddItem(ItemID.Buggy, Utils.Coins(0, 80));
                }

                if (progression > 7)
                {
                    // 50% Bait Power
                    AddItem(ItemID.MasterBait, Utils.Coins(0, 0, 1));
                    AddItem(ItemID.TreeNymphButterfly, Utils.Coins(0, 0, 1));
                    AddItem(ItemID.GoldButterfly, Utils.Coins(0, 0, 1));
                    AddItem(ItemID.GoldWorm, Utils.Coins(0, 0, 1));
                    AddItem(ItemID.GoldGrasshopper, Utils.Coins(0, 0, 1));
                }

                if (progression > 8)
                {
                    AddItem(ItemID.TruffleWorm, Utils.Coins(0, 0, 0, 1));
                }
                return;
            }

            // Default Shop
            ShopFishingPole(progression);

            if (progression > 0)
            {
                AddItem(ItemID.AnglerPants, Utils.UniversalAccessoryCost);
            }

            if (progression > 1)
            {
                AddItem(ItemID.AnglerVest, Utils.UniversalAccessoryCost);
            }

            if (progression > 2)
            {
                AddItem(ItemID.AnglerHat, Utils.UniversalAccessoryCost);
            }

            if (progression > 3)
            {
                AddItem(ItemID.FishFinder, Utils.UniversalAccessoryCost);
            }

            if (progression > 4)
            {
                AddItem(ItemID.AnglerEarring, Utils.UniversalAccessoryCost);
            }

            if (progression > 5)
            {
                AddItem(ItemID.Sextant, Utils.UniversalAccessoryCost);
            }

            if (progression > 6)
            {
                AddItem(ItemID.WeatherRadio, Utils.UniversalAccessoryCost);
            }

            if (progression > 7)
            {
                AddItem(ItemID.FishermansGuide, Utils.UniversalAccessoryCost);
            }

            if (progression > 8)
            {
                AddItem(ItemID.TackleBox, Utils.UniversalAccessoryCost);
            }

            if (progression > 9)
            {
                AddItem(ItemID.HighTestFishingLine, Utils.UniversalAccessoryCost);
            }
        }

        private void ShopFishingPole(int progression)
        {
            ReplaceItem(ItemID.WoodFishingPole, Utils.Coins(0, 10));

            if (progression > 0)
            {
                ReplaceItem(ItemID.ReinforcedFishingPole, Utils.Coins(0, 25));
            }
            if (progression > 1)
            {
                ReplaceItem(ItemID.FisherofSouls, Utils.Coins(0, 0, 1));
            }
            if (progression > 2)
            {
                ReplaceItem(ItemID.FiberglassFishingPole, Utils.Coins(0, 0, 10));
            }
            if (progression > 3)
            {
                ReplaceItem(ItemID.MechanicsRod, Utils.Coins(0, 0, 25));
            }
            if (progression > 4)
            {
                ReplaceItem(ItemID.SittingDucksFishingRod, Utils.Coins(0, 0, 50));
            }

            if (progression > 5)
            {
                ReplaceItem(ItemID.HotlineFishingHook, Utils.Coins(0, 0, 0, 1));
            }

            if (progression > 6)
            {
                ReplaceItem(ItemID.GoldenFishingRod, Utils.Coins(0, 0, 0, 2));
            }

            NextSlot++;
        }
    }
}