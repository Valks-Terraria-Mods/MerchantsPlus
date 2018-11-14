using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Merchant : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.Merchant) {
                shop.item[nextSlot++].SetDefaults(ItemID.DepthMeter);
                shop.item[nextSlot++].SetDefaults(ItemID.Compass);
                shop.item[nextSlot++].SetDefaults(ItemID.MetalDetector);
                shop.item[nextSlot++].SetDefaults(ItemID.DPSMeter);
                shop.item[nextSlot++].SetDefaults(ItemID.Stopwatch);
                shop.item[nextSlot++].SetDefaults(ItemID.TallyCounter);
                shop.item[nextSlot++].SetDefaults(ItemID.LifeformAnalyzer);
                shop.item[nextSlot++].SetDefaults(ItemID.Radar);
                shop.item[nextSlot++].SetDefaults(ItemID.MagicQuiver);
            }
            
        }
    }
}
