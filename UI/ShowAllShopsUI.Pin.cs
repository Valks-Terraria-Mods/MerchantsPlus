namespace MerchantsPlus.UI;

public partial class ShowAllShopsUI
{
    public void ClearPinnedShop(bool clearTalkNpc)
    {
        ClearPinnedTalkNpc(clearTalkNpc);
    }

    public static bool TryGetPinnedTalkNpc(out int pinnedTalkNpcIndex)
    {
        if (_pinnedTalkNpcIndex >= 0
            && _pinnedTalkNpcIndex < Main.maxNPCs
            && Main.npc[_pinnedTalkNpcIndex].active)
        {
            pinnedTalkNpcIndex = _pinnedTalkNpcIndex;
            return true;
        }

        pinnedTalkNpcIndex = -1;
        return false;
    }

    public static void ClearPinnedTalkNpc(bool clearTalkNpc)
    {
        if (clearTalkNpc && Main.LocalPlayer is not null)
        {
            Main.LocalPlayer.SetTalkNPC(-1);
        }

        _pinnedTalkNpcIndex = -1;
    }

    private static void PinCurrentTalkNpc()
    {
        if (Main.LocalPlayer is null)
        {
            _pinnedTalkNpcIndex = -1;
            return;
        }

        int talkNpc = Main.LocalPlayer.talkNPC;
        if (talkNpc >= 0 && talkNpc < Main.maxNPCs && Main.npc[talkNpc].active)
        {
            _pinnedTalkNpcIndex = talkNpc;
            return;
        }

        _pinnedTalkNpcIndex = -1;
    }
}
