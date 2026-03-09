namespace MerchantsPlus.UI;

internal static class WorldShopPurchaseDiagnostics
{
    private static string _selection = "none";
    private static string _hover = "none";
    private static string _mouseDown = "none";
    private static string _attempt = "none";
    private static string _result = "none";
    private static string _failure = "none";
    private static ulong _selectionTick;
    private static ulong _hoverTick;
    private static ulong _mouseDownTick;
    private static ulong _attemptTick;
    private static ulong _resultTick;

    public static void RecordSelection(int merchantId, string shopName, int visibleCount)
    {
        string merchant = Lang.GetNPCNameValue(merchantId);
        if (string.IsNullOrWhiteSpace(merchant))
        {
            merchant = $"NPC {merchantId}";
        }

        _selection = $"{merchant}/{shopName} visible={visibleCount}";
        _selectionTick = Main.GameUpdateCount;
    }

    public static void RecordHover(int slotIndex, Item item)
    {
        _hover = $"{BuildSlotItemText(slotIndex, item)}";
        _hoverTick = Main.GameUpdateCount;
    }

    public static void RecordMouseDown(int slotIndex, Item item, bool ignoreMouseInterface, string source)
    {
        string src = string.IsNullOrWhiteSpace(source) ? "unknown" : source;
        _mouseDown = $"{BuildSlotItemText(slotIndex, item)} src={src} ignoreMouse={ignoreMouseInterface} ml={Main.mouseLeft} mr={Main.mouseRight} mlr={Main.mouseLeftRelease} mrr={Main.mouseRightRelease}";
        _mouseDownTick = Main.GameUpdateCount;
    }

    public static void RecordAttempt(int slotIndex, Item item, long price, int currency, bool canAfford)
    {
        _attempt = $"{BuildSlotItemText(slotIndex, item)} price={price} cur={currency} canAfford={canAfford}";
        _attemptTick = Main.GameUpdateCount;
    }

    public static void RecordResult(bool success, string detail)
    {
        _result = $"{(success ? "ok" : "fail")} {detail}";
        _resultTick = Main.GameUpdateCount;
        if (!success)
        {
            _failure = detail;
        }
    }

    public static List<string> GetPanelLines(bool worldUiOpen)
    {
        return
        [
            $"worldUI={worldUiOpen} tick={Main.GameUpdateCount} sel@{_selectionTick}: {_selection}",
            $"hover@{_hoverTick}: {_hover}",
            $"down@{_mouseDownTick}: {_mouseDown}",
            $"try@{_attemptTick}: {_attempt}",
            $"res@{_resultTick}: {_result}; fail={_failure}",
        ];
    }

    private static string BuildSlotItemText(int slotIndex, Item item)
    {
        if (item is null || item.IsAir || item.type <= ItemID.None)
        {
            return $"slot={slotIndex + 1} item=air";
        }

        string name = string.IsNullOrWhiteSpace(item.Name) ? Lang.GetItemNameValue(item.type) : item.Name;
        return $"slot={slotIndex + 1} item={name}({item.type})";
    }
}
