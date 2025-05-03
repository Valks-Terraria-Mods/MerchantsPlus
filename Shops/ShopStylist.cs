namespace MerchantsPlus.Shops;

public class ShopStylist : Shop
{
    public override string[] Shops =>
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
            AddItem(Utils.Kills(NPCID.Eyezor) >= bannerKillsRequirement, ItemID.EyezorBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Frankenstein) >= bannerKillsRequirement, ItemID.FrankensteinBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.SwampThing) >= bannerKillsRequirement, ItemID.SwampThingBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Vampire) >= bannerKillsRequirement, ItemID.VampireBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.CreatureFromTheDeep) >= bannerKillsRequirement, ItemID.CreatureFromTheDeepBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Fritz) >= bannerKillsRequirement, ItemID.FritzBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Reaper) >= bannerKillsRequirement, ItemID.ReaperBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.ThePossessed) >= bannerKillsRequirement, ItemID.ThePossessedBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Mothron) >= bannerKillsRequirement, ItemID.MothronBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Butcher) >= bannerKillsRequirement, ItemID.ButcherBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.DeadlySphere) >= bannerKillsRequirement, ItemID.DeadlySphereBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.DrManFly) >= bannerKillsRequirement, ItemID.DrManFlyBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Nailhead) >= bannerKillsRequirement, ItemID.NailheadBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Psycho) >= bannerKillsRequirement, ItemID.PsychoBanner, bannerCostHard);
            return;
        }

        if (shop == "Bloodmoon")
        {
            AddItem(Utils.Kills(NPCID.BloodZombie) >= bannerKillsRequirement, ItemID.BloodZombieBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.Drippler) >= bannerKillsRequirement, ItemID.DripplerBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.TheGroom) >= bannerKillsRequirement, ItemID.TheGroomBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.CorruptBunny) >= bannerKillsRequirement, ItemID.CorruptBunnyBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.CorruptGoldfish) >= bannerKillsRequirement, ItemID.CorruptGoldfishBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.CorruptPenguin) >= bannerKillsRequirement, ItemID.CorruptPenguinBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.Clown) >= bannerKillsRequirement, ItemID.ClownBanner, bannerCostHard);
            return;
        }

        if (shop == "Goblin Army")
        {
            AddItem(Utils.Kills(NPCID.GoblinPeon) >= bannerKillsRequirement, ItemID.GoblinPeonBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.GoblinSorcerer) >= bannerKillsRequirement, ItemID.GoblinSorcererBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.GoblinThief) >= bannerKillsRequirement, ItemID.GoblinThiefBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.GoblinWarrior) >= bannerKillsRequirement, ItemID.GoblinWarriorBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.GoblinArcher) >= bannerKillsRequirement, ItemID.GoblinArcherBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.GoblinSummoner) >= bannerKillsRequirement, ItemID.GoblinSummonerBanner, bannerCostHard);
            return;
        }

        if (shop == "Dungeon")
        {
            AddItem(Utils.Kills(NPCID.AngryBones) >= bannerKillsRequirement, ItemID.AngryBonesBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.DarkCaster) >= bannerKillsRequirement, ItemID.SkeletonMageBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.CursedSkull) >= bannerKillsRequirement, ItemID.CursedSkullBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.DungeonSlime) >= bannerKillsRequirement, ItemID.DungeonSlimeBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.BlueArmoredBones) >= bannerKillsRequirement, ItemID.BlueArmoredBonesBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.RustyArmoredBonesSword) >= bannerKillsRequirement, ItemID.RustyArmoredBonesBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.HellArmoredBones) >= bannerKillsRequirement, ItemID.HellArmoredBonesBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Paladin) >= bannerKillsRequirement, ItemID.PaladinBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Necromancer) >= bannerKillsRequirement, ItemID.NecromancerBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.RaggedCaster) >= bannerKillsRequirement, ItemID.RaggedCasterBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.SkeletonCommando) >= bannerKillsRequirement, ItemID.SkeletonCommandoBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.SkeletonSniper) >= bannerKillsRequirement, ItemID.SkeletonSniperBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.TacticalSkeleton) >= bannerKillsRequirement, ItemID.TacticalSkeletonBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.GiantCursedSkull) >= bannerKillsRequirement, ItemID.GiantCursedSkullBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.BoneLee) >= bannerKillsRequirement, ItemID.BoneLeeBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.DungeonSpirit) >= bannerKillsRequirement, ItemID.DungeonSpiritBanner, bannerCostHard);
            return;
        }

        if (shop == "Desert")
        {
            AddItem(Utils.Kills(NPCID.Antlion) >= bannerKillsRequirement, ItemID.AntlionBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.FlyingAntlion) >= bannerKillsRequirement, ItemID.FlyingAntlionBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.WalkingAntlion) >= bannerKillsRequirement, ItemID.WalkingAntlionBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Vulture) >= bannerKillsRequirement, ItemID.VultureBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.SandSlime) >= bannerKillsRequirement, ItemID.SandSlimeBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Mummy) >= bannerKillsRequirement, ItemID.MummyBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.LightMummy) >= bannerKillsRequirement, ItemID.LightMummyBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.DarkMummy) >= bannerKillsRequirement, ItemID.DarkMummyBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.DesertBeast) >= bannerKillsRequirement, ItemID.DesertBasiliskBanner, bannerCostHard);
            AddItem((Utils.Kills(NPCID.DesertLamiaDark) >= bannerKillsRequirement || Utils.Kills(NPCID.DesertLamiaLight) >= bannerKillsRequirement), ItemID.DesertLamiaBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.DesertGhoul) >= bannerKillsRequirement, ItemID.DesertGhoulBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.DungeonSpirit) >= bannerKillsRequirement, ItemID.DungeonSpiritBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Tumbleweed) >= bannerKillsRequirement, ItemID.TumbleweedBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.SandShark) >= bannerKillsRequirement, ItemID.SandsharkBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.DuneSplicerHead) >= bannerKillsRequirement, ItemID.DuneSplicerBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.SandElemental) >= bannerKillsRequirement, ItemID.SandElementalBanner, bannerCostHard);
            return;
        }

        if (shop == "Old Ones Army")
        {
            AddItem(Utils.Kills(NPCID.DD2WyvernT1) >= bannerKillsRequirement, ItemID.DD2WyvernBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.DD2JavelinstT1) >= bannerKillsRequirement, ItemID.DD2JavelinThrowerBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.DD2SkeletonT1) >= bannerKillsRequirement, ItemID.DD2SkeletonBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.DD2GoblinT1) >= bannerKillsRequirement, ItemID.DD2GoblinBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.DD2GoblinBomberT1) >= bannerKillsRequirement, ItemID.DD2GoblinBomberBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.DD2LightningBugT3) >= bannerKillsRequirement, ItemID.DD2LightningBugBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.DD2KoboldWalkerT2) >= bannerKillsRequirement, ItemID.DD2KoboldBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.DD2KoboldFlyerT2) >= bannerKillsRequirement, ItemID.DD2KoboldFlyerBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.DD2DrakinT2) >= bannerKillsRequirement, ItemID.DD2DrakinBanner, bannerCostHard);
            return;
        }

        if (shop == "Frost Legion")
        {
            AddItem(Utils.Kills(NPCID.MisterStabby) >= bannerKillsRequirement, ItemID.MisterStabbyBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.SnowmanGangsta) >= bannerKillsRequirement, ItemID.SnowmanGangstaBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.SnowBalla) >= bannerKillsRequirement, ItemID.SnowBallaBanner, bannerCostHard);
            return;
        }

        if (shop == "Pirate Invasion")
        {
            AddItem(Utils.Kills(NPCID.Pirate) >= bannerKillsRequirement, ItemID.PirateBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.PirateDeadeye) >= bannerKillsRequirement, ItemID.PirateDeadeyeBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.PirateCorsair) >= bannerKillsRequirement, ItemID.PirateCorsairBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.PirateCrossbower) >= bannerKillsRequirement, ItemID.PirateCrossbowerBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.PirateCaptain) >= bannerKillsRequirement, ItemID.PirateCaptainBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Parrot) >= bannerKillsRequirement, ItemID.ParrotBanner, bannerCostHard);
            return;
        }

        if (shop == "Pumpkin Moon")
        {
            AddItem(Utils.Kills(NPCID.Scarecrow1) >= bannerKillsRequirement, ItemID.ScarecrowBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Splinterling) >= bannerKillsRequirement, ItemID.SplinterlingBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Hellhound) >= bannerKillsRequirement, ItemID.HellhoundBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Poltergeist) >= bannerKillsRequirement, ItemID.PoltergeistBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.HeadlessHorseman) >= bannerKillsRequirement, ItemID.HeadlessHorsemanBanner, bannerCostHard);
            return;
        }

        if (shop == "Frost Moon")
        {
            AddItem(Utils.Kills(NPCID.GingerbreadMan) >= bannerKillsRequirement, ItemID.GingerbreadManBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.ZombieElf) >= bannerKillsRequirement, ItemID.ZombieElfBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.ElfArcher) >= bannerKillsRequirement, ItemID.ElfArcherBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Nutcracker) >= bannerKillsRequirement, ItemID.NutcrackerBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Yeti) >= bannerKillsRequirement, ItemID.YetiBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.ElfCopter) >= bannerKillsRequirement, ItemID.ElfCopterBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Krampus) >= bannerKillsRequirement, ItemID.KrampusBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Flocko) >= bannerKillsRequirement, ItemID.FlockoBanner, bannerCostHard);
            return;
        }

        if (shop == "Martian Madness")
        {
            AddItem(Utils.Kills(NPCID.Scutlix) >= bannerKillsRequirement, ItemID.ScutlixBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.MartianWalker) >= bannerKillsRequirement, ItemID.MartianWalkerBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.MartianDrone) >= bannerKillsRequirement, ItemID.MartianDroneBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.MartianTurret) >= bannerKillsRequirement, ItemID.MartianTeslaTurretBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.GigaZapper) >= bannerKillsRequirement, ItemID.MartianGigazapperBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.MartianEngineer) >= bannerKillsRequirement, ItemID.MartianEngineerBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.MartianOfficer) >= bannerKillsRequirement, ItemID.MartianOfficerBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.RayGunner) >= bannerKillsRequirement, ItemID.MartianRaygunnerBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.GrayGrunt) >= bannerKillsRequirement, ItemID.MartianGreyGruntBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.BrainScrambler) >= bannerKillsRequirement, ItemID.MartianBrainscramblerBanner, bannerCostHard);
            return;
        }

        if (shop == "Solar Zone")
        {
            AddItem(Utils.Kills(NPCID.SolarSolenian) >= bannerKillsRequirement, ItemID.SolarSolenianBanner, bannerCostInsane);
            AddItem(Utils.Kills(NPCID.SolarDrakomire) >= bannerKillsRequirement, ItemID.SolarDrakomireBanner, bannerCostInsane);
            AddItem(Utils.Kills(NPCID.SolarDrakomireRider) >= bannerKillsRequirement, ItemID.SolarDrakomireRiderBanner, bannerCostInsane);
            AddItem(Utils.Kills(NPCID.SolarCorite) >= bannerKillsRequirement, ItemID.SolarCoriteBanner, bannerCostInsane);
            AddItem(Utils.Kills(NPCID.SolarSroller) >= bannerKillsRequirement, ItemID.SolarSrollerBanner, bannerCostInsane);
            AddItem(Utils.Kills(NPCID.SolarCrawltipedeHead) >= bannerKillsRequirement, ItemID.SolarCrawltipedeBanner, bannerCostInsane);
            return;
        }

        if (shop == "Vortex Zone")
        {
            AddItem(Utils.Kills(NPCID.VortexHornet) >= bannerKillsRequirement, ItemID.VortexHornetBanner, bannerCostInsane);
            AddItem(Utils.Kills(NPCID.VortexHornetQueen) >= bannerKillsRequirement, ItemID.VortexHornetQueenBanner, bannerCostInsane);
            AddItem(Utils.Kills(NPCID.VortexLarva) >= bannerKillsRequirement, ItemID.VortexLarvaBanner, bannerCostInsane);
            AddItem(Utils.Kills(NPCID.VortexRifleman) >= bannerKillsRequirement, ItemID.VortexRiflemanBanner, bannerCostInsane);
            AddItem(Utils.Kills(NPCID.VortexSoldier) >= bannerKillsRequirement, ItemID.VortexSoldierBanner, bannerCostInsane);
            return;
        }

        if (shop == "Nebula Zone")
        {
            AddItem(Utils.Kills(NPCID.NebulaBeast) >= bannerKillsRequirement, ItemID.NebulaBeastBanner, bannerCostInsane);
            AddItem(Utils.Kills(NPCID.NebulaBrain) >= bannerKillsRequirement, ItemID.NebulaBrainBanner, bannerCostInsane);
            AddItem(Utils.Kills(NPCID.NebulaHeadcrab) >= bannerKillsRequirement, ItemID.NebulaHeadcrabBanner, bannerCostInsane);
            AddItem(Utils.Kills(NPCID.NebulaSoldier) >= bannerKillsRequirement, ItemID.NebulaSoldierBanner, bannerCostInsane);
            return;
        }

        if (shop == "Stardust Zone")
        {
            AddItem(Utils.Kills(NPCID.StardustJellyfishSmall) >= bannerKillsRequirement, ItemID.StardustJellyfishBanner, bannerCostInsane);
            AddItem(Utils.Kills(NPCID.StardustJellyfishBig) >= bannerKillsRequirement, ItemID.StardustLargeCellBanner, bannerCostInsane);
            AddItem(Utils.Kills(NPCID.StardustCellSmall) >= bannerKillsRequirement, ItemID.StardustSmallCellBanner, bannerCostInsane);
            AddItem(Utils.Kills(NPCID.StardustSoldier) >= bannerKillsRequirement, ItemID.StardustSoldierBanner, bannerCostInsane);
            AddItem(Utils.Kills(NPCID.StardustSpiderSmall) >= bannerKillsRequirement, ItemID.StardustSpiderBanner, bannerCostInsane);
            AddItem(Utils.Kills(NPCID.StardustWormHead) >= bannerKillsRequirement, ItemID.StardustWormBanner, bannerCostInsane);
            return;
        }

        if (shop == "Ocean")
        {
            AddItem(Utils.Kills(NPCID.PinkJellyfish) >= bannerKillsRequirement, ItemID.PinkJellyfishBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.Crab) >= bannerKillsRequirement, ItemID.CrabBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.SeaSnail) >= bannerKillsRequirement, ItemID.SeaSnailBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.Squid) >= bannerKillsRequirement, ItemID.SquidBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.Shark) >= bannerKillsRequirement, ItemID.SharkBanner, bannerCostEasy);
            return;
        }

        if (shop == "Snow")
        {
            AddItem(Utils.Kills(NPCID.IceSlime) >= bannerKillsRequirement, ItemID.IceSlimeBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.ZombieEskimo) >= bannerKillsRequirement, ItemID.ZombieEskimoBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.IceElemental) >= bannerKillsRequirement, ItemID.IceElementalBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Wolf) >= bannerKillsRequirement, ItemID.WolfBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.IceGolem) >= bannerKillsRequirement, ItemID.IceGolemBanner, bannerCostInsane);
            AddItem(Utils.Kills(NPCID.Penguin) >= bannerKillsRequirement, ItemID.PenguinBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.IceBat) >= bannerKillsRequirement, ItemID.IceBatBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.SnowFlinx) >= bannerKillsRequirement, ItemID.SnowFlinxBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.SpikedIceSlime) >= bannerKillsRequirement, ItemID.SpikedIceSlimeBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.UndeadViking) >= bannerKillsRequirement, ItemID.UndeadVikingBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.ArmoredViking) >= bannerKillsRequirement, ItemID.ArmoredVikingBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.IceTortoise) >= bannerKillsRequirement, ItemID.IceTortoiseBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.IceElemental) >= bannerKillsRequirement, ItemID.IceElementalBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.IcyMerman) >= bannerKillsRequirement, ItemID.IcyMermanBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.PigronCorruption) >= bannerKillsRequirement, ItemID.PigronBanner, bannerCostHard);
            return;
        }

        if (shop == "Jungle")
        {
            AddItem(Utils.Kills(NPCID.Piranha) >= bannerKillsRequirement, ItemID.PiranhaBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.Snatcher) >= bannerKillsRequirement, ItemID.SnatcherBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.JungleBat) >= bannerKillsRequirement, ItemID.JungleBatBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.JungleSlime) >= bannerKillsRequirement, ItemID.JungleSlimeBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.DoctorBones) >= bannerKillsRequirement, ItemID.DoctorBonesBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.AnglerFish) >= bannerKillsRequirement, ItemID.AnglerFishBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Arapaima) >= bannerKillsRequirement, ItemID.ArapaimaBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.GiantTortoise) >= bannerKillsRequirement, ItemID.TortoiseBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.AngryTrapper) >= bannerKillsRequirement, ItemID.AngryTrapperBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Derpling) >= bannerKillsRequirement, ItemID.DerplingBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.GiantFlyingFox) >= bannerKillsRequirement, ItemID.GiantFlyingFoxBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Hornet) >= bannerKillsRequirement, ItemID.HornetBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.ManEater) >= bannerKillsRequirement, ItemID.ManEaterBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.SpikedJungleSlime) >= bannerKillsRequirement, ItemID.SpikedJungleSlimeBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.LacBeetle) >= bannerKillsRequirement, ItemID.LacBeetleBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.JungleCreeper) >= bannerKillsRequirement, ItemID.JungleCreeperBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Moth) >= bannerKillsRequirement, ItemID.MothBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Lihzahrd) >= bannerKillsRequirement, ItemID.LihzahrdBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.FlyingSnake) >= bannerKillsRequirement, ItemID.FlyingSnakeBanner, bannerCostHard);
            return;
        }

        if (shop == "Mushroom")
        {
            AddItem(Utils.Kills(NPCID.FungiBulb) >= bannerKillsRequirement, ItemID.FungiBulbBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.AnomuraFungus) >= bannerKillsRequirement, ItemID.AnomuraFungusBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.MushiLadybug) >= bannerKillsRequirement, ItemID.MushiLadybugBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Spore) >= bannerKillsRequirement, ItemID.SporeZombieBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.FungoFish) >= bannerKillsRequirement, ItemID.FungoFishBanner, bannerCostHard);
            return;
        }

        if (shop == "Corruption")
        {
            AddItem(Utils.Kills(NPCID.EaterofSouls) >= bannerKillsRequirement, ItemID.EaterofSoulsBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.DevourerHead) >= bannerKillsRequirement, ItemID.DevourerBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.Corruptor) >= bannerKillsRequirement, ItemID.CorruptorBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.CorruptSlime) >= bannerKillsRequirement, ItemID.CorruptSlimeBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Slimer) >= bannerKillsRequirement, ItemID.SlimerBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.BloodFeeder) >= bannerKillsRequirement, ItemID.WorldFeederBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.CursedHammer) >= bannerKillsRequirement, ItemID.CursedHammerBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Clinger) >= bannerKillsRequirement, ItemID.ClingerBanner, bannerCostHard);
            return;
        }

        if (shop == "Crimson")
        {
            AddItem(Utils.Kills(NPCID.BloodCrawler) >= bannerKillsRequirement, ItemID.BloodCrawlerBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.FaceMonster) >= bannerKillsRequirement, ItemID.FaceMonsterBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.Crimera) >= bannerKillsRequirement, ItemID.CrimeraBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.Herpling) >= bannerKillsRequirement, ItemID.HerplingBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Crimslime) >= bannerKillsRequirement, ItemID.CrimslimeBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.BloodJelly) >= bannerKillsRequirement, ItemID.BloodJellyBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.BloodFeeder) >= bannerKillsRequirement, ItemID.BloodFeederBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.CrimsonAxe) >= bannerKillsRequirement, ItemID.CrimsonAxeBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.IchorSticker) >= bannerKillsRequirement, ItemID.IchorStickerBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.FloatyGross) >= bannerKillsRequirement, ItemID.FloatyGrossBanner, bannerCostHard);
            return;
        }

        if (shop == "Hallow")
        {
            AddItem(Utils.Kills(NPCID.Pixie) >= bannerKillsRequirement, ItemID.PixieBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Unicorn) >= bannerKillsRequirement, ItemID.UnicornBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.RainbowSlime) >= bannerKillsRequirement, ItemID.RainbowSlimeBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Gastropod) >= bannerKillsRequirement, ItemID.GastropodBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.DD2LightningBugT3) >= bannerKillsRequirement, ItemID.DD2LightningBugBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.IlluminantSlime) >= bannerKillsRequirement, ItemID.IlluminantSlimeBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.IlluminantBat) >= bannerKillsRequirement, ItemID.IlluminantBatBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.ChaosElemental) >= bannerKillsRequirement, ItemID.ChaosElementalBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.EnchantedSword) >= bannerKillsRequirement, ItemID.EnchantedSwordBanner, bannerCostHard);
            return;
        }

        if (shop == "Space")
        {
            AddItem(Utils.Kills(NPCID.Harpy) >= bannerKillsRequirement, ItemID.HarpyBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.WyvernHead) >= bannerKillsRequirement, ItemID.WyvernBanner, bannerCostHard);
            return;
        }

        if (shop == "Underworld")
        {
            AddItem(Utils.Kills(NPCID.Hellbat) >= bannerKillsRequirement, ItemID.HellbatBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.LavaSlime) >= bannerKillsRequirement, ItemID.LavaSlimeBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.FireImp) >= bannerKillsRequirement, ItemID.FireImpBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.Demon) >= bannerKillsRequirement, ItemID.DemonBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.BoneSerpentHead) >= bannerKillsRequirement, ItemID.BoneSerpentBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.Lavabat) >= bannerKillsRequirement, ItemID.LavaBatBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.RedDevil) >= bannerKillsRequirement, ItemID.RedDevilBanner, bannerCostHard);
            return;
        }

        if (shop == "Overworld")
        {
            AddItem(Utils.Kills(NPCID.BlueSlime) >= bannerKillsRequirement, ItemID.SlimeBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.GreenSlime) >= bannerKillsRequirement, ItemID.GreenSlimeBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.PurpleSlime) >= bannerKillsRequirement, ItemID.PurpleSlimeBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.Pinky) >= bannerKillsRequirement, ItemID.PinkyBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.Zombie) >= bannerKillsRequirement, ItemID.ZombieBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.Raven) >= bannerKillsRequirement, ItemID.RavenBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.DemonEye) >= bannerKillsRequirement, ItemID.DemonEyeBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.PossessedArmor) >= bannerKillsRequirement, ItemID.PossessedArmorBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.HoppinJack) >= bannerKillsRequirement, ItemID.HoppinJackBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Werewolf) >= bannerKillsRequirement, ItemID.WerewolfBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Bunny) >= bannerKillsRequirement, ItemID.BunnyBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.Bird) >= bannerKillsRequirement, ItemID.BirdBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.Worm) >= bannerKillsRequirement, ItemID.WormBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.RedSlime) >= bannerKillsRequirement, ItemID.RedSlimeBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.YellowSlime) >= bannerKillsRequirement, ItemID.YellowSlimeBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.ToxicSludge) >= bannerKillsRequirement, ItemID.ToxicSludgeBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.Skeleton) >= bannerKillsRequirement, ItemID.SkeletonBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.Salamander) >= bannerKillsRequirement, ItemID.SalamanderBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.Crawdad) >= bannerKillsRequirement, ItemID.CrawdadBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.GiantShelly) >= bannerKillsRequirement, ItemID.GiantShellyBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.UndeadMiner) >= bannerKillsRequirement, ItemID.UndeadMinerBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.Tim) >= bannerKillsRequirement, ItemID.TimBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.Nymph) >= bannerKillsRequirement, ItemID.NypmhBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.CochinealBeetle) >= bannerKillsRequirement, ItemID.CochinealBeetleBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.BlueJellyfish) >= bannerKillsRequirement, ItemID.JellyfishBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.GreenJellyfish) >= bannerKillsRequirement, ItemID.GreenJellyfishBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.PinkJellyfish) >= bannerKillsRequirement, ItemID.PinkJellyfishBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.WallCreeper) >= bannerKillsRequirement, ItemID.SpiderBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.BlackRecluse) >= bannerKillsRequirement, ItemID.BlackRecluseBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.GraniteGolem) >= bannerKillsRequirement, ItemID.GraniteGolemBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.GraniteFlyer) >= bannerKillsRequirement, ItemID.GraniteFlyerBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.Medusa) >= bannerKillsRequirement, ItemID.MedusaBanner, bannerCostHard);
            AddItem(Utils.Kills(NPCID.MeteorHead) >= bannerKillsRequirement, ItemID.MeteorHeadBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.FlyingFish) >= bannerKillsRequirement, ItemID.FlyingFishBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.UmbrellaSlime) >= bannerKillsRequirement, ItemID.UmbrellaSlimeBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.ZombieRaincoat) >= bannerKillsRequirement, ItemID.RaincoatZombieBanner, bannerCostEasy);
            AddItem(Utils.Kills(NPCID.AngryNimbus) >= bannerKillsRequirement, ItemID.AngryNimbusBanner, bannerCostHard);
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
            AddItem(ItemID.LovePotion, Utils.UniversalPotionCost);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.Stylist);
    }
}
