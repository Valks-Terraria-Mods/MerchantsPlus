using Terraria.GameInput;

namespace MerchantsPlus;

public class PlayerHooks : ModPlayer
{
    public override void ProcessTriggers(TriggersSet triggersSet)
    {
        if (ShopUI.Visible && !PlayerUtils.TalkingToNpc())
        {
            ModContent.GetInstance<AddCustomShopUI>().HideShopUI();
            return;
        }
    }
}
