namespace MerchantsPlus.Merchants;

internal class ShopWitchDoctor : Shop
{
    public override string[] Shops => new string[] { "Gear", "Flasks", "Wings" };

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Wings")
        {
            AddItem(ItemID.AngelWings, Utils.Coins(0, 0, 0, 2));
            AddItem(ItemID.DemonWings, Utils.Coins(0, 0, 0, 2));
            AddItem(ItemID.FinWings, Utils.Coins(0, 0, 0, 2));
            AddItem(ItemID.Jetpack, Utils.Coins(0, 0, 0, 2));
            AddItem(ItemID.BeeWings, Utils.Coins(0, 0, 0, 2));
            AddItem(ItemID.ButterflyWings, Utils.Coins(0, 0, 0, 2));
            AddItem(ItemID.FairyWings, Utils.Coins(0, 0, 0, 2));
            AddItem(ItemID.BatWings, Utils.Coins(0, 0, 0, 2));
            AddItem(ItemID.HarpyWings, Utils.Coins(0, 0, 0, 2));
            AddItem(ItemID.BoneWings, Utils.Coins(0, 0, 0, 2));
            if (NPC.downedMechBossAny)
            {
                AddItem(ItemID.WillsWings, Utils.Coins(0, 0, 0, 2));
                AddItem(ItemID.CrownosWings, Utils.Coins(0, 0, 0, 2));
                AddItem(ItemID.DTownsWings, Utils.Coins(0, 0, 0, 2));
                AddItem(ItemID.CenxsWings, Utils.Coins(0, 0, 0, 2));
                AddItem(ItemID.Yoraiz0rDarkness, Utils.Coins(0, 0, 0, 2));
                AddItem(ItemID.LokisWings, Utils.Coins(0, 0, 0, 2));
                AddItem(ItemID.BejeweledValkyrieWing, Utils.Coins(0, 0, 0, 2));
                AddItem(ItemID.JimsWings, Utils.Coins(0, 0, 0, 2));
                AddItem(ItemID.SkiphsWings, Utils.Coins(0, 0, 0, 2));
                AddItem(ItemID.RedsWings, Utils.Coins(0, 0, 0, 2));
                AddItem(ItemID.MothronWings, Utils.Coins(0, 0, 0, 2));
                AddItem(ItemID.LeafWings, Utils.Coins(0, 0, 0, 2));
                AddItem(ItemID.FrozenWings, Utils.Coins(0, 0, 0, 2));
                AddItem(ItemID.FlameWings, Utils.Coins(0, 0, 0, 2));
                AddItem(ItemID.BeetleWings, Utils.Coins(0, 0, 0, 2));
                AddItem(ItemID.Hoverboard, Utils.Coins(0, 0, 0, 2));
            }
            if (NPC.downedChristmasIceQueen) AddItem(ItemID.FestiveWings, Utils.Coins(0, 0, 0, 2));
            if (NPC.downedHalloweenKing) AddItem(ItemID.SpookyWings, Utils.Coins(0, 0, 0, 2));
            if (Utils.IsNPCHere(NPCID.Steampunker)) AddItem(ItemID.SteampunkWings, Utils.Coins(0, 0, 0, 2));
            if (NPC.downedFishron) AddItem(ItemID.FishronWings, Utils.Coins(0, 0, 0, 2));
            if (NPC.downedMoonlord)
            {
                AddItem(ItemID.WingsStardust, Utils.Coins(0, 0, 0, 2));
                AddItem(ItemID.WingsVortex, Utils.Coins(0, 0, 0, 2));
                AddItem(ItemID.WingsNebula, Utils.Coins(0, 0, 0, 2));
                AddItem(ItemID.WingsSolar, Utils.Coins(0, 0, 0, 2));
            }
            return;
        }

        if (shop == "Flasks")
        {
            AddItem(ItemID.FlaskofCursedFlames);
            AddItem(ItemID.FlaskofFire);
            AddItem(ItemID.FlaskofGold);
            AddItem(ItemID.FlaskofIchor);
            AddItem(ItemID.FlaskofNanites);
            AddItem(ItemID.FlaskofParty);
            AddItem(ItemID.FlaskofPoison);
            AddItem(ItemID.FlaskofVenom);
            return;
        }

        if (shop == "Gear")
        {
            AddItem(ItemID.HerculesBeetle);
            AddItem(ItemID.NecromanticScroll);
            AddItem(ItemID.PygmyNecklace);
            return;
        }

        // Default Shop
        Inv.SetupShop(16);
    }
}