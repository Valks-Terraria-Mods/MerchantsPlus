using MerchantsPlus.Utils;

namespace MerchantsPlus.ModDefs;

public static class ModRedemption
{
    private const string ModName = "Redemption";
    private const string ConditionsType = "Redemption.Globals.RedeConditions";

    public static class Items
    {
        public static int HeartOfThorns => OtherMods.TryFindItemType(ModName, "HeartOfThorns");
        public static int ForbiddenRitual => OtherMods.TryFindItemType(ModName, "DemonScroll");
        public static int WeddingRing => OtherMods.TryFindItemType(ModName, "WeddingRing");
        public static int AnomalyDetector => OtherMods.TryFindItemType(ModName, "AnomalyDetector");
        public static int CyberRadio => OtherMods.TryFindItemType(ModName, "CyberTech");
        public static int OmegaTransmitter => OtherMods.TryFindItemType(ModName, "OmegaTransmitter");
        public static int HologramRemote => OtherMods.TryFindItemType(ModName, "LabHologramDevice");
        public static int AncientSigil => OtherMods.TryFindItemType(ModName, "AncientSigil");
        public static int GalaxyStone => OtherMods.TryFindItemType(ModName, "NebSummon");
        public static int EggCrown => OtherMods.TryFindItemType(ModName, "EggCrown");
        public static int EaglecrestSpelltome => OtherMods.TryFindItemType(ModName, "EaglecrestSpelltome");
    }

    public static class Bosses
    {
        public static bool ThornsDowned => OtherMods.TryInvokeBoolMember(ModName, ConditionsType, "DownedThorn", "IsMet");
        public static bool ErhanDowned => OtherMods.TryInvokeBoolMember(ModName, ConditionsType, "DownedErhan", "IsMet");
        public static bool KeeperDowned => OtherMods.TryInvokeBoolMember(ModName, ConditionsType, "DownedKeeper", "IsMet");
        public static bool SeedOfInfectionDowned => OtherMods.TryInvokeBoolMember(ModName, ConditionsType, "DownedSeed", "IsMet");
        public static bool KingSlayerIIIDowned => OtherMods.TryInvokeBoolMember(ModName, ConditionsType, "DownedSlayer", "IsMet");
        public static bool OmegaObliteratorDowned => OtherMods.TryInvokeBoolMember(ModName, ConditionsType, "DownedOmega1", "IsMet");
        public static bool PatientZeroDowned => OtherMods.TryInvokeBoolMember(ModName, ConditionsType, "DownedOmega2", "IsMet");
        public static bool AncientDeityDowned => OtherMods.TryInvokeBoolMember(ModName, ConditionsType, "DownedOmega3", "IsMet");
        public static bool NebuleusDowned => OtherMods.TryInvokeBoolMember(ModName, ConditionsType, "DownedNebuleus", "IsMet");
        public static bool FowlEmperorDowned => OtherMods.TryInvokeBoolMember(ModName, ConditionsType, "DownedFowlEmperor", "IsMet");
        public static bool EaglecrestGolemDowned => OtherMods.TryInvokeBoolMember(ModName, ConditionsType, "DownedEaglecrestGolem", "IsMet");
    }
}
