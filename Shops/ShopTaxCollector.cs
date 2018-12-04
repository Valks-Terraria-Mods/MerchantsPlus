using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    class ShopTaxCollector
    {
        private Chest shop;
        private int nextSlot;

        public ShopTaxCollector(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            switch (currentShop) {
                default:
                    break;
            }
        }
    }
}
