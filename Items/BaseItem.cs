namespace MerchantsPlus.Items;

public class BaseItem : GlobalItem
{
    public override void SetDefaults(Item item)
    {
        base.SetDefaults(item);

        item.shopCustomPrice = item.type switch
        {
            ItemID.ManaCrystal => Coins.Silver(10),
            ItemID.EmptyBucket => Coins.Silver(10),
            ItemID.Seed => Coins.Copper(),
            ItemID.Snowball => Coins.Copper(),
            ItemID.CursedDart => Coins.Silver(),
            ItemID.IchorDart => Coins.Silver(),
            ItemID.CrystalDart => Coins.Silver(),
            ItemID.PoisonDart => Coins.Silver(),
            ItemID.RottenEgg => Coins.Silver(),
            ItemID.Yoraiz0rDarkness => Coins.Gold(5),
            _ => item.shopCustomPrice
        };
    }
}