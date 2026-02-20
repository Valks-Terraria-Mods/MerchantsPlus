namespace MerchantsPlus.Shops;

public static class ShopStylistCatalog
{
    private static readonly int _bannerCostEasy = Coins.Gold();
    private static readonly int _bannerCostHard = Coins.Gold(10);
    private static readonly int _bannerCostInsane = Coins.Gold(25);

    public const string HairDyesShopName = "Hair Dyes";

    public static readonly string[] ShopNames =
    [
        HairDyesShopName,
        "Overworld",
        "Underworld",
        "Desert",
        "Snow",
        "Jungle",
        "Ocean",
        "Corruption",
        "Crimson",
        "Hallow",
        "Space",
        "Mushroom",
        "Dungeon",
        "Bloodmoon",
        "Eclipse",
        "Goblin Army",
        "Old Ones Army",
        "Frost Legion",
        "Pumpkin Moon",
        "Frost Moon",
        "Pirate Invasion",
        "Martian Madness",
        "Solar Zone",
        "Vortex Zone",
        "Nebula Zone",
        "Stardust Zone",
    ];

    public static readonly int[] HairDyes =
    [
        ItemID.HairDyeRemover,
        ItemID.DepthHairDye,
        ItemID.LifeHairDye,
        ItemID.ManaHairDye,
        ItemID.MoneyHairDye,
        ItemID.TimeHairDye,
        ItemID.TeamHairDye,
        ItemID.PartyHairDye,
        ItemID.BiomeHairDye,
        ItemID.SpeedHairDye,
        ItemID.RainbowHairDye,
        ItemID.MartianHairDye,
        ItemID.TwilightHairDye,
    ];

