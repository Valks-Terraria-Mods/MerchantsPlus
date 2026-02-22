using MerchantsPlus.Shops;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;
using Terraria.GameContent.UI.Elements;
using Terraria.GameInput;

namespace MerchantsPlus.UI;

public class ShopUI : UIState
{
    private const float PanelWidth = 375f;
    private const float PanelHeight = 114f;
    private const string HintPrefix = "Hint: ";
    private const float HintScale = 0.65f;
    private const float LeftColumnX = 16f;
    private const float LeftColumnWidth = 160f;
    private const float ListLeft = 170f;
    private const float ListTop = 4f;
    private const float ListBottomPadding = 34f;
    private const float HintLeft = LeftColumnX;
    private const float HintTop = 93f;
    private const float HintWrapWidth = PanelWidth - 16f;
    private readonly record struct ShopUnlockInfo(int LockedCount, int NextRequiredProgression, int NextItemId, bool HasCatalogData);

    public static Dictionary<int, Shop> Shops { get; } = CreateShops();

    public static bool Visible { get; set; }
    public static int CurrentMerchantId { get; set; }

    private UIText _merchantNameText;
    private UIText _shopNameText;
    private UIText _hintText;
    private UIList _shopList;
    private DraggableUIPanel _rootPanel;
    private int _lastMerchantId = NPCID.None;
    private int _lastSelectedIndex = -1;
    private string _lastShopsSignature = string.Empty;
    private int _lastHintMerchantId = NPCID.None;
    private string _lastHintShopName = string.Empty;
    private int _lastHintProgressionLevel = int.MinValue;
    private bool _lastHintUnlockAll;
    private string _lastHintText = string.Empty;

    private static Dictionary<int, Shop> CreateShops()
    {
        Dictionary<int, Shop> shops = new()
        {
            { NPCID.Angler, new ShopAngler() },
            { NPCID.ArmsDealer, new ShopArmsDealer() },
            { NPCID.Clothier, new ShopClothier() },
            { NPCID.Cyborg, new ShopCyborg() },
            { NPCID.Demolitionist, new ShopDemolitionist() },
            { NPCID.Dryad, new ShopDryad() },
            { NPCID.DyeTrader, new ShopDyeTrader() },
            { NPCID.GoblinTinkerer, new ShopGoblinTinkerer() },
            { NPCID.Mechanic, new ShopMechanic() },
            { NPCID.Merchant, new ShopMerchant() },
            { NPCID.Nurse, new ShopNurse() },
            { NPCID.Painter, new ShopPainter() },
            { NPCID.PartyGirl, new ShopPartyGirl() },
            { NPCID.Pirate, new ShopPirate() },
            { NPCID.SantaClaus, new ShopSantaClaus() },
            { NPCID.SkeletonMerchant, new ShopSkeletonMerchant() },
            { NPCID.Steampunker, new ShopSteampunker() },
            { NPCID.Stylist, new ShopStylist() },
            { NPCID.DD2Bartender, new ShopTavernkeep() },
            { NPCID.TaxCollector, new ShopTaxCollector() },
            { NPCID.TravellingMerchant, new ShopTravellingMerchant() },
            { NPCID.Truffle, new ShopTruffle() },
            { NPCID.WitchDoctor, new ShopWitchDoctor() },
            { NPCID.Wizard, new ShopWizard() },
            { NPCID.Guide, new ShopGuide() },
        };

        AddExpandedOnlyShop(shops, NPCID.Golfer);
        AddExpandedOnlyShop(shops, NPCID.Princess);

        AddExpandedOnlyShop(shops, "TownCat");
        AddExpandedOnlyShop(shops, "TownDog");
        AddExpandedOnlyShop(shops, "TownBunny");

        AddExpandedOnlyShop(shops, "TownSlimeBlue");    // Nerdy Slime
        AddExpandedOnlyShop(shops, "TownSlimeGreen");   // Cool Slime
        AddExpandedOnlyShop(shops, "TownSlimeOld");     // Elder Slime
        AddExpandedOnlyShop(shops, "TownSlimePurple");  // Clumsy Slime
        AddExpandedOnlyShop(shops, "TownSlimeRainbow"); // Diva Slime
        AddExpandedOnlyShop(shops, "TownSlimeRed");     // Surly Slime
        AddExpandedOnlyShop(shops, "TownSlimeYellow");  // Mystic Slime
        AddExpandedOnlyShop(shops, "TownSlimeCopper");  // Squire Slime

        return shops;
    }

