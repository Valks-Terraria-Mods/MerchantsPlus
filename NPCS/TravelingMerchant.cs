using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class TravelingMerchant : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot) {
            if (type == NPCID.TravellingMerchant) {
                shop.item[nextSlot++].SetDefaults(ItemID.HighTestFishingLine);
                shop.item[nextSlot++].SetDefaults(ItemID.AnglerEarring);
                shop.item[nextSlot++].SetDefaults(ItemID.TackleBox);
            }
        }
    }
}
