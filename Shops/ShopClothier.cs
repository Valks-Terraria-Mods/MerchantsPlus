namespace MerchantsPlus.Shops;

public class ShopClothier : Shop
{
    public override List<string> Shops { get; } = [
        "Clothing",
        "Boss Masks",
        "Vanity I",
        "Vanity II",
        "Vanity III",
        "Vanity IV" ];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        switch (shop)
        {
            case "Boss Masks":
                BossMasks();
                return;
            case "Vanity IV":
                VanityIV();
                return;
            case "Vanity III":
                VanityIII();
                return;
            case "Vanity II":
                VanityII();
                return;
            case "Vanity I":
                VanityI();
                return;
            case "Clothing":
                Clothing();
                return;
            default:
                // Default Shop
                Inv.SetupShop(ShopType.Clothier);
                return;
        }
    }

    private void Clothing()
    {
        AddItem(ItemID.BlackThread);
        AddItem(ItemID.PinkThread);
        AddItem(ItemID.FamiliarWig);
        AddItem(ItemID.FamiliarShirt);
        AddItem(ItemID.FamiliarPants);

        if (Progression.SlimeKing)
        {
            AddItem(ItemID.EyePatch, ItemCosts.Vanity);
            AddItem(ItemID.PlatinumCrown, ItemCosts.Vanity);
        }

        if (Progression.EyeOfCthulhu)
        {
            AddItem(ItemID.Sunglasses, ItemCosts.Vanity);
        }

        if (Progression.BrainOrEater)
        {
            AddItem(ItemID.GuyFawkesMask, ItemCosts.Vanity);
        }

        if (Progression.Skeletron)
        {
            AddItem(ItemID.ReindeerAntlers, ItemCosts.Vanity);
        }

        if (Progression.Hardmode)
        {
            AddItem(ItemID.ReaperRobe, ItemCosts.Vanity);
            AddItem(ItemID.ReaperHood, ItemCosts.Vanity);
        }

        if (NPC.downedMechBossAny)
        {
            AddItem(ItemID.SpaceCreaturePants, ItemCosts.Vanity);
            AddItem(ItemID.SpaceCreatureShirt, ItemCosts.Vanity);
            AddItem(ItemID.SpaceCreatureMask, ItemCosts.Vanity);
            AddItem(ItemID.SkiphsPants, ItemCosts.Vanity);
            AddItem(ItemID.SkiphsShirt, ItemCosts.Vanity);
            AddItem(ItemID.SkiphsHelm, ItemCosts.Vanity);
            AddItem(ItemID.WillsLeggings, ItemCosts.Vanity);
            AddItem(ItemID.WillsBreastplate, ItemCosts.Vanity);
            AddItem(ItemID.WillsHelmet, ItemCosts.Vanity);
            AddItem(ItemID.AaronsLeggings, ItemCosts.Vanity);
            AddItem(ItemID.AaronsBreastplate, ItemCosts.Vanity);
            AddItem(ItemID.AaronsHelmet, ItemCosts.Vanity);
            AddItem(ItemID.BejeweledValkyrieBody, ItemCosts.Vanity);
            AddItem(ItemID.BejeweledValkyrieHead, ItemCosts.Vanity);
        }

        if (Progression.Plantera)
        {
            AddItem(ItemID.BunnyHood, ItemCosts.Vanity);
        }

        if (Main.raining)
        {
            AddItem(ItemID.CrownosLeggings, ItemCosts.Vanity);
            AddItem(ItemID.CrownosBreastplate, ItemCosts.Vanity);
            AddItem(ItemID.CrownosMask, ItemCosts.Vanity);
        }

        if (Main.bloodMoon)
        {
            AddItem(ItemID.CenxsDressPants, ItemCosts.Vanity);
            AddItem(ItemID.CenxsLeggings, ItemCosts.Vanity);
            AddItem(ItemID.CenxsDress, ItemCosts.Vanity);
            AddItem(ItemID.CenxsBreastplate, ItemCosts.Vanity);
            AddItem(ItemID.CenxsTiara, ItemCosts.Vanity);
        }

        if (Main.eclipse)
        {
            AddItem(ItemID.JimsLeggings, ItemCosts.Vanity);
            AddItem(ItemID.JimsBreastplate, ItemCosts.Vanity);
            AddItem(ItemID.JimsHelmet, ItemCosts.Vanity);
        }

        if (Main.dayTime)
        {
            AddItem(ItemID.ArkhalisPants, ItemCosts.Vanity);
            AddItem(ItemID.ArkhalisShirt, ItemCosts.Vanity);
            AddItem(ItemID.ArkhalisHat, ItemCosts.Vanity);
            AddItem(ItemID.Yoraiz0rPants, ItemCosts.Vanity);
            AddItem(ItemID.Yoraiz0rShirt, ItemCosts.Vanity);
            AddItem(ItemID.Yoraiz0rHead, ItemCosts.Vanity);
            AddItem(ItemID.Yoraiz0rDarkness, ItemCosts.Vanity);
        }
        else
        {
            AddItem(ItemID.LokisPants, ItemCosts.Vanity);
            AddItem(ItemID.LokisShirt, ItemCosts.Vanity);
            AddItem(ItemID.LokisHelm, ItemCosts.Vanity);
        }

        if (Progression.Hardmode)
        {
            AddItem(ItemID.LeinforsPants, ItemCosts.Vanity);
            AddItem(ItemID.LeinforsShirt, ItemCosts.Vanity);
            AddItem(ItemID.LeinforsHat, ItemCosts.Vanity);
            AddItem(ItemID.LeinforsAccessory, ItemCosts.Vanity);
        }

        if (NPC.downedAncientCultist)
        {
            AddItem(ItemID.Yoraiz0rWings, Coins.Platinum(2));
        }
    }

    private void VanityI()
    {
        AddItem(ItemID.BrideofFrankensteinDress, ItemCosts.Vanity);
        AddItem(ItemID.BrideofFrankensteinMask, ItemCosts.Vanity);
        AddItem(ItemID.CatMask, ItemCosts.Vanity);
        AddItem(ItemID.CatShirt, ItemCosts.Vanity);
        AddItem(ItemID.CatPants, ItemCosts.Vanity);
        AddItem(ItemID.RedHat, ItemCosts.Vanity);
        AddItem(ItemID.ClothierJacket, ItemCosts.Vanity);
        AddItem(ItemID.ClothierPants, ItemCosts.Vanity);
        AddItem(ItemID.CyborgHelmet, ItemCosts.Vanity);
        AddItem(ItemID.CyborgShirt, ItemCosts.Vanity);
        AddItem(ItemID.CyborgPants, ItemCosts.Vanity);
        AddItem(ItemID.DryadCoverings, ItemCosts.Vanity);
        AddItem(ItemID.Dryadisque, ItemCosts.Vanity);
        AddItem(ItemID.DryadLoincloth, ItemCosts.Vanity);
        AddItem(ItemID.CreeperMask, ItemCosts.Vanity);
        AddItem(ItemID.CreeperShirt, ItemCosts.Vanity);
        AddItem(ItemID.CreeperPants, ItemCosts.Vanity);
        AddItem(ItemID.DyeTraderTurban, ItemCosts.Vanity);
        AddItem(ItemID.DyeTraderRobe, ItemCosts.Vanity);
        AddItem(ItemID.FoxMask, ItemCosts.Vanity);
        AddItem(ItemID.FoxShirt, ItemCosts.Vanity);
        AddItem(ItemID.FoxPants, ItemCosts.Vanity);
        AddItem(ItemID.GhostMask, ItemCosts.Vanity);
        AddItem(ItemID.GhostShirt, ItemCosts.Vanity);
        AddItem(ItemID.KarateTortoiseMask, ItemCosts.Vanity);
        AddItem(ItemID.KarateTortoiseShirt, ItemCosts.Vanity);
        AddItem(ItemID.KarateTortoisePants, ItemCosts.Vanity);
        AddItem(ItemID.LeprechaunHat, ItemCosts.Vanity);
        AddItem(ItemID.LeprechaunShirt, ItemCosts.Vanity);
        AddItem(ItemID.LeprechaunPants, ItemCosts.Vanity);
        AddItem(ItemID.NurseHat, ItemCosts.Vanity);
        AddItem(ItemID.NurseShirt, ItemCosts.Vanity);
        AddItem(ItemID.NursePants, ItemCosts.Vanity);
        AddItem(ItemID.PixieShirt, ItemCosts.Vanity);
        AddItem(ItemID.PixiePants, ItemCosts.Vanity);
        AddItem(ItemID.PrincessHat, ItemCosts.Vanity);
        AddItem(ItemID.PrincessDress, ItemCosts.Vanity);
        AddItem(ItemID.PumpkinHelmet, ItemCosts.Vanity);
        AddItem(ItemID.PumpkinShirt, ItemCosts.Vanity);
        AddItem(ItemID.PumpkinPants, ItemCosts.Vanity);
    }

    private void VanityII()
    {
        AddItem(ItemID.ReaperHood, ItemCosts.Vanity);
        AddItem(ItemID.ReaperRobe, ItemCosts.Vanity);
        AddItem(ItemID.RobotMask, ItemCosts.Vanity);
        AddItem(ItemID.RobotShirt, ItemCosts.Vanity);
        AddItem(ItemID.RobotPants, ItemCosts.Vanity);
        AddItem(ItemID.SpaceCreatureMask, ItemCosts.Vanity);
        AddItem(ItemID.SpaceCreatureShirt, ItemCosts.Vanity);
        AddItem(ItemID.SpaceCreaturePants, ItemCosts.Vanity);
        AddItem(ItemID.TreasureHunterShirt, ItemCosts.Vanity);
        AddItem(ItemID.TreasureHunterPants, ItemCosts.Vanity);
        AddItem(ItemID.UnicornMask, ItemCosts.Vanity);
        AddItem(ItemID.UnicornShirt, ItemCosts.Vanity);
        AddItem(ItemID.UnicornPants, ItemCosts.Vanity);
        AddItem(ItemID.VampireMask, ItemCosts.Vanity);
        AddItem(ItemID.VampireShirt, ItemCosts.Vanity);
        AddItem(ItemID.VampirePants, ItemCosts.Vanity);
        AddItem(ItemID.WitchHat, ItemCosts.Vanity);
        AddItem(ItemID.WitchDress, ItemCosts.Vanity);
        AddItem(ItemID.WitchBoots, ItemCosts.Vanity);
        AddItem(ItemID.MrsClauseHat, ItemCosts.Vanity);
        AddItem(ItemID.MrsClauseShirt, ItemCosts.Vanity);
        AddItem(ItemID.MrsClauseHeels, ItemCosts.Vanity);
        AddItem(ItemID.SantaHat, ItemCosts.Vanity);
        AddItem(ItemID.SantaShirt, ItemCosts.Vanity);
        AddItem(ItemID.SantaPants, ItemCosts.Vanity);
        AddItem(ItemID.ParkaHood, ItemCosts.Vanity);
        AddItem(ItemID.ParkaCoat, ItemCosts.Vanity);
        AddItem(ItemID.ParkaPants, ItemCosts.Vanity);
        AddItem(ItemID.TreeMask, ItemCosts.Vanity);
        AddItem(ItemID.TreeShirt, ItemCosts.Vanity);
        AddItem(ItemID.TreeTrunks, ItemCosts.Vanity);
        AddItem(ItemID.AncientArmorHat, ItemCosts.Vanity);
        AddItem(ItemID.AncientArmorPants, ItemCosts.Vanity);
        AddItem(ItemID.AncientArmorShirt, ItemCosts.Vanity);
        AddItem(ItemID.ArchaeologistsHat, ItemCosts.Vanity);
        AddItem(ItemID.ArchaeologistsJacket, ItemCosts.Vanity);
        AddItem(ItemID.ArchaeologistsPants, ItemCosts.Vanity);
        AddItem(ItemID.BeeHat, ItemCosts.Vanity);
        AddItem(ItemID.BeeShirt, ItemCosts.Vanity);
        AddItem(ItemID.BeePants, ItemCosts.Vanity);
    }

    private void VanityIII()
    {
        AddItem(ItemID.BuccaneerBandana, ItemCosts.Vanity);
        AddItem(ItemID.BuccaneerShirt, ItemCosts.Vanity);
        AddItem(ItemID.BuccaneerPants, ItemCosts.Vanity);
        AddItem(ItemID.ClownHat, ItemCosts.Vanity);
        AddItem(ItemID.ClownShirt, ItemCosts.Vanity);
        AddItem(ItemID.ClownPants, ItemCosts.Vanity);
        AddItem(ItemID.CowboyHat, ItemCosts.Vanity);
        AddItem(ItemID.CowboyJacket, ItemCosts.Vanity);
        AddItem(ItemID.CowboyPants, ItemCosts.Vanity);
        AddItem(ItemID.ElfHat, ItemCosts.Vanity);
        AddItem(ItemID.ElfShirt, ItemCosts.Vanity);
        AddItem(ItemID.ElfPants, ItemCosts.Vanity);
        AddItem(ItemID.FallenTuxedoShirt, ItemCosts.Vanity);
        AddItem(ItemID.FallenTuxedoPants, ItemCosts.Vanity);
        AddItem(ItemID.FamiliarWig, ItemCosts.Vanity);
        AddItem(ItemID.FamiliarShirt, ItemCosts.Vanity);
        AddItem(ItemID.FamiliarPants, ItemCosts.Vanity);
        AddItem(ItemID.FishCostumeMask, ItemCosts.Vanity);
        AddItem(ItemID.FishCostumeShirt, ItemCosts.Vanity);
        AddItem(ItemID.FishCostumeFinskirt, ItemCosts.Vanity);
        AddItem(ItemID.HerosHat, ItemCosts.Vanity);
        AddItem(ItemID.HerosShirt, ItemCosts.Vanity);
        AddItem(ItemID.HerosPants, ItemCosts.Vanity);
        AddItem(ItemID.LamiaHat, ItemCosts.Vanity);
        AddItem(ItemID.LamiaShirt, ItemCosts.Vanity);
        AddItem(ItemID.LamiaPants, ItemCosts.Vanity);
        AddItem(ItemID.BlueLunaticHood, ItemCosts.Vanity);
        AddItem(ItemID.BlueLunaticRobe, ItemCosts.Vanity);
        AddItem(ItemID.WhiteLunaticHood, ItemCosts.Vanity);
        AddItem(ItemID.WhiteLunaticRobe, ItemCosts.Vanity);
        AddItem(ItemID.MartianCostumeMask, ItemCosts.Vanity);
        AddItem(ItemID.MartianCostumeShirt, ItemCosts.Vanity);
        AddItem(ItemID.MartianCostumePants, ItemCosts.Vanity);
        AddItem(ItemID.MartianUniformHelmet, ItemCosts.Vanity);
        AddItem(ItemID.MartianUniformTorso, ItemCosts.Vanity);
        AddItem(ItemID.MartianUniformPants, ItemCosts.Vanity);
        AddItem(ItemID.MermaidAdornment, ItemCosts.Vanity);
        AddItem(ItemID.MermaidTail, ItemCosts.Vanity);
        AddItem(ItemID.MummyMask, ItemCosts.Vanity);
        AddItem(ItemID.MummyShirt, ItemCosts.Vanity);
    }

    private void VanityIV()
    {
        AddItem(ItemID.MummyPants, ItemCosts.Vanity);
        AddItem(ItemID.PedguinHat, ItemCosts.Vanity);
        AddItem(ItemID.PedguinShirt, ItemCosts.Vanity);
        AddItem(ItemID.PedguinPants, ItemCosts.Vanity);
        AddItem(ItemID.PharaohsMask, ItemCosts.Vanity);
        AddItem(ItemID.PharaohsRobe, ItemCosts.Vanity);
        AddItem(ItemID.PirateHat, ItemCosts.Vanity);
        AddItem(ItemID.PirateShirt, ItemCosts.Vanity);
        AddItem(ItemID.PiratePants, ItemCosts.Vanity);
        AddItem(ItemID.PlumbersHat, ItemCosts.Vanity);
        AddItem(ItemID.PlumbersShirt, ItemCosts.Vanity);
        AddItem(ItemID.PlumbersPants, ItemCosts.Vanity);
        AddItem(ItemID.PrincessHat, ItemCosts.Vanity);
        AddItem(ItemID.PrincessDress, ItemCosts.Vanity);
        AddItem(ItemID.PrincessDressNew, ItemCosts.Vanity);
        AddItem(ItemID.RainHat, ItemCosts.Vanity);
        AddItem(ItemID.RainCoat, ItemCosts.Vanity);
        AddItem(ItemID.RuneHat, ItemCosts.Vanity);
        AddItem(ItemID.RuneRobe, ItemCosts.Vanity);
        AddItem(ItemID.SailorHat, ItemCosts.Vanity);
        AddItem(ItemID.SailorShirt, ItemCosts.Vanity);
        AddItem(ItemID.SailorPants, ItemCosts.Vanity);
        AddItem(ItemID.ScarecrowHat, ItemCosts.Vanity);
        AddItem(ItemID.ScarecrowShirt, ItemCosts.Vanity);
        AddItem(ItemID.ScarecrowPants, ItemCosts.Vanity);
        AddItem(ItemID.SteampunkHat, ItemCosts.Vanity);
        AddItem(ItemID.SteampunkShirt, ItemCosts.Vanity);
        AddItem(ItemID.SteampunkPants, ItemCosts.Vanity);
        AddItem(ItemID.TaxCollectorHat, ItemCosts.Vanity);
        AddItem(ItemID.TaxCollectorSuit, ItemCosts.Vanity);
        AddItem(ItemID.TaxCollectorPants, ItemCosts.Vanity);
        AddItem(ItemID.TheDoctorsShirt, ItemCosts.Vanity);
        AddItem(ItemID.TheDoctorsPants, ItemCosts.Vanity);
        AddItem(ItemID.TuxedoShirt, ItemCosts.Vanity);
        AddItem(ItemID.TuxedoPants, ItemCosts.Vanity);
        AddItem(ItemID.TheBrideHat, ItemCosts.Vanity);
        AddItem(ItemID.TheBrideDress, ItemCosts.Vanity);
        AddItem(ItemID.WhiteTuxedoShirt, ItemCosts.Vanity);
        AddItem(ItemID.WhiteTuxedoPants, ItemCosts.Vanity);
    }

    private void BossMasks()
    {
        AddItem(ItemID.BrainMask, ItemCosts.Vanity);
        AddItem(ItemID.DukeFishronMask, ItemCosts.Vanity);
        AddItem(ItemID.EyeMask, ItemCosts.Vanity);
        AddItem(ItemID.KingSlimeMask, ItemCosts.Vanity);
        AddItem(ItemID.BeeMask, ItemCosts.Vanity);
        AddItem(ItemID.SkeletronPrimeMask, ItemCosts.Vanity);
        AddItem(ItemID.FleshMask, ItemCosts.Vanity);
        AddItem(ItemID.BossMaskCultist, ItemCosts.Vanity);
        AddItem(ItemID.BossMaskBetsy, ItemCosts.Vanity);
        AddItem(ItemID.BossMaskOgre, ItemCosts.Vanity);
        AddItem(ItemID.DestroyerMask, ItemCosts.Vanity);
        AddItem(ItemID.EaterMask, ItemCosts.Vanity);
        AddItem(ItemID.GolemMask, ItemCosts.Vanity);
        AddItem(ItemID.PlanteraMask, ItemCosts.Vanity);
        AddItem(ItemID.SkeletronMask, ItemCosts.Vanity);
        AddItem(ItemID.TwinMask, ItemCosts.Vanity);
        AddItem(ItemID.BossMaskDarkMage, ItemCosts.Vanity);
        AddItem(ItemID.BossMaskMoonlord, ItemCosts.Vanity);
    }
}