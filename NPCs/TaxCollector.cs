using Terraria.ID;

namespace MerchantsPlus.NPCs;

internal class TaxCollector : BaseMerchant
{
    public override void GetChat(NPC npc, ref string chat)
    {
        if (npc.type != NPCID.TaxCollector) return;
        base.GetChat(npc, ref chat);
    }

    public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
    {
        if (npc.type != NPCID.TaxCollector) return;
        base.TownNPCAttackProj(npc, ref projType, ref attackDelay);
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