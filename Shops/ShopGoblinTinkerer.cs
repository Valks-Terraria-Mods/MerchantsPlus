using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.Shops
{
    class ShopGoblinTinkerer
    {
        private Chest shop;
        private int nextSlot;

        public ShopGoblinTinkerer(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            switch (currentShop)
            {
                //case "Calamity Special":
                    //if (MerchantsPlus.calamityLoaded)
                    //{
                        /*Mod calamity = ModLoader.GetMod("CalamityMod");
                        if (Utils.CalamityDownedCrabulon) shop.item[nextSlot++].SetDefaults(calamity.ItemType("FungalClump"));
                        if (Utils.CalamityDownedDesertScourge) shop.item[nextSlot++].SetDefaults(calamity.ItemType("OceanCrest"));
                        if (Utils.CalamityDownedPerforators) shop.item[nextSlot++].SetDefaults(calamity.ItemType("BloodyWormTooth"));
                        if (Utils.CalamityDownedHiveMind) shop.item[nextSlot++].SetDefaults(calamity.ItemType("RottenBrain"));
                        if (Utils.CalamityDownedSlimeGod) shop.item[nextSlot++].SetDefaults(calamity.ItemType("ManaOverloader"));
                        if (Utils.CalamityDownedCryogen) shop.item[nextSlot++].SetDefaults(calamity.ItemType("SoulofCryogen"));
                        if (Utils.CalamityDownedCryogen) shop.item[nextSlot++].SetDefaults(calamity.ItemType("FrostFlare"));
                        if (Utils.CalamityDownedBrimstoneElemental) shop.item[nextSlot++].SetDefaults(calamity.ItemType("Gehenna"));
                        if (Utils.CalamityDownedAquaticScourge) shop.item[nextSlot++].SetDefaults(calamity.ItemType("AquaticEmblem"));
                        if (Utils.CalamityDownedLeviathan) shop.item[nextSlot++].SetDefaults(calamity.ItemType("LeviathanAmbergris"));
                        if (Utils.CalamityDownedLeviathan) shop.item[nextSlot++].SetDefaults(calamity.ItemType("SirensHeart"));
                        if (Utils.CalamityDownedPlaguebringer) shop.item[nextSlot++].SetDefaults(calamity.ItemType("ToxicHeart"));
                        if (Utils.CalamityDownedProvidence) shop.item[nextSlot++].SetDefaults(calamity.ItemType("BloodflareCore"));
                        if (Utils.CalamityDownedPolterghast) shop.item[nextSlot++].SetDefaults(calamity.ItemType("Affliction"));
                        if (Utils.CalamityDownedYharon) shop.item[nextSlot++].SetDefaults(calamity.ItemType("YharimsGift"));*/
                        //if (NPC.downedBoss1) shop.item[nextSlot++].SetDefaults(calamity.ItemType("CounterScarf"));
                        //if (NPC.downedSlimeKing) shop.item[nextSlot++].SetDefaults(calamity.ItemType("CrownJewel"));
                        
                        /*shop.item[nextSlot++].SetDefaults(calamity.ItemType("HeartofDarkness"));
                        shop.item[nextSlot++].SetDefaults(calamity.ItemType("Laudanum"));
                        shop.item[nextSlot++].SetDefaults(calamity.ItemType("StressPills"));*/
                    //}
                    //break;
                case "Miscellaneous":
                    if (NPC.downedPirates)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.GoldRing);
                        shop.item[nextSlot].SetDefaults(ItemID.DiscountCard);
                        shop.item[nextSlot].SetDefaults(ItemID.LuckyCoin);
                    }
                    shop.item[nextSlot].SetDefaults(ItemID.FlowerBoots);
                    if (Utils.multiKills(new short[] { NPCID.BlueJellyfish, NPCID.PinkJellyfish, NPCID.GreenJellyfish }) > 100)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.JellyfishNecklace);
                    }
                    if (NPC.downedMechBoss1)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.NeptunesShell);
                    }
                    break;
                case "Special":
                    if (NPC.downedSlimeKing) { shop.item[nextSlot].SetDefaults(ItemID.RoyalGel); }
                    if (NPC.downedBoss1) { shop.item[nextSlot].SetDefaults(ItemID.EoCShield); }
                    if (NPC.downedBoss2)
                    {
                        if (WorldGen.crimson)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.BrainOfConfusion);
                        }
                        else
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.WormScarf);
                        }
                    }
                    if (NPC.downedQueenBee)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.HiveBackpack);
                    }
                    if (NPC.downedPlantBoss)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SporeSac);
                    }
                    if (NPC.downedGolemBoss)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ShinyStone);
                    }
                    if (NPC.downedMoonlord)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.GravityGlobe);
                    }
                    break;
                case "Defensive":
                    if (NPC.downedBoss3)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.CobaltShield);
                    }
                    if (Utils.kills(NPCID.Zombie) > 100)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.Shackle);
                    }
                    if (Utils.kills(NPCID.BigMimicCrimson) > 0)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.FleshKnuckles);
                    }
                    if (Utils.kills(NPCID.IceTortoise) > 0)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.FrozenTurtleShell);
                    }
                    break;
                case "Immunity":
                    if (Main.hardMode)
                    {
                        if (Utils.multiKills(new short[] { NPCID.RustyArmoredBonesAxe, NPCID.Werewolf, NPCID.AnglerFish }) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.AdhesiveBandage);
                        }
                        if (Utils.multiKills(new short[] { NPCID.ArmoredSkeleton, NPCID.BlueArmoredBones }) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.ArmorPolish);
                        }
                        if (Utils.kills(NPCID.ToxicSludge) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.Bezoar);
                        }
                        if (Utils.kills(NPCID.CorruptSlime) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.Blindfold);
                        }

                        if (Utils.multiKills(new short[] { NPCID.Pixie, NPCID.DarkMummy }) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.Megaphone);
                        }
                        if (Utils.kills(NPCID.Mimic) > 2)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.CrossNecklace);
                        }
                        if (Utils.kills(NPCID.Pixie) > 10)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.FastClock);
                        }
                        shop.item[nextSlot].SetDefaults(ItemID.HandWarmer);
                        if (Main.hardMode)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.ObsidianRose);
                        }

                        if (Utils.kills(NPCID.Medusa) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.PocketMirror);
                        }


                        if (Utils.kills(NPCID.LightMummy) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.TrifoldMap);
                        }

                        if (Utils.kills(NPCID.Corruptor) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.Vitamins);
                        }
                        if (Utils.kills(NPCID.CursedSkull) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.Nazar);
                        }
                    }
                    break;
                case "Combat":
                    if (NPC.downedBoss2)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PanicNecklace);
                    }
                    if (NPC.downedPlantBoss)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.BlackBelt);
                    }
                    if (NPC.downedQueenBee)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.HoneyComb);
                    }

                    if (NPC.downedMechBoss1)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.MoonCharm);

                        shop.item[nextSlot].SetDefaults(ItemID.FeralClaws);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.MagmaStone);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.EyeoftheGolem);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.MoonStone);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.MagicQuiver);
                    }

                    if (NPC.downedMechBoss2)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PaladinsShield);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.PutridScent);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.SharkToothNecklace);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.StarCloak);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.SunStone);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.TitanGlove);
                        
                    }


                    if (NPC.downedMechBoss3)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ApprenticeScarf);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.SquireShield);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.HuntressBuckler);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.MonkBelt);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.HerculesBeetle);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.NecromanticScroll);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.PygmyNecklace);
                        
                    }

                    break;
                case "Health and Mana":
                    if (NPC.downedBoss2)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.BandofStarpower);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.BandofRegeneration);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.CelestialMagnet);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.NaturesGift);
                        

                    }
                    if (Main.hardMode)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PhilosophersStone);
                        
                    }
                    break;
                case "Informational":
                    if (WorldGen.goldBar > 0) shop.item[nextSlot].SetDefaults(ItemID.GoldWatch); else shop.item[nextSlot].SetDefaults(ItemID.PlatinumWatch);
                    shop.item[nextSlot].SetDefaults(ItemID.DepthMeter);
                    
                    shop.item[nextSlot].SetDefaults(ItemID.Compass);
                    
                    shop.item[nextSlot].SetDefaults(ItemID.Ruler);
                    
                    shop.item[nextSlot].SetDefaults(ItemID.MetalDetector);
                    
                    shop.item[nextSlot].SetDefaults(ItemID.Stopwatch);
                    
                    shop.item[nextSlot].SetDefaults(ItemID.DPSMeter);
                    
                    shop.item[nextSlot].SetDefaults(ItemID.TallyCounter);
                    
                    shop.item[nextSlot].SetDefaults(ItemID.LifeformAnalyzer);
                    
                    shop.item[nextSlot].SetDefaults(ItemID.Radar);
                    
                    shop.item[nextSlot].SetDefaults(ItemID.MechanicalLens);
                    
                    shop.item[nextSlot].SetDefaults(ItemID.LaserRuler);
                    
                    break;
                case "Movement":
                    if (NPC.downedBoss1)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.HermesBoots);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.WaterWalkingBoots);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.IceSkates);
                        
                    }
                    if (NPC.downedBoss2)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.RocketBoots);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.CloudinaBottle);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.SandstorminaBottle);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.TsunamiInABottle);
                        
                    }
                    if (NPC.downedBoss3)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.Aglet);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.ClimbingClaws);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.AnkletoftheWind);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.Flipper);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.ShoeSpikes);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.FlyingCarpet);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.DivingHelmet);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.ShinyRedBalloon);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.LuckyHorseshoe);
                        
                        shop.item[nextSlot].SetDefaults(ItemID.LavaCharm);
                        
                    }
                    if (NPC.downedPlantBoss)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.Tabi);
                        
                    }
                    break;
                default:
                    shop.SetupShop(6);
                    break;
            }
        }
    }
}
