namespace MerchantsPlus.Merchants;

internal class ShopTavernkeep : Shop
{
    public override string[] Shops => new string[] { "Gear" };

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
        Inv.SetupShop(21);
    }

    void Flameburst()
    {
        ReplaceItem(ItemID.DD2FlameburstTowerT1Popper);
        if (Utils.DownedMechBosses() == 1) ReplaceItem(ItemID.DD2FlameburstTowerT2Popper);
        if (NPC.downedGolemBoss) ReplaceItem(ItemID.DD2FlameburstTowerT3Popper);
        NextSlot++;
    }

    void Ballista()
    {
        ReplaceItem(ItemID.DD2BallistraTowerT1Popper);
        if (Utils.DownedMechBosses() == 1) ReplaceItem(ItemID.DD2BallistraTowerT2Popper);
        if (NPC.downedGolemBoss) ReplaceItem(ItemID.DD2BallistraTowerT3Popper);
        NextSlot++;
    }

    void Lightning()
    {
        ReplaceItem(ItemID.DD2LightningAuraT1Popper);
        if (Utils.DownedMechBosses() == 1) ReplaceItem(ItemID.DD2LightningAuraT2Popper);
        if (NPC.downedGolemBoss) ReplaceItem(ItemID.DD2LightningAuraT3Popper);
        NextSlot++;
    }

    void Explosive()
    {
        ReplaceItem(ItemID.DD2ExplosiveTrapT1Popper);
        if (Utils.DownedMechBosses() == 1) ReplaceItem(ItemID.DD2ExplosiveTrapT2Popper);
        if (NPC.downedGolemBoss) ReplaceItem(ItemID.DD2ExplosiveTrapT3Popper);
        NextSlot++;
    }
}