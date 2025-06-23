namespace MerchantsPlus.Shops;

public class ShopDryad : Shop
{
    public override List<string> Shops { get; } = ["Seeds"];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Seeds")
        {
            AddItem(ItemID.GrassSeeds, ItemCosts.Seeds);
            AddItem(ItemID.CorruptSeeds, ItemCosts.Seeds);
            AddItem(ItemID.HallowedSeeds, ItemCosts.Seeds);
            AddItem(ItemID.MushroomGrassSeeds, ItemCosts.Seeds);
            AddItem(ItemID.CrimsonSeeds, ItemCosts.Seeds);
            AddItem(ItemID.BlinkrootSeeds, ItemCosts.Seeds);
            AddItem(ItemID.DaybloomSeeds, ItemCosts.Seeds);
            AddItem(ItemID.DeathweedSeeds, ItemCosts.Seeds);
            AddItem(ItemID.FireblossomSeeds, ItemCosts.Seeds);
            AddItem(ItemID.MoonglowSeeds, ItemCosts.Seeds);
            AddItem(ItemID.WaterleafSeeds, ItemCosts.Seeds);
            AddItem(ItemID.ShiverthornSeeds, ItemCosts.Seeds);

            if (!WorldGen.crimson)
            {
                AddItem(ItemID.VilePowder, ItemCosts.Seeds);
            }
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.Dryad);
    }
}