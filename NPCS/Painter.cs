using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Painter : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.Painter)
            {
                npc.lifeMax = 500;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type == NPCID.Painter)
            {
                switch (Main.rand.Next(5))
                {
                    case 0:
                        chat = "I gotta' fresh load of white paint. Want some? :)";
                        break;
                    case 1:
                        chat = "All my paint is real good, I promise. ;)";
                        break;
                    case 2:
                        chat = Utils.dialogGift(npc, "Here, take this, it was given to me by my old grand father. Hope you make good use of it.", "Painting these walls day and night..", !Main.hardMode, 10, ItemID.PainterPaintballGun, 50000);
                        break;
                    case 3:
                        if (Utils.isNPCHere(NPCID.PartyGirl))
                        {
                            chat = "Can you please tell " + Utils.getNPCName(NPCID.PartyGirl) + " to stop decorating my house!";
                        }
                        else {
                            chat = "I wonder where that party girl is at.";
                        }
                        break;
                    case 4:
                        chat = Utils.dialogGift(npc, "Have some free paint friend!", "Paint is the only thing I dream about at night.", true, 10, ItemID.RedPaint, 0);
                        break;
                    default:
                        chat = "You won't get any paint this good anywhere else. :)";
                        break;
                }
            }
        }
    }
}
