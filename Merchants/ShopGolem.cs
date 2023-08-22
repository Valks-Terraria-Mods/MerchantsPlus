using MerchantsPlus.Merchants;
using Terraria.ModLoader.UI.ModBrowser;
using Magic = MerchantsPlus.MagicStorageDefs;

namespace MerchantsPlus;

internal class ShopGolem : Shop
{
    public ShopGolem(params string[] shops) : base(shops) { }

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        switch (shop)
        {
            case "Storage":
                if (Utils.Progression() >= 0)
                {
                    AddItem(Magic.StorageHeart.Type, Utils.Coins());
                    AddItem(Magic.CraftingAccess.Type, Utils.Coins());
                    AddItem(Magic.StorageAccess.Type, Utils.Coins());
                    AddItem(Magic.StorageUnitTiny.Type, Utils.Coins());
                }
                
                AddItem(Magic.StorageUnit.Type, Utils.Coins(), 1);

                if (Utils.Progression() >= 2)
                {
                    if (WorldGen.crimson)
                    {
                        AddItem(Magic.UpgradeCrimtane.Type, Utils.Coins());
                        AddItem(Magic.StorageUnitCrimtane.Type, Utils.Coins());
                    }
                    else
                    {
                        AddItem(Magic.UpgradeDemonite.Type, Utils.Coins());
                        AddItem(Magic.StorageUnitDemonite.Type, Utils.Coins());
                    }
                }

                if (Utils.Progression() >= 3)
                {
                    AddItem(Magic.UpgradeHellstone.Type, Utils.Coins());
                    AddItem(Magic.StorageUnitHellstone.Type, Utils.Coins());
                }
                
                if (Utils.Progression() >= 4)
                {
                    AddItem(Magic.StorageUnitBlueChlorophyte.Type, Utils.Coins());
                }
                
                if (Utils.Progression() >= 5)
                {
                    AddItem(Magic.UpgradeHallowed.Type, Utils.Coins());
                    AddItem(Magic.StorageUnitHallowed.Type, Utils.Coins());
                }

                if (Utils.Progression() >= 6)
                {
                    AddItem(Magic.UpgradeLuminite.Type, Utils.Coins());
                    AddItem(Magic.StorageUnitLuminite.Type, Utils.Coins());
                }

                if (Utils.Progression() >= 7)
                {
                    AddItem(Magic.UpgradeTerra.Type, Utils.Coins());
                    AddItem(Magic.StorageUnitTerra.Type, Utils.Coins());
                }

                if (Utils.Progression() >= 8)
                {
                    AddItem(Magic.RemoteAccess.Type, Utils.Coins());
                }

                break;
        }
    }
}
