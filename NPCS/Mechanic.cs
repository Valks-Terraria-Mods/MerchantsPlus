using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Mechanic : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.Mechanic) {
                shop.item[nextSlot++].SetDefaults(ItemID.CelestialMagnet);
                shop.item[nextSlot++].SetDefaults(ItemID.Toolbox);
                shop.item[nextSlot++].SetDefaults(ItemID.PaintSprayer);
                shop.item[nextSlot++].SetDefaults(ItemID.ExtendoGrip);
                shop.item[nextSlot++].SetDefaults(ItemID.PortableCementMixer);
                shop.item[nextSlot++].SetDefaults(ItemID.BrickLayer);
            }
            
        }
    }
}
