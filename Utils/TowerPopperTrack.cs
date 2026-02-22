namespace MerchantsPlus.Shops;

public sealed class TowerPopperTrack(int tierOneItemId, int tierTwoItemId, int tierThreeItemId)
{
    public int TierOneItemId { get; } = tierOneItemId;
    public int TierTwoItemId { get; } = tierTwoItemId;
    public int TierThreeItemId { get; } = tierThreeItemId;
}
