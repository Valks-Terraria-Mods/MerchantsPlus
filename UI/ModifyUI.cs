namespace MerchantsPlus.UI;

internal class ModifyUI : ModSystem
{
    UserInterface userInterface;
    GameTime lastUpdateUiGameTime;
    ShopUI shopUI;

    internal void ShowShopUI()
    {
        ShopUI.Visible = true;
        userInterface?.SetState(shopUI);
    }

    internal void HideShopUI()
    {
        ShopUI.Visible = false;
        userInterface?.SetState(null);
    }

    public override void Load()
    {
        if (!Main.dedServ)
        {
            shopUI = new ShopUI();
            shopUI.Activate();

            userInterface = new UserInterface();
        }
    }

    public override void UpdateUI(GameTime gameTime)
    {
        lastUpdateUiGameTime = gameTime;
        if (userInterface?.CurrentState != null)
        {
            userInterface.Update(gameTime);
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
                    if (lastUpdateUiGameTime != null && userInterface?.CurrentState != null)
                    {
                        userInterface.Draw(Main.spriteBatch, lastUpdateUiGameTime);
                    }
                    return true;
                },
                InterfaceScaleType.UI));
        }
    }
}
