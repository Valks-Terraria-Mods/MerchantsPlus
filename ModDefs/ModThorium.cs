using MerchantsPlus.Utils;

namespace MerchantsPlus.ModDefs;

public static class ModThorium
{
    private const string ModName = "ThoriumMod";
    private const string WorldType = "ThoriumMod.ThoriumWorld";

    public static class Items
    {
        public static int GrandFlareGun => OtherMods.TryFindItemType(ModName, "GrandFlareGun");
        public static int StormFlare => OtherMods.TryFindItemType(ModName, "StormFlare");
        public static int JellyfishResonator => OtherMods.TryFindItemType(ModName, "JellyfishResonator");
        public static int UnholyShards => OtherMods.TryFindItemType(ModName, "UnholyShards");
        public static int UnstableCore => OtherMods.TryFindItemType(ModName, "UnstableCore");
        public static int AncientBlade => OtherMods.TryFindItemType(ModName, "AncientBlade");
        public static int StarCaller => OtherMods.TryFindItemType(ModName, "StarCaller");
        public static int StriderTear => OtherMods.TryFindItemType(ModName, "StriderTear");
        public static int VoidLens => OtherMods.TryFindItemType(ModName, "VoidLens");
        public static int AbyssalShadow => OtherMods.TryFindItemType(ModName, "AbyssalShadow");
        public static int DoomSayersCoin => OtherMods.TryFindItemType(ModName, "DoomSayersCoin");
    }

    public static class Bosses
    {
        public static bool DownedTheGrandThunderBird => OtherMods.TryGetStaticBoolField(ModName, WorldType, "downedTheGrandThunderBird");
        public static bool DownedQueenJellyfish => OtherMods.TryGetStaticBoolField(ModName, WorldType, "downedQueenJellyfish");
        public static bool DownedViscount => OtherMods.TryGetStaticBoolField(ModName, WorldType, "downedViscount");
        public static bool DownedGraniteEnergyStorm => OtherMods.TryGetStaticBoolField(ModName, WorldType, "downedGraniteEnergyStorm");
        public static bool DownedBuriedChampion => OtherMods.TryGetStaticBoolField(ModName, WorldType, "downedBuriedChampion");
        public static bool DownedStarScouter => OtherMods.TryGetStaticBoolField(ModName, WorldType, "downedStarScouter");
        public static bool DownedBoreanStrider => OtherMods.TryGetStaticBoolField(ModName, WorldType, "downedBoreanStrider");
        public static bool DownedFallenBeholder => OtherMods.TryGetStaticBoolField(ModName, WorldType, "downedFallenBeholder");
        public static bool DownedLich => OtherMods.TryGetStaticBoolField(ModName, WorldType, "downedLich");
        public static bool DownedForgottenOne => OtherMods.TryGetStaticBoolField(ModName, WorldType, "downedForgottenOne");
        public static bool DownedThePrimordials => OtherMods.TryGetStaticBoolField(ModName, WorldType, "downedThePrimordials");
    }
}
