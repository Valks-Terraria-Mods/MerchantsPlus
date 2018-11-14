using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Pirate : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot) {
            if (type == NPCID.Pirate) {
                shop.item[nextSlot++].SetDefaults(ItemID.RangerEmblem);
                shop.item[nextSlot++].SetDefaults(ItemID.SorcererEmblem);
                shop.item[nextSlot++].SetDefaults(ItemID.SummonerEmblem);
                shop.item[nextSlot++].SetDefaults(ItemID.WarriorEmblem);
            }
        }
    }
}
