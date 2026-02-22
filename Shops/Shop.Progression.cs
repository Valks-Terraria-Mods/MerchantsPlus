namespace MerchantsPlus.Shops;

public abstract partial class Shop
{
    /// <summary>
    /// Adds items progressively across a progression window so larger collections unlock gradually.
    /// </summary>
    /// <param name="itemIds">The Terraria item IDs to add progressively.</param>
    /// <param name="minProgression">The progression level where the first item starts unlocking.</param>
    /// <param name="maxProgression">The progression level where the final item unlocks.</param>
    protected void AddStagedItems(IReadOnlyList<int> itemIds, int minProgression = 0, int maxProgression = 21)
    {
        if (itemIds is null || itemIds.Count == 0)
        {
            return;
        }

        minProgression = Math.Clamp(minProgression, 0, 21);
        maxProgression = Math.Clamp(maxProgression, minProgression, 21);

        if (Config.Instance?.UnlockAllItems == true)
        {
            foreach (int itemId in itemIds)
            {
                AddItem(itemId);
            }

            return;
        }

        int progression = Progression.LevelFull();
        for (int i = 0; i < itemIds.Count; i++)
        {
            int requiredProgression = GetStagedRequiredProgression(i, itemIds.Count, minProgression, maxProgression);
            AddItem(itemIds[i], progression >= requiredProgression);
        }
    }

    /// <summary>
    /// Adds items at a fixed price progressively across a progression window.
    /// </summary>
    /// <param name="price">The custom shop price in copper.</param>
    /// <param name="itemIds">The Terraria item IDs to add progressively.</param>
    /// <param name="minProgression">The progression level where the first item starts unlocking.</param>
    /// <param name="maxProgression">The progression level where the final item unlocks.</param>
    protected void AddStagedItemsAtPrice(int price, IReadOnlyList<int> itemIds, int minProgression = 0, int maxProgression = 21)
    {
        if (itemIds is null || itemIds.Count == 0)
        {
            return;
        }

        minProgression = Math.Clamp(minProgression, 0, 21);
        maxProgression = Math.Clamp(maxProgression, minProgression, 21);

        if (Config.Instance?.UnlockAllItems == true)
        {
            foreach (int itemId in itemIds)
            {
                AddItem(itemId, price);
            }

            return;
        }

        for (int i = 0; i < itemIds.Count; i++)
        {
            int requiredProgression = GetStagedRequiredProgression(i, itemIds.Count, minProgression, maxProgression);
            AddItem(itemIds[i], price, requiredProgression);
        }
    }

    /// <summary>
    /// Returns whether at least one staged item in the collection should currently be visible.
    /// </summary>
    protected static bool HasAnyStagedItemVisible(IReadOnlyList<int> itemIds, int minProgression = 0, int maxProgression = 21)
    {
        if (itemIds is null || itemIds.Count == 0)
        {
            return false;
        }

        minProgression = Math.Clamp(minProgression, 0, 21);
        maxProgression = Math.Clamp(maxProgression, minProgression, 21);

        if (Config.Instance?.UnlockAllItems == true)
        {
            foreach (int itemId in itemIds)
            {
                if (itemId > ItemID.None)
                {
                    return true;
                }
            }

            return false;
        }

        int progression = Progression.LevelFull();
        for (int i = 0; i < itemIds.Count; i++)
        {
            if (itemIds[i] <= ItemID.None)
            {
                continue;
            }

            int requiredProgression = GetStagedRequiredProgression(i, itemIds.Count, minProgression, maxProgression);
            if (progression >= requiredProgression)
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// Returns whether at least one conditional offer in the set is currently visible.
    /// </summary>
    protected static bool HasAnyConditionalOfferVisible(IReadOnlyList<ConditionalShopOffer> offers)
    {
        if (offers is null || offers.Count == 0)
        {
            return false;
        }

        if (Config.Instance?.UnlockAllItems == true)
        {
            foreach (ConditionalShopOffer offer in offers)
            {
                if (offer.ItemIds.Length > 0)
                {
                    return true;
                }
            }

            return false;
        }

        foreach (ConditionalShopOffer offer in offers)
        {
            if (offer.IsUnlocked() && offer.ItemIds.Length > 0)
            {
                return true;
            }
        }

        return false;
    }

    private static int GetStagedRequiredProgression(int index, int itemCount, int minProgression, int maxProgression)
    {
        if (itemCount <= 1 || minProgression >= maxProgression)
        {
            return minProgression;
        }

        double t = (double)index / (itemCount - 1);
        return minProgression + (int)Math.Round(t * (maxProgression - minProgression));
    }

    /// <summary>
    /// Adds all progression-gated items that are unlocked at the given progression level.
    /// </summary>
    /// <param name="progression">The current progression level.</param>
    /// <param name="items">The progression item definitions to evaluate.</param>
    protected void AddProgressionItems(int progression, IReadOnlyList<ProgressionShopItem> items)
    {
        foreach (ProgressionShopItem item in items)
        {
            if (item.IsUnlocked(progression))
            {
                AddItem(item.ItemId, item.Price);
            }
        }
    }

    /// <summary>
    /// Adds all progression tiers that are unlocked at the given progression level.
    /// </summary>
    /// <param name="progression">The current progression level.</param>
    /// <param name="tiers">The progression tier definitions to evaluate.</param>
    protected void AddProgressionTiers(int progression, IReadOnlyList<ProgressionShopTier> tiers)
    {
        foreach (ProgressionShopTier tier in tiers)
        {
            if (!tier.IsUnlocked(progression))
            {
                continue;
            }

            foreach (int itemId in tier.ItemIds)
            {
                AddItem(itemId, tier.Price);
            }
        }
    }

    /// <summary>
    /// Adds all mod-item progression tiers that are unlocked at the given progression level.
    /// </summary>
    /// <param name="progression">The current progression level.</param>
    /// <param name="tiers">The mod-item progression tiers to evaluate.</param>
    protected void AddProgressionModItemTiers(int progression, IReadOnlyList<ProgressionModShopTier> tiers)
    {
        foreach (ProgressionModShopTier tier in tiers)
        {
            if (!tier.IsUnlocked(progression))
            {
                continue;
            }

            AddItemsAtPrice(tier.Price, tier.GetItems());
        }
    }

    /// <summary>
    /// Adds all condition-based offers that are currently unlocked.
    /// </summary>
    /// <param name="offers">The conditional offer definitions to evaluate.</param>
    protected void AddConditionalOffers(IReadOnlyList<ConditionalShopOffer> offers)
    {
        foreach (ConditionalShopOffer offer in offers)
        {
            if (!offer.IsUnlocked())
            {
                continue;
            }

            if (offer.Price.HasValue)
            {
                AddItemsAtPrice(offer.Price.Value, offer.ItemIds);
            }
            else
            {
                AddItems(offer.ItemIds);
            }
        }
    }
}
