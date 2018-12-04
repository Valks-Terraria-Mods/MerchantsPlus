using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    class ShopSkeletonMerchant
    {
        private Chest shop;
        private int nextSlot;

        public ShopSkeletonMerchant(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            switch (currentShop)
            {
                case "Music Boxes":
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxAltOverworldDay);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxAltUnderground);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxBoss1);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxBoss2);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxBoss3);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxBoss4);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxBoss5);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxCorruption);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxCrimson);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxDD2);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxDesert);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxDungeon);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxEclipse);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxEerie);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxFrostMoon);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxGoblins);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxIce);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxJungle);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxLunarBoss);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxMartians);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxMushrooms);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxNight);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxOcean);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxOverworldDay);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxPlantera);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxPumpkinMoon);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxRain);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxSandstorm);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxSnow);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxSpace);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxTemple);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxTheHallow);
                    break;
                case "Gear":
                    shop.item[nextSlot++].SetDefaults(ItemID.PinkString);
                    shop.item[nextSlot++].SetDefaults(ItemID.PurpleCounterweight);
                    shop.item[nextSlot++].SetDefaults(ItemID.YoYoGlove);
                    if (Main.hardMode)
                    {
                        if (Utils.kills(NPCID.WyvernHead) > 0) shop.item[nextSlot++].SetDefaults(ItemID.SoulofFlight);
                        if (NPC.downedMechBoss3) shop.item[nextSlot++].SetDefaults(ItemID.SoulofFright);
                        if (Utils.kills(NPCID.IlluminantSlime) > 0) shop.item[nextSlot++].SetDefaults(ItemID.SoulofLight);
                        if (NPC.downedMechBoss2) shop.item[nextSlot++].SetDefaults(ItemID.SoulofMight);
                        if (Utils.kills(NPCID.Clinger) > 0 || Utils.kills(NPCID.IchorSticker) > 0) shop.item[nextSlot++].SetDefaults(ItemID.SoulofNight);
                        if (NPC.downedMechBoss1) shop.item[nextSlot++].SetDefaults(ItemID.SoulofSight);
                        shop.item[nextSlot].SetDefaults(ItemID.RagePotion);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    }
                    break;
                default:
                    shop.SetupShop(20);
                    break;
            }
        }
    }
}
