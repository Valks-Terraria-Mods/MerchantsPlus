namespace MerchantsPlus.UI;

public class AddCustomShopUI : ModSystem
{
    private UserInterface _shopUserInterface;
    private UserInterface _showAllShopsUserInterface;
    private GameTime _lastUpdateUiGameTime;
    private ShopUI _shopUI;
    private ShowAllShopsUI _showAllShopsUI;

    public void ShowShopUI()
    {
        _showAllShopsUI?.ClearPinnedShop(clearTalkNpc: false);
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

    public override void Load()
    {
        if (!Main.dedServ)
        {
            _shopUI = new ShopUI();
            _shopUI.Activate();
            _showAllShopsUI = new ShowAllShopsUI();
            _showAllShopsUI.Activate();

            _shopUserInterface = new UserInterface();
            _showAllShopsUserInterface = new UserInterface();
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

                    return true;
                },
                InterfaceScaleType.UI));
        }
    }
}
