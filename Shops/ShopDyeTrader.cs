using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    internal class ShopDyeTrader
    {
        private Chest shop;
        private int nextSlot;

        public ShopDyeTrader(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            switch (currentShop)
            {
                case "Color":
                    shop.item[nextSlot++].SetDefaults(ItemID.DyeVat);
                    shop.item[nextSlot++].SetDefaults(ItemID.SilverDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.TeamDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.BrownDye);
                    if (NPC.downedSlimeKing)
                    {
                        if (Utils.Kills(NPCID.BlueSlime) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightBlueDye);
                        if (Utils.Kills(NPCID.BlueSlime) > 10) shop.item[nextSlot++].SetDefaults(ItemID.BlueDye);
                        if (Utils.Kills(NPCID.Harpy) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightSkyBlueDye);
                        if (Utils.Kills(NPCID.Harpy) > 10) shop.item[nextSlot++].SetDefaults(ItemID.SkyBlueDye);
                    }

                    if (NPC.downedBoss1)
                    { //eye
                        if (Utils.Kills(NPCID.RedSlime) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightRedDye);
                        if (Utils.Kills(NPCID.RedSlime) > 10) shop.item[nextSlot++].SetDefaults(ItemID.RedDye);
                        if (Utils.Kills(NPCID.PinkJellyfish) > 10) shop.item[nextSlot++].SetDefaults(ItemID.BrightPinkDye);
                        if (Utils.Kills(NPCID.Pinky) > 1) shop.item[nextSlot++].SetDefaults(ItemID.PinkDye);
                        if (Utils.Kills(NPCID.PurpleSlime) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightPurpleDye);
                        if (Utils.Kills(NPCID.PurpleSlime) > 10) shop.item[nextSlot++].SetDefaults(ItemID.PurpleDye);
                        if (Utils.Kills(NPCID.DemonEye) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightVioletDye);
                        if (Utils.Kills(NPCID.DemonEye) > 10) shop.item[nextSlot++].SetDefaults(ItemID.VioletDye);
                        if (Utils.Kills(NPCID.Zombie) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BlackDye);
                    }

                    if (NPC.downedBoss2)
                    { // brain / worm
                        if (Utils.Kills(NPCID.EaterofSouls) > 20 || (Utils.Kills(NPCID.BloodCrawler) > 20)) shop.item[nextSlot++].SetDefaults(ItemID.BrightGreenDye);
                        if (Utils.Kills(NPCID.EaterofSouls) > 10 || (Utils.Kills(NPCID.BloodCrawler) > 10)) shop.item[nextSlot++].SetDefaults(ItemID.GreenDye);
                        if (Utils.Kills(NPCID.DevourerBody) > 20 || (Utils.Kills(NPCID.FaceMonster) > 20)) shop.item[nextSlot++].SetDefaults(ItemID.BrightLimeDye);
                        if (Utils.Kills(NPCID.DevourerBody) > 10 || (Utils.Kills(NPCID.FaceMonster) > 10)) shop.item[nextSlot++].SetDefaults(ItemID.LimeDye);
                    }

                    if (NPC.downedQueenBee)
                    {
                        if (Utils.Kills(NPCID.AngryTrapper) > 10) shop.item[nextSlot++].SetDefaults(ItemID.BrightCyanDye);
                        if (Utils.Kills(NPCID.AngryTrapper) > 5) shop.item[nextSlot++].SetDefaults(ItemID.CyanDye);
                        if (Utils.Kills(NPCID.JungleSlime) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightTealDye);
                        if (Utils.Kills(NPCID.JungleSlime) > 10) shop.item[nextSlot++].SetDefaults(ItemID.TealDye);
                        if (Utils.Kills(NPCID.Hornet) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightYellowDye);
                        if (Utils.Kills(NPCID.Hornet) > 10) shop.item[nextSlot++].SetDefaults(ItemID.YellowDye);
                        if (Utils.Kills(NPCID.JungleBat) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightOrangeDye);
                        if (Utils.Kills(NPCID.JungleBat) > 10) shop.item[nextSlot++].SetDefaults(ItemID.OrangeDye);
                    }

                    if (NPC.downedBoss3)
                    { // skeletron
                        if (Utils.Kills(NPCID.AngryBones) > 10) shop.item[nextSlot++].SetDefaults(ItemID.PurpleOozeDye);
                        if (Utils.Kills(NPCID.DarkCaster) > 10) shop.item[nextSlot++].SetDefaults(ItemID.ReflectiveMetalDye);
                        if (Utils.Kills(NPCID.CursedSkull) > 10) shop.item[nextSlot++].SetDefaults(ItemID.ShadowDye);
                        if (Utils.Kills(NPCID.DungeonSlime) > 10) shop.item[nextSlot++].SetDefaults(ItemID.StardustDye);
                        if (Utils.Kills(NPCID.AngryBones) > 20) shop.item[nextSlot++].SetDefaults(ItemID.GrimDye);
                        if (Utils.Kills(NPCID.DarkCaster) > 20) shop.item[nextSlot++].SetDefaults(ItemID.HadesDye);
                        if (Utils.Kills(NPCID.CursedSkull) > 20) shop.item[nextSlot++].SetDefaults(ItemID.LivingFlameDye);
                        if (Utils.Kills(NPCID.DungeonSlime) > 20) shop.item[nextSlot++].SetDefaults(ItemID.MartianArmorDye);
                    }

                    if (Main.hardMode)
                    {
                        if (Utils.Kills(NPCID.PossessedArmor) > 10) shop.item[nextSlot++].SetDefaults(ItemID.ShadowflameHadesDye);
                        if (Utils.Kills(NPCID.WanderingEye) > 10) shop.item[nextSlot++].SetDefaults(ItemID.PhaseDye);
                        if (Utils.Kills(NPCID.Wraith) > 10) shop.item[nextSlot++].SetDefaults(ItemID.TwilightDye);
                    }
                    break;

                default:
                    shop.SetupShop(12);
                    break;
            }
        }
    }
}