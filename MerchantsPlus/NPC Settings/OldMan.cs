using Terraria.GameContent.ItemDropRules;

namespace MerchantsPlus.NPCs;

public class OldMan : BaseMerchant
{
    public override void GetChat(NPC npc, ref string chat)
    {
        if (npc.type != NPCID.OldMan)
        {
            return;
        }

        base.GetChat(npc, ref chat);
    }

    public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
    {
        if (npc.type == NPCID.OldMan)
        {
            npcLoot.Add(ItemDropRule.Common(ItemID.Bacon));
        }
    }
}