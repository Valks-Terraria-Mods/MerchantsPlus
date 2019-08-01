using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    class ShopAngler
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
            switch (currentShop)
            {
                case "Buffs":
                    shop.item[nextSlot].SetDefaults(ItemID.FishingPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.CratePotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.SonarPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.CookedFish);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.CookedShrimp);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.Sashimi);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.FlipperPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.GillsPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.WaterWalkingPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    break;
                case "Crates":
                    shop.item[nextSlot].SetDefaults(ItemID.WoodenCrate);
                    shop.item[nextSlot++].shopCustomPrice = 30000;
                    if (NPC.downedSlimeKing)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.IronCrate);
                        shop.item[nextSlot++].shopCustomPrice = 100000;
                    }
                    if (NPC.downedBoss1)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.JungleFishingCrate);
                        shop.item[nextSlot++].shopCustomPrice = 250000;
                        shop.item[nextSlot].SetDefaults(ItemID.FloatingIslandFishingCrate);
                        shop.item[nextSlot++].shopCustomPrice = 250000;
                        if (NPC.downedBoss2)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.CorruptFishingCrate);
                            shop.item[nextSlot++].shopCustomPrice = 250000;
                            shop.item[nextSlot].SetDefaults(ItemID.CrimsonFishingCrate);
                            shop.item[nextSlot++].shopCustomPrice = 250000;
                        }
                        if (Main.hardMode)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.HallowedFishingCrate);
                            shop.item[nextSlot++].shopCustomPrice = 250000;
                        }
                        if (NPC.downedBoss3)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.DungeonFishingCrate);
                            shop.item[nextSlot++].shopCustomPrice = 250000;
                        }
                    }
                    if (Main.hardMode)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.GoldenCrate);
                        shop.item[nextSlot++].shopCustomPrice = 1000000;
                    }
                    break;
                case "Bait":
                    shop.item[nextSlot++].SetDefaults(ItemID.MonarchButterfly);
                    if (NPC.downedSlimeKing)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.SulphurButterfly);
                        shop.item[nextSlot++].SetDefaults(ItemID.Scorpion);
                        shop.item[nextSlot++].SetDefaults(ItemID.Snail);
                        shop.item[nextSlot++].SetDefaults(ItemID.Grasshopper);
                    }
                    if (NPC.downedBoss1)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.ApprenticeBait);
                        shop.item[nextSlot++].SetDefaults(ItemID.BlueJellyfish);
                        shop.item[nextSlot++].SetDefaults(ItemID.GreenJellyfish);
                        shop.item[nextSlot++].SetDefaults(ItemID.PinkJellyfish);
                        shop.item[nextSlot++].SetDefaults(ItemID.JuliaButterfly);
                        shop.item[nextSlot++].SetDefaults(ItemID.UlyssesButterfly);
                        shop.item[nextSlot++].SetDefaults(ItemID.ZebraSwallowtailButterfly);
                        shop.item[nextSlot++].SetDefaults(ItemID.Firefly);
                        shop.item[nextSlot++].SetDefaults(ItemID.BlackScorpion);
                        shop.item[nextSlot++].SetDefaults(ItemID.Worm);
                        shop.item[nextSlot++].SetDefaults(ItemID.GlowingSnail);
                        shop.item[nextSlot++].SetDefaults(ItemID.Sluggy);
                        shop.item[nextSlot++].SetDefaults(ItemID.Grubby);
                    }
                    if (NPC.downedBoss2)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.JourneymanBait);
                        shop.item[nextSlot++].SetDefaults(ItemID.PurpleEmperorButterfly);
                        shop.item[nextSlot++].SetDefaults(ItemID.RedAdmiralButterfly);
                        shop.item[nextSlot++].SetDefaults(ItemID.LightningBug);
                        shop.item[nextSlot++].SetDefaults(ItemID.EnchantedNightcrawler);
                        shop.item[nextSlot++].SetDefaults(ItemID.Buggy);
                    }
                    if (NPC.downedBoss3)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.MasterBait);
                        shop.item[nextSlot++].SetDefaults(ItemID.TreeNymphButterfly);
                        shop.item[nextSlot++].SetDefaults(ItemID.GoldButterfly);
                        shop.item[nextSlot++].SetDefaults(ItemID.GoldWorm);
                        shop.item[nextSlot++].SetDefaults(ItemID.GoldGrasshopper);
                    }
                    if (NPC.downedGolemBoss)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.TruffleWorm);
                    }
                    break;
                default:
                    shopFishingPole(shop, ref nextSlot);
                    shop.item[nextSlot++].SetDefaults(ItemID.AnglerHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.AnglerVest);
                    shop.item[nextSlot++].SetDefaults(ItemID.AnglerPants);
                    shop.item[nextSlot].SetDefaults(ItemID.HighTestFishingLine);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.AnglerEarring);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.TackleBox);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.FishermansGuide);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.WeatherRadio);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.Sextant);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.FishFinder);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    /*if (MerchantsPlus.calamityLoaded)
                    {
                        shop.item[nextSlot++].SetDefaults(MerchantsPlus.calamity.ItemType("AlluringBait"));
                        shop.item[nextSlot++].SetDefaults(MerchantsPlus.calamity.ItemType("EnchantedPearl"));
                    }*/
                    break;
            }

        }

        private void shopFishingPole(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.WoodFishingPole);
            shop.item[nextSlot].shopCustomPrice = 1000;
            if (NPC.downedSlimeKing)
            {
                shop.item[nextSlot].SetDefaults(ItemID.ReinforcedFishingPole);
                shop.item[nextSlot].shopCustomPrice = 2500;
            }
            if (NPC.downedBoss1)
            {
                shop.item[nextSlot].SetDefaults(ItemID.FisherofSouls);
                shop.item[nextSlot].shopCustomPrice = 10000;
            }
            if (NPC.downedBoss2)
            {
                shop.item[nextSlot].SetDefaults(ItemID.FiberglassFishingPole);
                shop.item[nextSlot].shopCustomPrice = 100000;
            }
            if (NPC.downedBoss3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.MechanicsRod);
                shop.item[nextSlot].shopCustomPrice = 250000;
            }
            if (Main.hardMode)
            {
                shop.item[nextSlot].SetDefaults(ItemID.SittingDucksFishingRod);
                shop.item[nextSlot].shopCustomPrice = 500000;
            }
            if (Utils.downedMechBosses() == 1)
            {
                shop.item[nextSlot].SetDefaults(ItemID.HotlineFishingHook);
                shop.item[nextSlot].shopCustomPrice = 1000000;
            }
            if (Utils.downedMechBosses() == 2)
            {
                shop.item[nextSlot].SetDefaults(ItemID.GoldenFishingRod);
                shop.item[nextSlot].shopCustomPrice = 2000000;
            }
            nextSlot++;
        }
    }
}
