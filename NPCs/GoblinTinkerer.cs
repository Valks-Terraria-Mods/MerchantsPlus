using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class GoblinTinkerer : GlobalNPC
    {

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.GoblinTinkerer) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "Were going to mod your gear right up baby. :)" ,
                "I got all the modifications you will ever need. >:)",
                "Did someone call for a modder? >:D"});
        }

        

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.GoblinTinkerer) return;
            projType = ProjectileID.ThrowingKnife;
            if (NPC.downedBoss2)
            {
                projType = ProjectileID.PoisonedKnife;
            }
            if (Utils.downedMechBosses() == 1)
            {
                projType = ProjectileID.BoneJavelin;
            }
            attackDelay = 1;
        }

        
    }
}
