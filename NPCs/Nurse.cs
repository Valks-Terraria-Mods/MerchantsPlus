using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    internal class Nurse : BaseMerchant
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Nurse) return;
            base.GetChat(npc, ref chat);
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Nurse) return;
            base.TownNPCAttackProj(npc, ref projType, ref attackDelay);
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