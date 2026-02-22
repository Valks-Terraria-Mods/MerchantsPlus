using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;
using Terraria.GameContent.UI.Elements;

namespace MerchantsPlus.UI;

public class DarkScrollbar : UIScrollbar
{
    protected override void DrawSelf(SpriteBatch spriteBatch)
    {
        // Keep vanilla interaction/drag behavior, then fully overpaint visuals.
        base.DrawSelf(spriteBatch);

        CalculatedStyle dimensions = GetDimensions();
        Rectangle track = dimensions.ToRectangle();
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, track, new Color(0, 0, 0, 255));

        Rectangle border = track;
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(border.X, border.Y, border.Width, 1), new Color(40, 40, 40, 255));
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(border.X, border.Bottom - 1, border.Width, 1), new Color(40, 40, 40, 255));
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(border.X, border.Y, 1, border.Height), new Color(40, 40, 40, 255));
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(border.Right - 1, border.Y, 1, border.Height), new Color(40, 40, 40, 255));

        int handleHeight = Math.Clamp((int)(track.Height * 0.2f), 24, Math.Max(24, track.Height - 4));
        int maxTop = track.Bottom - handleHeight;
        int top = maxTop <= track.Top
            ? track.Top
            : track.Top + (int)((maxTop - track.Top) * ViewPosition);

        Rectangle handle = new(
            track.X + 2,
            top + 2,
            Math.Max(4, track.Width - 4),
            Math.Max(8, handleHeight - 4));
        Color handleColor = IsMouseHovering ? new Color(34, 34, 34, 255) : new Color(20, 20, 20, 255);
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, handle, handleColor);
    }
}
