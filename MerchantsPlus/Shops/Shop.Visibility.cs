namespace MerchantsPlus.Shops;

public abstract partial class Shop
{
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
}
