using MerchantsPlus.Shops;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.UI.Elements;

namespace MerchantsPlus.UI;

public partial class ShowAllShopsUI
{
    private const float PreviewPanelWidth = 500f;
    private const float PreviewPanelHeight = PanelHeight;
    private static readonly int[] PreviewRowColumns = [9, 9, 9, 9, 4];
    private const float PreviewGridSidePadding = 12f;
    private const float PreviewGridCenterNudge = -18f;
    private const float PreviewSlotSpacing = 4f;
    private const float PreviewSlotsTop = 34f;
    private const float PreviewTooltipScale = 0.72f;

    private void InitializePreviewPanel(UIElement parent)
    {
        if (!_onlyPresentTownMerchants)
        {
            return;
        }

        UIPanel previewPanel = new();
        _previewPanel = previewPanel;
        previewPanel.SetPadding(0f);
        previewPanel.Left.Set(PanelWidth + 6f, 0f);
        previewPanel.Top.Set(0f, 0f);
        previewPanel.Width.Set(PreviewPanelWidth, 0f);
        previewPanel.Height.Set(PreviewPanelHeight, 0f);
        previewPanel.BackgroundColor = new Color(8, 8, 8, 165);
        previewPanel.BorderColor = new Color(28, 28, 28, 220);
        parent.Append(previewPanel);

        _previewHeaderLabel = new UIText("Shop Items (0 / 40)", 0.8f)
        {
            HAlign = 0.5f,
        };
        _previewHeaderLabel.Top.Set(8f, 0f);
        previewPanel.Append(_previewHeaderLabel);

        float slotScale = ComputePreviewSlotScale();
        float slotWidth = TextureAssets.InventoryBack9.Value.Width * slotScale;
        float slotHeight = TextureAssets.InventoryBack9.Value.Height * slotScale;
        int maxColumns = GetMaxPreviewColumns();
        float maxRowWidth = (maxColumns * slotWidth) + ((maxColumns - 1) * PreviewSlotSpacing);
        float gridLeft = Math.Max(PreviewGridSidePadding, ((PreviewPanelWidth - maxRowWidth) / 2f) + PreviewGridCenterNudge);

        int slotIndex = 0;
        for (int row = 0; row < PreviewRowColumns.Length; row++)
        {
            int columns = PreviewRowColumns[row];
            if (columns <= 0)
            {
                continue;
            }

            // Keep all rows aligned to the same left edge so the 5th row (4 slots) remains left-aligned.
            float rowLeft = gridLeft;

            for (int col = 0; col < columns && slotIndex < PreviewSlotCount; col++)
            {
                int capturedSlotIndex = slotIndex;
                WorldShopPreviewSlot slot = new(
                    capturedSlotIndex,
                    GetPreviewItemAt,
                    HandlePreviewSlotHover,
                    TryPurchasePreviewItem,
                    ItemSlot.Context.BankItem,
                    slotScale);
                slot.Left.Set(rowLeft + (col * (slotWidth + PreviewSlotSpacing)), 0f);
                slot.Top.Set(PreviewSlotsTop + (row * (slotHeight + PreviewSlotSpacing)), 0f);
                previewPanel.Append(slot);
                slotIndex++;
            }
        }
    }

    private static float ComputePreviewSlotScale()
    {
        float frameWidth = TextureAssets.InventoryBack9.Value.Width;
        int maxColumns = GetMaxPreviewColumns();

        float availableWidth = PreviewPanelWidth - (PreviewGridSidePadding * 2f);
        float widthPerSlot = (availableWidth - ((maxColumns - 1) * PreviewSlotSpacing)) / maxColumns;
        if (widthPerSlot <= 0f || frameWidth <= 0f)
        {
            return 0.75f;
        }

        return Math.Clamp(widthPerSlot / frameWidth, 0.58f, 0.8f);
    }

    private static int GetMaxPreviewColumns()
    {
        int maxColumns = 0;
        for (int i = 0; i < PreviewRowColumns.Length; i++)
        {
            if (PreviewRowColumns[i] > maxColumns)
            {
                maxColumns = PreviewRowColumns[i];
            }
        }

        return Math.Max(1, maxColumns);
    }

    private Item GetPreviewItemAt(int index)
    {
        if ((uint)index >= (uint)_previewItems.Length)
        {
            Item empty = new();
            empty.SetDefaults(ItemID.None);
            return empty;
        }

        return _previewItems[index];
    }

