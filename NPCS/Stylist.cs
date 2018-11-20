using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Stylist : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.Stylist)
            {
                npc.lifeMax = 2000;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type == NPCID.Stylist)
            {
                switch (Main.rand.Next(3))
                {
                    case 0:
                        chat = "Hey, you look pretty, sike! JUST KIDDING! YOU DON'T LOOK PRETTY BECAUSE YOU NEVER BOUGHT ANY OF MY HAIR DYES!";
                        break;
                    case 1:
                        chat = "I own your hair, it's mine, MINE!";
                        break;
                    default:
                        chat = "Maybe all these hair dyes are getting to my head.";
                        break;
                }
            }
        }
    }
}
