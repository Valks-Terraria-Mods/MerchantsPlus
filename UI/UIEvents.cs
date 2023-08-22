using System;
using Terraria.ID;

namespace MerchantsPlus.UI;

internal class UIEvents : GlobalNPC
{
    public static HashSet<int> ShopNPCs { get; } = new()
    {
        NPCID.Angler,
        NPCID.ArmsDealer,
        NPCID.Clothier,
        NPCID.Cyborg,
        NPCID.Demolitionist,
        NPCID.Dryad,
        NPCID.DyeTrader,
        NPCID.GoblinTinkerer,
        NPCID.Guide,
        NPCID.Mechanic,
        NPCID.Merchant,
        NPCID.Nurse,
        NPCID.Painter,
        NPCID.PartyGirl,
        NPCID.Pirate,
        NPCID.SantaClaus,
        NPCID.SkeletonMerchant,
        NPCID.Steampunker,
        NPCID.Stylist,
        NPCID.DD2Bartender,
        NPCID.TaxCollector,
        NPCID.TravellingMerchant,
        NPCID.Truffle,
        NPCID.WitchDoctor,
        NPCID.Wizard
    };

    static bool IsShopNPC(NPC npc) => ShopNPCs.Contains(npc.type);
    static void SetShopIndex(NPC npc) => ShopUI.CurrentMerchantID = npc.type;

    static NPC currentNPC;

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
}
