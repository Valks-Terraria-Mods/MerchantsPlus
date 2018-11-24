using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
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
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] {"I'm only here because someone told me real players will buy my stuff."});
        }
        public override void SetupShop(int type, Chest shop, ref int nextSlot) {
            if (type != NPCID.TravellingMerchant) return;
            shop.item[nextSlot++].SetDefaults(ItemID.HighTestFishingLine);
            shop.item[nextSlot++].SetDefaults(ItemID.AnglerEarring);
            shop.item[nextSlot++].SetDefaults(ItemID.TackleBox);
            shop.item[nextSlot++].SetDefaults(ItemID.ShadowOrb);
            shop.item[nextSlot++].SetDefaults(ItemID.MagicLantern);
            shop.item[nextSlot++].SetDefaults(ItemID.DD2PetGhost);
            if (Main.hardMode) shop.item[nextSlot++].SetDefaults(ItemID.SuspiciousLookingTentacle);
        }
    }
}
