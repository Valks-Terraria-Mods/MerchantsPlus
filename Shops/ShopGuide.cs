namespace MerchantsPlus.Shops;

public class ShopGuide : Shop
{
    public override string[] Shops => ["Gear", "Pylons"];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Gear")
        {
            if (!Utils.IsHardMode())
            {
                AddItem(ItemID.RecallPotion, Utils.Coins(0, 1));
            }
            else
            {
                AddItem(ItemID.MagicMirror, Utils.Coins(0, 0, 1));
            }

            AddItem(ItemID.TeleportationPotion, Utils.Coins(0, 1));
            AddItem(ItemID.GenderChangePotion, Utils.Coins(1));

            if (Utils.DownedEyeOfCthulhu())
            {
                AddItem(ItemID.ObsidianSkinPotion, Utils.UniversalPotionCost);
            }

            AddItem(ItemID.CordageGuide, Utils.Coins(0, 0, 1));

            if (!Utils.IsNPCHere(NPCID.Merchant))
            {
                AddItem(ItemID.Torch);
            }

            if (Utils.DownedSkeletron() && !Main.hardMode)
            {
                AddItem(ItemID.GuideVoodooDoll, Utils.Coins(0, 0, 5));
            }

            if (!Utils.IsNPCHere(NPCID.Pirate))
            {
                AddItem(ItemID.Cannon, Utils.Coins(0, 0, 2));
                AddItem(ItemID.Cannonball);
            }

            AddItem(ItemID.Gel, Utils.Coins(0, 1));
        }

        if (shop == "Pylons")
        {
            AddItem(ItemID.TeleportationPylonVictory, Utils.Coins(0, 0, 1));
            AddItem(ItemID.TeleportationPylonUnderground, Utils.Coins(0, 0, 1));
            AddItem(ItemID.TeleportationPylonSnow, Utils.Coins(0, 0, 1));
            AddItem(ItemID.TeleportationPylonPurity, Utils.Coins(0, 0, 1));
            AddItem(ItemID.TeleportationPylonOcean, Utils.Coins(0, 0, 1));
            AddItem(ItemID.TeleportationPylonMushroom, Utils.Coins(0, 0, 1));
            AddItem(ItemID.TeleportationPylonJungle, Utils.Coins(0, 0, 1));
            AddItem(ItemID.TeleportationPylonHallow, Utils.Coins(0, 0, 1));
            AddItem(ItemID.TeleportationPylonDesert, Utils.Coins(0, 0, 1));
        }
    }
}