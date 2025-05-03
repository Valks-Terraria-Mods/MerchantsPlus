namespace MerchantsPlus.Items;

class ItemsBlocks : BaseItem
{
    public override void SetDefaults(Item item)
    {
        base.SetDefaults(item);

        if (item.type == ItemID.StoneBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.DirtBlock) item.shopCustomPrice = Coins.Copper(1);

        if (item.type == ItemID.StoneWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.DirtWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.EbonstoneBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.EbonstoneBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.Candle) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.GrayBrick) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.GrayBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.RedBrick) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.RedBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.ClayBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.BlueBrick) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.BlueBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.BlueBrickPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.GreenBrick) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.GreenBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.GreenBrickPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PinkBrick) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PinkBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PinkBrickPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.GoldBrick) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.GoldBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.SilverBrick) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.SilverBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.CopperBrick) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.CopperBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.Spike) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.WaterCandle) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.Cobweb) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.SandBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.Glass) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.Sign) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.AshBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.Hellstone) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.MudBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.HellstoneBrick) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.HellstoneBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PearlsandBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PearlstoneBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PearlstoneBrick) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PearlstoneBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.IridescentBrick) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.IridescentBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.MudstoneBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.MudstoneBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.CobaltBrick) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.CobaltBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.MythrilBrick) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.MythrilBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.SiltBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PlankedWall) item.shopCustomPrice = Coins.Copper(1);

        if (item.type == ItemID.Mannequin) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.Womannquin) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.Boulder) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.DemoniteBrick) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.DemoniteBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.Explosives) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.InletPump) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.OutletPump) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.CandyCaneBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.CandyCaneWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.GreenCandyCaneBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.GreenCandyCaneWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.SnowBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.SnowBrick) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.SnowBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.AdamantiteBeam) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.AdamantiteBeamWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.Sandstone) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.SandstoneBrick) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.SandstoneBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.EbonstoneBrick) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.EbonstoneBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.RedStucco) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.RedStuccoWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.GreenStucco) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.GreenStuccoWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.YellowStucco) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.YellowStuccoWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.GrayStucco) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.GrayStuccoWall) item.shopCustomPrice = Coins.Copper(1);

        if (item.type == ItemID.RainbowBrick) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.RainbowBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.TinBrick) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.TinBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.TungstenBrick) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.TungstenBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PlatinumBrick) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PlatinumBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.Cloud) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.CloudWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.FleshBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.FleshBlockWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.RainCloud) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.AsphaltBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.FleshChair) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.DiscWall) item.shopCustomPrice = Coins.Copper(1);

        if (item.type == ItemID.CrimstoneBlock) item.shopCustomPrice = Coins.Copper(1);

        if (item.type == ItemID.Campfire) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.SlushBlock) item.shopCustomPrice = Coins.Copper(1);

        if (item.type == ItemID.CrimsandBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.WallSkeleton) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.HangingSkeleton) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.BlueSlabWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.BlueTiledWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PinkSlabWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PinkTiledWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.GreenSlabWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.GreenTiledWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.BlueBrickPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PinkBrickPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.GreenBrickPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.MetalShelf) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.BrassShelf) item.shopCustomPrice = Coins.Copper(1);

        if (item.type == ItemID.BrassLantern) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.CagedLantern) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.CarriageLantern) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.AlchemyLantern) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.DiablostLamp) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.OilRagSconse) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.BlueDungeonChair) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.GreenDungeonChair) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PinkDungeonChair) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.BlueDungeonCandle) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.GreenDungeonCandle) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PinkDungeonCandle) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.Catacomb) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.DungeonShelf) item.shopCustomPrice = Coins.Copper(1);

        if (item.type == ItemID.LeadFence) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.GothicChair) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.GlassChair) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.BarStool) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.Hay) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.HayWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.HangingJackOLantern) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.HeartLantern) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.Present) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PineTreeBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.FireflyinaBottle) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.LightningBuginaBottle) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.WaterfallBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.WaterfallWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.LavafallWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.LavafallBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.CopperPlating) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.CopperPlatingWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.LightningBuginaBottle) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.MinecartTrack) item.shopCustomPrice = Coins.Copper(1);

        // Gravestones
        if (item.type == ItemID.GraveMarker) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.CrossGraveMarker) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.Headstone) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.Gravestone) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.Tombstone) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.Obelisk) item.shopCustomPrice = Coins.Copper(1);

        // Cages
        if (item.type == ItemID.BunnyCage) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.SquirrelCage) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.DuckCage) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.MallardDuckCage) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.BirdCage) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.BlueJayCage) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.CardinalCage) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.SnailCage) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.GlowingSnailCage) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.ScorpionCage) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.BlackScorpionCage) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.FrogCage) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.MouseCage) item.shopCustomPrice = Coins.Copper(1);

        // Jars
        if (item.type == ItemID.MonarchButterflyJar) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PurpleEmperorButterflyJar) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.RedAdmiralButterflyJar) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.UlyssesButterflyJar) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.SulphurButterflyJar) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.TreeNymphButterflyJar) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.ZebraSwallowtailButterflyJar) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.JuliaButterflyJar) item.shopCustomPrice = Coins.Copper(1);

        // Wood
        if (item.type == ItemID.GoldenPlatform) item.shopCustomPrice = Coins.Silver(10);

        if (item.type == ItemID.Wood) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.WoodenFence) item.shopCustomPrice = Coins.Copper(10);
        if (item.type == ItemID.WoodPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.WoodenChair) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.WoodWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.WoodenBeam) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.WoodShelf) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.WoodenSpike) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.LeafWand) item.shopCustomPrice = Coins.Silver(5);
        if (item.type == ItemID.LivingWoodWand) item.shopCustomPrice = Coins.Silver(5);

        if (item.type == ItemID.LivingWoodCandle) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.LivingWoodPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.LivingWoodChair) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.LivingWoodWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.LivingWoodLantern) item.shopCustomPrice = Coins.Silver();

        if (item.type == ItemID.Ebonwood) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.EbonwoodCandle) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.EbonwoodFence) item.shopCustomPrice = Coins.Copper(10);
        if (item.type == ItemID.EbonwoodPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.EbonwoodChair) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.EbonwoodWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.EbonwoodLantern) item.shopCustomPrice = Coins.Silver();

        if (item.type == ItemID.Shadewood) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.ShadewoodCandle) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.ShadewoodFence) item.shopCustomPrice = Coins.Copper(10);
        if (item.type == ItemID.ShadewoodPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.ShadewoodChair) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.ShadewoodWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.ShadewoodLantern) item.shopCustomPrice = Coins.Silver();

        if (item.type == ItemID.CrystalBlockWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.CrystalCandle) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.CrystalPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.CrystalChair) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.CrystalLantern) item.shopCustomPrice = Coins.Silver();

        if (item.type == ItemID.Cactus) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.CactusCandle) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.CactusPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.CactusChair) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.CactusWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.CactusLantern) item.shopCustomPrice = Coins.Silver();

        if (item.type == ItemID.Bone) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.BonePlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.BoneChair) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.BoneLantern) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.BoneWand) item.shopCustomPrice = Coins.Silver(10);

        if (item.type == ItemID.RichMahogany) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.RichMahoganyCandle) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.RichMahoganyFence) item.shopCustomPrice = Coins.Copper(10);
        if (item.type == ItemID.RichMahoganyPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.RichMahoganyChair) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.RichMahoganyWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.RichMahoganyLantern) item.shopCustomPrice = Coins.Silver();

        if (item.type == ItemID.Pearlwood) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PearlwoodCandle) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.PearlwoodFence) item.shopCustomPrice = Coins.Copper(10);
        if (item.type == ItemID.PearlwoodPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PearlwoodChair) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.PearlwoodWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PearlwoodLantern) item.shopCustomPrice = Coins.Silver();

        if (item.type == ItemID.PalmWood) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PalmWoodCandle) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.PalmWoodFence) item.shopCustomPrice = Coins.Copper(10);
        if (item.type == ItemID.PalmWoodPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PalmWoodChair) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.PalmWoodWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PalmWoodLantern) item.shopCustomPrice = Coins.Silver();

        if (item.type == ItemID.BorealWood) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.BorealWoodCandle) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.BorealWoodFence) item.shopCustomPrice = Coins.Copper(10);
        if (item.type == ItemID.BorealWoodPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.BorealWoodChair) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.BorealWoodWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.BorealWoodLantern) item.shopCustomPrice = Coins.Silver();

        if (item.type == ItemID.SteampunkCandle) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.SteampunkPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.SteampunkChair) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.SteampunkLantern) item.shopCustomPrice = Coins.Silver();

        if (item.type == ItemID.Obsidian) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.ObsidianBrick) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.ObsidianBrickWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.ObsidianCandle) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.ObsidianPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.ObsidianChair) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.ObsidianLantern) item.shopCustomPrice = Coins.Silver();

        if (item.type == ItemID.Pumpkin) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PumpkinCandle) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.PumpkinPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PumpkinChair) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.PumpkinWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PumpkinLantern) item.shopCustomPrice = Coins.Silver();

        if (item.type == ItemID.HoneyBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.HoneyCandle) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.HoneyPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.HoneyChair) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.HoneyLantern) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.Hive) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.HiveWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.CrispyHoneyBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.HiveWand) item.shopCustomPrice = Coins.Silver(10);

        if (item.type == ItemID.Mushroom) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.MushroomCandle) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.MushroomPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.MushroomChair) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.MushroomWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.MushroomLantern) item.shopCustomPrice = Coins.Silver();

        if (item.type == ItemID.IceBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.FrozenCandle) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.FrozenPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.FrozenChair) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.FrozenLantern) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.PurpleIceBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.PinkIceBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.RedIceBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.IceBrick) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.IceBrickWall) item.shopCustomPrice = Coins.Copper(1);

        if (item.type == ItemID.SunplateBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.SkywareCandle) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.SkywarePlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.SkywareChair) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.SkywareLantern) item.shopCustomPrice = Coins.Silver();

        if (item.type == ItemID.LihzahrdBrick) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.LihzahrdBrickWall) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.LihzahrdCandle) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.LihzahrdPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.LihzahrdChair) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.LihzahrdLantern) item.shopCustomPrice = Coins.Silver();

        if (item.type == ItemID.FleshBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.FleshBlockWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.FleshCandle) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.FleshPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.FleshChair) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.FleshLantern) item.shopCustomPrice = Coins.Silver();

        if (item.type == ItemID.DynastyWood) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.DynastyCandle) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.DynastyPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.DynastyChair) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.WhiteDynastyWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.BlueDynastyWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.DynastyLantern) item.shopCustomPrice = Coins.Silver();

        if (item.type == ItemID.SpookyWood) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.SpookyCandle) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.SpookyPlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.SpookyChair) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.SpookyWoodWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.SpookyLantern) item.shopCustomPrice = Coins.Silver();

        if (item.type == ItemID.SlimeBlock) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.SlimeCandle) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.SlimePlatform) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.SlimeChair) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.SlimeBlockWall) item.shopCustomPrice = Coins.Copper(1);
        if (item.type == ItemID.SlimeLantern) item.shopCustomPrice = Coins.Silver();
        if (item.type == ItemID.FrozenSlimeBlock) item.shopCustomPrice = Coins.Copper(1);
    }
}