    private void RefreshPreviewItems(bool force)
    {
        if (!_onlyPresentTownMerchants)
        {
            return;
        }

        if (_selectedMerchantId <= NPCID.None
            || string.IsNullOrWhiteSpace(_selectedShopName)
            || !ShopUI.Shops.TryGetValue(_selectedMerchantId, out Shop _))
        {
            ClearPreviewItems();
            UpdatePreviewHeader(0);
            return;
        }

        bool showAllItems = Config.Instance?.ShowAllItems == true;
        bool forceUnlockAll = showAllItems || Config.Instance?.UnlockAllItems == true;
        int progression = forceUnlockAll ? 21 : Progression.LevelFull();
        if (!force
            && _previewCacheMerchantId == _selectedMerchantId
            && string.Equals(_previewCacheShopName, _selectedShopName, StringComparison.Ordinal)
            && _previewCacheProgression == progression
            && _previewCacheForceUnlockAll == forceUnlockAll
            && _previewCacheShowAllItems == showAllItems)
        {
            return;
        }

        List<Item> items = SnapshotShopEntriesAtState(
            _selectedMerchantId,
            _selectedShopName,
            progression,
            forceUnlockAllItems: forceUnlockAll,
            sourceTag: "world_preview");

        int visibleCount = 0;
        for (int i = 0; i < _previewItems.Length; i++)
        {
            if (i < items.Count && i < PreviewSlotCount)
            {
                Item clone = items[i].Clone();
                _previewItems[i] = clone;
                if (!clone.IsAir && clone.type > ItemID.None)
                {
                    visibleCount++;
                }
            }
            else
            {
                Item empty = new();
                empty.SetDefaults(ItemID.None);
                _previewItems[i] = empty;
            }
        }

        _previewCacheMerchantId = _selectedMerchantId;
        _previewCacheShopName = _selectedShopName ?? string.Empty;
        _previewCacheProgression = progression;
        _previewCacheForceUnlockAll = forceUnlockAll;
        _previewCacheShowAllItems = showAllItems;
        WorldShopPurchaseDiagnostics.RecordSelection(_selectedMerchantId, _selectedShopName, visibleCount);
        UpdatePreviewHeader(visibleCount);
    }

    private void InvalidatePreviewCache()
    {
        _previewCacheMerchantId = NPCID.None;
        _previewCacheShopName = string.Empty;
        _previewCacheProgression = int.MinValue;
        _previewCacheForceUnlockAll = false;
        _previewCacheShowAllItems = false;
    }

    private void BeginPreviewHoverTracking()
    {
        _hoveredPreviewItem = null;
        _hoveredPreviewPrice = 0;
        _hoveredPreviewHasPrice = false;
    }

    private void HandlePreviewSlotHover(int slotIndex, Item sourceItem)
    {
        if (sourceItem is null || sourceItem.IsAir || sourceItem.type <= ItemID.None)
        {
            return;
        }

        WorldShopPurchaseDiagnostics.RecordHover(slotIndex, sourceItem);
        _hoveredPreviewItem = sourceItem.Clone();
        _hoveredPreviewPrice = GetPreviewItemUnitPrice(_hoveredPreviewItem);
        _hoveredPreviewHasPrice = true;

        Main.HoverItem = _hoveredPreviewItem.Clone();
    }

    private void TryPurchasePreviewItem(int slotIndex)
    {
        if ((uint)slotIndex >= (uint)_previewItems.Length || Main.LocalPlayer is null)
        {
            WorldShopPurchaseDiagnostics.RecordResult(false, $"invalid slot/player slot={slotIndex + 1}");
            return;
        }

        Item sourceItem = _previewItems[slotIndex];
        if (sourceItem is null || sourceItem.IsAir || sourceItem.type <= ItemID.None)
        {
            WorldShopPurchaseDiagnostics.RecordResult(false, $"air item slot={slotIndex + 1}");
            return;
        }

        int customCurrency = sourceItem.shopSpecialCurrency;
        long price = GetPreviewItemUnitPrice(sourceItem);
        bool canAfford = Main.LocalPlayer.CanAfford(price, customCurrency);
        WorldShopPurchaseDiagnostics.RecordAttempt(slotIndex, sourceItem, price, customCurrency, canAfford);
        if (!canAfford)
        {
            WorldShopPurchaseDiagnostics.RecordResult(false, "cannot afford");
            SoundEngine.PlaySound(SoundID.MenuClose);
            return;
        }

        try
        {
            Main.LocalPlayer.BuyItem(price, customCurrency);

            Item purchasedItem = sourceItem.Clone();
            int stack = Math.Max(1, purchasedItem.stack);
            Main.LocalPlayer.QuickSpawnItem(
                new EntitySource_Misc("MerchantsPlus.WorldShopPreview"),
                purchasedItem,
                stack);

            SoundEngine.PlaySound(SoundID.Coins);
            WorldShopPurchaseDiagnostics.RecordResult(true, $"bought x{stack}");
        }
        catch (Exception ex)
        {
            WorldShopPurchaseDiagnostics.RecordResult(false, $"exception: {ex.GetType().Name}");
        }
    }

    private static long GetPreviewItemUnitPrice(Item item)
    {
        if (item is null || item.IsAir || item.type <= ItemID.None)
        {
            return 1;
        }

        long value = item.shopCustomPrice ?? item.value;
        return Math.Max(1, value);
    }

