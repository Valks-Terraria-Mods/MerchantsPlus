using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class WitchDoctor : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.WitchDoctor) {
                shop.item[nextSlot++].SetDefaults(ItemID.HerculesBeetle);
                shop.item[nextSlot++].SetDefaults(ItemID.NecromanticScroll);
                shop.item[nextSlot++].SetDefaults(ItemID.PygmyNecklace);
            }
        }
    }
}
