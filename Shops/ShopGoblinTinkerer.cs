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
                case "Calamity Special":
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
                    break;
                case "Miscellaneous":
                    if (NPC.downedPirates)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.GoldRing);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.DiscountCard);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.LuckyCoin);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    shop.item[nextSlot].SetDefaults(ItemID.FlowerBoots);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    if (Utils.multiKills(new short[] { NPCID.BlueJellyfish, NPCID.PinkJellyfish, NPCID.GreenJellyfish }) > 100)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.JellyfishNecklace);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (NPC.downedMechBoss1)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.NeptunesShell);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    break;
                case "Special":
                    if (NPC.downedSlimeKing) { shop.item[nextSlot].SetDefaults(ItemID.RoyalGel); shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost; }
                    if (NPC.downedBoss1) { shop.item[nextSlot].SetDefaults(ItemID.EoCShield); shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost; }
                    if (NPC.downedBoss2)
                    {
                        if (WorldGen.crimson)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.BrainOfConfusion);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }
                        else
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.WormScarf);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }
                    }
                    if (NPC.downedQueenBee)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.HiveBackpack);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (NPC.downedPlantBoss)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SporeSac);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (NPC.downedGolemBoss)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ShinyStone);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (NPC.downedMoonlord)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.GravityGlobe);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    break;
                case "Defensive":
                    if (NPC.downedBoss3)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.CobaltShield);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (Utils.kills(NPCID.Zombie) > 100)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.Shackle);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (Utils.kills(NPCID.BigMimicCrimson) > 0)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.FleshKnuckles);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (Utils.kills(NPCID.IceTortoise) > 0)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.FrozenTurtleShell);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    break;
                case "Immunity":
                    if (Main.hardMode)
                    {
                        if (Utils.multiKills(new short[] { NPCID.RustyArmoredBonesAxe, NPCID.Werewolf, NPCID.AnglerFish }) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.AdhesiveBandage);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }
                        if (Utils.multiKills(new short[] { NPCID.ArmoredSkeleton, NPCID.BlueArmoredBones }) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.ArmorPolish);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }
                        if (Utils.kills(NPCID.ToxicSludge) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.Bezoar);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }
                        if (Utils.kills(NPCID.CorruptSlime) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.Blindfold);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }

                        if (Utils.multiKills(new short[] { NPCID.Pixie, NPCID.DarkMummy }) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.Megaphone);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }
                        if (Utils.kills(NPCID.Mimic) > 2)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.CrossNecklace);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }
                        if (Utils.kills(NPCID.Pixie) > 10)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.FastClock);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }
                        shop.item[nextSlot].SetDefaults(ItemID.HandWarmer);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        if (Main.hardMode)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.ObsidianRose);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }

                        if (Utils.kills(NPCID.Medusa) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.PocketMirror);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }


                        if (Utils.kills(NPCID.LightMummy) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.TrifoldMap);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }

                        if (Utils.kills(NPCID.Corruptor) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.Vitamins);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }
                        if (Utils.kills(NPCID.CursedSkull) > 0)
                        {
                            shop.item[nextSlot].SetDefaults(ItemID.Nazar);
                            shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        }
                    }
                    break;
                case "Combat":
                    if (NPC.downedBoss2)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PanicNecklace);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (NPC.downedPlantBoss)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.BlackBelt);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (NPC.downedQueenBee)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.HoneyComb);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }

                    if (NPC.downedMechBoss1)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.MoonCharm);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;

                        shop.item[nextSlot].SetDefaults(ItemID.FeralClaws);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.MagmaStone);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.EyeoftheGolem);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.MoonStone);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.MagicQuiver);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }

                    if (NPC.downedMechBoss2)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PaladinsShield);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.PutridScent);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.SharkToothNecklace);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.StarCloak);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.SunStone);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.TitanGlove);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }


                    if (NPC.downedMechBoss3)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ApprenticeScarf);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.SquireShield);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.HuntressBuckler);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.MonkBelt);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.HerculesBeetle);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.NecromanticScroll);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.PygmyNecklace);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }

                    break;
                case "Health and Mana":
                    if (NPC.downedBoss2)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.BandofStarpower);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.BandofRegeneration);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.CelestialMagnet);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.NaturesGift);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;

                    }
                    if (Main.hardMode)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PhilosophersStone);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    break;
                case "Informational":
                    if (WorldGen.goldBar > 0) shop.item[nextSlot].SetDefaults(ItemID.GoldWatch); else shop.item[nextSlot].SetDefaults(ItemID.PlatinumWatch);
                    shop.item[nextSlot].SetDefaults(ItemID.DepthMeter);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.Compass);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.Ruler);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.MetalDetector);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.Stopwatch);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.DPSMeter);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.TallyCounter);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.LifeformAnalyzer);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.Radar);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.MechanicalLens);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    shop.item[nextSlot].SetDefaults(ItemID.LaserRuler);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    break;
                case "Movement":
                    if (NPC.downedBoss1)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.HermesBoots);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.WaterWalkingBoots);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.IceSkates);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (NPC.downedBoss2)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.RocketBoots);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.CloudinaBottle);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.SandstorminaBottle);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.TsunamiInABottle);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (NPC.downedBoss3)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.Aglet);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.ClimbingClaws);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.AnkletoftheWind);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.Flipper);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.ShoeSpikes);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.FlyingCarpet);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.DivingHelmet);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.ShinyRedBalloon);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.LuckyHorseshoe);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                        shop.item[nextSlot].SetDefaults(ItemID.LavaCharm);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    if (NPC.downedPlantBoss)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.Tabi);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalAccessoryCost;
                    }
                    break;
                default:
                    shop.SetupShop(6);
                    break;
            }
        }
    }
}
