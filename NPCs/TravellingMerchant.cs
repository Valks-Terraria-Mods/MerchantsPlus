using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class TravellingMerchant : GlobalNPC
    {


        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.TravellingMerchant) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "I'm only here because someone told me real players will buy my stuff." });
        }

        

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.TravellingMerchant) return;
            attackDelay = 1;
            projType = ProjectileID.ThrowingKnife;
        }

        
    }
}
