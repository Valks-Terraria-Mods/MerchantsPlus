namespace MerchantsPlus.Shops;

public class ShopPirate : Shop
{
    public override string[] Shops => ["Arrr", "Potions"];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Potions")
        {
            AddItem(ItemID.TrapsightPotion, ItemCosts.Potions);
            AddItem(ItemID.HunterPotion, ItemCosts.Potions);
            AddItem(ItemID.InfernoPotion, ItemCosts.Potions);
            return;
        }

        if (shop == "Arrr")
        {
            AddItem(ItemID.Sail);
            AddItem(ItemID.ParrotCracker);
            AddItem(ItemID.BunnyCannon);
            AddItem(ItemID.RangerEmblem, Coins.Platinum());
            AddItem(ItemID.SorcererEmblem, Coins.Platinum());
            AddItem(ItemID.SummonerEmblem, Coins.Platinum());
            AddItem(ItemID.WarriorEmblem, Coins.Platinum());
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.Pirate);
    }
}