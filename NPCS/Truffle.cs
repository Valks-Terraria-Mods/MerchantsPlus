using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Truffle : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.Truffle)
            {
                npc.lifeMax = 500;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type == NPCID.Truffle)
            {
                switch (Main.rand.Next(4))
                {
                    case 0:
                        chat = "Slerp?";
                        break;
                    case 1:
                        chat = "FOOP ROOP DOOP!";
                        break;
                    case 2:
                        chat = ":o";
                        break;
                    default:
                        chat = "Pu?";
                        break;
                }
            }
        }
        public override void SetupShop(int type, Chest shop, ref int nextSlot) {
            if (type == NPCID.Truffle) { 
            
            }
        }
    }
}
