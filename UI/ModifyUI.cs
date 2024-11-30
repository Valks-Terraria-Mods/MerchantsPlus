namespace MerchantsPlus.UI;

public class ModifyUI : ModSystem
{
    private UserInterface userInterface;
    private GameTime lastUpdateUiGameTime;
    private ShopUI shopUI;

    public void ShowShopUI()
    {
        shopUI.UpdateUI();
        ShopUI.Visible = true;
        userInterface?.SetState(shopUI);
    }

    public void HideShopUI()
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
