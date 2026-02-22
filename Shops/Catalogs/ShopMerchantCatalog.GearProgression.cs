using Terraria.WorldBuilding;

namespace MerchantsPlus.Shops;

public static partial class ShopMerchantCatalog
{
    public static readonly int[] BasePickaxes =
    [
        ItemID.IronPickaxe,
        ItemID.LeadPickaxe,
    ];

    public static readonly int[] EyePickaxes =
    [
        ItemID.GoldPickaxe,
        ItemID.PlatinumPickaxe,
    ];

    public static readonly int[] EvilPickaxes =
    [
        ItemID.DeathbringerPickaxe,
        ItemID.NightmarePickaxe,
    ];

    public static readonly int[] BaseAxes =
    [
        ItemID.IronAxe,
        ItemID.LeadAxe,
    ];

    public static readonly int[] EyeAxes =
    [
        ItemID.GoldAxe,
        ItemID.PlatinumAxe,
    ];

    public static readonly int[] EvilAxes =
    [
        ItemID.BloodLustCluster,
        ItemID.WarAxeoftheNight,
    ];

    public static readonly int[] BaseHammers =
    [
        ItemID.IronHammer,
        ItemID.LeadHammer,
    ];

    public static readonly int[] EyeHammers =
    [
        ItemID.GoldHammer,
        ItemID.PlatinumHammer,
    ];

    public static readonly int[] EvilHammers =
    [
        ItemID.FleshGrinder,
        ItemID.TheBreaker,
    ];

    public static readonly int[] BaseHelmets =
    [
        ItemID.CopperHelmet,
        ItemID.TinHelmet,
    ];

    public static readonly int[] SlimeHelmets =
    [
        ItemID.IronHelmet,
        ItemID.LeadHelmet,
    ];

    public static readonly int[] EyeHelmets =
    [
        ItemID.GoldHelmet,
        ItemID.PlatinumHelmet,
    ];

    public static readonly int[] EvilHelmets =
    [
        ItemID.CrimsonHelmet,
        ItemID.ShadowHelmet,
    ];

    public static readonly int[] BaseBreastplates =
    [
        ItemID.CopperChainmail,
        ItemID.TinChainmail,
    ];

    public static readonly int[] SlimeBreastplates =
    [
        ItemID.IronChainmail,
        ItemID.LeadChainmail,
    ];

    public static readonly int[] EyeBreastplates =
    [
        ItemID.GoldChainmail,
        ItemID.PlatinumChainmail,
    ];

    public static readonly int[] EvilBreastplates =
    [
        ItemID.CrimsonScalemail,
        ItemID.ShadowScalemail,
    ];

    public static readonly int[] BaseGreaves =
    [
        ItemID.CopperGreaves,
        ItemID.TinGreaves,
    ];

    public static readonly int[] SlimeGreaves =
    [
        ItemID.IronGreaves,
        ItemID.LeadGreaves,
    ];

    public static readonly int[] EyeGreaves =
    [
        ItemID.GoldGreaves,
        ItemID.PlatinumGreaves,
    ];

    public static readonly int[] EvilGreaves =
    [
        ItemID.CrimsonGreaves,
        ItemID.ShadowGreaves,
    ];

    public static readonly int[] BaseShortswords =
    [
        ItemID.IronShortsword,
        ItemID.LeadShortsword,
    ];

    public static readonly int[] EyeShortswords =
    [
        ItemID.GoldShortsword,
        ItemID.PlatinumShortsword,
    ];

    public static readonly int[] BaseBroadswords =
    [
        ItemID.IronBroadsword,
        ItemID.LeadBroadsword,
    ];

    public static readonly int[] EyeBroadswords =
    [
        ItemID.GoldBroadsword,
        ItemID.PlatinumBroadsword,
    ];

    public static readonly int[] EvilBroadswords =
    [
        ItemID.BloodButcherer,
        ItemID.LightsBane,
    ];

    public static readonly int[] BaseBows =
    [
        ItemID.IronBow,
        ItemID.LeadBow,
    ];

    public static readonly int[] EyeBows =
    [
        ItemID.GoldBow,
        ItemID.PlatinumBow,
    ];

    public static readonly int[] EvilBows =
    [
        ItemID.TendonBow,
        ItemID.DemonBow,
    ];

    public static readonly int[] BaseOreBars =
    [
        ItemID.CopperBar,
        ItemID.TinBar,
    ];

    public static readonly int[] TierOneOreBars =
    [
        ItemID.IronBar,
        ItemID.LeadBar,
    ];

    public static readonly int[] TierTwoOreBars =
    [
        ItemID.SilverBar,
        ItemID.TungstenBar,
    ];

    public static readonly int[] TierThreeOreBars =
    [
        ItemID.GoldBar,
        ItemID.PlatinumBar,
    ];

