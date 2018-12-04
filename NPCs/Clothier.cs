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
            chat = Utils.dialog(new string[] {"There's one thing I like about this world is that you can sit back and relax and make clothes.",
            "Ah peace and quiet.",
            "One day I'll make the most beautiful piece of clothing ever laid eyes on.",
            "Oh you're back for more? I've got a big selection for you.",
            "This red hat really suits me well!",
            "I love hearing the birds in the early morning. It's just so peaceful.",
            "I always dreamed of living on the beach.",
            "Just.. so.. peaceful..",
            Main.dayTime ? "The sunshine is upon us!" : "I don't really like that it's so dark outside..",
            Main.hardMode ? "You know the world use to be very peaceful, not it seems very stirred up." : "The world is very calm right now, I like it.",
            Main.raining ? "Rain is so noisy, not my kind of day.." : "At least it's not raining!",
            Main.eclipse ? "I'm so scared!" : "I don't think I'm afraid of anything. Why do you ask?",
            "I hope you like the clothes I have on sale today, come back tomorrow and I'll have different clothes to sell!",
            "I get the job done, if it's a shoe, a hat, it's no problem for me.",
            "Me? Make a shirt for you? That's not a problem for me! I'll get right on it!",
            "I could teach you how to make your own clothes! All you need is a few materials I have in my shop!"});
        }

        

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Clothier) return;
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
