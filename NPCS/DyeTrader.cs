using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class DyeTrader : GlobalNPC
    {
        // custom loot bags with all the dyes in them (e.g. blue, red bags)
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.DyeTrader) {
                shop.item[nextSlot++].SetDefaults(ItemID.ShadowDye);
            }
        }
    }
}