    public static readonly IReadOnlyDictionary<string, NpcBannerOffer[]> BannerOffersByShop = new Dictionary<string, NpcBannerOffer[]>
    {
        ["Eclipse"] =
        [
            new(ItemID.EyezorBanner, _bannerCostHard, NPCID.Eyezor),
            new(ItemID.FrankensteinBanner, _bannerCostHard, NPCID.Frankenstein),
            new(ItemID.SwampThingBanner, _bannerCostHard, NPCID.SwampThing),
            new(ItemID.VampireBanner, _bannerCostHard, NPCID.Vampire),
            new(ItemID.CreatureFromTheDeepBanner, _bannerCostHard, NPCID.CreatureFromTheDeep),
            new(ItemID.FritzBanner, _bannerCostHard, NPCID.Fritz),
            new(ItemID.ReaperBanner, _bannerCostHard, NPCID.Reaper),
            new(ItemID.ThePossessedBanner, _bannerCostHard, NPCID.ThePossessed),
            new(ItemID.MothronBanner, _bannerCostHard, NPCID.Mothron),
            new(ItemID.ButcherBanner, _bannerCostHard, NPCID.Butcher),
            new(ItemID.DeadlySphereBanner, _bannerCostHard, NPCID.DeadlySphere),
            new(ItemID.DrManFlyBanner, _bannerCostHard, NPCID.DrManFly),
            new(ItemID.NailheadBanner, _bannerCostHard, NPCID.Nailhead),
            new(ItemID.PsychoBanner, _bannerCostHard, NPCID.Psycho),
        ],

        ["Bloodmoon"] =
        [
            new(ItemID.BloodZombieBanner, _bannerCostEasy, NPCID.BloodZombie),
            new(ItemID.DripplerBanner, _bannerCostEasy, NPCID.Drippler),
            new(ItemID.TheGroomBanner, _bannerCostEasy, NPCID.TheGroom),
            new(ItemID.CorruptBunnyBanner, _bannerCostEasy, NPCID.CorruptBunny),
            new(ItemID.CorruptGoldfishBanner, _bannerCostEasy, NPCID.CorruptGoldfish),
            new(ItemID.CorruptPenguinBanner, _bannerCostEasy, NPCID.CorruptPenguin),
            new(ItemID.ClownBanner, _bannerCostHard, NPCID.Clown),
        ],

        ["Goblin Army"] =
        [
            new(ItemID.GoblinPeonBanner, _bannerCostEasy, NPCID.GoblinPeon),
            new(ItemID.GoblinSorcererBanner, _bannerCostEasy, NPCID.GoblinSorcerer),
            new(ItemID.GoblinThiefBanner, _bannerCostEasy, NPCID.GoblinThief),
            new(ItemID.GoblinWarriorBanner, _bannerCostEasy, NPCID.GoblinWarrior),
            new(ItemID.GoblinArcherBanner, _bannerCostEasy, NPCID.GoblinArcher),
            new(ItemID.GoblinSummonerBanner, _bannerCostHard, NPCID.GoblinSummoner),
        ],

        ["Dungeon"] =
        [
            new(ItemID.AngryBonesBanner, _bannerCostHard, NPCID.AngryBones),
            new(ItemID.SkeletonMageBanner, _bannerCostHard, NPCID.DarkCaster),
            new(ItemID.CursedSkullBanner, _bannerCostHard, NPCID.CursedSkull),
            new(ItemID.DungeonSlimeBanner, _bannerCostHard, NPCID.DungeonSlime),
            new(ItemID.BlueArmoredBonesBanner, _bannerCostHard, NPCID.BlueArmoredBones),
            new(ItemID.RustyArmoredBonesBanner, _bannerCostHard, NPCID.RustyArmoredBonesSword),
            new(ItemID.HellArmoredBonesBanner, _bannerCostHard, NPCID.HellArmoredBones),
            new(ItemID.PaladinBanner, _bannerCostHard, NPCID.Paladin),
            new(ItemID.NecromancerBanner, _bannerCostHard, NPCID.Necromancer),
            new(ItemID.RaggedCasterBanner, _bannerCostHard, NPCID.RaggedCaster),
            new(ItemID.SkeletonCommandoBanner, _bannerCostHard, NPCID.SkeletonCommando),
            new(ItemID.SkeletonSniperBanner, _bannerCostHard, NPCID.SkeletonSniper),
            new(ItemID.TacticalSkeletonBanner, _bannerCostHard, NPCID.TacticalSkeleton),
            new(ItemID.GiantCursedSkullBanner, _bannerCostHard, NPCID.GiantCursedSkull),
            new(ItemID.BoneLeeBanner, _bannerCostHard, NPCID.BoneLee),
            new(ItemID.DungeonSpiritBanner, _bannerCostHard, NPCID.DungeonSpirit),
        ],

        ["Desert"] =
        [
            new(ItemID.AntlionBanner, _bannerCostHard, NPCID.Antlion),
            new(ItemID.FlyingAntlionBanner, _bannerCostHard, NPCID.FlyingAntlion),
            new(ItemID.WalkingAntlionBanner, _bannerCostHard, NPCID.WalkingAntlion),
            new(ItemID.VultureBanner, _bannerCostHard, NPCID.Vulture),
            new(ItemID.SandSlimeBanner, _bannerCostHard, NPCID.SandSlime),
            new(ItemID.MummyBanner, _bannerCostHard, NPCID.Mummy),
            new(ItemID.LightMummyBanner, _bannerCostHard, NPCID.LightMummy),
            new(ItemID.DarkMummyBanner, _bannerCostHard, NPCID.DarkMummy),
            new(ItemID.DesertBasiliskBanner, _bannerCostHard, NPCID.DesertBeast),
            new(ItemID.DesertLamiaBanner, _bannerCostHard, NPCID.DesertLamiaDark, NPCID.DesertLamiaLight),
            new(ItemID.DesertGhoulBanner, _bannerCostHard, NPCID.DesertGhoul),
            new(ItemID.DungeonSpiritBanner, _bannerCostHard, NPCID.DungeonSpirit),
            new(ItemID.TumbleweedBanner, _bannerCostHard, NPCID.Tumbleweed),
            new(ItemID.SandsharkBanner, _bannerCostHard, NPCID.SandShark),
            new(ItemID.DuneSplicerBanner, _bannerCostHard, NPCID.DuneSplicerHead),
            new(ItemID.SandElementalBanner, _bannerCostHard, NPCID.SandElemental),
        ],

        ["Old Ones Army"] =
        [
            new(ItemID.DD2WyvernBanner, _bannerCostHard, NPCID.DD2WyvernT1),
            new(ItemID.DD2JavelinThrowerBanner, _bannerCostHard, NPCID.DD2JavelinstT1),
            new(ItemID.DD2SkeletonBanner, _bannerCostHard, NPCID.DD2SkeletonT1),
            new(ItemID.DD2GoblinBanner, _bannerCostHard, NPCID.DD2GoblinT1),
            new(ItemID.DD2GoblinBomberBanner, _bannerCostHard, NPCID.DD2GoblinBomberT1),
            new(ItemID.DD2LightningBugBanner, _bannerCostHard, NPCID.DD2LightningBugT3),
            new(ItemID.DD2KoboldBanner, _bannerCostHard, NPCID.DD2KoboldWalkerT2),
            new(ItemID.DD2KoboldFlyerBanner, _bannerCostHard, NPCID.DD2KoboldFlyerT2),
            new(ItemID.DD2DrakinBanner, _bannerCostHard, NPCID.DD2DrakinT2),
        ],

        ["Frost Legion"] =
        [
            new(ItemID.MisterStabbyBanner, _bannerCostHard, NPCID.MisterStabby),
            new(ItemID.SnowmanGangstaBanner, _bannerCostHard, NPCID.SnowmanGangsta),
            new(ItemID.SnowBallaBanner, _bannerCostHard, NPCID.SnowBalla),
        ],

        ["Pirate Invasion"] =
        [
            new(ItemID.PirateBanner, _bannerCostHard, NPCID.Pirate),
            new(ItemID.PirateDeadeyeBanner, _bannerCostHard, NPCID.PirateDeadeye),
            new(ItemID.PirateCorsairBanner, _bannerCostHard, NPCID.PirateCorsair),
            new(ItemID.PirateCrossbowerBanner, _bannerCostHard, NPCID.PirateCrossbower),
            new(ItemID.PirateCaptainBanner, _bannerCostHard, NPCID.PirateCaptain),
            new(ItemID.ParrotBanner, _bannerCostHard, NPCID.Parrot),
        ],

        ["Pumpkin Moon"] =
        [
            new(ItemID.ScarecrowBanner, _bannerCostHard, NPCID.Scarecrow1),
            new(ItemID.SplinterlingBanner, _bannerCostHard, NPCID.Splinterling),
            new(ItemID.HellhoundBanner, _bannerCostHard, NPCID.Hellhound),
            new(ItemID.PoltergeistBanner, _bannerCostHard, NPCID.Poltergeist),
            new(ItemID.HeadlessHorsemanBanner, _bannerCostHard, NPCID.HeadlessHorseman),
        ],

        ["Frost Moon"] =
        [
            new(ItemID.GingerbreadManBanner, _bannerCostHard, NPCID.GingerbreadMan),
            new(ItemID.ZombieElfBanner, _bannerCostHard, NPCID.ZombieElf),
            new(ItemID.ElfArcherBanner, _bannerCostHard, NPCID.ElfArcher),
            new(ItemID.NutcrackerBanner, _bannerCostHard, NPCID.Nutcracker),
            new(ItemID.YetiBanner, _bannerCostHard, NPCID.Yeti),
            new(ItemID.ElfCopterBanner, _bannerCostHard, NPCID.ElfCopter),
            new(ItemID.KrampusBanner, _bannerCostHard, NPCID.Krampus),
            new(ItemID.FlockoBanner, _bannerCostHard, NPCID.Flocko),
        ],

        ["Martian Madness"] =
        [
            new(ItemID.ScutlixBanner, _bannerCostHard, NPCID.Scutlix),
            new(ItemID.MartianWalkerBanner, _bannerCostHard, NPCID.MartianWalker),
            new(ItemID.MartianDroneBanner, _bannerCostHard, NPCID.MartianDrone),
            new(ItemID.MartianTeslaTurretBanner, _bannerCostHard, NPCID.MartianTurret),
            new(ItemID.MartianGigazapperBanner, _bannerCostHard, NPCID.GigaZapper),
            new(ItemID.MartianEngineerBanner, _bannerCostHard, NPCID.MartianEngineer),
            new(ItemID.MartianOfficerBanner, _bannerCostHard, NPCID.MartianOfficer),
            new(ItemID.MartianRaygunnerBanner, _bannerCostHard, NPCID.RayGunner),
            new(ItemID.MartianGreyGruntBanner, _bannerCostHard, NPCID.GrayGrunt),
            new(ItemID.MartianBrainscramblerBanner, _bannerCostHard, NPCID.BrainScrambler),
        ],

        ["Solar Zone"] =
        [
            new(ItemID.SolarSolenianBanner, _bannerCostInsane, NPCID.SolarSolenian),
            new(ItemID.SolarDrakomireBanner, _bannerCostInsane, NPCID.SolarDrakomire),
            new(ItemID.SolarDrakomireRiderBanner, _bannerCostInsane, NPCID.SolarDrakomireRider),
            new(ItemID.SolarCoriteBanner, _bannerCostInsane, NPCID.SolarCorite),
            new(ItemID.SolarSrollerBanner, _bannerCostInsane, NPCID.SolarSroller),
            new(ItemID.SolarCrawltipedeBanner, _bannerCostInsane, NPCID.SolarCrawltipedeHead),
        ],

        ["Vortex Zone"] =
        [
            new(ItemID.VortexHornetBanner, _bannerCostInsane, NPCID.VortexHornet),
            new(ItemID.VortexHornetQueenBanner, _bannerCostInsane, NPCID.VortexHornetQueen),
            new(ItemID.VortexLarvaBanner, _bannerCostInsane, NPCID.VortexLarva),
            new(ItemID.VortexRiflemanBanner, _bannerCostInsane, NPCID.VortexRifleman),
            new(ItemID.VortexSoldierBanner, _bannerCostInsane, NPCID.VortexSoldier),
        ],

        ["Nebula Zone"] =
        [
            new(ItemID.NebulaBeastBanner, _bannerCostInsane, NPCID.NebulaBeast),
            new(ItemID.NebulaBrainBanner, _bannerCostInsane, NPCID.NebulaBrain),
            new(ItemID.NebulaHeadcrabBanner, _bannerCostInsane, NPCID.NebulaHeadcrab),
            new(ItemID.NebulaSoldierBanner, _bannerCostInsane, NPCID.NebulaSoldier),
        ],

        ["Stardust Zone"] =
        [
            new(ItemID.StardustJellyfishBanner, _bannerCostInsane, NPCID.StardustJellyfishSmall),
            new(ItemID.StardustLargeCellBanner, _bannerCostInsane, NPCID.StardustJellyfishBig),
            new(ItemID.StardustSmallCellBanner, _bannerCostInsane, NPCID.StardustCellSmall),
            new(ItemID.StardustSoldierBanner, _bannerCostInsane, NPCID.StardustSoldier),
            new(ItemID.StardustSpiderBanner, _bannerCostInsane, NPCID.StardustSpiderSmall),
            new(ItemID.StardustWormBanner, _bannerCostInsane, NPCID.StardustWormHead),
        ],

        ["Ocean"] =
        [
            new(ItemID.PinkJellyfishBanner, _bannerCostEasy, NPCID.PinkJellyfish),
            new(ItemID.CrabBanner, _bannerCostEasy, NPCID.Crab),
            new(ItemID.SeaSnailBanner, _bannerCostEasy, NPCID.SeaSnail),
            new(ItemID.SquidBanner, _bannerCostEasy, NPCID.Squid),
            new(ItemID.SharkBanner, _bannerCostEasy, NPCID.Shark),
        ],

        ["Snow"] =
        [
            new(ItemID.IceSlimeBanner, _bannerCostEasy, NPCID.IceSlime),
            new(ItemID.ZombieEskimoBanner, _bannerCostEasy, NPCID.ZombieEskimo),
            new(ItemID.IceElementalBanner, _bannerCostHard, NPCID.IceElemental),
            new(ItemID.WolfBanner, _bannerCostHard, NPCID.Wolf),
            new(ItemID.IceGolemBanner, _bannerCostInsane, NPCID.IceGolem),
            new(ItemID.PenguinBanner, _bannerCostEasy, NPCID.Penguin),
            new(ItemID.IceBatBanner, _bannerCostEasy, NPCID.IceBat),
            new(ItemID.SnowFlinxBanner, _bannerCostEasy, NPCID.SnowFlinx),
            new(ItemID.SpikedIceSlimeBanner, _bannerCostEasy, NPCID.SpikedIceSlime),
            new(ItemID.UndeadVikingBanner, _bannerCostEasy, NPCID.UndeadViking),
            new(ItemID.ArmoredVikingBanner, _bannerCostHard, NPCID.ArmoredViking),
            new(ItemID.IceTortoiseBanner, _bannerCostHard, NPCID.IceTortoise),
            new(ItemID.IceElementalBanner, _bannerCostHard, NPCID.IceElemental),
            new(ItemID.IcyMermanBanner, _bannerCostHard, NPCID.IcyMerman),
            new(ItemID.PigronBanner, _bannerCostHard, NPCID.PigronCorruption),
        ],

        ["Jungle"] =
        [
            new(ItemID.PiranhaBanner, _bannerCostEasy, NPCID.Piranha),
            new(ItemID.SnatcherBanner, _bannerCostEasy, NPCID.Snatcher),
            new(ItemID.JungleBatBanner, _bannerCostEasy, NPCID.JungleBat),
            new(ItemID.JungleSlimeBanner, _bannerCostEasy, NPCID.JungleSlime),
            new(ItemID.DoctorBonesBanner, _bannerCostEasy, NPCID.DoctorBones),
            new(ItemID.AnglerFishBanner, _bannerCostHard, NPCID.AnglerFish),
            new(ItemID.ArapaimaBanner, _bannerCostHard, NPCID.Arapaima),
            new(ItemID.TortoiseBanner, _bannerCostHard, NPCID.GiantTortoise),
            new(ItemID.AngryTrapperBanner, _bannerCostHard, NPCID.AngryTrapper),
            new(ItemID.DerplingBanner, _bannerCostHard, NPCID.Derpling),
            new(ItemID.GiantFlyingFoxBanner, _bannerCostHard, NPCID.GiantFlyingFox),
            new(ItemID.HornetBanner, _bannerCostEasy, NPCID.Hornet),
            new(ItemID.ManEaterBanner, _bannerCostEasy, NPCID.ManEater),
            new(ItemID.SpikedJungleSlimeBanner, _bannerCostEasy, NPCID.SpikedJungleSlime),
            new(ItemID.LacBeetleBanner, _bannerCostEasy, NPCID.LacBeetle),
            new(ItemID.JungleCreeperBanner, _bannerCostHard, NPCID.JungleCreeper),
            new(ItemID.MothBanner, _bannerCostHard, NPCID.Moth),
            new(ItemID.LihzahrdBanner, _bannerCostHard, NPCID.Lihzahrd),
            new(ItemID.FlyingSnakeBanner, _bannerCostHard, NPCID.FlyingSnake),
        ],

        ["Mushroom"] =
        [
            new(ItemID.FungiBulbBanner, _bannerCostHard, NPCID.FungiBulb),
            new(ItemID.AnomuraFungusBanner, _bannerCostHard, NPCID.AnomuraFungus),
            new(ItemID.MushiLadybugBanner, _bannerCostHard, NPCID.MushiLadybug),
            new(ItemID.SporeZombieBanner, _bannerCostHard, NPCID.Spore),
            new(ItemID.FungoFishBanner, _bannerCostHard, NPCID.FungoFish),
        ],

        ["Corruption"] =
        [
            new(ItemID.EaterofSoulsBanner, _bannerCostEasy, NPCID.EaterofSouls),
            new(ItemID.DevourerBanner, _bannerCostEasy, NPCID.DevourerHead),
            new(ItemID.CorruptorBanner, _bannerCostHard, NPCID.Corruptor),
            new(ItemID.CorruptSlimeBanner, _bannerCostHard, NPCID.CorruptSlime),
            new(ItemID.SlimerBanner, _bannerCostHard, NPCID.Slimer),
            new(ItemID.WorldFeederBanner, _bannerCostHard, NPCID.BloodFeeder),
            new(ItemID.CursedHammerBanner, _bannerCostHard, NPCID.CursedHammer),
            new(ItemID.ClingerBanner, _bannerCostHard, NPCID.Clinger),
        ],

        ["Crimson"] =
        [
            new(ItemID.BloodCrawlerBanner, _bannerCostEasy, NPCID.BloodCrawler),
            new(ItemID.FaceMonsterBanner, _bannerCostEasy, NPCID.FaceMonster),
            new(ItemID.CrimeraBanner, _bannerCostEasy, NPCID.Crimera),
            new(ItemID.HerplingBanner, _bannerCostHard, NPCID.Herpling),
            new(ItemID.CrimslimeBanner, _bannerCostHard, NPCID.Crimslime),
            new(ItemID.BloodJellyBanner, _bannerCostHard, NPCID.BloodJelly),
            new(ItemID.BloodFeederBanner, _bannerCostHard, NPCID.BloodFeeder),
            new(ItemID.CrimsonAxeBanner, _bannerCostHard, NPCID.CrimsonAxe),
            new(ItemID.IchorStickerBanner, _bannerCostHard, NPCID.IchorSticker),
            new(ItemID.FloatyGrossBanner, _bannerCostHard, NPCID.FloatyGross),
        ],

        ["Hallow"] =
        [
            new(ItemID.PixieBanner, _bannerCostHard, NPCID.Pixie),
            new(ItemID.UnicornBanner, _bannerCostHard, NPCID.Unicorn),
            new(ItemID.RainbowSlimeBanner, _bannerCostHard, NPCID.RainbowSlime),
            new(ItemID.GastropodBanner, _bannerCostHard, NPCID.Gastropod),
            new(ItemID.DD2LightningBugBanner, _bannerCostHard, NPCID.DD2LightningBugT3),
            new(ItemID.IlluminantSlimeBanner, _bannerCostHard, NPCID.IlluminantSlime),
            new(ItemID.IlluminantBatBanner, _bannerCostHard, NPCID.IlluminantBat),
            new(ItemID.ChaosElementalBanner, _bannerCostHard, NPCID.ChaosElemental),
            new(ItemID.EnchantedSwordBanner, _bannerCostHard, NPCID.EnchantedSword),
        ],

        ["Space"] =
        [
            new(ItemID.HarpyBanner, _bannerCostEasy, NPCID.Harpy),
            new(ItemID.WyvernBanner, _bannerCostHard, NPCID.WyvernHead),
        ],

        ["Underworld"] =
        [
            new(ItemID.HellbatBanner, _bannerCostEasy, NPCID.Hellbat),
            new(ItemID.LavaSlimeBanner, _bannerCostEasy, NPCID.LavaSlime),
            new(ItemID.FireImpBanner, _bannerCostEasy, NPCID.FireImp),
            new(ItemID.DemonBanner, _bannerCostEasy, NPCID.Demon),
            new(ItemID.BoneSerpentBanner, _bannerCostEasy, NPCID.BoneSerpentHead),
            new(ItemID.LavaBatBanner, _bannerCostHard, NPCID.Lavabat),
            new(ItemID.RedDevilBanner, _bannerCostHard, NPCID.RedDevil),
        ],

        ["Overworld"] =
        [
            new(ItemID.SlimeBanner, _bannerCostEasy, NPCID.BlueSlime),
            new(ItemID.GreenSlimeBanner, _bannerCostEasy, NPCID.GreenSlime),
            new(ItemID.PurpleSlimeBanner, _bannerCostEasy, NPCID.PurpleSlime),
            new(ItemID.PinkyBanner, _bannerCostEasy, NPCID.Pinky),
            new(ItemID.ZombieBanner, _bannerCostEasy, NPCID.Zombie),
            new(ItemID.RavenBanner, _bannerCostEasy, NPCID.Raven),
            new(ItemID.DemonEyeBanner, _bannerCostEasy, NPCID.DemonEye),
            new(ItemID.PossessedArmorBanner, _bannerCostHard, NPCID.PossessedArmor),
            new(ItemID.HoppinJackBanner, _bannerCostHard, NPCID.HoppinJack),
            new(ItemID.WerewolfBanner, _bannerCostHard, NPCID.Werewolf),
            new(ItemID.BunnyBanner, _bannerCostEasy, NPCID.Bunny),
            new(ItemID.BirdBanner, _bannerCostEasy, NPCID.Bird),
            new(ItemID.WormBanner, _bannerCostEasy, NPCID.Worm),
            new(ItemID.RedSlimeBanner, _bannerCostEasy, NPCID.RedSlime),
            new(ItemID.YellowSlimeBanner, _bannerCostEasy, NPCID.YellowSlime),
            new(ItemID.ToxicSludgeBanner, _bannerCostHard, NPCID.ToxicSludge),
            new(ItemID.SkeletonBanner, _bannerCostEasy, NPCID.Skeleton),
            new(ItemID.SalamanderBanner, _bannerCostEasy, NPCID.Salamander),
            new(ItemID.CrawdadBanner, _bannerCostEasy, NPCID.Crawdad),
            new(ItemID.GiantShellyBanner, _bannerCostEasy, NPCID.GiantShelly),
            new(ItemID.UndeadMinerBanner, _bannerCostEasy, NPCID.UndeadMiner),
            new(ItemID.TimBanner, _bannerCostEasy, NPCID.Tim),
            new(ItemID.NypmhBanner, _bannerCostEasy, NPCID.Nymph),
            new(ItemID.CochinealBeetleBanner, _bannerCostEasy, NPCID.CochinealBeetle),
            new(ItemID.JellyfishBanner, _bannerCostEasy, NPCID.BlueJellyfish),
            new(ItemID.GreenJellyfishBanner, _bannerCostEasy, NPCID.GreenJellyfish),
            new(ItemID.PinkJellyfishBanner, _bannerCostEasy, NPCID.PinkJellyfish),
            new(ItemID.SpiderBanner, _bannerCostEasy, NPCID.WallCreeper),
            new(ItemID.BlackRecluseBanner, _bannerCostHard, NPCID.BlackRecluse),
            new(ItemID.GraniteGolemBanner, _bannerCostEasy, NPCID.GraniteGolem),
            new(ItemID.GraniteFlyerBanner, _bannerCostEasy, NPCID.GraniteFlyer),
            new(ItemID.MedusaBanner, _bannerCostHard, NPCID.Medusa),
            new(ItemID.MeteorHeadBanner, _bannerCostEasy, NPCID.MeteorHead),
            new(ItemID.FlyingFishBanner, _bannerCostEasy, NPCID.FlyingFish),
            new(ItemID.UmbrellaSlimeBanner, _bannerCostEasy, NPCID.UmbrellaSlime),
            new(ItemID.RaincoatZombieBanner, _bannerCostEasy, NPCID.ZombieRaincoat),
            new(ItemID.AngryNimbusBanner, _bannerCostHard, NPCID.AngryNimbus),
        ],

    };
}
