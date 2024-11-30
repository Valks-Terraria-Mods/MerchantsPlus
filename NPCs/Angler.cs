using Terraria.GameContent.ItemDropRules;

namespace MerchantsPlus.NPCs;

public class Angler : BaseMerchant
{
    public override void GetChat(NPC npc, ref string chat)
    {
        if (npc.type != NPCID.Angler)
        {
            return;
        }

        base.GetChat(npc, ref chat);
    }

    public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
    {
        if (npc.type == NPCID.Angler)
        {
            _ = npcLoot.Add(ItemDropRule.Common(ItemID.Fish, 1));
        }
    }

    public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
    {
        if (npc.type != NPCID.Angler)
        {
            return;
        }

        base.TownNPCAttackProj(npc, ref projType, ref attackDelay);

        projType = true switch
        {
            _ when NPC.downedBoss2 => ProjectileID.InfluxWaver,
            _ when NPC.downedBoss1 => ProjectileID.Blizzard,
            _ when NPC.downedSlimeKing => ProjectileID.IceSickle,
            _ => ProjectileID.FrostDaggerfish
        };
    }

}