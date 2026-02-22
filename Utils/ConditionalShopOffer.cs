namespace MerchantsPlus.Shops;

public sealed class ConditionalShopOffer
{
    public Func<bool> Condition { get; }
    public int? Price { get; }
    public int[] ItemIds { get; }

    public ConditionalShopOffer(Func<bool> condition, params int[] itemIds)
    {
        Condition = condition;
        ItemIds = itemIds;
    }

    public ConditionalShopOffer(Func<bool> condition, int price, params int[] itemIds)
    {
        Condition = condition;
        Price = price;
        ItemIds = itemIds;
    }

    public bool IsUnlocked()
    {
        return Condition();
    }
}
