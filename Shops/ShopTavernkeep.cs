namespace MerchantsPlus.Shops;

public class ShopTavernkeep : Shop
{
    public override string[] Shops => ["Gear"];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Gear")
        {
            AddItem(ItemID.Ale);
            AddItem(ItemID.DD2ElderCrystal);
            AddItem(ItemID.DD2ElderCrystalStand);
            AddItem(ItemID.DefendersForge);
            Ballista();
            Explosive();
            Lightning();
            Flameburst();
            AddItem(ItemID.ApprenticeScarf);
            AddItem(ItemID.SquireShield);
            AddItem(ItemID.HuntressBuckler);
            AddItem(ItemID.MonkBelt);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.TavernKeep);
    }

    private void Flameburst()
    {
        ReplaceItem(ItemID.DD2FlameburstTowerT1Popper);
        ReplaceItem(Progression.DownedMechs(1), ItemID.DD2FlameburstTowerT2Popper);
        ReplaceItem(Progression.Golem, ItemID.DD2FlameburstTowerT3Popper);

        NextSlot++;
    }

    private void Ballista()
    {
        ReplaceItem(ItemID.DD2BallistraTowerT1Popper);
        ReplaceItem(Progression.DownedMechs(1), ItemID.DD2BallistraTowerT2Popper);
        ReplaceItem(Progression.Golem, ItemID.DD2BallistraTowerT3Popper);

        NextSlot++;
    }

    private void Lightning()
    {
        ReplaceItem(ItemID.DD2LightningAuraT1Popper);
        ReplaceItem(Progression.DownedMechs(1), ItemID.DD2LightningAuraT2Popper);
        ReplaceItem(Progression.Golem, ItemID.DD2LightningAuraT3Popper);

        NextSlot++;
    }

    private void Explosive()
    {
        ReplaceItem(ItemID.DD2ExplosiveTrapT1Popper);
        ReplaceItem(Progression.DownedMechs(1), ItemID.DD2ExplosiveTrapT2Popper);
        ReplaceItem(Progression.Golem, ItemID.DD2ExplosiveTrapT3Popper);

        NextSlot++;
    }
}