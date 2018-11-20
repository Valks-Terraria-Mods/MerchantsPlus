using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class WitchDoctor : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.WitchDoctor)
            {
                npc.lifeMax = 500;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type == NPCID.WitchDoctor)
            {
                switch (Main.rand.Next(3))
                {
                    case 0:
                        chat = ":)";
                        break;
                    case 1:
                        chat = ":)";
                        break;
                    default:
                        chat = ":)";
                        break;
                }
            }
        }
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.WitchDoctor) {
                shop.item[nextSlot++].SetDefaults(ItemID.HerculesBeetle);
                shop.item[nextSlot++].SetDefaults(ItemID.NecromanticScroll);
                shop.item[nextSlot++].SetDefaults(ItemID.PygmyNecklace);
            }
        }
    }
}
