using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    internal class ShopWitchDoctor
    {
        private Chest shop;
        private int nextSlot;

        public ShopWitchDoctor(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            switch (currentShop)
            {
                case "Flasks":
                    shop.item[nextSlot++].SetDefaults(ItemID.FlaskofCursedFlames);
                    shop.item[nextSlot++].SetDefaults(ItemID.FlaskofFire);
                    shop.item[nextSlot++].SetDefaults(ItemID.FlaskofGold);
                    shop.item[nextSlot++].SetDefaults(ItemID.FlaskofIchor);
                    shop.item[nextSlot++].SetDefaults(ItemID.FlaskofNanites);
                    shop.item[nextSlot++].SetDefaults(ItemID.FlaskofParty);
                    shop.item[nextSlot++].SetDefaults(ItemID.FlaskofPoison);
                    shop.item[nextSlot++].SetDefaults(ItemID.FlaskofVenom);
                    break;

                case "Gear":
                    shop.item[nextSlot++].SetDefaults(ItemID.HerculesBeetle);
                    shop.item[nextSlot++].SetDefaults(ItemID.NecromanticScroll);
                    shop.item[nextSlot++].SetDefaults(ItemID.PygmyNecklace);
                    break;

                default:
                    shop.SetupShop(16);
                    break;
            }
        }
    }
}