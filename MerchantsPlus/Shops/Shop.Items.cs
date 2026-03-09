namespace MerchantsPlus.Shops;

public abstract partial class Shop
{
    /// <summary>
    /// Adds an item to the next available shop slot when the condition is met.
    /// </summary>
    /// <param name="itemId">The Terraria item ID to add.</param>
    /// <param name="condition">Whether the item should be added.</param>
    protected void AddItem(int itemId, bool condition = true)
    {
        if (condition && itemId > ItemID.None && HasAvailableSlot())
        {
            Inv.item[NextSlot].SetDefaults(itemId);
            EnsureMinimumSellPrice(NextSlot);
            NextSlot++;
        }
    }

    /// <summary>
    /// Adds an item with a custom price when progression requirements are met.
    /// </summary>
    /// <param name="itemId">The Terraria item ID to add.</param>
    /// <param name="price">The custom shop price in copper.</param>
    /// <param name="progression">The minimum progression level required.</param>
    protected void AddItem(int itemId, int price, int progression = 0)
    {
        if (itemId > ItemID.None && Progression.LevelFull() >= progression && HasAvailableSlot())
        {
            Inv.item[NextSlot].SetDefaults(itemId);
            Inv.item[NextSlot++].shopCustomPrice = price;
        }
    }

    /// <summary>
    /// Adds a mod item with a custom price when progression requirements are met.
    /// </summary>
    /// <param name="item">The mod item instance to add.</param>
    /// <param name="price">The custom shop price in copper.</param>
    /// <param name="progression">The minimum progression level required.</param>
    protected void AddItem(ModItem item, int price, int progression = 0)
    {
        AddItem(item.Type, price, progression);
    }

    /// <summary>
    /// Adds multiple items to consecutive shop slots.
    /// </summary>
    /// <param name="itemIds">The Terraria item IDs to add.</param>
    protected void AddItems(params int[] itemIds)
    {
        foreach (int itemId in itemIds)
        {
            AddItem(itemId);
        }
    }

    /// <summary>
    /// Adds multiple vanilla items at the same custom price.
    /// </summary>
    /// <param name="price">The custom shop price in copper.</param>
    /// <param name="itemIds">The Terraria item IDs to add.</param>
    protected void AddItemsAtPrice(int price, params int[] itemIds)
    {
        foreach (int itemId in itemIds)
        {
            AddItem(itemId, price);
        }
    }

    /// <summary>
    /// Adds multiple mod items at the same custom price.
    /// </summary>
    /// <param name="price">The custom shop price in copper.</param>
    /// <param name="items">The mod items to add.</param>
    protected void AddItemsAtPrice(int price, params ModItem[] items)
    {
        foreach (ModItem item in items)
        {
            AddItem(item, price);
        }
    }

    /// <summary>
    /// Adds an item to the next available shop slot when the condition is met.
    /// </summary>
    /// <param name="condition">Whether the item should be added.</param>
    /// <param name="itemId">The Terraria item ID to add.</param>
    protected void AddItem(bool condition, int itemId)
    {
        if (condition && itemId > ItemID.None && HasAvailableSlot())
        {
            Inv.item[NextSlot].SetDefaults(itemId);
            EnsureMinimumSellPrice(NextSlot);
            NextSlot++;
        }
    }

    /// <summary>
    /// Adds an item with a custom price when both condition and progression requirements are met.
    /// </summary>
    /// <param name="condition">Whether the item should be added.</param>
    /// <param name="itemId">The Terraria item ID to add.</param>
    /// <param name="price">The custom shop price in copper.</param>
    /// <param name="progression">The minimum progression level required.</param>
    protected void AddItem(bool condition, int itemId, int price, int progression = 0)
    {
        if (condition && itemId > ItemID.None && Progression.LevelFull() >= progression && HasAvailableSlot())
        {
            Inv.item[NextSlot].SetDefaults(itemId);
            Inv.item[NextSlot++].shopCustomPrice = price;
        }
    }

    /// <summary>
    /// Replaces the current shop slot item.
    /// </summary>
    /// <param name="itemId">The Terraria item ID to set in the current slot.</param>
    protected void ReplaceItem(int itemId)
    {
        if (!HasAvailableSlot())
        {
            return;
        }

        Inv.item[NextSlot].SetDefaults(itemId);
        EnsureMinimumSellPrice(NextSlot);
    }

    /// <summary>
    /// Replaces the current shop slot item when the condition is met.
    /// </summary>
    /// <param name="condition">Whether the item should be replaced.</param>
    /// <param name="itemId">The Terraria item ID to set in the current slot.</param>
    protected void ReplaceItem(bool condition, int itemId)
    {
        if (condition && HasAvailableSlot())
        {
            Inv.item[NextSlot].SetDefaults(itemId);
            EnsureMinimumSellPrice(NextSlot);
        }
    }

    /// <summary>
    /// Replaces the current shop slot item and sets a custom price.
    /// </summary>
    /// <param name="itemId">The Terraria item ID to set in the current slot.</param>
    /// <param name="price">The custom shop price in copper.</param>
    protected void ReplaceItem(int itemId, int price)
    {
        if (!HasAvailableSlot())
        {
            return;
        }

        Inv.item[NextSlot].SetDefaults(itemId);
        Inv.item[NextSlot].shopCustomPrice = price;
    }

    /// <summary>
    /// Replaces the current shop slot item and price when the condition is met.
    /// </summary>
    /// <param name="condition">Whether the item should be replaced.</param>
    /// <param name="itemId">The Terraria item ID to set in the current slot.</param>
    /// <param name="price">The custom shop price in copper.</param>
    protected void ReplaceItem(bool condition, int itemId, int price)
    {
        if (condition && HasAvailableSlot())
        {
            Inv.item[NextSlot].SetDefaults(itemId);
            Inv.item[NextSlot].shopCustomPrice = price;
        }
    }

    private void EnsureMinimumSellPrice(int slot)
    {
        if (Inv?.item is null || (uint)slot >= (uint)Inv.item.Length)
        {
            return;
        }

        Item item = Inv.item[slot];
        if (item is null || item.IsAir)
        {
            return;
        }

        if (item.shopCustomPrice.HasValue)
        {
            return;
        }

        if (item.value <= 0)
        {
            item.shopCustomPrice = Coins.Copper();
        }
    }

    /// <summary>
    /// Replaces the custom price of the current shop slot.
    /// </summary>
    /// <param name="price">The custom shop price in copper.</param>
    protected void ReplacePrice(int price)
    {
        if (!HasAvailableSlot())
        {
            return;
        }

        Inv.item[NextSlot].shopCustomPrice = price;
    }

    /// <summary>
    /// Replaces the custom price of the current shop slot when the condition is met.
    /// </summary>
    /// <param name="condition">Whether the price should be replaced.</param>
    /// <param name="price">The custom shop price in copper.</param>
    protected void ReplacePrice(bool condition, int price)
    {
        if (condition && HasAvailableSlot())
        {
            Inv.item[NextSlot].shopCustomPrice = price;
        }
    }
}
