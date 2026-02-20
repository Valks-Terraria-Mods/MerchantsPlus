namespace MerchantsPlus.Shops;

public class ShopTavernkeep : Shop
{
    public override List<string> Shops { get; } = [.. ShopTavernkeepCatalog.ShopNames];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == ShopTavernkeepCatalog.GearShopName)
        {
            Gear();
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.TavernKeep);
    }

    private void Gear()
    {
        AddItems(ShopTavernkeepCatalog.TavernkeepEssentials);
        AddTowerPoppers(ShopTavernkeepCatalog.TowerPopperTracks);
        AddItems(ShopTavernkeepCatalog.OldOnesArmyAccessories);
    }

    private void AddTowerPoppers(IReadOnlyList<TowerPopperTrack> towerTracks)
    {
        foreach (TowerPopperTrack towerTrack in towerTracks)
        {
            ReplaceItem(towerTrack.TierOneItemId);
            ReplaceItem(Progression.DownedMechs(1), towerTrack.TierTwoItemId);
            ReplaceItem(Progression.Golem, towerTrack.TierThreeItemId);

            NextSlot++;
        }
    }
}

