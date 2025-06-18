using Magic = MerchantsPlus.ModDefs.MagicStorage;

namespace MerchantsPlus.Shops;

public class ShopGolem : Shop
{
    public override string[] Shops => ["Storage"];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        switch (shop)
        {
            case "Storage":
                AddItem(Magic.StorageHeart, Coins.Silver());
                AddItem(Magic.CraftingAccess, Coins.Silver());
                AddItem(Magic.StorageAccess, Coins.Silver());
                AddItem(Magic.StorageUnitTiny, Coins.Silver());
                AddItem(Magic.StorageUnit, Coins.Silver());

                if (Progression.Level() >= 1)
                {
                    if (WorldGen.crimson)
                    {
                        AddItem(Magic.UpgradeCrimtane, Coins.Silver(3));
                        AddItem(Magic.StorageUnitCrimtane, Coins.Silver(3));
                    }
                    else
                    {
                        AddItem(Magic.UpgradeDemonite, Coins.Silver(3));
                        AddItem(Magic.StorageUnitDemonite, Coins.Silver(3));
                    }
                }

                if (Progression.Level() >= 2)
                {
                    AddItem(Magic.UpgradeHellstone, Coins.Silver(10));
                    AddItem(Magic.StorageUnitHellstone, Coins.Silver(10));
                }

                if (Progression.Level() >= 3)
                {
                    AddItem(Magic.StorageUnitBlueChlorophyte, Coins.Silver(15));
                }

                if (Progression.Level() >= 4)
                {
                    AddItem(Magic.UpgradeHallowed, Coins.Gold());
                    AddItem(Magic.StorageUnitHallowed, Coins.Gold());
                }

                if (Progression.Level() >= 5)
                {
                    AddItem(Magic.UpgradeLuminite, Coins.Gold(2));
                    AddItem(Magic.StorageUnitLuminite, Coins.Gold(2));
                }

                if (Progression.Level() >= 6)
                {
                    AddItem(Magic.UpgradeTerra, Coins.Gold(3));
                    AddItem(Magic.StorageUnitTerra, Coins.Gold(3));
                }

                if (Progression.Level() >= 7)
                {
                    AddItem(Magic.RemoteAccess, Coins.Gold());
                }

                break;
        }
    }
}
