namespace MerchantsPlus.Shops;

public class ShopStylist : Shop
{
    public override List<string> Shops { get; } = 
    [
        "Hair Dyes",
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
        "Stardust Zone"
    ];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        int bannerKillsRequirement = 50;
        int bannerCostEasy = Coins.Gold();
        int bannerCostHard = Coins.Gold(10);
        int bannerCostInsane = Coins.Gold(25);

        if (shop == "Eclipse")
        {
            AddItem(WorldUtils.Kills(NPCID.Eyezor) >= bannerKillsRequirement, ItemID.EyezorBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Frankenstein) >= bannerKillsRequirement, ItemID.FrankensteinBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.SwampThing) >= bannerKillsRequirement, ItemID.SwampThingBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Vampire) >= bannerKillsRequirement, ItemID.VampireBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.CreatureFromTheDeep) >= bannerKillsRequirement, ItemID.CreatureFromTheDeepBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Fritz) >= bannerKillsRequirement, ItemID.FritzBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Reaper) >= bannerKillsRequirement, ItemID.ReaperBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.ThePossessed) >= bannerKillsRequirement, ItemID.ThePossessedBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Mothron) >= bannerKillsRequirement, ItemID.MothronBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Butcher) >= bannerKillsRequirement, ItemID.ButcherBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.DeadlySphere) >= bannerKillsRequirement, ItemID.DeadlySphereBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.DrManFly) >= bannerKillsRequirement, ItemID.DrManFlyBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Nailhead) >= bannerKillsRequirement, ItemID.NailheadBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Psycho) >= bannerKillsRequirement, ItemID.PsychoBanner, bannerCostHard);
            return;
        }

        if (shop == "Bloodmoon")
        {
            AddItem(WorldUtils.Kills(NPCID.BloodZombie) >= bannerKillsRequirement, ItemID.BloodZombieBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.Drippler) >= bannerKillsRequirement, ItemID.DripplerBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.TheGroom) >= bannerKillsRequirement, ItemID.TheGroomBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.CorruptBunny) >= bannerKillsRequirement, ItemID.CorruptBunnyBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.CorruptGoldfish) >= bannerKillsRequirement, ItemID.CorruptGoldfishBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.CorruptPenguin) >= bannerKillsRequirement, ItemID.CorruptPenguinBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.Clown) >= bannerKillsRequirement, ItemID.ClownBanner, bannerCostHard);
            return;
        }

        if (shop == "Goblin Army")
        {
            AddItem(WorldUtils.Kills(NPCID.GoblinPeon) >= bannerKillsRequirement, ItemID.GoblinPeonBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.GoblinSorcerer) >= bannerKillsRequirement, ItemID.GoblinSorcererBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.GoblinThief) >= bannerKillsRequirement, ItemID.GoblinThiefBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.GoblinWarrior) >= bannerKillsRequirement, ItemID.GoblinWarriorBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.GoblinArcher) >= bannerKillsRequirement, ItemID.GoblinArcherBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.GoblinSummoner) >= bannerKillsRequirement, ItemID.GoblinSummonerBanner, bannerCostHard);
            return;
        }

        if (shop == "Dungeon")
        {
            AddItem(WorldUtils.Kills(NPCID.AngryBones) >= bannerKillsRequirement, ItemID.AngryBonesBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.DarkCaster) >= bannerKillsRequirement, ItemID.SkeletonMageBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.CursedSkull) >= bannerKillsRequirement, ItemID.CursedSkullBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.DungeonSlime) >= bannerKillsRequirement, ItemID.DungeonSlimeBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.BlueArmoredBones) >= bannerKillsRequirement, ItemID.BlueArmoredBonesBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.RustyArmoredBonesSword) >= bannerKillsRequirement, ItemID.RustyArmoredBonesBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.HellArmoredBones) >= bannerKillsRequirement, ItemID.HellArmoredBonesBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Paladin) >= bannerKillsRequirement, ItemID.PaladinBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Necromancer) >= bannerKillsRequirement, ItemID.NecromancerBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.RaggedCaster) >= bannerKillsRequirement, ItemID.RaggedCasterBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.SkeletonCommando) >= bannerKillsRequirement, ItemID.SkeletonCommandoBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.SkeletonSniper) >= bannerKillsRequirement, ItemID.SkeletonSniperBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.TacticalSkeleton) >= bannerKillsRequirement, ItemID.TacticalSkeletonBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.GiantCursedSkull) >= bannerKillsRequirement, ItemID.GiantCursedSkullBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.BoneLee) >= bannerKillsRequirement, ItemID.BoneLeeBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.DungeonSpirit) >= bannerKillsRequirement, ItemID.DungeonSpiritBanner, bannerCostHard);
            return;
        }

        if (shop == "Desert")
        {
            AddItem(WorldUtils.Kills(NPCID.Antlion) >= bannerKillsRequirement, ItemID.AntlionBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.FlyingAntlion) >= bannerKillsRequirement, ItemID.FlyingAntlionBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.WalkingAntlion) >= bannerKillsRequirement, ItemID.WalkingAntlionBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Vulture) >= bannerKillsRequirement, ItemID.VultureBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.SandSlime) >= bannerKillsRequirement, ItemID.SandSlimeBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Mummy) >= bannerKillsRequirement, ItemID.MummyBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.LightMummy) >= bannerKillsRequirement, ItemID.LightMummyBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.DarkMummy) >= bannerKillsRequirement, ItemID.DarkMummyBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.DesertBeast) >= bannerKillsRequirement, ItemID.DesertBasiliskBanner, bannerCostHard);
            AddItem((WorldUtils.Kills(NPCID.DesertLamiaDark) >= bannerKillsRequirement || WorldUtils.Kills(NPCID.DesertLamiaLight) >= bannerKillsRequirement), ItemID.DesertLamiaBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.DesertGhoul) >= bannerKillsRequirement, ItemID.DesertGhoulBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.DungeonSpirit) >= bannerKillsRequirement, ItemID.DungeonSpiritBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Tumbleweed) >= bannerKillsRequirement, ItemID.TumbleweedBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.SandShark) >= bannerKillsRequirement, ItemID.SandsharkBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.DuneSplicerHead) >= bannerKillsRequirement, ItemID.DuneSplicerBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.SandElemental) >= bannerKillsRequirement, ItemID.SandElementalBanner, bannerCostHard);
            return;
        }

        if (shop == "Old Ones Army")
        {
            AddItem(WorldUtils.Kills(NPCID.DD2WyvernT1) >= bannerKillsRequirement, ItemID.DD2WyvernBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.DD2JavelinstT1) >= bannerKillsRequirement, ItemID.DD2JavelinThrowerBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.DD2SkeletonT1) >= bannerKillsRequirement, ItemID.DD2SkeletonBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.DD2GoblinT1) >= bannerKillsRequirement, ItemID.DD2GoblinBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.DD2GoblinBomberT1) >= bannerKillsRequirement, ItemID.DD2GoblinBomberBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.DD2LightningBugT3) >= bannerKillsRequirement, ItemID.DD2LightningBugBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.DD2KoboldWalkerT2) >= bannerKillsRequirement, ItemID.DD2KoboldBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.DD2KoboldFlyerT2) >= bannerKillsRequirement, ItemID.DD2KoboldFlyerBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.DD2DrakinT2) >= bannerKillsRequirement, ItemID.DD2DrakinBanner, bannerCostHard);
            return;
        }

        if (shop == "Frost Legion")
        {
            AddItem(WorldUtils.Kills(NPCID.MisterStabby) >= bannerKillsRequirement, ItemID.MisterStabbyBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.SnowmanGangsta) >= bannerKillsRequirement, ItemID.SnowmanGangstaBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.SnowBalla) >= bannerKillsRequirement, ItemID.SnowBallaBanner, bannerCostHard);
            return;
        }

        if (shop == "Pirate Invasion")
        {
            AddItem(WorldUtils.Kills(NPCID.Pirate) >= bannerKillsRequirement, ItemID.PirateBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.PirateDeadeye) >= bannerKillsRequirement, ItemID.PirateDeadeyeBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.PirateCorsair) >= bannerKillsRequirement, ItemID.PirateCorsairBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.PirateCrossbower) >= bannerKillsRequirement, ItemID.PirateCrossbowerBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.PirateCaptain) >= bannerKillsRequirement, ItemID.PirateCaptainBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Parrot) >= bannerKillsRequirement, ItemID.ParrotBanner, bannerCostHard);
            return;
        }

        if (shop == "Pumpkin Moon")
        {
            AddItem(WorldUtils.Kills(NPCID.Scarecrow1) >= bannerKillsRequirement, ItemID.ScarecrowBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Splinterling) >= bannerKillsRequirement, ItemID.SplinterlingBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Hellhound) >= bannerKillsRequirement, ItemID.HellhoundBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Poltergeist) >= bannerKillsRequirement, ItemID.PoltergeistBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.HeadlessHorseman) >= bannerKillsRequirement, ItemID.HeadlessHorsemanBanner, bannerCostHard);
            return;
        }

        if (shop == "Frost Moon")
        {
            AddItem(WorldUtils.Kills(NPCID.GingerbreadMan) >= bannerKillsRequirement, ItemID.GingerbreadManBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.ZombieElf) >= bannerKillsRequirement, ItemID.ZombieElfBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.ElfArcher) >= bannerKillsRequirement, ItemID.ElfArcherBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Nutcracker) >= bannerKillsRequirement, ItemID.NutcrackerBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Yeti) >= bannerKillsRequirement, ItemID.YetiBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.ElfCopter) >= bannerKillsRequirement, ItemID.ElfCopterBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Krampus) >= bannerKillsRequirement, ItemID.KrampusBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Flocko) >= bannerKillsRequirement, ItemID.FlockoBanner, bannerCostHard);
            return;
        }

        if (shop == "Martian Madness")
        {
            AddItem(WorldUtils.Kills(NPCID.Scutlix) >= bannerKillsRequirement, ItemID.ScutlixBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.MartianWalker) >= bannerKillsRequirement, ItemID.MartianWalkerBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.MartianDrone) >= bannerKillsRequirement, ItemID.MartianDroneBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.MartianTurret) >= bannerKillsRequirement, ItemID.MartianTeslaTurretBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.GigaZapper) >= bannerKillsRequirement, ItemID.MartianGigazapperBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.MartianEngineer) >= bannerKillsRequirement, ItemID.MartianEngineerBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.MartianOfficer) >= bannerKillsRequirement, ItemID.MartianOfficerBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.RayGunner) >= bannerKillsRequirement, ItemID.MartianRaygunnerBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.GrayGrunt) >= bannerKillsRequirement, ItemID.MartianGreyGruntBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.BrainScrambler) >= bannerKillsRequirement, ItemID.MartianBrainscramblerBanner, bannerCostHard);
            return;
        }

        if (shop == "Solar Zone")
        {
            AddItem(WorldUtils.Kills(NPCID.SolarSolenian) >= bannerKillsRequirement, ItemID.SolarSolenianBanner, bannerCostInsane);
            AddItem(WorldUtils.Kills(NPCID.SolarDrakomire) >= bannerKillsRequirement, ItemID.SolarDrakomireBanner, bannerCostInsane);
            AddItem(WorldUtils.Kills(NPCID.SolarDrakomireRider) >= bannerKillsRequirement, ItemID.SolarDrakomireRiderBanner, bannerCostInsane);
            AddItem(WorldUtils.Kills(NPCID.SolarCorite) >= bannerKillsRequirement, ItemID.SolarCoriteBanner, bannerCostInsane);
            AddItem(WorldUtils.Kills(NPCID.SolarSroller) >= bannerKillsRequirement, ItemID.SolarSrollerBanner, bannerCostInsane);
            AddItem(WorldUtils.Kills(NPCID.SolarCrawltipedeHead) >= bannerKillsRequirement, ItemID.SolarCrawltipedeBanner, bannerCostInsane);
            return;
        }

        if (shop == "Vortex Zone")
        {
            AddItem(WorldUtils.Kills(NPCID.VortexHornet) >= bannerKillsRequirement, ItemID.VortexHornetBanner, bannerCostInsane);
            AddItem(WorldUtils.Kills(NPCID.VortexHornetQueen) >= bannerKillsRequirement, ItemID.VortexHornetQueenBanner, bannerCostInsane);
            AddItem(WorldUtils.Kills(NPCID.VortexLarva) >= bannerKillsRequirement, ItemID.VortexLarvaBanner, bannerCostInsane);
            AddItem(WorldUtils.Kills(NPCID.VortexRifleman) >= bannerKillsRequirement, ItemID.VortexRiflemanBanner, bannerCostInsane);
            AddItem(WorldUtils.Kills(NPCID.VortexSoldier) >= bannerKillsRequirement, ItemID.VortexSoldierBanner, bannerCostInsane);
            return;
        }

        if (shop == "Nebula Zone")
        {
            AddItem(WorldUtils.Kills(NPCID.NebulaBeast) >= bannerKillsRequirement, ItemID.NebulaBeastBanner, bannerCostInsane);
            AddItem(WorldUtils.Kills(NPCID.NebulaBrain) >= bannerKillsRequirement, ItemID.NebulaBrainBanner, bannerCostInsane);
            AddItem(WorldUtils.Kills(NPCID.NebulaHeadcrab) >= bannerKillsRequirement, ItemID.NebulaHeadcrabBanner, bannerCostInsane);
            AddItem(WorldUtils.Kills(NPCID.NebulaSoldier) >= bannerKillsRequirement, ItemID.NebulaSoldierBanner, bannerCostInsane);
            return;
        }

        if (shop == "Stardust Zone")
        {
            AddItem(WorldUtils.Kills(NPCID.StardustJellyfishSmall) >= bannerKillsRequirement, ItemID.StardustJellyfishBanner, bannerCostInsane);
            AddItem(WorldUtils.Kills(NPCID.StardustJellyfishBig) >= bannerKillsRequirement, ItemID.StardustLargeCellBanner, bannerCostInsane);
            AddItem(WorldUtils.Kills(NPCID.StardustCellSmall) >= bannerKillsRequirement, ItemID.StardustSmallCellBanner, bannerCostInsane);
            AddItem(WorldUtils.Kills(NPCID.StardustSoldier) >= bannerKillsRequirement, ItemID.StardustSoldierBanner, bannerCostInsane);
            AddItem(WorldUtils.Kills(NPCID.StardustSpiderSmall) >= bannerKillsRequirement, ItemID.StardustSpiderBanner, bannerCostInsane);
            AddItem(WorldUtils.Kills(NPCID.StardustWormHead) >= bannerKillsRequirement, ItemID.StardustWormBanner, bannerCostInsane);
            return;
        }

        if (shop == "Ocean")
        {
            AddItem(WorldUtils.Kills(NPCID.PinkJellyfish) >= bannerKillsRequirement, ItemID.PinkJellyfishBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.Crab) >= bannerKillsRequirement, ItemID.CrabBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.SeaSnail) >= bannerKillsRequirement, ItemID.SeaSnailBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.Squid) >= bannerKillsRequirement, ItemID.SquidBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.Shark) >= bannerKillsRequirement, ItemID.SharkBanner, bannerCostEasy);
            return;
        }

        if (shop == "Snow")
        {
            AddItem(WorldUtils.Kills(NPCID.IceSlime) >= bannerKillsRequirement, ItemID.IceSlimeBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.ZombieEskimo) >= bannerKillsRequirement, ItemID.ZombieEskimoBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.IceElemental) >= bannerKillsRequirement, ItemID.IceElementalBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Wolf) >= bannerKillsRequirement, ItemID.WolfBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.IceGolem) >= bannerKillsRequirement, ItemID.IceGolemBanner, bannerCostInsane);
            AddItem(WorldUtils.Kills(NPCID.Penguin) >= bannerKillsRequirement, ItemID.PenguinBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.IceBat) >= bannerKillsRequirement, ItemID.IceBatBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.SnowFlinx) >= bannerKillsRequirement, ItemID.SnowFlinxBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.SpikedIceSlime) >= bannerKillsRequirement, ItemID.SpikedIceSlimeBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.UndeadViking) >= bannerKillsRequirement, ItemID.UndeadVikingBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.ArmoredViking) >= bannerKillsRequirement, ItemID.ArmoredVikingBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.IceTortoise) >= bannerKillsRequirement, ItemID.IceTortoiseBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.IceElemental) >= bannerKillsRequirement, ItemID.IceElementalBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.IcyMerman) >= bannerKillsRequirement, ItemID.IcyMermanBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.PigronCorruption) >= bannerKillsRequirement, ItemID.PigronBanner, bannerCostHard);
            return;
        }

        if (shop == "Jungle")
        {
            AddItem(WorldUtils.Kills(NPCID.Piranha) >= bannerKillsRequirement, ItemID.PiranhaBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.Snatcher) >= bannerKillsRequirement, ItemID.SnatcherBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.JungleBat) >= bannerKillsRequirement, ItemID.JungleBatBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.JungleSlime) >= bannerKillsRequirement, ItemID.JungleSlimeBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.DoctorBones) >= bannerKillsRequirement, ItemID.DoctorBonesBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.AnglerFish) >= bannerKillsRequirement, ItemID.AnglerFishBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Arapaima) >= bannerKillsRequirement, ItemID.ArapaimaBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.GiantTortoise) >= bannerKillsRequirement, ItemID.TortoiseBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.AngryTrapper) >= bannerKillsRequirement, ItemID.AngryTrapperBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Derpling) >= bannerKillsRequirement, ItemID.DerplingBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.GiantFlyingFox) >= bannerKillsRequirement, ItemID.GiantFlyingFoxBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Hornet) >= bannerKillsRequirement, ItemID.HornetBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.ManEater) >= bannerKillsRequirement, ItemID.ManEaterBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.SpikedJungleSlime) >= bannerKillsRequirement, ItemID.SpikedJungleSlimeBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.LacBeetle) >= bannerKillsRequirement, ItemID.LacBeetleBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.JungleCreeper) >= bannerKillsRequirement, ItemID.JungleCreeperBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Moth) >= bannerKillsRequirement, ItemID.MothBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Lihzahrd) >= bannerKillsRequirement, ItemID.LihzahrdBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.FlyingSnake) >= bannerKillsRequirement, ItemID.FlyingSnakeBanner, bannerCostHard);
            return;
        }

        if (shop == "Mushroom")
        {
            AddItem(WorldUtils.Kills(NPCID.FungiBulb) >= bannerKillsRequirement, ItemID.FungiBulbBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.AnomuraFungus) >= bannerKillsRequirement, ItemID.AnomuraFungusBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.MushiLadybug) >= bannerKillsRequirement, ItemID.MushiLadybugBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Spore) >= bannerKillsRequirement, ItemID.SporeZombieBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.FungoFish) >= bannerKillsRequirement, ItemID.FungoFishBanner, bannerCostHard);
            return;
        }

        if (shop == "Corruption")
        {
            AddItem(WorldUtils.Kills(NPCID.EaterofSouls) >= bannerKillsRequirement, ItemID.EaterofSoulsBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.DevourerHead) >= bannerKillsRequirement, ItemID.DevourerBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.Corruptor) >= bannerKillsRequirement, ItemID.CorruptorBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.CorruptSlime) >= bannerKillsRequirement, ItemID.CorruptSlimeBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Slimer) >= bannerKillsRequirement, ItemID.SlimerBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.BloodFeeder) >= bannerKillsRequirement, ItemID.WorldFeederBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.CursedHammer) >= bannerKillsRequirement, ItemID.CursedHammerBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Clinger) >= bannerKillsRequirement, ItemID.ClingerBanner, bannerCostHard);
            return;
        }

        if (shop == "Crimson")
        {
            AddItem(WorldUtils.Kills(NPCID.BloodCrawler) >= bannerKillsRequirement, ItemID.BloodCrawlerBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.FaceMonster) >= bannerKillsRequirement, ItemID.FaceMonsterBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.Crimera) >= bannerKillsRequirement, ItemID.CrimeraBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.Herpling) >= bannerKillsRequirement, ItemID.HerplingBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Crimslime) >= bannerKillsRequirement, ItemID.CrimslimeBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.BloodJelly) >= bannerKillsRequirement, ItemID.BloodJellyBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.BloodFeeder) >= bannerKillsRequirement, ItemID.BloodFeederBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.CrimsonAxe) >= bannerKillsRequirement, ItemID.CrimsonAxeBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.IchorSticker) >= bannerKillsRequirement, ItemID.IchorStickerBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.FloatyGross) >= bannerKillsRequirement, ItemID.FloatyGrossBanner, bannerCostHard);
            return;
        }

        if (shop == "Hallow")
        {
            AddItem(WorldUtils.Kills(NPCID.Pixie) >= bannerKillsRequirement, ItemID.PixieBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Unicorn) >= bannerKillsRequirement, ItemID.UnicornBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.RainbowSlime) >= bannerKillsRequirement, ItemID.RainbowSlimeBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Gastropod) >= bannerKillsRequirement, ItemID.GastropodBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.DD2LightningBugT3) >= bannerKillsRequirement, ItemID.DD2LightningBugBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.IlluminantSlime) >= bannerKillsRequirement, ItemID.IlluminantSlimeBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.IlluminantBat) >= bannerKillsRequirement, ItemID.IlluminantBatBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.ChaosElemental) >= bannerKillsRequirement, ItemID.ChaosElementalBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.EnchantedSword) >= bannerKillsRequirement, ItemID.EnchantedSwordBanner, bannerCostHard);
            return;
        }

        if (shop == "Space")
        {
            AddItem(WorldUtils.Kills(NPCID.Harpy) >= bannerKillsRequirement, ItemID.HarpyBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.WyvernHead) >= bannerKillsRequirement, ItemID.WyvernBanner, bannerCostHard);
            return;
        }

        if (shop == "Underworld")
        {
            AddItem(WorldUtils.Kills(NPCID.Hellbat) >= bannerKillsRequirement, ItemID.HellbatBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.LavaSlime) >= bannerKillsRequirement, ItemID.LavaSlimeBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.FireImp) >= bannerKillsRequirement, ItemID.FireImpBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.Demon) >= bannerKillsRequirement, ItemID.DemonBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.BoneSerpentHead) >= bannerKillsRequirement, ItemID.BoneSerpentBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.Lavabat) >= bannerKillsRequirement, ItemID.LavaBatBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.RedDevil) >= bannerKillsRequirement, ItemID.RedDevilBanner, bannerCostHard);
            return;
        }

        if (shop == "Overworld")
        {
            AddItem(WorldUtils.Kills(NPCID.BlueSlime) >= bannerKillsRequirement, ItemID.SlimeBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.GreenSlime) >= bannerKillsRequirement, ItemID.GreenSlimeBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.PurpleSlime) >= bannerKillsRequirement, ItemID.PurpleSlimeBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.Pinky) >= bannerKillsRequirement, ItemID.PinkyBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.Zombie) >= bannerKillsRequirement, ItemID.ZombieBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.Raven) >= bannerKillsRequirement, ItemID.RavenBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.DemonEye) >= bannerKillsRequirement, ItemID.DemonEyeBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.PossessedArmor) >= bannerKillsRequirement, ItemID.PossessedArmorBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.HoppinJack) >= bannerKillsRequirement, ItemID.HoppinJackBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Werewolf) >= bannerKillsRequirement, ItemID.WerewolfBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Bunny) >= bannerKillsRequirement, ItemID.BunnyBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.Bird) >= bannerKillsRequirement, ItemID.BirdBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.Worm) >= bannerKillsRequirement, ItemID.WormBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.RedSlime) >= bannerKillsRequirement, ItemID.RedSlimeBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.YellowSlime) >= bannerKillsRequirement, ItemID.YellowSlimeBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.ToxicSludge) >= bannerKillsRequirement, ItemID.ToxicSludgeBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.Skeleton) >= bannerKillsRequirement, ItemID.SkeletonBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.Salamander) >= bannerKillsRequirement, ItemID.SalamanderBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.Crawdad) >= bannerKillsRequirement, ItemID.CrawdadBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.GiantShelly) >= bannerKillsRequirement, ItemID.GiantShellyBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.UndeadMiner) >= bannerKillsRequirement, ItemID.UndeadMinerBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.Tim) >= bannerKillsRequirement, ItemID.TimBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.Nymph) >= bannerKillsRequirement, ItemID.NypmhBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.CochinealBeetle) >= bannerKillsRequirement, ItemID.CochinealBeetleBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.BlueJellyfish) >= bannerKillsRequirement, ItemID.JellyfishBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.GreenJellyfish) >= bannerKillsRequirement, ItemID.GreenJellyfishBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.PinkJellyfish) >= bannerKillsRequirement, ItemID.PinkJellyfishBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.WallCreeper) >= bannerKillsRequirement, ItemID.SpiderBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.BlackRecluse) >= bannerKillsRequirement, ItemID.BlackRecluseBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.GraniteGolem) >= bannerKillsRequirement, ItemID.GraniteGolemBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.GraniteFlyer) >= bannerKillsRequirement, ItemID.GraniteFlyerBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.Medusa) >= bannerKillsRequirement, ItemID.MedusaBanner, bannerCostHard);
            AddItem(WorldUtils.Kills(NPCID.MeteorHead) >= bannerKillsRequirement, ItemID.MeteorHeadBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.FlyingFish) >= bannerKillsRequirement, ItemID.FlyingFishBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.UmbrellaSlime) >= bannerKillsRequirement, ItemID.UmbrellaSlimeBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.ZombieRaincoat) >= bannerKillsRequirement, ItemID.RaincoatZombieBanner, bannerCostEasy);
            AddItem(WorldUtils.Kills(NPCID.AngryNimbus) >= bannerKillsRequirement, ItemID.AngryNimbusBanner, bannerCostHard);
            return;
        }

        if (shop == "Hair Dyes")
        {
            AddItem(ItemID.HairDyeRemover);
            AddItem(ItemID.DepthHairDye);
            AddItem(ItemID.LifeHairDye);
            AddItem(ItemID.ManaHairDye);
            AddItem(ItemID.MoneyHairDye);
            AddItem(ItemID.TimeHairDye);
            AddItem(ItemID.TeamHairDye);
            AddItem(ItemID.PartyHairDye);
            AddItem(ItemID.BiomeHairDye);
            AddItem(ItemID.SpeedHairDye);
            AddItem(ItemID.RainbowHairDye);
            AddItem(ItemID.MartianHairDye);
            AddItem(ItemID.TwilightHairDye);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.Stylist);
    }
}
