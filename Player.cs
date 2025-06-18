using Terraria.GameInput;

namespace MerchantsPlus;

public class PlayerHooks : ModPlayer
{
    public override void ProcessTriggers(TriggersSet triggersSet)
    {
        if (PlayerUtils.TalkingToNpc()) 
            return;
        
        if (ShopUI.Visible)
        {
            ModContent.GetInstance<AddCustomShopUI>().HideShopUI();
            //Main.NewText("Hiding shop ui");
        }
    }
}
