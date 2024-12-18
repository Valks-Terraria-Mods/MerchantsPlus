namespace MerchantsPlus.Shops;

public class ShopPirate : Shop
{
    public override string[] Shops => ["Arrr", "Potions"];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Potions")
        {
            AddItem(ItemID.TrapsightPotion, Utils.UniversalPotionCost);
            AddItem(ItemID.HunterPotion, Utils.UniversalPotionCost);
            AddItem(ItemID.InfernoPotion, Utils.UniversalPotionCost);
            return;
        }

        if (shop == "Arrr")
        {
            AddItem(ItemID.Sail);
            AddItem(ItemID.ParrotCracker);
            AddItem(ItemID.BunnyCannon);

            AddItem(ItemID.RangerEmblem, Utils.Coins(0, 0, 0, 1));
            AddItem(ItemID.SorcererEmblem, Utils.Coins(0, 0, 0, 1));
            AddItem(ItemID.SummonerEmblem, Utils.Coins(0, 0, 0, 1));
            AddItem(ItemID.WarriorEmblem, Utils.Coins(0, 0, 0, 1));
            return;
        }

        // Default Shop
        Inv.SetupShop(17);
    }
}