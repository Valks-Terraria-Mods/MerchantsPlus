using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    internal class Mechanic : BaseMerchant
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Mechanic) return;
            base.GetChat(npc, ref chat);
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Mechanic) return;
            base.TownNPCAttackProj(npc, ref projType, ref attackDelay);
            projType = ProjectileID.MechanicWrench;
            if (Utils.DownedMechBosses() == 1)
            {
                projType = ProjectileID.ExplosiveBunny;
            }
            if (Utils.DownedMechBosses() == 2)
            {
                projType = ProjectileID.BallofFrost;
            }
            if (Utils.DownedMechBosses() == 3)
            {
                projType = ProjectileID.Flamarang;
            }
            if (NPC.downedPlantBoss)
            {
                projType = ProjectileID.IceSickle;
            }
        }
    }
}