using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Pirate : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.Pirate)
            {
                npc.lifeMax = 500;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type == NPCID.Pirate)
            {
                switch (Main.rand.Next(3))
                {
                    case 0:
                        chat = "Arrrr";
                        break;
                    case 1:
                        chat = "ARRRR";
                        break;
                    default:
                        chat = "Arr?";
                        break;
                }
            }
        }

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
