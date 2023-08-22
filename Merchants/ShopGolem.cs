using MerchantsPlus.Merchants;

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
                AddItem(MagicStorageDefs.StorageHeart.Type, 
                    Utils.Coins(), 0);

                AddItem(MagicStorageDefs.CraftingAccess.Type, 
                    Utils.Coins(), 0);

                AddItem(MagicStorageDefs.StorageAccess.Type, 
                    Utils.Coins(), 0);

                AddItem(MagicStorageDefs.StorageUnitTiny.Type, 
                    Utils.Coins(), 0);

                AddItem(MagicStorageDefs.StorageUnit.Type, 
                    Utils.Coins(), 1);

                if (WorldGen.crimson)
                    AddItem(MagicStorageDefs.StorageUnitCrimtane.Type, 
                        Utils.Coins(), 2);
                else
                    AddItem(MagicStorageDefs.StorageUnitDemonite.Type, 
                        Utils.Coins(), 2);

                AddItem(MagicStorageDefs.StorageUnitHellstone.Type, 
                    Utils.Coins(), 3);

                AddItem(MagicStorageDefs.StorageUnitHallowed.Type, 
                    Utils.Coins(), 4);

                AddItem(MagicStorageDefs.StorageUnitLuminite.Type, 
                    Utils.Coins(), 5);

                AddItem(MagicStorageDefs.StorageUnitTerra.Type, 
                    Utils.Coins(), 6);

                AddItem(MagicStorageDefs.RemoteAccess.Type,
                    Utils.Coins(), 7);

                break;
        }
    }
}