    public static readonly int[] EvilOreBars =
    [
        ItemID.CrimtaneBar,
        ItemID.DemoniteBar,
    ];

    public static int GetBasePickaxe() => GenVars.ironBar > 0 ? ItemID.IronPickaxe : ItemID.LeadPickaxe;
    public static int GetEyePickaxe() => GenVars.goldBar > 0 ? ItemID.GoldPickaxe : ItemID.PlatinumPickaxe;
    public static int GetEvilPickaxe() => WorldGen.crimson ? ItemID.DeathbringerPickaxe : ItemID.NightmarePickaxe;

    public static int GetBaseAxe() => GenVars.ironBar > 0 ? ItemID.IronAxe : ItemID.LeadAxe;
    public static int GetEyeAxe() => GenVars.goldBar > 0 ? ItemID.GoldAxe : ItemID.PlatinumAxe;
    public static int GetEvilAxe() => WorldGen.crimson ? ItemID.BloodLustCluster : ItemID.WarAxeoftheNight;

    public static int GetBaseHammer() => GenVars.ironBar > 0 ? ItemID.IronHammer : ItemID.LeadHammer;
    public static int GetEyeHammer() => GenVars.goldBar > 0 ? ItemID.GoldHammer : ItemID.PlatinumHammer;
    public static int GetEvilHammer() => WorldGen.crimson ? ItemID.FleshGrinder : ItemID.TheBreaker;

    public static int GetBaseHelmet() => GenVars.copperBar > 0 ? ItemID.CopperHelmet : ItemID.TinHelmet;
    public static int GetSlimeHelmet() => GenVars.ironBar > 0 ? ItemID.IronHelmet : ItemID.LeadHelmet;
    public static int GetEyeHelmet() => GenVars.goldBar > 0 ? ItemID.GoldHelmet : ItemID.PlatinumHelmet;
    public static int GetEvilHelmet() => WorldGen.crimson ? ItemID.CrimsonHelmet : ItemID.ShadowHelmet;

    public static int GetBaseBreastplate() => GenVars.copperBar > 0 ? ItemID.CopperChainmail : ItemID.TinChainmail;
    public static int GetSlimeBreastplate() => GenVars.ironBar > 0 ? ItemID.IronChainmail : ItemID.LeadChainmail;
    public static int GetEyeBreastplate() => GenVars.goldBar > 0 ? ItemID.GoldChainmail : ItemID.PlatinumChainmail;
    public static int GetEvilBreastplate() => WorldGen.crimson ? ItemID.CrimsonScalemail : ItemID.ShadowScalemail;

    public static int GetBaseGreaves() => GenVars.copperBar > 0 ? ItemID.CopperGreaves : ItemID.TinGreaves;
    public static int GetSlimeGreaves() => GenVars.ironBar > 0 ? ItemID.IronGreaves : ItemID.LeadGreaves;
    public static int GetEyeGreaves() => GenVars.goldBar > 0 ? ItemID.GoldGreaves : ItemID.PlatinumGreaves;
    public static int GetEvilGreaves() => WorldGen.crimson ? ItemID.CrimsonGreaves : ItemID.ShadowGreaves;

    public static int GetBaseShortsword() => GenVars.ironBar > 0 ? ItemID.IronShortsword : ItemID.LeadShortsword;
    public static int GetEyeShortsword() => GenVars.goldBar > 0 ? ItemID.GoldShortsword : ItemID.PlatinumShortsword;

    public static int GetBaseBroadsword() => GenVars.ironBar > 0 ? ItemID.IronBroadsword : ItemID.LeadBroadsword;
    public static int GetEyeBroadsword() => GenVars.goldBar > 0 ? ItemID.GoldBroadsword : ItemID.PlatinumBroadsword;
    public static int GetEvilBroadsword() => WorldGen.crimson ? ItemID.BloodButcherer : ItemID.LightsBane;

    public static int GetBaseBow() => GenVars.ironBar > 0 ? ItemID.IronBow : ItemID.LeadBow;
    public static int GetEyeBow() => GenVars.goldBar > 0 ? ItemID.GoldBow : ItemID.PlatinumBow;
    public static int GetEvilBow() => WorldGen.crimson ? ItemID.TendonBow : ItemID.DemonBow;

    public static int GetBaseOre() => GenVars.copperBar > 0 ? ItemID.CopperBar : ItemID.TinBar;
    public static int GetTierOneOre() => GenVars.ironBar > 0 ? ItemID.IronBar : ItemID.LeadBar;
    public static int GetTierTwoOre() => GenVars.silverBar > 0 ? ItemID.SilverBar : ItemID.TungstenBar;
    public static int GetTierThreeOre() => GenVars.goldBar > 0 ? ItemID.GoldBar : ItemID.PlatinumBar;
    public static int GetEvilOre() => WorldGen.crimson ? ItemID.CrimtaneBar : ItemID.DemoniteBar;
}
