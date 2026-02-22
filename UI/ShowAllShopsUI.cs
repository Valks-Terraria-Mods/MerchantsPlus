using MerchantsPlus.Shops;
using Terraria.GameContent.UI.Elements;

namespace MerchantsPlus.UI;

public partial class ShowAllShopsUI : UIState
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
    private static int _pinnedTalkNpcIndex = -1;

    public ShowAllShopsUI() : this(false, "All Merchant Shops")
    {
    }

    public ShowAllShopsUI(bool onlyPresentTownMerchants, string titleText)
    {
        _onlyPresentTownMerchants = onlyPresentTownMerchants;
        _titleText = string.IsNullOrWhiteSpace(titleText) ? "Merchant Shops" : titleText;
    }
}
