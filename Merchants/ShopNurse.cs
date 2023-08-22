namespace MerchantsPlus.Merchants;

internal class ShopNurse : Shop
{
    public override string[] Shops => new string[] 
    { 
        "Life", 
        "Potions"
    };

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Potions")
        {
            AddItem(ItemID.EndurancePotion, Utils.UniversalPotionCost);
            AddItem(ItemID.IronskinPotion, Utils.UniversalPotionCost);

            AddItem(ItemID.LifeforcePotion, Utils.UniversalPotionCost);

            AddItem(ItemID.RegenerationPotion, Utils.UniversalPotionCost);

            AddItem(ItemID.HeartreachPotion, Utils.UniversalPotionCost);

            return;
        }

        if (shop == "Life")
        {
            AddItem(ItemID.LifeCrystal, Utils.Coins(0, 0, 0, 1));
            if (Main.hardMode)
            {
                AddItem(ItemID.LifeFruit, Utils.Coins(0, 0, 0, 1));
            }
            AddItem(ItemID.HeartLantern, Utils.Coins(0, 0, 0, 1));
        }
    }
}