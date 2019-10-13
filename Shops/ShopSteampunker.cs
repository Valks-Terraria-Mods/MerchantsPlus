using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    class ShopSteampunker
    {
        private Chest shop;
        private int nextSlot;

        public ShopSteampunker(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            switch (currentShop)
            {
                case "Logic":
                    shop.item[nextSlot++].SetDefaults(ItemID.LogicGateLamp_Faulty);
                    shop.item[nextSlot++].SetDefaults(ItemID.LogicGateLamp_Off);
                    shop.item[nextSlot++].SetDefaults(ItemID.LogicGate_AND);
                    shop.item[nextSlot++].SetDefaults(ItemID.LogicGate_NAND);
                    shop.item[nextSlot++].SetDefaults(ItemID.LogicGate_NOR);
                    shop.item[nextSlot++].SetDefaults(ItemID.LogicGate_NXOR);
                    shop.item[nextSlot++].SetDefaults(ItemID.LogicGate_OR);
                    shop.item[nextSlot++].SetDefaults(ItemID.LogicGate_XOR);
                    shop.item[nextSlot++].SetDefaults(ItemID.LogicSensor_Above);
                    shop.item[nextSlot++].SetDefaults(ItemID.LogicSensor_Honey);
                    shop.item[nextSlot++].SetDefaults(ItemID.LogicSensor_Lava);
                    shop.item[nextSlot++].SetDefaults(ItemID.LogicSensor_Liquid);
                    shop.item[nextSlot++].SetDefaults(ItemID.LogicSensor_Moon);
                    shop.item[nextSlot++].SetDefaults(ItemID.LogicSensor_Sun);
                    shop.item[nextSlot++].SetDefaults(ItemID.LogicSensor_Water);
                    break;
                case "Solutions":
                    shop.item[nextSlot++].SetDefaults(ItemID.Clentaminator);
                    shop.item[nextSlot++].SetDefaults(ItemID.PurpleSolution);
                    shop.item[nextSlot++].SetDefaults(ItemID.RedSolution);
                    shop.item[nextSlot++].SetDefaults(ItemID.GreenSolution);
                    shop.item[nextSlot++].SetDefaults(ItemID.DarkBlueSolution);
                    shop.item[nextSlot++].SetDefaults(ItemID.BlueSolution);
                    break;
                case "Gear":
                    shop.item[nextSlot++].SetDefaults(ItemID.Teleporter);
                    shop.item[nextSlot++].SetDefaults(ItemID.Jetpack);
                    shop.item[nextSlot++].SetDefaults(ItemID.Solidifier);
                    shop.item[nextSlot++].SetDefaults(ItemID.BlendOMatic);
                    shop.item[nextSlot++].SetDefaults(ItemID.FleshCloningVaat);
                    shop.item[nextSlot++].SetDefaults(ItemID.SteampunkBoiler);
                    shop.item[nextSlot++].SetDefaults(ItemID.Cog);
                    shop.item[nextSlot++].SetDefaults(ItemID.StaticHook);
                    shop.item[nextSlot++].SetDefaults(ItemID.ConveyorBeltRight);
                    break;
                default:
                    shop.SetupShop(11);
                    break;
            }
        }
    }
}
