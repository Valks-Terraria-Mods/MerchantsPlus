using Terraria.ID;

namespace MerchantsPlus.Items;

class ItemsBlocks : BaseItem
{
    public override void SetDefaults(Item item)
    {
        base.SetDefaults(item);

        if (item.type == ItemID.DirtBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.StoneBlock) item.shopCustomPrice = Utils.Coins(1);
        
        if (item.type == ItemID.StoneWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.DirtWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.EbonstoneBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.EbonstoneBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.Candle) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.GrayBrick) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.GrayBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.RedBrick) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.RedBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.ClayBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.BlueBrick) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.BlueBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.BlueBrickPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.GreenBrick) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.GreenBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.GreenBrickPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PinkBrick) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PinkBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PinkBrickPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.GoldBrick) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.GoldBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.SilverBrick) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.SilverBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.CopperBrick) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.CopperBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.Spike) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.WaterCandle) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.Cobweb) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.SandBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.Glass) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.Sign) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.AshBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.Hellstone) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.MudBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.HellstoneBrick) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.HellstoneBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PearlsandBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PearlstoneBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PearlstoneBrick) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PearlstoneBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.IridescentBrick) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.IridescentBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.MudstoneBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.MudstoneBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.CobaltBrick) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.CobaltBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.MythrilBrick) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.MythrilBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.SiltBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PlankedWall) item.shopCustomPrice = Utils.Coins(1);
        
        if (item.type == ItemID.Mannequin) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.Womannquin) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.Boulder) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.DemoniteBrick) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.DemoniteBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.Explosives) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.InletPump) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.OutletPump) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.CandyCaneBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.CandyCaneWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.GreenCandyCaneBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.GreenCandyCaneWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.SnowBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.SnowBrick) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.SnowBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.AdamantiteBeam) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.AdamantiteBeamWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.Sandstone) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.SandstoneBrick) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.SandstoneBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.EbonstoneBrick) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.EbonstoneBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.RedStucco) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.RedStuccoWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.GreenStucco) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.GreenStuccoWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.YellowStucco) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.YellowStuccoWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.GrayStucco) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.GrayStuccoWall) item.shopCustomPrice = Utils.Coins(1);
        
        if (item.type == ItemID.RainbowBrick) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.RainbowBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.TinBrick) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.TinBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.TungstenBrick) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.TungstenBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PlatinumBrick) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PlatinumBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.Cloud) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.CloudWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.FleshBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.FleshBlockWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.RainCloud) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.AsphaltBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.FleshChair) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.DiscWall) item.shopCustomPrice = Utils.Coins(1);

        if (item.type == ItemID.CrimstoneBlock) item.shopCustomPrice = Utils.Coins(1);
        
        if (item.type == ItemID.Campfire) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.SlushBlock) item.shopCustomPrice = Utils.Coins(1);
        
        if (item.type == ItemID.CrimsandBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.WallSkeleton) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.HangingSkeleton) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.BlueSlabWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.BlueTiledWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PinkSlabWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PinkTiledWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.GreenSlabWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.GreenTiledWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.BlueBrickPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PinkBrickPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.GreenBrickPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.MetalShelf) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.BrassShelf) item.shopCustomPrice = Utils.Coins(1);
        
        if (item.type == ItemID.BrassLantern) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.CagedLantern) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.CarriageLantern) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.AlchemyLantern) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.DiablostLamp) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.OilRagSconse) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.BlueDungeonChair) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.GreenDungeonChair) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PinkDungeonChair) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.BlueDungeonCandle) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.GreenDungeonCandle) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PinkDungeonCandle) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.Catacomb) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.DungeonShelf) item.shopCustomPrice = Utils.Coins(1);
        
        if (item.type == ItemID.LeadFence) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.GothicChair) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.GlassChair) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.BarStool) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.Hay) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.HayWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.HangingJackOLantern) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.HeartLantern) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.Present) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PineTreeBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.FireflyinaBottle) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.LightningBuginaBottle) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.WaterfallBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.WaterfallWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.LavafallWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.LavafallBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.CopperPlating) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.CopperPlatingWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.LightningBuginaBottle) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.MinecartTrack) item.shopCustomPrice = Utils.Coins(1);

        // Gravestones
        if (item.type == ItemID.GraveMarker) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.CrossGraveMarker) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.Headstone) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.Gravestone) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.Tombstone) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.Obelisk) item.shopCustomPrice = Utils.Coins(1);

        // Cages
        if (item.type == ItemID.BunnyCage) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.SquirrelCage) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.DuckCage) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.MallardDuckCage) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.BirdCage) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.BlueJayCage) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.CardinalCage) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.SnailCage) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.GlowingSnailCage) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.ScorpionCage) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.BlackScorpionCage) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.FrogCage) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.MouseCage) item.shopCustomPrice = Utils.Coins(1);

        // Jars
        if (item.type == ItemID.MonarchButterflyJar) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PurpleEmperorButterflyJar) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.RedAdmiralButterflyJar) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.UlyssesButterflyJar) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.SulphurButterflyJar) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.TreeNymphButterflyJar) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.ZebraSwallowtailButterflyJar) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.JuliaButterflyJar) item.shopCustomPrice = Utils.Coins(1);

        // Wood
        if (item.type == ItemID.GoldenPlatform) item.shopCustomPrice = Utils.Coins(0, 10);

        if (item.type == ItemID.Wood) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.WoodenFence) item.shopCustomPrice = Utils.Coins(10);
        if (item.type == ItemID.WoodPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.WoodenChair) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.WoodWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.WoodenBeam) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.WoodShelf) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.WoodenSpike) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.LeafWand) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.LivingWoodWand) item.shopCustomPrice = Utils.Coins(0, 5);

        if (item.type == ItemID.LivingWoodCandle) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.LivingWoodPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.LivingWoodChair) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.LivingWoodWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.LivingWoodLantern) item.shopCustomPrice = Utils.Coins(0, 1);

        if (item.type == ItemID.Ebonwood) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.EbonwoodCandle) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.EbonwoodFence) item.shopCustomPrice = Utils.Coins(10);
        if (item.type == ItemID.EbonwoodPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.EbonwoodChair) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.EbonwoodWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.EbonwoodLantern) item.shopCustomPrice = Utils.Coins(0, 1);

        if (item.type == ItemID.Shadewood) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.ShadewoodCandle) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.ShadewoodFence) item.shopCustomPrice = Utils.Coins(10);
        if (item.type == ItemID.ShadewoodPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.ShadewoodChair) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.ShadewoodWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.ShadewoodLantern) item.shopCustomPrice = Utils.Coins(0, 1);

        if (item.type == ItemID.CrystalBlockWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.CrystalCandle) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.CrystalPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.CrystalChair) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.CrystalLantern) item.shopCustomPrice = Utils.Coins(0, 1);

        if (item.type == ItemID.Cactus) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.CactusCandle) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.CactusPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.CactusChair) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.CactusWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.CactusLantern) item.shopCustomPrice = Utils.Coins(0, 1);

        if (item.type == ItemID.Bone) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.BonePlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.BoneChair) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.BoneLantern) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.BoneWand) item.shopCustomPrice = Utils.Coins(0, 10);

        if (item.type == ItemID.RichMahogany) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.RichMahoganyCandle) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.RichMahoganyFence) item.shopCustomPrice = Utils.Coins(10);
        if (item.type == ItemID.RichMahoganyPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.RichMahoganyChair) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.RichMahoganyWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.RichMahoganyLantern) item.shopCustomPrice = Utils.Coins(0, 1);

        if (item.type == ItemID.Pearlwood) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PearlwoodCandle) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.PearlwoodFence) item.shopCustomPrice = Utils.Coins(10);
        if (item.type == ItemID.PearlwoodPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PearlwoodChair) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.PearlwoodWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PearlwoodLantern) item.shopCustomPrice = Utils.Coins(0, 1);

        if (item.type == ItemID.PalmWood) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PalmWoodCandle) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.PalmWoodFence) item.shopCustomPrice = Utils.Coins(10);
        if (item.type == ItemID.PalmWoodPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PalmWoodChair) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.PalmWoodWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PalmWoodLantern) item.shopCustomPrice = Utils.Coins(0, 1);

        if (item.type == ItemID.BorealWood) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.BorealWoodCandle) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.BorealWoodFence) item.shopCustomPrice = Utils.Coins(10);
        if (item.type == ItemID.BorealWoodPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.BorealWoodChair) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.BorealWoodWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.BorealWoodLantern) item.shopCustomPrice = Utils.Coins(0, 1);

        if (item.type == ItemID.SteampunkCandle) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.SteampunkPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.SteampunkChair) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.SteampunkLantern) item.shopCustomPrice = Utils.Coins(0, 1);

        if (item.type == ItemID.Obsidian) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.ObsidianBrick) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.ObsidianBrickWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.ObsidianCandle) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.ObsidianPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.ObsidianChair) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.ObsidianLantern) item.shopCustomPrice = Utils.Coins(0, 1);

        if (item.type == ItemID.Pumpkin) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PumpkinCandle) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.PumpkinPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PumpkinChair) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.PumpkinWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PumpkinLantern) item.shopCustomPrice = Utils.Coins(0, 1);

        if (item.type == ItemID.HoneyBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.HoneyCandle) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.HoneyPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.HoneyChair) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.HoneyLantern) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.Hive) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.HiveWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.CrispyHoneyBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.HiveWand) item.shopCustomPrice = Utils.Coins(0, 10);

        if (item.type == ItemID.Mushroom) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.MushroomCandle) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.MushroomPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.MushroomChair) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.MushroomWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.MushroomLantern) item.shopCustomPrice = Utils.Coins(0, 1);

        if (item.type == ItemID.IceBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.FrozenCandle) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.FrozenPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.FrozenChair) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.FrozenLantern) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.PurpleIceBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.PinkIceBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.RedIceBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.IceBrick) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.IceBrickWall) item.shopCustomPrice = Utils.Coins(1);

        if (item.type == ItemID.SunplateBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.SkywareCandle) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.SkywarePlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.SkywareChair) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.SkywareLantern) item.shopCustomPrice = Utils.Coins(0, 1);

        if (item.type == ItemID.LihzahrdBrick) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.LihzahrdBrickWall) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.LihzahrdCandle) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.LihzahrdPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.LihzahrdChair) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.LihzahrdLantern) item.shopCustomPrice = Utils.Coins(0, 1);

        if (item.type == ItemID.FleshBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.FleshBlockWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.FleshCandle) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.FleshPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.FleshChair) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.FleshLantern) item.shopCustomPrice = Utils.Coins(0, 1);

        if (item.type == ItemID.DynastyWood) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.DynastyCandle) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.DynastyPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.DynastyChair) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.WhiteDynastyWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.BlueDynastyWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.DynastyLantern) item.shopCustomPrice = Utils.Coins(0, 1);

        if (item.type == ItemID.SpookyWood) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.SpookyCandle) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.SpookyPlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.SpookyChair) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.SpookyWoodWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.SpookyLantern) item.shopCustomPrice = Utils.Coins(0, 1);

        if (item.type == ItemID.SlimeBlock) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.SlimeCandle) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.SlimePlatform) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.SlimeChair) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.SlimeBlockWall) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.SlimeLantern) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.FrozenSlimeBlock) item.shopCustomPrice = Utils.Coins(1);
    }
}
