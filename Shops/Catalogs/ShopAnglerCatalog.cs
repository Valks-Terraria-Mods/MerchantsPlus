namespace MerchantsPlus.Shops;

public static class ShopAnglerCatalog
{
    public const string BaitShopName = "Bait";
    public const string FoodShopName = "Food";
    public const string CratesShopName = "Crates";

    public static readonly string[] ShopNames =
    [
        BaitShopName,
        FoodShopName,
        CratesShopName,
    ];

    public static readonly ProgressionShopItem[] FishingPoleProgression =
    [
        new(1, ItemID.ReinforcedFishingPole, Coins.Silver(25)),
        new(2, ItemID.FisherofSouls, Coins.Gold()),
        new(3, ItemID.FiberglassFishingPole, Coins.Gold(10)),
        new(4, ItemID.MechanicsRod, Coins.Gold(25)),
        new(5, ItemID.SittingDucksFishingRod, Coins.Gold(50)),
        new(6, ItemID.HotlineFishingHook, Coins.Platinum()),
        new(7, ItemID.GoldenFishingRod, Coins.Platinum(2))
    ];

    public static readonly ProgressionShopItem[] DefaultProgressionItems =
    [
        new(1, ItemID.AnglerPants, ItemCosts.Accessories),
        new(2, ItemID.AnglerVest, ItemCosts.Accessories),
        new(3, ItemID.AnglerHat, ItemCosts.Accessories),
        new(4, ItemID.FishFinder, ItemCosts.Accessories),
        new(5, ItemID.AnglerEarring, ItemCosts.Accessories),
        new(6, ItemID.Sextant, ItemCosts.Accessories),
        new(7, ItemID.WeatherRadio, ItemCosts.Accessories),
        new(8, ItemID.FishermansGuide, ItemCosts.Accessories),
        new(9, ItemID.TackleBox, ItemCosts.Accessories),
        new(10, ItemID.HighTestFishingLine, ItemCosts.Accessories)
    ];

    public static readonly ProgressionShopTier[] BaitTiers =
    [
        // 5% Bait Power
        new(0, Coins.Silver(10), ItemID.MonarchButterfly),

        // 10% Bait Power
        new(1, Coins.Silver(20), ItemID.SulphurButterfly, ItemID.Scorpion, ItemID.Snail, ItemID.Grasshopper),

        // 15% Bait Power
        new(2, Coins.Silver(30), ItemID.ApprenticeBait, ItemID.ZebraSwallowtailButterfly, ItemID.BlackScorpion, ItemID.GlowingSnail, ItemID.Grubby),

        // 20% Bait Power
        new(3, Coins.Silver(40), ItemID.Firefly, ItemID.UlyssesButterfly, ItemID.BlueJellyfish, ItemID.GreenJellyfish, ItemID.PinkJellyfish),

        // 25% Bait Power
        new(4, Coins.Silver(50), ItemID.JuliaButterfly, ItemID.Worm, ItemID.Sluggy),

        // 30% Bait Power
        new(5, Coins.Silver(60), ItemID.JourneymanBait, ItemID.RedAdmiralButterfly),

        // 35% Bait Power
        new(6, Coins.Silver(70), ItemID.PurpleEmperorButterfly, ItemID.LightningBug, ItemID.EnchantedNightcrawler),

        // 40% Bait Power
        new(7, Coins.Silver(80), ItemID.Buggy),

        // 50% Bait Power
        new(8, Coins.Gold(), ItemID.MasterBait, ItemID.TreeNymphButterfly, ItemID.GoldButterfly, ItemID.GoldWorm, ItemID.GoldGrasshopper),
        new(9, Coins.Platinum(), ItemID.TruffleWorm)
    ];

    public static readonly ProgressionShopItem[] CrateProgressionItems =
    [
        new(0, ItemID.WoodenCrate, Coins.Gold(10)),
        new(1, ItemID.IronCrate, Coins.Gold(15)),
        new(2, ItemID.JungleFishingCrate, Coins.Gold(10)),
        new(2, ItemID.FloatingIslandFishingCrate, Coins.Gold(10)),
        new(3, ItemID.CorruptFishingCrate, Coins.Gold(10)),
        new(3, ItemID.CrimsonFishingCrate, Coins.Gold(10)),
        new(4, ItemID.DungeonFishingCrate, Coins.Gold(25)),
        new(5, ItemID.GoldenCrate, Coins.Gold(30)),
        new(6, ItemID.HallowedFishingCrate, Coins.Gold(30))
    ];

    public static readonly ProgressionShopItem[] FoodProgressionItems =
    [
        new(2, ItemID.Sashimi, ItemCosts.Potions),
        new(2, ItemID.CookedFish, ItemCosts.Potions),
        new(2, ItemID.CookedShrimp, ItemCosts.Potions)
    ];
}
