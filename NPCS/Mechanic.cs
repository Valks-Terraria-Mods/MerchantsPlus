using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Mechanic : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.Mechanic)
            {
                npc.lifeMax = 500;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type == NPCID.Mechanic)
            {
                switch (Main.rand.Next(3))
                {
                    case 0:
                        chat = "We gotta' fix that pipe ma keeps talking about.";
                        break;
                    case 1:
                        chat = "Pa keeps telling me to fix his ol' radio.";
                        break;
                    default:
                        chat = "Ba won't stop nagging me about that ol' ufo.";
                        break;
                }
            }
        }
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.Mechanic) {
                if (NPC.downedMechBoss1) shop.item[nextSlot++].SetDefaults(ItemID.CelestialMagnet);
                if (NPC.downedMechBoss2) shop.item[nextSlot++].SetDefaults(ItemID.Toolbox);
                if (NPC.downedMechBoss3) shop.item[nextSlot++].SetDefaults(ItemID.PaintSprayer);
                if (NPC.downedMartians) shop.item[nextSlot++].SetDefaults(ItemID.ExtendoGrip);
                if (NPC.downedTowerStardust) shop.item[nextSlot++].SetDefaults(ItemID.PortableCementMixer);
                if (NPC.downedTowerSolar) shop.item[nextSlot++].SetDefaults(ItemID.BrickLayer);
            }
            
        }
    }
}
