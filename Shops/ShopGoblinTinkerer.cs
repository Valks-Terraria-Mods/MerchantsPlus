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
            AddItem(ItemID.FlowerBoots, Utils.UniversalAccessoryCost);

            if (NPC.downedPirates)
            {
                AddItem(ItemID.GoldRing, Utils.UniversalAccessoryCost);
                AddItem(ItemID.DiscountCard, Utils.UniversalAccessoryCost);
                AddItem(ItemID.LuckyCoin, Utils.UniversalAccessoryCost);
            }

            if (Utils.MultiKills([NPCID.BlueJellyfish, NPCID.PinkJellyfish, NPCID.GreenJellyfish]) > 100)
            {
                AddItem(ItemID.JellyfishNecklace, Utils.UniversalAccessoryCost);
            }

            if (NPC.downedMechBoss1)
            {
                AddItem(ItemID.NeptunesShell, Utils.UniversalAccessoryCost);
            }
            return;
        }

        if (shop == "Special")
        {
            AddItem(Progression.SlimeKing,       ItemID.RoyalGel,          Utils.UniversalAccessoryCost);
            AddItem(Progression.EyeOfCthulhu,    ItemID.EoCShield,         Utils.UniversalAccessoryCost);

            if (Progression.BrainOrEater)
            {
                if (WorldGen.crimson)
                {
                    AddItem(ItemID.BrainOfConfusion, Utils.UniversalAccessoryCost);
                }
                else
                {
                    AddItem(ItemID.WormScarf, Utils.UniversalAccessoryCost);
                }
            }

            AddItem(Progression.QueenBee,        ItemID.HiveBackpack,     Utils.UniversalAccessoryCost);
            AddItem(Progression.Plantera,        ItemID.SporeSac,         Utils.UniversalAccessoryCost);
            AddItem(Progression.Golem,           ItemID.ShinyStone,       Utils.UniversalAccessoryCost);
            AddItem(Progression.Moonlord,        ItemID.GravityGlobe,     Utils.UniversalAccessoryCost);
            return;
        }

        if (shop == "Defensive")
        {
            AddItem(Progression.Skeletron,                  ItemID.CobaltShield,      Utils.UniversalAccessoryCost);
            AddItem(Utils.Kills(NPCID.Zombie) > 100,        ItemID.Shackle,           Utils.UniversalAccessoryCost);
            AddItem(Utils.Kills(NPCID.BigMimicCrimson) > 0, ItemID.FleshKnuckles,     Utils.UniversalAccessoryCost);
            AddItem(Utils.Kills(NPCID.IceTortoise) > 0,     ItemID.FrozenTurtleShell, Utils.UniversalAccessoryCost);

            return;
        }

        if (shop == "Immunity")
        {
            if (Progression.Hardmode)
            {
                AddItem(ItemID.HandWarmer, Utils.UniversalAccessoryCost);

                if (Utils.MultiKills([NPCID.RustyArmoredBonesAxe, NPCID.Werewolf, NPCID.AnglerFish]) > 0)
                {
                    AddItem(ItemID.AdhesiveBandage, Utils.UniversalAccessoryCost);
                }
                if (Utils.MultiKills([NPCID.ArmoredSkeleton, NPCID.BlueArmoredBones]) > 0)
                {
                    AddItem(ItemID.ArmorPolish, Utils.UniversalAccessoryCost);
                }
                if (Utils.Kills(NPCID.ToxicSludge) > 0)
                {
                    AddItem(ItemID.Bezoar, Utils.UniversalAccessoryCost);
                }
                if (Utils.Kills(NPCID.CorruptSlime) > 0)
                {
                    AddItem(ItemID.Blindfold, Utils.UniversalAccessoryCost);
                }

                if (Utils.MultiKills([NPCID.Pixie, NPCID.DarkMummy]) > 0)
                {
                    AddItem(ItemID.Megaphone, Utils.UniversalAccessoryCost);
                }
                if (Utils.Kills(NPCID.Mimic) > 2)
                {
                    AddItem(ItemID.CrossNecklace, Utils.UniversalAccessoryCost);
                }
                if (Utils.Kills(NPCID.Pixie) > 10)
                {
                    AddItem(ItemID.FastClock, Utils.UniversalAccessoryCost);
                }

                if (Progression.Hardmode)
                {
                    AddItem(ItemID.ObsidianRose, Utils.UniversalAccessoryCost);
                }

                if (Utils.Kills(NPCID.Medusa) > 0)
                {
                    AddItem(ItemID.PocketMirror, Utils.UniversalAccessoryCost);
                }

                if (Utils.Kills(NPCID.LightMummy) > 0)
                {
                    AddItem(ItemID.TrifoldMap, Utils.UniversalAccessoryCost);
                }

                if (Utils.Kills(NPCID.Corruptor) > 0)
                {
                    AddItem(ItemID.Vitamins, Utils.UniversalAccessoryCost);
                }
                if (Utils.Kills(NPCID.CursedSkull) > 0)
                {
                    AddItem(ItemID.Nazar, Utils.UniversalAccessoryCost);
                }
            }

            return;
        }

        if (shop == "Combat")
        {
            AddItem(ItemID.SharkToothNecklace, Utils.UniversalAccessoryCost);

            if (progression > 0)
            {
                AddItem(ItemID.FeralClaws, Utils.UniversalAccessoryCost);
            }

            if (Progression.BrainOfCthulhu)
            {
                AddItem(ItemID.PanicNecklace, Utils.UniversalAccessoryCost);
            }

            if (Progression.QueenBee)
            {
                AddItem(ItemID.HoneyComb, Utils.UniversalAccessoryCost);
            }

            if (progression > 8)
            {
                AddItem(ItemID.MagicQuiver, Utils.UniversalAccessoryCost);
            }
            if (progression > 9)
            {
                AddItem(ItemID.MoonCharm, Utils.UniversalAccessoryCost);
            }
            if (progression > 10)
            {
                AddItem(ItemID.MoonStone, Utils.UniversalAccessoryCost);
            }
            if (progression > 11)
            {
                AddItem(ItemID.SunStone, Utils.UniversalAccessoryCost);
            }
            if (progression > 12)
            {
                AddItem(ItemID.MagmaStone, Utils.UniversalAccessoryCost);

                AddItem(ItemID.StarCloak, Utils.UniversalAccessoryCost);
            }
            if (progression > 13)
            {
                AddItem(ItemID.EyeoftheGolem, Utils.UniversalAccessoryCost);
            }

            if (Progression.Plantera)
            {
                AddItem(ItemID.BlackBelt, Utils.UniversalAccessoryCost);
            }

            if (progression > 15)
            {
                AddItem(ItemID.ApprenticeScarf, Utils.UniversalAccessoryCost);
            }
            if (progression > 16)
            {
                AddItem(ItemID.PutridScent, Utils.UniversalAccessoryCost);
            }

            if (progression > 17)
            {
                AddItem(ItemID.HerculesBeetle, Utils.UniversalAccessoryCost);
            }

            if (progression > 18)
            {
                AddItem(ItemID.NecromanticScroll, Utils.UniversalAccessoryCost);
            }

            if (progression > 19)
            {
                AddItem(ItemID.PygmyNecklace, Utils.UniversalAccessoryCost);
            }

            if (progression > 20)
            {
                AddItem(ItemID.PaladinsShield, Utils.UniversalAccessoryCost);
                AddItem(ItemID.SquireShield, Utils.UniversalAccessoryCost);
                AddItem(ItemID.HuntressBuckler, Utils.UniversalAccessoryCost);
                AddItem(ItemID.MonkBelt, Utils.UniversalAccessoryCost);
                AddItem(ItemID.TitanGlove, Utils.UniversalAccessoryCost);
            }

            return;
        }

        if (shop == "Health and Mana")
        {
            AddItem(ItemID.NaturesGift, Utils.UniversalAccessoryCost);

            if (Progression.BrainOrEater)
            {
                AddItem(ItemID.BandofStarpower, Utils.UniversalAccessoryCost);

                AddItem(ItemID.BandofRegeneration, Utils.UniversalAccessoryCost);
            }
            if (progression > 4)
            {
                AddItem(ItemID.CelestialMagnet, Utils.UniversalAccessoryCost);
            }
            if (Progression.Hardmode)
            {
                AddItem(ItemID.PhilosophersStone, Utils.UniversalAccessoryCost);
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
                AddItem(ItemID.DepthMeter, Utils.UniversalAccessoryCost);
            }
            if (progression > 1)
            {
                AddItem(ItemID.Compass, Utils.UniversalAccessoryCost);
            }
            if (progression > 2)
            {
                AddItem(ItemID.Stopwatch, Utils.UniversalAccessoryCost);
            }
            if (progression > 3)
            {
                AddItem(ItemID.TallyCounter, Utils.UniversalAccessoryCost);
            }
            if (progression > 4)
            {
                AddItem(ItemID.LifeformAnalyzer, Utils.UniversalAccessoryCost);
            }
            if (progression > 5)
            {
                AddItem(ItemID.DPSMeter, Utils.UniversalAccessoryCost);
            }
            if (progression > 6)
            {
                AddItem(ItemID.MetalDetector, Utils.UniversalAccessoryCost);
            }
            if (progression > 7)
            {
                AddItem(ItemID.Radar, Utils.UniversalAccessoryCost);
            }
            if (progression > 8)
            {
                AddItem(ItemID.Ruler, Utils.UniversalAccessoryCost);
            }
            if (progression > 9)
            {
                AddItem(ItemID.MechanicalLens, Utils.UniversalAccessoryCost);
            }
            if (progression > 10)
            {
                AddItem(ItemID.LaserRuler, Utils.UniversalAccessoryCost);
            }
            return;
        }

        if (shop == "Movement")
        {
            AddItem(ItemID.WaterWalkingBoots, Utils.UniversalAccessoryCost);

            if (progression > 0)
            {
                AddItem(ItemID.HermesBoots, Utils.UniversalAccessoryCost);
            }

            if (progression > 1)
            {
                AddItem(ItemID.CloudinaBottle, Utils.UniversalAccessoryCost);

                AddItem(ItemID.SandstorminaBottle, Utils.UniversalAccessoryCost);

                AddItem(ItemID.TsunamiInABottle, Utils.UniversalAccessoryCost);
            }

            if (progression > 2)
            {
                AddItem(ItemID.Aglet, Utils.UniversalAccessoryCost);
            }

            if (progression > 3)
            {
                AddItem(ItemID.AnkletoftheWind, Utils.UniversalAccessoryCost);
            }

            if (progression > 4)
            {
                AddItem(ItemID.RocketBoots, Utils.UniversalAccessoryCost);
            }

            if (progression > 5)
            {
                AddItem(ItemID.IceSkates, Utils.UniversalAccessoryCost);
            }

            if (progression > 6)
            {
                AddItem(ItemID.Flipper, Utils.UniversalAccessoryCost);
            }

            if (progression > 7)
            {
                AddItem(ItemID.ClimbingClaws, Utils.UniversalAccessoryCost);
            }

            if (progression > 8)
            {
                AddItem(ItemID.ShoeSpikes, Utils.UniversalAccessoryCost);
            }

            if (progression > 9)
            {
                AddItem(ItemID.DivingHelmet, Utils.UniversalAccessoryCost);
            }

            if (progression > 10)
            {
                AddItem(ItemID.ShinyRedBalloon, Utils.UniversalAccessoryCost);
            }

            if (progression > 11)
            {
                AddItem(ItemID.FlyingCarpet, Utils.UniversalAccessoryCost);
            }

            if (progression > 12)
            {
                AddItem(ItemID.LavaCharm, Utils.UniversalAccessoryCost);
            }

            if (progression > 13)
            {
                AddItem(ItemID.LuckyHorseshoe, Utils.UniversalAccessoryCost);
            }

            if (progression > 14)
            {
                AddItem(ItemID.Tabi, Utils.UniversalAccessoryCost);
            }

            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.GoblinTinkerer);
    }
}