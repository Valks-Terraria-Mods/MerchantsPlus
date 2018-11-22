using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Merchant : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.Merchant) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 0.8f;
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Merchant) return;
                chat = Utils.dialog(new string[] { "Hey. Buddy. I have to tell you a secret.. wait nvm. I'll catch you later." ,
                "Hey, did you hear? Were in a two dimensional world, why can't I sell three dimensional stuff! >:(",
                "Hey, need a general purpose item? I'm your guy."});
        }

        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type != NPCID.Merchant) return;
            shop.item[nextSlot++].SetDefaults(ItemID.DepthMeter);
            shop.item[nextSlot++].SetDefaults(ItemID.Compass);
            shop.item[nextSlot++].SetDefaults(ItemID.MetalDetector);
            shop.item[nextSlot++].SetDefaults(ItemID.DPSMeter);
            shop.item[nextSlot++].SetDefaults(ItemID.Stopwatch);
            shop.item[nextSlot++].SetDefaults(ItemID.TallyCounter);
            shop.item[nextSlot++].SetDefaults(ItemID.LifeformAnalyzer);
            shop.item[nextSlot++].SetDefaults(ItemID.Radar);
            shop.item[nextSlot++].SetDefaults(ItemID.MagicQuiver);
            if (NPC.downedSlimeKing) {
                shop.item[9].SetDefaults(ItemID.BoneArrow);
            }
            if (NPC.downedBoss1) {
                shop.item[9].SetDefaults(ItemID.FlamingArrow);
            }
            if (NPC.downedBoss2) {
                shop.item[9].SetDefaults(ItemID.FrostburnArrow);
            }
            if (NPC.downedBoss3) {
                shop.item[9].SetDefaults(ItemID.JestersArrow);
            }
            if (Main.hardMode) {
                shop.item[9].SetDefaults(ItemID.UnholyArrow);
            }
            if (Utils.downedMechBosses() == 1) {
                shop.item[9].SetDefaults(ItemID.HellfireArrow);
            }
        }
    }
}
