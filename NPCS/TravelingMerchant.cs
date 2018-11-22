using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class TravelingMerchant : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.TravellingMerchant) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 1.2f;
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.TravellingMerchant) return;
            chat = Utils.dialog(new string[] {"I TRAVEL THE FAR LANDS OF LANDS",
                "LANDS OF THE FAR LANDS I TRAVEL",
                "..where am I? Who are you? Oh my god, I'm so far away from home, Sarah's gonna' kill me!"});
        }
        public override void SetupShop(int type, Chest shop, ref int nextSlot) {
            if (type != NPCID.TravellingMerchant) return;
            shop.item[nextSlot++].SetDefaults(ItemID.HighTestFishingLine);
            shop.item[nextSlot++].SetDefaults(ItemID.AnglerEarring);
            shop.item[nextSlot++].SetDefaults(ItemID.TackleBox);
        }
    }
}
