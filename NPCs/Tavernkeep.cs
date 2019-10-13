using MerchantsPlus.UI;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Tavernkeep : GlobalNPC
    {


        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.DD2Bartender) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] {"...", "...", "...", "...", "...",
                "I AIN'T TELLIN' YOU NOTHIN'"});
        }

        

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.DD2Bartender) return;
            attackDelay = 1;
            projType = ProjectileID.Ale;
        }

        
    }
}
