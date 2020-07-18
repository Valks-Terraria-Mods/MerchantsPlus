using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    internal class ShopGuide : Shop
    {
        public ShopGuide(bool merchant, params string[] shops) : base(merchant, shops)
        {
        }

        public override void OpenShop(string shop)
        {
            base.OpenShop(shop);

            // Default Shop
            AddItem(ItemID.CordageGuide);
            if (!Utils.IsNPCHere(NPCID.Merchant)) AddItem(ItemID.Torch);
            if (Utils.DownedSkeletron() && !Main.hardMode)
            {
                AddItem(ItemID.ObsidianSkinPotion, Utils.UniversalPotionCost);
                AddItem(ItemID.GuideVoodooDoll, Utils.Coins(0, 0, 10));
            }
            if (!Utils.IsNPCHere(NPCID.Pirate))
            {
                AddItem(ItemID.Cannon);
                AddItem(ItemID.Cannonball);
            }
        }
    }
}