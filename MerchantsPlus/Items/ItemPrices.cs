namespace MerchantsPlus.Items;

public class ItemPrices : BaseItem
{
    private static readonly HashSet<int> _endgameArmorItems =
    [
        ItemID.StardustLeggings,
        ItemID.StardustBreastplate,
        ItemID.StardustHelmet,
        ItemID.SolarFlareLeggings,
        ItemID.SolarFlareBreastplate,
        ItemID.SolarFlareHelmet,
        ItemID.VortexLeggings,
        ItemID.VortexBreastplate,
        ItemID.VortexHelmet,
        ItemID.NebulaLeggings,
        ItemID.NebulaBreastplate,
        ItemID.NebulaHelmet
    ];

    private static readonly HashSet<int> _earlyArmorItems =
    [
        ItemID.PalmWoodGreaves,
        ItemID.PalmWoodBreastplate,
        ItemID.PalmWoodHelmet,
        ItemID.BorealWoodGreaves,
        ItemID.BorealWoodBreastplate,
        ItemID.BorealWoodHelmet,
        ItemID.PumpkinLeggings,
        ItemID.PumpkinBreastplate,
        ItemID.PumpkinHelmet,
        ItemID.ShadewoodGreaves,
        ItemID.ShadewoodBreastplate,
        ItemID.ShadewoodHelmet,
        ItemID.CactusLeggings,
        ItemID.CactusBreastplate,
        ItemID.CactusHelmet,
        ItemID.PearlwoodGreaves,
        ItemID.PearlwoodBreastplate,
        ItemID.PearlwoodHelmet,
        ItemID.RichMahoganyGreaves,
        ItemID.RichMahoganyBreastplate,
        ItemID.RichMahoganyHelmet,
        ItemID.EbonwoodGreaves,
        ItemID.EbonwoodBreastplate,
        ItemID.EbonwoodHelmet,
        ItemID.WoodGreaves,
        ItemID.WoodBreastplate,
        ItemID.WoodHelmet
    ];

    public override void SetDefaults(Item item)
    {
        base.SetDefaults(item);

        if (_endgameArmorItems.Contains(item.type))
        {
            item.shopCustomPrice = Coins.Gold(20);
            return;
        }

        if (_earlyArmorItems.Contains(item.type))
        {
            item.shopCustomPrice = Coins.Silver(5);
        }
    }
}
