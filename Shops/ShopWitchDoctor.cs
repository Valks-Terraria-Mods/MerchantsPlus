using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    internal class ShopWitchDoctor : Shop
    {
        public ShopWitchDoctor(bool merchant, params string[] shops) : base(merchant, shops)
        {
        }

        public override void OpenShop(string shop)
        {
            base.OpenShop(shop);

            if (shop == "Flasks")
            {
                AddItem(ItemID.FlaskofCursedFlames);
                AddItem(ItemID.FlaskofFire);
                AddItem(ItemID.FlaskofGold);
                AddItem(ItemID.FlaskofIchor);
                AddItem(ItemID.FlaskofNanites);
                AddItem(ItemID.FlaskofParty);
                AddItem(ItemID.FlaskofPoison);
                AddItem(ItemID.FlaskofVenom);
                return;
            }

            if (shop == "Gear")
            {
                AddItem(ItemID.HerculesBeetle);
                AddItem(ItemID.NecromanticScroll);
                AddItem(ItemID.PygmyNecklace);
                return;
            }

            // Default Shop
            Inv.SetupShop(16);
        }
    }
}