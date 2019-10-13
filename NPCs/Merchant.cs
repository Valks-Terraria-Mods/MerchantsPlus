using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Merchant : GlobalNPC
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Merchant) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "Hey. Buddy. I have to tell you a secret.. wait nvm. I'll catch you later." ,
                "Hey, did you hear? Were in a two dimensional world, why can't I sell three dimensional stuff!",
                "Hey, need a general purpose item? I'm your guy."});
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Merchant) return;
            attackDelay = 1;
            projType = ProjectileID.ThrowingKnife;
            if (NPC.downedBoss2)
            {
                projType = ProjectileID.PoisonedKnife;
            }
            if (Utils.downedMechBosses() == 1)
            {
                projType = ProjectileID.BoneJavelin;
            }
        }
    }
}
