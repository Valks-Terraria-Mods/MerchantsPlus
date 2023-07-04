using Terraria.GameInput;

namespace MerchantsPlus;

public class PlayerHooks : ModPlayer
{
    public override void ProcessTriggers(TriggersSet triggersSet)
    {
        if (!Utils.TalkingToNPC())
        {
            if (ShopUI.Visible)
            {
                ModContent.GetInstance<ModifyUI>().HideShopUI();
                //Main.NewText("Hiding shop ui");
            }
        }
    }
}
