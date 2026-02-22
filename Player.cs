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

    public static string GetTalkNpcReflectionMode()
    {
        return "disabled";
    }

    public static string GetNpcShopReflectionMode()
    {
        return "disabled";
    }
}
