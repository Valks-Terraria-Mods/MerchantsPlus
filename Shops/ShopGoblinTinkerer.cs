using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    internal class ShopGoblinTinkerer : Shop
    {
        public ShopGoblinTinkerer(bool merchant, params string[] shops) : base(merchant, shops)
        {
        }

        public override void OpenShop(string shop)
        {
            base.OpenShop(shop);

            int progression = Utils.Progression();

            if (shop == "Miscellaneous")
            {
                AddItem(ItemID.FlowerBoots, Utils.UniversalAccessoryCost);
                

                if (NPC.downedPirates)
                {
                    AddItem(ItemID.GoldRing, Utils.UniversalAccessoryCost);
                    
                    AddItem(ItemID.DiscountCard, Utils.UniversalAccessoryCost);
                    
                    AddItem(ItemID.LuckyCoin, Utils.UniversalAccessoryCost);
                    
                }

                if (Utils.MultiKills(new short[] { NPCID.BlueJellyfish, NPCID.PinkJellyfish, NPCID.GreenJellyfish }) > 100)
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
                if (NPC.downedSlimeKing) { AddItem(ItemID.RoyalGel, Utils.UniversalAccessoryCost);  }
                if (NPC.downedBoss1) { AddItem(ItemID.EoCShield, Utils.UniversalAccessoryCost);  }
                if (NPC.downedBoss2)
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
                if (NPC.downedQueenBee)
                {
                    AddItem(ItemID.HiveBackpack, Utils.UniversalAccessoryCost);
                    
                }
                if (NPC.downedPlantBoss)
                {
                    AddItem(ItemID.SporeSac, Utils.UniversalAccessoryCost);
                    
                }
                if (NPC.downedGolemBoss)
                {
                    AddItem(ItemID.ShinyStone, Utils.UniversalAccessoryCost);
                    
                }
                if (NPC.downedMoonlord)
                {
                    AddItem(ItemID.GravityGlobe, Utils.UniversalAccessoryCost);
                    
                }
                return;
            }

            if (shop == "Defensive")
            {
                if (NPC.downedBoss3)
                {
                    AddItem(ItemID.CobaltShield, Utils.UniversalAccessoryCost);
                    
                }
                if (Utils.Kills(NPCID.Zombie) > 100)
                {
                    AddItem(ItemID.Shackle, Utils.UniversalAccessoryCost);
                    
                }
                if (Utils.Kills(NPCID.BigMimicCrimson) > 0)
                {
                    AddItem(ItemID.FleshKnuckles, Utils.UniversalAccessoryCost);
                    
                }
                if (Utils.Kills(NPCID.IceTortoise) > 0)
                {
                    AddItem(ItemID.FrozenTurtleShell, Utils.UniversalAccessoryCost);
                    
                }

                return;
            }

            if (shop == "Immunity")
            {
                if (Main.hardMode)
                {
                    AddItem(ItemID.HandWarmer, Utils.UniversalAccessoryCost);
                    

                    if (Utils.MultiKills(new short[] { NPCID.RustyArmoredBonesAxe, NPCID.Werewolf, NPCID.AnglerFish }) > 0)
                    {
                        AddItem(ItemID.AdhesiveBandage, Utils.UniversalAccessoryCost);
                        
                    }
                    if (Utils.MultiKills(new short[] { NPCID.ArmoredSkeleton, NPCID.BlueArmoredBones }) > 0)
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

                    if (Utils.MultiKills(new short[] { NPCID.Pixie, NPCID.DarkMummy }) > 0)
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

                    if (Main.hardMode)
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

                if (progression > (int)Utils.Progress.BRAIN_OF_CTHULU)
                {
                    AddItem(ItemID.PanicNecklace, Utils.UniversalAccessoryCost);
                    
                }

                if (progression > (int)Utils.Progress.QUEEN_BEE)
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

                if (progression > (int)Utils.Progress.PLANT_BOSS)
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
                    
                }

                if (progression > 21)
                {
                    AddItem(ItemID.SquireShield, Utils.UniversalAccessoryCost);
                    
                }

                if (progression > 22)
                {
                    AddItem(ItemID.HuntressBuckler, Utils.UniversalAccessoryCost);
                    
                }

                if (progression > 23)
                {
                    AddItem(ItemID.MonkBelt, Utils.UniversalAccessoryCost);
                    
                }

                if (progression > 24)
                {
                    AddItem(ItemID.TitanGlove, Utils.UniversalAccessoryCost);
                    
                }

                return;
            }

            if (shop == "Health and Mana")
            {
                AddItem(ItemID.NaturesGift, Utils.UniversalAccessoryCost);
                
                if (NPC.downedBoss2)
                {
                    AddItem(ItemID.BandofStarpower, Utils.UniversalAccessoryCost);
                    
                    AddItem(ItemID.BandofRegeneration, Utils.UniversalAccessoryCost);
                    
                }
                if (progression > 4)
                {
                    AddItem(ItemID.CelestialMagnet, Utils.UniversalAccessoryCost);
                    
                }
                if (Main.hardMode)
                {
                    AddItem(ItemID.PhilosophersStone, Utils.UniversalAccessoryCost);
                    
                }

                return;
            }

            if (shop == "Informational")
            {
                if (WorldGen.goldBar > 0) AddItem(ItemID.GoldWatch); else AddItem(ItemID.PlatinumWatch);
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
            Inv.SetupShop(6);
        }
    }
}