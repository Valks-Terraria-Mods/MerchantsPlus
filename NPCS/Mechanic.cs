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
                if (NPC.downedMechBoss1) shop.item[nextSlot++].SetDefaults(ItemID.CelestialMagnet);
                if (NPC.downedMechBoss2) shop.item[nextSlot++].SetDefaults(ItemID.Toolbox);
                if (NPC.downedMechBoss3) shop.item[nextSlot++].SetDefaults(ItemID.PaintSprayer);
                if (NPC.downedMartians) shop.item[nextSlot++].SetDefaults(ItemID.ExtendoGrip);
                if (NPC.downedTowerStardust) shop.item[nextSlot++].SetDefaults(ItemID.PortableCementMixer);
                if (NPC.downedTowerSolar) shop.item[nextSlot++].SetDefaults(ItemID.BrickLayer);
            }
            
        }
    }
}
