using MerchantsPlus.Shops;
using Terraria.GameContent;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Terraria.GameContent.UI.Elements;
using Terraria.GameInput;

namespace MerchantsPlus.UI;

public class ShowAllShopsUI : UIState
{
    private const float PanelWidth = 470f;
    private const float PanelHeight = 360f;
    private const float HintTextScale = 0.66f;
    private const string HintPrefix = "Hint: ";
    private readonly record struct ShopUnlockInfo(int LockedCount, int NextRequiredProgression, int NextItemId, bool HasCatalogData);

    private readonly List<int> _merchantIds = [];

    private UIList _merchantList;
    private UIList _shopList;
    private UIText _selectedMerchantLabel;
    private UIText _selectedShopLabel;
    private UIText _selectedShopHintLabel;
    private TextButton _showAllItemsBtn;

    private int _selectedMerchantId = NPCID.None;
    private string _selectedShopName = string.Empty;
    private bool _shopWasExplicitlyClicked;
    private DraggableUIPanel _rootPanel;
    private readonly bool _onlyPresentTownMerchants;
    private readonly string _titleText;

    public ShowAllShopsUI() : this(false, "All Merchant Shops")
    {
    }

    public ShowAllShopsUI(bool onlyPresentTownMerchants, string titleText)
    {
        _onlyPresentTownMerchants = onlyPresentTownMerchants;
        _titleText = string.IsNullOrWhiteSpace(titleText) ? "Merchant Shops" : titleText;
    }

