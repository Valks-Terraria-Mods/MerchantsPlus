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
                if (Progression.Level() >= 0)
                {
                    AddItem(Magic.StorageHeart.Type, Coins.Silver(1));
                    AddItem(Magic.CraftingAccess.Type, Coins.Silver(1));
                    AddItem(Magic.StorageAccess.Type, Coins.Silver(1));
                    AddItem(Magic.StorageUnitTiny.Type, Coins.Silver(1));
                }

                AddItem(Magic.StorageUnit.Type, Coins.Silver(1), 1);

                if (Progression.Level() >= 2)
                {
                    if (WorldGen.crimson)
                    {
                        AddItem(Magic.UpgradeCrimtane.Type, Coins.Silver(1));
                        AddItem(Magic.StorageUnitCrimtane.Type, Coins.Silver(1));
                    }
                    else
                    {
                        AddItem(Magic.UpgradeDemonite.Type, Coins.Silver(1));
                        AddItem(Magic.StorageUnitDemonite.Type, Coins.Silver(1));
                    }
                }

                if (Progression.Level() >= 3)
                {
                    AddItem(Magic.UpgradeHellstone.Type, Coins.Silver(1));
                    AddItem(Magic.StorageUnitHellstone.Type, Coins.Silver(1));
                }

                if (Progression.Level() >= 4)
                {
                    AddItem(Magic.StorageUnitBlueChlorophyte.Type, Coins.Silver(1));
                }

                if (Progression.Level() >= 5)
                {
                    AddItem(Magic.UpgradeHallowed.Type, Coins.Silver(1));
                    AddItem(Magic.StorageUnitHallowed.Type, Coins.Silver(1));
                }

                if (Progression.Level() >= 6)
                {
                    AddItem(Magic.UpgradeLuminite.Type, Coins.Silver(1));
                    AddItem(Magic.StorageUnitLuminite.Type, Coins.Silver(1));
                }

                if (Progression.Level() >= 7)
                {
                    AddItem(Magic.UpgradeTerra.Type, Coins.Silver(1));
                    AddItem(Magic.StorageUnitTerra.Type, Coins.Silver(1));
                }

                if (Progression.Level() >= 8)
                {
                    AddItem(Magic.RemoteAccess.Type, Coins.Silver(1));
                }

                break;
        }
    }
}
