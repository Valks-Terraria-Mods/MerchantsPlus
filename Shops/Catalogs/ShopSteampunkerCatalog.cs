namespace MerchantsPlus.Shops;

public static class ShopSteampunkerCatalog
{
    public const string GearShopName = "Gear";
    public const string SolutionsShopName = "Solutions";
    public const string LogicShopName = "Logic";

    public static readonly string[] ShopNames =
    [
        GearShopName,
        SolutionsShopName,
        LogicShopName,
    ];

    public static readonly int[] LogicSensors =
    [
        ItemID.LogicSensor_Above,
        ItemID.LogicSensor_Honey,
        ItemID.LogicSensor_Lava,
        ItemID.LogicSensor_Liquid,
        ItemID.LogicSensor_Moon,
        ItemID.LogicSensor_Sun,
        ItemID.LogicSensor_Water,
    ];

    public static readonly int[] LogicGates =
    [
        ItemID.LogicGateLamp_Faulty,
        ItemID.LogicGateLamp_Off,
        ItemID.LogicGate_AND,
        ItemID.LogicGate_NAND,
        ItemID.LogicGate_NOR,
        ItemID.LogicGate_NXOR,
        ItemID.LogicGate_OR,
        ItemID.LogicGate_XOR,
    ];

    public static readonly int[] BiomeSolutions =
    [
        ItemID.PurpleSolution,
        ItemID.RedSolution,
        ItemID.GreenSolution,
        ItemID.DarkBlueSolution,
        ItemID.BlueSolution,
    ];

    public static readonly int[] SteampunkGear =
    [
        ItemID.Teleporter,
        ItemID.Jetpack,
        ItemID.Solidifier,
        ItemID.BlendOMatic,
        ItemID.FleshCloningVaat,
        ItemID.SteampunkBoiler,
        ItemID.Cog,
        ItemID.StaticHook,
        ItemID.ConveyorBeltRight,
    ];

    public static readonly IReadOnlyDictionary<string, (int? Price, int[] ItemIds)[]> SectionsByShop =
        new Dictionary<string, (int? Price, int[] ItemIds)[]>
        {
            [GearShopName] =
            [
                (null, SteampunkGear),
            ],
            [SolutionsShopName] =
            [
                (null, BiomeSolutions),
            ],
            [LogicShopName] =
            [
                (null, LogicGates),
                (Coins.Gold(), LogicSensors),
            ],
        };

}

