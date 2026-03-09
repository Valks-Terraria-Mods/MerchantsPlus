namespace MerchantsPlus.UI;

public partial class ShowAllShopsUI
{
    internal static bool TryGetWorldSession(out WorldShopSession session)
    {
        if (_worldShopSession.IsActive)
        {
            session = _worldShopSession;
            return true;
        }

        session = null;
        return false;
    }

    public void ClearPinnedShop(bool clearTalkNpc)
    {
        ClearWorldSession(clearTalkNpc);
    }

    public static bool TryGetPinnedTalkNpc(out int pinnedTalkNpcIndex)
    {
        if (_worldShopSession.IsActive
            && _worldShopSession.PinnedTalkNpcIndex >= 0
            && _worldShopSession.PinnedTalkNpcIndex < Main.maxNPCs
            && Main.npc[_worldShopSession.PinnedTalkNpcIndex].active)
        {
            pinnedTalkNpcIndex = _worldShopSession.PinnedTalkNpcIndex;
            return true;
        }

        pinnedTalkNpcIndex = -1;
        return false;
    }

    public static void ClearPinnedTalkNpc(bool clearTalkNpc)
    {
        ClearWorldSession(clearTalkNpc);
    }

    internal static void ClearWorldSession(bool clearTalkNpc)
    {
        bool shouldClearTalkNpc = clearTalkNpc && _worldShopSession.IsActive && Main.LocalPlayer is not null;
        _worldShopSession.Clear();

        if (shouldClearTalkNpc)
        {
            Main.LocalPlayer.SetTalkNPC(-1);
        }
    }

    internal static void SetWorldSession(
        int merchantId,
        string shopName,
        int pinnedTalkNpcIndex,
        ulong explicitOpenTick,
        ulong keepAliveTick,
        ulong openSucceededTick,
        int openNonce)
    {
        if (merchantId <= NPCID.None
            || string.IsNullOrWhiteSpace(shopName)
            || pinnedTalkNpcIndex < 0
            || pinnedTalkNpcIndex >= Main.maxNPCs
            || !Main.npc[pinnedTalkNpcIndex].active)
        {
            ClearWorldSession(clearTalkNpc: false);
            return;
        }

        _worldShopSession.IsActive = true;
        _worldShopSession.MerchantId = merchantId;
        _worldShopSession.ShopName = shopName;
        _worldShopSession.PinnedTalkNpcIndex = pinnedTalkNpcIndex;
        _worldShopSession.LastExplicitOpenTick = explicitOpenTick;
        _worldShopSession.LastKeepAliveTick = keepAliveTick;
        _worldShopSession.LastOpenSucceededTick = openSucceededTick;
        _worldShopSession.LastRecoveryAttemptTick = explicitOpenTick;
        _worldShopSession.OpenNonce = Math.Max(1, openNonce);
    }

    internal static void UpdateWorldSessionKeepAlive(ulong keepAliveTick)
    {
        if (!_worldShopSession.IsActive)
        {
            return;
        }

        _worldShopSession.LastKeepAliveTick = keepAliveTick;
    }
}
