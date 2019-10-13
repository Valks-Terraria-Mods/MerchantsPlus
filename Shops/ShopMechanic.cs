using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    class ShopMechanic
    {
        private Chest shop;
        private int nextSlot;

        public ShopMechanic(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            switch (currentShop)
            {
                case "Golden":
                    shop.item[nextSlot++].SetDefaults(ItemID.GoldBrick);
                    shop.item[nextSlot++].SetDefaults(ItemID.GoldenBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.GoldenBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.GoldenBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.GoldenChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.GoldenTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.GoldenChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.GoldenClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.GoldenDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.GoldenCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.GoldenCandle);
                    shop.item[nextSlot++].SetDefaults(ItemID.GoldenPiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.GoldenPlatform);
                    shop.item[nextSlot++].SetDefaults(ItemID.GoldenSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.GoldenSofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.GoldenWorkbench);
                    break;
                case "Martian":
                    shop.item[nextSlot++].SetDefaults(ItemID.MartianConduitPlating);
                    shop.item[nextSlot++].SetDefaults(ItemID.MartianBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.MartianBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.MartianTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.MartianChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.MartianDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.MartianPiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.MartianPlatform);
                    shop.item[nextSlot++].SetDefaults(ItemID.MartianSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.MartianSofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.MartianWorkBench);
                    break;
                case "Lihzahrd":
                    shop.item[nextSlot++].SetDefaults(ItemID.LihzahrdBrick);
                    shop.item[nextSlot++].SetDefaults(ItemID.LihzahrdBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.LihzahrdBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.LihzahrdBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.LihzahrdChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.LihzahrdTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.LihzahrdChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.LihzahrdClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.LihzahrdDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.LihzahrdCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.LihzahrdCandle);
                    shop.item[nextSlot++].SetDefaults(ItemID.LihzahrdPiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.LihzahrdPlatform);
                    shop.item[nextSlot++].SetDefaults(ItemID.LihzahrdSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.LihzahrdSofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.LihzahrdWorkBench);
                    break;
                case "Steampunk":
                    shop.item[nextSlot++].SetDefaults(ItemID.Cog);
                    shop.item[nextSlot++].SetDefaults(ItemID.SteampunkBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.SteampunkBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.SteampunkBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.SteampunkChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.SteampunkTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.SteampunkChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.SteampunkClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.SteampunkDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.SteampunkCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.SteampunkCandle);
                    shop.item[nextSlot++].SetDefaults(ItemID.SteampunkPiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.SteampunkPlatform);
                    shop.item[nextSlot++].SetDefaults(ItemID.SteampunkSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.SteampunkSofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.SteampunkWorkBench);
                    break;
                case "Flesh":
                    shop.item[nextSlot++].SetDefaults(ItemID.FleshBlock);
                    shop.item[nextSlot++].SetDefaults(ItemID.FleshBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.FleshBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.FleshBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.FleshChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.FleshTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.FleshChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.FleshClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.FleshDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.FleshCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.FleshCandle);
                    shop.item[nextSlot++].SetDefaults(ItemID.FleshPiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.FleshPlatform);
                    shop.item[nextSlot++].SetDefaults(ItemID.FleshSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.FleshSofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.FleshWorkBench);
                    break;
                case "Bone":
                    shop.item[nextSlot++].SetDefaults(ItemID.BoneBlock);
                    shop.item[nextSlot++].SetDefaults(ItemID.BoneBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.BoneBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.BoneBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.BoneChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.BoneTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.BoneChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.BoneClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.BoneDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.BoneCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.BonePiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.BonePlatform);
                    shop.item[nextSlot++].SetDefaults(ItemID.BoneSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.BoneSofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.BoneWorkBench);
                    break;
                case "Slime":
                    shop.item[nextSlot++].SetDefaults(ItemID.SlimeBlock);
                    shop.item[nextSlot++].SetDefaults(ItemID.SlimeBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.SlimeBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.SlimeBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.SlimeChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.SlimeTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.SlimeChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.SlimeClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.SlimeDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.SlimeCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.SlimeCandle);
                    shop.item[nextSlot++].SetDefaults(ItemID.SlimePiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.SlimePlatform);
                    shop.item[nextSlot++].SetDefaults(ItemID.SlimeSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.SlimeSofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.SlimeWorkBench);
                    break;
                case "Honey":
                    shop.item[nextSlot++].SetDefaults(ItemID.HoneyBlock);
                    shop.item[nextSlot++].SetDefaults(ItemID.HoneyBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.HoneyBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.HoneyBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.HoneyChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.HoneyTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.HoneyChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.HoneyClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.HoneyDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.HoneyCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.HoneyCandle);
                    shop.item[nextSlot++].SetDefaults(ItemID.HoneyPiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.HoneyPlatform);
                    shop.item[nextSlot++].SetDefaults(ItemID.HoneySink);
                    shop.item[nextSlot++].SetDefaults(ItemID.HoneySofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.HoneyWorkBench);
                    break;
                case "Frozen":
                    shop.item[nextSlot++].SetDefaults(ItemID.IceBlock);
                    shop.item[nextSlot++].SetDefaults(ItemID.FrozenBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.FrozenBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.FrozenBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.FrozenChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.FrozenTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.FrozenChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.FrozenClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.FrozenDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.FrozenCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.FrozenCandle);
                    shop.item[nextSlot++].SetDefaults(ItemID.FrozenPiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.FrozenPlatform);
                    shop.item[nextSlot++].SetDefaults(ItemID.FrozenSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.FrozenSofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.FrozenWorkBench);
                    break;
                case "Skyware":
                    shop.item[nextSlot++].SetDefaults(ItemID.SunplateBlock);
                    shop.item[nextSlot++].SetDefaults(ItemID.SkywareBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.SkywareBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.SkywareBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.SkywareChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.SkywareTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.SkywareChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.SkywareClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.SkywareDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.SkywareCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.SkywareCandle);
                    shop.item[nextSlot++].SetDefaults(ItemID.SkywarePiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.SkywarePlatform);
                    shop.item[nextSlot++].SetDefaults(ItemID.SkywareSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.SkywareSofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.SkywareWorkbench);
                    break;
                case "Living":
                    shop.item[nextSlot++].SetDefaults(ItemID.LivingWoodWand);
                    shop.item[nextSlot++].SetDefaults(ItemID.LivingLeafWall);
                    shop.item[nextSlot++].SetDefaults(ItemID.LivingWoodBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.LivingWoodBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.LivingWoodBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.LivingWoodChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.LivingWoodTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.LivingWoodChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.LivingWoodClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.LivingWoodDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.LivingWoodCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.LivingWoodCandle);
                    shop.item[nextSlot++].SetDefaults(ItemID.LivingWoodPiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.LivingWoodPlatform);
                    shop.item[nextSlot++].SetDefaults(ItemID.LivingWoodSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.LivingWoodSofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.LivingWoodWorkBench);
                    break;
                case "Glass":
                    shop.item[nextSlot++].SetDefaults(ItemID.Glass);
                    shop.item[nextSlot++].SetDefaults(ItemID.GlassBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.GlassBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.GlassBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.GlassChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.GlassTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.GlassChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.GlassClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.GlassDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.GlassCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.GlassCandle);
                    shop.item[nextSlot++].SetDefaults(ItemID.GlassPiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.GlassPlatform);
                    shop.item[nextSlot++].SetDefaults(ItemID.GlassSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.GlassSofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.GlassWorkBench);
                    break;
                case "Crystal":
                    shop.item[nextSlot++].SetDefaults(ItemID.CrystalBlock);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrystalBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrystalBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrystalBookCase);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrystalChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrystalTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrystalChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrystalClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrystalDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrystalCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrystalCandle);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrystalPiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrystalPlatform);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrystalSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrystalSofaHowDoesThatEvenWork);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrystalWorkbench);
                    break;
                case "Meteorite":
                    shop.item[nextSlot++].SetDefaults(ItemID.Meteorite);
                    shop.item[nextSlot++].SetDefaults(ItemID.MeteoriteBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.MeteoriteBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.MeteoriteBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.MeteoriteChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.MeteoriteTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.MeteoriteChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.MeteoriteClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.MeteoriteDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.MeteoriteCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.MeteoriteCandle);
                    shop.item[nextSlot++].SetDefaults(ItemID.MeteoritePiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.MeteoritePlatform);
                    shop.item[nextSlot++].SetDefaults(ItemID.MeteoriteSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.MeteoriteSofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.MeteoriteWorkBench);
                    break;
                case "Marble":
                    shop.item[nextSlot++].SetDefaults(ItemID.Marble);
                    shop.item[nextSlot++].SetDefaults(ItemID.MarbleBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.MarbleBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.MarbleBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.MarbleChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.MarbleTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.MarbleChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.MarbleClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.MarbleDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.MarbleCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.MarbleCandle);
                    shop.item[nextSlot++].SetDefaults(ItemID.MarblePiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.MarblePlatform);
                    shop.item[nextSlot++].SetDefaults(ItemID.MarbleSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.MarbleSofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.MarbleWorkBench);
                    break;
                case "Granite":
                    shop.item[nextSlot++].SetDefaults(ItemID.Granite);
                    shop.item[nextSlot++].SetDefaults(ItemID.GraniteBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.GraniteBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.GraniteBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.GraniteChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.GraniteTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.GraniteChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.GraniteClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.GraniteDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.GraniteCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.GraniteCandle);
                    shop.item[nextSlot++].SetDefaults(ItemID.GranitePiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.GranitePlatform);
                    shop.item[nextSlot++].SetDefaults(ItemID.GraniteSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.GraniteSofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.GraniteWorkBench);
                    break;
                case "Mushroom":
                    shop.item[nextSlot++].SetDefaults(ItemID.Mushroom);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.MushroomBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.MushroomBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.MushroomBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.MushroomChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.MushroomTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.MushroomChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.MushroomClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.MushroomDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.MushroomCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.MushroomCandle);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.MushroomPiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.MushroomPlatform);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.MushroomSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.MushroomSofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.MushroomWorkBench);
                    break;
                case "Pumpkin":
                    shop.item[nextSlot++].SetDefaults(ItemID.Pumpkin);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.PumpkinBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.PumpkinBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.PumpkinBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.PumpkinChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.PumpkinTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.PumpkinChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.PumpkinClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.PumpkinDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.PumpkinCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.PumpkinCandle);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.PumpkinPiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.PumpkinPlatform);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.PumpkinSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.PumpkinSofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.PumpkinWorkBench);
                    break;
                case "Cactus":
                    shop.item[nextSlot++].SetDefaults(ItemID.Cactus);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.CactusBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.CactusBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.CactusBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.CactusChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.CactusTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.CactusChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.CactusClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.CactusDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.CactusCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.CactusCandle);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.CactusPiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.CactusPlatform);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.CactusSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.CactusSofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.CactusWorkBench);
                    break;
                case "Dynasty":
                    shop.item[nextSlot++].SetDefaults(ItemID.DynastyWood);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.DynastyBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.DynastyBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.DynastyBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.DynastyChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.DynastyTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.DynastyChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.DynastyClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.DynastyDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.DynastyCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.DynastyCandle);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.DynastyPiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.DynastyPlatform);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.DynastySink);
                    shop.item[nextSlot++].SetDefaults(ItemID.DynastySofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.DynastyWorkBench);
                    break;
                case "Spooky":
                    shop.item[nextSlot++].SetDefaults(ItemID.SpookyWood);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.SpookyBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.SpookyBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.SpookyBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.SpookyChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.SpookyTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.SpookyChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.SpookyClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.SpookyDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.SpookyCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.SpookyCandle);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.SpookyPiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.SpookyPlatform);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.SpookySink);
                    shop.item[nextSlot++].SetDefaults(ItemID.SpookySofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.SpookyWorkBench);
                    break;
                case "Pearlwood":
                    shop.item[nextSlot++].SetDefaults(ItemID.Pearlwood);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.PearlwoodBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.PearlwoodBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.PearlwoodBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.PearlwoodCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.PearlwoodChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.PearlwoodTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.PearlwoodChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.PearlwoodClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.PearlwoodDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.PearlwoodCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.PearlwoodCandle);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.PearlwoodPiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.PearlwoodPlatform);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.PearlwoodSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.PearlwoodSofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.PearlwoodWorkBench);
                    break;
                case "Shadewood":
                    shop.item[nextSlot++].SetDefaults(ItemID.Shadewood);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.ShadewoodBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.ShadewoodBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.ShadewoodBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.ShadewoodCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.ShadewoodChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.ShadewoodTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.ShadewoodChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.ShadewoodClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.ShadewoodDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.ShadewoodCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.ShadewoodCandle);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.ShadewoodPiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.ShadewoodPlatform);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.ShadewoodSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.ShadewoodSofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.ShadewoodWorkBench);
                    break;
                case "Ebonwood":
                    shop.item[nextSlot++].SetDefaults(ItemID.Ebonwood);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.EbonwoodBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.EbonwoodBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.EbonwoodBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.EbonwoodCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.EbonwoodChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.EbonwoodTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.EbonwoodChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.EbonwoodClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.EbonwoodDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.EbonwoodCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.EbonwoodCandle);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.EbonwoodPiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.EbonwoodPlatform);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.EbonwoodSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.EbonwoodSofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.EbonwoodWorkBench);
                    break;
                case "Palm":
                    shop.item[nextSlot++].SetDefaults(ItemID.PalmWood);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.PalmWoodBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.PalmWoodBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.PalmWoodBench);
                    shop.item[nextSlot++].SetDefaults(ItemID.PalmWoodBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.PalmWoodCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.PalmWoodChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.PalmWoodTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.PalmWoodChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.PalmWoodClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.PalmWoodDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.PalmWoodCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.PalmWoodCandle);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.PalmWoodPiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.PalmWoodPlatform);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.PalmWoodSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.PalmWoodSofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.PalmWoodWorkBench);
                    break;
                case "Boreal":
                    shop.item[nextSlot++].SetDefaults(ItemID.BorealWood);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.BorealWoodBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.BorealWoodBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.BorealWoodBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.BorealWoodCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.BorealWoodChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.BorealWoodTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.BorealWoodChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.BorealWoodClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.BorealWoodDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.BorealWoodCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.BorealWoodCandle);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.BorealWoodPiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.BorealWoodPlatform);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.BorealWoodSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.BorealWoodSofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.BorealWoodWorkBench);
                    break;
                case "Rich Mahogany":
                    shop.item[nextSlot++].SetDefaults(ItemID.RichMahogany);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.RichMahoganyBathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.RichMahoganyBed);
                    shop.item[nextSlot++].SetDefaults(ItemID.RichMahoganyBookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.RichMahoganyCandelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.RichMahoganyCandle);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.RichMahoganyChair);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.RichMahoganyTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.RichMahoganyChest);
                    shop.item[nextSlot++].SetDefaults(ItemID.RichMahoganyClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.RichMahoganyDresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.RichMahoganyLamp);
                    shop.item[nextSlot++].SetDefaults(ItemID.RichMahoganyLantern);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.RichMahoganyPiano);
                    shop.item[nextSlot++].SetDefaults(ItemID.RichMahoganyPlatform);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.RichMahoganySink);
                    shop.item[nextSlot++].SetDefaults(ItemID.RichMahoganySofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.RichMahoganyWorkBench);
                    break;
                case "Wood":
                    shop.item[nextSlot++].SetDefaults(ItemID.Wood);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.Bathtub);
                    shop.item[nextSlot++].SetDefaults(ItemID.Bed);
                    shop.item[nextSlot++].SetDefaults(ItemID.Bench);
                    shop.item[nextSlot++].SetDefaults(ItemID.Bookcase);
                    shop.item[nextSlot++].SetDefaults(ItemID.Candelabra);
                    shop.item[nextSlot++].SetDefaults(ItemID.Candle);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.WoodenChair);
                    shop.item[nextSlot++].SetDefaults(ItemID.WoodenTable);
                    shop.item[nextSlot++].SetDefaults(ItemID.Chest);
                    shop.item[nextSlot++].SetDefaults(ItemID.GrandfatherClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.Dresser);
                    shop.item[nextSlot++].SetDefaults(ItemID.TikiTorch);
                    shop.item[nextSlot++].SetDefaults(ItemID.Piano);
                    shop.item[nextSlot++].SetDefaults(ItemID.WoodPlatform);
                    
                    shop.item[nextSlot++].SetDefaults(ItemID.WoodenSink);
                    shop.item[nextSlot++].SetDefaults(ItemID.Sofa);
                    shop.item[nextSlot++].SetDefaults(ItemID.WorkBench);
                    break;
                case "Mechanics":
                    shop.item[nextSlot++].SetDefaults(ItemID.Wrench);
                    shop.item[nextSlot++].SetDefaults(ItemID.BlueWrench);
                    shop.item[nextSlot++].SetDefaults(ItemID.GreenWrench);
                    shop.item[nextSlot++].SetDefaults(ItemID.YellowWrench);
                    shop.item[nextSlot++].SetDefaults(ItemID.WireCutter);
                    shop.item[nextSlot++].SetDefaults(ItemID.Wire);
                    shop.item[nextSlot++].SetDefaults(ItemID.Lever);
                    shop.item[nextSlot++].SetDefaults(ItemID.Switch);
                    shop.item[nextSlot++].SetDefaults(ItemID.RedPressurePlate);
                    shop.item[nextSlot++].SetDefaults(ItemID.BluePressurePlate);
                    shop.item[nextSlot++].SetDefaults(ItemID.BrownPressurePlate);
                    shop.item[nextSlot++].SetDefaults(ItemID.GrayPressurePlate);
                    shop.item[nextSlot++].SetDefaults(ItemID.GreenPressurePlate);
                    shop.item[nextSlot++].SetDefaults(ItemID.YellowPressurePlate);
                    shop.item[nextSlot++].SetDefaults(ItemID.ProjectilePressurePad);
                    shop.item[nextSlot++].SetDefaults(ItemID.BoosterTrack);
                    shop.item[nextSlot++].SetDefaults(ItemID.Actuator);
                    shop.item[nextSlot++].SetDefaults(ItemID.WirePipe);
                    shop.item[nextSlot++].SetDefaults(ItemID.WireBulb);
                    shop.item[nextSlot++].SetDefaults(ItemID.Timer1Second);
                    shop.item[nextSlot++].SetDefaults(ItemID.Timer3Second);
                    shop.item[nextSlot++].SetDefaults(ItemID.Timer5Second);
                    break;
                default:
                    shop.SetupShop(8);
                    break;
            }
        }
    }
}
