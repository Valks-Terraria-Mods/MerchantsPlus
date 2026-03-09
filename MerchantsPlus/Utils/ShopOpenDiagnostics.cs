namespace MerchantsPlus;

internal static class ShopOpenDiagnostics
{
    private static readonly Dictionary<string, int> _counts = new(StringComparer.Ordinal);
    private static ulong _lastFlushTick;
    private static string _latestAttemptLine = "none";
    private static ulong _latestAttemptTick;

    public static void RecordAttempt(string sourceTag, int merchantId, string shopName, bool suppressSound, bool soundPlayed)
    {
        if (Config.Instance?.DevMode != true)
        {
            return;
        }

        ulong tick = Main.GameUpdateCount;
        if (_lastFlushTick == 0)
        {
            _lastFlushTick = tick;
        }

        string merchantName = Lang.GetNPCNameValue(merchantId);
        if (string.IsNullOrWhiteSpace(merchantName))
        {
            merchantName = merchantId > NPCID.None ? $"NPC {merchantId}" : "Unknown";
        }

        string normalizedSource = string.IsNullOrWhiteSpace(sourceTag) ? "unknown" : sourceTag;
        string normalizedShop = string.IsNullOrWhiteSpace(shopName) ? "-" : shopName;
        string key = $"{normalizedSource}|{merchantName}/{normalizedShop}|sup={(suppressSound ? 1 : 0)}|snd={(soundPlayed ? 1 : 0)}";
        _latestAttemptLine = key;
        _latestAttemptTick = tick;

        _counts.TryGetValue(key, out int current);
        _counts[key] = current + 1;

        if (tick - _lastFlushTick < 60)
        {
            return;
        }

        if (_counts.Count > 0)
        {
            List<KeyValuePair<string, int>> rows = [.. _counts];
            rows.Sort((a, b) => b.Value.CompareTo(a.Value));

            Mod mod = ModContent.GetInstance<MerchantsPlus>();
            int shown = Math.Min(6, rows.Count);
            for (int i = 0; i < shown; i++)
            {
                KeyValuePair<string, int> row = rows[i];
                mod.Logger.Info($"[ShopDiag] {row.Key} -> {row.Value}/s");
            }
        }

        _counts.Clear();
        _lastFlushTick = tick;
    }

    public static string GetLatestAttemptDebug()
    {
        if (Config.Instance?.DevMode != true)
        {
            return string.Empty;
        }

        if (_latestAttemptTick == 0)
        {
            return "LastOpen: none";
        }

        ulong age = Main.GameUpdateCount >= _latestAttemptTick
            ? Main.GameUpdateCount - _latestAttemptTick
            : 0;
        return $"LastOpen: {_latestAttemptLine} ({age} ticks ago)";
    }
}
