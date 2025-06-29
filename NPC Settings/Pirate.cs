﻿namespace MerchantsPlus.NPCs;

public class Pirate : BaseMerchant
{
    public override void GetChat(NPC npc, ref string chat)
    {
        if (npc.type != NPCID.Pirate)
        {
            return;
        }

        base.GetChat(npc, ref chat);
    }

    public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
    {
        if (npc.type != NPCID.Pirate)
        {
            return;
        }

        base.TownNPCAttackProj(npc, ref projType, ref attackDelay);

        projType = true switch
        {
            _ when NPC.downedMoonlord => ProjectileID.MoonlordBullet,
            _ when NPC.downedPlantBoss => ProjectileID.ChlorophyteBullet,
            _ when Progression.DownedMechs(3) => ProjectileID.CrystalBullet,
            _ when Progression.DownedMechs(2) => ProjectileID.IchorBullet,
            _ when Progression.DownedMechs(1) => ProjectileID.CursedBullet,
            _ => ProjectileID.Bullet
        };
    }
}