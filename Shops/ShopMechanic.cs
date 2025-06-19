namespace MerchantsPlus.Shops;

public class ShopMechanic : Shop
{
    public override List<string> Shops { get; } = ["Mechanics", "Materials"];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Materials")
        {
            AddItem(ItemID.Wood, Coins.Silver());
            AddItem(ItemID.Cactus, Coins.Silver());
            AddItem(ItemID.RichMahogany, Coins.Silver());
            AddItem(ItemID.BorealWood, Coins.Silver());
            AddItem(ItemID.PalmWood, Coins.Silver());
            AddItem(ItemID.Ebonwood, Coins.Silver());
            AddItem(ItemID.Shadewood, Coins.Silver());
            AddItem(ItemID.Pearlwood, Coins.Silver());
            AddItem(ItemID.SpookyWood, Coins.Silver());
            AddItem(ItemID.DynastyWood, Coins.Silver());
            AddItem(ItemID.Pumpkin, Coins.Silver());
            AddItem(ItemID.Mushroom, Coins.Silver());
            AddItem(ItemID.Granite, Coins.Silver());
            AddItem(ItemID.Marble, Coins.Silver());
            AddItem(ItemID.Meteorite, Coins.Silver());
            AddItem(ItemID.CrystalBlock, Coins.Silver());
            AddItem(ItemID.Glass, Coins.Silver());
            AddItem(ItemID.LivingWoodWand, Coins.Silver());
            AddItem(ItemID.SunplateBlock, Coins.Silver());
            AddItem(ItemID.IceBlock, Coins.Silver());
            AddItem(ItemID.HoneyBlock, Coins.Silver());
            AddItem(ItemID.SlimeBlock, Coins.Silver());
            AddItem(ItemID.BoneBlock, Coins.Silver());
            AddItem(ItemID.FleshBlock, Coins.Silver());
            AddItem(ItemID.Cog, Coins.Silver());
            AddItem(ItemID.LihzahrdBrick, Coins.Silver());
            AddItem(ItemID.MartianConduitPlating, Coins.Silver());
            AddItem(ItemID.GoldBrick, Coins.Silver());
            return;
        }

        if (shop == "Mechanics")
        {
            AddItem(ItemID.Wrench);
            AddItem(ItemID.BlueWrench);
            AddItem(ItemID.GreenWrench);
            AddItem(ItemID.YellowWrench);
            AddItem(ItemID.WireCutter);
            AddItem(ItemID.Wire);
            AddItem(ItemID.Lever);
            AddItem(ItemID.Switch);
            AddItem(ItemID.RedPressurePlate);
            AddItem(ItemID.BluePressurePlate);
            AddItem(ItemID.BrownPressurePlate);
            AddItem(ItemID.GrayPressurePlate);
            AddItem(ItemID.GreenPressurePlate);
            AddItem(ItemID.YellowPressurePlate);
            AddItem(ItemID.ProjectilePressurePad);
            AddItem(ItemID.BoosterTrack);
            AddItem(ItemID.Actuator);
            AddItem(ItemID.WirePipe);
            AddItem(ItemID.WireBulb);
            AddItem(ItemID.Timer1Second);
            AddItem(ItemID.Timer3Second);
            AddItem(ItemID.Timer5Second);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.Mechanic);
    }
}