using MerchantsPlus.ModDefs;

namespace MerchantsPlus.Shops;

public partial class ShopGuide
{
    private void ThoriumBosses()
    {
        bool unlockAllItems = Config.Instance?.UnlockAllItems == true;

        if (unlockAllItems)
        {
            AddItem(ShopGuideCatalog.ThoriumGrandFlareGun, Coins.Gold(2));
            AddItem(ShopGuideCatalog.ThoriumStormFlare, Coins.Gold());
            AddCrossModBossSummon(ShopGuideCatalog.ThoriumJellyfishResonator);
            AddItem(ShopGuideCatalog.ThoriumUnholyShards, Coins.Silver(50));
            AddCrossModBossSummon(ShopGuideCatalog.ThoriumUnstableCore);
            AddCrossModBossSummon(ShopGuideCatalog.ThoriumAncientBlade);
            AddCrossModBossSummon(ShopGuideCatalog.ThoriumStarCaller);
            AddCrossModBossSummon(ShopGuideCatalog.ThoriumStriderTear);
            AddCrossModBossSummon(ShopGuideCatalog.ThoriumVoidLens);
            AddItem(ShopGuideCatalog.PumpkinItemId, Coins.Silver(10));
            AddCrossModBossSummon(ShopGuideCatalog.ThoriumAbyssalShadow);
            AddItem(ShopGuideCatalog.ThoriumDoomSayersCoin, Coins.Gold(10));
            return;
        }

        // The Grand Thunder Bird
        // These items are crafted from iron bars, talons and fallen stars. Talons drop from vultures in the desert.
        AddItem(ShopGuideCatalog.ThoriumGrandFlareGun, Coins.Gold(2));
        AddItem(ShopGuideCatalog.ThoriumStormFlare, Coins.Gold());

        if (ModThorium.Bosses.DownedTheGrandThunderBird)
        {
            // Queen Jellyfish
            // The Jellyfish Resonator is a boss-summoning item that is used to summon the Queen Jellyfish. It can only be used in the Ocean during the day.
            // The item is crafted from coral, seashell and starfish and / or pink jellyfish.
            AddCrossModBossSummon(ShopGuideCatalog.ThoriumJellyfishResonator);
        }

        if (ModThorium.Bosses.DownedQueenJellyfish)
        {
            // Viscount is summoned by using 5 Unholy Shards at a Blood Altar in the Cavern layer.
            // Unholy Shards are a pre-Hardmode crafting material that drops from all enemies during a Blood Moon.
            AddItem(ShopGuideCatalog.ThoriumUnholyShards, Coins.Silver(50));
        }

        if (ModThorium.Bosses.DownedViscount)
        {
            // Granite Energy Storm
            // The Unstable Core is a boss-summoning item that is used to summon the Granite Energy Storm. It can only be used in the Granite Caves.
            AddCrossModBossSummon(ShopGuideCatalog.ThoriumUnstableCore);
        }

        if (ModThorium.Bosses.DownedGraniteEnergyStorm)
        {
            // Buried Champion
            // The Ancient Blade is a boss-summoning item used to summon the Buried Champion in the Marble Caves.
            AddCrossModBossSummon(ShopGuideCatalog.ThoriumAncientBlade);
        }

        if (ModThorium.Bosses.DownedBuriedChampion)
        {
            // Star Scouter
            // The Star Caller is a boss-summoning item that is used to summon the Star Scouter in Space.
            AddCrossModBossSummon(ShopGuideCatalog.ThoriumStarCaller);
        }

        if (ModThorium.Bosses.DownedStarScouter)
        {
            // Borean Strider
            // The Strider's Tear is a Hardmode boss-summoning item used to summon the Borean Strider in the Snow biome during Blizzards.
            AddCrossModBossSummon(ShopGuideCatalog.ThoriumStriderTear);
        }

        if (ModThorium.Bosses.DownedBoreanStrider)
        {
            // Fallen Beholder
            // The Void Lens is a Hardmode boss-summoning item that is used to summon the Fallen Beholder in The Underworld.
            AddCrossModBossSummon(ShopGuideCatalog.ThoriumVoidLens);
        }

        if (ModThorium.Bosses.DownedFallenBeholder)
        {
            // Lich
            // The Lich is a skeletal boss summoned at the Natural Graveyard’s Ancient Phylactery for 30 pumpkins.
            AddItem(ShopGuideCatalog.PumpkinItemId, Coins.Silver(10));
        }

        if (ModThorium.Bosses.DownedLich)
        {
            // Forgotten One
            // The Forgotten One is a crab-like boss fought in the Aquatic Depths. It spawns automatically after collecting 3 Abyssal Shadows dropped by Aquatic Hallucinations, but after its defeat, Abyssal Shadows can be used to manually summon the boss.
            AddCrossModBossSummon(ShopGuideCatalog.ThoriumAbyssalShadow);
        }

        if (ModThorium.Bosses.DownedForgottenOne)
        {
            // The Primordials
            // The Primordials is the final boss of the Thorium mod, summoned with the Doom Sayer's Coin.
            AddItem(ShopGuideCatalog.ThoriumDoomSayersCoin, Coins.Gold(10));
        }
    }
}
