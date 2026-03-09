using MerchantsPlus.ModDefs;

namespace MerchantsPlus.Shops;

public partial class ShopGuide
{
    private void RedemptionBosses()
    {
        bool unlockAllItems = Config.Instance?.UnlockAllItems == true;

        if (unlockAllItems)
        {
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionHeartOfThorns);
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionForbiddenRitual);
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionWeddingRing);
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionAnomalyDetector);
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionCyberRadio);
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionOmegaTransmitter);
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionHologramRemote);
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionAncientSigil);
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionGalaxyStone);
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionEggCrown);
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionEaglecrestSpelltome);
            return;
        }

        // Pre-Hardmode
        AddCrossModBossSummon(ShopGuideCatalog.RedemptionHeartOfThorns);
        if (ModRedemption.Bosses.ThornsDowned)
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionForbiddenRitual);
        if (ModRedemption.Bosses.ErhanDowned)
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionWeddingRing);
        if (ModRedemption.Bosses.KeeperDowned)
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionAnomalyDetector);

        // Hardmode
        if (ModRedemption.Bosses.SeedOfInfectionDowned)
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionCyberRadio);
        if (ModRedemption.Bosses.KingSlayerIIIDowned)
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionOmegaTransmitter);

        // Post-Moon Lord
        if (ModRedemption.Bosses.OmegaObliteratorDowned)
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionHologramRemote);
        if (ModRedemption.Bosses.PatientZeroDowned)
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionAncientSigil);
        if (ModRedemption.Bosses.AncientDeityDowned)
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionGalaxyStone);

        // Mini Bosses (optional)
        if (!ModRedemption.Bosses.FowlEmperorDowned)
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionEggCrown);
        if (ModRedemption.Bosses.EaglecrestGolemDowned)
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionEaglecrestSpelltome);
    }
}
