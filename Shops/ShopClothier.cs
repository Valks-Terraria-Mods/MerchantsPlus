namespace MerchantsPlus.Merchants;

public class ShopClothier : Shop
{
    public override string[] Shops => [ 
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
                Inv.SetupShop(5);
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

        if (NPC.downedSlimeKing)
        {
            AddItem(ItemID.EyePatch, Utils.UniversalVanityCost);
            AddItem(ItemID.PlatinumCrown, Utils.UniversalVanityCost);
        }

        if (NPC.downedBoss1)
        { // eye
            AddItem(ItemID.Sunglasses, Utils.UniversalVanityCost);
        }

        if (NPC.downedBoss2)
        { //worm / brain
            AddItem(ItemID.GuyFawkesMask, Utils.UniversalVanityCost);
        }

        if (NPC.downedBoss3)
        { // skeletron
            AddItem(ItemID.ReindeerAntlers, Utils.UniversalVanityCost);
        }

        if (Main.hardMode)
        {
            AddItem(ItemID.ReaperRobe, Utils.UniversalVanityCost);
            AddItem(ItemID.ReaperHood, Utils.UniversalVanityCost);
        }

        if (NPC.downedMechBossAny)
        {
            AddItem(ItemID.SpaceCreaturePants, Utils.UniversalVanityCost);
            AddItem(ItemID.SpaceCreatureShirt, Utils.UniversalVanityCost);
            AddItem(ItemID.SpaceCreatureMask, Utils.UniversalVanityCost);
            AddItem(ItemID.SkiphsPants, Utils.UniversalVanityCost);
            AddItem(ItemID.SkiphsShirt, Utils.UniversalVanityCost);
            AddItem(ItemID.SkiphsHelm, Utils.UniversalVanityCost);
            AddItem(ItemID.WillsLeggings, Utils.UniversalVanityCost);
            AddItem(ItemID.WillsBreastplate, Utils.UniversalVanityCost);
            AddItem(ItemID.WillsHelmet, Utils.UniversalVanityCost);
            AddItem(ItemID.AaronsLeggings, Utils.UniversalVanityCost);
            AddItem(ItemID.AaronsBreastplate, Utils.UniversalVanityCost);
            AddItem(ItemID.AaronsHelmet, Utils.UniversalVanityCost);
            AddItem(ItemID.BejeweledValkyrieBody, Utils.UniversalVanityCost);
            AddItem(ItemID.BejeweledValkyrieHead, Utils.UniversalVanityCost);
        }

        if (NPC.downedPlantBoss)
        {
            AddItem(ItemID.BunnyHood, Utils.UniversalVanityCost);
        }

        if (Main.raining)
        {
            AddItem(ItemID.CrownosLeggings, Utils.UniversalVanityCost);
            AddItem(ItemID.CrownosBreastplate, Utils.UniversalVanityCost);
            AddItem(ItemID.CrownosMask, Utils.UniversalVanityCost);
        }

        if (Main.bloodMoon)
        {
            AddItem(ItemID.CenxsDressPants, Utils.UniversalVanityCost);
            AddItem(ItemID.CenxsLeggings, Utils.UniversalVanityCost);
            AddItem(ItemID.CenxsDress, Utils.UniversalVanityCost);
            AddItem(ItemID.CenxsBreastplate, Utils.UniversalVanityCost);
            AddItem(ItemID.CenxsTiara, Utils.UniversalVanityCost);
        }

        if (Main.eclipse)
        {
            AddItem(ItemID.JimsLeggings, Utils.UniversalVanityCost);
            AddItem(ItemID.JimsBreastplate, Utils.UniversalVanityCost);
            AddItem(ItemID.JimsHelmet, Utils.UniversalVanityCost);
        }

        if (Main.dayTime)
        {
            AddItem(ItemID.ArkhalisPants, Utils.UniversalVanityCost);
            AddItem(ItemID.ArkhalisShirt, Utils.UniversalVanityCost);
            AddItem(ItemID.ArkhalisHat, Utils.UniversalVanityCost);
            AddItem(ItemID.Yoraiz0rPants, Utils.UniversalVanityCost);
            AddItem(ItemID.Yoraiz0rShirt, Utils.UniversalVanityCost);
            AddItem(ItemID.Yoraiz0rHead, Utils.UniversalVanityCost);
            AddItem(ItemID.Yoraiz0rDarkness, Utils.UniversalVanityCost);
        }
        else
        {
            AddItem(ItemID.LokisPants, Utils.UniversalVanityCost);
            AddItem(ItemID.LokisShirt, Utils.UniversalVanityCost);
            AddItem(ItemID.LokisHelm, Utils.UniversalVanityCost);
        }

        if (Main.hardMode)
        {
            AddItem(ItemID.LeinforsPants, Utils.UniversalVanityCost);
            AddItem(ItemID.LeinforsShirt, Utils.UniversalVanityCost);
            AddItem(ItemID.LeinforsHat, Utils.UniversalVanityCost);
            AddItem(ItemID.LeinforsAccessory, Utils.UniversalVanityCost);
        }

        if (NPC.downedAncientCultist)
        {
            AddItem(ItemID.Yoraiz0rWings, Utils.Coins(0, 0, 0, 2));
        }
    }

