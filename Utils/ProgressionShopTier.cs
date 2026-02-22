namespace MerchantsPlus.Shops;

public sealed class ProgressionShopTier(int requiredProgression, int price, params int[] itemIds)
{
    public int RequiredProgression { get; } = requiredProgression;
    public int Price { get; } = price;
    public IReadOnlyList<int> ItemIds { get; } = itemIds;

    public bool IsUnlocked(int progression)
    {
        return progression >= RequiredProgression;
    }
}
