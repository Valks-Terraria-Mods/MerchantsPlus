namespace MerchantsPlus.UI;

public class AddCustomShopUI : ModSystem
{
    private UserInterface _shopUserInterface;
    private UserInterface _showAllShopsUserInterface;
    private UserInterface _worldShopsUserInterface;
    private GameTime _lastUpdateUiGameTime;
    private ShopUI _shopUI;
    private ShowAllShopsUI _showAllShopsUI;
    private ShowAllShopsUI _worldShopsUI;

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
        _worldShopsUI?.Refresh();
        _worldShopsUserInterface?.SetState(_worldShopsUI);
    }

    public void HideWorldShopsUI()
    {
        _worldShopsUserInterface?.SetState(null);
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

            _shopUserInterface = new UserInterface();
            _showAllShopsUserInterface = new UserInterface();
            _worldShopsUserInterface = new UserInterface();
        }
    }
    
    public override void UpdateUI(GameTime gameTime)
    {
        _lastUpdateUiGameTime = gameTime;

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

                    return true;
                },
                InterfaceScaleType.UI));
        }
    }
}
