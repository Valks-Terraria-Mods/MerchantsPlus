using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Cyborg : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.Cyborg) {
                if (NPC.downedGolemBoss)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.ElectrosphereLauncher);
                }

                if (NPC.downedFishron)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.RocketLauncher);
                }

                if (NPC.downedAncientCultist) {
                    shop.item[nextSlot++].SetDefaults(ItemID.SnowmanCannon);
                }

                if (NPC.downedTowerVortex) {
                    shop.item[nextSlot++].SetDefaults(ItemID.NailGun);
                }
                
            }
            
        }
    }
}
