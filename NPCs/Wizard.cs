namespace MerchantsPlus.NPCs;

public class Wizard : BaseMerchant
{
    public override void GetChat(NPC npc, ref string chat)
    {
        if (npc.type != NPCID.Wizard)
        {
            return;
        }

        base.GetChat(npc, ref chat);
    }

    public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
    {
        if (npc.type != NPCID.Wizard)
        {
            return;
        }

        base.TownNPCAttackProj(npc, ref projType, ref attackDelay);

        projType = true switch
        {
            _ when NPC.downedMoonlord => ProjectileID.RainbowCrystal,
            _ when NPC.downedFishron => ProjectileID.RainbowFront,
            _ when NPC.downedGolemBoss => ProjectileID.RainbowBack,
            _ when NPC.downedPlantBoss => ProjectileID.RainbowRodBullet,
            _ when Utils.DownedMechBosses() == 3 => ProjectileID.MagnetSphereBall,
            _ when Utils.DownedMechBosses() == 2 => ProjectileID.BallofFrost,
            _ when Utils.DownedMechBosses() == 1 => ProjectileID.BallofFire,
            _ => ProjectileID.RainbowCrystalExplosion
        };
    }
}