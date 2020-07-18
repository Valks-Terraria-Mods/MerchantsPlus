using Terraria;
using Terraria.ID;

namespace MerchantsPlus.NPCs
{
    internal class Angler : BaseMerchant
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Angler) return;
            base.GetChat(npc, ref chat);
        }

        public override void NPCLoot(NPC npc)
        {
            if (npc.type != NPCID.Angler) return;
            base.NPCLoot(npc);
            Utils.DropItem(npc, NPCID.Angler, new short[] { ItemID.Fish }, 25);
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Angler) return;
            base.TownNPCAttackProj(npc, ref projType, ref attackDelay);
            projType = ProjectileID.FrostDaggerfish;
            if (NPC.downedSlimeKing)
            {
                projType = ProjectileID.IceSickle;
            }
            if (NPC.downedBoss1)
            {
                projType = ProjectileID.Blizzard;
            }
            if (NPC.downedBoss2)
            {
                projType = ProjectileID.InfluxWaver;
            }
        }
    }
}