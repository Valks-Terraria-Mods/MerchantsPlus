using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    internal class Guide : BaseMerchant
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Guide) return;
            base.GetChat(npc, ref chat);
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Guide) return;
            base.TownNPCAttackProj(npc, ref projType, ref attackDelay);
            projType = ProjectileID.WoodenArrowFriendly;
            if (NPC.downedSlimeKing)
            {
                projType = ProjectileID.FrostburnArrow;
            }
            /*if (NPC.downedBoss1)
            {
                projType = ProjectileID.FrostburnArrow;
            }*/
            if (NPC.downedBoss2)
            {
                projType = ProjectileID.JestersArrow;
            }
            if (Main.hardMode)
            {
                projType = ProjectileID.UnholyArrow;
            }
            if (Utils.DownedMechBosses() == 1)
            {
                projType = ProjectileID.HolyArrow;
            }
            if (Utils.DownedMechBosses() == 2)
            {
                projType = ProjectileID.CursedArrow;
            }
            if (Utils.DownedMechBosses() == 3)
            {
                projType = ProjectileID.VenomArrow;
            }
            if (NPC.downedPlantBoss)
            {
                projType = ProjectileID.ChlorophyteArrow;
            }
            if (NPC.downedMoonlord)
            {
                projType = ProjectileID.MoonlordArrow;
            }
        }
    }
}