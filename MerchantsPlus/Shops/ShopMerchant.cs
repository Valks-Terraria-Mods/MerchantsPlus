namespace MerchantsPlus.Shops;

public partial class ShopMerchant : Shop
{
    private static bool UnlockAllItems => Config.Instance?.UnlockAllItems == true;

    private enum ShopNames
    {
        Gear,
        Potions,
        Ores,
        Pets,
        Mounts
    }

    public override List<string> Shops { get; } = BuildShopList(
        NPCID.Merchant,
        [
            nameof(ShopNames.Gear),
            nameof(ShopNames.Potions),
            nameof(ShopNames.Ores),
            nameof(ShopNames.Pets),
            nameof(ShopNames.Mounts),
        ]);

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.Merchant, shop))
        {
            return;
        }

        Action openShop = shop switch
        {
            nameof(ShopNames.Mounts) => Mounts,
            nameof(ShopNames.Pets) => Pets,
            nameof(ShopNames.Ores) => Ores,
            nameof(ShopNames.Gear) => Gear,
            nameof(ShopNames.Potions) => Potions,
            _ => () => Inv.SetupShop(ShopType.Merchant)
        };
        openShop();
    }
}
