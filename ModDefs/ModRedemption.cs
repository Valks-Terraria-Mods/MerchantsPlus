using Redemption.Items.Usable.Summons;

namespace MerchantsPlus.ModDefs;

[JITWhenModsEnabled("Redemption")]
public class ModRedemption
{
    public class Items
    {
        // Pre-Hardmode Summons
        public static int HeartOfThorns => ModContent.ItemType<HeartOfThorns>();         // Thorn, Bane of the Forest
        public static int ForbiddenRitual => ModContent.ItemType<DemonScroll>();         // Erhan, Anglonic High Priest
        public static int WeddingRing => ModContent.ItemType<WeddingRing>();             // The Keeper
        public static int AnomalyDetector => ModContent.ItemType<AnomalyDetector>();     // Seed of Infection

        // Hardmode Summons
        public static int CyberRadio => ModContent.ItemType<CyberTech>();                // King Slayer III
        public static int OmegaTransmitter => ModContent.ItemType<OmegaTransmitter>();   // Omega Cleaver / Omega Gigapora / Omega Obliterator

        // Post-Moon Lord Summons
        public static int HologramRemote => ModContent.ItemType<LabHologramDevice>();    // Patient Zero
        public static int AncientSigil => ModContent.ItemType<AncientSigil>();           // Ancient Deity Duo
        public static int GalaxyStone => ModContent.ItemType<NebSummon>();               // Nebuleus, Angel of the Cosmos

        // Mini Boss Summons
        public static int EggCrown => ModContent.ItemType<EggCrown>();                   // Fowl Emperor
        public static int EaglecrestSpelltome => ModContent.ItemType<EaglecrestSpelltome>(); // Eaglecrest Golem
    }

    public class Bosses
    {
        // Pre-Hardmode
        public static bool ThornsDowned => Redemption.Globals.RedeConditions.DownedThorn.IsMet();
        public static bool ErhanDowned => Redemption.Globals.RedeConditions.DownedErhan.IsMet();
        public static bool KeeperDowned => Redemption.Globals.RedeConditions.DownedKeeper.IsMet();
        public static bool SeedOfInfectionDowned => Redemption.Globals.RedeConditions.DownedSeed.IsMet();

        // Hardmode
        public static bool KingSlayerIIIDowned => Redemption.Globals.RedeConditions.DownedSlayer.IsMet();
        public static bool OmegaObliteratorDowned => Redemption.Globals.RedeConditions.DownedOmega1.IsMet();

        // Post-Moon Lord
        public static bool PatientZeroDowned => Redemption.Globals.RedeConditions.DownedOmega2.IsMet();
        public static bool AncientDeityDowned => Redemption.Globals.RedeConditions.DownedOmega3.IsMet();
        public static bool NebuleusDowned => Redemption.Globals.RedeConditions.DownedNebuleus.IsMet();

        // Mini Bosses
        public static bool FowlEmperorDowned => Redemption.Globals.RedeConditions.DownedFowlEmperor.IsMet();
        public static bool EaglecrestGolemDowned => Redemption.Globals.RedeConditions.DownedEaglecrestGolem.IsMet();
    }
}
