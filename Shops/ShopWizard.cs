namespace MerchantsPlus.Shops;

public class ShopWizard : Shop
{
    public override List<string> Shops { get; } = ["Gear"];

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
        Inv.SetupShop(ShopType.Wizard);
    }
}