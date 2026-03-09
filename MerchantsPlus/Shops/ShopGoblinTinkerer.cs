namespace MerchantsPlus.Shops;

public class ShopGoblinTinkerer : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.GoblinTinkerer, ShopGoblinTinkererCatalog.ShopNames);

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.GoblinTinkerer, shop))
        {
            return;
        }

        int progression = Progression.LevelFull();
        Action openShop = shop switch
        {
            ShopGoblinTinkererCatalog.MiscellaneousShopName => Miscellaneous,
            ShopGoblinTinkererCatalog.SpecialShopName => Special,
            ShopGoblinTinkererCatalog.DefensiveShopName => Defensive,
            ShopGoblinTinkererCatalog.ImmunityShopName => Immunity,
            ShopGoblinTinkererCatalog.CombatShopName => () => Combat(progression),
            ShopGoblinTinkererCatalog.HealthAndManaShopName => () => HealthAndMana(progression),
            ShopGoblinTinkererCatalog.InformationalShopName => () => Informational(progression),
            ShopGoblinTinkererCatalog.MovementShopName => () => Movement(progression),
            _ => () => Inv.SetupShop(ShopType.GoblinTinkerer)
        };

        openShop();
    }

    private void Movement(int progression)
    {
        AddItemsAtPrice(ItemCosts.Accessories, ShopGoblinTinkererCatalog.MovementBaseAccessories);
        AddProgressionItems(progression, ShopGoblinTinkererCatalog.MovementProgressionItems);
    }

    private void Informational(int progression)
    {
        if (Config.Instance?.UnlockAllItems == true)
        {
            AddItems(ShopGoblinTinkererCatalog.WatchVariants);
        }
        else
        {
            AddItem(ShopGoblinTinkererCatalog.GetWatchByWorldOre());
        }

        AddProgressionItems(progression, ShopGoblinTinkererCatalog.InformationalProgressionItems);
    }

    private void HealthAndMana(int progression)
    {
        AddItemsAtPrice(ItemCosts.Accessories, ShopGoblinTinkererCatalog.HealthAndManaBaseAccessories);
        AddConditionalOffers(ShopGoblinTinkererCatalog.HealthAndManaPreProgressionOffers);
        AddProgressionItems(progression, ShopGoblinTinkererCatalog.HealthAndManaProgressionItems);
        AddConditionalOffers(ShopGoblinTinkererCatalog.HealthAndManaPostProgressionOffers);
    }

    private void Combat(int progression)
    {
        AddItemsAtPrice(ItemCosts.Accessories, ShopGoblinTinkererCatalog.CombatBaseAccessories);
        AddProgressionItems(progression, ShopGoblinTinkererCatalog.CombatEarlyProgressionItems);
        AddConditionalOffers(ShopGoblinTinkererCatalog.CombatEarlyConditionalOffers);
        AddProgressionItems(progression, ShopGoblinTinkererCatalog.CombatMidProgressionItems);
        AddConditionalOffers(ShopGoblinTinkererCatalog.CombatLateConditionalOffers);
        AddProgressionItems(progression, ShopGoblinTinkererCatalog.CombatLateProgressionItems);
        AddProgressionTiers(progression, ShopGoblinTinkererCatalog.CombatDefenseAccessoryTiers);
    }

    private void Immunity()
    {
        AddConditionalOffers(ShopGoblinTinkererCatalog.ImmunityOffers);
    }

    private void Defensive()
    {
        AddConditionalOffers(ShopGoblinTinkererCatalog.DefensiveOffers);
    }

    private void Special()
    {
        if (Config.Instance?.UnlockAllItems == true)
        {
            AddConditionalOffers(ShopGoblinTinkererCatalog.SpecialPreBrainOffers);
            AddItemsAtPrice(ItemCosts.Accessories, ShopGoblinTinkererCatalog.EvilBossAccessories);
            AddConditionalOffers(ShopGoblinTinkererCatalog.SpecialPostBrainOffers);
            return;
        }

        AddConditionalOffers(ShopGoblinTinkererCatalog.SpecialPreBrainOffers);
        AddItem(Progression.BrainOrEater, ShopGoblinTinkererCatalog.GetEvilBossAccessory(), ItemCosts.Accessories);
        AddConditionalOffers(ShopGoblinTinkererCatalog.SpecialPostBrainOffers);
    }

    private void Miscellaneous()
    {
        AddItemsAtPrice(ItemCosts.Accessories, ShopGoblinTinkererCatalog.MiscellaneousBaseAccessories);
        AddConditionalOffers(ShopGoblinTinkererCatalog.MiscellaneousOffers);
    }
}



