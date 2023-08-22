namespace MerchantsPlus.Items;

internal class BaseItem : GlobalItem
{
    public override void SetDefaults(Item item)
    {
        base.SetDefaults(item);

        if (item.type == ItemID.ManaCrystal) item.shopCustomPrice = Utils.Coins(0, 10);
        if (item.type == ItemID.EmptyBucket) item.shopCustomPrice = Utils.Coins(0, 10);
        if (item.type == ItemID.Seed) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.Snowball) item.shopCustomPrice = Utils.Coins(1);
        if (item.type == ItemID.CursedDart) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.IchorDart) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.CrystalDart) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.PoisonDart) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.RottenEgg) item.shopCustomPrice = Utils.Coins(0, 1);
        if (item.type == ItemID.Yoraiz0rDarkness) item.shopCustomPrice = Utils.Coins(0, 0, 5);
    }
}