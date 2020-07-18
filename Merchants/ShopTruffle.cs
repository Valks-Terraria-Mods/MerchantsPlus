using Terraria.ID;

namespace MerchantsPlus.Merchants
{
    internal class ShopTruffle : Shop
    {
        public ShopTruffle(bool merchant, params string[] shops) : base(merchant, shops)
        {
        }

        public override void OpenShop(string shop)
        {
            base.OpenShop(shop);

            if (shop == "Gear")
            {
                AddItem(ItemID.StrangeGlowingMushroom);
                AddItem(ItemID.MushroomSpear);
                AddItem(ItemID.Hammush);
                AddItem(ItemID.Autohammer);
                return;
            }

            // Default Shop
            Inv.SetupShop(10);
        }
    }
}