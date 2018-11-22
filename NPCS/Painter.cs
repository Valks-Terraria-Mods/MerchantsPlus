using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Painter : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.Painter) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 0.8f;
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Painter) return;
            chat = Utils.dialog(new string[] { "I gotta' fresh load of white paint. Want some? :)" ,
                "All my paint is real good, I promise. ;)",
                Utils.dialogGift(npc, "Here, take this, it was given to me by my old grand father. Hope you make good use of it.", "Painting these walls day and night..", !Main.hardMode, 10, ItemID.PainterPaintballGun, 50000),
                Utils.isNPCHere(NPCID.PartyGirl) ? "Can you please tell " + Utils.getNPCName(NPCID.PartyGirl) + " to stop decorating my house!" : "I wonder where that party girl is at.",
                Utils.dialogGift(npc, "Have some free paint friend!", "Paint is the only thing I dream about at night.", true, 10, ItemID.RedPaint, 0),
                "You won't get any paint this good anywhere else. :)"});
        }
    }
}
