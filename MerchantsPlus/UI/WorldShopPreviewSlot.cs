using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;
using Terraria.GameInput;

namespace MerchantsPlus.UI;

public sealed class WorldShopPreviewSlot : UIElement
{
    private readonly int _slotIndex;
    private readonly Func<int, Item> _getItemAtIndex;
    private readonly Action<int, Item> _onHover;
    private readonly Action<int> _onClick;
    private readonly int _drawContext;
    private readonly float _scale;
    private bool _wasLeftMouseDown;
    private int _rightHoldTicks;

    public WorldShopPreviewSlot(
        int slotIndex,
        Func<int, Item> getItemAtIndex,
        Action<int, Item> onHover,
        Action<int> onClick,
        int drawContext = ItemSlot.Context.BankItem,
        float scale = 0.85f)
    {
        _slotIndex = slotIndex;
        _getItemAtIndex = getItemAtIndex;
        _onHover = onHover;
        _onClick = onClick;
        _drawContext = drawContext;
        _scale = scale;

        Width.Set(TextureAssets.InventoryBack9.Value.Width * _scale, 0f);
        Height.Set(TextureAssets.InventoryBack9.Value.Height * _scale, 0f);

    }

    protected override void DrawSelf(SpriteBatch spriteBatch)
    {
        Item sourceItem = _getItemAtIndex?.Invoke(_slotIndex);
        Item slotItem = sourceItem?.Clone() ?? new Item();
        if (slotItem.type <= ItemID.None)
        {
            slotItem.SetDefaults(ItemID.None);
        }

        float previousScale = Main.inventoryScale;
        Main.inventoryScale = _scale;
        Rectangle slotBounds = GetDimensions().ToRectangle();

        bool isHovering = ContainsPoint(Main.MouseScreen);
        bool ignoreMouseInterface = PlayerInput.IgnoreMouseInterface;
        if (isHovering && !ignoreMouseInterface)
        {
            if (Main.LocalPlayer is not null)
            {
                Main.LocalPlayer.mouseInterface = true;
            }

            _onHover?.Invoke(_slotIndex, sourceItem);

            // Fallback click detection path:
            // UIElement left-mouse events are not firing reliably for these custom slot elements in-world.
            bool leftDown = Main.mouseLeft;
            bool leftJustPressed = leftDown && !_wasLeftMouseDown;
            if (leftJustPressed)
            {
                WorldShopPurchaseDiagnostics.RecordMouseDown(_slotIndex, sourceItem, ignoreMouseInterface, "left_press");
                Main.mouseLeftRelease = false;
                _onClick?.Invoke(_slotIndex);
            }

            bool rightDown = Main.mouseRight;
            if (rightDown)
            {
                _rightHoldTicks++;
                bool shouldBuy = _rightHoldTicks == 1;
                if (!shouldBuy && _rightHoldTicks > 1)
                {
                    int interval = _rightHoldTicks < 24
                        ? 12
                        : _rightHoldTicks < 72
                            ? 6
                            : 3;
                    shouldBuy = (_rightHoldTicks % interval) == 0;
                }

                if (shouldBuy)
                {
                    WorldShopPurchaseDiagnostics.RecordMouseDown(_slotIndex, sourceItem, ignoreMouseInterface, "right_hold");
                    Main.mouseRightRelease = false;
                    _onClick?.Invoke(_slotIndex);
                }
            }
            else
            {
                _rightHoldTicks = 0;
            }
        }
        else
        {
            _rightHoldTicks = 0;
        }

        ItemSlot.Draw(spriteBatch, ref slotItem, _drawContext, slotBounds.TopLeft());
        Main.inventoryScale = previousScale;
        _wasLeftMouseDown = Main.mouseLeft;
    }

}
