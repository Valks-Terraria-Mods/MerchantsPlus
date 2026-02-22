namespace MerchantsPlus.UI;

/// <summary>
/// Prevents vanilla distance cleanup from closing remote world-browser shop sessions.
/// </summary>
public sealed class WorldShopTalkGuard : ModSystem
{
    public override void Load()
    {
        On_Player.SetTalkNPC += OnPlayerSetTalkNpc;
    }

    public override void Unload()
    {
        On_Player.SetTalkNPC -= OnPlayerSetTalkNpc;
    }

    private static void OnPlayerSetTalkNpc(On_Player.orig_SetTalkNPC orig, Player self, int npcIndex, bool fromNet)
    {
        if (ShouldBlockTalkNpcClear(self, npcIndex))
        {
            return;
        }

        orig(self, npcIndex, fromNet);
    }

    private static bool ShouldBlockTalkNpcClear(Player player, int requestedNpcIndex)
    {
        if (requestedNpcIndex != -1 || player is null || player.whoAmI != Main.myPlayer)
        {
            return false;
        }

        AddCustomShopUI customUi = ModContent.GetInstance<AddCustomShopUI>();
        if (customUi is null || !customUi.IsWorldShopsUIOpen())
        {
            return false;
        }

        if (!ShowAllShopsUI.TryGetWorldSession(out WorldShopSession session)
            || session is null
            || !session.IsActive
            || session.PinnedTalkNpcIndex < 0
            || session.PinnedTalkNpcIndex >= Main.maxNPCs)
        {
            return false;
        }

        NPC pinnedNpc = Main.npc[session.PinnedTalkNpcIndex];
        if (!pinnedNpc.active || !pinnedNpc.townNPC)
        {
            ShowAllShopsUI.ClearWorldSession(clearTalkNpc: false);
            return false;
        }

        // Session is active and still valid, so do not let vanilla clear talkNPC this frame.
        return true;
    }
}
