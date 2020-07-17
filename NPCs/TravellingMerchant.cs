using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    internal class TravellingMerchant : GlobalNPC
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.TravellingMerchant) return;
            if (!Config.merchantDialog) return;
            chat = Utils.Dialog(new string[] { "I'm only here because someone told me real players will buy my stuff." });
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.TravellingMerchant) return;
            attackDelay = 1;
            projType = ProjectileID.ThrowingKnife;
            if (NPC.downedBoss2)
            {
                projType = ProjectileID.PoisonedKnife;
            }
            if (Utils.DownedMechBosses() == 1)
            {
                projType = ProjectileID.BoneJavelin;
            }
        }
    }
}