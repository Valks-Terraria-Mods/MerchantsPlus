using MerchantsPlus.ModDefs;
using Terraria.WorldBuilding;

namespace MerchantsPlus.Shops;

public class ShopGuide : Shop
{
    public override List<string> Shops { get; } = [.. ShopGuideCatalog.ShopNames];
    private static readonly int _crossModBossSummonPrice = Coins.Gold(3);

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        switch (shop)
        {
            case ShopGuideCatalog.GearShopName:
                Gear();
                return;
            case ShopGuideCatalog.PylonsShopName:
                Pylons();
                return;
            case ShopGuideCatalog.VanillaShopName:
                VanillaBosses();
                return;
            case ShopGuideCatalog.CalamityShopName:
                CalamityBosses();
                return;
            // Shop will only be added if ThoriumMod is enabled
            case ShopGuideCatalog.ThoriumShopName:
                ThoriumBosses();
                return;
            // Shop will only be added if Redemption mod is enabled
            case ShopGuideCatalog.RedemptionShopName:
                RedemptionBosses();
                return;
            default:
                return;
        }
    }

    private void Gear()
    {
        AddItemsAtPrice(Coins.Gold(), ShopGuideCatalog.UtilityGear);

        if (!WorldUtils.IsNpcHere(NPCID.Merchant))
        {
            AddItem(ShopGuideCatalog.TorchItemId);
        }

        if (Progression.Skeletron && !Progression.Hardmode)
        {
            AddItem(ShopGuideCatalog.GuideVoodooDollItemId, Coins.Gold(5));
        }

        if (!Progression.Hardmode && (Progression.EaterOfWorlds || Progression.BrainOfCthulhu))
        {
            AddItem(ShopGuideCatalog.ObsidianItemId, Coins.Silver());
        }

        if (!WorldUtils.IsNpcHere(NPCID.Pirate))
        {
            AddItem(ShopGuideCatalog.CannonItemId, Coins.Gold(2));
            AddItem(ShopGuideCatalog.CannonballItemId);
        }

        AddItem(ShopGuideCatalog.GelItemId, Coins.Silver());
        AddItem(ShopGuideCatalog.BedItemId, Coins.Silver(10));
    }

    private void Pylons()
    {
        AddItemsAtPrice(Coins.Gold(), ShopGuideCatalog.Pylons);
    }

    private void AddCrossModBossSummon(int itemId)
    {
        AddItem(itemId, _crossModBossSummonPrice);
    }

    private void CalamityBosses()
    {
        AddCrossModBossSummon(ShopGuideCatalog.CalamityDesertMedallion);

        if (ModCalamity.Bosses.DesertScourgeDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityDecapoditaSprout);
        }

        if (ModCalamity.Bosses.CrabulonDowned)
        {
            AddCrossModBossSummon(WorldGen.crimson ? ShopGuideCatalog.CalamityBloodyWormFood : ShopGuideCatalog.CalamityTeratoma);
        }

        if (ModCalamity.Bosses.PerforatorDowned || ModCalamity.Bosses.TheHiveMindDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityOverloadedSludge);
        }

        if (ModCalamity.Bosses.SlimeGodDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityCryoKey);
        }

        // Hardmode
        if (ModCalamity.Bosses.CryogenDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamitySeafood);
        }

        if (ModCalamity.Bosses.AquaticScourgeDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityCharredIdol);
        }

        if (ModCalamity.Bosses.BrimstoneElementalDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityEyeofDesolation); // Calamitas Clone Key
        }

        if (ModCalamity.Bosses.CalamitasDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityEyeofDesolation);
        }

        if (ModCalamity.Bosses.AstrumAureusDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityAstralChunk);
        }

        if (ModCalamity.Bosses.PlaguebringeDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityAbombination);
        }

        if (ModCalamity.Bosses.RavagerDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityDeathWhistle);
        }

        if (ModCalamity.Bosses.AstrumDeusDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityTitanHeart);
        }

        // Post-Moon Lord
        if (ModCalamity.Bosses.ProfanedGuardiansDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityProfanedShard);
        }

        if (ModCalamity.Bosses.DragonfollyDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityExoticPheromones);
        }

        if (ModCalamity.Bosses.ProvidenceDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityProfanedCore);
        }

        if (ModCalamity.Bosses.StormWeaverDowned || ModCalamity.Bosses.CeaselessVoidDowned || ModCalamity.Bosses.SignusDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityMarkofProvidence);
        }

        if (ModCalamity.Bosses.OldDukeDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityBloodworm);
        }

        if (ModCalamity.Bosses.DevourerOfGodsDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityCosmicWorm);
        }

        if (ModCalamity.Bosses.YharonDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityBlessedPhoenixEgg);
        }

        if (ModCalamity.Bosses.SupremeWitchCalamitasDowned)
        {
            AddCrossModBossSummon(ShopGuideCatalog.CalamityAshesOfCalamity);
        }
    }

    private void RedemptionBosses()
    {
        // Pre-Hardmode
        AddCrossModBossSummon(ShopGuideCatalog.RedemptionHeartOfThorns);
        if (ModRedemption.Bosses.ThornsDowned)
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionForbiddenRitual);
        if (ModRedemption.Bosses.ErhanDowned)
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionWeddingRing);
        if (ModRedemption.Bosses.KeeperDowned)
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionAnomalyDetector);

        // Hardmode
        if (ModRedemption.Bosses.SeedOfInfectionDowned)
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionCyberRadio);
        if (ModRedemption.Bosses.KingSlayerIIIDowned)
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionOmegaTransmitter);

        // Post-Moon Lord
        if (ModRedemption.Bosses.OmegaObliteratorDowned)
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionHologramRemote);
        if (ModRedemption.Bosses.PatientZeroDowned)
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionAncientSigil);
        if (ModRedemption.Bosses.AncientDeityDowned)
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionGalaxyStone);

        // Mini Bosses (optional)
        if (!ModRedemption.Bosses.FowlEmperorDowned)
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionEggCrown);
        if (ModRedemption.Bosses.EaglecrestGolemDowned)
            AddCrossModBossSummon(ShopGuideCatalog.RedemptionEaglecrestSpelltome);
    }
    private void ThoriumBosses()
    {
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

    private void VanillaBosses()
    {
        AddItem(ShopGuideCatalog.SlimeCrownItemId, Coins.Gold(3));

        List<int[]> rewardTiers = ShopGuideCatalog.GetVanillaBossRewardItemTiers();
        for (int i = 0; i < Math.Min(Progression.LevelBoss(), rewardTiers.Count); i++)
        {
            int price = i == rewardTiers.Count - 1 ? Coins.Gold(10) : Coins.Gold(5);
            foreach (int itemId in rewardTiers[i])
            {
                AddItem(itemId, price);
            }
        }
    }
}

public class ExtraCrossModTooltips : GlobalItem
{
    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        if (item.ModItem != null && item.ModItem.Mod.Name == "ThoriumMod")
        {
            switch (item.ModItem.Name)
            {
                case ShopGuideCatalog.ThoriumUnholyShardsName:
                {
                    TooltipLine line = new(Mod, "SummoningInfo", "Use 5 at a Blood Altar in the Cavern layer to summon the Viscount") { OverrideColor = Color.LightCoral };
                    tooltips.Insert(tooltips.Count - 2, line);
                    break;
                }
                case ShopGuideCatalog.ThoriumAbyssalShadowName:
                {
                    TooltipLine line = new(Mod, "SummoningInfo", "Use 3 in the Aquatic Depths to summon the The Forgotten One") { OverrideColor = Color.LightCoral };
                    tooltips.Insert(tooltips.Count - 2, line);
                    break;
                }
            }
        }
    }
}




