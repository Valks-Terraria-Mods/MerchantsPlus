using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    internal class WitchDoctor : GlobalNPC
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.WitchDoctor) return;
            if (!Config.merchantDialog) return;
            chat = Utils.Dialog(new string[] { "Be careful, this imbuing station needs tending to..",
                "A flask a day keeps the Witch Doctor away."});
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.WitchDoctor) return;
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