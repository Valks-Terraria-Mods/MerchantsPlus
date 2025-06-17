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
            AddItem(ItemID.EndurancePotion, ItemCosts.Potions);
            AddItem(ItemID.IronskinPotion, ItemCosts.Potions);
            AddItem(ItemID.LifeforcePotion, ItemCosts.Potions);
            AddItem(ItemID.RegenerationPotion, ItemCosts.Potions);
            AddItem(ItemID.HeartreachPotion, ItemCosts.Potions);
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