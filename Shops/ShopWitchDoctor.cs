namespace MerchantsPlus.Shops;

public class ShopWitchDoctor : Shop
{
    public override List<string> Shops { get; } = ["Gear", "Flasks", "Wings"];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        switch (shop)
        {
            case "Wings":
                Wings();
                return;
            case "Flasks":
                Flasks();
                return;
            case "Gear":
                Gear();
                return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.WitchDoctor);
    }

    private void Gear()
    {
        AddItem(ItemID.HerculesBeetle);
        AddItem(ItemID.NecromanticScroll, Progression.Halloween);
        AddItem(ItemID.PygmyNecklace, Progression.Plantera);
    }

    private void Flasks()
    {
        int progression = Progression.Level();

        AddItem(ItemID.FlaskofNanites);
        AddItem(ItemID.FlaskofFire, progression > 8);
        AddItem(ItemID.FlaskofGold, progression > 9);
        AddItem(ItemID.FlaskofIchor, progression > 10);
        AddItem(ItemID.FlaskofCursedFlames, progression > 11);
        AddItem(ItemID.FlaskofParty, progression > 12);
        AddItem(ItemID.FlaskofPoison, progression > 13);
        AddItem(ItemID.FlaskofVenom, progression > 14);
    }

    private void Wings()
    {
        AddItem(ItemID.CreativeWings, Coins.Platinum()); // Fledgling wings

        if (Progression.Hardmode)
        {
            AddItem(ItemID.AngelWings, Coins.Platinum(2));
            AddItem(WorldUtils.Kills(NPCID.Demon) >= 3, ItemID.DemonWings, Coins.Platinum(2));
            AddItem(WorldUtils.Kills(NPCID.Shark) >= 3, ItemID.FinWings, Coins.Platinum(2));

            if (NPC.downedMechBossAny)
            {
                AddItem(ItemID.Jetpack, Coins.Platinum(2));
                AddItem(ItemID.BeeWings, Coins.Platinum(2));
                AddItem(ItemID.ButterflyWings, Coins.Platinum(2));
                AddItem(ItemID.FairyWings, Coins.Platinum(2));
                AddItem(ItemID.BatWings, Coins.Platinum(2));
                AddItem(ItemID.HarpyWings, Coins.Platinum(2));
                AddItem(ItemID.BoneWings, Coins.Platinum(2));
                AddItem(ItemID.WillsWings, Coins.Platinum(2));
                AddItem(ItemID.CrownosWings, Coins.Platinum(2));
                AddItem(ItemID.DTownsWings, Coins.Platinum(2));
                AddItem(ItemID.CenxsWings, Coins.Platinum(2));
                AddItem(ItemID.Yoraiz0rDarkness, Coins.Platinum(2));
                AddItem(ItemID.LokisWings, Coins.Platinum(2));
                AddItem(ItemID.BejeweledValkyrieWing, Coins.Platinum(2));
                AddItem(ItemID.JimsWings, Coins.Platinum(2));
                AddItem(ItemID.SkiphsWings, Coins.Platinum(2));
                AddItem(ItemID.RedsWings, Coins.Platinum(2));
                AddItem(ItemID.MothronWings, Coins.Platinum(2));
                AddItem(ItemID.LeafWings, Coins.Platinum(2));
                AddItem(ItemID.FrozenWings, Coins.Platinum(2));
                AddItem(ItemID.FlameWings, Coins.Platinum(2));
                AddItem(ItemID.BeetleWings, Coins.Platinum(2));
                AddItem(ItemID.Hoverboard, Coins.Platinum(2));
            }

            AddItem(NPC.downedChristmasIceQueen, ItemID.FestiveWings, Coins.Platinum(2));
            AddItem(NPC.downedHalloweenKing, ItemID.SpookyWings, Coins.Platinum(2));
            AddItem(WorldUtils.IsNpcHere(NPCID.Steampunker), ItemID.SteampunkWings, Coins.Platinum(2));
            AddItem(NPC.downedFishron, ItemID.FishronWings, Coins.Platinum(2));

            if (Progression.Moonlord)
            {
                AddItem(ItemID.WingsStardust, Coins.Platinum(2));
                AddItem(ItemID.WingsVortex, Coins.Platinum(2));
                AddItem(ItemID.WingsNebula, Coins.Platinum(2));
                AddItem(ItemID.WingsSolar, Coins.Platinum(2));
            }
        }
    }
}