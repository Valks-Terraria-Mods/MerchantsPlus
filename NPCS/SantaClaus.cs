using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class SantaClaus : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.SantaClaus)
            {
                npc.lifeMax = 500;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type == NPCID.SantaClaus)
            {
                switch (Main.rand.Next(4))
                {
                    case 0:
                        chat = "HOHOHOOOOOHOOOOOO";
                        break;
                    case 1:
                        chat = "HOOOOOOOO HOOOOOO HOOOOOOOO";
                        break;
                    case 2:
                        chat = "You were a good lil' kid wern't ya buddy? HOOOOOOOOO HOOOOOOO HOOOOOOOOOO";
                        break;
                    default:
                        chat = "HOOOOOOOOOOOOOOOO HOOOOOOOOOOOO HOOOOOOOOOOOOO";
                        break;
                }
            }
        }
    }
}
