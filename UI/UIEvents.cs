namespace MerchantsPlus.UI;

public class UIEvents : GlobalNPC
{
    private static bool IsShopNPC(NPC npc)
    {
        return ShopUI.Shops.ContainsKey(npc.type);
    }

    private static void SetShopIndex(NPC npc)
    {
        ShopUI.CurrentMerchantId = npc.type;
    }

    public override void GetChat(NPC npc, ref string chat)
    {
        // Do not change shop if this is not a shop NPC
        bool notShopNpc = !IsShopNPC(npc);

        if (notShopNpc) return;
        
        SetShopIndex(npc);
        ModContent.GetInstance<AddCustomShopUI>().ShowShopUI();
    }
}
