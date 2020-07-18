using Terraria.ID;

namespace MerchantsPlus.Merchants
{
    internal class ShopSantaClaus : Shop
    {
        public ShopSantaClaus(bool merchant, params string[] shops) : base(merchant, shops)
        {
        }

        public override void OpenShop(string shop)
        {
            base.OpenShop(shop);

            if (shop == "Potions")
            {
                AddItem(ItemID.InvisibilityPotion, Utils.UniversalPotionCost);
                AddItem(ItemID.GenderChangePotion, Utils.UniversalPotionCost);
                AddItem(ItemID.RecallPotion, Utils.UniversalPotionCost);
                AddItem(ItemID.TeleportationPotion, Utils.UniversalPotionCost);
                AddItem(ItemID.WormholePotion, Utils.UniversalPotionCost);
                return;
            }

            if (shop == "Lights")
            {
                AddItem(ItemID.RedLight);
                AddItem(ItemID.GreenLight);
                AddItem(ItemID.BlueLight);
                AddItem(ItemID.StarTopper1);
                AddItem(ItemID.StarTopper2);
                AddItem(ItemID.StarTopper3);
                AddItem(ItemID.MulticoloredLights);
                AddItem(ItemID.RedLights);
                AddItem(ItemID.GreenLights);
                AddItem(ItemID.BlueLights);
                AddItem(ItemID.YellowLights);
                AddItem(ItemID.RedAndYellowLights);
                AddItem(ItemID.RedAndGreenLights);
                AddItem(ItemID.YellowAndGreenLights);
                AddItem(ItemID.BlueAndGreenLights);
                AddItem(ItemID.RedAndBlueLights);
                AddItem(ItemID.BlueAndYellowLights);
                return;
            }

            if (shop == "Bulbs")
            {
                AddItem(ItemID.RedBulb);
                AddItem(ItemID.YellowBulb);
                AddItem(ItemID.RedAndGreenBulb);
                AddItem(ItemID.YellowAndGreenBulb);
                AddItem(ItemID.RedAndYellowBulb);
                AddItem(ItemID.WhiteBulb);
                AddItem(ItemID.WhiteAndRedBulb);
                AddItem(ItemID.WhiteAndYellowBulb);
                AddItem(ItemID.WhiteAndGreenBulb);
                return;
            }

            if (shop == "Decor")
            {
                AddItem(ItemID.ChristmasTree);
                AddItem(ItemID.BowTopper);
                AddItem(ItemID.WhiteGarland);
                AddItem(ItemID.WhiteAndRedGarland);
                AddItem(ItemID.RedGardland);
                AddItem(ItemID.GreenGardland);
                AddItem(ItemID.GreenAndWhiteGarland);
                AddItem(ItemID.MulticoloredBulb);
                return;
            }

            // Default Shop
            Inv.SetupShop(9);
        }
    }
}