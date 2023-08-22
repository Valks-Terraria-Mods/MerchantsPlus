namespace MerchantsPlus.Merchants;

internal class ShopSteampunker : Shop
{
    public override string[] Shops => new string[] { "Gear", "Solutions", "Logic" };

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Logic")
        {
            AddItem(ItemID.LogicGateLamp_Faulty);
            AddItem(ItemID.LogicGateLamp_Off);
            AddItem(ItemID.LogicGate_AND);
            AddItem(ItemID.LogicGate_NAND);
            AddItem(ItemID.LogicGate_NOR);
            AddItem(ItemID.LogicGate_NXOR);
            AddItem(ItemID.LogicGate_OR);
            AddItem(ItemID.LogicGate_XOR);
            AddItem(ItemID.LogicSensor_Above, Utils.Coins(0, 0, 1));
            AddItem(ItemID.LogicSensor_Honey, Utils.Coins(0, 0, 1));
            AddItem(ItemID.LogicSensor_Lava, Utils.Coins(0, 0, 1));
            AddItem(ItemID.LogicSensor_Liquid, Utils.Coins(0, 0, 1));
            AddItem(ItemID.LogicSensor_Moon, Utils.Coins(0, 0, 1));
            AddItem(ItemID.LogicSensor_Sun, Utils.Coins(0, 0, 1));
            AddItem(ItemID.LogicSensor_Water, Utils.Coins(0, 0, 1));
            return;
        }

        if (shop == "Solutions")
        {
            AddItem(ItemID.PurpleSolution);
            AddItem(ItemID.RedSolution);
            AddItem(ItemID.GreenSolution);
            AddItem(ItemID.DarkBlueSolution);
            AddItem(ItemID.BlueSolution);
            return;
        }

        if (shop == "Gear")
        {
            AddItem(ItemID.Teleporter);
            AddItem(ItemID.Jetpack);
            AddItem(ItemID.Solidifier);
            AddItem(ItemID.BlendOMatic);
            AddItem(ItemID.FleshCloningVaat);
            AddItem(ItemID.SteampunkBoiler);
            AddItem(ItemID.Cog);
            AddItem(ItemID.StaticHook);
            AddItem(ItemID.ConveyorBeltRight);
            return;
        }

        // Default Shop
        Inv.SetupShop(11);
    }
}