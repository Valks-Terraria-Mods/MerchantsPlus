using MerchantsPlus.ModDefs;
using Terraria.WorldBuilding;

namespace MerchantsPlus.Shops;

public class ShopGuide : Shop
{
    public override List<string> Shops { get; } = ["Gear", "Pylons", "Vanilla Bosses"];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Gear")
        {
            if (Progression.Hardmode)
            {
                AddItem(ItemID.MagicMirror, Coins.Gold());
            }

            AddItem(ItemID.CordageGuide, Coins.Gold());

            if (!WorldUtils.IsNpcHere(NPCID.Merchant))
            {
                AddItem(ItemID.Torch);
            }

            if (Progression.Skeletron && !Progression.Hardmode)
            {
                AddItem(ItemID.GuideVoodooDoll, Coins.Gold(5));
            }

            if (Progression.EaterOfWorlds || Progression.BrainOfCthulhu)
            {
                if (!Progression.Hardmode)
                {
                    AddItem(ItemID.Obsidian, Coins.Silver());
                }
            }

            if (!WorldUtils.IsNpcHere(NPCID.Pirate))
            {
                AddItem(ItemID.Cannon, Coins.Gold(2));
                AddItem(ItemID.Cannonball);
            }

            AddItem(ItemID.Gel, Coins.Silver());
        }

        if (shop == "Pylons")
        {
            AddItem(ItemID.TeleportationPylonVictory, Coins.Gold());
            AddItem(ItemID.TeleportationPylonUnderground, Coins.Gold());
            AddItem(ItemID.TeleportationPylonSnow, Coins.Gold());
            AddItem(ItemID.TeleportationPylonPurity, Coins.Gold());
            AddItem(ItemID.TeleportationPylonOcean, Coins.Gold());
            AddItem(ItemID.TeleportationPylonMushroom, Coins.Gold());
            AddItem(ItemID.TeleportationPylonJungle, Coins.Gold());
            AddItem(ItemID.TeleportationPylonHallow, Coins.Gold());
            AddItem(ItemID.TeleportationPylonDesert, Coins.Gold());
        }

        if (shop == "Vanilla Bosses")
        {
            VanillaBosses();
        }

        // Shop will only be added if ThoriumMod is enabled
        if (shop == "Thorium Bosses")
        {
            ThoriumBosses();
        }
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
            AddItem(ModThorium.Items.JellyfishResonator, Coins.Gold(3));
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
            AddItem(ModThorium.Items.UnstableCore, Coins.Gold(3));
        }

        if (ModThorium.Bosses.DownedGraniteEnergyStorm)
        {
            // Buried Champion
            // The Ancient Blade is a boss-summoning item used to summon the Buried Champion in the Marble Caves.
            AddItem(ModThorium.Items.AncientBlade, Coins.Gold(3));
        }

        if (ModThorium.Bosses.DownedBuriedChampion)
        {
            // Star Scouter
            // The Star Caller is a boss-summoning item that is used to summon the Star Scouter in Space.
            AddItem(ModThorium.Items.StarCaller, Coins.Gold(3));
        }

        if (ModThorium.Bosses.DownedStarScouter)
        {
            // Borean Strider
            // The Strider's Tear is a Hardmode boss-summoning item used to summon the Borean Strider in the Snow biome during Blizzards.
            AddItem(ModThorium.Items.StriderTear, Coins.Gold(3));
        }

        if (ModThorium.Bosses.DownedBoreanStrider)
        {
            // Fallen Beholder
            // The Void Lens is a Hardmode boss-summoning item that is used to summon the Fallen Beholder in The Underworld.
            AddItem(ModThorium.Items.VoidLens, Coins.Gold(3));
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
            AddItem(ModThorium.Items.AbyssalShadow, Coins.Gold(3));
        }

        if (ModThorium.Bosses.DownedForgottenOne)
        {
            // The Primordials
            // The Primordials is the final boss of the Thorium mod, summoned with the Doom Sayer's Coin.
            AddItem(ModThorium.Items.DoomSayersCoin, Coins.Gold(10));
        }
    }
    
    private void VanillaBosses()
    {
        AddItem(ItemID.SlimeCrown, Coins.Gold(3));
        
        if (Progression.SlimeKing)
            AddItem(ItemID.SuspiciousLookingEye, Coins.Gold(5));
        
        if (Progression.EyeOfCthulhu)
            AddItem(GenVars.crimsonLeft ? ItemID.BloodySpine : ItemID.WormFood, Coins.Gold(5));

        if (Progression.Skeletron)
        {
            AddItem(ItemID.Abeemination, Coins.Gold(5));
            AddItem(ItemID.DeerThing, Coins.Gold(5));
            AddItem(ItemID.GuideVoodooDoll, Coins.Gold(5));
        }

        if (Main.hardMode)
        {
            AddItem(ItemID.QueenSlimeCrystal, Coins.Gold(5));
            AddItem(ItemID.MechanicalEye, Coins.Gold(5));
            AddItem(ItemID.MechanicalSkull, Coins.Gold(5));
            AddItem(ItemID.MechanicalWorm, Coins.Gold(5));

            if (Progression.DownedMechs(3))
            {
                AddItem(ItemID.LihzahrdPowerCell, Coins.Gold(5));
            }

            if (Progression.Golem)
            {
                AddItem(ItemID.TruffleWorm, Coins.Gold(5));
            }

            if (Progression.Towers)
            {
                AddItem(ItemID.CelestialSigil, Coins.Gold(10));
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
