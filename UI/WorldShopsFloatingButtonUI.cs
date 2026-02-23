using Terraria.GameContent.UI.Elements;
using Terraria.GameInput;

namespace MerchantsPlus.UI;

public class WorldShopsFloatingButtonUI : UIState
{
    private UIPanel _rootPanel;
    private TextButton _shopsButton;

    public override void OnInitialize()
    {
        UIPanel panel = new();
        _rootPanel = panel;
        panel.SetPadding(0f);
        panel.Left.Set(-400f, 1f);
        panel.Top.Set(15f, 0f);
        panel.Width.Set(88f, 0f);
        panel.Height.Set(30f, 0f);
        panel.BackgroundColor = new Color(8, 8, 8, 170);
        panel.BorderColor = new Color(28, 28, 28, 210);

        _shopsButton = new TextButton("Shops", 0.76f)
        {
            HAlign = 0.5f,
            VAlign = 0.5f,
        };
        _shopsButton.OnLeftClick += (_, _) =>
        {
            AddCustomShopUI ui = ModContent.GetInstance<AddCustomShopUI>();
            if (ui != null)
            {
                if (ui.IsWorldShopsUIOpen())
                {
                    ui.HideWorldShopsUI();
                }
                else
                {
                    ui.ShowWorldShopsUI();
                }
            }
        };
        panel.Append(_shopsButton);

        Append(panel);
    }

    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);

        if (Main.LocalPlayer is not null && _rootPanel?.ContainsPoint(Main.MouseScreen) == true)
        {
            Main.LocalPlayer.mouseInterface = true;
            PlayerInput.LockVanillaMouseScroll("MerchantsPlus.WorldShopsFloatingButtonUI");
        }
    }

    public override void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
    {
        base.Draw(spriteBatch);

        if (Main.LocalPlayer is not null && _rootPanel is not null)
        {
            _ = UIUtils.IsInteractiveHover(_rootPanel);
        }
    }

    public bool IsPointerOverPanel()
    {
        return _rootPanel?.ContainsPoint(Main.MouseScreen) == true;
    }
}
