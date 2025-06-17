using Terraria.WorldBuilding;

namespace MerchantsPlus.Shops;

public class ShopGoblinTinkerer : Shop
{
    public override string[] Shops => [
        "Movement",
        "Informational",
        "Combat",
        "Health and Mana",
        "Immunity",
        "Defensive",
        "Special",
        "Miscellaneous" ];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        int progression = Progression.Level();

        if (shop == "Miscellaneous")
        {
            AddItem(ItemID.FlowerBoots, ItemCosts.Accessories);

            if (NPC.downedPirates)
            {
                AddItem(ItemID.GoldRing, ItemCosts.Accessories);
                AddItem(ItemID.DiscountCard, ItemCosts.Accessories);
                AddItem(ItemID.LuckyCoin, ItemCosts.Accessories);
            }

            if (WorldUtils.MultiKills([NPCID.BlueJellyfish, NPCID.PinkJellyfish, NPCID.GreenJellyfish]) > 100)
            {
                AddItem(ItemID.JellyfishNecklace, ItemCosts.Accessories);
            }

            if (NPC.downedMechBoss1)
            {
                AddItem(ItemID.NeptunesShell, ItemCosts.Accessories);
            }
            return;
        }

        if (shop == "Special")
        {
            AddItem(Progression.SlimeKing,       ItemID.RoyalGel,          ItemCosts.Accessories);
            AddItem(Progression.EyeOfCthulhu,    ItemID.EoCShield,         ItemCosts.Accessories);

            if (Progression.BrainOrEater)
            {
                if (WorldGen.crimson)
                {
                    AddItem(ItemID.BrainOfConfusion, ItemCosts.Accessories);
                }
                else
                {
                    AddItem(ItemID.WormScarf, ItemCosts.Accessories);
                }
            }

            AddItem(Progression.QueenBee,        ItemID.HiveBackpack,     ItemCosts.Accessories);
            AddItem(Progression.Plantera,        ItemID.SporeSac,         ItemCosts.Accessories);
            AddItem(Progression.Golem,           ItemID.ShinyStone,       ItemCosts.Accessories);
            AddItem(Progression.Moonlord,        ItemID.GravityGlobe,     ItemCosts.Accessories);
            return;
        }

        if (shop == "Defensive")
        {
            AddItem(Progression.Skeletron,                  ItemID.CobaltShield,      ItemCosts.Accessories);
            AddItem(WorldUtils.Kills(NPCID.Zombie) > 100,        ItemID.Shackle,           ItemCosts.Accessories);
            AddItem(WorldUtils.Kills(NPCID.BigMimicCrimson) > 0, ItemID.FleshKnuckles,     ItemCosts.Accessories);
            AddItem(WorldUtils.Kills(NPCID.IceTortoise) > 0,     ItemID.FrozenTurtleShell, ItemCosts.Accessories);

            return;
        }

