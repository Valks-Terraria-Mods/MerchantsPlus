using Terraria.ID;

namespace MerchantsPlus.UI;

internal class UIEvents : GlobalNPC
{
    public override bool? CanChat(NPC npc)
    {
        if (ShopUI.Visible || !Utils.TalkingToNPC())
            return base.CanChat(npc);

        SetShopIndex(npc);
        Main.NewText("Showing shop ui");
        ModContent.GetInstance<ModifyUI>().ShowShopUI();

        // Reset shop category index
        ShopUI.ShopCycleIndexes[ShopUI.CurrentShopIndex] = 0;

        return base.CanChat(npc);
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