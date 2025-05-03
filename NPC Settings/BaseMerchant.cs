namespace MerchantsPlus.NPCs;

public abstract class BaseMerchant : GlobalNPC
{
    public override void SetDefaults(NPC npc)
    {
        base.SetDefaults(npc);

        if (IsMerchant(npc.type))
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

    private static bool IsMerchant(int npcID)
    {
        return npcID switch
        {
            NPCID.Angler or
            NPCID.ArmsDealer or
            NPCID.Clothier or
            NPCID.Cyborg or
            NPCID.Demolitionist or
            NPCID.Dryad or
            NPCID.DyeTrader or
            NPCID.GoblinTinkerer or
            NPCID.Guide or
            NPCID.Mechanic or
            NPCID.Nurse or
            NPCID.Painter or
            NPCID.PartyGirl or
            NPCID.Pirate or
            NPCID.SantaClaus or
            NPCID.SkeletonMerchant or
            NPCID.Steampunker or
            NPCID.Stylist or
            NPCID.DD2Bartender or
            NPCID.TaxCollector or
            NPCID.TravellingMerchant or
            NPCID.Truffle or
            NPCID.WitchDoctor or
            NPCID.Wizard or
            NPCID.OldMan or
            NPCID.BoundGoblin or
            NPCID.BoundMechanic or
            NPCID.BoundWizard or
            NPCID.SleepingAngler => true,
            _ => false,
        };
    }
}