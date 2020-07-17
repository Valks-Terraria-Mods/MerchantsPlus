using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    internal class Dryad : GlobalNPC
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Dryad) return;
            if (!Config.merchantDialog) return;
            chat = Utils.Dialog(new string[] { "I will protect you from the darkness!",
                "I will do whatever it takes to protect you!",
                "If it's the last thing I'll do, I'll protect you!"});
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Dryad) return;
            attackDelay = 1;
            projType = ProjectileID.ThrowingKnife;
            if (NPC.downedBoss2)
            {
                projType = ProjectileID.PoisonedKnife;
            }
            if (Utils.DownedMechBosses() == 1)
            {
                projType = ProjectileID.BoneJavelin;
            }
        }
    }
}