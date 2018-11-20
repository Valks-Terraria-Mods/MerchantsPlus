using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Tavernkeep : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.DD2Bartender)
            {
                npc.lifeMax = 500;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type == NPCID.DD2Bartender)
            {
                switch (Main.rand.Next(11))
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        chat = "...";
                        break;
                    case 10:
                        chat = "?";
                        break;
                    default:
                        chat = "I AINT' TELLIN' YOU NOTHIN'";
                        break;
                }
            }
        }
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
