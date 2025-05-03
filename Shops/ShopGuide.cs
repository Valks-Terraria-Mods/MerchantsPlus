namespace MerchantsPlus.Shops;

public class ShopGuide : Shop
{
    public override string[] Shops => ["Gear", "Pylons"];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Gear")
        {
            if (!Progression.Hardmode)
            {
                AddItem(ItemID.RecallPotion, Coins.Silver());
            }
            else
            {
                AddItem(ItemID.MagicMirror, Coins.Gold());
            }

            AddItem(ItemID.TeleportationPotion, Coins.Silver());
            AddItem(ItemID.GenderChangePotion, Coins.Copper());

            if (Progression.EyeOfCthulhu)
            {
                AddItem(ItemID.ObsidianSkinPotion, Utils.UniversalPotionCost);
            }

            AddItem(ItemID.CordageGuide, Coins.Gold());

            if (!Utils.IsNPCHere(NPCID.Merchant))
            {
                AddItem(ItemID.Torch);
            }

            if (Progression.Skeletron && !Progression.Hardmode)
            {
                AddItem(ItemID.GuideVoodooDoll, Coins.Gold(5));
            }

            if (!Utils.IsNPCHere(NPCID.Pirate))
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