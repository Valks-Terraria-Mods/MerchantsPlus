using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.UI
{
    internal class UIEvents : GlobalNPC
    {
        public override bool? CanChat(NPC npc)
        {
            if (!ShopUI.Visible)
            {
                switch (npc.type)
                {
                    case NPCID.Angler:
                        ShopUI.TheShop = ShopUI.ANGLER;
                        break;

                    case NPCID.ArmsDealer:
                        ShopUI.TheShop = ShopUI.ARMSDEALER;
                        break;

                    case NPCID.Clothier:
                        ShopUI.TheShop = ShopUI.CLOTHIER;
                        break;

                    case NPCID.Cyborg:
                        ShopUI.TheShop = ShopUI.CYBORG;
                        break;

                    case NPCID.Demolitionist:
                        ShopUI.TheShop = ShopUI.DEMOLITIONIST;
                        break;

                    case NPCID.Dryad:
                        ShopUI.TheShop = ShopUI.DRYAD;
                        break;

                    case NPCID.DyeTrader:
                        ShopUI.TheShop = ShopUI.DYETRADER;
                        break;

                    case NPCID.GoblinTinkerer:
                        ShopUI.TheShop = ShopUI.GOBLINTINKERER;
                        break;

                    case NPCID.Guide:
                        ShopUI.TheShop = ShopUI.GUIDE;
                        break;

                    case NPCID.Mechanic:
                        ShopUI.TheShop = ShopUI.MECHANIC;
                        break;

                    case NPCID.Merchant:
                        ShopUI.TheShop = ShopUI.MERCHANT;
                        break;

                    case NPCID.Nurse:
                        ShopUI.TheShop = ShopUI.NURSE;
                        break;

                    case NPCID.Painter:
                        ShopUI.TheShop = ShopUI.PAINTER;
                        break;

                    case NPCID.PartyGirl:
                        ShopUI.TheShop = ShopUI.PARTYGIRL;
                        break;

                    case NPCID.Pirate:
                        ShopUI.TheShop = ShopUI.PIRATE;
                        break;

                    case NPCID.SantaClaus:
                        ShopUI.TheShop = ShopUI.SANTACLAUS;
                        break;

                    case NPCID.SkeletonMerchant:
                        ShopUI.TheShop = ShopUI.SKELETONMERCHANT;
                        break;

                    case NPCID.Steampunker:
                        ShopUI.TheShop = ShopUI.STEAMPUNKER;
                        break;

                    case NPCID.Stylist:
                        ShopUI.TheShop = ShopUI.STYLIST;
                        break;

                    case NPCID.DD2Bartender:
                        ShopUI.TheShop = ShopUI.TAVERNKEEP;
                        break;

                    case NPCID.TaxCollector:
                        ShopUI.TheShop = ShopUI.TAXCOLLECTOR;
                        break;

                    case NPCID.TravellingMerchant:
                        ShopUI.TheShop = ShopUI.TRAVELLINGMERCHANT;
                        break;

                    case NPCID.Truffle:
                        ShopUI.TheShop = ShopUI.TRUFFLE;
                        break;

                    case NPCID.WitchDoctor:
                        ShopUI.TheShop = ShopUI.WITCHDOCTOR;
                        break;

                    case NPCID.Wizard:
                        ShopUI.TheShop = ShopUI.WIZARD;
                        break;
                }
                ShopUI.Visible = true;
                MerchantsPlus.UserInterface.SetState(new ShopUI());
            }

            // Reset shop category index
            ShopUI.ShopCounters[ShopUI.TheShop] = 0;

            return base.CanChat(npc);
        }
    }
}