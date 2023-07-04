using Terraria.ID;

namespace MerchantsPlus.Items;

class ItemsArmour : BaseItem
{
    public override void SetDefaults(Item item)
    {
        base.SetDefaults(item);

        if (item.type == ItemID.StardustLeggings) item.shopCustomPrice = Utils.Coins(0, 0, 20);
        if (item.type == ItemID.StardustBreastplate) item.shopCustomPrice = Utils.Coins(0, 0, 20);
        if (item.type == ItemID.StardustHelmet) item.shopCustomPrice = Utils.Coins(0, 0, 20);
        if (item.type == ItemID.SolarFlareLeggings) item.shopCustomPrice = Utils.Coins(0, 0, 20);
        if (item.type == ItemID.SolarFlareBreastplate) item.shopCustomPrice = Utils.Coins(0, 0, 20);
        if (item.type == ItemID.SolarFlareHelmet) item.shopCustomPrice = Utils.Coins(0, 0, 20);
        if (item.type == ItemID.VortexLeggings) item.shopCustomPrice = Utils.Coins(0, 0, 20);
        if (item.type == ItemID.VortexBreastplate) item.shopCustomPrice = Utils.Coins(0, 0, 20);
        if (item.type == ItemID.VortexHelmet) item.shopCustomPrice = Utils.Coins(0, 0, 20);
        if (item.type == ItemID.NebulaLeggings) item.shopCustomPrice = Utils.Coins(0, 0, 20);
        if (item.type == ItemID.NebulaBreastplate) item.shopCustomPrice = Utils.Coins(0, 0, 20);
        if (item.type == ItemID.NebulaHelmet) item.shopCustomPrice = Utils.Coins(0, 0, 20);
        if (item.type == ItemID.PalmWoodGreaves) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.PalmWoodBreastplate) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.PalmWoodHelmet) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.BorealWoodGreaves) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.BorealWoodBreastplate) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.BorealWoodHelmet) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.PumpkinLeggings) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.PumpkinBreastplate) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.PumpkinHelmet) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.ShadewoodGreaves) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.ShadewoodBreastplate) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.ShadewoodHelmet) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.CactusLeggings) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.CactusBreastplate) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.CactusHelmet) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.PearlwoodGreaves) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.PearlwoodBreastplate) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.PearlwoodHelmet) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.RichMahoganyGreaves) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.RichMahoganyBreastplate) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.RichMahoganyHelmet) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.EbonwoodGreaves) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.EbonwoodBreastplate) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.EbonwoodHelmet) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.WoodGreaves) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.WoodBreastplate) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.WoodHelmet) item.shopCustomPrice = Utils.Coins(0, 5);
    }
}
