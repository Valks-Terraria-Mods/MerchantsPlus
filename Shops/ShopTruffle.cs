using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    internal class ShopTruffle
    {
        private Chest shop;
        private int nextSlot;

        public ShopTruffle(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            switch (currentShop)
            {
                case "Gear":
                    shop.item[nextSlot++].SetDefaults(ItemID.StrangeGlowingMushroom);
                    shop.item[nextSlot++].SetDefaults(ItemID.MushroomSpear);
                    shop.item[nextSlot++].SetDefaults(ItemID.Hammush);
                    shop.item[nextSlot++].SetDefaults(ItemID.Autohammer);
                    break;

                default:
                    shop.SetupShop(10);
                    break;
            }
        }
    }
}