using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Painter : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.Painter)
            {
                npc.lifeMax = 500;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type == NPCID.Painter)
            {
                switch (Main.rand.Next(3))
                {
                    case 0:
                        chat = "I gotta' fresh load of white paint. Want some? :)";
                        break;
                    case 1:
                        chat = "All my paint is real good, I promise. ;)";
                        break;
                    default:
                        chat = "You won't get any paint this good anywhere else. :)";
                        break;
                }
            }
        }
    }
}
