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
                shop.item[nextSlot++].SetDefaults(ItemID.Flamethrower);
                shop.item[nextSlot++].SetDefaults(ItemID.ElectrosphereLauncher);
                shop.item[nextSlot++].SetDefaults(ItemID.RocketLauncher);
                shop.item[nextSlot++].SetDefaults(ItemID.SnowmanCannon);
                shop.item[nextSlot++].SetDefaults(ItemID.NailGun);
            }
            
        }
    }
}
