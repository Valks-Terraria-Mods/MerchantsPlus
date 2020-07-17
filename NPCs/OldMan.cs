﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    internal class OldMan : GlobalNPC
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.OldMan) return;
            if (!Config.merchantDialog) return;
            chat = Utils.Dialog(new string[] { "You want to fight big pa? Come back at night!" });
        }

        public override void NPCLoot(NPC npc)
        {
            if (npc.type != NPCID.OldMan) return;
            Utils.DropItem(npc, NPCID.OldMan, new short[] { ItemID.Bacon }, 100);
        }
    }
}