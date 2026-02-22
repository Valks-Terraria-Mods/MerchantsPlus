using MerchantsPlus.ModDefs;

namespace MerchantsPlus.Shops;

public partial class ShopGuide : Shop
{
    public override List<string> Shops { get; } = BuildShopList(NPCID.Guide, ShopGuideCatalog.ShopNames);
    private static readonly int _crossModBossSummonPrice = Coins.Gold(3);

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.Guide, shop))
        {
            return;
        }

        switch (shop)
        {
            case ShopGuideCatalog.GearShopName:
                Gear();
                return;
            case ShopGuideCatalog.PylonsShopName:
                Pylons();
                return;
            case ShopGuideCatalog.VanillaShopName:
                VanillaBosses();
                return;
            case ShopGuideCatalog.CalamityShopName:
                CalamityBosses();
                return;
            // Shop will only be added if ThoriumMod is enabled
            case ShopGuideCatalog.ThoriumShopName:
                ThoriumBosses();
                return;
            // Shop will only be added if Redemption mod is enabled
            case ShopGuideCatalog.RedemptionShopName:
                RedemptionBosses();
                return;
            default:
                return;
        }
    }

    private void Gear()
    {
        bool unlockAllItems = Config.Instance?.UnlockAllItems == true;
        AddItemsAtPrice(Coins.Gold(), ShopGuideCatalog.UtilityGear);

        if (!WorldUtils.IsNpcHere(NPCID.Merchant))
        {
            AddItem(ShopGuideCatalog.TorchItemId);
        }

        if ((Progression.Skeletron && !Progression.Hardmode) || unlockAllItems)
        {
            AddItem(ShopGuideCatalog.GuideVoodooDollItemId, Coins.Gold(5));
        }

        if ((!Progression.Hardmode && (Progression.EaterOfWorlds || Progression.BrainOfCthulhu)) || unlockAllItems)
        {
            AddItem(ShopGuideCatalog.ObsidianItemId, Coins.Silver());
        }

        if (!WorldUtils.IsNpcHere(NPCID.Pirate))
        {
            AddItem(ShopGuideCatalog.CannonItemId, Coins.Gold(2));
            AddItem(ShopGuideCatalog.CannonballItemId);
        }

        AddItem(ShopGuideCatalog.GelItemId, Coins.Silver());
        AddItem(ShopGuideCatalog.BedItemId, Coins.Silver(10));
    }

    private void Pylons()
    {
        AddStagedItemsAtPrice(Coins.Gold(), ShopGuideCatalog.Pylons, 0, 16);
    }

    private void AddCrossModBossSummon(int itemId)
    {
        AddItem(itemId, _crossModBossSummonPrice);
    }

    private void VanillaBosses()
    {
        AddItem(ShopGuideCatalog.SlimeCrownItemId, Coins.Gold(3));

        List<int[]> rewardTiers = ShopGuideCatalog.GetVanillaBossRewardItemTiers();
        for (int i = 0; i < Math.Min(Progression.LevelBoss(), rewardTiers.Count); i++)
        {
            int price = i == rewardTiers.Count - 1 ? Coins.Gold(10) : Coins.Gold(5);
            foreach (int itemId in rewardTiers[i])
            {
                AddItem(itemId, price);
            }
        }
    }
}

public class ExtraCrossModTooltips : GlobalItem
{
    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        if (item.ModItem != null && item.ModItem.Mod.Name == "ThoriumMod")
        {
            switch (item.ModItem.Name)
            {
                case ShopGuideCatalog.ThoriumUnholyShardsName:
                {
                    TooltipLine line = new(Mod, "SummoningInfo", "Use 5 at a Blood Altar in the Cavern layer to summon the Viscount") { OverrideColor = Color.LightCoral };
                    tooltips.Insert(tooltips.Count - 2, line);
                    break;
                }
                case ShopGuideCatalog.ThoriumAbyssalShadowName:
                {
                    TooltipLine line = new(Mod, "SummoningInfo", "Use 3 in the Aquatic Depths to summon the The Forgotten One") { OverrideColor = Color.LightCoral };
                    tooltips.Insert(tooltips.Count - 2, line);
                    break;
                }
            }
        }
    }
}
