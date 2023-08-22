namespace MerchantsPlus.Merchants;

internal class ShopDryad : Shop
{
    public override string[] Shops => new string[] { "Seeds", "Potions" };

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
            AddItem(ItemID.GrassSeeds, Utils.UniversalSeedCost);
            AddItem(ItemID.CorruptSeeds, Utils.UniversalSeedCost);
            AddItem(ItemID.HallowedSeeds, Utils.UniversalSeedCost);
            AddItem(ItemID.MushroomGrassSeeds, Utils.UniversalSeedCost);
            AddItem(ItemID.CrimsonSeeds, Utils.UniversalSeedCost);
            AddItem(ItemID.BlinkrootSeeds, Utils.UniversalSeedCost);
            AddItem(ItemID.DaybloomSeeds, Utils.UniversalSeedCost);
            AddItem(ItemID.DeathweedSeeds, Utils.UniversalSeedCost);
            AddItem(ItemID.FireblossomSeeds, Utils.UniversalSeedCost);
            AddItem(ItemID.MoonglowSeeds, Utils.UniversalSeedCost);
            AddItem(ItemID.WaterleafSeeds, Utils.UniversalSeedCost);
            AddItem(ItemID.ShiverthornSeeds, Utils.UniversalSeedCost);
            return;
        }

        // Default Shop
        Inv.SetupShop(3);
    }
}