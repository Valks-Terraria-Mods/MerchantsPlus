namespace MerchantsPlus.UI;

public class ModifyUI : ModSystem
{
    private UserInterface _userInterface;
    private GameTime _lastUpdateUiGameTime;
    private ShopUI _shopUI;

    public void ShowShopUI()
    {
        ShopUI.Visible = true;

        _shopUI.UpdateUI();
        _userInterface?.SetState(_shopUI);
    }

    public void HideShopUI()
    {
        ShopUI.Visible = false;

        _userInterface?.SetState(null);
    }

    public override void Load()
    {
        if (!Main.dedServ)
        {
            _shopUI = new ShopUI();
            _shopUI.Activate();

            _userInterface = new UserInterface();
        }
    }

    public override void UpdateUI(GameTime gameTime)
    {
        _lastUpdateUiGameTime = gameTime;

        if (_userInterface?.CurrentState != null)
        {
            _userInterface.Update(gameTime);
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
                    if (_lastUpdateUiGameTime != null && _userInterface?.CurrentState != null)
                    {
                        _userInterface.Draw(Main.spriteBatch, _lastUpdateUiGameTime);
                    }

                    return true;
                },
                InterfaceScaleType.UI));
        }
    }
}
