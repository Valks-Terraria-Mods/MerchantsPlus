﻿using Terraria;
using Terraria.GameContent.ItemDropRules;
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

        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.OldMan)
            {
                npcLoot.Add(ItemDropRule.Common(ItemID.Bacon, 1));
            }
        }
    }
}