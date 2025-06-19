using ThoriumMod;
using ThoriumMod.Items.BossBoreanStrider;
using ThoriumMod.Items.BossBuriedChampion;
using ThoriumMod.Items.BossFallenBeholder;
using ThoriumMod.Items.BossForgottenOne;
using ThoriumMod.Items.BossGraniteEnergyStorm;
using ThoriumMod.Items.BossQueenJellyfish;
using ThoriumMod.Items.BossStarScouter;
using ThoriumMod.Items.BossTheGrandThunderBird;
using ThoriumMod.Items.BossThePrimordials;
using ThoriumMod.Items.HealerItems;

namespace MerchantsPlus.ModDefs;

[JITWhenModsEnabled("ThoriumMod")]
public class ModThorium
{
    public class Items
    {
        public static int GrandFlareGun => ModContent.ItemType<GrandFlareGun>();
        public static int StormFlare => ModContent.ItemType<StormFlare>();
        public static int JellyfishResonator => ModContent.ItemType<JellyfishResonator>();
        public static int UnholyShards => ModContent.ItemType<UnholyShards>();
        public static int UnstableCore => ModContent.ItemType<UnstableCore>();
        public static int AncientBlade => ModContent.ItemType<AncientBlade>();
        public static int StarCaller => ModContent.ItemType<StarCaller>();
        public static int StriderTear => ModContent.ItemType<StriderTear>();
        public static int VoidLens => ModContent.ItemType<VoidLens>();
        public static int AbyssalShadow => ModContent.ItemType<AbyssalShadow>();
        public static int DoomSayersCoin => ModContent.ItemType<DoomSayersCoin>();

    }
    
    public class Bosses
    {
        public static bool DownedTheGrandThunderBird => ThoriumWorld.downedTheGrandThunderBird;
        public static bool DownedQueenJellyfish => ThoriumWorld.downedQueenJellyfish;
        public static bool DownedViscount => ThoriumWorld.downedViscount;
        public static bool DownedGraniteEnergyStorm => ThoriumWorld.downedGraniteEnergyStorm;
        public static bool DownedBuriedChampion => ThoriumWorld.downedBuriedChampion;
        public static bool DownedStarScouter =>  ThoriumWorld.downedStarScouter;
        public static bool DownedBoreanStrider => ThoriumWorld.downedBoreanStrider;
        public static bool DownedFallenBeholder => ThoriumWorld.downedFallenBeholder;
        public static bool DownedLich =>  ThoriumWorld.downedLich;
        public static bool DownedForgottenOne => ThoriumWorld.downedForgottenOne;
        public static bool DownedThePrimordials => ThoriumWorld.downedThePrimordials;
    }
}
