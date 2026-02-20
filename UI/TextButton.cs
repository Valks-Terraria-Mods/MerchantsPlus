using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;
using Terraria.GameContent.UI.Elements;

namespace MerchantsPlus.UI;

public class TextButton : UIPanel
{
    public bool visible = true;
    private static readonly Color _colorBorder = Color.Transparent;
    private readonly UIText _uitext;

    public TextButton(string text, float text_size)
    {
        SetPadding(0f);

        BackgroundColor = Color.Transparent;
        BorderColor = _colorBorder;

        _uitext = new UIText(text, text_size);
        Vector2 text_measure = FontAssets.MouseText.Value.MeasureString(_uitext.Text);

        float width = (text_measure.X * text_size);
        float height = (text_measure.Y * text_size) / 2f;

        const float UI_PADDING = 5f;

        float width_panel = width + (UI_PADDING * 2);
        float height_panel = height + (UI_PADDING * 2);

        Width.Set(width_panel, 0f);
        Height.Set(height_panel, 0f);

        _uitext.Left.Set((width_panel - width) / 2f, 0f);
        _uitext.Top.Set((height_panel - height) / 2f, 0f);
        Append(_uitext);
    }

    public override void MouseOut(UIMouseEvent evt)
    {
        base.MouseOut(evt);
        //BorderColor = COLOR_BORDER;
        _uitext.TextColor = new Color(255, 255, 255);
    }

    public override void MouseOver(UIMouseEvent evt)
    {
        base.MouseOver(evt);
        //BorderColor = COLOR_BORDER_HIGHLIGHT;
        _uitext.TextColor = new Color(254, 218, 0);
    }

    public override void Draw(SpriteBatch spriteBatch)
    {
        if (visible)
        {
            base.Draw(spriteBatch);
        }

        _ = UIUtils.IsInteractiveHover(this);
    }

    public void SetText(string text)
    {
        _uitext.SetText(text);
    }
}
