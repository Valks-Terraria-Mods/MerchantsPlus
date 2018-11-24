using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Stylist : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.Stylist) return;
            if (Config.merchantExtraLife) npc.lifeMax = 2000;
            if (Config.merchantScaling) npc.scale = 0.5f;
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Stylist) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] {
                "Hey, you look pretty, sike! JUST KIDDING! YOU DON'T LOOK PRETTY BECAUSE YOU NEVER BOUGHT ANY OF MY HAIR DYES!",
                "I own your hair, it's mine, MINE!",
                "Maybe all these hair dyes are getting to my head."});
        }
    }
}
