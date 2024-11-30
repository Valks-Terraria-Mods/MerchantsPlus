namespace MerchantsPlus.Items;

public class BaseItem : GlobalItem
{
    public override void SetDefaults(Item item)
    {
        base.SetDefaults(item);

        item.shopCustomPrice = item.type switch
        {
            ItemID.ManaCrystal => Utils.Coins(0, 10),
            ItemID.EmptyBucket => Utils.Coins(0, 10),
            ItemID.Seed => Utils.Coins(1),
            ItemID.Snowball => Utils.Coins(1),
            ItemID.CursedDart => Utils.Coins(0, 1),
            ItemID.IchorDart => Utils.Coins(0, 1),
            ItemID.CrystalDart => Utils.Coins(0, 1),
            ItemID.PoisonDart => Utils.Coins(0, 1),
            ItemID.RottenEgg => Utils.Coins(0, 1),
            ItemID.Yoraiz0rDarkness => Utils.Coins(0, 0, 5),
            _ => item.shopCustomPrice
        };
    }
}