    private static void AddExpandedOnlyShop(Dictionary<int, Shop> shops, int npcId)
    {
        if (npcId < 0 || shops.ContainsKey(npcId))
        {
            return;
        }

        shops[npcId] = new ShopExpandedOnly(npcId);
    }

    private static void AddExpandedOnlyShop(Dictionary<int, Shop> shops, string npcName)
    {
        int npcId = NPCID.Search.GetId(npcName);
        AddExpandedOnlyShop(shops, npcId);
    }

    public override void OnInitialize()
    {
        _rootPanel = new DraggableUIPanel();
        DraggableUIPanel panel = _rootPanel;
        panel.SetPadding(0);
        panel.Left.Set(75f, 0f);
        panel.Top.Set(428f, 0f);
        panel.Width.Set(PanelWidth, 0f);
        panel.Height.Set(PanelHeight, 0f);
        panel.BackgroundColor = new Color(0, 0, 0, 153);
        panel.ClampToScreen = true;

        UIElement dragHandle = new();
        dragHandle.Left.Set(0f, 0f);
        dragHandle.Top.Set(0f, 0f);
        dragHandle.Width.Set(0f, 1f);
        dragHandle.Height.Set(20f, 0f);
        dragHandle.OnLeftMouseDown += panel.StartDrag;
        dragHandle.OnLeftMouseUp += panel.StopDrag;
        panel.Append(dragHandle);

        _merchantNameText = new UIText("Merchant: -", 0.72f)
        {
            HAlign = 0f,
        };
        _merchantNameText.Left.Set(LeftColumnX, 0f);
        _merchantNameText.Top.Set(14f, 0f);
        panel.Append(_merchantNameText);

        _shopNameText = new UIText("Shop: -", 0.72f)
        {
            HAlign = 0f,
        };
        _shopNameText.Left.Set(LeftColumnX, 0f);
        _shopNameText.Top.Set(38f, 0f);
        panel.Append(_shopNameText);

        _hintText = new UIText($"{HintPrefix}-", HintScale)
        {
            HAlign = 0f,
        };
        _hintText.Left.Set(HintLeft, 0f);
        _hintText.Top.Set(HintTop, 0f);
        panel.Append(_hintText);

        UIPanel shopListContainer = new();
        shopListContainer.SetPadding(0f);
        shopListContainer.Left.Set(ListLeft, 0f);
        shopListContainer.Top.Set(ListTop, 0f);
        shopListContainer.Width.Set(PanelWidth - ListLeft - 6f, 0f);
        shopListContainer.Height.Set(PanelHeight - ListTop - ListBottomPadding, 0f);
        shopListContainer.BackgroundColor = Color.Transparent;
        shopListContainer.BorderColor = Color.Transparent;
        panel.Append(shopListContainer);

        _shopList = new UIList
        {
            ListPadding = 2f,
        };
        _shopList.Left.Set(2f, 0f);
        _shopList.Top.Set(2f, 0f);
        _shopList.Width.Set(-34f, 1f);
        _shopList.Height.Set(-4f, 1f);
        shopListContainer.Append(_shopList);

        UIScrollbar scrollbar = new DarkScrollbar();
        scrollbar.Left.Set(-20f, 1f);
        scrollbar.Top.Set(8f, 0f);
        scrollbar.Height.Set(-12f, 1f);
        scrollbar.Width.Set(12f, 0f);
        _shopList.SetScrollbar(scrollbar);
        shopListContainer.Append(scrollbar);

        Append(panel);
    }

    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);

        if (Main.LocalPlayer is not null && _rootPanel?.ContainsPoint(Main.MouseScreen) == true)
        {
            Main.LocalPlayer.mouseInterface = true;
            PlayerInput.LockVanillaMouseScroll("MerchantsPlus.ShopUI");
        }
    }

    public override void Draw(SpriteBatch spriteBatch)
    {
        base.Draw(spriteBatch);

        if (Main.LocalPlayer is not null && _rootPanel is not null)
        {
            _ = UIUtils.IsInteractiveHover(_rootPanel);
        }
    }

    public bool IsPointerOverPanel()
    {
        return _rootPanel?.ContainsPoint(Main.MouseScreen) == true;
    }

    public override void OnActivate()
    {
        Visible = true;
    }

    public override void OnDeactivate()
    {
        Visible = false;
        _lastMerchantId = NPCID.None;
        _lastSelectedIndex = -1;
        _lastShopsSignature = string.Empty;
        _lastHintMerchantId = NPCID.None;
        _lastHintShopName = string.Empty;
        _lastHintProgressionLevel = int.MinValue;
        _lastHintUnlockAll = false;
        _lastHintText = string.Empty;
    }

    public void UpdateUI()
    {
        if (!Visible || !Shops.TryGetValue(CurrentMerchantId, out Shop shop))
        {
            return;
        }

        NPC npc = Array.Find(Main.npc, n => n.active && n.type == CurrentMerchantId);
        List<string> visibleShops = Shop.GetVisibleShops(CurrentMerchantId, shop, shop.Shops);

        _merchantNameText.SetText($"Merchant: {(npc != null ? npc.TypeName : "Merchant")}");

        if (visibleShops.Count > 0)
        {
            if (shop.CycleIndex >= visibleShops.Count)
            {
                shop.CycleIndex = 0;
            }

            string selectedShopName = visibleShops[shop.CycleIndex];
            _shopNameText.SetText($"Shop: {selectedShopName}");
            _hintText.SetText(WrapHintText($"{HintPrefix}{GetCachedShopHint(CurrentMerchantId, selectedShopName)}"));
        }
        else
        {
            _shopNameText.SetText("Shop: -");
            _hintText.SetText(WrapHintText($"{HintPrefix}No unlocked shops are visible yet."));
        }

        string shopsSignature = string.Join('\u001F', visibleShops);
        if (_lastMerchantId == CurrentMerchantId
            && _lastShopsSignature == shopsSignature
            && _lastSelectedIndex == shop.CycleIndex)
        {
            return;
        }

        PopulateShopList(visibleShops, shop.CycleIndex);
        _lastMerchantId = CurrentMerchantId;
        _lastSelectedIndex = shop.CycleIndex;
        _lastShopsSignature = shopsSignature;
    }

    private void PopulateShopList(IReadOnlyList<string> visibleShops, int selectedIndex)
    {
        _shopList.Clear();

        if (visibleShops.Count == 0)
        {
            UITextPanel<string> empty = CreateShopEntry("No unlocked shops", selected: false);
            empty.OnLeftClick += (_, _) => { };
            _shopList.Add(empty);
            return;
        }

        for (int i = 0; i < visibleShops.Count; i++)
        {
            int capturedIndex = i;
            string capturedShop = visibleShops[i];
            UITextPanel<string> entry = CreateShopEntry(capturedShop, capturedIndex == selectedIndex);
            entry.OnLeftClick += (_, _) => OpenShopByIndex(capturedIndex, capturedShop);
            _shopList.Add(entry);
        }
    }

    private static UITextPanel<string> CreateShopEntry(string text, bool selected)
    {
        UITextPanel<string> panel = new(text, 0.76f, false)
        {
            PaddingTop = 3f,
            PaddingBottom = 3f,
        };
        panel.Width.Set(-2f, 1f);
        panel.Height.Set(28f, 0f);
        panel.BackgroundColor = selected
            ? new Color(26, 26, 26, 220)
            : new Color(12, 12, 12, 190);
        panel.BorderColor = new Color(40, 40, 40, 210);
        return panel;
    }

    private void OpenShopByIndex(int selectedIndex, string shopName)
    {
        if (!Shops.TryGetValue(CurrentMerchantId, out Shop shop))
        {
            return;
        }

        shop.CycleIndex = selectedIndex;
        _lastSelectedIndex = -1;
        UpdateUI();
        shop.OpenShop(shopName);
    }

    private string GetCachedShopHint(int merchantId, string shopName)
    {
        int progressionLevel = Progression.LevelFull();
        bool unlockAll = Config.Instance?.UnlockAllItems == true;

        if (merchantId == _lastHintMerchantId
            && string.Equals(shopName, _lastHintShopName, StringComparison.Ordinal)
            && progressionLevel == _lastHintProgressionLevel
            && unlockAll == _lastHintUnlockAll
            && !string.IsNullOrWhiteSpace(_lastHintText))
        {
            return _lastHintText;
        }

        _lastHintMerchantId = merchantId;
        _lastHintShopName = shopName ?? string.Empty;
        _lastHintProgressionLevel = progressionLevel;
        _lastHintUnlockAll = unlockAll;
        _lastHintText = ComputeShopHint(merchantId, shopName);
        return _lastHintText;
    }

    private static string ComputeShopHint(int merchantId, string shopName)
    {
        if (string.IsNullOrWhiteSpace(shopName))
        {
            return "Select a shop from the list.";
        }

        if (Config.Instance?.UnlockAllItems == true)
        {
            return "Show All Items is enabled.";
        }

        ShopUnlockInfo info = GetShopUnlockInfo(merchantId, shopName);
        if (!info.HasCatalogData)
        {
            return GetDynamicShopHint(merchantId, shopName);
        }

        if (info.LockedCount <= 0 || info.NextItemId <= ItemID.None || info.NextRequiredProgression <= 0)
        {
            return "All items currently unlocked for this shop.";
        }

        string itemName = GetItemDisplayName(info.NextItemId);
        string unlockHint = Progression.GetLevelFullUnlockHint(info.NextRequiredProgression);
        return string.IsNullOrWhiteSpace(itemName)
            ? unlockHint
            : $"Next: {itemName}. {unlockHint}";
    }

    private static string GetDynamicShopHint(int merchantId, string shopName)
    {
        if (Config.Instance?.UnlockAllItems == true)
        {
            return "Show All Items is enabled.";
        }

        List<int> currentItems = SnapshotShopItemsAtState(merchantId, shopName, Progression.LevelFull(), forceUnlockAllItems: false);
        if (currentItems.Count == 0)
        {
            return "No items currently visible in this shop.";
        }

        HashSet<int> currentSet = [.. currentItems];
        int currentLevel = Progression.LevelFull();

        for (int nextLevel = currentLevel + 1; nextLevel <= 21; nextLevel++)
        {
            List<int> futureItems = SnapshotShopItemsAtState(merchantId, shopName, nextLevel, forceUnlockAllItems: false);
            int nextProgressionItem = GetFirstNewItem(futureItems, currentSet);
            if (nextProgressionItem > ItemID.None)
            {
                return $"Next: {GetItemDisplayName(nextProgressionItem)}. {Progression.GetLevelFullUnlockHint(nextLevel)}";
            }
        }

        List<int> allItems = SnapshotShopItemsAtState(merchantId, shopName, 21, forceUnlockAllItems: true);
        int eventLockedItem = GetFirstNewItem(allItems, currentSet);
        if (eventLockedItem > ItemID.None)
        {
            return $"Next: {GetItemDisplayName(eventLockedItem)}. Defeat related enemies/events in addition to boss progression.";
        }

        return "All items currently unlocked for this shop.";
    }

    private static ShopUnlockInfo GetShopUnlockInfo(int merchantId, string shopName)
    {
        if (merchantId <= NPCID.None || string.IsNullOrWhiteSpace(shopName))
        {
            return default;
        }

        if (!ShopExpandedCatalog.TryGetPage(merchantId, shopName, out ShopExpandedCatalog.ShopPage page))
        {
            return new ShopUnlockInfo(0, 0, ItemID.None, false);
        }

        if (Config.Instance?.UnlockAllItems == true)
        {
            return new ShopUnlockInfo(0, 0, ItemID.None, true);
        }

        int progression = Progression.LevelFull();
        int lockedCount = 0;
        int nextRequired = int.MaxValue;
        int nextItemId = ItemID.None;

        foreach (ShopExpandedCatalog.ShopItem item in page.Items)
        {
            if (item.RequiredProgression <= progression)
            {
                continue;
            }

            lockedCount++;
            if (item.RequiredProgression < nextRequired)
            {
                nextRequired = item.RequiredProgression;
                nextItemId = item.ItemId;
            }
        }

        if (nextRequired == int.MaxValue)
        {
            nextRequired = 0;
        }

        return new ShopUnlockInfo(lockedCount, nextRequired, nextItemId, true);
    }

    private static List<int> SnapshotShopItemsAtState(int merchantId, string shopName, int progressionLevel, bool forceUnlockAllItems)
    {
        List<int> items = [];

        if (merchantId <= NPCID.None || string.IsNullOrWhiteSpace(shopName))
        {
            return items;
        }

        if (!ShopUI.Shops.TryGetValue(merchantId, out Shop shop))
        {
            return items;
        }

        int previousMerchantId = ShopUI.CurrentMerchantId;
        int previousTalkNpc = Main.LocalPlayer?.talkNPC ?? -1;
        int previousPlayerChest = Main.LocalPlayer?.chest ?? -1;
        int previousNpcShop = Main.npcShop;
        bool previousPlayerInventory = Main.playerInventory;
        string previousNpcChatText = Main.npcChatText;
        bool previousForceUnlockAll = Config.ForceUnlockAllItems;

        try
        {
            ShopUI.CurrentMerchantId = merchantId;
            Config.ForceUnlockAllItems = forceUnlockAllItems;

            using (Progression.PushPreviewLevelOverride(progressionLevel))
            {
                shop.OpenShopForNpcType(shopName, merchantId, suppressSound: true);
                Chest currentShop = Main.instance?.shop?[Main.npcShop];
                if (currentShop?.item is null)
                {
                    return items;
                }

                foreach (Item item in currentShop.item)
                {
                    if (item is null || item.IsAir || item.type <= ItemID.None)
                    {
                        continue;
                    }

                    items.Add(item.type);
                }
            }
        }
        finally
        {
            Config.ForceUnlockAllItems = previousForceUnlockAll;
            ShopUI.CurrentMerchantId = previousMerchantId;
            Main.SetNPCShopIndex(previousNpcShop);
            Main.playerInventory = previousPlayerInventory;
            Main.npcChatText = previousNpcChatText;

            if (Main.LocalPlayer is not null)
            {
                Main.LocalPlayer.SetTalkNPC(previousTalkNpc);
                Main.LocalPlayer.chest = previousPlayerChest;
            }
        }

        return items;
    }

    private static int GetFirstNewItem(IEnumerable<int> candidateItems, HashSet<int> currentItems)
    {
        foreach (int itemId in candidateItems)
        {
            if (!currentItems.Contains(itemId))
            {
                return itemId;
            }
        }

        return ItemID.None;
    }

    private static string GetItemDisplayName(int itemId)
    {
        if (itemId <= ItemID.None)
        {
            return string.Empty;
        }

        string itemName = Lang.GetItemNameValue(itemId);
        return string.IsNullOrWhiteSpace(itemName) ? $"Item {itemId}" : itemName;
    }

    private static string WrapHintText(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return $"{HintPrefix}-";
        }

        string normalized = text
            .Replace('\r', ' ')
            .Replace('\n', ' ')
            .Trim();
        if (string.IsNullOrWhiteSpace(normalized))
        {
            return $"{HintPrefix}-";
        }

        string[] words = normalized.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (words.Length == 0)
        {
            return $"{HintPrefix}-";
        }

        List<string> lines = [];
        string current = words[0];

        for (int i = 1; i < words.Length; i++)
        {
            string candidate = $"{current} {words[i]}";
            if (MeasureHintWidth(candidate) <= HintWrapWidth)
            {
                current = candidate;
            }
            else
            {
                lines.Add(current);
                current = words[i];
            }
        }

        lines.Add(current);
        return string.Join('\n', lines);
    }

    private static float MeasureHintWidth(string text)
    {
        return FontAssets.MouseText.Value.MeasureString(text).X * HintScale;
    }
}
