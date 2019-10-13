using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    public class Clothier : GlobalNPC
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Clothier) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] {"There's one thing I like about this world. You can sit back, relax, and just make clothes.",
            "Ahh... peace and quiet.",
            "One day I'll make the most beautiful piece of clothing the world will ever lay its eyes upon.",
            "Oh, you're back for more? I've got a big selection for you!",
            "This red hat really suits me well! I've nicknamed it Chippy!",
            "I love hearing the birds in the early morning. It's just so peaceful.",
            "I've always dreamed of living on the beach.",
            "Just... so... peaceful...",
            Main.dayTime ? "Sunshine is upon us!" : "I've had quiet a few bad encoutners with skeletons in the dark!",
            !Main.hardMode ? "You know, the world used to be very peaceful." : "The world seems to keep getting crazier!",
            Main.raining ? "Rain is so noisy! Not my kind of day.." : "At least it's not raining... yet.",
            Main.eclipse ? "I'm so scared!" : "I don't think I'm afraid of anything. Why do you ask?",
            "I hope you like the clothes I have on sale today. Come back tomorrow and I'll have different clothes to sell!",
            "I get the job done, if it's a shoe, a hat, it's no problem for me.",
            "Me? Make a shirt for you? That's not a problem for me! I'll get right on it!",
            "I could teach you how to make your own clothes! All you need is a few materials I have in my shop!"});
        }

        

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Clothier) return;
            attackDelay = 1;
            projType = ProjectileID.ThrowingKnife;
            if (NPC.downedQueenBee)
            {
                projType = ProjectileID.Bone;
            }
            if (Utils.downedMechBosses() == 1)
            {
                projType = ProjectileID.Skull;
            }
        }
    }
}
