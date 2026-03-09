using Microsoft.Xna.Framework;
using Terraria.GameContent.UI.Elements;

namespace MerchantsPlus.UI;

public class DraggableUIPanel : UIPanel
{
    private bool _dragging;
    private Vector2 _dragOffset;

    public bool ClampToScreen { get; set; } = true;

    public void StartDrag(UIMouseEvent evt, UIElement listeningElement)
    {
        _dragging = true;
        CalculatedStyle dimensions = GetDimensions();
        _dragOffset = evt.MousePosition - new Vector2(dimensions.X, dimensions.Y);
    }

    public void StopDrag(UIMouseEvent evt, UIElement listeningElement)
    {
        _dragging = false;
    }

    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);

        if (!_dragging)
        {
            return;
        }

        if (!Main.mouseLeft)
        {
            _dragging = false;
            return;
        }

        CalculatedStyle dimensions = GetDimensions();
        float width = dimensions.Width;
        float height = dimensions.Height;

        float left = Main.mouseX - _dragOffset.X;
        float top = Main.mouseY - _dragOffset.Y;

        if (ClampToScreen)
        {
            float maxLeft = Math.Max(0f, Main.screenWidth - width);
            float maxTop = Math.Max(0f, Main.screenHeight - height);
            left = MathHelper.Clamp(left, 0f, maxLeft);
            top = MathHelper.Clamp(top, 0f, maxTop);
        }

        Left.Set(left, 0f);
        Top.Set(top, 0f);
        Recalculate();

        if (Main.LocalPlayer is not null)
        {
            Main.LocalPlayer.mouseInterface = true;
        }
    }
}
