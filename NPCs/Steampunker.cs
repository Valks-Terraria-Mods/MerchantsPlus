using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Steampunker : GlobalNPC
    {

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Steampunker) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "The author of the mod forgot about me. ;(" ,
                "I don't really have much to say, like I said I'm a forgotten little someone. :(",
                "Hey, maybe the author of the mod will give me better dialog in the next update! :/",
                "Oh someone cares about me? <3"});
        }

        

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Steampunker) return;
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
