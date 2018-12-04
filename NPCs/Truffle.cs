using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Truffle : GlobalNPC
    {

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Truffle) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "Slerp?",
                "WOOP WOOP WOOP",
                ":o",
                "Pu?",
                "BOO!",
                "WUP?",
                "BSHHHHHHREEEELLO?",
                "(The mysterious creature glances at you from a distance..)",
                "(The creatures big open eyes gleem with excitement when look at what it has to offer..)"});
        }

        

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Truffle) return;
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
