namespace MerchantsPlus.Shops;

public class ShopNurse : Shop
{
    public override string[] Shops =>
    [
        "Life",
        "Potions"
    ];

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
            AddItem(ItemID.LifeCrystal, Coins.Platinum());
            AddItem(Progression.Hardmode, ItemID.LifeFruit, Coins.Platinum());
            AddItem(ItemID.HeartLantern, Coins.Platinum());
        }
    }
}