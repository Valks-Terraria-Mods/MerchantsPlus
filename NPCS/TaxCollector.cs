using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class TaxCollector : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.TaxCollector) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 0.8f;
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.TaxCollector) return;
            chat = Utils.dialog(new string[] { "Heh heh heh (all your gold was removed from your inventory) (jk)" });
        }

        public override void NPCLoot(NPC npc)
        {
            Utils.dropItem(npc, NPCID.TaxCollector, new short[] { ItemID.IronBow }, 25);
        }

        public override void TownNPCAttackCooldown(NPC npc, ref int cooldown, ref int randExtraCooldown)
        {
            if (npc.type != NPCID.TaxCollector) return;
            cooldown = 0;
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
        }
    }
}
