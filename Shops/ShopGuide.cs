namespace MerchantsPlus.Shops;

public class ShopGuide : Shop
{
    public override string[] Shops => ["Gear", "Pylons"];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Gear")
        {
            if (Progression.Hardmode)
            {
                AddItem(ItemID.MagicMirror, Coins.Gold());
            }

            AddItem(ItemID.CordageGuide, Coins.Gold());

            if (!WorldUtils.IsNpcHere(NPCID.Merchant))
            {
                AddItem(ItemID.Torch);
            }

            if (Progression.Skeletron && !Progression.Hardmode)
            {
                AddItem(ItemID.GuideVoodooDoll, Coins.Gold(5));
            }

            if (Progression.EaterOfWorlds || Progression.BrainOfCthulhu)
            {
                if (!Progression.Hardmode)
                {
                    AddItem(ItemID.Obsidian, Coins.Silver());
                }
            }

            if (!WorldUtils.IsNpcHere(NPCID.Pirate))
            {
                AddItem(ItemID.Cannon, Coins.Gold(2));
                AddItem(ItemID.Cannonball);
            }

            AddItem(ItemID.Gel, Coins.Silver());
        }

        if (shop == "Pylons")
        {
            AddItem(ItemID.TeleportationPylonVictory, Coins.Gold());
            AddItem(ItemID.TeleportationPylonUnderground, Coins.Gold());
            AddItem(ItemID.TeleportationPylonSnow, Coins.Gold());
            AddItem(ItemID.TeleportationPylonPurity, Coins.Gold());
            AddItem(ItemID.TeleportationPylonOcean, Coins.Gold());
            AddItem(ItemID.TeleportationPylonMushroom, Coins.Gold());
            AddItem(ItemID.TeleportationPylonJungle, Coins.Gold());
            AddItem(ItemID.TeleportationPylonHallow, Coins.Gold());
            AddItem(ItemID.TeleportationPylonDesert, Coins.Gold());
        }
    }
}