using Terraria.ID;

namespace MerchantsPlus.NPCs;

internal abstract class BaseMerchant : GlobalNPC
{
    public override void SetDefaults(NPC npc)
    {
        base.SetDefaults(npc);

        if (Utils.IsMerchant(npc.type))
        {
            if (Config.MerchantScaling) npc.scale = 0.9f;
            if (Config.MerchantExtraLife) npc.lifeMax = 500;
        }
    }

    public override void DrawEffects(NPC npc, ref Color drawColor)
    {
        base.DrawEffects(npc, ref drawColor);

        switch (npc.type)
        {
            case NPCID.BoundGoblin:
            case NPCID.BoundMechanic:
            case NPCID.BoundWizard:
                Lighting.AddLight(npc.position, new Vector3(1, 1, 1));
                break;
        }
    }

    public override void GetChat(NPC npc, ref string chat)
    {
        if (!Config.MerchantDialog) return;
        chat = Utils.Dialog(new string[] { "Defeat more bosses to unlock more gear." });
    }

    public override void OnKill(NPC npc)
    {
        if (!Config.MerchantDrops) return;
    }

    public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
    {
        if (!Config.MerchantProjectiles) return;
        attackDelay = 1;
    }
}