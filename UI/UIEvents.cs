namespace MerchantsPlus.UI;

public class UIEvents : GlobalNPC
{
    public override bool? CanChat(NPC npc)
    {
        if (npc is not null
            && npc.active
            && ShowAllShopsUI.TryGetPinnedTalkNpc(out int pinnedTalkNpcIndex)
            && npc.whoAmI == pinnedTalkNpcIndex)
        {
            return true;
        }

        return null;
    }

    public override void GetChat(NPC npc, ref string chat)
    {
        if (npc is null || !npc.active || !ShopUI.Shops.ContainsKey(npc.type))
        {
            return;
        }

        ShopUI.CurrentMerchantId = npc.type;
        ModContent.GetInstance<AddCustomShopUI>().ShowShopUI();
    }
}
