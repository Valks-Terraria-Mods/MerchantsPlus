namespace MerchantsPlus.Shops;

public class ShopAngler : Shop
{
    public override string[] Shops => ["Bait", "Food", "Crates"];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        int progression = Progression.Level();

        switch (shop)
        {
            case "Food":
                Food(progression);
                return;
            case "Crates":
                Crates(progression);
                return;
            case "Bait":
                Bait(progression);
                return;
            default:
                DefaultShop(progression);
                return;
        }
    }

    private void DefaultShop(int progression)
    {
        ShopFishingPole(progression);

        if (progression > 0)
        {
            AddItem(ItemID.AnglerPants, ItemCosts.Accessories);
        }

        if (progression > 1)
        {
            AddItem(ItemID.AnglerVest, ItemCosts.Accessories);
        }

        if (progression > 2)
        {
            AddItem(ItemID.AnglerHat, ItemCosts.Accessories);
        }

        if (progression > 3)
        {
            AddItem(ItemID.FishFinder, ItemCosts.Accessories);
        }

        if (progression > 4)
        {
            AddItem(ItemID.AnglerEarring, ItemCosts.Accessories);
        }

        if (progression > 5)
        {
            AddItem(ItemID.Sextant, ItemCosts.Accessories);
        }

        if (progression > 6)
        {
            AddItem(ItemID.WeatherRadio, ItemCosts.Accessories);
        }

        if (progression > 7)
        {
            AddItem(ItemID.FishermansGuide, ItemCosts.Accessories);
        }

        if (progression > 8)
        {
            AddItem(ItemID.TackleBox, ItemCosts.Accessories);
        }

        if (progression > 9)
        {
            AddItem(ItemID.HighTestFishingLine, ItemCosts.Accessories);
        }
    }

    private void Bait(int progression)
    {
        // 5% Bait Power
        AddItem(ItemID.MonarchButterfly, Coins.Silver(10));

        if (progression > 0)
        {
            // 10% Bait Power
            AddItem(ItemID.SulphurButterfly, Coins.Silver(20));
            AddItem(ItemID.Scorpion, Coins.Silver(20));
            AddItem(ItemID.Snail, Coins.Silver(20));
            AddItem(ItemID.Grasshopper, Coins.Silver(20));
        }

        if (progression > 1)
        {
            // 15% Bait Power
            AddItem(ItemID.ApprenticeBait, Coins.Silver(30));
            AddItem(ItemID.ZebraSwallowtailButterfly, Coins.Silver(30));
            AddItem(ItemID.BlackScorpion, Coins.Silver(30));
            AddItem(ItemID.GlowingSnail, Coins.Silver(30));
            AddItem(ItemID.Grubby, Coins.Silver(30));
        }

        if (progression > 2)
        {
            // 20% Bait Power
            AddItem(ItemID.Firefly, Coins.Silver(40));
            AddItem(ItemID.UlyssesButterfly, Coins.Silver(40));
            AddItem(ItemID.BlueJellyfish, Coins.Silver(40));
            AddItem(ItemID.GreenJellyfish, Coins.Silver(40));
            AddItem(ItemID.PinkJellyfish, Coins.Silver(40));
        }

        if (progression > 3)
        {
            // 25% Bait Power
            AddItem(ItemID.JuliaButterfly, Coins.Silver(50));
            AddItem(ItemID.Worm, Coins.Silver(50));
            AddItem(ItemID.Sluggy, Coins.Silver(50));
        }

        if (progression > 4)
        {
            // 30% Bait Power
            AddItem(ItemID.JourneymanBait, Coins.Silver(60));
            AddItem(ItemID.RedAdmiralButterfly, Coins.Silver(60));
        }

        if (progression > 5)
        {
            // 35% Bait Power
            AddItem(ItemID.PurpleEmperorButterfly, Coins.Silver(70));
            AddItem(ItemID.LightningBug, Coins.Silver(70));
            AddItem(ItemID.EnchantedNightcrawler, Coins.Silver(70));
        }

        if (progression > 6)
        {
            // 40% Bait Power
            AddItem(ItemID.Buggy, Coins.Silver(80));
        }

        if (progression > 7)
        {
            // 50% Bait Power
            AddItem(ItemID.MasterBait, Coins.Gold());
            AddItem(ItemID.TreeNymphButterfly, Coins.Gold());
            AddItem(ItemID.GoldButterfly, Coins.Gold());
            AddItem(ItemID.GoldWorm, Coins.Gold());
            AddItem(ItemID.GoldGrasshopper, Coins.Gold());
        }

        if (progression > 8)
        {
            AddItem(ItemID.TruffleWorm, Coins.Platinum());
        }
    }

    private void Crates(int progression)
    {
        AddItem(ItemID.WoodenCrate, Coins.Gold(10));

        if (progression > 0)
        {
            AddItem(ItemID.IronCrate, Coins.Gold(15));
        }

        if (progression > 1)
        {
            AddItem(ItemID.JungleFishingCrate, Coins.Gold(10));
            AddItem(ItemID.FloatingIslandFishingCrate, Coins.Gold(10));
        }

        if (progression > 2)
        {
            AddItem(ItemID.CorruptFishingCrate, Coins.Gold(10));
            AddItem(ItemID.CrimsonFishingCrate, Coins.Gold(10));
        }

        if (progression > 3)
        {
            AddItem(ItemID.DungeonFishingCrate, Coins.Gold(25));
        }

        if (progression > 4)
        {
            AddItem(ItemID.GoldenCrate, Coins.Gold(30));
        }

        if (progression > 5)
        {
            AddItem(ItemID.HallowedFishingCrate, Coins.Gold(30));
        }
    }

    private void Food(int progression)
    {
        if (progression > 1)
        {
            AddItem(ItemID.Sashimi, ItemCosts.Potions);
            AddItem(ItemID.CookedFish, ItemCosts.Potions);
            AddItem(ItemID.CookedShrimp, ItemCosts.Potions);
        }
    }

    private void ShopFishingPole(int progression)
    {
        ReplaceItem(ItemID.WoodFishingPole, Coins.Silver(10));

        ReplaceItem(progression > 0, ItemID.ReinforcedFishingPole, Coins.Silver(25));
        ReplaceItem(progression > 1, ItemID.FisherofSouls, Coins.Gold());
        ReplaceItem(progression > 2, ItemID.FiberglassFishingPole, Coins.Gold(10));
        ReplaceItem(progression > 3, ItemID.MechanicsRod, Coins.Gold(25));
        ReplaceItem(progression > 4, ItemID.SittingDucksFishingRod, Coins.Gold(50));
        ReplaceItem(progression > 5, ItemID.HotlineFishingHook, Coins.Platinum());
        ReplaceItem(progression > 6, ItemID.GoldenFishingRod, Coins.Platinum(2));

        NextSlot++;
    }
}