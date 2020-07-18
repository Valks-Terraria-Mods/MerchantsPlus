using Terraria;
using Terraria.ID;

namespace MerchantsPlus.NPCs
{
    internal class OldMan : BaseMerchant
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.OldMan) return;
            base.GetChat(npc, ref chat);
        }

        public override void NPCLoot(NPC npc)
        {
            if (npc.type != NPCID.OldMan) return;
            base.NPCLoot(npc);
            Utils.DropItem(npc, NPCID.OldMan, new short[] { ItemID.Bacon }, 100);
        }
    }
}