using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent;
using Terraria.GameContent.UI.Elements;
using Terraria.GameInput;
using Terraria.UI;

namespace MerchantsPlus.UI
{
    internal class TextButton : UIPanel
    {
        public bool visible = true;

        private static readonly Color BORDER = Color.Transparent;
        private static readonly Color BORDER_HIGHLIGHT = Color.Black;

        private UIText uitext;

        public TextButton(string text, float text_size)
        {
            SetPadding(0f);

            BackgroundColor = Color.Transparent;
            BorderColor = BORDER;

            uitext = new UIText(text, text_size);
            Vector2 text_measure = FontAssets.MouseText.Value.MeasureString(uitext.Text);

            float width = (text_measure.X * text_size);
            float height = (text_measure.Y * text_size) / 2f;

            const float UI_PADDING = 5f;

            float width_panel = width + (UI_PADDING * 2);
            float height_panel = height + (UI_PADDING * 2);

            Width.Set(width_panel, 0f);
            Height.Set(height_panel, 0f);

            uitext.Left.Set((width_panel - width) / 2f, 0f);
            uitext.Top.Set((height_panel - height) / 2f, 0f);
            Append(uitext);
        }

        public override void MouseOut(UIMouseEvent evt)
        {
            base.MouseOut(evt);
            //BorderColor = BORDER;
            uitext.TextColor = new Color(255, 255, 255);
        }

        public override void MouseOver(UIMouseEvent evt)
        {
            base.MouseOver(evt);
            //BorderColor = BORDER_HIGHLIGHT;
            uitext.TextColor = new Color(254, 218, 0);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (visible)
            {
                base.Draw(spriteBatch);
            }

            if (ContainsPoint(Main.MouseScreen) && !PlayerInput.IgnoreMouseInterface)
            {
                Main.player[Main.myPlayer].mouseInterface = true;
            }
        }
    }
}