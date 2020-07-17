using Terraria;

namespace MerchantsPlus.Shops
{
    internal class ShopTaxCollector
    {
        private readonly Chest shop;
        private readonly int nextSlot;

        public ShopTaxCollector(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            switch (currentShop)
            {
                default:
                    break;
            }
        }
    }
}