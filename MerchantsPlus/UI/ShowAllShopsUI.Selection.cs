using MerchantsPlus.Shops;
using Terraria.GameContent.UI.Elements;

namespace MerchantsPlus.UI;

public partial class ShowAllShopsUI
{
    public void Refresh()
    {
        UpdateDevProgPanel();
        _shopWasExplicitlyClicked = false;
        InvalidateHintCache();
        InvalidatePreviewCache();

        _merchantIds.Clear();
        foreach (int merchantId in ShopUI.Shops.Keys)
        {
            if (!ShouldIncludeMerchant(merchantId))
            {
                continue;
            }

            _merchantIds.Add(merchantId);
        }

        _merchantIds.Sort((a, b) => string.Compare(GetNpcName(a), GetNpcName(b), StringComparison.InvariantCultureIgnoreCase));

        if (_merchantIds.Count == 0)
        {
            _selectedMerchantId = NPCID.None;
            _selectedShopName = string.Empty;
            PopulateMerchantList();
            PopulateShopList();
            UpdateSelectionLabels();
            RefreshPreviewItems(force: true);
            return;
        }

        if (!_merchantIds.Contains(_selectedMerchantId))
        {
            _selectedMerchantId = _merchantIds[0];
        }

        PopulateMerchantList();
        EnsureValidSelectedShop();
        if (_onlyPresentTownMerchants && !string.IsNullOrWhiteSpace(_selectedShopName))
        {
            _shopWasExplicitlyClicked = true;
        }
        PopulateShopList();
        UpdateSelectionLabels();
        RefreshPreviewItems(force: true);
    }

    private void PopulateMerchantList()
    {
        _merchantList.Clear();
        _merchantListOrder.Clear();

        int merchantIndex = 0;
        foreach (int merchantId in _merchantIds)
        {
            int capturedMerchantId = merchantId;
            UITextPanel<string> btn = CreateListButton(
                GetNpcName(capturedMerchantId),
                _selectedMerchantId == capturedMerchantId);
            // UIList applies an internal sort; assign a stable pre-sort position to preserve intended order.
            btn.Top.Set(merchantIndex * 100f, 0f);
            _merchantListOrder[btn] = merchantIndex;
            btn.OnLeftClick += (_, _) => SelectMerchant(capturedMerchantId);
            _merchantList.Add(btn);
            merchantIndex++;
        }
    }