    private void VanityI()
    {
        AddItem(ItemID.BrideofFrankensteinDress, Utils.UniversalVanityCost);

        AddItem(ItemID.BrideofFrankensteinMask, Utils.UniversalVanityCost);

        AddItem(ItemID.CatMask, Utils.UniversalVanityCost);

        AddItem(ItemID.CatShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.CatPants, Utils.UniversalVanityCost);

        AddItem(ItemID.RedHat, Utils.UniversalVanityCost);

        AddItem(ItemID.ClothierJacket, Utils.UniversalVanityCost);

        AddItem(ItemID.ClothierPants, Utils.UniversalVanityCost);

        AddItem(ItemID.CyborgHelmet, Utils.UniversalVanityCost);

        AddItem(ItemID.CyborgShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.CyborgPants, Utils.UniversalVanityCost);

        AddItem(ItemID.DryadCoverings, Utils.UniversalVanityCost);

        AddItem(ItemID.Dryadisque, Utils.UniversalVanityCost);

        AddItem(ItemID.DryadLoincloth, Utils.UniversalVanityCost);

        AddItem(ItemID.CreeperMask, Utils.UniversalVanityCost);

        AddItem(ItemID.CreeperShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.CreeperPants, Utils.UniversalVanityCost);

        AddItem(ItemID.DyeTraderTurban, Utils.UniversalVanityCost);

        AddItem(ItemID.DyeTraderRobe, Utils.UniversalVanityCost);

        AddItem(ItemID.FoxMask, Utils.UniversalVanityCost);

        AddItem(ItemID.FoxShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.FoxPants, Utils.UniversalVanityCost);

        AddItem(ItemID.GhostMask, Utils.UniversalVanityCost);

        AddItem(ItemID.GhostShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.KarateTortoiseMask, Utils.UniversalVanityCost);

        AddItem(ItemID.KarateTortoiseShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.KarateTortoisePants, Utils.UniversalVanityCost);

        AddItem(ItemID.LeprechaunHat, Utils.UniversalVanityCost);

        AddItem(ItemID.LeprechaunShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.LeprechaunPants, Utils.UniversalVanityCost);

        AddItem(ItemID.NurseHat, Utils.UniversalVanityCost);

        AddItem(ItemID.NurseShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.NursePants, Utils.UniversalVanityCost);

        AddItem(ItemID.PixieShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.PixiePants, Utils.UniversalVanityCost);

        AddItem(ItemID.PrincessHat, Utils.UniversalVanityCost);

        AddItem(ItemID.PrincessDress, Utils.UniversalVanityCost);

        AddItem(ItemID.PumpkinHelmet, Utils.UniversalVanityCost);

        AddItem(ItemID.PumpkinShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.PumpkinPants, Utils.UniversalVanityCost);
    }

