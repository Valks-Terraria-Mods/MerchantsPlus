using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class SkeletonMerchant : GlobalNPC
    {


        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.SkeletonMerchant) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "(You hear a small crackling noise..)" ,
                "(The skeleton stares blankly at you..)",
                "(The skeleton seems to be getting impatient..)"});
        }

        

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.SkeletonMerchant) return;
            attackDelay = 1;
            projType = ProjectileID.GreenLaser;
        }
    }
}
