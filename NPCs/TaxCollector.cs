using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    internal class TaxCollector : GlobalNPC
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.TaxCollector) return;
            if (!Config.merchantDialog) return;
            chat = Utils.Dialog(new string[] { "Heh heh heh (all your gold was removed from your inventory) (jk)" });
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.TaxCollector) return;
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