    private void VanityII()
    {
        AddItem(ItemID.ReaperHood, Utils.UniversalVanityCost);

        AddItem(ItemID.ReaperRobe, Utils.UniversalVanityCost);

        AddItem(ItemID.RobotMask, Utils.UniversalVanityCost);

        AddItem(ItemID.RobotShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.RobotPants, Utils.UniversalVanityCost);

        AddItem(ItemID.SpaceCreatureMask, Utils.UniversalVanityCost);

        AddItem(ItemID.SpaceCreatureShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.SpaceCreaturePants, Utils.UniversalVanityCost);

        AddItem(ItemID.TreasureHunterShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.TreasureHunterPants, Utils.UniversalVanityCost);

        AddItem(ItemID.UnicornMask, Utils.UniversalVanityCost);

        AddItem(ItemID.UnicornShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.UnicornPants, Utils.UniversalVanityCost);

        AddItem(ItemID.VampireMask, Utils.UniversalVanityCost);

        AddItem(ItemID.VampireShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.VampirePants, Utils.UniversalVanityCost);

        AddItem(ItemID.WitchHat, Utils.UniversalVanityCost);

        AddItem(ItemID.WitchDress, Utils.UniversalVanityCost);

        AddItem(ItemID.WitchBoots, Utils.UniversalVanityCost);

        AddItem(ItemID.MrsClauseHat, Utils.UniversalVanityCost);

        AddItem(ItemID.MrsClauseShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.MrsClauseHeels, Utils.UniversalVanityCost);

        AddItem(ItemID.SantaHat, Utils.UniversalVanityCost);

        AddItem(ItemID.SantaShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.SantaPants, Utils.UniversalVanityCost);

        AddItem(ItemID.ParkaHood, Utils.UniversalVanityCost);

        AddItem(ItemID.ParkaCoat, Utils.UniversalVanityCost);

        AddItem(ItemID.ParkaPants, Utils.UniversalVanityCost);

        AddItem(ItemID.TreeMask, Utils.UniversalVanityCost);

        AddItem(ItemID.TreeShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.TreeTrunks, Utils.UniversalVanityCost);

        AddItem(ItemID.AncientArmorHat, Utils.UniversalVanityCost);

        AddItem(ItemID.AncientArmorPants, Utils.UniversalVanityCost);

        AddItem(ItemID.AncientArmorShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.ArchaeologistsHat, Utils.UniversalVanityCost);

        AddItem(ItemID.ArchaeologistsJacket, Utils.UniversalVanityCost);

        AddItem(ItemID.ArchaeologistsPants, Utils.UniversalVanityCost);

        AddItem(ItemID.BeeHat, Utils.UniversalVanityCost);

        AddItem(ItemID.BeeShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.BeePants, Utils.UniversalVanityCost);
    }

    private void VanityIII()
    {
        AddItem(ItemID.BuccaneerBandana, Utils.UniversalVanityCost);

        AddItem(ItemID.BuccaneerShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.BuccaneerPants, Utils.UniversalVanityCost);

        AddItem(ItemID.ClownHat, Utils.UniversalVanityCost);

        AddItem(ItemID.ClownShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.ClownPants, Utils.UniversalVanityCost);

        AddItem(ItemID.CowboyHat, Utils.UniversalVanityCost);

        AddItem(ItemID.CowboyJacket, Utils.UniversalVanityCost);

        AddItem(ItemID.CowboyPants, Utils.UniversalVanityCost);

        AddItem(ItemID.ElfHat, Utils.UniversalVanityCost);

        AddItem(ItemID.ElfShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.ElfPants, Utils.UniversalVanityCost);

        AddItem(ItemID.FallenTuxedoShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.FallenTuxedoPants, Utils.UniversalVanityCost);

        AddItem(ItemID.FamiliarWig, Utils.UniversalVanityCost);

        AddItem(ItemID.FamiliarShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.FamiliarPants, Utils.UniversalVanityCost);

        AddItem(ItemID.FishCostumeMask, Utils.UniversalVanityCost);

        AddItem(ItemID.FishCostumeShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.FishCostumeFinskirt, Utils.UniversalVanityCost);

        AddItem(ItemID.HerosHat, Utils.UniversalVanityCost);

        AddItem(ItemID.HerosShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.HerosPants, Utils.UniversalVanityCost);

        AddItem(ItemID.LamiaHat, Utils.UniversalVanityCost);

        AddItem(ItemID.LamiaShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.LamiaPants, Utils.UniversalVanityCost);

        AddItem(ItemID.BlueLunaticHood, Utils.UniversalVanityCost);

        AddItem(ItemID.BlueLunaticRobe, Utils.UniversalVanityCost);

        AddItem(ItemID.WhiteLunaticHood, Utils.UniversalVanityCost);

        AddItem(ItemID.WhiteLunaticRobe, Utils.UniversalVanityCost);

        AddItem(ItemID.MartianCostumeMask, Utils.UniversalVanityCost);

        AddItem(ItemID.MartianCostumeShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.MartianCostumePants, Utils.UniversalVanityCost);

        AddItem(ItemID.MartianUniformHelmet, Utils.UniversalVanityCost);

        AddItem(ItemID.MartianUniformTorso, Utils.UniversalVanityCost);

        AddItem(ItemID.MartianUniformPants, Utils.UniversalVanityCost);

        AddItem(ItemID.MermaidAdornment, Utils.UniversalVanityCost);

        AddItem(ItemID.MermaidTail, Utils.UniversalVanityCost);

        AddItem(ItemID.MummyMask, Utils.UniversalVanityCost);

        AddItem(ItemID.MummyShirt, Utils.UniversalVanityCost);
    }