    private static string FormatPriceText(long value, int specialCurrency)
    {
        if (specialCurrency >= 0)
        {
            return $"Buy price: {value} (special currency)";
        }

        long platinum = value / 1_000_000;
        value %= 1_000_000;
        long gold = value / 10_000;
        value %= 10_000;
        long silver = value / 100;
        long copper = value % 100;

        List<string> parts = [];
        if (platinum > 0)
        {
            parts.Add($"{platinum}p");
        }

        if (gold > 0)
        {
            parts.Add($"{gold}g");
        }

        if (silver > 0)
        {
            parts.Add($"{silver}s");
        }

        if (copper > 0 || parts.Count == 0)
        {
            parts.Add($"{copper}c");
        }

        return $"Buy price: {string.Join(" ", parts)}";
    }

    private void DrawPreviewTooltip(SpriteBatch spriteBatch)
    {
        if (!_onlyPresentTownMerchants
            || !_hoveredPreviewHasPrice
            || _hoveredPreviewItem is null
            || _hoveredPreviewItem.IsAir)
        {
            return;
        }

        string nameLine = string.IsNullOrWhiteSpace(_hoveredPreviewItem.Name)
            ? Lang.GetItemNameValue(_hoveredPreviewItem.type)
            : _hoveredPreviewItem.Name;
        string priceLine = FormatPriceText(_hoveredPreviewPrice, _hoveredPreviewItem.shopSpecialCurrency);
        string helperLine = "Left click to buy";

        string[] lines = [nameLine, priceLine, helperLine];
        var font = FontAssets.MouseText.Value;
        float maxWidth = 0f;
        foreach (string line in lines)
        {
            maxWidth = Math.Max(maxWidth, font.MeasureString(line).X * PreviewTooltipScale);
        }

        float lineHeight = font.LineSpacing * PreviewTooltipScale;
        float boxWidth = maxWidth + 14f;
        float boxHeight = (lines.Length * lineHeight) + 12f;

        Vector2 cursor = Main.MouseScreen + new Vector2(22f, 16f);
        float maxX = Main.screenWidth - boxWidth - 8f;
        float maxY = Main.screenHeight - boxHeight - 8f;
        float x = Math.Clamp(cursor.X, 8f, maxX);
        float y = Math.Clamp(cursor.Y, 8f, maxY);
        Rectangle box = new((int)x, (int)y, (int)Math.Ceiling(boxWidth), (int)Math.Ceiling(boxHeight));

        spriteBatch.Draw(TextureAssets.MagicPixel.Value, box, new Color(8, 8, 8, 230));
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(box.X, box.Y, box.Width, 1), new Color(36, 36, 36, 255));
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(box.X, box.Bottom - 1, box.Width, 1), new Color(36, 36, 36, 255));
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(box.X, box.Y, 1, box.Height), new Color(36, 36, 36, 255));
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(box.Right - 1, box.Y, 1, box.Height), new Color(36, 36, 36, 255));

        Vector2 textPos = new(box.X + 7f, box.Y + 6f);
        Color[] colors = [Color.White, new Color(230, 210, 120), new Color(160, 160, 160)];
        for (int i = 0; i < lines.Length; i++)
        {
            Terraria.Utils.DrawBorderString(
                spriteBatch,
                lines[i],
                textPos + new Vector2(0f, i * lineHeight),
                colors[i],
                PreviewTooltipScale);
        }
    }

    private void ClearPreviewItems()
    {
        for (int i = 0; i < _previewItems.Length; i++)
        {
            Item empty = new();
            empty.SetDefaults(ItemID.None);
            _previewItems[i] = empty;
        }

        InvalidatePreviewCache();
    }

    private void UpdatePreviewHeader(int visibleCount)
    {
        if (_previewHeaderLabel is null)
        {
            return;
        }

        _previewHeaderLabel.SetText($"Shop Items ({visibleCount} / 40)");
    }

    private bool IsPointerOverPreviewPanel()
    {
        return _previewPanel?.ContainsPoint(Main.MouseScreen) == true;
    }

    private void ClampWorldPreviewToScreen()
    {
        if (!_onlyPresentTownMerchants || _rootPanel is null)
        {
            return;
        }

        CalculatedStyle rootDimensions = _rootPanel.GetDimensions();
        float totalWidth = PanelWidth + 6f + PreviewPanelWidth;
        float minLeft = 8f;
        float maxLeft = Main.screenWidth - totalWidth - 8f;
        if (maxLeft < minLeft)
        {
            maxLeft = minLeft;
        }

        float clampedLeft = Math.Clamp(rootDimensions.X, minLeft, maxLeft);
        if (Math.Abs(clampedLeft - rootDimensions.X) < 0.1f)
        {
            return;
        }

        _rootPanel.Left.Set(clampedLeft, 0f);
        _rootPanel.Recalculate();
    }
}
