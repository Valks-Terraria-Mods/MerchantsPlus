using Terraria.ID;

namespace MerchantsPlus.Merchants;

internal class ShopGuide : Shop
{
    public ShopGuide(params string[] shops) : base(shops)
    {
    }

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        // Default Shop
        AddItem(ItemID.CordageGuide, Utils.Coins(0, 0, 1));
        if (!Utils.IsNPCHere(NPCID.Merchant)) AddItem(ItemID.Torch);
        if (Utils.DownedSkeletron() && !Main.hardMode)
        {
            AddItem(ItemID.ObsidianSkinPotion, Utils.UniversalPotionCost);
            AddItem(ItemID.GuideVoodooDoll, Utils.Coins(0, 0, 5));
        }
        if (!Utils.IsNPCHere(NPCID.Pirate))
        {
            AddItem(ItemID.Cannon, Utils.Coins(0, 0, 2));
            AddItem(ItemID.Cannonball);
        }
        AddItem(ItemID.Gel, Utils.Coins(0, 1));
    }
}