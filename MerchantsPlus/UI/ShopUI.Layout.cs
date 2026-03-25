using MerchantsPlus.Shops;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;
using Terraria.GameContent.UI.Elements;
using Terraria.GameInput;

namespace MerchantsPlus.UI;

public partial class ShopUI
{
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
        Dictionary<string, bool> hasUnseenUnlockByShop = BuildUnseenUnlockState(CurrentMerchantId, visibleShops);

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

            // Keep selected custom inventory in sync while chat UI is open.
            // Vanilla shop state can overwrite custom entries on subsequent frames.
            shop.OpenShopForNpcType(selectedShopName, CurrentMerchantId, suppressSound: true, sourceTag: "local_ui_sync");
        }
        else
        {
            _shopNameText.SetText("Shop: -");
            _hintText.SetText(WrapHintText($"{HintPrefix}No unlocked shops are visible yet."));
        }

        string shopsSignature = BuildShopListSignature(visibleShops, hasUnseenUnlockByShop);
        if (_lastMerchantId == CurrentMerchantId
            && _lastShopsSignature == shopsSignature
            && _lastSelectedIndex == shop.CycleIndex)
        {
            return;
        }

        PopulateShopList(visibleShops, shop.CycleIndex, hasUnseenUnlockByShop);
        _lastMerchantId = CurrentMerchantId;
        _lastSelectedIndex = shop.CycleIndex;
        _lastShopsSignature = shopsSignature;
    }

    private void PopulateShopList(
        IReadOnlyList<string> visibleShops,
        int selectedIndex,
        IReadOnlyDictionary<string, bool> hasUnseenUnlockByShop)
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
            bool hasUnseenUnlock = hasUnseenUnlockByShop.TryGetValue(capturedShop, out bool hasUnseen) && hasUnseen;
            UITextPanel<string> entry = CreateShopEntry(capturedShop, capturedIndex == selectedIndex, hasUnseenUnlock);
            entry.OnLeftClick += (_, _) =>
            {
                ShopUnlockAsteriskTracker.AcknowledgeShop(CurrentMerchantId, capturedShop);
                OpenShopByIndex(capturedIndex, capturedShop);
            };
            _shopList.Add(entry);
        }
    }

    private static UITextPanel<string> CreateShopEntry(string text, bool selected, bool hasNewUnlock = false)
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

        if (hasNewUnlock)
        {
            AppendNewUnlockAsterisk(panel, text);
        }

        return panel;
    }

    private static Dictionary<string, bool> BuildUnseenUnlockState(int merchantId, IReadOnlyList<string> visibleShops)
    {
        Dictionary<string, bool> map = new(StringComparer.Ordinal);
        HashSet<string> seen = new(StringComparer.Ordinal);
        foreach (string shopName in visibleShops)
        {
            if (string.IsNullOrWhiteSpace(shopName) || !seen.Add(shopName))
            {
                continue;
            }

            map[shopName] = ShopUnlockAsteriskTracker.HasUnseenUnlocks(merchantId, shopName);
        }

        return map;
    }

    private static string BuildShopListSignature(
        IReadOnlyList<string> visibleShops,
        IReadOnlyDictionary<string, bool> hasUnseenUnlockByShop)
    {
        if (visibleShops.Count == 0)
        {
            return string.Empty;
        }

        System.Text.StringBuilder signature = new(visibleShops.Count * 16);
        foreach (string shopName in visibleShops)
        {
            if (string.IsNullOrWhiteSpace(shopName))
            {
                continue;
            }

            bool hasUnseenUnlock = hasUnseenUnlockByShop.TryGetValue(shopName, out bool hasUnseen) && hasUnseen;
            _ = signature
                .Append(shopName)
                .Append(hasUnseenUnlock ? '*' : '-')
                .Append('\u001F');
        }

        return signature.ToString();
    }

    private static void AppendNewUnlockAsterisk(UITextPanel<string> panel, string baseText)
    {
        UIText marker = new("*", 0.84f)
        {
            TextColor = Color.Lime,
        };
        const float buttonTextScale = 0.76f;
        const float nominalButtonWidth = 163f;
        baseText ??= string.Empty;
        float textWidth = FontAssets.MouseText.Value.MeasureString(baseText).X * buttonTextScale;
        float suffixLeft = Math.Min(nominalButtonWidth - 12f, (nominalButtonWidth * 0.5f) + (textWidth * 0.5f) + 2f);
        marker.Left.Set(suffixLeft, 0f);
        marker.Top.Set(4f, 0f);
        panel.Append(marker);
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
        shop.OpenShopForNpcType(shopName, CurrentMerchantId, suppressSound: false, sourceTag: "local_ui_click");
    }
}
