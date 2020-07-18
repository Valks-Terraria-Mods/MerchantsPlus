using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Merchants
{
    internal class ShopStylist : Shop
    {
        public ShopStylist(bool merchant, params string[] shops) : base(merchant, shops)
        {
        }

        public override void OpenShop(string shop)
        {
            base.OpenShop(shop);

            int bannerKillsRequirement = 50; // 50 Kills
            int bannerCostEasy = Utils.Coins(0, 0, 1); // 1 gold
            int bannerCostHard = Utils.Coins(0, 0, 10); // 10 gold
            int bannerCostInsane = Utils.Coins(0, 0, 25); // 25 gold

            if (shop == "Eclipse")
            {
                if (Utils.Kills(NPCID.Eyezor) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.EyezorBanner, bannerCostHard);
                    
                }
                if (Utils.Kills(NPCID.Frankenstein) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.FrankensteinBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.SwampThing) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SwampThingBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Vampire) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.VampireBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.CreatureFromTheDeep) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.CreatureFromTheDeepBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Fritz) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.FritzBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Reaper) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.ReaperBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.ThePossessed) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.ThePossessedBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Mothron) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.MothronBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Butcher) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.ButcherBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.DeadlySphere) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DeadlySphereBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.DrManFly) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DrManFlyBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Nailhead) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.NailheadBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Psycho) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.PsychoBanner, bannerCostHard);
                    
                }
                return;
            }

            if (shop == "Bloodmoon")
            {
                if (Utils.Kills(NPCID.BloodZombie) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.BloodZombieBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.Drippler) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DripplerBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.TheGroom) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.TheGroomBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.CorruptBunny) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.CorruptBunnyBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.CorruptGoldfish) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.CorruptGoldfishBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.CorruptPenguin) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.CorruptPenguinBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.Clown) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.ClownBanner, bannerCostHard);
                    
                }
                return;
            }

            if (shop == "Goblin Army")
            {
                if (Utils.Kills(NPCID.GoblinPeon) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.GoblinPeonBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.GoblinSorcerer) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.GoblinSorcererBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.GoblinThief) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.GoblinThiefBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.GoblinWarrior) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.GoblinWarriorBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.GoblinArcher) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.GoblinArcherBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.GoblinSummoner) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.GoblinSummonerBanner, bannerCostHard);
                    
                }
                return;
            }

            if (shop == "Dungeon")
            {
                if (Utils.Kills(NPCID.AngryBones) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.AngryBonesBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.DarkCaster) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SkeletonMageBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.CursedSkull) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.CursedSkullBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.DungeonSlime) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DungeonSlimeBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.BlueArmoredBones) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.BlueArmoredBonesBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.RustyArmoredBonesSword) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.RustyArmoredBonesBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.HellArmoredBones) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.HellArmoredBonesBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Paladin) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.PaladinBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Necromancer) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.NecromancerBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.RaggedCaster) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.RaggedCasterBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.SkeletonCommando) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SkeletonCommandoBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.SkeletonSniper) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SkeletonSniperBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.TacticalSkeleton) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.TacticalSkeletonBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.GiantCursedSkull) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.GiantCursedSkullBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.BoneLee) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.BoneLeeBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.DungeonSpirit) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DungeonSpiritBanner, bannerCostHard);
                    
                }
                return;
            }

            if (shop == "Desert")
            {
                if (Utils.Kills(NPCID.Antlion) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.AntlionBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.FlyingAntlion) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.FlyingAntlionBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.WalkingAntlion) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.WalkingAntlionBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Vulture) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.VultureBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.SandSlime) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SandSlimeBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Mummy) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.MummyBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.LightMummy) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.LightMummyBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.DarkMummy) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DarkMummyBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.DesertBeast) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DesertBasiliskBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.DesertLamiaDark) >= bannerKillsRequirement || Utils.Kills(NPCID.DesertLamiaLight) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DesertLamiaBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.DesertGhoul) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DesertGhoulBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.DungeonSpirit) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DungeonSpiritBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Tumbleweed) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.TumbleweedBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.SandShark) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SandsharkBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.DuneSplicerHead) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DuneSplicerBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.SandElemental) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SandElementalBanner, bannerCostHard);
                    
                }
                return;
            }

            if (shop == "Old Ones Army")
            {
                if (Utils.Kills(NPCID.DD2WyvernT1) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DD2WyvernBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.DD2JavelinstT1) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DD2JavelinThrowerBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.DD2SkeletonT1) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DD2SkeletonBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.DD2GoblinT1) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DD2GoblinBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.DD2GoblinBomberT1) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DD2GoblinBomberBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.DD2LightningBugT3) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DD2LightningBugBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.DD2KoboldWalkerT2) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DD2KoboldBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.DD2KoboldFlyerT2) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DD2KoboldFlyerBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.DD2DrakinT2) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DD2DrakinBanner, bannerCostHard);
                    
                }
                return;
            }

            if (shop == "Frost Legion")
            {
                if (Utils.Kills(NPCID.MisterStabby) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.MisterStabbyBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.SnowmanGangsta) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SnowmanGangstaBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.SnowBalla) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SnowBallaBanner, bannerCostHard);
                    
                }
                return;
            }

            if (shop == "Pirate Invasion")
            {
                if (Utils.Kills(NPCID.Pirate) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.PirateBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.PirateDeadeye) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.PirateDeadeyeBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.PirateCorsair) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.PirateCorsairBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.PirateCrossbower) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.PirateCrossbowerBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.PirateCaptain) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.PirateCaptainBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Parrot) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.ParrotBanner, bannerCostHard);
                    
                }
                return;
            }

            if (shop == "Pumpkin Moon")
            {
                if (Utils.Kills(NPCID.Scarecrow1) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.ScarecrowBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Splinterling) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SplinterlingBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Hellhound) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.HellhoundBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Poltergeist) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.PoltergeistBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.HeadlessHorseman) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.HeadlessHorsemanBanner, bannerCostHard);
                    
                }
                return;
            }

            if (shop == "Frost Moon")
            {
                if (Utils.Kills(NPCID.GingerbreadMan) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.GingerbreadManBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.ZombieElf) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.ZombieElfBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.ElfArcher) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.ElfArcherBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Nutcracker) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.NutcrackerBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Yeti) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.YetiBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.ElfCopter) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.ElfCopterBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Krampus) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.KrampusBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Flocko) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.FlockoBanner, bannerCostHard);
                    
                }
                return;
            }

            if (shop == "Martian Madness")
            {
                if (Utils.Kills(NPCID.Scutlix) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.ScutlixBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.MartianWalker) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.MartianWalkerBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.MartianDrone) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.MartianDroneBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.MartianTurret) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.MartianTeslaTurretBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.GigaZapper) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.MartianGigazapperBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.MartianEngineer) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.MartianEngineerBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.MartianOfficer) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.MartianOfficerBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.RayGunner) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.MartianRaygunnerBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.GrayGrunt) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.MartianGreyGruntBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.BrainScrambler) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.MartianBrainscramblerBanner, bannerCostHard);
                    
                }
                return;
            }

            if (shop == "Solar Zone")
            {
                if (Utils.Kills(NPCID.SolarSolenian) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SolarSolenianBanner, bannerCostInsane);
                    
                }

                if (Utils.Kills(NPCID.SolarDrakomire) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SolarDrakomireBanner, bannerCostInsane);
                    
                }

                if (Utils.Kills(NPCID.SolarDrakomireRider) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SolarDrakomireRiderBanner, bannerCostInsane);
                    
                }

                if (Utils.Kills(NPCID.SolarCorite) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SolarCoriteBanner, bannerCostInsane);
                    
                }

                if (Utils.Kills(NPCID.SolarSroller) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SolarSrollerBanner, bannerCostInsane);
                    
                }

                if (Utils.Kills(NPCID.SolarCrawltipedeHead) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SolarCrawltipedeBanner, bannerCostInsane);
                    
                }
                return;
            }

            if (shop == "Vortex Zone")
            {
                if (Utils.Kills(NPCID.VortexHornet) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.VortexHornetBanner, bannerCostInsane);
                    
                }

                if (Utils.Kills(NPCID.VortexHornetQueen) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.VortexHornetQueenBanner, bannerCostInsane);
                    
                }

                if (Utils.Kills(NPCID.VortexLarva) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.VortexLarvaBanner, bannerCostInsane);
                    
                }

                if (Utils.Kills(NPCID.VortexRifleman) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.VortexRiflemanBanner, bannerCostInsane);
                    
                }

                if (Utils.Kills(NPCID.VortexSoldier) >= bannerKillsRequirement)
                {
                }
                AddItem(ItemID.VortexSoldierBanner, bannerCostInsane);
                
                return;
            }

            if (shop == "Nebula Zone")
            {
                if (Utils.Kills(NPCID.NebulaBeast) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.NebulaBeastBanner, bannerCostInsane);
                    
                }

                if (Utils.Kills(NPCID.NebulaBrain) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.NebulaBrainBanner, bannerCostInsane);
                    
                }

                if (Utils.Kills(NPCID.NebulaHeadcrab) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.NebulaHeadcrabBanner, bannerCostInsane);
                    
                }

                if (Utils.Kills(NPCID.NebulaSoldier) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.NebulaSoldierBanner, bannerCostInsane);
                    
                }
                return;
            }

            if (shop == "Stardust Zone")
            {
                if (Utils.Kills(NPCID.StardustJellyfishSmall) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.StardustJellyfishBanner, bannerCostInsane);
                    
                }

                if (Utils.Kills(NPCID.StardustJellyfishBig) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.StardustLargeCellBanner, bannerCostInsane);
                    
                }

                if (Utils.Kills(NPCID.StardustCellSmall) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.StardustSmallCellBanner, bannerCostInsane);
                    
                }

                if (Utils.Kills(NPCID.StardustSoldier) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.StardustSoldierBanner, bannerCostInsane);
                    
                }

                if (Utils.Kills(NPCID.StardustSpiderSmall) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.StardustSpiderBanner, bannerCostInsane);
                    
                }

                if (Utils.Kills(NPCID.StardustWormHead) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.StardustWormBanner, bannerCostInsane);
                    
                }
                return;
            }

            if (shop == "Ocean")
            {
                if (Utils.Kills(NPCID.PinkJellyfish) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.PinkJellyfishBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.Crab) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.CrabBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.SeaSnail) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SeaSnailBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.Squid) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SquidBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.Shark) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SharkBanner, bannerCostEasy);
                    
                }
                return;
            }

            if (shop == "Snow")
            {
                if (Utils.Kills(NPCID.IceSlime) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.IceSlimeBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.ZombieEskimo) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.ZombieEskimoBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.IceElemental) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.IceElementalBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Wolf) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.WolfBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.IceGolem) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.IceGolemBanner, bannerCostInsane);
                }

                if (Utils.Kills(NPCID.Penguin) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.PenguinBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.IceBat) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.IceBatBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.SnowFlinx) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SnowFlinxBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.SpikedIceSlime) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SpikedIceSlimeBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.UndeadViking) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.UndeadVikingBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.ArmoredViking) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.ArmoredVikingBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.IceTortoise) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.IceTortoiseBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.IceElemental) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.IceElementalBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.IcyMerman) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.IcyMermanBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.PigronCorruption) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.PigronBanner, bannerCostHard);
                    
                }
                return;
            }

            if (shop == "Jungle")
            {
                if (Utils.Kills(NPCID.Piranha) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.PiranhaBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.Snatcher) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SnatcherBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.JungleBat) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.JungleBatBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.JungleSlime) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.JungleSlimeBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.DoctorBones) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DoctorBonesBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.AnglerFish) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.AnglerFishBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Arapaima) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.ArapaimaBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.GiantTortoise) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.TortoiseBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.AngryTrapper) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.AngryTrapperBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Derpling) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DerplingBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.GiantFlyingFox) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.GiantFlyingFoxBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Hornet) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.HornetBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.ManEater) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.ManEaterBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.SpikedJungleSlime) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SpikedJungleSlimeBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.LacBeetle) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.LacBeetleBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.JungleCreeper) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.JungleCreeperBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Moth) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.MothBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Lihzahrd) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.LihzahrdBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.FlyingSnake) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.FlyingSnakeBanner, bannerCostHard);
                    
                }
                return;
            }

            if (shop == "Mushroom")
            {
                if (Utils.Kills(NPCID.FungiBulb) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.FungiBulbBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.AnomuraFungus) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.AnomuraFungusBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.MushiLadybug) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.MushiLadybugBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Spore) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SporeZombieBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.FungoFish) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.FungoFishBanner, bannerCostHard);
                    
                }
                return;
            }

            if (shop == "Corruption")
            {
                if (Utils.Kills(NPCID.EaterofSouls) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.EaterofSoulsBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.DevourerHead) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DevourerBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.Corruptor) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.CorruptorBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.CorruptSlime) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.CorruptSlimeBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Slimer) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SlimerBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.BloodFeeder) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.WorldFeederBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.CursedHammer) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.CursedHammerBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Clinger) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.ClingerBanner, bannerCostHard);
                    
                }
                return;
            }

            if (shop == "Crimson")
            {
                if (Utils.Kills(NPCID.BloodCrawler) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.BloodCrawlerBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.FaceMonster) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.FaceMonsterBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.Crimera) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.CrimeraBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.Herpling) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.HerplingBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Crimslime) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.CrimslimeBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.BloodJelly) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.BloodJellyBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.BloodFeeder) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.BloodFeederBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.CrimsonAxe) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.CrimsonAxeBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.IchorSticker) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.IchorStickerBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.FloatyGross) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.FloatyGrossBanner, bannerCostHard);
                    
                }
                return;
            }

            if (shop == "Hallow")
            {
                if (Utils.Kills(NPCID.Pixie) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.PixieBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Unicorn) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.UnicornBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.RainbowSlime) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.RainbowSlimeBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Gastropod) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.GastropodBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.DD2LightningBugT3) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DD2LightningBugBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.IlluminantSlime) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.IlluminantSlimeBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.IlluminantBat) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.IlluminantBatBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.ChaosElemental) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.ChaosElementalBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.EnchantedSword) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.EnchantedSwordBanner, bannerCostHard);
                    
                }
                return;
            }

            if (shop == "Space")
            {
                if (Utils.Kills(NPCID.Harpy) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.HarpyBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.WyvernHead) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.WyvernBanner, bannerCostHard);
                    
                }
                return;
            }

            if (shop == "Underworld")
            {
                if (Utils.Kills(NPCID.Hellbat) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.HellbatBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.LavaSlime) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.LavaSlimeBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.FireImp) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.FireImpBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.Demon) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DemonBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.BoneSerpentHead) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.BoneSerpentBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.Lavabat) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.LavaBatBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.RedDevil) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.RedDevilBanner, bannerCostHard);
                    
                }
                return;
            }

            if (shop == "Overworld")
            {
                if (Utils.Kills(NPCID.BlueSlime) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SlimeBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.GreenSlime) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.GreenSlimeBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.PurpleSlime) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.PurpleSlimeBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.Pinky) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.PinkyBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.Zombie) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.ZombieBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.Raven) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.RavenBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.DemonEye) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.DemonEyeBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.PossessedArmor) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.PossessedArmorBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.HoppinJack) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.HoppinJackBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Werewolf) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.WerewolfBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Bunny) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.BunnyBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.Bird) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.BirdBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.Worm) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.WormBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.RedSlime) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.RedSlimeBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.YellowSlime) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.YellowSlimeBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.ToxicSludge) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.ToxicSludgeBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.Skeleton) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SkeletonBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.Salamander) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SalamanderBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.Crawdad) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.CrawdadBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.GiantShelly) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.GiantShellyBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.UndeadMiner) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.UndeadMinerBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.Tim) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.TimBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.Nymph) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.NypmhBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.CochinealBeetle) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.CochinealBeetleBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.BlueJellyfish) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.JellyfishBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.GreenJellyfish) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.GreenJellyfishBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.PinkJellyfish) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.PinkJellyfishBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.WallCreeper) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.SpiderBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.BlackRecluse) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.BlackRecluseBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.GraniteGolem) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.GraniteGolemBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.GraniteFlyer) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.GraniteFlyerBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.Medusa) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.MedusaBanner, bannerCostHard);
                    
                }

                if (Utils.Kills(NPCID.MeteorHead) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.MeteorHeadBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.FlyingFish) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.FlyingFishBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.UmbrellaSlime) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.UmbrellaSlimeBanner, bannerCostEasy);
                    
                }

                if (Utils.Kills(NPCID.ZombieRaincoat) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.RaincoatZombieBanner, bannerCostEasy);
                }

                if (Utils.Kills(NPCID.AngryNimbus) >= bannerKillsRequirement)
                {
                    AddItem(ItemID.AngryNimbusBanner, bannerCostHard);
                }
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
            Inv.SetupShop(18);
        }
    }
}