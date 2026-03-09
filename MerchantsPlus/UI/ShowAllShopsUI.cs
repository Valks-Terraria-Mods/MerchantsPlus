using MerchantsPlus.Shops;
using Terraria.GameContent.UI.Elements;

namespace MerchantsPlus.UI;

public partial class ShowAllShopsUI : UIState
{
    private const float PanelWidth = 470f;
    private const float PanelHeight = 360f;
    private const int PreviewSlotCount = 40;
    private const float HintTextScale = 0.66f;
    private const string HintPrefix = "Hint: ";
    private readonly record struct ShopUnlockInfo(int LockedCount, int NextRequiredProgression, int NextItemId, bool HasCatalogData);

    private readonly List<int> _merchantIds = [];

    private UIList _merchantList;
    private UIList _shopList;
    private UIText _selectedMerchantLabel;
    private UIText _selectedShopLabel;
    private UIText _selectedShopHintLabel;
    private UIText _previewHeaderLabel;
    private UIPanel _previewPanel;
    private TextButton _showAllItemsBtn;
    private TextButton _escLockBtn;
    private readonly Item[] _previewItems = CreatePreviewItemBuffer();

    private int _selectedMerchantId = NPCID.None;
    private string _selectedShopName = string.Empty;
    private bool _shopWasExplicitlyClicked;
    private DraggableUIPanel _rootPanel;
    private readonly bool _onlyPresentTownMerchants;
    private readonly string _titleText;
    private static readonly WorldShopSession _worldShopSession = new();
    private int _lastOpenedMerchantId = NPCID.None;
    private string _lastOpenedShopName = string.Empty;
    private ulong _lastOpenedShopTick;

    private int _hintCacheMerchantId = NPCID.None;
    private string _hintCacheShopName = string.Empty;
    private int _hintCacheProgression = int.MinValue;
    private bool _hintCacheUnlockAll;
    private int _hintCacheWorldSessionNonce = -1;
    private string _hintCacheText = string.Empty;
    private int _hintCacheLockedCount = -1;
    private int _previewCacheMerchantId = NPCID.None;
    private string _previewCacheShopName = string.Empty;
    private int _previewCacheProgression = int.MinValue;
    private bool _previewCacheForceUnlockAll;
    private bool _previewCacheShowAllItems;
    private Item _hoveredPreviewItem;
    private long _hoveredPreviewPrice;
    private bool _hoveredPreviewHasPrice;
    private bool _preventEscClose;

    public ShowAllShopsUI() : this(false, "All Merchant Shops")
    {
    }

    public ShowAllShopsUI(bool onlyPresentTownMerchants, string titleText)
    {
        _onlyPresentTownMerchants = onlyPresentTownMerchants;
        _titleText = string.IsNullOrWhiteSpace(titleText) ? "Merchant Shops" : titleText;
    }

    private static Item[] CreatePreviewItemBuffer()
    {
        Item[] items = new Item[PreviewSlotCount];
        for (int i = 0; i < items.Length; i++)
        {
            Item item = new();
            item.SetDefaults(ItemID.None);
            items[i] = item;
        }

        return items;
    }

    public bool IsEscCloseLocked()
    {
        return _onlyPresentTownMerchants && _preventEscClose;
    }
}
