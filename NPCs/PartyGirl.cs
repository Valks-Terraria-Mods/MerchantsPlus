using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class PartyGirl : GlobalNPC
    {

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.PartyGirl) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "PARTY TIME BRUH" ,
                "SWINGIN' MA HEAD BRUH", "GOTTA' LOVE THIS PARTY BRUH"});
        }

        
        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.PartyGirl) return;
            attackDelay = 1;
            projType = ProjectileID.ThrowingKnife;
            if (NPC.downedBoss2)
            {
                projType = ProjectileID.PoisonedKnife;
            }
            if (Utils.downedMechBosses() == 1)
            {
                projType = ProjectileID.BoneJavelin;
            }
        }

        
    }
}