    private void VanityIV()
    {
        AddItem(ItemID.MummyPants, Utils.UniversalVanityCost);

        AddItem(ItemID.PedguinHat, Utils.UniversalVanityCost);

        AddItem(ItemID.PedguinShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.PedguinPants, Utils.UniversalVanityCost);

        AddItem(ItemID.PharaohsMask, Utils.UniversalVanityCost);

        AddItem(ItemID.PharaohsRobe, Utils.UniversalVanityCost);

        AddItem(ItemID.PirateHat, Utils.UniversalVanityCost);

        AddItem(ItemID.PirateShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.PiratePants, Utils.UniversalVanityCost);

        AddItem(ItemID.PlumbersHat, Utils.UniversalVanityCost);

        AddItem(ItemID.PlumbersShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.PlumbersPants, Utils.UniversalVanityCost);

        AddItem(ItemID.PrincessHat, Utils.UniversalVanityCost);

        AddItem(ItemID.PrincessDress, Utils.UniversalVanityCost);

        AddItem(ItemID.PrincessDressNew, Utils.UniversalVanityCost);

        AddItem(ItemID.RainHat, Utils.UniversalVanityCost);

        AddItem(ItemID.RainCoat, Utils.UniversalVanityCost);

        AddItem(ItemID.RuneHat, Utils.UniversalVanityCost);

        AddItem(ItemID.RuneRobe, Utils.UniversalVanityCost);

        AddItem(ItemID.SailorHat, Utils.UniversalVanityCost);

        AddItem(ItemID.SailorShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.SailorPants, Utils.UniversalVanityCost);

        AddItem(ItemID.ScarecrowHat, Utils.UniversalVanityCost);

        AddItem(ItemID.ScarecrowShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.ScarecrowPants, Utils.UniversalVanityCost);

        AddItem(ItemID.SteampunkHat, Utils.UniversalVanityCost);

        AddItem(ItemID.SteampunkShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.SteampunkPants, Utils.UniversalVanityCost);

        AddItem(ItemID.TaxCollectorHat, Utils.UniversalVanityCost);

        AddItem(ItemID.TaxCollectorSuit, Utils.UniversalVanityCost);

        AddItem(ItemID.TaxCollectorPants, Utils.UniversalVanityCost);

        AddItem(ItemID.TheDoctorsShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.TheDoctorsPants, Utils.UniversalVanityCost);

        AddItem(ItemID.TuxedoShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.TuxedoPants, Utils.UniversalVanityCost);

        AddItem(ItemID.TheBrideHat, Utils.UniversalVanityCost);

        AddItem(ItemID.TheBrideDress, Utils.UniversalVanityCost);

        AddItem(ItemID.WhiteTuxedoShirt, Utils.UniversalVanityCost);

        AddItem(ItemID.WhiteTuxedoPants, Utils.UniversalVanityCost);
    }

    private void BossMasks()
    {
        AddItem(ItemID.BrainMask, Utils.UniversalVanityCost);
        AddItem(ItemID.DukeFishronMask, Utils.UniversalVanityCost);
        AddItem(ItemID.EyeMask, Utils.UniversalVanityCost);
        AddItem(ItemID.KingSlimeMask, Utils.UniversalVanityCost);
        AddItem(ItemID.BeeMask, Utils.UniversalVanityCost);
        AddItem(ItemID.SkeletronPrimeMask, Utils.UniversalVanityCost);
        AddItem(ItemID.FleshMask, Utils.UniversalVanityCost);
        AddItem(ItemID.BossMaskCultist, Utils.UniversalVanityCost);
        AddItem(ItemID.BossMaskBetsy, Utils.UniversalVanityCost);
        AddItem(ItemID.BossMaskOgre, Utils.UniversalVanityCost);
        AddItem(ItemID.DestroyerMask, Utils.UniversalVanityCost);
        AddItem(ItemID.EaterMask, Utils.UniversalVanityCost);
        AddItem(ItemID.GolemMask, Utils.UniversalVanityCost);
        AddItem(ItemID.PlanteraMask, Utils.UniversalVanityCost);
        AddItem(ItemID.SkeletronMask, Utils.UniversalVanityCost);
        AddItem(ItemID.TwinMask, Utils.UniversalVanityCost);
        AddItem(ItemID.BossMaskDarkMage, Utils.UniversalVanityCost);
        AddItem(ItemID.BossMaskMoonlord, Utils.UniversalVanityCost);
    }
}