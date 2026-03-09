namespace MerchantsPlus.NPCs;

public class Demolitionist : BaseMerchant
{
    public override void GetChat(NPC npc, ref string chat)
    {
        if (npc.type != NPCID.Demolitionist)
        {
            return;
        }

        base.GetChat(npc, ref chat);
    }

    public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
    {
        if (npc.type != NPCID.Demolitionist)
        {
            return;
        }

        base.TownNPCAttackProj(npc, ref projType, ref attackDelay);

        projType = true switch
        {
            _ when NPC.downedBoss2 => ProjectileID.HappyBomb,
            _ when NPC.downedBoss1 => ProjectileID.BouncyGrenade,
            _ when NPC.downedSlimeKing => ProjectileID.StickyGrenade,
            _ => ProjectileID.Grenade
        };
    }

}