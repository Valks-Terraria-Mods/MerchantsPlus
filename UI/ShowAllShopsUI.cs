using MerchantsPlus.Shops;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Terraria.GameContent.UI.Elements;
using Terraria.GameInput;

namespace MerchantsPlus.UI;

public class ShowAllShopsUI : UIState
{
    private const float PanelWidth = 470f;
    private const float PanelHeight = 360f;

    private readonly List<int> _merchantIds = [];

    private UIList _merchantList;
    private UIList _shopList;
    private UIText _selectedMerchantLabel;
    private UIText _selectedShopLabel;

    private int _selectedMerchantId = NPCID.None;
    private string _selectedShopName = string.Empty;
    private UIPanel _rootPanel;
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
        UIPanel panel = new();
        _rootPanel = panel;
        panel.SetPadding(8f);
        panel.Width.Set(PanelWidth, 0f);
        panel.Height.Set(PanelHeight, 0f);
        panel.Left.Set(-PanelWidth - 20f, 1f);
        panel.Top.Set(-PanelHeight - 20f, 1f);
        panel.BackgroundColor = new Color(8, 8, 8, 165);
        panel.BorderColor = new Color(28, 28, 28, 220);

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

        Append(panel);
    }

    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);

        if (Main.keyState.IsKeyDown(Keys.Escape))
        {
            CloseThisUI();
            return;
        }

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

    public void ClearPinnedShop(bool clearTalkNpc)
    {
        // No-op: retained for compatibility with existing calls.
    }

    public void Refresh()
    {
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
        IReadOnlyList<string> visibleShops = Shop.GetVisibleShops(_selectedMerchantId, merchantShop.Shops);
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

        IReadOnlyList<string> visibleShops = Shop.GetVisibleShops(merchantId, merchantShop.Shops);
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
        EnsureValidSelectedShop();
        PopulateMerchantList();
        PopulateShopList();
        UpdateSelectionLabels();
    }

    private void SelectShop(string shopName)
    {
        _selectedShopName = shopName;
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
        IReadOnlyList<string> visibleShops = Shop.GetVisibleShops(_selectedMerchantId, merchantShop.Shops);
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

        _selectedMerchantLabel.SetText($"Merchant: {merchantText}");
        _selectedShopLabel.SetText($"Shop: {shopText}");
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
