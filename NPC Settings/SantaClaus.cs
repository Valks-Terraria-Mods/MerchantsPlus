namespace MerchantsPlus.NPCs;

public class SantaClaus : BaseMerchant
{
    public override void GetChat(NPC npc, ref string chat)
    {
        if (npc.type != NPCID.SantaClaus)
        {
            return;
        }

        base.GetChat(npc, ref chat);
    }

    public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
    {
        if (npc.type != NPCID.SantaClaus)
        {
            return;
        }

        base.TownNPCAttackProj(npc, ref projType, ref attackDelay);

        projType = true switch
        {
            _ when NPC.downedBoss2 => ProjectileID.PoisonedKnife,
            _ when Utils.DownedMechBosses() == 1 => ProjectileID.BoneJavelin,
            _ => ProjectileID.ThrowingKnife
        };
    }

}