using MerchantsPlus;
using MerchantsPlus.UI;
using Terraria.ModLoader;

namespace MerchantsPlus.Utils;

public class ShopUnlockAsteriskProgressionWatcher : ModSystem
{
    private int _lastProgressionLevel = -1;

    public override void PostUpdateWorld()
    {
        int current = Progression.LevelFull();
        if (_lastProgressionLevel != current)
        {
            _lastProgressionLevel = current;
            ShopUnlockAsteriskTracker.NotifyProgressionChanged();
        }
    }
}
