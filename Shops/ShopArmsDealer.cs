namespace MerchantsPlus.Shops;

public class ShopArmsDealer : Shop
{
    public override string[] Shops => ["Guns"];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Guns")
        {
            ShopBulletMain();
            ShopBulletOther();
            ShopPistol();
            ShopRifle();
            ShopShotgun();

            // Msc
            if (Progression.Plantera)
            {
                AddItem(ItemID.SniperRifle);
                AddItem(ItemID.RifleScope);
            }

            if (!Main.dayTime)
            {
                AddItem(ItemID.IllegalGunParts);
            }

            if (Progression.Hardmode)
            {
                AddItem(ItemID.EmptyBullet);
            }

            AddItem(ItemID.AmmoBox);
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.ArmsDealer);
    }

    private void ShopBulletMain()
    {
        ReplaceItem(ItemID.MusketBall);

        ReplaceItem(Progression.EyeOfCthulhu, ItemID.SilverBullet);
        ReplaceItem(Progression.BrainOrEater, ItemID.MeteorShot);
        ReplaceItem(Progression.DownedMechs(1), ItemID.CursedBullet);
        ReplaceItem(Progression.DownedMechs(2), ItemID.IchorBullet);
        ReplaceItem(Progression.DownedMechs(3), ItemID.CrystalBullet);
        ReplaceItem(Progression.Plantera, ItemID.ChlorophyteBullet);
        ReplaceItem(Progression.Moonlord, ItemID.MoonlordBullet);

        NextSlot++;
    }

    private void ShopBulletOther()
    {
        ReplaceItem(ItemID.PartyBullet);
        ReplacePrice(Coins.Silver());

        ReplacePrice(Progression.SlimeKing, Coins.Copper(50));
        ReplacePrice(Progression.EyeOfCthulhu, Coins.Copper(25));
        ReplacePrice(Progression.BrainOrEater, Coins.Copper(5));
        ReplacePrice(Progression.QueenBee, Coins.Copper());
        ReplaceItem(Progression.Skeletron, ItemID.ExplodingBullet);
        ReplaceItem(Progression.DownedMechs(1), ItemID.GoldenBullet);
        ReplaceItem(Progression.DownedMechs(2), ItemID.NanoBullet);
        ReplaceItem(Progression.DownedMechs(3), ItemID.HighVelocityBullet);
        ReplaceItem(Progression.Plantera, ItemID.VenomBullet);

        NextSlot++;
    }

    private void ShopPistol()
    {
        ReplaceItem(ItemID.FlintlockPistol);

        ReplaceItem(Progression.SlimeKing, ItemID.TheUndertaker);
        ReplaceItem(Progression.EyeOfCthulhu, ItemID.Revolver);
        ReplaceItem(Progression.BrainOrEater, ItemID.Handgun);
        ReplaceItem(Progression.QueenBee, ItemID.PhoenixBlaster);
        ReplaceItem(Progression.Hardmode, ItemID.Uzi);
        ReplaceItem(Progression.DownedMechs(3), ItemID.VenusMagnum);

        NextSlot++;
    }

    private void ShopRifle()
    {
        ReplaceItem(ItemID.RedRyder);

        ReplaceItem(Progression.EyeOfCthulhu, ItemID.Musket);
        ReplaceItem(Progression.BrainOrEater, ItemID.Minishark);
        ReplaceItem(Progression.Hardmode, ItemID.ClockworkAssaultRifle);
        ReplaceItem(Progression.DownedMechs(1), ItemID.Gatligator);
        ReplaceItem(Progression.DownedMechs(2), ItemID.Megashark);
        ReplaceItem(NPC.downedAncientCultist, ItemID.VortexBeater);
        ReplaceItem(Progression.Moonlord, ItemID.SDMG);

        NextSlot++;
    }

    private void ShopShotgun()
    {
        ReplaceItem(ItemID.Boomstick);

        ReplaceItem(Progression.Hardmode, ItemID.Shotgun);
        ReplaceItem(Progression.DownedMechs(1), ItemID.OnyxBlaster);
        ReplaceItem(Progression.Plantera, ItemID.TacticalShotgun);

        NextSlot++;
    }
}