        if (shop == "Immunity")
        {
            if (Progression.Hardmode)
            {
                AddItem(ItemID.HandWarmer, ItemCosts.Accessories);

                if (WorldUtils.MultiKills([NPCID.RustyArmoredBonesAxe, NPCID.Werewolf, NPCID.AnglerFish]) > 0)
                {
                    AddItem(ItemID.AdhesiveBandage, ItemCosts.Accessories);
                }
                if (WorldUtils.MultiKills([NPCID.ArmoredSkeleton, NPCID.BlueArmoredBones]) > 0)
                {
                    AddItem(ItemID.ArmorPolish, ItemCosts.Accessories);
                }
                if (WorldUtils.Kills(NPCID.ToxicSludge) > 0)
                {
                    AddItem(ItemID.Bezoar, ItemCosts.Accessories);
                }
                if (WorldUtils.Kills(NPCID.CorruptSlime) > 0)
                {
                    AddItem(ItemID.Blindfold, ItemCosts.Accessories);
                }

                if (WorldUtils.MultiKills([NPCID.Pixie, NPCID.DarkMummy]) > 0)
                {
                    AddItem(ItemID.Megaphone, ItemCosts.Accessories);
                }
                if (WorldUtils.Kills(NPCID.Mimic) > 2)
                {
                    AddItem(ItemID.CrossNecklace, ItemCosts.Accessories);
                }
                if (WorldUtils.Kills(NPCID.Pixie) > 10)
                {
                    AddItem(ItemID.FastClock, ItemCosts.Accessories);
                }

                if (Progression.Hardmode)
                {
                    AddItem(ItemID.ObsidianRose, ItemCosts.Accessories);
                }

                if (WorldUtils.Kills(NPCID.Medusa) > 0)
                {
                    AddItem(ItemID.PocketMirror, ItemCosts.Accessories);
                }

                if (WorldUtils.Kills(NPCID.LightMummy) > 0)
                {
                    AddItem(ItemID.TrifoldMap, ItemCosts.Accessories);
                }

                if (WorldUtils.Kills(NPCID.Corruptor) > 0)
                {
                    AddItem(ItemID.Vitamins, ItemCosts.Accessories);
                }
                if (WorldUtils.Kills(NPCID.CursedSkull) > 0)
                {
                    AddItem(ItemID.Nazar, ItemCosts.Accessories);
                }
            }

            return;
        }

        if (shop == "Combat")
        {
            AddItem(ItemID.SharkToothNecklace, ItemCosts.Accessories);

            if (progression > 0)
            {
                AddItem(ItemID.FeralClaws, ItemCosts.Accessories);
            }

            if (Progression.BrainOfCthulhu)
            {
                AddItem(ItemID.PanicNecklace, ItemCosts.Accessories);
            }

            if (Progression.QueenBee)
            {
                AddItem(ItemID.HoneyComb, ItemCosts.Accessories);
            }

            if (progression > 8)
            {
                AddItem(ItemID.MagicQuiver, ItemCosts.Accessories);
            }
            if (progression > 9)
            {
                AddItem(ItemID.MoonCharm, ItemCosts.Accessories);
            }
            if (progression > 10)
            {
                AddItem(ItemID.MoonStone, ItemCosts.Accessories);
            }
            if (progression > 11)
            {
                AddItem(ItemID.SunStone, ItemCosts.Accessories);
            }
            if (progression > 12)
            {
                AddItem(ItemID.MagmaStone, ItemCosts.Accessories);

                AddItem(ItemID.StarCloak, ItemCosts.Accessories);
            }
            if (progression > 13)
            {
                AddItem(ItemID.EyeoftheGolem, ItemCosts.Accessories);
            }

            if (Progression.Plantera)
            {
                AddItem(ItemID.BlackBelt, ItemCosts.Accessories);
            }

            if (progression > 15)
            {
                AddItem(ItemID.ApprenticeScarf, ItemCosts.Accessories);
            }
            if (progression > 16)
            {
                AddItem(ItemID.PutridScent, ItemCosts.Accessories);
            }

            if (progression > 17)
            {
                AddItem(ItemID.HerculesBeetle, ItemCosts.Accessories);
            }

            if (progression > 18)
            {
                AddItem(ItemID.NecromanticScroll, ItemCosts.Accessories);
            }

            if (progression > 19)
            {
                AddItem(ItemID.PygmyNecklace, ItemCosts.Accessories);
            }

            if (progression > 20)
            {
                AddItem(ItemID.PaladinsShield, ItemCosts.Accessories);
                AddItem(ItemID.SquireShield, ItemCosts.Accessories);
                AddItem(ItemID.HuntressBuckler, ItemCosts.Accessories);
                AddItem(ItemID.MonkBelt, ItemCosts.Accessories);
                AddItem(ItemID.TitanGlove, ItemCosts.Accessories);
            }

            return;
        }

