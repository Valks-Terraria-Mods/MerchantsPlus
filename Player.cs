using Terraria.GameInput;

namespace MerchantsPlus;

public class PlayerHooks : ModPlayer
{
    public override void ProcessTriggers(TriggersSet triggersSet)
    {
        if (ShowAllShopsUI.TryGetPinnedTalkNpc(out int pinnedTalkNpcIndex))
        {
            if (Main.LocalPlayer is null
                || pinnedTalkNpcIndex < 0
                || pinnedTalkNpcIndex >= Main.maxNPCs
                || !Main.npc[pinnedTalkNpcIndex].active)
            {
                ShowAllShopsUI.ClearPinnedTalkNpc(clearTalkNpc: false);
            }
            else if (Main.playerInventory && Main.LocalPlayer.talkNPC != pinnedTalkNpcIndex)
            {
                Main.LocalPlayer.SetTalkNPC(pinnedTalkNpcIndex);
            }
        }

        if (ShopUI.Visible && !PlayerUtils.TalkingToNpc())
        {
            ModContent.GetInstance<AddCustomShopUI>().HideShopUI();
            return;
        }
    }
}
