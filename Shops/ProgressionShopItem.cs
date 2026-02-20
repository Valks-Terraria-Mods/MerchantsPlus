namespace MerchantsPlus.Shops;

public sealed class ProgressionShopItem(int requiredProgression, int itemId, int price)
{
    public int RequiredProgression { get; } = requiredProgression;
    public int ItemId { get; } = itemId;
    public int Price { get; } = price;

    public bool IsUnlocked(int progression)
    {
        return progression >= RequiredProgression;
    }
}
