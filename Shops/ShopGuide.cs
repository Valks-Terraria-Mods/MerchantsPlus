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
            AddItem(ItemID.Torch);
        }

        if (Progression.Skeletron && !Progression.Hardmode)
        {
            AddItem(ItemID.GuideVoodooDoll, Coins.Gold(5));
        }

        if (!Progression.Hardmode && (Progression.EaterOfWorlds || Progression.BrainOfCthulhu))
        {
            AddItem(ItemID.Obsidian, Coins.Silver());
        }

        if (!WorldUtils.IsNpcHere(NPCID.Pirate))
        {
            AddItem(ItemID.Cannon, Coins.Gold(2));
            AddItem(ItemID.Cannonball);
        }

        AddItem(ItemID.Gel, Coins.Silver());
        AddItem(ItemID.Bed, Coins.Silver(10));
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
        AddCrossModBossSummon(ModCalamity.Items.DesertMedallion);

        if (ModCalamity.Bosses.DesertScourgeDowned)
        {
            AddCrossModBossSummon(ModCalamity.Items.DecapoditaSprout);
        }

        if (ModCalamity.Bosses.CrabulonDowned)
        {
            AddCrossModBossSummon(WorldGen.crimson ? ModCalamity.Items.BloodyWormFood : ModCalamity.Items.Teratoma);
        }

        if (ModCalamity.Bosses.PerforatorDowned || ModCalamity.Bosses.TheHiveMindDowned)
        {
            AddCrossModBossSummon(ModCalamity.Items.OverloadedSludge);
        }

        if (ModCalamity.Bosses.SlimeGodDowned)
        {
            AddCrossModBossSummon(ModCalamity.Items.CryoKey);
        }

        // Hardmode
        if (ModCalamity.Bosses.CryogenDowned)
        {
            AddCrossModBossSummon(ModCalamity.Items.Seafood);
        }

        if (ModCalamity.Bosses.AquaticScourgeDowned)
        {
            AddCrossModBossSummon(ModCalamity.Items.CharredIdol);
        }

        if (ModCalamity.Bosses.BrimstoneElementalDowned)
        {
            AddCrossModBossSummon(ModCalamity.Items.EyeofDesolation); // Calamitas Clone Key
        }

        if (ModCalamity.Bosses.CalamitasDowned)
        {
            AddCrossModBossSummon(ModCalamity.Items.EyeofDesolation);
        }

        if (ModCalamity.Bosses.AstrumAureusDowned)
        {
            AddCrossModBossSummon(ModCalamity.Items.AstralChunk);
        }

        if (ModCalamity.Bosses.PlaguebringeDowned)
        {
            AddCrossModBossSummon(ModCalamity.Items.Abombination);
        }

        if (ModCalamity.Bosses.RavagerDowned)
        {
            AddCrossModBossSummon(ModCalamity.Items.DeathWhistle);
        }

        if (ModCalamity.Bosses.AstrumDeusDowned)
        {
            AddCrossModBossSummon(ModCalamity.Items.TitanHeart);
        }

        // Post-Moon Lord
        if (ModCalamity.Bosses.ProfanedGuardiansDowned)
        {
            AddCrossModBossSummon(ModCalamity.Items.ProfanedShard);
        }

        if (ModCalamity.Bosses.DragonfollyDowned)
        {
            AddCrossModBossSummon(ModCalamity.Items.ExoticPheromones);
        }

        if (ModCalamity.Bosses.ProvidenceDowned)
        {
            AddCrossModBossSummon(ModCalamity.Items.ProfanedCore);
        }

        if (ModCalamity.Bosses.StormWeaverDowned || ModCalamity.Bosses.CeaselessVoidDowned || ModCalamity.Bosses.SignusDowned)
        {
            AddCrossModBossSummon(ModCalamity.Items.MarkofProvidence);
        }

        if (ModCalamity.Bosses.OldDukeDowned)
        {
            AddCrossModBossSummon(ModCalamity.Items.Bloodworm);
        }

        if (ModCalamity.Bosses.DevourerOfGodsDowned)
        {
            AddCrossModBossSummon(ModCalamity.Items.CosmicWorm);
        }

        if (ModCalamity.Bosses.YharonDowned)
        {
            AddCrossModBossSummon(ModCalamity.Items.BlessedPhoenixEgg);
        }

        if (ModCalamity.Bosses.SupremeWitchCalamitasDowned)
        {
            AddCrossModBossSummon(ModCalamity.Items.AshesOfCalamity);
        }
    }

    private void RedemptionBosses()
    {
        // Pre-Hardmode
        AddCrossModBossSummon(ModRedemption.Items.HeartOfThorns);
        if (ModRedemption.Bosses.ThornsDowned)
            AddCrossModBossSummon(ModRedemption.Items.ForbiddenRitual);
        if (ModRedemption.Bosses.ErhanDowned)
            AddCrossModBossSummon(ModRedemption.Items.WeddingRing);
        if (ModRedemption.Bosses.KeeperDowned)
            AddCrossModBossSummon(ModRedemption.Items.AnomalyDetector);

        // Hardmode
        if (ModRedemption.Bosses.SeedOfInfectionDowned)
            AddCrossModBossSummon(ModRedemption.Items.CyberRadio);
        if (ModRedemption.Bosses.KingSlayerIIIDowned)
            AddCrossModBossSummon(ModRedemption.Items.OmegaTransmitter);

        // Post-Moon Lord
        if (ModRedemption.Bosses.OmegaObliteratorDowned)
            AddCrossModBossSummon(ModRedemption.Items.HologramRemote);
        if (ModRedemption.Bosses.PatientZeroDowned)
            AddCrossModBossSummon(ModRedemption.Items.AncientSigil);
        if (ModRedemption.Bosses.AncientDeityDowned)
            AddCrossModBossSummon(ModRedemption.Items.GalaxyStone);

        // Mini Bosses (optional)
        if (!ModRedemption.Bosses.FowlEmperorDowned)
            AddCrossModBossSummon(ModRedemption.Items.EggCrown);
        if (ModRedemption.Bosses.EaglecrestGolemDowned)
            AddCrossModBossSummon(ModRedemption.Items.EaglecrestSpelltome);
    }
    private void ThoriumBosses()
    {
        // The Grand Thunder Bird
        // These items are crafted from iron bars, talons and fallen stars. Talons drop from vultures in the desert.
        AddItem(ModThorium.Items.GrandFlareGun, Coins.Gold(2));
        AddItem(ModThorium.Items.StormFlare, Coins.Gold());

        if (ModThorium.Bosses.DownedTheGrandThunderBird)
        {
            // Queen Jellyfish
            // The Jellyfish Resonator is a boss-summoning item that is used to summon the Queen Jellyfish. It can only be used in the Ocean during the day.
            // The item is crafted from coral, seashell and starfish and / or pink jellyfish.
            AddCrossModBossSummon(ModThorium.Items.JellyfishResonator);
        }

        if (ModThorium.Bosses.DownedQueenJellyfish)
        {
            // Viscount is summoned by using 5 Unholy Shards at a Blood Altar in the Cavern layer.
            // Unholy Shards are a pre-Hardmode crafting material that drops from all enemies during a Blood Moon.
            AddItem(ModThorium.Items.UnholyShards, Coins.Silver(50));
        }

        if (ModThorium.Bosses.DownedViscount)
        {
            // Granite Energy Storm
            // The Unstable Core is a boss-summoning item that is used to summon the Granite Energy Storm. It can only be used in the Granite Caves.
            AddCrossModBossSummon(ModThorium.Items.UnstableCore);
        }

        if (ModThorium.Bosses.DownedGraniteEnergyStorm)
        {
            // Buried Champion
            // The Ancient Blade is a boss-summoning item used to summon the Buried Champion in the Marble Caves.
            AddCrossModBossSummon(ModThorium.Items.AncientBlade);
        }

        if (ModThorium.Bosses.DownedBuriedChampion)
        {
            // Star Scouter
            // The Star Caller is a boss-summoning item that is used to summon the Star Scouter in Space.
            AddCrossModBossSummon(ModThorium.Items.StarCaller);
        }

        if (ModThorium.Bosses.DownedStarScouter)
        {
            // Borean Strider
            // The Strider's Tear is a Hardmode boss-summoning item used to summon the Borean Strider in the Snow biome during Blizzards.
            AddCrossModBossSummon(ModThorium.Items.StriderTear);
        }

        if (ModThorium.Bosses.DownedBoreanStrider)
        {
            // Fallen Beholder
            // The Void Lens is a Hardmode boss-summoning item that is used to summon the Fallen Beholder in The Underworld.
            AddCrossModBossSummon(ModThorium.Items.VoidLens);
        }

        if (ModThorium.Bosses.DownedFallenBeholder)
        {
            // Lich
            // The Lich is a skeletal boss summoned at the Natural Graveyard’s Ancient Phylactery for 30 pumpkins.
            AddItem(ItemID.Pumpkin, Coins.Silver(10));
        }

        if (ModThorium.Bosses.DownedLich)
        {
            // Forgotten One
            // The Forgotten One is a crab-like boss fought in the Aquatic Depths. It spawns automatically after collecting 3 Abyssal Shadows dropped by Aquatic Hallucinations, but after its defeat, Abyssal Shadows can be used to manually summon the boss.
            AddCrossModBossSummon(ModThorium.Items.AbyssalShadow);
        }

        if (ModThorium.Bosses.DownedForgottenOne)
        {
            // The Primordials
            // The Primordials is the final boss of the Thorium mod, summoned with the Doom Sayer's Coin.
            AddItem(ModThorium.Items.DoomSayersCoin, Coins.Gold(10));
        }
    }

    private sealed class RewardTier(RewardItem[] items)
    {
        public RewardItem[] Items { get; } = items;
    }

    private sealed class RewardItem(int id, int price)
    {
        public int Id { get; } = id;
        public int Price { get; } = price;
    }

    private readonly List<RewardTier> _vanillaBossRewards =
    [
        new RewardTier(//Reward for defeating SlimeKing,
        [
            new RewardItem(ItemID.SuspiciousLookingEye, Coins.Gold(5))
        ]),

        new RewardTier(//EyeOfCthulhu,
        [
            new RewardItem(WorldGen.crimson ? ItemID.BloodySpine : ItemID.WormFood, Coins.Gold(5))
        ]),

        new RewardTier(//Skeletron,
        [
            new RewardItem(ItemID.Abeemination, Coins.Gold(5)),
            new RewardItem(ItemID.DeerThing, Coins.Gold(5)),
            new RewardItem(ItemID.GuideVoodooDoll, Coins.Gold(5))
        ]),

        new RewardTier(//hardMode,
        [
            new RewardItem(ItemID.QueenSlimeCrystal, Coins.Gold(5)),
            new RewardItem(ItemID.MechanicalEye, Coins.Gold(5)),
            new RewardItem(ItemID.MechanicalSkull, Coins.Gold(5)),
            new RewardItem(ItemID.MechanicalWorm, Coins.Gold(5))
        ]),

        new RewardTier(//Plantera,
        [
            new RewardItem(ItemID.LihzahrdPowerCell, Coins.Gold(5))
        ]),

        new RewardTier(//Golem,
        [
            new RewardItem(ItemID.TruffleWorm, Coins.Gold(5))
        ]),

        new RewardTier(//Towers,
        [
            new RewardItem(ItemID.CelestialSigil, Coins.Gold(10))
        ])
    ];

    private void VanillaBosses()
    {
        AddItem(ItemID.SlimeCrown, Coins.Gold(3));

        for (int i = 0; i < Math.Min(Progression.LevelBoss(), _vanillaBossRewards.Count); i++)
        {
            RewardTier reward = _vanillaBossRewards[i];

            foreach (RewardItem item in reward.Items)
            {
                AddItem(item.Id, item.Price);
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
                case nameof(ModThorium.Items.UnholyShards):
                {
                    TooltipLine line = new(Mod, "SummoningInfo", "Use 5 at a Blood Altar in the Cavern layer to summon the Viscount") { OverrideColor = Color.LightCoral };
                    tooltips.Insert(tooltips.Count - 2, line);
                    break;
                }
                case nameof(ModThorium.Items.AbyssalShadow):
                {
                    TooltipLine line = new(Mod, "SummoningInfo", "Use 3 in the Aquatic Depths to summon the The Forgotten One") { OverrideColor = Color.LightCoral };
                    tooltips.Insert(tooltips.Count - 2, line);
                    break;
                }
            }
        }
    }
}




