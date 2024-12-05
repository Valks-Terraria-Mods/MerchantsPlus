﻿namespace MerchantsPlus.NPCs;

public class Dryad : BaseMerchant
{
    public override void GetChat(NPC npc, ref string chat)
    {
        if (npc.type != NPCID.Dryad)
        {
            return;
        }

        base.GetChat(npc, ref chat);
    }

    public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
    {
        if (npc.type != NPCID.Dryad)
        {
            return;
        }

        base.TownNPCAttackProj(npc, ref projType, ref attackDelay);

        projType = true switch
        {
            _ when Utils.DownedMechBosses() == 1 => ProjectileID.BoneJavelin,
            _ when NPC.downedBoss2 => ProjectileID.PoisonedKnife,
            _ => ProjectileID.ThrowingKnife
        };
    }
}