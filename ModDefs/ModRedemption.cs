using MerchantsPlus.Utils;

namespace MerchantsPlus.ModDefs;

public static class ModRedemption
{
    private const string ModName = "Redemption";
    private const string ConditionsType = "Redemption.Globals.RedeConditions";

    private static int Item(string itemName) => OtherMods.TryFindItemType(ModName, itemName);
    private static bool Condition(string conditionName) => OtherMods.TryInvokeBoolMember(ModName, ConditionsType, conditionName, "IsMet");

    public static class Items
    {
        public static int HeartOfThorns => Item("HeartOfThorns");
        public static int ForbiddenRitual => Item("DemonScroll");
        public static int WeddingRing => Item("WeddingRing");
        public static int AnomalyDetector => Item("AnomalyDetector");
        public static int CyberRadio => Item("CyberTech");
        public static int OmegaTransmitter => Item("OmegaTransmitter");
        public static int HologramRemote => Item("LabHologramDevice");
        public static int AncientSigil => Item("AncientSigil");
        public static int GalaxyStone => Item("NebSummon");
        public static int EggCrown => Item("EggCrown");
        public static int EaglecrestSpelltome => Item("EaglecrestSpelltome");
    }

    public static class Bosses
    {
        public static bool ThornsDowned => Condition("DownedThorn");
        public static bool ErhanDowned => Condition("DownedErhan");
        public static bool KeeperDowned => Condition("DownedKeeper");
        public static bool SeedOfInfectionDowned => Condition("DownedSeed");
        public static bool KingSlayerIIIDowned => Condition("DownedSlayer");
        public static bool OmegaObliteratorDowned => Condition("DownedOmega1");
        public static bool PatientZeroDowned => Condition("DownedOmega2");
        public static bool AncientDeityDowned => Condition("DownedOmega3");
        public static bool NebuleusDowned => Condition("DownedNebuleus");
        public static bool FowlEmperorDowned => Condition("DownedFowlEmperor");
        public static bool EaglecrestGolemDowned => Condition("DownedEaglecrestGolem");
    }
}

