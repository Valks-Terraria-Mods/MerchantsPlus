﻿using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    class ShopPartyGirl
    {
        private Chest shop;
        private int nextSlot;

        public ShopPartyGirl(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            switch (currentShop)
            {
                case "Boss Masks":
                    shop.item[nextSlot].SetDefaults(ItemID.BrainMask);
                    shop.item[nextSlot++].shopCustomPrice = 100000;
                    shop.item[nextSlot].SetDefaults(ItemID.DukeFishronMask);
                    shop.item[nextSlot++].shopCustomPrice = 100000;
                    shop.item[nextSlot].SetDefaults(ItemID.EyeMask);
                    shop.item[nextSlot++].shopCustomPrice = 100000;
                    shop.item[nextSlot].SetDefaults(ItemID.KingSlimeMask);
                    shop.item[nextSlot++].shopCustomPrice = 100000;
                    shop.item[nextSlot].SetDefaults(ItemID.BeeMask);
                    shop.item[nextSlot++].shopCustomPrice = 100000;
                    shop.item[nextSlot].SetDefaults(ItemID.SkeletronPrimeMask);
                    shop.item[nextSlot++].shopCustomPrice = 100000;
                    shop.item[nextSlot].SetDefaults(ItemID.FleshMask);
                    shop.item[nextSlot++].shopCustomPrice = 100000;
                    shop.item[nextSlot].SetDefaults(ItemID.BossMaskCultist);
                    shop.item[nextSlot++].shopCustomPrice = 100000;
                    shop.item[nextSlot].SetDefaults(ItemID.BossMaskBetsy);
                    shop.item[nextSlot++].shopCustomPrice = 100000;
                    shop.item[nextSlot].SetDefaults(ItemID.BossMaskOgre);
                    shop.item[nextSlot++].shopCustomPrice = 100000;
                    shop.item[nextSlot].SetDefaults(ItemID.DestroyerMask);
                    shop.item[nextSlot++].shopCustomPrice = 100000;
                    shop.item[nextSlot].SetDefaults(ItemID.EaterMask);
                    shop.item[nextSlot++].shopCustomPrice = 100000;
                    shop.item[nextSlot].SetDefaults(ItemID.GolemMask);
                    shop.item[nextSlot++].shopCustomPrice = 100000;
                    shop.item[nextSlot].SetDefaults(ItemID.PlanteraMask);
                    shop.item[nextSlot++].shopCustomPrice = 100000;
                    shop.item[nextSlot].SetDefaults(ItemID.SkeletronMask);
                    shop.item[nextSlot++].shopCustomPrice = 100000;
                    shop.item[nextSlot].SetDefaults(ItemID.TwinMask);
                    shop.item[nextSlot++].shopCustomPrice = 100000;
                    shop.item[nextSlot].SetDefaults(ItemID.BossMaskDarkMage);
                    shop.item[nextSlot++].shopCustomPrice = 100000;
                    shop.item[nextSlot].SetDefaults(ItemID.BossMaskMoonlord);
                    shop.item[nextSlot++].shopCustomPrice = 1000000;
                    break;
                case "Vanity Sets 4":
                    shop.item[nextSlot].SetDefaults(ItemID.MummyPants);
                    shop.item[nextSlot++].shopCustomPrice = 30000;
                    shop.item[nextSlot++].SetDefaults(ItemID.PedguinHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.PedguinShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.PedguinPants);
                    shop.item[nextSlot].SetDefaults(ItemID.PharaohsMask);
                    shop.item[nextSlot++].shopCustomPrice = 30000;
                    shop.item[nextSlot].SetDefaults(ItemID.PharaohsRobe);
                    shop.item[nextSlot++].shopCustomPrice = 30000;
                    shop.item[nextSlot++].SetDefaults(ItemID.PirateHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.PirateShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.PiratePants);
                    shop.item[nextSlot++].SetDefaults(ItemID.PlumbersHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.PlumbersShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.PlumbersPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.PrincessHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.PrincessDress);
                    shop.item[nextSlot++].SetDefaults(ItemID.PrincessDressNew);
                    shop.item[nextSlot++].SetDefaults(ItemID.RainHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.RainCoat);
                    shop.item[nextSlot++].SetDefaults(ItemID.RuneHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.RuneRobe);
                    shop.item[nextSlot].SetDefaults(ItemID.SailorHat);
                    shop.item[nextSlot++].shopCustomPrice = 30000;
                    shop.item[nextSlot].SetDefaults(ItemID.SailorShirt);
                    shop.item[nextSlot++].shopCustomPrice = 30000;
                    shop.item[nextSlot].SetDefaults(ItemID.SailorPants);
                    shop.item[nextSlot++].shopCustomPrice = 30000;
                    shop.item[nextSlot++].SetDefaults(ItemID.ScarecrowHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.ScarecrowShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.ScarecrowPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.SteampunkHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.SteampunkShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.SteampunkPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.TaxCollectorHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.TaxCollectorSuit);
                    shop.item[nextSlot++].SetDefaults(ItemID.TaxCollectorPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.TheDoctorsShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.TheDoctorsPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.TuxedoShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.TuxedoPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.TheBrideHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.TheBrideDress);
                    shop.item[nextSlot++].SetDefaults(ItemID.WhiteTuxedoShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.WhiteTuxedoPants);
                    break;
                case "Vanity Sets 3":
                    shop.item[nextSlot++].SetDefaults(ItemID.BuccaneerBandana);
                    shop.item[nextSlot++].SetDefaults(ItemID.BuccaneerShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.BuccaneerPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.ClownHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.ClownShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.ClownPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.CowboyHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.CowboyJacket);
                    shop.item[nextSlot++].SetDefaults(ItemID.CowboyPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.ElfHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.ElfShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.ElfPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.FallenTuxedoShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.FallenTuxedoPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.FamiliarWig);
                    shop.item[nextSlot++].SetDefaults(ItemID.FamiliarShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.FamiliarPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.FishCostumeMask);
                    shop.item[nextSlot++].SetDefaults(ItemID.FishCostumeShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.FishCostumeFinskirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.HerosHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.HerosShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.HerosPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.LamiaHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.LamiaShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.LamiaPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.BlueLunaticHood);
                    shop.item[nextSlot++].SetDefaults(ItemID.BlueLunaticRobe);
                    shop.item[nextSlot++].SetDefaults(ItemID.WhiteLunaticHood);
                    shop.item[nextSlot++].SetDefaults(ItemID.WhiteLunaticRobe);
                    shop.item[nextSlot++].SetDefaults(ItemID.MartianCostumeMask);
                    shop.item[nextSlot++].SetDefaults(ItemID.MartianCostumeShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.MartianCostumePants);
                    shop.item[nextSlot++].SetDefaults(ItemID.MartianUniformHelmet);
                    shop.item[nextSlot++].SetDefaults(ItemID.MartianUniformTorso);
                    shop.item[nextSlot++].SetDefaults(ItemID.MartianUniformPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.MermaidAdornment);
                    shop.item[nextSlot++].SetDefaults(ItemID.MermaidTail);
                    shop.item[nextSlot].SetDefaults(ItemID.MummyMask);
                    shop.item[nextSlot++].shopCustomPrice = 30000;
                    shop.item[nextSlot].SetDefaults(ItemID.MummyShirt);
                    shop.item[nextSlot++].shopCustomPrice = 30000;
                    break;
                case "Vanity Sets 2":
                    shop.item[nextSlot++].SetDefaults(ItemID.ReaperHood);
                    shop.item[nextSlot++].SetDefaults(ItemID.ReaperRobe);
                    shop.item[nextSlot++].SetDefaults(ItemID.RobotMask);
                    shop.item[nextSlot++].SetDefaults(ItemID.RobotShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.RobotPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.SpaceCreatureMask);
                    shop.item[nextSlot++].SetDefaults(ItemID.SpaceCreatureShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.SpaceCreaturePants);
                    shop.item[nextSlot++].SetDefaults(ItemID.TreasureHunterShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.TreasureHunterPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.UnicornMask);
                    shop.item[nextSlot++].SetDefaults(ItemID.UnicornShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.UnicornPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.VampireMask);
                    shop.item[nextSlot++].SetDefaults(ItemID.VampireShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.VampirePants);
                    shop.item[nextSlot++].SetDefaults(ItemID.WitchHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.WitchDress);
                    shop.item[nextSlot++].SetDefaults(ItemID.WitchBoots);
                    shop.item[nextSlot++].SetDefaults(ItemID.MrsClauseHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.MrsClauseShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.MrsClauseHeels);
                    shop.item[nextSlot++].SetDefaults(ItemID.SantaHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.SantaShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.SantaPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.ParkaHood);
                    shop.item[nextSlot++].SetDefaults(ItemID.ParkaCoat);
                    shop.item[nextSlot++].SetDefaults(ItemID.ParkaPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.TreeMask);
                    shop.item[nextSlot++].SetDefaults(ItemID.TreeShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.TreeTrunks);
                    shop.item[nextSlot++].SetDefaults(ItemID.AncientArmorHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.AncientArmorPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.AncientArmorShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.ArchaeologistsHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.ArchaeologistsJacket);
                    shop.item[nextSlot++].SetDefaults(ItemID.ArchaeologistsPants);
                    shop.item[nextSlot].SetDefaults(ItemID.BeeHat);
                    shop.item[nextSlot++].shopCustomPrice = 30000;
                    shop.item[nextSlot].SetDefaults(ItemID.BeeShirt);
                    shop.item[nextSlot++].shopCustomPrice = 30000;
                    shop.item[nextSlot].SetDefaults(ItemID.BeePants);
                    shop.item[nextSlot++].shopCustomPrice = 30000;
                    break;
                case "Vanity Sets 1":
                    shop.item[nextSlot++].SetDefaults(ItemID.BrideofFrankensteinDress);
                    shop.item[nextSlot++].SetDefaults(ItemID.BrideofFrankensteinMask);
                    shop.item[nextSlot++].SetDefaults(ItemID.CatMask);
                    shop.item[nextSlot++].SetDefaults(ItemID.CatShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.CatPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.RedHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.ClothierJacket);
                    shop.item[nextSlot++].SetDefaults(ItemID.ClothierPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.CyborgHelmet);
                    shop.item[nextSlot++].SetDefaults(ItemID.CyborgShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.CyborgPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.DryadCoverings);
                    shop.item[nextSlot++].SetDefaults(ItemID.Dryadisque);
                    shop.item[nextSlot++].SetDefaults(ItemID.DryadLoincloth);
                    shop.item[nextSlot++].SetDefaults(ItemID.CreeperMask);
                    shop.item[nextSlot++].SetDefaults(ItemID.CreeperShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.CreeperPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.DyeTraderTurban);
                    shop.item[nextSlot++].SetDefaults(ItemID.DyeTraderRobe);
                    shop.item[nextSlot++].SetDefaults(ItemID.FoxMask);
                    shop.item[nextSlot++].SetDefaults(ItemID.FoxShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.FoxPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.GhostMask);
                    shop.item[nextSlot++].SetDefaults(ItemID.GhostShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.KarateTortoiseMask);
                    shop.item[nextSlot++].SetDefaults(ItemID.KarateTortoiseShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.KarateTortoisePants);
                    shop.item[nextSlot++].SetDefaults(ItemID.LeprechaunHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.LeprechaunShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.LeprechaunPants);
                    shop.item[nextSlot++].SetDefaults(ItemID.NurseHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.NurseShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.NursePants);
                    shop.item[nextSlot++].SetDefaults(ItemID.PixieShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.PixiePants);
                    shop.item[nextSlot++].SetDefaults(ItemID.PrincessHat);
                    shop.item[nextSlot++].SetDefaults(ItemID.PrincessDress);
                    shop.item[nextSlot].SetDefaults(ItemID.PumpkinHelmet);
                    shop.item[nextSlot++].shopCustomPrice = 30000;
                    shop.item[nextSlot++].SetDefaults(ItemID.PumpkinShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.PumpkinPants);
                    break;
                case "Party Stuff":
                    shop.item[nextSlot++].SetDefaults(ItemID.ConfettiGun);
                    shop.item[nextSlot++].SetDefaults(ItemID.Confetti);
                    shop.item[nextSlot++].SetDefaults(ItemID.SmokeBomb);
                    shop.item[nextSlot++].SetDefaults(ItemID.BubbleMachine);
                    shop.item[nextSlot++].SetDefaults(ItemID.BubbleWand);
                    shop.item[nextSlot++].SetDefaults(ItemID.BeachBall);
                    shop.item[nextSlot++].SetDefaults(ItemID.LavaLamp);
                    shop.item[nextSlot++].SetDefaults(ItemID.FireworksBox);
                    shop.item[nextSlot++].SetDefaults(ItemID.FireworkFountain);
                    shop.item[nextSlot++].SetDefaults(ItemID.RedRocket);
                    shop.item[nextSlot++].SetDefaults(ItemID.GreenRocket);
                    shop.item[nextSlot++].SetDefaults(ItemID.BlueRocket);
                    shop.item[nextSlot++].SetDefaults(ItemID.YellowRocket);
                    shop.item[nextSlot++].SetDefaults(ItemID.ConfettiCannon);
                    shop.item[nextSlot++].SetDefaults(ItemID.Bubble);
                    shop.item[nextSlot++].SetDefaults(ItemID.SmokeBlock);
                    shop.item[nextSlot++].SetDefaults(ItemID.PartyMonolith);
                    shop.item[nextSlot++].SetDefaults(ItemID.SillyBalloonMachine);
                    shop.item[nextSlot++].SetDefaults(ItemID.PartyPresent);
                    shop.item[nextSlot++].SetDefaults(ItemID.Pigronata);
                    shop.item[nextSlot++].SetDefaults(ItemID.SillyStreamerBlue);
                    shop.item[nextSlot++].SetDefaults(ItemID.SillyStreamerGreen);
                    shop.item[nextSlot++].SetDefaults(ItemID.SillyStreamerPink);
                    shop.item[nextSlot++].SetDefaults(ItemID.SillyBalloonTiedPurple);
                    shop.item[nextSlot++].SetDefaults(ItemID.SillyBalloonTiedGreen);
                    shop.item[nextSlot++].SetDefaults(ItemID.SillyBalloonTiedPink);
                    shop.item[nextSlot++].SetDefaults(ItemID.MysteriousCape);
                    shop.item[nextSlot++].SetDefaults(ItemID.DiamondRing);
                    shop.item[nextSlot++].SetDefaults(ItemID.AngelHalo);
                    shop.item[nextSlot++].SetDefaults(ItemID.GingerBeard);
                    break;
                default:
                    shop.SetupShop(13);
                    break;
            }
        }
    }
}