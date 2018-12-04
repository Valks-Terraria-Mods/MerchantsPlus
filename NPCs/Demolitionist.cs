using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Demolitionist : GlobalNPC
    {


        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Demolitionist) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "Modder still working on my dialog." });
        }

        

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Demolitionist) return;
            attackDelay = 1;
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