        if (shop == "Health and Mana")
        {
            AddItem(ItemID.NaturesGift, ItemCosts.Accessories);

            if (Progression.BrainOrEater)
            {
                AddItem(ItemID.BandofStarpower, ItemCosts.Accessories);

                AddItem(ItemID.BandofRegeneration, ItemCosts.Accessories);
            }
            if (progression > 4)
            {
                AddItem(ItemID.CelestialMagnet, ItemCosts.Accessories);
            }
            if (Progression.Hardmode)
            {
                AddItem(ItemID.PhilosophersStone, ItemCosts.Accessories);
            }

            return;
        }

        if (shop == "Informational")
        {
            if (GenVars.goldBar > 0)
            {
                AddItem(ItemID.GoldWatch);
            }
            else
            {
                AddItem(ItemID.PlatinumWatch);
            }

            if (progression > 0)
            {
                AddItem(ItemID.DepthMeter, ItemCosts.Accessories);
            }
            if (progression > 1)
            {
                AddItem(ItemID.Compass, ItemCosts.Accessories);
            }
            if (progression > 2)
            {
                AddItem(ItemID.Stopwatch, ItemCosts.Accessories);
            }
            if (progression > 3)
            {
                AddItem(ItemID.TallyCounter, ItemCosts.Accessories);
            }
            if (progression > 4)
            {
                AddItem(ItemID.LifeformAnalyzer, ItemCosts.Accessories);
            }
            if (progression > 5)
            {
                AddItem(ItemID.DPSMeter, ItemCosts.Accessories);
            }
            if (progression > 6)
            {
                AddItem(ItemID.MetalDetector, ItemCosts.Accessories);
            }
            if (progression > 7)
            {
                AddItem(ItemID.Radar, ItemCosts.Accessories);
            }
            if (progression > 8)
            {
                AddItem(ItemID.Ruler, ItemCosts.Accessories);
            }
            if (progression > 9)
            {
                AddItem(ItemID.MechanicalLens, ItemCosts.Accessories);
            }
            if (progression > 10)
            {
                AddItem(ItemID.LaserRuler, ItemCosts.Accessories);
            }
            return;
        }

        if (shop == "Movement")
        {
            AddItem(ItemID.WaterWalkingBoots, ItemCosts.Accessories);

            if (progression > 0)
            {
                AddItem(ItemID.HermesBoots, ItemCosts.Accessories);
            }

            if (progression > 1)
            {
                AddItem(ItemID.CloudinaBottle, ItemCosts.Accessories);

                AddItem(ItemID.SandstorminaBottle, ItemCosts.Accessories);

                AddItem(ItemID.TsunamiInABottle, ItemCosts.Accessories);
            }

            if (progression > 2)
            {
                AddItem(ItemID.Aglet, ItemCosts.Accessories);
            }

            if (progression > 3)
            {
                AddItem(ItemID.AnkletoftheWind, ItemCosts.Accessories);
            }

            if (progression > 4)
            {
                AddItem(ItemID.RocketBoots, ItemCosts.Accessories);
            }

            if (progression > 5)
            {
                AddItem(ItemID.IceSkates, ItemCosts.Accessories);
            }

            if (progression > 6)
            {
                AddItem(ItemID.Flipper, ItemCosts.Accessories);
            }

            if (progression > 7)
            {
                AddItem(ItemID.ClimbingClaws, ItemCosts.Accessories);
            }

            if (progression > 8)
            {
                AddItem(ItemID.ShoeSpikes, ItemCosts.Accessories);
            }

            if (progression > 9)
            {
                AddItem(ItemID.DivingHelmet, ItemCosts.Accessories);
            }

            if (progression > 10)
            {
                AddItem(ItemID.ShinyRedBalloon, ItemCosts.Accessories);
            }

            if (progression > 11)
            {
                AddItem(ItemID.FlyingCarpet, ItemCosts.Accessories);
            }

            if (progression > 12)
            {
                AddItem(ItemID.LavaCharm, ItemCosts.Accessories);
            }

            if (progression > 13)
            {
                AddItem(ItemID.LuckyHorseshoe, ItemCosts.Accessories);
            }

            if (progression > 14)
            {
                AddItem(ItemID.Tabi, ItemCosts.Accessories);
            }

            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.GoblinTinkerer);
    }
}