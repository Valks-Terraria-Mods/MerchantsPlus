using MerchantsPlus.Utils;

namespace MerchantsPlus.ModDefs;

public static class ModThorium
{
    private const string ModName = "ThoriumMod";
    private const string WorldType = "ThoriumMod.ThoriumWorld";

    private static int Item(string itemName) => OtherMods.TryFindItemType(ModName, itemName);
    private static bool Downed(string fieldName) => OtherMods.TryGetStaticBoolField(ModName, WorldType, fieldName);

    public static class Items
    {
        public static int GrandFlareGun => Item("GrandFlareGun");
        public static int StormFlare => Item("StormFlare");
        public static int JellyfishResonator => Item("JellyfishResonator");
        public static int UnholyShards => Item("UnholyShards");
        public static int UnstableCore => Item("UnstableCore");
        public static int AncientBlade => Item("AncientBlade");
        public static int StarCaller => Item("StarCaller");
        public static int StriderTear => Item("StriderTear");
        public static int VoidLens => Item("VoidLens");
        public static int AbyssalShadow => Item("AbyssalShadow");
        public static int DoomSayersCoin => Item("DoomSayersCoin");
    }

    public static class Bosses
    {
        public static bool DownedTheGrandThunderBird => Downed("downedTheGrandThunderBird");
        public static bool DownedQueenJellyfish => Downed("downedQueenJellyfish");
        public static bool DownedViscount => Downed("downedViscount");
        public static bool DownedGraniteEnergyStorm => Downed("downedGraniteEnergyStorm");
        public static bool DownedBuriedChampion => Downed("downedBuriedChampion");
        public static bool DownedStarScouter => Downed("downedStarScouter");
        public static bool DownedBoreanStrider => Downed("downedBoreanStrider");
        public static bool DownedFallenBeholder => Downed("downedFallenBeholder");
        public static bool DownedLich => Downed("downedLich");
        public static bool DownedForgottenOne => Downed("downedForgottenOne");
        public static bool DownedThePrimordials => Downed("downedThePrimordials");
    }
}

