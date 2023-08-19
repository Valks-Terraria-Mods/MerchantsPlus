using Terraria.ID;

namespace MerchantsPlus.Merchants;

internal class ShopTruffle : Shop
{
    public ShopTruffle(params string[] shops) : base(shops)
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