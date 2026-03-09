using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;
using Terraria.GameContent.UI.Elements;

namespace MerchantsPlus.UI;

public class DarkScrollbar : UIScrollbar
{
    private const float MouseWheelStep = 32f;

    public override void ScrollWheel(UIScrollWheelEvent evt)
    {
        base.ScrollWheel(evt);

        float scrollRange = Math.Max(0f, MaxViewSize - ViewSize);
        if (scrollRange <= 0f)
        {
            return;
        }

        float steps = evt.ScrollWheelValue / 120f;
        ViewPosition = Math.Clamp(ViewPosition - (steps * MouseWheelStep), 0f, scrollRange);
    }

    protected override void DrawSelf(SpriteBatch spriteBatch)
    {
        // Keep vanilla interaction/drag behavior, then fully overpaint visuals.
        base.DrawSelf(spriteBatch);

        CalculatedStyle dimensions = GetDimensions();
        Rectangle track = dimensions.ToRectangle();

        // Overpaint an expanded area so vanilla blue tip artifacts are completely hidden.
        Rectangle backdrop = new(track.X - 8, track.Y - 8, track.Width + 16, track.Height + 16);
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, backdrop, new Color(8, 8, 8, 205));
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, track, new Color(8, 8, 8, 190));

        // Force-hide tiny vanilla blue end-tip artifacts while keeping center area translucent.
        const int tipCover = 10;
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(track.X - 2, track.Y - tipCover, track.Width + 4, tipCover + 2), new Color(8, 8, 8, 255));
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(track.X - 2, track.Bottom - 2, track.Width + 4, tipCover + 2), new Color(8, 8, 8, 255));

        spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(track.X, track.Y, track.Width, 1), new Color(44, 44, 44, 245));
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(track.X, track.Bottom - 1, track.Width, 1), new Color(44, 44, 44, 245));
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(track.X, track.Y, 1, track.Height), new Color(44, 44, 44, 245));
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(track.Right - 1, track.Y, 1, track.Height), new Color(44, 44, 44, 245));

        float scrollRange = Math.Max(0f, MaxViewSize - ViewSize);
        float progress = scrollRange <= 0f
            ? 0f
            : Math.Clamp(ViewPosition / scrollRange, 0f, 1f);

        float handleRatio = MaxViewSize <= 0f
            ? 1f
            : Math.Clamp(ViewSize / MaxViewSize, 0.08f, 1f);
        int innerHeight = Math.Max(1, track.Height - 4);
        int handleHeight = Math.Clamp((int)Math.Round(innerHeight * handleRatio), 14, innerHeight);
        int handleTop = track.Y + 2 + (int)Math.Round((innerHeight - handleHeight) * progress);

        Rectangle handle = new(
            track.X + 2,
            handleTop,
            Math.Max(4, track.Width - 4),
            handleHeight);
        Color handleColor = IsMouseHovering ? new Color(42, 42, 42, 250) : new Color(28, 28, 28, 245);
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, handle, handleColor);
    }
}
