using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class SantaClaus : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.SantaClaus) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 1.2f;
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.SantaClaus) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "HOHOHOOOOOHOOOOOO",
                "HOOOOOOOO HOOOOOO HOOOOOOOO",
                "You were a good lil' kid wern't ya buddy? HOOOOOOOOO HOOOOOOO HOOOOOOOOOO",
                "HOOOOOOOOOOOOOOOO HOOOOOOOOOOOO HOOOOOOOOOOOOO"});
        }
    }
}
