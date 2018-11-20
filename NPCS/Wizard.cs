using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Wizard : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.Wizard)
            {
                npc.lifeMax = 500;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type == NPCID.Wizard)
            {
                switch (Main.rand.Next(6))
                {
                    case 0:
                        chat = "Gandolf? Is that you?";
                        break;
                    case 1:
                        chat = "My magic is more then you think young one.";
                        break;
                    case 2:
                        chat = "It is dangerous to go alone little one. Bring friends on your journey.";
                        break;
                    case 3:
                        chat = "The dungeon is a dark place litte one, be careful.";
                        break;
                    case 4:
                        chat = "Some say a lord possesses this world.";
                        break;
                    case 5:
                        chat = Utils.dialogGift(npc, "Here take this little one, you may need this on your journey.", "Be safe on your journey.", true, 10, ItemID.MagicDagger, 50000);
                        break;
                    default:
                        chat = "The world is a big place little one.";
                        break;
                }
            }
        }
    }
}
