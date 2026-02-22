using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Terraria.GameContent;
using Terraria.GameContent.UI.Elements;
using Terraria.GameInput;

namespace MerchantsPlus.UI;

public partial class ShowAllShopsUI
{
    public override void OnInitialize()
    {
        DraggableUIPanel panel = new();
        _rootPanel = panel;
        panel.SetPadding(8f);
        panel.Width.Set(PanelWidth, 0f);
        panel.Height.Set(PanelHeight, 0f);
        float rightOffset = _onlyPresentTownMerchants
            ? PanelWidth + PreviewPanelWidth + 30f
            : PanelWidth + 20f;
        panel.Left.Set(-rightOffset, 1f);
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
            _showAllItemsBtn.Left.Set(90f, 0f);
            _showAllItemsBtn.Top.Set(8f, 0f);
            _showAllItemsBtn.OnLeftClick += OnShowAllItemsClicked;
            panel.Append(_showAllItemsBtn);

            _escLockBtn = new TextButton("Esc Lock", 0.72f)
            {
                HAlign = 0f,
            };
            _escLockBtn.Left.Set(8f, 0f);
            _escLockBtn.Top.Set(8f, 0f);
            _escLockBtn.OnLeftClick += OnEscLockClicked;
            panel.Append(_escLockBtn);
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

        InitializePreviewPanel(panel);
        Append(panel);
        UpdateShowAllItemsButton();
        UpdateEscLockButton();
    }

    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
        BeginPreviewHoverTracking();

        if (Main.keyState.IsKeyDown(Keys.Escape) && !IsEscCloseLocked())
        {
            CloseThisUI();
            return;
        }

        UpdateShowAllItemsButton();
        UpdateEscLockButton();
        RefreshPreviewItems(force: false);
        ClampWorldPreviewToScreen();

        if (Main.LocalPlayer is not null
            && ((_rootPanel?.ContainsPoint(Main.MouseScreen) == true) || IsPointerOverPreviewPanel()))
        {
            Main.LocalPlayer.mouseInterface = true;
            PlayerInput.LockVanillaMouseScroll("MerchantsPlus.ShowAllShopsUI");
        }
    }

    public override void Draw(SpriteBatch spriteBatch)
    {
        base.Draw(spriteBatch);
        DrawPreviewCoinBalance(spriteBatch);
        DrawPreviewTooltip(spriteBatch);

        if (Main.LocalPlayer is not null && _rootPanel is not null)
        {
            _ = UIUtils.IsInteractiveHover(_rootPanel);
        }

        if (Main.LocalPlayer is not null && _previewPanel is not null)
        {
            _ = UIUtils.IsInteractiveHover(_previewPanel);
        }
    }

    public override void OnDeactivate()
    {
        base.OnDeactivate();
        ClearWorldSession(clearTalkNpc: !_onlyPresentTownMerchants);
    }

    public bool IsPointerOverPanel()
    {
        return (_rootPanel?.ContainsPoint(Main.MouseScreen) == true) || IsPointerOverPreviewPanel();
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

    private static UITextPanel<string> CreateListButton(string text, bool selected, bool hasNewUnlock = false)
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

        if (hasNewUnlock)
        {
            AppendNewUnlockAsterisk(button, text);
        }

        return button;
    }

    private static void AppendNewUnlockAsterisk(UITextPanel<string> button, string baseText)
    {
        UIText marker = new("*", 0.86f)
        {
            TextColor = Color.Lime,
        };
        const float buttonTextScale = 0.78f;
        const float nominalButtonWidth = 183f;
        baseText ??= string.Empty;
        float textWidth = FontAssets.MouseText.Value.MeasureString(baseText).X * buttonTextScale;
        float suffixLeft = Math.Min(nominalButtonWidth - 12f, (nominalButtonWidth * 0.5f) + (textWidth * 0.5f) + 2f);
        marker.Left.Set(suffixLeft, 0f);
        marker.Top.Set(5f, 0f);
        button.Append(marker);
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

    private void OnEscLockClicked(UIMouseEvent evt, UIElement listeningElement)
    {
        if (!_onlyPresentTownMerchants)
        {
            return;
        }

        _preventEscClose = !_preventEscClose;
        UpdateEscLockButton();
    }

    private void UpdateEscLockButton()
    {
        if (_escLockBtn is null)
        {
            return;
        }

        _escLockBtn.SetText(_preventEscClose ? "Esc Lock: ON" : "Esc Lock");
    }
}
