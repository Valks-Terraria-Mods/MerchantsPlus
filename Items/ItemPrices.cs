namespace MerchantsPlus.Items;

public class ItemPrices : BaseItem
{
    public override void SetDefaults(Item item)
    {
        base.SetDefaults(item);
        
        switch (item.type)
        {
            // Armour
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
            // Ores
            // Isn't this done already for us when we set custom shop price in ShopMerchant.cs?
            /*case ItemID.CopperBar:
            case ItemID.TinBar:
                item.shopCustomPrice = 50;
                break;
            case ItemID.IronBar:
            case ItemID.LeadBar:
                item.shopCustomPrice = 100;
                break;
            case ItemID.SilverBar:
            case ItemID.TungstenBar:
                item.shopCustomPrice = 150;
                break;
            case ItemID.GoldBar:
            case ItemID.PlatinumBar:
                item.shopCustomPrice = 200;
                break;
            case ItemID.CrimtaneBar:
            case ItemID.DemoniteBar:
                item.shopCustomPrice = 250;
                break;
            case ItemID.MeteoriteBar:
                item.shopCustomPrice = 300;
                break;
            case ItemID.HellstoneBar:
                item.shopCustomPrice = 350;
                break;
            case ItemID.PalladiumBar:
            case ItemID.CobaltBar:
                item.shopCustomPrice = 400;
                break;
            case ItemID.OrichalcumBar:
            case ItemID.MythrilBar:
                item.shopCustomPrice = 450;
                break;
            case ItemID.AdamantiteBar:
            case ItemID.TitaniumBar:
                item.shopCustomPrice = 500;
                break;
            case ItemID.HallowedBar:
                item.shopCustomPrice = 550;
                break;*/
        }
    }
}
