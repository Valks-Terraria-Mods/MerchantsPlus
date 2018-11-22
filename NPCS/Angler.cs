using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Angler : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.Angler) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 0.8f;
            npc.aiStyle = 1;
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Angler) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[]{"Modder felt like making me jump. What can I say.",
                "No I will not stop jumping while you talk to me! I want to jump!",
                "When I grow up, I want to be a bunny hopper."});
        }

        public override void NPCLoot(NPC npc)
        {
            Utils.dropItem(npc, NPCID.Angler, new short[] { ItemID.IronBow }, 25);
        }

        public override void TownNPCAttackCooldown(NPC npc, ref int cooldown, ref int randExtraCooldown)
        {
            if (npc.type != NPCID.Angler)
            cooldown = 0;
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
        }
    }
}
