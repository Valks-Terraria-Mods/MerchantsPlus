using Terraria.ID;

namespace MerchantsPlus.Merchants
{
    internal class ShopWizard : Shop
    {
        public ShopWizard(bool merchant, params string[] shops) : base(merchant, shops)
        {
        }

        public override void OpenShop(string shop)
        {
            base.OpenShop(shop);

            if (shop == "Gear")
            {
                AddItem(ItemID.IceRod);
                AddItem(ItemID.SpellTome);
                AddItem(ItemID.GreaterManaPotion);
                AddItem(ItemID.MusicBox);
                AddItem(ItemID.Bell);
                AddItem(ItemID.Harp);
                AddItem(ItemID.CrystalBall);
                AddItem(ItemID.EmptyDropper);
                return;
            }

            // Default Shop
            Inv.SetupShop(7);
        }
    }
}