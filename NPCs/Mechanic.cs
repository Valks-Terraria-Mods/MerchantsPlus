namespace MerchantsPlus.NPCs;

public class Mechanic : BaseMerchant
{
    public override void GetChat(NPC npc, ref string chat)
    {
        if (npc.type != NPCID.Mechanic)
        {
            return;
        }

        base.GetChat(npc, ref chat);
    }

    public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
    {
        if (npc.type != NPCID.Mechanic)
        {
            return;
        }

        base.TownNPCAttackProj(npc, ref projType, ref attackDelay);

        projType = true switch
        {
            _ when NPC.downedPlantBoss => ProjectileID.IceSickle,
            _ when Utils.DownedMechBosses() == 3 => ProjectileID.Flamarang,
            _ when Utils.DownedMechBosses() == 2 => ProjectileID.BallofFrost,
            _ when Utils.DownedMechBosses() == 1 => ProjectileID.ExplosiveBunny,
            _ => ProjectileID.MechanicWrench
        };
    }

}