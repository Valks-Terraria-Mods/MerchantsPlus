using MerchantsPlus.Utils;

namespace MerchantsPlus.ModDefs;

public static class ModCalamity
{
    private const string ModName = "CalamityMod";
    private const string DownedBossSystemType = "CalamityMod.DownedBossSystem";

    public static class Items
    {
        public static int DesertMedallion => OtherMods.TryFindItemType(ModName, "DesertMedallion");
        public static int DecapoditaSprout => OtherMods.TryFindItemType(ModName, "DecapoditaSprout");
        public static int Teratoma => OtherMods.TryFindItemType(ModName, "Teratoma");
        public static int BloodyWormFood => OtherMods.TryFindItemType(ModName, "BloodyWormFood");
        public static int OverloadedSludge => OtherMods.TryFindItemType(ModName, "OverloadedSludge");
        public static int CryoKey => OtherMods.TryFindItemType(ModName, "CryoKey");
        public static int Seafood => OtherMods.TryFindItemType(ModName, "Seafood");
        public static int CharredIdol => OtherMods.TryFindItemType(ModName, "CharredIdol");
        public static int EyeofDesolation => OtherMods.TryFindItemType(ModName, "EyeofDesolation");
        public static int AstralChunk => OtherMods.TryFindItemType(ModName, "AstralChunk");
        public static int Abombination => OtherMods.TryFindItemType(ModName, "Abombination");
        public static int DeathWhistle => OtherMods.TryFindItemType(ModName, "DeathWhistle");
        public static int TitanHeart => OtherMods.TryFindItemType(ModName, "TitanHeart");
        public static int ProfanedShard => OtherMods.TryFindItemType(ModName, "ProfanedShard");
        public static int ExoticPheromones => OtherMods.TryFindItemType(ModName, "ExoticPheromones");
        public static int ProfanedCore => OtherMods.TryFindItemType(ModName, "ProfanedCore");
        public static int MarkofProvidence => OtherMods.TryFindItemType(ModName, "MarkofProvidence");
        public static int Bloodworm => OtherMods.TryFindItemType(ModName, "BloodwormItem");
        public static int CosmicWorm => OtherMods.TryFindItemType(ModName, "CosmicWorm");
        public static int BlessedPhoenixEgg => OtherMods.TryFindItemType(ModName, "YharonEgg");
        public static int AshesOfCalamity => OtherMods.TryFindItemType(ModName, "AshesofCalamity");
    }

    public static class Bosses
    {
        public static bool DesertScourgeDowned => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, "downedDesertScourge");
        public static bool CrabulonDowned => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, "downedCrabulon");
        public static bool TheHiveMindDowned => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, "downedHiveMind");
        public static bool PerforatorDowned => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, "downedPerforator");
        public static bool SlimeGodDowned => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, "downedSlimeGod");
        public static bool CryogenDowned => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, "downedCryogen");
        public static bool AquaticScourgeDowned => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, "downedAquaticScourge");
        public static bool BrimstoneElementalDowned => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, "downedBrimstoneElemental");
        public static bool CalamitasDowned => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, "downedCalamitas");
        public static bool AstrumAureusDowned => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, "downedAstrumAureus");
        public static bool PlaguebringeDowned => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, "downedPlaguebringer");
        public static bool RavagerDowned => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, "downedRavager");
        public static bool AstrumDeusDowned => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, "downedAstrumDeus");
        public static bool ProfanedGuardiansDowned => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, "downedGuardians");
        public static bool DragonfollyDowned => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, "downedDragonfolly");
        public static bool ProvidenceDowned => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, "downedProvidence");
        public static bool StormWeaverDowned => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, "downedStormWeaver");
        public static bool CeaselessVoidDowned => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, "downedCeaselessVoid");
        public static bool SignusDowned => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, "downedSignus");
        public static bool OldDukeDowned => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, "downedBoomerDuke");
        public static bool DevourerOfGodsDowned => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, "downedDoG");
        public static bool YharonDowned => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, "downedYharon");
        public static bool SupremeWitchCalamitasDowned => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, "downedCalamitasClone");
    }
}
