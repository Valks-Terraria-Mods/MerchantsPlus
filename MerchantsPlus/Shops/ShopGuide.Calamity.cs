using MerchantsPlus.ModDefs;

namespace MerchantsPlus.Shops;

public partial class ShopGuide
{
    private void CalamityBosses()
    {
        bool unlockAllItems = Config.Instance?.UnlockAllItems == true;

        if (unlockAllItems)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityDesertMedallion);
            AddCrossModBossSummon(ShopGuideCatalog.CalamityDecapoditaSprout);
            AddCrossModBossSummon(ShopGuideCatalog.CalamityBloodyWormFood);
            AddCrossModBossSummon(ShopGuideCatalog.CalamityTeratoma);
            AddCrossModBossSummon(ShopGuideCatalog.CalamityOverloadedSludge);
            AddCrossModBossSummon(ShopGuideCatalog.CalamityCryoKey);
            AddCrossModBossSummon(ShopGuideCatalog.CalamitySeafood);
            AddCrossModBossSummon(ShopGuideCatalog.CalamityCharredIdol);
            AddCrossModBossSummon(ShopGuideCatalog.CalamityEyeofDesolation);
            AddCrossModBossSummon(ShopGuideCatalog.CalamityAstralChunk);
            AddCrossModBossSummon(ShopGuideCatalog.CalamityAbombination);
            AddCrossModBossSummon(ShopGuideCatalog.CalamityDeathWhistle);
            AddCrossModBossSummon(ShopGuideCatalog.CalamityTitanHeart);
            AddCrossModBossSummon(ShopGuideCatalog.CalamityProfanedShard);
            AddCrossModBossSummon(ShopGuideCatalog.CalamityExoticPheromones);
            AddCrossModBossSummon(ShopGuideCatalog.CalamityProfanedCore);
            AddCrossModBossSummon(ShopGuideCatalog.CalamityMarkofProvidence);
            AddCrossModBossSummon(ShopGuideCatalog.CalamityBloodworm);
            AddCrossModBossSummon(ShopGuideCatalog.CalamityCosmicWorm);
            AddCrossModBossSummon(ShopGuideCatalog.CalamityBlessedPhoenixEgg);
            AddCrossModBossSummon(ShopGuideCatalog.CalamityAshesOfCalamity);
            return;
        }

        AddCrossModBossSummon(ShopGuideCatalog.CalamityDesertMedallion);

        if (ModCalamity.Bosses.DesertScourgeDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityDecapoditaSprout);
        }

        if (ModCalamity.Bosses.CrabulonDowned)
        {
            AddCrossModBossSummon(WorldGen.crimson ? ShopGuideCatalog.CalamityBloodyWormFood : ShopGuideCatalog.CalamityTeratoma);
        }

        if (ModCalamity.Bosses.PerforatorDowned || ModCalamity.Bosses.TheHiveMindDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityOverloadedSludge);
        }

        if (ModCalamity.Bosses.SlimeGodDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityCryoKey);
        }

        // Hardmode
        if (ModCalamity.Bosses.CryogenDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamitySeafood);
        }

        if (ModCalamity.Bosses.AquaticScourgeDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityCharredIdol);
        }

        if (ModCalamity.Bosses.BrimstoneElementalDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityEyeofDesolation); // Calamitas Clone Key
        }

        if (ModCalamity.Bosses.CalamitasDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityEyeofDesolation);
        }

        if (ModCalamity.Bosses.AstrumAureusDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityAstralChunk);
        }

        if (ModCalamity.Bosses.PlaguebringeDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityAbombination);
        }

        if (ModCalamity.Bosses.RavagerDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityDeathWhistle);
        }

        if (ModCalamity.Bosses.AstrumDeusDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityTitanHeart);
        }

        // Post-Moon Lord
        if (ModCalamity.Bosses.ProfanedGuardiansDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityProfanedShard);
        }

        if (ModCalamity.Bosses.DragonfollyDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityExoticPheromones);
        }

        if (ModCalamity.Bosses.ProvidenceDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityProfanedCore);
        }

        if (ModCalamity.Bosses.StormWeaverDowned || ModCalamity.Bosses.CeaselessVoidDowned || ModCalamity.Bosses.SignusDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityMarkofProvidence);
        }

        if (ModCalamity.Bosses.OldDukeDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityBloodworm);
        }

        if (ModCalamity.Bosses.DevourerOfGodsDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityCosmicWorm);
        }

        if (ModCalamity.Bosses.YharonDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityBlessedPhoenixEgg);
        }

        if (ModCalamity.Bosses.SupremeWitchCalamitasDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityAshesOfCalamity);
        }
    }
}
