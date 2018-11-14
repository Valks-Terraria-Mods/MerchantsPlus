using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Tavernkeep : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot) {
            if (type == NPCID.DD2Bartender) {
                shop.item[nextSlot++].SetDefaults(ItemID.ApprenticeScarf);
                shop.item[nextSlot++].SetDefaults(ItemID.SquireShield);
                shop.item[nextSlot++].SetDefaults(ItemID.HuntressBuckler);
                shop.item[nextSlot++].SetDefaults(ItemID.MonkBelt);
            }
        }
    }
}
