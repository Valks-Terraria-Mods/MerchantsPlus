namespace MerchantsPlus.Shops;

public static class ShopTavernkeepCatalog
{
    public const string GearShopName = "Gear";
    public static readonly string[] ShopNames = [GearShopName];

    public static readonly int[] TavernkeepEssentials =
    [
        ItemID.Ale,
        ItemID.DD2ElderCrystal,
        ItemID.DD2ElderCrystalStand,
        ItemID.DefendersForge,
    ];

    public static readonly int[] OldOnesArmyAccessories =
    [
        ItemID.ApprenticeScarf,
        ItemID.SquireShield,
        ItemID.HuntressBuckler,
        ItemID.MonkBelt,
    ];

    public static readonly TowerPopperTrack[] TowerPopperTracks =
    [
        new(ItemID.DD2BallistraTowerT1Popper, ItemID.DD2BallistraTowerT2Popper, ItemID.DD2BallistraTowerT3Popper),
        new(ItemID.DD2ExplosiveTrapT1Popper, ItemID.DD2ExplosiveTrapT2Popper, ItemID.DD2ExplosiveTrapT3Popper),
        new(ItemID.DD2LightningAuraT1Popper, ItemID.DD2LightningAuraT2Popper, ItemID.DD2LightningAuraT3Popper),
        new(ItemID.DD2FlameburstTowerT1Popper, ItemID.DD2FlameburstTowerT2Popper, ItemID.DD2FlameburstTowerT3Popper),
    ];

}

