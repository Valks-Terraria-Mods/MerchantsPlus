using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class TravelingMerchant : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.TravellingMerchant)
            {
                npc.lifeMax = 500;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type == NPCID.TravellingMerchant)
            {
                switch (Main.rand.Next(3))
                {
                    case 0:
                        chat = "I TRAVEL THE FAR LANDS OF LANDS";
                        break;
                    case 1:
                        chat = "LANDS OF THE FAR LANDS I TRAVEL";
                        break;
                    default:
                        chat = "LL-ANd.. where am I? Who are you? Oh my god, I'm so far away from home, Sarah's gonna' kill me!";
                        break;
                }
            }
        }
        public override void SetupShop(int type, Chest shop, ref int nextSlot) {
            if (type == NPCID.TravellingMerchant) {
                shop.item[nextSlot++].SetDefaults(ItemID.HighTestFishingLine);
                shop.item[nextSlot++].SetDefaults(ItemID.AnglerEarring);
                shop.item[nextSlot++].SetDefaults(ItemID.TackleBox);
            }
        }
    }
}
