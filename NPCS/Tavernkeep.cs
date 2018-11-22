using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Tavernkeep : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.DD2Bartender) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 1f;
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.DD2Bartender) return;
                chat = Utils.dialog(new string[] {"...", "...", "...", "...", "...",
                "I AIN'T TELLIN' YOU NOTHIN'"});
        }
        public override void SetupShop(int type, Chest shop, ref int nextSlot) {
            if (type != NPCID.DD2Bartender) return;
            shop.item[nextSlot++].SetDefaults(ItemID.ApprenticeScarf);
            shop.item[nextSlot++].SetDefaults(ItemID.SquireShield);
            shop.item[nextSlot++].SetDefaults(ItemID.HuntressBuckler);
            shop.item[nextSlot++].SetDefaults(ItemID.MonkBelt);
        }
    }
}
