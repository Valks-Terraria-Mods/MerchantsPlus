using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Mechanic : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.Mechanic) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 0.8f;
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Mechanic) return;
            chat = Utils.dialog(new string[] { "We gotta' fix that pipe ma keeps talking about.",
                "Pa keeps telling me to fix his ol' radio.",
                "Ba won't stop nagging me about that ol' ufo."});
        }
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type != NPCID.Mechanic) return;
            if (NPC.downedMechBoss1) shop.item[nextSlot++].SetDefaults(ItemID.CelestialMagnet);
            if (NPC.downedMechBoss2) shop.item[nextSlot++].SetDefaults(ItemID.Toolbox);
            if (NPC.downedMechBoss3) shop.item[nextSlot++].SetDefaults(ItemID.PaintSprayer);
            if (NPC.downedMartians) shop.item[nextSlot++].SetDefaults(ItemID.ExtendoGrip);
            if (NPC.downedTowerStardust) shop.item[nextSlot++].SetDefaults(ItemID.PortableCementMixer);
            if (NPC.downedTowerSolar) shop.item[nextSlot++].SetDefaults(ItemID.BrickLayer);
        }

    }
}
