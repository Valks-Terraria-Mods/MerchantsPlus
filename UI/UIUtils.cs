using Terraria.GameInput;

namespace MerchantsPlus.UI;

public static class UIUtils
{
    public static bool IsInteractiveHover(UIElement element)
    {
        if (!element.ContainsPoint(Main.MouseScreen) || PlayerInput.IgnoreMouseInterface)
        {
            return false;
        }

        Main.LocalPlayer.mouseInterface = true;
        return true;
    }
}
