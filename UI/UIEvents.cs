using Terraria.ID;

namespace MerchantsPlus.UI;

internal class UIEvents : GlobalNPC
{
    static NPC currentNPC;

    public override bool? CanChat(NPC npc)
    {
        // Do not change shop if the player is talking to the same NPC
        // Do not change shop if not talking to a NPC
        // Do not change shop if this is not a shop NPC
        if (npc == currentNPC || !Utils.TalkingToNPC() || !IsShopNPC(npc))
            return base.CanChat(npc);

        // Player must close the current shop before opening up another
        if (ShopUI.Visible)
            return base.CanChat(npc);

        currentNPC = npc;
        SetShopIndex(npc);
        Main.NewText("Showing shop ui for " + npc.FullName);
        ModContent.GetInstance<ModifyUI>().ShowShopUI();

        // Reset shop category index
        ShopUI.ShopCycleIndexes[ShopUI.CurrentShopIndex] = 0;

        return base.CanChat(npc);
    }

    static bool IsShopNPC(NPC npc)
    {
        switch (npc.type)
        {
            case NPCID.Angler:
            case NPCID.ArmsDealer:
            case NPCID.Clothier:
            case NPCID.Cyborg:
            case NPCID.Demolitionist:
            case NPCID.Dryad:
            case NPCID.DyeTrader:
            case NPCID.GoblinTinkerer:
            case NPCID.Guide:
            case NPCID.Mechanic:
            case NPCID.Merchant:
            case NPCID.Nurse:
            case NPCID.Painter:
            case NPCID.PartyGirl:
            case NPCID.Pirate:
            case NPCID.SantaClaus:
            case NPCID.SkeletonMerchant:
            case NPCID.Steampunker:
            case NPCID.Stylist:
            case NPCID.DD2Bartender:
            case NPCID.TaxCollector:
            case NPCID.TravellingMerchant:
            case NPCID.Truffle:
            case NPCID.WitchDoctor:
            case NPCID.Wizard:
                return true;
        }

        return false;
    }

    static void SetShopIndex(NPC npc)
    {
        switch (npc.type)
        {
            case NPCID.Angler:
                ShopUI.CurrentShopIndex = ShopUI.ANGLER;
                break;

            case NPCID.ArmsDealer:
                ShopUI.CurrentShopIndex = ShopUI.ARMSDEALER;
                break;

            case NPCID.Clothier:
                ShopUI.CurrentShopIndex = ShopUI.CLOTHIER;
                break;

            case NPCID.Cyborg:
                ShopUI.CurrentShopIndex = ShopUI.CYBORG;
                break;

            case NPCID.Demolitionist:
                ShopUI.CurrentShopIndex = ShopUI.DEMOLITIONIST;
                break;

            case NPCID.Dryad:
                ShopUI.CurrentShopIndex = ShopUI.DRYAD;
                break;

            case NPCID.DyeTrader:
                ShopUI.CurrentShopIndex = ShopUI.DYETRADER;
                break;

            case NPCID.GoblinTinkerer:
                ShopUI.CurrentShopIndex = ShopUI.GOBLINTINKERER;
                break;

            case NPCID.Guide:
                ShopUI.CurrentShopIndex = ShopUI.GUIDE;
                break;

            case NPCID.Mechanic:
                ShopUI.CurrentShopIndex = ShopUI.MECHANIC;
                break;

            case NPCID.Merchant:
                ShopUI.CurrentShopIndex = ShopUI.MERCHANT;
                break;

            case NPCID.Nurse:
                ShopUI.CurrentShopIndex = ShopUI.NURSE;
                break;

            case NPCID.Painter:
                ShopUI.CurrentShopIndex = ShopUI.PAINTER;
                break;

            case NPCID.PartyGirl:
                ShopUI.CurrentShopIndex = ShopUI.PARTYGIRL;
                break;

            case NPCID.Pirate:
                ShopUI.CurrentShopIndex = ShopUI.PIRATE;
                break;

            case NPCID.SantaClaus:
                ShopUI.CurrentShopIndex = ShopUI.SANTACLAUS;
                break;

            case NPCID.SkeletonMerchant:
                ShopUI.CurrentShopIndex = ShopUI.SKELETONMERCHANT;
                break;

            case NPCID.Steampunker:
                ShopUI.CurrentShopIndex = ShopUI.STEAMPUNKER;
                break;

            case NPCID.Stylist:
                ShopUI.CurrentShopIndex = ShopUI.STYLIST;
                break;

            case NPCID.DD2Bartender:
                ShopUI.CurrentShopIndex = ShopUI.TAVERNKEEP;
                break;

            case NPCID.TaxCollector:
                ShopUI.CurrentShopIndex = ShopUI.TAXCOLLECTOR;
                break;

            case NPCID.TravellingMerchant:
                ShopUI.CurrentShopIndex = ShopUI.TRAVELLINGMERCHANT;
                break;

            case NPCID.Truffle:
                ShopUI.CurrentShopIndex = ShopUI.TRUFFLE;
                break;

            case NPCID.WitchDoctor:
                ShopUI.CurrentShopIndex = ShopUI.WITCHDOCTOR;
                break;

            case NPCID.Wizard:
                ShopUI.CurrentShopIndex = ShopUI.WIZARD;
                break;
        }
    }
}