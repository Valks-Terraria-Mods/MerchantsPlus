namespace MerchantsPlus.NPCs;

internal class SkeletonMerchant : BaseMerchant
{
    public override void GetChat(NPC npc, ref string chat)
    {
        if (npc.type != NPCID.SkeletonMerchant) return;
        base.GetChat(npc, ref chat);
    }

    public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
    {
        if (npc.type != NPCID.SkeletonMerchant) return;
        base.TownNPCAttackProj(npc, ref projType, ref attackDelay);
        projType = ProjectileID.GreenLaser;
    }
}