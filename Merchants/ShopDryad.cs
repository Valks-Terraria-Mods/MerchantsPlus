using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Merchants
{
    internal class ShopDryad : Shop
    {
        public ShopDryad(bool merchant, params string[] shops) : base(merchant, shops)
        {
        }

        public override void OpenShop(string shop)
        {
            base.OpenShop(shop);

            if (shop == "Potions")
            {
                AddItem(ItemID.CalmingPotion, Utils.UniversalPotionCost);
                AddItem(ItemID.FeatherfallPotion, Utils.UniversalPotionCost);
                return;
            }

            if (shop == "Seeds")
            {
                AddItem(ItemID.GrassSeeds);
                AddItem(ItemID.CorruptSeeds);
                AddItem(ItemID.HallowedSeeds);
                AddItem(ItemID.MushroomGrassSeeds);
                AddItem(ItemID.CrimsonSeeds);
                AddItem(ItemID.BlinkrootSeeds);
                AddItem(ItemID.DaybloomSeeds);
                AddItem(ItemID.DeathweedSeeds);
                AddItem(ItemID.FireblossomSeeds);
                AddItem(ItemID.MoonglowSeeds);
                AddItem(ItemID.WaterleafSeeds);
                AddItem(ItemID.ShiverthornSeeds);
                return;
            }

            // Default Shop
            Inv.SetupShop(3);
        }
    }
}