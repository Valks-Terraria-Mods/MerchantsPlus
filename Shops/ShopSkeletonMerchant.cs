namespace MerchantsPlus.Shops;

public class ShopSkeletonMerchant : Shop
{
    public override List<string> Shops { get; } = ["Gear", "Music Boxes"];

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

            if (Progression.Hardmode)
            {
                if (WorldUtils.Kills(NPCID.WyvernHead) > 0)
                {
                    AddItem(ItemID.SoulofFlight);
                }

                if (NPC.downedMechBoss3)
                {
                    AddItem(ItemID.SoulofFright);
                }

                if (WorldUtils.Kills(NPCID.IlluminantSlime) > 0)
                {
                    AddItem(ItemID.SoulofLight);
                }

                if (NPC.downedMechBoss2)
                {
                    AddItem(ItemID.SoulofMight);
                }

                if (WorldUtils.Kills(NPCID.Clinger) > 0 || WorldUtils.Kills(NPCID.IchorSticker) > 0)
                {
                    AddItem(ItemID.SoulofNight);
                }

                if (NPC.downedMechBoss1)
                {
                    AddItem(ItemID.SoulofSight);
                }
            }

            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.SkeletonMerchant);
    }
}