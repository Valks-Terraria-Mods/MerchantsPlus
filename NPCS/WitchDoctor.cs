using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class WitchDoctor : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.WitchDoctor) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 0.9f;
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.WitchDoctor) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "Be careful, this imbuing station needs tending to..",
                "A flask a day keeps the Witch Doctor away.",
                Utils.dialogGift(npc, "Here, take these wings.", "Heh heh..", true, 25, ItemID.BoneWings, 50000)});
        }
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type != NPCID.WitchDoctor) return;
            shop.item[nextSlot++].SetDefaults(ItemID.HerculesBeetle);
            shop.item[nextSlot++].SetDefaults(ItemID.NecromanticScroll);
            shop.item[nextSlot++].SetDefaults(ItemID.PygmyNecklace);
        }
    }
}
