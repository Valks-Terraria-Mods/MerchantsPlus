using MerchantsPlus.UI;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class WitchDoctor : GlobalNPC
    {


        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.WitchDoctor) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "Be careful, this imbuing station needs tending to..",
                "A flask a day keeps the Witch Doctor away."});
        }

        

        

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.WitchDoctor) return;
            attackDelay = 1;
            projType = ProjectileID.PoisonDart;
        }

        
    }
}
