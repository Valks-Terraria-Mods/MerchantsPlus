﻿using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.UI.Elements;
using Terraria.GameInput;
using ReLogic.Content;

namespace MerchantsPlus.UI;

// This UIHoverImageButton class inherits from UIImageButton.
// Inheriting is a great tool for UI design.
// By inheriting, we get the Image drawing, MouseOver sound, and fading for free from UIImageButton
// We've added some code to allow the Button to show a text tooltip while hovered.
public class UIHoverImageButton(Asset<Texture2D> texture, string hoverText) : UIImageButton(texture)
{
    public string HoverText = hoverText;

    protected override void DrawSelf(SpriteBatch spriteBatch)
    {
        base.DrawSelf(spriteBatch);

        if (IsMouseHovering)
        {
            Main.hoverItemName = HoverText;
        }

        if (ContainsPoint(Main.MouseScreen) && !PlayerInput.IgnoreMouseInterface)
        {
            Main.player[Main.myPlayer].mouseInterface = true;
        }
    }
}