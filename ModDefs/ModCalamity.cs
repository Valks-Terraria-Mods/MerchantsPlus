using CalamityMod;
using CalamityMod.Items.Materials;
using CalamityMod.Items.SummonItems;

namespace MerchantsPlus.ModDefs;

[JITWhenModsEnabled("CalamityMod")]
public class ModCalamity
{
    public class Items
    {
        public static int DesertMedallion => ModContent.ItemType<DesertMedallion>(); // Desert Scrouge
        public static int DecapoditaSprout => ModContent.ItemType<DecapoditaSprout>(); // Crabulon
        public static int Teratoma => ModContent.ItemType<Teratoma>(); // The Hive Mind
        public static int BloodyWormFood => ModContent.ItemType<BloodyWormFood>(); // The Perforators
        public static int OverloadedSludge => ModContent.ItemType<OverloadedSludge>(); // The Slime God

        // Hardmode
        public static int CryoKey => ModContent.ItemType<CryoKey>(); // Cryogen
        public static int Seafood => ModContent.ItemType<Seafood>(); // Aquatic Scourge
        public static int CharredIdol => ModContent.ItemType<CharredIdol>(); // Brimstone Elemental
        public static int EyeofDesolation => ModContent.ItemType<EyeofDesolation>(); // Calamitas Clone
        public static int AstralChunk => ModContent.ItemType<AstralChunk>(); // Astrum Aureus
        public static int Abombination => ModContent.ItemType<Abombination>(); // The Plaguebringer Goliath
        public static int DeathWhistle => ModContent.ItemType<DeathWhistle>(); // Ravager
        public static int TitanHeart => ModContent.ItemType<TitanHeart>(); // Astrum Deus

        // Post-Moon Lord
        public static int ProfanedShard => ModContent.ItemType<ProfanedShard>(); // Profaned Guardians
        public static int ExoticPheromones => ModContent.ItemType<ExoticPheromones>(); // Dragonfolly
        public static int ProfanedCore => ModContent.ItemType<ProfanedCore>(); // Providence, the Profaned Goddess
        public static int MarkofProvidence => ModContent.ItemType<MarkofProvidence>(); // Storm Weaver, CeaselessVoid and Signus
        public static int Bloodworm => ModContent.ItemType<BloodwormItem>(); // The Old Duke
        public static int CosmicWorm => ModContent.ItemType<CosmicWorm>(); // The Devourer of Gods
        public static int BlessedPhoenixEgg => ModContent.ItemType<YharonEgg>(); // Yharon, Dragon of Rebirth
        public static int AshesOfCalamity => ModContent.ItemType<AshesofCalamity>(); // Supreme Witch, Calamitas
    }

    public class Bosses
    {
        public static bool DesertScourgeDowned => DownedBossSystem.downedDesertScourge;
        public static bool CrabulonDowned => DownedBossSystem.downedCrabulon;
        public static bool TheHiveMindDowned => DownedBossSystem.downedHiveMind;
        public static bool PerforatorDowned => DownedBossSystem.downedPerforator;
        public static bool SlimeGodDowned => DownedBossSystem.downedSlimeGod;

        // Hardmode
        public static bool CryogenDowned => DownedBossSystem.downedCryogen;
        public static bool AquaticScourgeDowned => DownedBossSystem.downedAquaticScourge;
        public static bool BrimstoneElementalDowned => DownedBossSystem.downedBrimstoneElemental;
        public static bool CalamitasDowned => DownedBossSystem.downedCalamitas;
        public static bool AstrumAureusDowned => DownedBossSystem.downedAstrumAureus;
        public static bool PlaguebringeDowned => DownedBossSystem.downedPlaguebringer;
        public static bool RavagerDowned => DownedBossSystem.downedRavager;
        public static bool AstrumDeusDowned => DownedBossSystem.downedAstrumDeus;

        // Post-Moon Lord
        public static bool ProfanedGuardiansDowned => DownedBossSystem.downedGuardians;
        public static bool DragonfollyDowned => DownedBossSystem.downedDragonfolly;
        public static bool ProvidenceDowned => DownedBossSystem.downedProvidence;
        public static bool StormWeaverDowned => DownedBossSystem.downedStormWeaver;
        public static bool CeaselessVoidDowned => DownedBossSystem.downedCeaselessVoid;
        public static bool SignusDowned => DownedBossSystem.downedSignus;
        public static bool OldDukeDowned => DownedBossSystem.downedBoomerDuke;
        public static bool DevourerOfGodsDowned => DownedBossSystem.downedDoG;
        public static bool YharonDowned => DownedBossSystem.downedYharon;
        public static bool SupremeWitchCalamitasDowned => DownedBossSystem.downedCalamitasClone;
    }
}
