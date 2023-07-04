using Terraria.ID;

namespace MerchantsPlus.Merchants;

internal class ShopSkeletonMerchant : Shop
{
    public ShopSkeletonMerchant(bool merchant, params string[] shops) : base(merchant, shops)
    {
    }

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Music Boxes")
        {
            AddItem(ItemID.MusicBoxAltOverworldDay);
            AddItem(ItemID.MusicBoxAltUnderground);
            AddItem(ItemID.MusicBoxBoss1);
            AddItem(ItemID.MusicBoxBoss2);
            AddItem(ItemID.MusicBoxBoss3);
            AddItem(ItemID.MusicBoxBoss4);
            AddItem(ItemID.MusicBoxBoss5);
            AddItem(ItemID.MusicBoxCorruption);
            AddItem(ItemID.MusicBoxCrimson);
            AddItem(ItemID.MusicBoxDD2);
            AddItem(ItemID.MusicBoxDesert);
            AddItem(ItemID.MusicBoxDungeon);
            AddItem(ItemID.MusicBoxEclipse);
            AddItem(ItemID.MusicBoxEerie);
            AddItem(ItemID.MusicBoxFrostMoon);
            AddItem(ItemID.MusicBoxGoblins);
            AddItem(ItemID.MusicBoxIce);
            AddItem(ItemID.MusicBoxJungle);
            AddItem(ItemID.MusicBoxLunarBoss);
            AddItem(ItemID.MusicBoxMartians);
            AddItem(ItemID.MusicBoxMushrooms);
            AddItem(ItemID.MusicBoxNight);
            AddItem(ItemID.MusicBoxOcean);
            AddItem(ItemID.MusicBoxOverworldDay);
            AddItem(ItemID.MusicBoxPlantera);
            AddItem(ItemID.MusicBoxPumpkinMoon);
            AddItem(ItemID.MusicBoxRain);
            AddItem(ItemID.MusicBoxSandstorm);
            AddItem(ItemID.MusicBoxSnow);
            AddItem(ItemID.MusicBoxSpace);
            AddItem(ItemID.MusicBoxTemple);
            AddItem(ItemID.MusicBoxTheHallow);
            return;
        }

        if (shop == "Gear")
        {
            AddItem(ItemID.PinkString);
            AddItem(ItemID.PurpleCounterweight);
            AddItem(ItemID.YoYoGlove);
            if (Main.hardMode)
            {
                if (Utils.Kills(NPCID.WyvernHead) > 0) AddItem(ItemID.SoulofFlight);
                if (NPC.downedMechBoss3) AddItem(ItemID.SoulofFright);
                if (Utils.Kills(NPCID.IlluminantSlime) > 0) AddItem(ItemID.SoulofLight);
                if (NPC.downedMechBoss2) AddItem(ItemID.SoulofMight);
                if (Utils.Kills(NPCID.Clinger) > 0 || Utils.Kills(NPCID.IchorSticker) > 0) AddItem(ItemID.SoulofNight);
                if (NPC.downedMechBoss1) AddItem(ItemID.SoulofSight);
                AddItem(ItemID.RagePotion, Utils.UniversalPotionCost);
            }
            return;
        }

        // Default Shop
        Inv.SetupShop(20);
    }
}