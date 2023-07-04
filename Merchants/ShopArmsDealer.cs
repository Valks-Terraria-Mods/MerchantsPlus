using Terraria.ID;

namespace MerchantsPlus.Merchants;

internal class ShopArmsDealer : Shop
{
    public ShopArmsDealer(bool merchant, params string[] shops) : base(merchant, shops)
    {
    }

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
            if (NPC.downedPlantBoss)
            {
                AddItem(ItemID.SniperRifle);
                AddItem(ItemID.RifleScope);
            }
            if (!Main.dayTime) AddItem(ItemID.IllegalGunParts);
            if (Main.hardMode) AddItem(ItemID.EmptyBullet);
            AddItem(ItemID.AmmoBox);
            AddItem(ItemID.AmmoReservationPotion, Utils.UniversalPotionCost);
            return;
        }

        // Default Shop
        Inv.SetupShop(2);
    }

    private void ShopBulletMain()
    {
        ReplaceItem(ItemID.MusketBall);
        if (NPC.downedBoss1) ReplaceItem(ItemID.SilverBullet);
        if (NPC.downedBoss2) ReplaceItem(ItemID.MeteorShot);
        if (Utils.DownedMechBosses() == 1) ReplaceItem(ItemID.CursedBullet);
        if (Utils.DownedMechBosses() == 2) ReplaceItem(ItemID.IchorBullet);
        if (Utils.DownedMechBosses() == 3) ReplaceItem(ItemID.CrystalBullet);
        if (NPC.downedPlantBoss) ReplaceItem(ItemID.ChlorophyteBullet);
        if (NPC.downedMoonlord) ReplaceItem(ItemID.MoonlordBullet);
        NextSlot++;
    }

    private void ShopBulletOther()
    {
        ReplaceItem(ItemID.PartyBullet);
        ReplacePrice(Utils.Coins(0, 1));
        if (NPC.downedSlimeKing) ReplacePrice(Utils.Coins(50));
        if (NPC.downedBoss1) ReplacePrice(Utils.Coins(25));
        if (NPC.downedBoss2) ReplacePrice(Utils.Coins(5));
        if (NPC.downedQueenBee) ReplacePrice(Utils.Coins(1));
        if (NPC.downedBoss3) ReplaceItem(ItemID.ExplodingBullet);
        if (Utils.DownedMechBosses() == 1) ReplaceItem(ItemID.GoldenBullet);
        if (Utils.DownedMechBosses() == 2) ReplaceItem(ItemID.NanoBullet);
        if (Utils.DownedMechBosses() == 3) ReplaceItem(ItemID.HighVelocityBullet);
        if (NPC.downedPlantBoss) ReplaceItem(ItemID.VenomBullet);
        NextSlot++;
    }

    private void ShopPistol()
    {
        ReplaceItem(ItemID.FlintlockPistol);
        if (NPC.downedSlimeKing) ReplaceItem(ItemID.TheUndertaker);
        if (NPC.downedBoss1) ReplaceItem(ItemID.Revolver);
        if (NPC.downedBoss2) ReplaceItem(ItemID.Handgun);
        if (NPC.downedQueenBee) ReplaceItem(ItemID.PhoenixBlaster);
        if (Main.hardMode) ReplaceItem(ItemID.Uzi);
        if (Utils.DownedMechBosses() == 3) ReplaceItem(ItemID.VenusMagnum);
        NextSlot++;
    }

    private void ShopRifle()
    {
        ReplaceItem(ItemID.RedRyder);
        if (NPC.downedBoss1) ReplaceItem(ItemID.Musket);
        if (NPC.downedBoss2) ReplaceItem(ItemID.Minishark);
        if (Main.hardMode) ReplaceItem(ItemID.ClockworkAssaultRifle);
        if (Utils.DownedMechBosses() == 1) ReplaceItem(ItemID.Gatligator);
        if (Utils.DownedMechBosses() == 2) ReplaceItem(ItemID.Megashark);
        if (NPC.downedAncientCultist) ReplaceItem(ItemID.VortexBeater);
        if (NPC.downedMoonlord) ReplaceItem(ItemID.SDMG);
        NextSlot++;
    }

    private void ShopShotgun()
    {
        ReplaceItem(ItemID.Boomstick);
        if (Main.hardMode) ReplaceItem(ItemID.Shotgun);
        if (Utils.DownedMechBosses() == 1) ReplaceItem(ItemID.OnyxBlaster);
        if (NPC.downedPlantBoss) ReplaceItem(ItemID.TacticalShotgun);
        NextSlot++;
    }
}