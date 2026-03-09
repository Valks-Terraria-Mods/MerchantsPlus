namespace MerchantsPlus.UI;

internal sealed class WorldShopSession
{
    public bool IsActive { get; set; }
    public int MerchantId { get; set; } = NPCID.None;
    public string ShopName { get; set; } = string.Empty;
    public int PinnedTalkNpcIndex { get; set; } = -1;
    public ulong LastExplicitOpenTick { get; set; }
    public ulong LastKeepAliveTick { get; set; }
    public ulong LastOpenSucceededTick { get; set; }
    public ulong LastRecoveryAttemptTick { get; set; }
    public int OpenNonce { get; set; }

    public void Clear()
    {
        IsActive = false;
        MerchantId = NPCID.None;
        ShopName = string.Empty;
        PinnedTalkNpcIndex = -1;
        LastExplicitOpenTick = 0;
        LastKeepAliveTick = 0;
        LastOpenSucceededTick = 0;
        LastRecoveryAttemptTick = 0;
        OpenNonce = 0;
    }
}
