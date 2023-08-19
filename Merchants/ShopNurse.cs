using Terraria.ID;

namespace MerchantsPlus.Merchants;

internal class ShopNurse : Shop
{
    public ShopNurse(params string[] shops) : base(shops)
    {
    }

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

        // Default Shop
        AddItem(ItemID.LifeCrystal, Utils.Coins(0, 0, 0, 1));
        if (Main.hardMode)
        {
            AddItem(ItemID.LifeFruit, Utils.Coins(0, 0, 0, 1));
        }
        AddItem(ItemID.HeartLantern, Utils.Coins(0, 0, 0, 1));
    }
}