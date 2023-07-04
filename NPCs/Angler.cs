using Terraria.GameContent.ItemDropRules;
using Terraria.ID;

namespace MerchantsPlus.NPCs;

internal class Angler : BaseMerchant
{
    public override void GetChat(NPC npc, ref string chat)
    {
        if (npc.type != NPCID.Angler) return;
        base.GetChat(npc, ref chat);
    }

    public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
    {
        if (npc.type == NPCID.Angler)
        {
            npcLoot.Add(ItemDropRule.Common(ItemID.Fish, 1));
        }
    }

    public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
    {
        if (npc.type != NPCID.Angler) return;
        base.TownNPCAttackProj(npc, ref projType, ref attackDelay);
        projType = ProjectileID.FrostDaggerfish;
        if (NPC.downedSlimeKing)
        {
            projType = ProjectileID.IceSickle;
        }
        if (NPC.downedBoss1)
        {
            projType = ProjectileID.Blizzard;
        }
        if (NPC.downedBoss2)
        {
            projType = ProjectileID.InfluxWaver;
        }
    }
}