using Terraria.Audio;

namespace MerchantsPlus.Shops;

public abstract class Shop
{
    public abstract List<string> Shops { get; }
    public int CycleIndex { get; set; }
    private static int _forcedContextNpcType = NPCID.None;
    private static int _forcedContextNpcIndex = -1;
    private static bool _suppressOpenSound;

    protected Chest Inv;
    protected int NextSlot;

    private bool HasAvailableSlot()
    {
        return Inv?.item is not null && (uint)NextSlot < (uint)Inv.item.Length;
    }

    /// <summary>
    /// Initializes the custom shop inventory for the current NPC interaction.
    /// </summary>
    /// <param name="shop">The selected shop tab name.</param>
    public virtual void OpenShop(string shop)
    {
        if (!_suppressOpenSound)
        {
            SoundEngine.PlaySound(SoundID.MenuTick);
        }

        Main.playerInventory = true;
        Main.npcChatText = "";
        EnsureForcedTalkNpcAssigned();

        // Not sure what this line of code does
        // Note that any number greater than 1 will cause index out of bounds error
        // freezing the game
        // If this line of code is commented out then an error will appear saying
        // "Object reference not set to an instance of an object"
        Main.SetNPCShopIndex(1);

        NPC npc = GetShopContextNpc();

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
    /// Opens a shop tab using the provided NPC type as context when no NPC is being talked to.
    /// </summary>
    /// <param name="shop">The selected shop tab name.</param>
    /// <param name="npcType">The NPC type to use as the shop context.</param>
    public void OpenShopForNpcType(string shop, int npcType, bool suppressSound = false)
    {
        int previousNpcType = _forcedContextNpcType;
        int previousNpcIndex = _forcedContextNpcIndex;
        bool previousSuppressOpenSound = _suppressOpenSound;
        _forcedContextNpcType = npcType;
        _forcedContextNpcIndex = FindFallbackTalkNpcIndex(npcType);
        _suppressOpenSound = suppressSound;

        try
        {
            if (_forcedContextNpcIndex >= 0 && Main.LocalPlayer is not null)
            {
                Main.LocalPlayer.SetTalkNPC(_forcedContextNpcIndex);
            }

            OpenShop(shop);
        }
        finally
        {
            _forcedContextNpcType = previousNpcType;
            _forcedContextNpcIndex = previousNpcIndex;
            _suppressOpenSound = previousSuppressOpenSound;
        }
    }

    private static NPC GetShopContextNpc()
    {
        NPC talkNpc = Main.LocalPlayer?.TalkNPC;
        if (talkNpc is not null && talkNpc.active && talkNpc.type > NPCID.None)
        {
            return talkNpc;
        }

        if (_forcedContextNpcIndex >= 0
            && (uint)_forcedContextNpcIndex < (uint)Main.npc.Length
            && Main.npc[_forcedContextNpcIndex].active
            && Main.npc[_forcedContextNpcIndex].type > NPCID.None)
        {
            return Main.npc[_forcedContextNpcIndex];
        }

        int npcType = _forcedContextNpcType;
        if (npcType <= NPCID.None)
        {
            npcType = NPCID.Merchant;
        }

        NPC activeNpc = Array.Find(Main.npc, npc => npc.active && npc.type == npcType);
        if (activeNpc is not null)
        {
            return activeNpc;
        }

        NPC npcContext = new();
        npcContext.SetDefaults(npcType);
        return npcContext;
    }

    private static void EnsureForcedTalkNpcAssigned()
    {
        if (_forcedContextNpcIndex < 0 && _forcedContextNpcType <= NPCID.None)
        {
            return;
        }

        if (_forcedContextNpcIndex < 0 || _forcedContextNpcIndex >= Main.maxNPCs || !Main.npc[_forcedContextNpcIndex].active)
        {
            _forcedContextNpcIndex = FindFallbackTalkNpcIndex(_forcedContextNpcType);
        }

        if (_forcedContextNpcIndex >= 0 && Main.LocalPlayer is not null)
        {
            Main.LocalPlayer.SetTalkNPC(_forcedContextNpcIndex);
        }
    }

    private static int FindFallbackTalkNpcIndex(int preferredNpcType)
    {
        if (Main.LocalPlayer is not null)
        {
            int nearbyTownNpc = FindNearestTalkableTownNpc(Main.LocalPlayer.Center, 480f);
            if (nearbyTownNpc >= 0)
            {
                return nearbyTownNpc;
            }
        }

        if (preferredNpcType > NPCID.None)
        {
            int preferred = Array.FindIndex(Main.npc, npc => npc.active && npc.type == preferredNpcType);
            if (preferred >= 0)
            {
                return preferred;
            }
        }

        int townNpc = Array.FindIndex(Main.npc, npc => npc.active && npc.townNPC);
        if (townNpc >= 0)
        {
            return townNpc;
        }

        return Array.FindIndex(Main.npc, npc => npc.active);
    }

    private static int FindNearestTalkableTownNpc(Vector2 center, float maxDistance)
    {
        float maxDistanceSquared = maxDistance * maxDistance;
        int bestIndex = -1;
        float bestDistanceSquared = maxDistanceSquared;

        for (int i = 0; i < Main.npc.Length; i++)
        {
            NPC npc = Main.npc[i];
            if (!npc.active || !npc.townNPC)
            {
                continue;
            }

            float distSq = Vector2.DistanceSquared(center, npc.Center);
            if (distSq <= bestDistanceSquared)
            {
                bestDistanceSquared = distSq;
                bestIndex = i;
            }
        }

        return bestIndex;
    }

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
    /// Builds the shop tab list by combining base tabs with expansion catalog tabs for a merchant.
    /// </summary>
    /// <param name="merchantNpcId">The NPC ID of the merchant owning these shop tabs.</param>
    /// <param name="baseShops">The base shop tab names.</param>
    /// <returns>The combined list of shop tab names.</returns>
    protected static List<string> BuildShopList(int merchantNpcId, IEnumerable<string> baseShops)
    {
        List<string> shops = [];
        HashSet<string> seen = new(StringComparer.Ordinal);

        foreach (string shop in baseShops)
        {
            if (!string.IsNullOrWhiteSpace(shop) && seen.Add(shop))
            {
                shops.Add(shop);
            }
        }

        foreach (string shop in ShopExpandedCatalog.GetShopNames(merchantNpcId))
        {
            if (!string.IsNullOrWhiteSpace(shop) && seen.Add(shop))
            {
                shops.Add(shop);
            }
        }

        return shops;
    }

    /// <summary>
    /// Determines whether a non-expanded (base) shop tab should currently be visible.
    /// </summary>
    /// <param name="shopName">The base shop tab name.</param>
    /// <returns><c>true</c> if the tab should be visible; otherwise <c>false</c>.</returns>
    public virtual bool IsBaseShopVisible(string shopName)
    {
        return true;
    }

    /// <summary>
    /// Returns only shop tabs that should currently be visible to the player.
    /// </summary>
    /// <param name="merchantNpcId">The NPC ID of the merchant owning these tabs.</param>
    /// <param name="shops">All tabs (base and expansion) for the merchant.</param>
    /// <returns>A filtered list containing currently visible tabs.</returns>
    public static List<string> GetVisibleShops(int merchantNpcId, IReadOnlyList<string> shops)
    {
        return GetVisibleShops(merchantNpcId, null, shops);
    }

    /// <summary>
    /// Returns only shop tabs that should currently be visible to the player.
    /// </summary>
    /// <param name="merchantNpcId">The NPC ID of the merchant owning these tabs.</param>
    /// <param name="merchantShop">The merchant shop instance, used for base-tab visibility checks.</param>
    /// <param name="shops">All tabs (base and expansion) for the merchant.</param>
    /// <returns>A filtered list containing currently visible tabs.</returns>
    public static List<string> GetVisibleShops(int merchantNpcId, Shop merchantShop, IReadOnlyList<string> shops)
    {
        List<string> visible = new(shops.Count);
        HashSet<string> seen = new(StringComparer.Ordinal);

        foreach (string shop in shops)
        {
            if (string.IsNullOrWhiteSpace(shop) || !seen.Add(shop))
            {
                continue;
            }

            if (!ShopExpandedCatalog.TryGetPage(merchantNpcId, shop, out ShopExpandedCatalog.ShopPage page))
            {
                if (merchantShop?.IsBaseShopVisible(shop) ?? true)
                {
                    visible.Add(shop);
                }
                continue;
            }

            if (HasVisibleExpandedItems(page))
            {
                visible.Add(shop);
            }
        }

        return visible;
    }

    /// <summary>
    /// Opens an expansion shop tab for the given merchant when available and unlocked.
    /// </summary>
    /// <param name="merchantNpcId">The NPC ID of the merchant owning the expansion tabs.</param>
    /// <param name="shop">The selected shop tab name.</param>
    /// <returns><c>true</c> if the selected tab belongs to expansion content; otherwise, <c>false</c>.</returns>
    protected bool OpenExpandedShop(int merchantNpcId, string shop)
    {
        if (!ShopExpandedCatalog.TryGetPage(merchantNpcId, shop, out ShopExpandedCatalog.ShopPage page))
        {
            return false;
        }

        if (Config.Instance?.UnlockAllItems == true)
        {
            foreach (ShopExpandedCatalog.ShopItem item in page.Items)
            {
                AddItem(item.ItemId);
            }
            return true;
        }

        int progression = Progression.LevelFull();
        foreach (ShopExpandedCatalog.ShopItem item in page.Items)
        {
            AddItem(item.ItemId, progression >= item.RequiredProgression);
        }

        return true;
    }

    private static bool HasVisibleExpandedItems(ShopExpandedCatalog.ShopPage page)
    {
        if (page.Items.Length == 0)
        {
            return false;
        }

        if (Config.Instance?.UnlockAllItems == true)
        {
            return true;
        }

        int progression = Progression.LevelFull();
        foreach (ShopExpandedCatalog.ShopItem item in page.Items)
        {
            if (progression >= item.RequiredProgression)
            {
                return true;
            }
        }

        return false;
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