    private void PopulateShopList()
    {
        _shopList.Clear();
        _shopListOrder.Clear();

        if (_selectedMerchantId <= NPCID.None || !ShopUI.Shops.TryGetValue(_selectedMerchantId, out Shop merchantShop))
        {
            return;
        }

        HashSet<string> seen = new(StringComparer.Ordinal);
        IReadOnlyList<string> visibleShops = Shop.GetVisibleShops(_selectedMerchantId, merchantShop, merchantShop.Shops);
        Dictionary<string, bool> hasUnseenUnlockByShop = BuildUnseenUnlockState(_selectedMerchantId, visibleShops);
        int capturedMerchantId = _selectedMerchantId;
        int shopIndex = 0;
        foreach (string shopName in visibleShops)
        {
            if (string.IsNullOrWhiteSpace(shopName) || !seen.Add(shopName))
            {
                continue;
            }

            string capturedShopName = shopName;
            UITextPanel<string> btn = CreateListButton(
                capturedShopName,
                string.Equals(_selectedShopName, capturedShopName, StringComparison.Ordinal),
                hasUnseenUnlockByShop.TryGetValue(capturedShopName, out bool hasUnseenUnlock) && hasUnseenUnlock);
            // Keep deterministic display order for shops as well.
            btn.Top.Set(shopIndex * 100f, 0f);
            _shopListOrder[btn] = shopIndex;
            btn.OnLeftClick += (_, _) =>
            {
                ShopUnlockAsteriskTracker.AcknowledgeShop(capturedMerchantId, capturedShopName);
                SelectShop(capturedShopName);
            };
            _shopList.Add(btn);
            shopIndex++;
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

        // In DevMode with the progression slider active, always include present merchants
        // so the list stays stable while the slider is moved.
        if (_devProgPanelActive)
        {
            return true;
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
        InvalidateHintCache();
        InvalidatePreviewCache();
        EnsureValidSelectedShop();
        AcknowledgeVisibleShopsForMerchant(merchantId);
        // In world-browser mode, selecting a merchant immediately selects/opens the first visible shop.
        // Mark selection as active so hint text refreshes for that newly selected shop.
        if (_onlyPresentTownMerchants && !string.IsNullOrWhiteSpace(_selectedShopName))
        {
            _shopWasExplicitlyClicked = true;
        }
        PopulateMerchantList();
        PopulateShopList();
        UpdateSelectionLabels();
        RefreshPreviewItems(force: true);
    }

    private void SelectShop(string shopName)
    {
        _selectedShopName = shopName;
        _shopWasExplicitlyClicked = true;
        ShopUnlockAsteriskTracker.AcknowledgeShop(_selectedMerchantId, _selectedShopName);
        InvalidateHintCache();
        InvalidatePreviewCache();
        PopulateShopList();
        UpdateSelectionLabels();
        OpenShopSelection(_selectedMerchantId, _selectedShopName, suppressSound: false);
        RefreshPreviewItems(force: true);
    }

    private void EnsureValidSelectedShop()
    {
        if (_selectedMerchantId <= NPCID.None || !ShopUI.Shops.TryGetValue(_selectedMerchantId, out Shop merchantShop))
        {
            _selectedShopName = string.Empty;
            return;
        }

        HashSet<string> seen = new(StringComparer.Ordinal);
        IReadOnlyList<string> visibleShops = Shop.GetVisibleShops(_selectedMerchantId, merchantShop, merchantShop.Shops);

        // Build a de-duplicated visible set so we can check containment.
        List<string> deduped = [];
        foreach (string shopName in visibleShops)
        {
            if (!string.IsNullOrWhiteSpace(shopName) && seen.Add(shopName))
            {
                deduped.Add(shopName);
            }
        }

        // Preserve current selection if it is still visible.
        if (!string.IsNullOrWhiteSpace(_selectedShopName) && deduped.Contains(_selectedShopName))
        {
            return;
        }

        _selectedShopName = deduped.Count > 0 ? deduped[0] : string.Empty;
    }

    private static Dictionary<string, bool> BuildUnseenUnlockState(int merchantId, IReadOnlyList<string> shops)
    {
        Dictionary<string, bool> map = new(StringComparer.Ordinal);
        HashSet<string> seen = new(StringComparer.Ordinal);
        foreach (string shopName in shops)
        {
            if (string.IsNullOrWhiteSpace(shopName) || !seen.Add(shopName))
            {
                continue;
            }

            map[shopName] = ShopUnlockAsteriskTracker.HasUnseenUnlocks(merchantId, shopName);
        }

        return map;
    }

    private static void AcknowledgeVisibleShopsForMerchant(int merchantId)
    {
        if (merchantId <= NPCID.None || !ShopUI.Shops.TryGetValue(merchantId, out Shop merchantShop))
        {
            return;
        }

        IReadOnlyList<string> visibleShops = Shop.GetVisibleShops(merchantId, merchantShop, merchantShop.Shops);
        ShopUnlockAsteriskTracker.AcknowledgeShops(merchantId, visibleShops);
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
        const ulong explicitClickDebounceTicks = 20;

        if (merchantId <= NPCID.None || string.IsNullOrWhiteSpace(shopName))
        {
            return;
        }

        if (merchantId == _lastOpenedMerchantId
            && string.Equals(shopName, _lastOpenedShopName, StringComparison.Ordinal)
            && Main.GameUpdateCount < _lastOpenedShopTick + 15)
        {
            return;
        }

        int currentSessionNonce = 0;
        if (_onlyPresentTownMerchants
            && TryGetWorldSession(out WorldShopSession currentSession)
            && currentSession is not null
            && currentSession.IsActive
            && currentSession.MerchantId == merchantId
            && string.Equals(currentSession.ShopName, shopName, StringComparison.Ordinal))
        {
            currentSessionNonce = currentSession.OpenNonce;
            bool sameSessionAlreadyOpen = Main.playerInventory
                && Main.LocalPlayer is not null
                && Main.LocalPlayer.talkNPC == currentSession.PinnedTalkNpcIndex;

            if (sameSessionAlreadyOpen
                || Main.GameUpdateCount < currentSession.LastExplicitOpenTick + explicitClickDebounceTicks)
            {
                ShopOpenDiagnostics.RecordAttempt("explicit_click_skip", merchantId, shopName, suppressSound, soundPlayed: false);
                return;
            }
        }

        if (!ShopUI.Shops.TryGetValue(merchantId, out Shop shop))
        {
            return;
        }

        if (_onlyPresentTownMerchants)
        {
            // In world browser mode we render a custom shop panel instead of opening vanilla shop UI.
            // This avoids far-distance open/reopen side effects and associated sound spam.
            ClearWorldSession(clearTalkNpc: false);
            ShopOpenDiagnostics.RecordAttempt("world_preview_select", merchantId, shopName, suppressSound: true, soundPlayed: false);
            _lastOpenedMerchantId = merchantId;
            _lastOpenedShopName = shopName;
            _lastOpenedShopTick = Main.GameUpdateCount;
            return;
        }

        ShopUI.CurrentMerchantId = merchantId;

        int shopIndex = shop.Shops.FindIndex(name => string.Equals(name, shopName, StringComparison.Ordinal));
        if (shopIndex >= 0)
        {
            shop.CycleIndex = shopIndex;
        }

        // World browser shops are opened only from explicit shop-button clicks.
        // Keepalive code must never call OpenShopForNpcType, otherwise repeated opens/sounds can occur.
        shop.OpenShopForNpcType(
            shopName,
            merchantId,
            suppressSound,
            sourceTag: _onlyPresentTownMerchants ? "explicit_click" : "allshops_click");
        _lastOpenedMerchantId = merchantId;
        _lastOpenedShopName = shopName;
        _lastOpenedShopTick = Main.GameUpdateCount;

        if (_onlyPresentTownMerchants)
        {
            int pinnedTalkNpcIndex = Main.LocalPlayer?.talkNPC ?? -1;
            if (pinnedTalkNpcIndex < 0
                || pinnedTalkNpcIndex >= Main.maxNPCs
                || !Main.npc[pinnedTalkNpcIndex].active)
            {
                ClearWorldSession(clearTalkNpc: false);
                return;
            }

            int nextNonce = Math.Max(1, currentSessionNonce + 1);
            SetWorldSession(
                merchantId,
                shopName,
                pinnedTalkNpcIndex,
                explicitOpenTick: Main.GameUpdateCount,
                keepAliveTick: Main.GameUpdateCount,
                openSucceededTick: Main.GameUpdateCount,
                openNonce: nextNonce);
        }
    }
}
