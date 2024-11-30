namespace MerchantsPlus.NPCs;

public class Nurse : BaseMerchant
{
    public override void GetChat(NPC npc, ref string chat)
    {
        if (npc.type != NPCID.Nurse)
        {
            return;
        }

        base.GetChat(npc, ref chat);
    }

    public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
    {
        if (npc.type != NPCID.Nurse)
        {
            return;
        }

        base.TownNPCAttackProj(npc, ref projType, ref attackDelay);

        projType = true switch
        {
            _ when NPC.downedBoss2 => ProjectileID.BlueFlare,
            _ when NPC.downedBoss1 => ProjectileID.Flamelash,
            _ when NPC.downedSlimeKing => ProjectileID.Flamarang,
            _ => ProjectileID.NurseSyringeHurt
        };
    }
}