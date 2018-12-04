using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    class ShopStylist
    {
        private Chest shop;
        private int nextSlot;

        public ShopStylist(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            const int bannerKillsRequirement = 50; // 50 kills
            const int bannerCostEasy = 10000; // 1 gold
            const int bannerCostHard = 100000; // 10 gold
            const int bannerCostInsane = 250000; // 25 gold

            switch (currentShop)
            {
                case "Eclipse":
                    if (Utils.kills(NPCID.Eyezor) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.EyezorBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }
                    if (Utils.kills(NPCID.Frankenstein) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.FrankensteinBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.SwampThing) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SwampThingBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Vampire) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.VampireBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.CreatureFromTheDeep) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.CreatureFromTheDeepBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Fritz) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.FritzBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Reaper) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ReaperBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.ThePossessed) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ThePossessedBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Mothron) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.MothronBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Butcher) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ButcherBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.DeadlySphere) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DeadlySphereBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.DrManFly) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DrManFlyBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Nailhead) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.NailheadBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Psycho) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PsychoBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    break;
                case "Bloodmoon":
                    if (Utils.kills(NPCID.BloodZombie) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.BloodZombieBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.Drippler) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DripplerBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.TheGroom) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.TheGroomBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.CorruptBunny) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.CorruptBunnyBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.CorruptGoldfish) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.CorruptGoldfishBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.CorruptPenguin) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.CorruptPenguinBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.Clown) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ClownBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    break;
                case "Goblin Army":
                    if (Utils.kills(NPCID.GoblinPeon) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.GoblinPeonBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.GoblinSorcerer) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.GoblinSorcererBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.GoblinThief) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.GoblinThiefBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.GoblinWarrior) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.GoblinWarriorBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.GoblinArcher) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.GoblinArcherBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.GoblinSummoner) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.GoblinSummonerBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    break;
                case "Dungeon":
                    if (Utils.kills(NPCID.AngryBones) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.AngryBonesBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.DarkCaster) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SkeletonMageBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.CursedSkull) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.CursedSkullBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.DungeonSlime) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DungeonSlimeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.BlueArmoredBones) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.BlueArmoredBonesBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.RustyArmoredBonesSword) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.RustyArmoredBonesBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.HellArmoredBones) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.HellArmoredBonesBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Paladin) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PaladinBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Necromancer) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.NecromancerBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.RaggedCaster) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.RaggedCasterBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.SkeletonCommando) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SkeletonCommandoBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.SkeletonSniper) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SkeletonSniperBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.TacticalSkeleton) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.TacticalSkeletonBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.GiantCursedSkull) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.GiantCursedSkullBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.BoneLee) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.BoneLeeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.DungeonSpirit) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DungeonSpiritBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    break;
                case "Desert":
                    if (Utils.kills(NPCID.Antlion) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.AntlionBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.FlyingAntlion) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.FlyingAntlionBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.WalkingAntlion) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.WalkingAntlionBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.Vulture) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.VultureBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.SandSlime) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SandSlimeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.Mummy) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.MummyBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.LightMummy) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.LightMummyBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.DarkMummy) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DarkMummyBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.DesertBeast) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DesertBasiliskBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.DesertLamiaDark) >= bannerKillsRequirement || Utils.kills(NPCID.DesertLamiaLight) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DesertLamiaBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.DesertGhoul) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DesertGhoulBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.DungeonSpirit) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DungeonSpiritBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Tumbleweed) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.TumbleweedBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.SandShark) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SandsharkBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.DuneSplicerHead) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DuneSplicerBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.SandElemental) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SandElementalBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    break;
                case "Old Ones Army":
                    if (Utils.kills(NPCID.DD2WyvernT1) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DD2WyvernBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.DD2JavelinstT1) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DD2JavelinThrowerBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.DD2SkeletonT1) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DD2SkeletonBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.DD2GoblinT1) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DD2GoblinBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.DD2GoblinBomberT1) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DD2GoblinBomberBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.DD2LightningBugT3) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DD2LightningBugBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.DD2KoboldWalkerT2) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DD2KoboldBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.DD2KoboldFlyerT2) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DD2KoboldFlyerBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.DD2DrakinT2) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DD2DrakinBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    break;
                case "Frost Legion":
                    if (Utils.kills(NPCID.MisterStabby) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.MisterStabbyBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.SnowmanGangsta) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SnowmanGangstaBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.SnowBalla) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SnowBallaBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    break;
                case "Pirate Invasion":
                    if (Utils.kills(NPCID.Pirate) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PirateBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.PirateDeadeye) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PirateDeadeyeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.PirateCorsair) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PirateCorsairBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.PirateCrossbower) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PirateCrossbowerBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.PirateCaptain) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PirateCaptainBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Parrot) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ParrotBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    break;
                case "Pumpkin Moon":
                    if (Utils.kills(NPCID.Scarecrow1) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ScarecrowBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Splinterling) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SplinterlingBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Hellhound) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.HellhoundBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Poltergeist) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PoltergeistBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.HeadlessHorseman) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.HeadlessHorsemanBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    break;
                case "Frost Moon":
                    if (Utils.kills(NPCID.GingerbreadMan) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.GingerbreadManBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.ZombieElf) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ZombieElfBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.ElfArcher) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ElfArcherBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Nutcracker) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.NutcrackerBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Yeti) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.YetiBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.ElfCopter) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ElfCopterBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Krampus) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.KrampusBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Flocko) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.FlockoBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    break;
                case "Martian Madness":
                    if (Utils.kills(NPCID.Scutlix) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ScutlixBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.MartianWalker) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.MartianWalkerBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.MartianDrone) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.MartianDroneBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.MartianTurret) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.MartianTeslaTurretBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.GigaZapper) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.MartianGigazapperBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.MartianEngineer) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.MartianEngineerBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.MartianOfficer) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.MartianOfficerBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.RayGunner) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.MartianRaygunnerBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.GrayGrunt) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.MartianGreyGruntBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.BrainScrambler) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.MartianBrainscramblerBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    break;
                case "Solar Zone":
                    if (Utils.kills(NPCID.SolarSolenian) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SolarSolenianBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostInsane;
                    }

                    if (Utils.kills(NPCID.SolarDrakomire) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SolarDrakomireBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostInsane;
                    }

                    if (Utils.kills(NPCID.SolarDrakomireRider) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SolarDrakomireRiderBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostInsane;
                    }

                    if (Utils.kills(NPCID.SolarCorite) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SolarCoriteBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostInsane;
                    }

                    if (Utils.kills(NPCID.SolarSroller) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SolarSrollerBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostInsane;
                    }

                    if (Utils.kills(NPCID.SolarCrawltipedeHead) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SolarCrawltipedeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostInsane;
                    }

                    break;
                case "Vortex Zone":
                    if (Utils.kills(NPCID.VortexHornet) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.VortexHornetBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostInsane;
                    }

                    if (Utils.kills(NPCID.VortexHornetQueen) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.VortexHornetQueenBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostInsane;
                    }

                    if (Utils.kills(NPCID.VortexLarva) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.VortexLarvaBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostInsane;
                    }

                    if (Utils.kills(NPCID.VortexRifleman) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.VortexRiflemanBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostInsane;
                    }

                    if (Utils.kills(NPCID.VortexSoldier) >= bannerKillsRequirement)
                    {

                    }
                    shop.item[nextSlot].SetDefaults(ItemID.VortexSoldierBanner);
                    shop.item[nextSlot++].shopCustomPrice = bannerCostInsane;
                    break;
                case "Nebula Zone":
                    if (Utils.kills(NPCID.NebulaBeast) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.NebulaBeastBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostInsane;
                    }

                    if (Utils.kills(NPCID.NebulaBrain) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.NebulaBrainBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostInsane;
                    }

                    if (Utils.kills(NPCID.NebulaHeadcrab) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.NebulaHeadcrabBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostInsane;
                    }

                    if (Utils.kills(NPCID.NebulaSoldier) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.NebulaSoldierBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostInsane;
                    }

                    break;
                case "Stardust Zone":
                    if (Utils.kills(NPCID.StardustJellyfishSmall) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.StardustJellyfishBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostInsane;
                    }

                    if (Utils.kills(NPCID.StardustJellyfishBig) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.StardustLargeCellBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostInsane;
                    }

                    if (Utils.kills(NPCID.StardustCellSmall) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.StardustSmallCellBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostInsane;
                    }

                    if (Utils.kills(NPCID.StardustSoldier) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.StardustSoldierBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostInsane;
                    }

                    if (Utils.kills(NPCID.StardustSpiderSmall) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.StardustSpiderBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostInsane;
                    }

                    if (Utils.kills(NPCID.StardustWormHead) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.StardustWormBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostInsane;
                    }

                    break;
                case "Ocean":
                    if (Utils.kills(NPCID.PinkJellyfish) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PinkJellyfishBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.Crab) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.CrabBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.SeaSnail) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SeaSnailBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.Squid) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SquidBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.Shark) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SharkBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    break;
                case "Snow":

                    if (Utils.kills(NPCID.IceSlime) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.IceSlimeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.ZombieEskimo) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ZombieEskimoBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.IceElemental) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.IceElementalBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Wolf) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.WolfBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.IceGolem) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.IceGolemBanner);
                        shop.item[nextSlot++].shopCustomPrice = 1000000;
                    }


                    if (Utils.kills(NPCID.Penguin) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PenguinBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }


                    if (Utils.kills(NPCID.IceBat) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.IceBatBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }


                    if (Utils.kills(NPCID.SnowFlinx) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SnowFlinxBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }


                    if (Utils.kills(NPCID.SpikedIceSlime) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SpikedIceSlimeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }


                    if (Utils.kills(NPCID.UndeadViking) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.UndeadVikingBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }


                    if (Utils.kills(NPCID.ArmoredViking) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ArmoredVikingBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }


                    if (Utils.kills(NPCID.IceTortoise) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.IceTortoiseBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }


                    if (Utils.kills(NPCID.IceElemental) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.IceElementalBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.IcyMerman) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.IcyMermanBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.PigronCorruption) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PigronBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }
                    break;
                case "Jungle":

                    if (Utils.kills(NPCID.Piranha) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PiranhaBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.Snatcher) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SnatcherBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.JungleBat) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.JungleBatBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.JungleSlime) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.JungleSlimeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.DoctorBones) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DoctorBonesBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.AnglerFish) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.AnglerFishBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Arapaima) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ArapaimaBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.GiantTortoise) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.TortoiseBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;

                    }

                    if (Utils.kills(NPCID.AngryTrapper) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.AngryTrapperBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Derpling) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DerplingBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.GiantFlyingFox) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.GiantFlyingFoxBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Hornet) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.HornetBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.ManEater) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ManEaterBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.SpikedJungleSlime) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SpikedJungleSlimeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.LacBeetle) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.LacBeetleBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.JungleCreeper) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.JungleCreeperBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Moth) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.MothBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Lihzahrd) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.LihzahrdBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.FlyingSnake) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.FlyingSnakeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    break;
                case "Mushroom":

                    if (Utils.kills(NPCID.FungiBulb) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.FungiBulbBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.AnomuraFungus) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.AnomuraFungusBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.MushiLadybug) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.MushiLadybugBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Spore) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SporeZombieBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.FungoFish) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.FungoFishBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    break;
                case "Corruption":

                    if (Utils.kills(NPCID.EaterofSouls) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.EaterofSoulsBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.DevourerHead) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DevourerBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.Corruptor) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.CorruptorBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.CorruptSlime) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.CorruptSlimeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Slimer) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SlimerBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.BloodFeeder) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.WorldFeederBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.CursedHammer) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.CursedHammerBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Clinger) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ClingerBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    break;
                case "Crimson":

                    if (Utils.kills(NPCID.BloodCrawler) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.BloodCrawlerBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.FaceMonster) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.FaceMonsterBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.Crimera) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.CrimeraBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.Herpling) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.HerplingBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Crimslime) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.CrimslimeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.BloodJelly) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.BloodJellyBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.BloodFeeder) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.BloodFeederBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.CrimsonAxe) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.CrimsonAxeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.IchorSticker) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.IchorStickerBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.FloatyGross) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.FloatyGrossBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    break;
                case "Hallow":

                    if (Utils.kills(NPCID.Pixie) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PixieBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Unicorn) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.UnicornBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.RainbowSlime) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.RainbowSlimeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Gastropod) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.GastropodBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.DD2LightningBugT3) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DD2LightningBugBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.IlluminantSlime) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.IlluminantSlimeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.IlluminantBat) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.IlluminantBatBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.ChaosElemental) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ChaosElementalBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.EnchantedSword) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.EnchantedSwordBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    break;
                case "Space":
                    if (Utils.kills(NPCID.Harpy) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.HarpyBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.WyvernHead) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.WyvernBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    break;
                case "Underworld":

                    if (Utils.kills(NPCID.Hellbat) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.HellbatBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.LavaSlime) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.LavaSlimeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.FireImp) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.FireImpBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.Demon) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DemonBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.BoneSerpentHead) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.BoneSerpentBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.Lavabat) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.LavaBatBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.RedDevil) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.RedDevilBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    break;
                case "Overworld":

                    if (Utils.kills(NPCID.BlueSlime) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SlimeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.GreenSlime) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.GreenSlimeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.PurpleSlime) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PurpleSlimeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.Pinky) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PinkyBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.Zombie) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ZombieBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.Raven) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.RavenBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.DemonEye) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.DemonEyeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.PossessedArmor) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PossessedArmorBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.HoppinJack) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.HoppinJackBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Werewolf) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.WerewolfBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Bunny) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.BunnyBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.Bird) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.BirdBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.Worm) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.WormBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.RedSlime) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.RedSlimeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.YellowSlime) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.YellowSlimeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.ToxicSludge) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ToxicSludgeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.Skeleton) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SkeletonBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.Salamander) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SalamanderBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.Crawdad) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.CrawdadBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.GiantShelly) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.GiantShellyBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.UndeadMiner) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.UndeadMinerBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.Tim) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.TimBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.Nymph) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.NypmhBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.CochinealBeetle) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.CochinealBeetleBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.BlueJellyfish) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.JellyfishBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.GreenJellyfish) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.GreenJellyfishBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.PinkJellyfish) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PinkJellyfishBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.WallCreeper) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SpiderBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.BlackRecluse) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.BlackRecluseBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.GraniteGolem) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.GraniteGolemBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.GraniteFlyer) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.GraniteFlyerBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.Medusa) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.MedusaBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }

                    if (Utils.kills(NPCID.MeteorHead) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.MeteorHeadBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.FlyingFish) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.FlyingFishBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.UmbrellaSlime) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.UmbrellaSlimeBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.ZombieRaincoat) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.RaincoatZombieBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostEasy;
                    }

                    if (Utils.kills(NPCID.AngryNimbus) >= bannerKillsRequirement)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.AngryNimbusBanner);
                        shop.item[nextSlot++].shopCustomPrice = bannerCostHard;
                    }
                    break;
                case "Hair Dyes":
                    shop.item[nextSlot++].SetDefaults(ItemID.HairDyeRemover);
                    shop.item[nextSlot++].SetDefaults(ItemID.DepthHairDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.LifeHairDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.ManaHairDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.MoneyHairDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.TimeHairDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.TeamHairDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.PartyHairDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.BiomeHairDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.SpeedHairDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.RainbowHairDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.MartianHairDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.TwilightHairDye);
                    shop.item[nextSlot].SetDefaults(ItemID.LovePotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    break;
                default:
                    shop.SetupShop(18);
                    break;
            }
        }
    }
}
