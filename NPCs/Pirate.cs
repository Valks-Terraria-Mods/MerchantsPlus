using Terraria;
using Terraria.ID;

namespace MerchantsPlus.NPCs
{
    internal class Pirate : BaseMerchant
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Pirate) return;
            base.GetChat(npc, ref chat);
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Pirate) return;
            base.TownNPCAttackProj(npc, ref projType, ref attackDelay);
            projType = ProjectileID.Bullet;
            if (Utils.DownedMechBosses() == 1)
            {
                projType = ProjectileID.CursedBullet;
            }
            if (Utils.DownedMechBosses() == 2)
            {
                projType = ProjectileID.IchorBullet;
            }
            if (Utils.DownedMechBosses() == 3)
            {
                projType = ProjectileID.CrystalBullet;
            }
            if (NPC.downedPlantBoss)
            {
                projType = ProjectileID.ChlorophyteBullet;
            }
            if (NPC.downedMoonlord)
            {
                projType = ProjectileID.MoonlordBullet;
            }
        }
    }
}