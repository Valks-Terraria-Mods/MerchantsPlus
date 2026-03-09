using MerchantsPlus.Utils;

namespace MerchantsPlus.ModDefs;

public static class ModCalamity
{
    private const string ModName = "CalamityMod";
    private const string DownedBossSystemType = "CalamityMod.DownedBossSystem";

    private static int Item(string itemName) => OtherMods.TryFindItemType(ModName, itemName);
    private static bool Downed(string fieldName) => OtherMods.TryGetStaticBoolField(ModName, DownedBossSystemType, fieldName);

    public static class Items
    {
        public static int DesertMedallion => Item("DesertMedallion");
        public static int DecapoditaSprout => Item("DecapoditaSprout");
        public static int Teratoma => Item("Teratoma");
        public static int BloodyWormFood => Item("BloodyWormFood");
        public static int OverloadedSludge => Item("OverloadedSludge");
        public static int CryoKey => Item("CryoKey");
        public static int Seafood => Item("Seafood");
        public static int CharredIdol => Item("CharredIdol");
        public static int EyeofDesolation => Item("EyeofDesolation");
        public static int AstralChunk => Item("AstralChunk");
        public static int Abombination => Item("Abombination");
        public static int DeathWhistle => Item("DeathWhistle");
        public static int TitanHeart => Item("TitanHeart");
        public static int ProfanedShard => Item("ProfanedShard");
        public static int ExoticPheromones => Item("ExoticPheromones");
        public static int ProfanedCore => Item("ProfanedCore");
        public static int MarkofProvidence => Item("MarkofProvidence");
        public static int Bloodworm => Item("BloodwormItem");
        public static int CosmicWorm => Item("CosmicWorm");
        public static int BlessedPhoenixEgg => Item("YharonEgg");
        public static int AshesOfCalamity => Item("AshesofCalamity");
    }

    public static class Bosses
    {
        public static bool DesertScourgeDowned => Downed("downedDesertScourge");
        public static bool CrabulonDowned => Downed("downedCrabulon");
        public static bool TheHiveMindDowned => Downed("downedHiveMind");
        public static bool PerforatorDowned => Downed("downedPerforator");
        public static bool SlimeGodDowned => Downed("downedSlimeGod");
        public static bool CryogenDowned => Downed("downedCryogen");
        public static bool AquaticScourgeDowned => Downed("downedAquaticScourge");
        public static bool BrimstoneElementalDowned => Downed("downedBrimstoneElemental");
        public static bool CalamitasDowned => Downed("downedCalamitas");
        public static bool AstrumAureusDowned => Downed("downedAstrumAureus");
        public static bool PlaguebringeDowned => Downed("downedPlaguebringer");
        public static bool RavagerDowned => Downed("downedRavager");
        public static bool AstrumDeusDowned => Downed("downedAstrumDeus");
        public static bool ProfanedGuardiansDowned => Downed("downedGuardians");
        public static bool DragonfollyDowned => Downed("downedDragonfolly");
        public static bool ProvidenceDowned => Downed("downedProvidence");
        public static bool StormWeaverDowned => Downed("downedStormWeaver");
        public static bool CeaselessVoidDowned => Downed("downedCeaselessVoid");
        public static bool SignusDowned => Downed("downedSignus");
        public static bool OldDukeDowned => Downed("downedBoomerDuke");
        public static bool DevourerOfGodsDowned => Downed("downedDoG");
        public static bool YharonDowned => Downed("downedYharon");
        public static bool SupremeWitchCalamitasDowned => Downed("downedCalamitasClone");
    }
}

