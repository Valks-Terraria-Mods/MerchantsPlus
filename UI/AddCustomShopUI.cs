namespace MerchantsPlus.UI;

public class AddCustomShopUI : ModSystem
{
    private UserInterface _shopUserInterface;
    private UserInterface _showAllShopsUserInterface;
    private UserInterface _worldShopsUserInterface;
    private UserInterface _debugUserInterface;
    private GameTime _lastUpdateUiGameTime;
    private ShopUI _shopUI;
    private ShowAllShopsUI _showAllShopsUI;
    private ShowAllShopsUI _worldShopsUI;
    private DebugPanelUI _debugPanelUI;

    public void ShowShopUI()
    {
        _showAllShopsUI?.ClearPinnedShop(clearTalkNpc: false);
        HideShowAllShopsUI();
        HideWorldShopsUI();
        ShopUI.Visible = true;

        _shopUI.UpdateUI();
        _shopUserInterface?.SetState(_shopUI);
    }

    public void HideShopUI()
    {
        ShopUI.Visible = false;

        _shopUserInterface?.SetState(null);
    }

    public void ShowShowAllShopsUI()
    {
        HideWorldShopsUI();
        _showAllShopsUI?.Refresh();
        _showAllShopsUserInterface?.SetState(_showAllShopsUI);
    }

    public void HideShowAllShopsUI()
    {
        _showAllShopsUserInterface?.SetState(null);
    }

    public void ToggleShowAllShopsUI()
    {
        if (_showAllShopsUserInterface?.CurrentState is null)
        {
            ShowShowAllShopsUI();
        }
        else
        {
            HideShowAllShopsUI();
        }
    }

    public void ShowWorldShopsUI()
    {
        HideShowAllShopsUI();
        ShowAllShopsUI.ClearWorldSession(clearTalkNpc: false);
        _worldShopsUI?.Refresh();
        _worldShopsUserInterface?.SetState(_worldShopsUI);
    }

    public void HideWorldShopsUI()
    {
        ShowAllShopsUI.ClearWorldSession(clearTalkNpc: false);
        _worldShopsUserInterface?.SetState(null);
    }

    public bool IsShowAllShopsUIOpen()
    {
        return _showAllShopsUserInterface?.CurrentState is not null;
    }

    public bool IsWorldShopsUIOpen()
    {
        return _worldShopsUserInterface?.CurrentState is not null;
    }

    public bool IsAnyBrowserUIOpen()
    {
        return IsShowAllShopsUIOpen() || IsWorldShopsUIOpen();
    }

    public bool IsPointerOverAnyCustomUI()
    {
        if (_shopUserInterface?.CurrentState is not null && _shopUI?.IsPointerOverPanel() == true)
        {
            return true;
        }

        if (_showAllShopsUserInterface?.CurrentState is not null && _showAllShopsUI?.IsPointerOverPanel() == true)
        {
            return true;
        }

        if (_worldShopsUserInterface?.CurrentState is not null && _worldShopsUI?.IsPointerOverPanel() == true)
        {
            return true;
        }

        if (_debugUserInterface?.CurrentState is not null && _debugPanelUI?.IsPointerOverPanel() == true)
        {
            return true;
        }

        return false;
    }

    public void ToggleWorldShopsUI()
    {
        if (_worldShopsUserInterface?.CurrentState is null)
        {
            ShowWorldShopsUI();
        }
        else
        {
            HideWorldShopsUI();
        }
    }

    public override void Load()
    {
        if (!Main.dedServ)
        {
            _shopUI = new ShopUI();
            _shopUI.Activate();
            _showAllShopsUI = new ShowAllShopsUI(false, "All Merchant Shops");
            _showAllShopsUI.Activate();
            _worldShopsUI = new ShowAllShopsUI(true, "World Merchant Shops");
            _worldShopsUI.Activate();
            _debugPanelUI = new DebugPanelUI(BuildDebugLinesForPanel, BuildDebugTextForClipboard);
            _debugPanelUI.Activate();

            _shopUserInterface = new UserInterface();
            _showAllShopsUserInterface = new UserInterface();
            _worldShopsUserInterface = new UserInterface();
            _debugUserInterface = new UserInterface();
        }
    }
    
    public override void UpdateUI(GameTime gameTime)
    {
        _lastUpdateUiGameTime = gameTime;

        if (Main.keyState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Escape))
        {
            HideShopUI();
            HideShowAllShopsUI();
            HideWorldShopsUI();
            return;
        }

        if (_shopUserInterface?.CurrentState != null)
        {
            _shopUserInterface.Update(gameTime);
        }

        if (_showAllShopsUserInterface?.CurrentState != null)
        {
            _showAllShopsUserInterface.Update(gameTime);
        }

        if (_worldShopsUserInterface?.CurrentState != null)
        {
            _worldShopsUserInterface.Update(gameTime);
        }

        UpdateDebugPanelState(gameTime);
    }

    public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
    {
        int mouseTextIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));

        if (mouseTextIndex != -1)
        {
            layers.Insert(mouseTextIndex, new LegacyGameInterfaceLayer(
                "MerchantsPlus: Custom Shops",
                delegate
                {
                    if (_lastUpdateUiGameTime is null)
                    {
                        return true;
                    }

                    if (_shopUserInterface?.CurrentState != null)
                    {
                        _shopUserInterface.Draw(Main.spriteBatch, _lastUpdateUiGameTime);
                    }

                    if (_showAllShopsUserInterface?.CurrentState != null)
                    {
                        _showAllShopsUserInterface.Draw(Main.spriteBatch, _lastUpdateUiGameTime);
                    }

                    if (_worldShopsUserInterface?.CurrentState != null)
                    {
                        _worldShopsUserInterface.Draw(Main.spriteBatch, _lastUpdateUiGameTime);
                    }

                    if (_debugUserInterface?.CurrentState != null)
                    {
                        _debugUserInterface.Draw(Main.spriteBatch, _lastUpdateUiGameTime);
                    }

                    return true;
                },
                InterfaceScaleType.UI));
        }
    }

    private void UpdateDebugPanelState(GameTime gameTime)
    {
        if (_debugUserInterface is null || _debugPanelUI is null)
        {
            return;
        }

        if (Config.Instance?.DevMode == true && !Main.gameMenu)
        {
            _debugPanelUI.Refresh();
            if (_debugUserInterface.CurrentState is null)
            {
                _debugUserInterface.SetState(_debugPanelUI);
            }

            _debugUserInterface.Update(gameTime);
            return;
        }

        if (_debugUserInterface.CurrentState is not null)
        {
            _debugUserInterface.SetState(null);
        }
    }

    private string BuildDebugTextForClipboard()
    {
        List<string> lines = BuildDebugLinesForPanel();
        lines.Insert(0, $"[MerchantsPlus Debug] {DateTime.UtcNow:O}");
        return string.Join(Environment.NewLine, lines);
    }

    private List<string> BuildDebugLinesForPanel()
    {
        return WorldShopPurchaseDiagnostics.GetPanelLines(IsWorldShopsUIOpen());
    }
}
