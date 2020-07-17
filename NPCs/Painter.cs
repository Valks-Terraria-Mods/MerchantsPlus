using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    internal class Painter : GlobalNPC
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Painter) return;
            if (!Config.merchantDialog) return;
            chat = Utils.Dialog(new string[] { "I gotta' fresh load of white paint. Want some? :)" ,
                "All my paint is real good, I promise. ;)",
                Utils.DialogGift(npc, "Here, take this, it was given to me by my old grand father. Hope you make good use of it.", "Painting these walls day and night..", !Main.hardMode, 1, ItemID.PainterPaintballGun, 50000),
                Utils.IsNPCHere(NPCID.PartyGirl) ? "Can you please tell " + Utils.GetNPCName(NPCID.PartyGirl) + " to stop decorating my house!" : "I wonder where that party girl is at.",
                Utils.DialogGift(npc, "Have some free paint friend!", "Paint is the only thing I dream about at night.", true, 1, ItemID.RedPaint, 0),
                "You won't get any paint this good anywhere else. :)"});
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Painter) return;
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