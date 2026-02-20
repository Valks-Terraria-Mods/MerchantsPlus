using Terraria.Audio;

namespace MerchantsPlus.Shops;

public abstract class Shop
{
    public abstract List<string> Shops { get; }
    public int CycleIndex { get; set; }

    protected Chest Inv;
    protected int NextSlot;

    /// <summary>
    /// Initializes the custom shop inventory for the current NPC interaction.
    /// </summary>
    /// <param name="shop">The selected shop tab name.</param>
    public virtual void OpenShop(string shop)
    {
        SoundEngine.PlaySound(SoundID.MenuTick);
        Main.playerInventory = true;
        Main.npcChatText = "";

        // Not sure what this line of code does
        // Note that any number greater than 1 will cause index out of bounds error
        // freezing the game
        // If this line of code is commented out then an error will appear saying
        // "Object reference not set to an instance of an object"
        Main.SetNPCShopIndex(1);

        NPC npc = Main.LocalPlayer.TalkNPC;

        // For future reference this code was updated from
        // https://github.com/tModLoader/tModLoader/blob/e6caaaf678efd2a69deece4d72fdaecc4391bd26/patches/tModLoader/Terraria/ModLoader/NPCLoader.cs#L1192
        Inv = Main.instance.shop[Main.npcShop];

        // Setting this to '2' will set up the shop items for the arms dealer
        // The arms dealer sells 3 guns
        Inv.SetupShop(NPCShopDatabase.GetShopNameFromVanillaIndex(2), npc);

        // Let's remove these guns as we will add our own items later
        foreach (Item item in Inv.item)
        {
            item.SetDefaults(ItemID.None);
        }

        NextSlot = 0;
    }

    /// <summary>
    /// Adds an item to the next available shop slot when the condition is met.
    /// </summary>
    /// <param name="itemId">The Terraria item ID to add.</param>
    /// <param name="condition">Whether the item should be added.</param>
    protected void AddItem(int itemId, bool condition = true)
    {
        if (condition && itemId > ItemID.None)
        {
            Inv.item[NextSlot++].SetDefaults(itemId);
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
        if (itemId > ItemID.None && Progression.LevelFull() >= progression)
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

    /// <summary>
    /// Adds an item to the next available shop slot when the condition is met.
    /// </summary>
    /// <param name="condition">Whether the item should be added.</param>
    /// <param name="itemId">The Terraria item ID to add.</param>
    protected void AddItem(bool condition, int itemId)
    {
        if (condition && itemId > ItemID.None)
        {
            Inv.item[NextSlot++].SetDefaults(itemId);
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
        if (condition && itemId > ItemID.None && Progression.LevelFull() >= progression)
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
        Inv.item[NextSlot].SetDefaults(itemId);
    }

    /// <summary>
    /// Replaces the current shop slot item when the condition is met.
    /// </summary>
    /// <param name="condition">Whether the item should be replaced.</param>
    /// <param name="itemId">The Terraria item ID to set in the current slot.</param>
    protected void ReplaceItem(bool condition, int itemId)
    {
        if (condition)
            Inv.item[NextSlot].SetDefaults(itemId);
    }

    /// <summary>
    /// Replaces the current shop slot item and sets a custom price.
    /// </summary>
    /// <param name="itemId">The Terraria item ID to set in the current slot.</param>
    /// <param name="price">The custom shop price in copper.</param>
    protected void ReplaceItem(int itemId, int price)
    {
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
        if (condition)
        {
            Inv.item[NextSlot].SetDefaults(itemId);
            Inv.item[NextSlot].shopCustomPrice = price;
        }
    }

    /// <summary>
    /// Replaces the custom price of the current shop slot.
    /// </summary>
    /// <param name="price">The custom shop price in copper.</param>
    protected void ReplacePrice(int price)
    {
        Inv.item[NextSlot].shopCustomPrice = price;
    }

    /// <summary>
    /// Replaces the custom price of the current shop slot when the condition is met.
    /// </summary>
    /// <param name="condition">Whether the price should be replaced.</param>
    /// <param name="price">The custom shop price in copper.</param>
    protected void ReplacePrice(bool condition, int price)
    {
        if (condition)
            Inv.item[NextSlot].shopCustomPrice = price;
    }

    /// <summary>
    /// Returns a display-friendly shop name derived from the class name.
    /// </summary>
    /// <returns>The shop name without the <c>Shop</c> prefix and with spaced capitals.</returns>
    public override string ToString()
    {
        return GetType().Name.Replace("Shop", "").AddSpaceBeforeEachCapital();
    }
}
