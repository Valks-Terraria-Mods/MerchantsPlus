namespace MerchantsPlus.UI;

public class UIEvents : GlobalNPC
{
    private static bool IsShopNPC(NPC npc)
    {
        return ShopUI.Shops.ContainsKey(npc.type);
    }

    private static void SetShopIndex(NPC npc)
    {
        ShopUI.CurrentMerchantID = npc.type;
    }

    //static NPC currentNPC;

    public override void GetChat(NPC npc, ref string chat)
    {
        // Do not change shop if the player is talking to the same NPC
        //bool sameNPC = npc.type == currentNPC?.type;

        // Do not change shop if not talking to a NPC
        //bool notTalkingToNPC = !Utils.TalkingToNPC();

        // Do not change shop if this is not a shop NPC
        bool notShopNPC = !IsShopNPC(npc);

        if (notShopNPC)
        {
            return;
        }

        //currentNPC = npc;
        SetShopIndex(npc);
        //Main.NewText("Showing shop ui for " + npc.FullName);
        ModContent.GetInstance<ModifyUI>().ShowShopUI();
    }
}
