using Terraria.ID;

namespace MerchantsPlus.NPCs;

internal class Wizard : BaseMerchant
{
    public override void GetChat(NPC npc, ref string chat)
    {
        if (npc.type != NPCID.Wizard) return;
        base.GetChat(npc, ref chat);
    }

    public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
    {
        if (npc.type != NPCID.Wizard) return;
        base.TownNPCAttackProj(npc, ref projType, ref attackDelay);
        projType = ProjectileID.RainbowCrystalExplosion;
        if (Utils.DownedMechBosses() == 1)
        {
            projType = ProjectileID.BallofFire;
        }
        if (Utils.DownedMechBosses() == 2)
        {
            projType = ProjectileID.BallofFrost;
        }
        if (Utils.DownedMechBosses() == 3)
        {
            projType = ProjectileID.MagnetSphereBall;
        }
        if (NPC.downedPlantBoss)
        {
            projType = ProjectileID.RainbowRodBullet;
        }
        if (NPC.downedGolemBoss)
        {
            projType = ProjectileID.RainbowBack;
        }
        if (NPC.downedFishron)
        {
            projType = ProjectileID.RainbowFront;
        }
        if (NPC.downedMoonlord)
        {
            projType = ProjectileID.RainbowCrystal;
        }
    }
}