    public override void OnInitialize()
    {
        DraggableUIPanel panel = new();
        _rootPanel = panel;
        panel.SetPadding(8f);
        panel.Width.Set(PanelWidth, 0f);
        panel.Height.Set(PanelHeight, 0f);
        panel.Left.Set(-PanelWidth - 20f, 1f);
        panel.Top.Set(-PanelHeight - 20f, 1f);
        panel.BackgroundColor = new Color(8, 8, 8, 165);
        panel.BorderColor = new Color(28, 28, 28, 220);
        panel.ClampToScreen = true;

        UIElement dragHandle = new();
        dragHandle.Left.Set(0f, 0f);
        dragHandle.Top.Set(0f, 0f);
        dragHandle.Width.Set(0f, 1f);
        dragHandle.Height.Set(28f, 0f);
        dragHandle.OnLeftMouseDown += panel.StartDrag;
        dragHandle.OnLeftMouseUp += panel.StopDrag;
        panel.Append(dragHandle);

        UIText title = new(_titleText, 0.95f)
        {
            HAlign = 0.5f,
        };
        title.Top.Set(8f, 0f);
        panel.Append(title);

        TextButton closeBtn = new("Close", 0.8f)
        {
            HAlign = 1f,
        };
        closeBtn.Left.Set(-8f, 0f);
        closeBtn.Top.Set(8f, 0f);
        closeBtn.OnLeftClick += (_, _) =>
        {
            AddCustomShopUI ui = ModContent.GetInstance<AddCustomShopUI>();
            if (_onlyPresentTownMerchants)
            {
                ui.HideWorldShopsUI();
            }
            else
            {
                ui.HideShowAllShopsUI();
            }
        };
        panel.Append(closeBtn);

        if (_onlyPresentTownMerchants)
        {
            _showAllItemsBtn = new TextButton("Show All Items", 0.72f)
            {
                HAlign = 0f,
            };
            _showAllItemsBtn.Left.Set(8f, 0f);
            _showAllItemsBtn.Top.Set(8f, 0f);
            _showAllItemsBtn.OnLeftClick += OnShowAllItemsClicked;
            panel.Append(_showAllItemsBtn);
        }

        UIText merchantsHeader = new("Merchants", 0.85f)
        {
            HAlign = 0f,
        };
        merchantsHeader.Left.Set(8f, 0f);
        merchantsHeader.Top.Set(40f, 0f);
        panel.Append(merchantsHeader);

        UIText shopsHeader = new("Shops", 0.85f)
        {
            HAlign = 0f,
        };
        shopsHeader.Left.Set(PanelWidth / 2f + 8f, 0f);
        shopsHeader.Top.Set(40f, 0f);
        panel.Append(shopsHeader);

        UIPanel merchantContainer = CreateListContainer(8f, 62f, true);
        panel.Append(merchantContainer);

        UIPanel shopContainer = CreateListContainer(PanelWidth / 2f + 8f, 62f, false);
        panel.Append(shopContainer);

        _selectedMerchantLabel = new UIText("Merchant: -", 0.72f);
        _selectedMerchantLabel.Left.Set(8f, 0f);
        _selectedMerchantLabel.Top.Set(289f, 0f);
        panel.Append(_selectedMerchantLabel);

        _selectedShopLabel = new UIText("Shop: -", 0.72f);
        _selectedShopLabel.Left.Set(PanelWidth / 2f + 8f, 0f);
        _selectedShopLabel.Top.Set(289f, 0f);
        panel.Append(_selectedShopLabel);

        _selectedShopHintLabel = new UIText("Hint: -", HintTextScale);
        _selectedShopHintLabel.Left.Set(8f, 0f);
        _selectedShopHintLabel.Top.Set(310f, 0f);
        panel.Append(_selectedShopHintLabel);

        Append(panel);
        UpdateShowAllItemsButton();
    }

    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);

        if (Main.keyState.IsKeyDown(Keys.Escape))
        {
            CloseThisUI();
            return;
        }

        UpdateShowAllItemsButton();

        if (Main.LocalPlayer is not null && _rootPanel?.ContainsPoint(Main.MouseScreen) == true)
        {
            Main.LocalPlayer.mouseInterface = true;
            PlayerInput.LockVanillaMouseScroll("MerchantsPlus.ShowAllShopsUI");
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

    public override void OnDeactivate()
    {
        base.OnDeactivate();
        ClearPinnedShop(clearTalkNpc: true);
    }

    public bool IsPointerOverPanel()
    {
        return _rootPanel?.ContainsPoint(Main.MouseScreen) == true;
    }

    public void ClearPinnedShop(bool clearTalkNpc)
    {
        // No-op: retained for compatibility with existing calls.
    }

    public void Refresh()
    {
        UpdateShowAllItemsButton();
        _shopWasExplicitlyClicked = false;

        _merchantIds.Clear();
        foreach (int merchantId in ShopUI.Shops.Keys)
        {
            if (!ShouldIncludeMerchant(merchantId))
            {
                continue;
            }

            _merchantIds.Add(merchantId);
        }

        _merchantIds.Sort((a, b) => string.Compare(GetNpcName(a), GetNpcName(b), StringComparison.Ordinal));

        if (_merchantIds.Count == 0)
        {
            _selectedMerchantId = NPCID.None;
            _selectedShopName = string.Empty;
            PopulateMerchantList();
            PopulateShopList();
            UpdateSelectionLabels();
            return;
        }

        if (!_merchantIds.Contains(_selectedMerchantId))
        {
            _selectedMerchantId = _merchantIds[0];
        }

        PopulateMerchantList();
        EnsureValidSelectedShop();
        PopulateShopList();
        UpdateSelectionLabels();
    }

    private UIPanel CreateListContainer(float left, float top, bool merchantList)
    {
        UIPanel container = new();
        container.SetPadding(6f);
        container.Left.Set(left, 0f);
        container.Top.Set(top, 0f);
        container.Width.Set((PanelWidth / 2f) - 24f, 0f);
        container.Height.Set(220f, 0f);
        container.BackgroundColor = new Color(4, 4, 4, 140);
        container.BorderColor = new Color(26, 26, 26, 180);

        UIList list = new();
        list.Left.Set(0f, 0f);
        list.Top.Set(0f, 0f);
        list.Width.Set(-24f, 1f);
        list.Height.Set(0f, 1f);
        list.ListPadding = 4f;

        UIScrollbar scrollbar = new DarkScrollbar();
        scrollbar.Left.Set(-20f, 1f);
        scrollbar.Top.Set(0f, 0f);
        scrollbar.Height.Set(0f, 1f);
        scrollbar.Width.Set(18f, 0f);
        list.SetScrollbar(scrollbar);

        container.Append(list);
        container.Append(scrollbar);

        if (merchantList)
        {
            _merchantList = list;
        }
        else
        {
            _shopList = list;
        }

        return container;
    }

    private void PopulateMerchantList()
    {
        _merchantList.Clear();

        foreach (int merchantId in _merchantIds)
        {
            int capturedMerchantId = merchantId;
            UITextPanel<string> btn = CreateListButton(
                GetNpcName(capturedMerchantId),
                _selectedMerchantId == capturedMerchantId);
            btn.OnLeftClick += (_, _) => SelectMerchant(capturedMerchantId);
            _merchantList.Add(btn);
        }
    }

    private void PopulateShopList()
    {
        _shopList.Clear();

        if (_selectedMerchantId <= NPCID.None || !ShopUI.Shops.TryGetValue(_selectedMerchantId, out Shop merchantShop))
        {
            return;
        }

        HashSet<string> seen = new(StringComparer.Ordinal);
        IReadOnlyList<string> visibleShops = Shop.GetVisibleShops(_selectedMerchantId, merchantShop, merchantShop.Shops);
        foreach (string shopName in visibleShops)
        {
            if (string.IsNullOrWhiteSpace(shopName) || !seen.Add(shopName))
            {
                continue;
            }

            string capturedShopName = shopName;
            UITextPanel<string> btn = CreateListButton(
                capturedShopName,
                string.Equals(_selectedShopName, capturedShopName, StringComparison.Ordinal));
            btn.OnLeftClick += (_, _) => SelectShop(capturedShopName);
            _shopList.Add(btn);
        }
    }

    private static UITextPanel<string> CreateListButton(string text, bool selected)
    {
        UITextPanel<string> button = new(text, 0.78f, false)
        {
            PaddingTop = 4f,
            PaddingBottom = 4f,
        };
        button.Width.Set(-4f, 1f);
        button.Height.Set(28f, 0f);

        button.BackgroundColor = selected
            ? new Color(26, 26, 26, 220)
            : new Color(12, 12, 12, 190);
        button.BorderColor = new Color(40, 40, 40, 210);

        return button;
    }

    private void CloseThisUI()
    {
        AddCustomShopUI ui = ModContent.GetInstance<AddCustomShopUI>();
        if (_onlyPresentTownMerchants)
        {
            ui.HideWorldShopsUI();
        }
        else
        {
            ui.HideShowAllShopsUI();
        }
    }

    private bool ShouldIncludeMerchant(int merchantId)
    {
        if (!_onlyPresentTownMerchants)
        {
            return true;
        }

        if (merchantId <= NPCID.None || !ShopUI.Shops.TryGetValue(merchantId, out Shop merchantShop))
        {
            return false;
        }

        if (!NPC.AnyNPCs(merchantId))
        {
            return false;
        }

        IReadOnlyList<string> visibleShops = Shop.GetVisibleShops(merchantId, merchantShop, merchantShop.Shops);
        return visibleShops.Count > 0;
    }

    private static string GetNpcName(int npcId)
    {
        string name = Lang.GetNPCNameValue(npcId);
        return string.IsNullOrWhiteSpace(name) ? $"NPC {npcId}" : name;
    }

    private void SelectMerchant(int merchantId)
    {
        _selectedMerchantId = merchantId;
        _shopWasExplicitlyClicked = false;
        EnsureValidSelectedShop();
        PopulateMerchantList();
        PopulateShopList();
        UpdateSelectionLabels();
    }

    private void SelectShop(string shopName)
    {
        _selectedShopName = shopName;
        _shopWasExplicitlyClicked = true;
        PopulateShopList();
        UpdateSelectionLabels();
        OpenShopSelection(_selectedMerchantId, _selectedShopName, suppressSound: false);
    }

    private void EnsureValidSelectedShop()
    {
        _selectedShopName = string.Empty;

        if (_selectedMerchantId <= NPCID.None || !ShopUI.Shops.TryGetValue(_selectedMerchantId, out Shop merchantShop))
        {
            return;
        }

        HashSet<string> seen = new(StringComparer.Ordinal);
        IReadOnlyList<string> visibleShops = Shop.GetVisibleShops(_selectedMerchantId, merchantShop, merchantShop.Shops);
        foreach (string shopName in visibleShops)
        {
            if (string.IsNullOrWhiteSpace(shopName) || !seen.Add(shopName))
            {
                continue;
            }

            _selectedShopName = shopName;
            break;
        }
    }

    private void UpdateSelectionLabels()
    {
        string merchantText = _selectedMerchantId > NPCID.None
            ? GetNpcName(_selectedMerchantId)
            : "-";
        string shopText = string.IsNullOrWhiteSpace(_selectedShopName)
            ? "-"
            : _selectedShopName;
        string hintText;
        if (_shopWasExplicitlyClicked)
        {
            hintText = GetSelectedShopHint();
            int lockedCount = GetSelectedShopLockedCount();
            hintText = AppendLockedStatus(hintText, lockedCount);
        }
        else
        {
            hintText = "Select a shop to open it and view unlock hints.";
        }

        _selectedMerchantLabel.SetText($"Merchant: {merchantText}");
        _selectedShopLabel.SetText($"Shop: {shopText}");
        _selectedShopHintLabel.SetText($"{HintPrefix}{FitHintText(hintText)}");
    }

    private string GetSelectedShopHint()
    {
        if (!_shopWasExplicitlyClicked)
        {
            return "Select a shop to open it and view unlock hints.";
        }

        if (_selectedMerchantId <= NPCID.None || string.IsNullOrWhiteSpace(_selectedShopName))
        {
            return "-";
        }

        if (Config.Instance?.UnlockAllItems == true)
        {
            return "Show All Items is enabled.";
        }

        ShopUnlockInfo info = GetShopUnlockInfo(_selectedMerchantId, _selectedShopName);
        if (!info.HasCatalogData)
        {
            return GetDynamicShopHint(_selectedMerchantId, _selectedShopName);
        }

        if (info.LockedCount <= 0)
        {
            return "All items currently unlocked for this shop.";
        }

        string itemName = GetItemDisplayName(info.NextItemId);
        string unlockHint = Progression.GetLevelFullUnlockHint(info.NextRequiredProgression);
        if (string.IsNullOrWhiteSpace(itemName))
        {
            return unlockHint;
        }

        return $"Next: {itemName}. {unlockHint}";
    }

    private string GetDynamicShopHint(int merchantId, string shopName)
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

    private static string GetItemDisplayName(int itemId)
    {
        if (itemId <= ItemID.None)
        {
            return string.Empty;
        }

        string itemName = Lang.GetItemNameValue(itemId);
        return string.IsNullOrWhiteSpace(itemName) ? $"Item {itemId}" : itemName;
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

    private int GetSelectedShopLockedCount()
    {
        if (!_shopWasExplicitlyClicked)
        {
            return 0;
        }

        if (_selectedMerchantId <= NPCID.None || string.IsNullOrWhiteSpace(_selectedShopName))
        {
            return 0;
        }

        if (Config.Instance?.UnlockAllItems == true)
        {
            return 0;
        }

        ShopUnlockInfo info = GetShopUnlockInfo(_selectedMerchantId, _selectedShopName);
        if (info.HasCatalogData)
        {
            return Math.Max(0, info.LockedCount);
        }

        List<int> currentItems = SnapshotShopItemsAtState(_selectedMerchantId, _selectedShopName, Progression.LevelFull(), forceUnlockAllItems: false);
        List<int> allItems = SnapshotShopItemsAtState(_selectedMerchantId, _selectedShopName, 21, forceUnlockAllItems: true);
        return Math.Max(0, allItems.Count - currentItems.Count);
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

            if (Main.LocalPlayer is not null)
            {
                Main.LocalPlayer.SetTalkNPC(previousTalkNpc);
            }
        }

        return items;
    }

    private void OnShowAllItemsClicked(UIMouseEvent evt, UIElement listeningElement)
    {
        Config config = Config.Instance;
        if (config is null || !config.DevMode)
        {
            return;
        }

        config.ShowAllItems = !config.ShowAllItems;
        UpdateShowAllItemsButton();
        Refresh();
    }

    private void UpdateShowAllItemsButton()
    {
        if (_showAllItemsBtn is null)
        {
            return;
        }

        bool devMode = Config.Instance?.DevMode == true;
        bool showAllItems = Config.Instance?.ShowAllItems == true;
        _showAllItemsBtn.IgnoresMouseInteraction = !devMode;

        if (!devMode)
        {
            _showAllItemsBtn.SetText(string.Empty);
            _showAllItemsBtn.Left.Set(-10000f, 0f);
            return;
        }

        _showAllItemsBtn.Left.Set(8f, 0f);
        _showAllItemsBtn.SetText(showAllItems ? "Show All Items: ON" : "Show All Items");
    }

    private static string FitHintText(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return "-";
        }

        string trimmed = text.Trim();
        // Leave extra right-side breathing room to avoid glyph clipping.
        float maxWidth = PanelWidth - 36f;
        if (MeasureHintLineWidth(trimmed) <= maxWidth)
        {
            return trimmed;
        }

        const string ellipsis = "...";
        int low = 0;
        int high = trimmed.Length;
        while (low < high)
        {
            int mid = (low + high + 1) / 2;
            string candidate = trimmed[..mid].TrimEnd() + ellipsis;
            if (MeasureHintLineWidth(candidate) <= maxWidth)
            {
                low = mid;
            }
            else
            {
                high = mid - 1;
            }
        }

        if (low <= 0)
        {
            return ellipsis;
        }

        return trimmed[..low].TrimEnd() + ellipsis;
    }

    private static string AppendLockedStatus(string hintText, int lockedCount)
    {
        string baseText = string.IsNullOrWhiteSpace(hintText) ? "-" : hintText.Trim();
        if (lockedCount <= 0)
        {
            return baseText;
        }

        string suffix = lockedCount == 1
            ? "1 item remains locked in this shop."
            : $"{lockedCount} items remain locked in this shop.";
        return $"{baseText} {suffix}";
    }

    private static float MeasureHintLineWidth(string text)
    {
        return FontAssets.MouseText.Value.MeasureString(HintPrefix + text).X * HintTextScale;
    }

    private void OpenShopSelection(int merchantId, string shopName, bool suppressSound)
    {
        if (merchantId <= NPCID.None || string.IsNullOrWhiteSpace(shopName))
        {
            return;
        }

        if (!ShopUI.Shops.TryGetValue(merchantId, out Shop shop))
        {
            return;
        }

        ShopUI.CurrentMerchantId = merchantId;

        int shopIndex = shop.Shops.FindIndex(name => string.Equals(name, shopName, StringComparison.Ordinal));
        if (shopIndex >= 0)
        {
            shop.CycleIndex = shopIndex;
        }

        shop.OpenShopForNpcType(shopName, merchantId, suppressSound);
    }
}
