﻿namespace MerchantsPlus.Shops;

public class ShopTruffle : Shop
{
    public override string[] Shops => ["Gear"];

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