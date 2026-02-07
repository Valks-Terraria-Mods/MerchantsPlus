namespace MerchantsPlus.NPCs;

public class ArmsDealer : BaseMerchant
{
    private static bool IsArmsDealer(NPC npc)
    {
        return npc.type == NPCID.ArmsDealer;
    }

    private static int GetProjectileType()
    {
        if (NPC.downedMoonlord)
        {
            return ProjectileID.MoonlordBullet;
        }

        if (NPC.downedPlantBoss)
        {
            return ProjectileID.ChlorophyteBullet;
        }

        if (Progression.DownedMechs(3))
        {
            return ProjectileID.CrystalBullet;
        }

        if (Progression.DownedMechs(2))
        {
            return ProjectileID.IchorBullet;
        }

        if (Progression.DownedMechs(1))
        {
            return ProjectileID.CursedBullet;
        }

        if (NPC.downedBoss2)
        {
            return ProjectileID.MeteorShot;
        }

        if (NPC.downedSlimeKing)
        {
            return ProjectileID.GoldenBullet;
        }

        return ProjectileID.Bullet;
    }

    public override void GetChat(NPC npc, ref string chat)
    {
        if (!IsArmsDealer(npc))
        {
            return;
        }

        base.GetChat(npc, ref chat);
    }

    public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
    {
        if (!IsArmsDealer(npc))
        {
            return;
        }

        base.TownNPCAttackProj(npc, ref projType, ref attackDelay);
        projType = GetProjectileType();
    }
}
