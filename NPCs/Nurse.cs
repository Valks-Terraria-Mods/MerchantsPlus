using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    internal class Nurse : GlobalNPC
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Nurse) return;
            if (!Config.merchantDialog) return;
            chat = Utils.Dialog(new string[] { "I heal people!" });
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Nurse) return;
            attackDelay = 1;
            projType = ProjectileID.NurseSyringeHurt;
            if (NPC.downedSlimeKing)
            {
                projType = ProjectileID.Flamarang;
            }
            if (NPC.downedBoss1)
            {
                projType = ProjectileID.Flamelash;
            }
            if (NPC.downedBoss2)
            {
                projType = ProjectileID.BlueFlare;
            }
        }
    }
}