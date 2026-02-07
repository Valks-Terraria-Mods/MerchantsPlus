namespace MerchantsPlus.Shops;

public static class ShopMechanicCatalog
{
    public const string MechanicsShopName = "Mechanics";
    public const string MaterialsShopName = "Materials";

    public static readonly string[] ShopNames =
    [
        MechanicsShopName,
        MaterialsShopName,
    ];

    public static readonly int[] BuildingMaterials =
    [
        ItemID.Wood,
        ItemID.Cactus,
        ItemID.RichMahogany,
        ItemID.BorealWood,
        ItemID.PalmWood,
        ItemID.Ebonwood,
        ItemID.Shadewood,
        ItemID.Pearlwood,
        ItemID.SpookyWood,
        ItemID.DynastyWood,
        ItemID.Pumpkin,
        ItemID.Mushroom,
        ItemID.Granite,
        ItemID.Marble,
        ItemID.Meteorite,
        ItemID.CrystalBlock,
        ItemID.Glass,
        ItemID.LivingWoodWand,
        ItemID.SunplateBlock,
        ItemID.IceBlock,
        ItemID.HoneyBlock,
        ItemID.SlimeBlock,
        ItemID.BoneBlock,
        ItemID.FleshBlock,
        ItemID.Cog,
        ItemID.LihzahrdBrick,
        ItemID.MartianConduitPlating,
        ItemID.GoldBrick,
        ItemID.StoneBlock,
        ItemID.GrayBrick,
        ItemID.RedBrick,
        ItemID.DirtBlock,
        ItemID.MudBlock,
        ItemID.Cloud,
        ItemID.RainCloud,
        ItemID.SnowBlock,
        ItemID.AshBlock,
        ItemID.SandBlock,
        ItemID.HardenedSand,
        ItemID.Sandstone,
    ];

    public static readonly int[] WiringTools =
    [
        ItemID.Wrench,
        ItemID.BlueWrench,
        ItemID.GreenWrench,
        ItemID.YellowWrench,
        ItemID.WireCutter,
        ItemID.Wire,
        ItemID.Lever,
        ItemID.Switch,
        ItemID.RedPressurePlate,
        ItemID.BluePressurePlate,
        ItemID.BrownPressurePlate,
        ItemID.GrayPressurePlate,
        ItemID.GreenPressurePlate,
        ItemID.YellowPressurePlate,
        ItemID.ProjectilePressurePad,
        ItemID.BoosterTrack,
        ItemID.Actuator,
        ItemID.WirePipe,
        ItemID.WireBulb,
        ItemID.Timer1Second,
        ItemID.Timer3Second,
        ItemID.Timer5Second,
    ];

    public static readonly IReadOnlyDictionary<string, (int? Price, int[] ItemIds)> SectionsByShop =
        new Dictionary<string, (int? Price, int[] ItemIds)>
        {
            [MechanicsShopName] = (null, WiringTools),
            [MaterialsShopName] = (Coins.Silver(), BuildingMaterials),
        };

}

