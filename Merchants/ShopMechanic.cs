using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Merchants
{
    internal class ShopMechanic : Shop
    {
        public ShopMechanic(bool merchant, params string[] shops) : base(merchant, shops)
        {
        }

        public override void OpenShop(string shop)
        {
            base.OpenShop(shop);

            if (shop == "Materials")
            {
                AddItem(ItemID.Wood, Utils.Coins(0, 1));
                
                AddItem(ItemID.Cactus, Utils.Coins(0, 1));
                
                AddItem(ItemID.RichMahogany, Utils.Coins(0, 1));
                
                AddItem(ItemID.BorealWood, Utils.Coins(0, 1));
                
                AddItem(ItemID.PalmWood, Utils.Coins(0, 1));
                
                AddItem(ItemID.Ebonwood, Utils.Coins(0, 1));
                
                AddItem(ItemID.Shadewood, Utils.Coins(0, 1));
                
                AddItem(ItemID.Pearlwood, Utils.Coins(0, 1));
                
                AddItem(ItemID.SpookyWood, Utils.Coins(0, 1));
                
                AddItem(ItemID.DynastyWood, Utils.Coins(0, 1));
                
                AddItem(ItemID.Pumpkin, Utils.Coins(0, 1));
                
                AddItem(ItemID.Mushroom, Utils.Coins(0, 1));
                
                AddItem(ItemID.Granite, Utils.Coins(0, 1));
                
                AddItem(ItemID.Marble, Utils.Coins(0, 1));
                
                AddItem(ItemID.Meteorite, Utils.Coins(0, 1));
                
                AddItem(ItemID.CrystalBlock, Utils.Coins(0, 1));
                
                AddItem(ItemID.Glass, Utils.Coins(0, 1));
                
                AddItem(ItemID.LivingWoodWand, Utils.Coins(0, 1));
                
                AddItem(ItemID.SunplateBlock, Utils.Coins(0, 1));
                
                AddItem(ItemID.IceBlock, Utils.Coins(0, 1));
                
                AddItem(ItemID.HoneyBlock, Utils.Coins(0, 1));
                
                AddItem(ItemID.SlimeBlock, Utils.Coins(0, 1));
                
                AddItem(ItemID.BoneBlock, Utils.Coins(0, 1));
                
                AddItem(ItemID.FleshBlock, Utils.Coins(0, 1));
                
                AddItem(ItemID.Cog, Utils.Coins(0, 1));
                
                AddItem(ItemID.LihzahrdBrick, Utils.Coins(0, 1));
                
                AddItem(ItemID.MartianConduitPlating, Utils.Coins(0, 1));
                
                AddItem(ItemID.GoldBrick, Utils.Coins(0, 1));
                
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
            Inv.SetupShop(8);
        }
    }
}