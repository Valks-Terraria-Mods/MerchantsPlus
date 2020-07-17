using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    internal class Demolitionist : BaseMerchant
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Demolitionist) return;
            base.GetChat(npc, ref chat);
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Demolitionist) return;
            base.TownNPCAttackProj(npc, ref projType, ref attackDelay);
            projType = ProjectileID.Grenade;
            if (NPC.downedSlimeKing)
            {
                projType = ProjectileID.StickyGrenade;
            }
            if (NPC.downedBoss1)
            {
                projType = ProjectileID.BouncyGrenade;
            }
            if (NPC.downedBoss2)
            {
                projType = ProjectileID.HappyBomb;
            }
        }
    }
}