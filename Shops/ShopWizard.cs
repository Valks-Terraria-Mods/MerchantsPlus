using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    internal class ShopWizard
    {
        private Chest shop;
        private int nextSlot;

        public ShopWizard(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            switch (currentShop)
            {
                case "Gear":
                    shop.item[nextSlot++].SetDefaults(ItemID.IceRod);
                    shop.item[nextSlot++].SetDefaults(ItemID.SpellTome);
                    shop.item[nextSlot++].SetDefaults(ItemID.GreaterManaPotion);
                    shop.item[nextSlot++].SetDefaults(ItemID.MusicBox);
                    shop.item[nextSlot++].SetDefaults(ItemID.Bell);
                    shop.item[nextSlot++].SetDefaults(ItemID.Harp);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrystalBall);
                    shop.item[nextSlot++].SetDefaults(ItemID.EmptyDropper);
                    break;

                default:
                    shop.SetupShop(7);
                    break;
            }
        }
    }
}