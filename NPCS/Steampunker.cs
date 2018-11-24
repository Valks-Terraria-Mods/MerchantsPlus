using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Steampunker : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.Steampunker) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 0.8f;
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Steampunker) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "The author of the mod forgot about me. ;(" ,
                "I don't really have much to say, like I said I'm a forgotten little someone. :(",
                "Hey, maybe the author of the mod will give me better dialog in the next update! :/",
                "Oh someone cares about me? <3"});
        }
    }
}
