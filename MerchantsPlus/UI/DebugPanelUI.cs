using Terraria.GameContent.UI.Elements;
using Terraria.GameContent;
using Terraria.GameInput;

namespace MerchantsPlus.UI;

public class DebugPanelUI : UIState
{
    private const float PanelWidth = 300f;
    private const float PanelHeight = 132f;
    private const int MaxLineCount = 5;
    private const float LineScale = 0.54f;
    private const float LineTopStart = 26f;
    private const float LineStep = 15f;

    private readonly Func<List<string>> _linesProvider;
    private readonly Func<string> _clipboardTextProvider;

    private DraggableUIPanel _rootPanel;
    private readonly List<UIText> _lineTexts = [];

    public DebugPanelUI(Func<List<string>> linesProvider, Func<string> clipboardTextProvider)
    {
        _linesProvider = linesProvider ?? (() => []);
        _clipboardTextProvider = clipboardTextProvider ?? (() => string.Empty);
    }

    public override void OnInitialize()
    {
        DraggableUIPanel panel = new();
        _rootPanel = panel;
        panel.SetPadding(8f);
        panel.Width.Set(PanelWidth, 0f);
        panel.Height.Set(PanelHeight, 0f);
        panel.Left.Set(-PanelWidth - 4f, 1f);
        panel.Top.Set(12f, 0f);
        panel.BackgroundColor = new Color(8, 8, 8, 110);
        panel.BorderColor = new Color(24, 24, 24, 150);
        panel.ClampToScreen = true;

        UIElement dragHandle = new();
        dragHandle.Left.Set(0f, 0f);
        dragHandle.Top.Set(0f, 0f);
        dragHandle.Width.Set(0f, 1f);
        dragHandle.Height.Set(22f, 0f);
        dragHandle.OnLeftMouseDown += panel.StartDrag;
        dragHandle.OnLeftMouseUp += panel.StopDrag;
        panel.Append(dragHandle);

        UIText title = new("MP Debug", 0.62f)
        {
            HAlign = 0f,
        };
        title.Left.Set(6f, 0f);
        title.Top.Set(6f, 0f);
        panel.Append(title);

        TextButton copyButton = new("Copy", 0.6f)
        {
            HAlign = 1f,
        };
        copyButton.Left.Set(-6f, 0f);
        copyButton.Top.Set(4f, 0f);
        copyButton.OnLeftClick += OnCopyDebugClicked;
        panel.Append(copyButton);

        for (int i = 0; i < MaxLineCount; i++)
        {
            UIText line = new(string.Empty, LineScale);
            line.Left.Set(6f, 0f);
            line.Top.Set(LineTopStart + (i * LineStep), 0f);
            panel.Append(line);
            _lineTexts.Add(line);
        }

        Append(panel);
    }

    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);

        if (Main.LocalPlayer is not null && _rootPanel?.ContainsPoint(Main.MouseScreen) == true)
        {
            Main.LocalPlayer.mouseInterface = true;
            PlayerInput.LockVanillaMouseScroll("MerchantsPlus.DebugPanelUI");
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

    public void Refresh()
    {
        List<string> lines = _linesProvider() ?? [];
        int visibleCount = Math.Min(MaxLineCount, lines.Count);

        for (int i = 0; i < visibleCount; i++)
        {
            _lineTexts[i].SetText(FitLineText(lines[i]));
        }

        if (lines.Count > MaxLineCount)
        {
            _lineTexts[MaxLineCount - 1].SetText(FitLineText($"... (+{lines.Count - (MaxLineCount - 1)} more)"));
            visibleCount = MaxLineCount;
        }

        for (int i = visibleCount; i < MaxLineCount; i++)
        {
            _lineTexts[i].SetText(string.Empty);
        }
    }

    private static string FitLineText(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return string.Empty;
        }

        string trimmed = text.Trim();
        const string ellipsis = "...";
        float maxWidth = PanelWidth - 18f;
        if (FontAssets.MouseText.Value.MeasureString(trimmed).X * LineScale <= maxWidth)
        {
            return trimmed;
        }

        int low = 0;
        int high = trimmed.Length;
        while (low < high)
        {
            int mid = (low + high + 1) / 2;
            string candidate = trimmed[..mid].TrimEnd() + ellipsis;
            if (FontAssets.MouseText.Value.MeasureString(candidate).X * LineScale <= maxWidth)
            {
                low = mid;
            }
            else
            {
                high = mid - 1;
            }
        }

        if (low <= 0)
        {
            return ellipsis;
        }

        return trimmed[..low].TrimEnd() + ellipsis;
    }

    private void OnCopyDebugClicked(UIMouseEvent evt, UIElement listeningElement)
    {
        string text = _clipboardTextProvider();
        if (string.IsNullOrWhiteSpace(text))
        {
            Main.NewText("MerchantsPlus debug is empty.", Color.Orange);
            return;
        }

        try
        {
            ReLogic.OS.Platform.Get<ReLogic.OS.IClipboard>().Value = text;
            Main.NewText("MerchantsPlus debug copied to clipboard.", Color.LightGreen);
        }
        catch (Exception ex)
        {
            Main.NewText($"MerchantsPlus clipboard copy failed: {ex.Message}", Color.OrangeRed);
        }
    }
}
