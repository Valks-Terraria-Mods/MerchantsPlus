using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Truffle : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.Truffle) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 0.8f;
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Truffle) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "Slerp?",
                "WOOP WOOP WOOP",
                ":o",
                "Pu?",
                "BOO!",
                "WUP?",
                "BSHHHHHHREEEELLO?",
                "(The mysterious creature glances at you from a distance..)",
                "(The creatures big open eyes gleem with excitement when look at what it has to offer..)"});
        }
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type != NPCID.Truffle) return;
        }
    }
}
