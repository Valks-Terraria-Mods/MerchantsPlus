using MerchantsPlus.ModDefs;

namespace MerchantsPlus.Shops;

public static class ShopGuideCatalog
{
    public const string GearShopName = "Gear";
    public const string PylonsShopName = "Pylons";
    public const string VanillaShopName = "Vanilla";
    public const string CalamityShopName = "Calamity";
    public const string ThoriumShopName = "Thorium";
    public const string RedemptionShopName = "Redemption";

    public static readonly string[] ShopNames =
    [
        GearShopName,
        PylonsShopName,
        VanillaShopName,
    ];

    public static readonly int[] UtilityGear =
    [
        ItemID.MagicMirror,
        ItemID.CordageGuide,
    ];

    public static readonly int[] Pylons =
    [
        ItemID.TeleportationPylonVictory,
        ItemID.TeleportationPylonUnderground,
        ItemID.TeleportationPylonSnow,
        ItemID.TeleportationPylonPurity,
        ItemID.TeleportationPylonOcean,
        ItemID.TeleportationPylonMushroom,
        ItemID.TeleportationPylonJungle,
        ItemID.TeleportationPylonHallow,
        ItemID.TeleportationPylonDesert,
    ];

    public const int TorchItemId = ItemID.Torch;
    public const int GuideVoodooDollItemId = ItemID.GuideVoodooDoll;
    public const int ObsidianItemId = ItemID.Obsidian;
    public const int CannonItemId = ItemID.Cannon;
    public const int CannonballItemId = ItemID.Cannonball;
    public const int GelItemId = ItemID.Gel;
    public const int BedItemId = ItemID.Bed;
    public const int PumpkinItemId = ItemID.Pumpkin;
    public const int SlimeCrownItemId = ItemID.SlimeCrown;
    public const string ThoriumUnholyShardsName = nameof(ModThorium.Items.UnholyShards);
    public const string ThoriumAbyssalShadowName = nameof(ModThorium.Items.AbyssalShadow);

    public static int ThoriumGrandFlareGun => ModThorium.Items.GrandFlareGun;
    public static int ThoriumStormFlare => ModThorium.Items.StormFlare;
    public static int ThoriumUnholyShards => ModThorium.Items.UnholyShards;
    public static int ThoriumDoomSayersCoin => ModThorium.Items.DoomSayersCoin;

    public static int ThoriumJellyfishResonator => ModThorium.Items.JellyfishResonator;
    public static int ThoriumUnstableCore => ModThorium.Items.UnstableCore;
    public static int ThoriumAncientBlade => ModThorium.Items.AncientBlade;
    public static int ThoriumStarCaller => ModThorium.Items.StarCaller;
    public static int ThoriumStriderTear => ModThorium.Items.StriderTear;
    public static int ThoriumVoidLens => ModThorium.Items.VoidLens;
    public static int ThoriumAbyssalShadow => ModThorium.Items.AbyssalShadow;

    public static int CalamityDesertMedallion => ModCalamity.Items.DesertMedallion;
    public static int CalamityDecapoditaSprout => ModCalamity.Items.DecapoditaSprout;
    public static int CalamityBloodyWormFood => ModCalamity.Items.BloodyWormFood;
    public static int CalamityTeratoma => ModCalamity.Items.Teratoma;
    public static int CalamityOverloadedSludge => ModCalamity.Items.OverloadedSludge;
    public static int CalamityCryoKey => ModCalamity.Items.CryoKey;
    public static int CalamitySeafood => ModCalamity.Items.Seafood;
    public static int CalamityCharredIdol => ModCalamity.Items.CharredIdol;
    public static int CalamityEyeofDesolation => ModCalamity.Items.EyeofDesolation;
    public static int CalamityAstralChunk => ModCalamity.Items.AstralChunk;
    public static int CalamityAbombination => ModCalamity.Items.Abombination;
    public static int CalamityDeathWhistle => ModCalamity.Items.DeathWhistle;
    public static int CalamityTitanHeart => ModCalamity.Items.TitanHeart;
    public static int CalamityProfanedShard => ModCalamity.Items.ProfanedShard;
    public static int CalamityExoticPheromones => ModCalamity.Items.ExoticPheromones;
    public static int CalamityProfanedCore => ModCalamity.Items.ProfanedCore;
    public static int CalamityMarkofProvidence => ModCalamity.Items.MarkofProvidence;
    public static int CalamityBloodworm => ModCalamity.Items.Bloodworm;
    public static int CalamityCosmicWorm => ModCalamity.Items.CosmicWorm;
    public static int CalamityBlessedPhoenixEgg => ModCalamity.Items.BlessedPhoenixEgg;
    public static int CalamityAshesOfCalamity => ModCalamity.Items.AshesOfCalamity;

    public static int RedemptionHeartOfThorns => ModRedemption.Items.HeartOfThorns;
    public static int RedemptionForbiddenRitual => ModRedemption.Items.ForbiddenRitual;
    public static int RedemptionWeddingRing => ModRedemption.Items.WeddingRing;
    public static int RedemptionAnomalyDetector => ModRedemption.Items.AnomalyDetector;
    public static int RedemptionCyberRadio => ModRedemption.Items.CyberRadio;
    public static int RedemptionOmegaTransmitter => ModRedemption.Items.OmegaTransmitter;
    public static int RedemptionHologramRemote => ModRedemption.Items.HologramRemote;
    public static int RedemptionAncientSigil => ModRedemption.Items.AncientSigil;
    public static int RedemptionGalaxyStone => ModRedemption.Items.GalaxyStone;
    public static int RedemptionEggCrown => ModRedemption.Items.EggCrown;
    public static int RedemptionEaglecrestSpelltome => ModRedemption.Items.EaglecrestSpelltome;

    public static List<int[]> GetVanillaBossRewardItemTiers()
    {
        int[] evilTier =
            Config.Instance?.UnlockAllItems == true
                ? [ItemID.BloodySpine, ItemID.WormFood]
                : [WorldGen.crimson ? ItemID.BloodySpine : ItemID.WormFood];

        return
        [
            [ItemID.SuspiciousLookingEye],
            evilTier,
            [ItemID.Abeemination, ItemID.DeerThing, ItemID.GuideVoodooDoll],
            [ItemID.QueenSlimeCrystal, ItemID.MechanicalEye, ItemID.MechanicalSkull, ItemID.MechanicalWorm],
            [ItemID.LihzahrdPowerCell],
            [ItemID.TruffleWorm],
            [ItemID.CelestialSigil],
        ];
    }
}

