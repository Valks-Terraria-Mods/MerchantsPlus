namespace MerchantsPlus.Items;

public class ItemsArmour : BaseItem
{
    public override void SetDefaults(Item item)
    {
        base.SetDefaults(item);

        switch (item.type)
        {
            case ItemID.StardustLeggings:
            case ItemID.StardustBreastplate:
            case ItemID.StardustHelmet:
            case ItemID.SolarFlareLeggings:
            case ItemID.SolarFlareBreastplate:
            case ItemID.SolarFlareHelmet:
            case ItemID.VortexLeggings:
            case ItemID.VortexBreastplate:
            case ItemID.VortexHelmet:
            case ItemID.NebulaLeggings:
            case ItemID.NebulaBreastplate:
            case ItemID.NebulaHelmet:
                item.shopCustomPrice = Coins.Gold(20);
                break;
            case ItemID.PalmWoodGreaves:
            case ItemID.PalmWoodBreastplate:
            case ItemID.PalmWoodHelmet:
            case ItemID.BorealWoodGreaves:
            case ItemID.BorealWoodBreastplate:
            case ItemID.BorealWoodHelmet:
            case ItemID.PumpkinLeggings:
            case ItemID.PumpkinBreastplate:
            case ItemID.PumpkinHelmet:
            case ItemID.ShadewoodGreaves:
            case ItemID.ShadewoodBreastplate:
            case ItemID.ShadewoodHelmet:
            case ItemID.CactusLeggings:
            case ItemID.CactusBreastplate:
            case ItemID.CactusHelmet:
            case ItemID.PearlwoodGreaves:
            case ItemID.PearlwoodBreastplate:
            case ItemID.PearlwoodHelmet:
            case ItemID.RichMahoganyGreaves:
            case ItemID.RichMahoganyBreastplate:
            case ItemID.RichMahoganyHelmet:
            case ItemID.EbonwoodGreaves:
            case ItemID.EbonwoodBreastplate:
            case ItemID.EbonwoodHelmet:
            case ItemID.WoodGreaves:
            case ItemID.WoodBreastplate:
            case ItemID.WoodHelmet:
                item.shopCustomPrice = Coins.Silver(5);
                break;
        }
    }
}
