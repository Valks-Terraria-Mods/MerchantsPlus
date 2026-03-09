using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent;
using Terraria.UI;

namespace MerchantsPlus.UI;

/// <summary>A simple horizontal integer drag-slider for the DevMode progression override panel.</summary>
internal class DevProgressionSlider : UIElement
{
    private const int ThumbW = 10;
    private const int ThumbH = 18;
    private const int TrackH = 4;

    public event Action<int> OnValueChanged;

    private int _value;
    private readonly int _min;
    private readonly int _max;
    private bool _isDragging;

    public int Value => _value;

    public bool IsDragging => _isDragging;

    public DevProgressionSlider(int min, int max, int initialValue)
    {
        _min = min;
        _max = max;
        _value = Math.Clamp(initialValue, min, max);
    }

    /// <summary>Sets the slider value without firing <see cref="OnValueChanged"/>.</summary>
    public void SetValueSilent(int value)
    {
        _value = Math.Clamp(value, _min, _max);
    }

    public override void LeftMouseDown(UIMouseEvent evt)
    {
        base.LeftMouseDown(evt);
        _isDragging = true;
        UpdateValueFromMouse();
    }

    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
        if (_isDragging)
        {
            if (!Main.mouseLeft)
                _isDragging = false;
            else
                UpdateValueFromMouse();
        }
    }

    private void UpdateValueFromMouse()
    {
        CalculatedStyle dims = GetDimensions();
        float trackLeft = dims.X + ThumbW / 2f;
        float trackRight = dims.X + dims.Width - ThumbW / 2f;
        float trackWidth = trackRight - trackLeft;

        if (trackWidth <= 0f)
            return;

        float t = Math.Clamp((Main.mouseX - trackLeft) / trackWidth, 0f, 1f);
        int newValue = _min + (int)Math.Round(t * (_max - _min));
        if (newValue == _value)
            return;

        _value = newValue;
        OnValueChanged?.Invoke(_value);
    }

    protected override void DrawSelf(SpriteBatch spriteBatch)
    {
        CalculatedStyle dims = GetDimensions();
        float cy = dims.Y + dims.Height / 2f;

        // Track
        Rectangle track = new((int)dims.X, (int)(cy - TrackH / 2f), (int)dims.Width, TrackH);
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, track, new Color(60, 60, 60, 220));

        // Filled portion
        float progress = _max > _min ? (float)(_value - _min) / (_max - _min) : 0f;
        int filledW = (int)(dims.Width * progress);
        if (filledW > 0)
        {
            spriteBatch.Draw(TextureAssets.MagicPixel.Value,
                new Rectangle((int)dims.X, track.Y, filledW, TrackH),
                new Color(80, 170, 80, 220));
        }

        // Thumb
        int thumbX = (int)(dims.X + dims.Width * progress - ThumbW / 2f);
        thumbX = Math.Clamp(thumbX, (int)dims.X, (int)(dims.X + dims.Width - ThumbW));
        Rectangle thumb = new(thumbX, (int)(cy - ThumbH / 2f), ThumbW, ThumbH);
        Color thumbColor = _isDragging ? new Color(240, 240, 100) : new Color(200, 200, 200);
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, thumb, thumbColor);

        // Thumb border
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(thumb.X, thumb.Y, thumb.Width, 1), new Color(90, 90, 90));
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(thumb.X, thumb.Bottom - 1, thumb.Width, 1), new Color(90, 90, 90));
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(thumb.X, thumb.Y, 1, thumb.Height), new Color(90, 90, 90));
        spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(thumb.Right - 1, thumb.Y, 1, thumb.Height), new Color(90, 90, 90));
    }
}
