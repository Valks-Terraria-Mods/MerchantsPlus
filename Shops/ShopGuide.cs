using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    class ShopGuide
    {
        private Chest shop;
        private int nextSlot;

        public ShopGuide(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            switch (currentShop)
            {
                case "Msc":
                    shop.item[nextSlot++].SetDefaults(ItemID.Cannon);
                    shop.item[nextSlot++].SetDefaults(ItemID.Cannonball);
                    break;
                default:
                    shop.item[nextSlot++].SetDefaults(ItemID.CordageGuide);
                    if (Utils.isNPCHere(NPCID.Merchant))
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.Torch);
                        shop.item[nextSlot++].SetDefaults(ItemID.WoodenArrow);
                    }
                    if (Utils.isNPCHere(NPCID.ArmsDealer)) shop.item[nextSlot++].SetDefaults(ItemID.MusketBall);
                    if (NPC.downedBoss3 && !Main.hardMode)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ObsidianSkinPotion);
                        shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                        shop.item[nextSlot++].SetDefaults(ItemID.GuideVoodooDoll);
                    }
                    break;
            }
        }
    }
}
