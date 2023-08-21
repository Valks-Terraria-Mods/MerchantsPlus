using Terraria.ID;

namespace MerchantsPlus.UI;

internal class UIEvents : GlobalNPC
{
    static NPC currentNPC = null;

    public override void GetChat(NPC npc, ref string chat)
    {
        // Do not change shop if the player is talking to the same NPC
        bool sameNPC = npc.type == currentNPC?.type;

        // Do not change shop if not talking to a NPC
        bool notTalkingToNPC = !Utils.TalkingToNPC();

        // Do not change shop if this is not a shop NPC
        bool notShopNPC = !IsShopNPC(npc);

        if (sameNPC || notTalkingToNPC || notShopNPC)
            return;

        currentNPC = npc;
        SetShopIndex(npc);
        //Main.NewText("Showing shop ui for " + npc.FullName);
        ModContent.GetInstance<ModifyUI>().ShowShopUI();
    }

    static bool IsShopNPC(NPC npc) => npc.type switch
    {
        NPCID.Angler or
        NPCID.ArmsDealer or
        NPCID.Clothier or
        NPCID.Cyborg or
        NPCID.Demolitionist or
        NPCID.Dryad or
        NPCID.DyeTrader or
        NPCID.GoblinTinkerer or
        NPCID.Guide or
        NPCID.Mechanic or
        NPCID.Merchant or
        NPCID.Nurse or
        NPCID.Painter or
        NPCID.PartyGirl or
        NPCID.Pirate or
        NPCID.SantaClaus or
        NPCID.SkeletonMerchant or
        NPCID.Steampunker or
        NPCID.Stylist or
        NPCID.DD2Bartender or
        NPCID.TaxCollector or
        NPCID.TravellingMerchant or
        NPCID.Truffle or
        NPCID.WitchDoctor or
        NPCID.Wizard => true,
        _ => false,
    };

    static void SetShopIndex(NPC npc)
    {
        ShopUI.CurrentMerchantID = npc.type;
    }
}