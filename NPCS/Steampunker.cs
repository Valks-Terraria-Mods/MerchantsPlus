using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Steampunker : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.Steampunker)
            {
                npc.lifeMax = 500;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type == NPCID.Steampunker)
            {
                switch (Main.rand.Next(4))
                {
                    case 0:
                        chat = "The author of the mod forgot about me. ;(";
                        break;
                    case 1:
                        chat = "I don't really have much to say, like I said I'm a forgotten little someone. :(";
                        break;
                    case 2:
                        chat = "Hey, maybe the author of the mod will give me better dialog in the next update! :/";
                        break;
                    default:
                        chat = "Oh someone cares about me? <3";
                        break;
                }
            }
        }
    }
}
