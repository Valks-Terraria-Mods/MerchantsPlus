using MerchantsPlus.Shops;
using Terraria.GameContent.UI.Elements;

namespace MerchantsPlus.UI;

public partial class ShowAllShopsUI
{
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

        if (_onlyPresentTownMerchants)
        {
            PinCurrentTalkNpc();
        }
    }
}
