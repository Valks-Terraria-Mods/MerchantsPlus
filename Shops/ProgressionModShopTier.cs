namespace MerchantsPlus.Shops;

public sealed class ProgressionModShopTier(int requiredProgression, int price, Func<ModItem[]> itemsFactory)
{
    private readonly Func<ModItem[]> _itemsFactory = itemsFactory;

    public int RequiredProgression { get; } = requiredProgression;
    public int Price { get; } = price;

    public bool IsUnlocked(int progression)
    {
        return progression >= RequiredProgression;
    }

    public ModItem[] GetItems()
    {
        return _itemsFactory();
    }
}
