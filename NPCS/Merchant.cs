using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Merchant : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.Merchant)
            {
                npc.lifeMax = 500;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type == NPCID.Merchant)
            {
                switch (Main.rand.Next(3))
                {
                    case 0:
                        chat = "Hey. Buddy. I have to tell you a secret.. wait nvm. I'll catch you later.";
                        break;
                    case 1:
                        chat = "Hey, did you hear? Were in a two dimensional world, why can't I sell three dimensional stuff! >:(";
                        break;
                    default:
                        chat = "Hey, need a general purpose item? I'm your guy.";
                        break;
                }
            }
        }

        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.Merchant) {
                shop.item[nextSlot++].SetDefaults(ItemID.DepthMeter);
                shop.item[nextSlot++].SetDefaults(ItemID.Compass);
                shop.item[nextSlot++].SetDefaults(ItemID.MetalDetector);
                shop.item[nextSlot++].SetDefaults(ItemID.DPSMeter);
                shop.item[nextSlot++].SetDefaults(ItemID.Stopwatch);
                shop.item[nextSlot++].SetDefaults(ItemID.TallyCounter);
                shop.item[nextSlot++].SetDefaults(ItemID.LifeformAnalyzer);
                shop.item[nextSlot++].SetDefaults(ItemID.Radar);
                shop.item[nextSlot++].SetDefaults(ItemID.MagicQuiver);
            }
            
        }
    }
}
