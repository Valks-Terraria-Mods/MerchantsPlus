using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Cyborg : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.Cyborg) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 1.1f;
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Cyborg) return;
            chat = Utils.dialog(new string[] { "Beep?", "Boop?" });
        }

        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type != NPCID.Cyborg) return;
            if (NPC.downedGolemBoss)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.ElectrosphereLauncher);
            }

            if (NPC.downedFishron)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.RocketLauncher);
            }

            if (NPC.downedAncientCultist)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.SnowmanCannon);
            }

            if (NPC.downedTowerVortex)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.NailGun);
            }

        }

    }
}
