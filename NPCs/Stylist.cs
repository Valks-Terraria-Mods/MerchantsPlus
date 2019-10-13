﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Stylist : GlobalNPC
    {


        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Stylist) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] {"I also sell every banner type depending on if you killed that enemy 50 times!"});
        }

        

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Stylist) return;
            attackDelay = 1;
            projType = ProjectileID.PainterPaintball;
        }

        
    }
}
