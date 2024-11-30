namespace MerchantsPlus.NPCs;

public abstract class BaseMerchant : GlobalNPC
{
    public override void SetDefaults(NPC npc)
    {
        base.SetDefaults(npc);

        if (Utils.IsMerchant(npc.type))
        {
            if (Config.Instance.ToggleScaling)
            {
                npc.scale = 0.9f;
            }

            if (Config.Instance.ToggleExtraLife)
            {
                npc.lifeMax = 500;
            }
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
        if (!Config.Instance.ToggleDialog)
        {
            return;
        }

        chat = Utils.Dialog(["Defeat more bosses to unlock more gear."]);
    }

    public override void OnKill(NPC npc)
    {
        if (!Config.Instance.ToggleDrops)
        {
            return;
        }
    }

    public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
    {
        if (!Config.Instance.ToggleProjectiles)
        {
            return;
        }

        attackDelay = 1;
    }
}