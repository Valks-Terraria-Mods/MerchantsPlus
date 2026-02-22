using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;
using Terraria.GameContent.UI.Elements;

namespace MerchantsPlus.UI;

public class TextButton : UIPanel
{
    private const float UiPadding = 5f;
    public bool visible = true;
    private static readonly Color _colorBorder = Color.Transparent;
    private readonly float _textScale;
    private readonly UIText _uitext;

    public TextButton(string text, float text_size)
    {
        _textScale = text_size;
        SetPadding(0f);

        BackgroundColor = Color.Transparent;
        BorderColor = _colorBorder;

        _uitext = new UIText(text, text_size)
        {
            HAlign = 0.5f,
            VAlign = 0.5f,
        };
        Append(_uitext);

        SetText(text);
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
        Vector2 textMeasure = FontAssets.MouseText.Value.MeasureString(_uitext.Text);

        float width = textMeasure.X * _textScale;
        float height = (textMeasure.Y * _textScale) / 2f;

        Width.Set(width + (UiPadding * 2f), 0f);
        Height.Set(height + (UiPadding * 2f), 0f);
        Recalculate();
    }
}
