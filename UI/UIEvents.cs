using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.UI
{
    internal class UIEvents : GlobalNPC
    {
        public override bool? CanChat(NPC npc)
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
                case NPCID.Nurse:
                case NPCID.Merchant:
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
                case NPCID.OldMan:
                case NPCID.BoundGoblin:
                case NPCID.BoundMechanic:
                case NPCID.BoundWizard:
                case NPCID.SleepingAngler:
                    if (!ExampleUI.Visible)
                    {
                        switch (npc.type)
                        {
                            case NPCID.Angler:
                                ExampleUI.the_shop = ExampleUI.ANGLER;
                                break;

                            case NPCID.ArmsDealer:
                                ExampleUI.the_shop = ExampleUI.ARMSDEALER;
                                break;

                            case NPCID.Clothier:
                                ExampleUI.the_shop = ExampleUI.CLOTHIER;
                                break;

                            case NPCID.Cyborg:
                                ExampleUI.the_shop = ExampleUI.CYBORG;
                                break;

                            case NPCID.Demolitionist:
                                ExampleUI.the_shop = ExampleUI.DEMOLITIONIST;
                                break;

                            case NPCID.Dryad:
                                ExampleUI.the_shop = ExampleUI.DRYAD;
                                break;

                            case NPCID.DyeTrader:
                                ExampleUI.the_shop = ExampleUI.DYETRADER;
                                break;

                            case NPCID.GoblinTinkerer:
                                ExampleUI.the_shop = ExampleUI.GOBLINTINKERER;
                                break;

                            case NPCID.Guide:
                                ExampleUI.the_shop = ExampleUI.GUIDE;
                                break;

                            case NPCID.Mechanic:
                                ExampleUI.the_shop = ExampleUI.MECHANIC;
                                break;

                            case NPCID.Merchant:
                                ExampleUI.the_shop = ExampleUI.MERCHANT;
                                break;

                            case NPCID.Nurse:
                                ExampleUI.the_shop = ExampleUI.NURSE;
                                break;

                            case NPCID.Painter:
                                ExampleUI.the_shop = ExampleUI.PAINTER;
                                break;

                            case NPCID.PartyGirl:
                                ExampleUI.the_shop = ExampleUI.PARTYGIRL;
                                break;

                            case NPCID.Pirate:
                                ExampleUI.the_shop = ExampleUI.PIRATE;
                                break;

                            case NPCID.SantaClaus:
                                ExampleUI.the_shop = ExampleUI.SANTACLAUS;
                                break;

                            case NPCID.SkeletonMerchant:
                                ExampleUI.the_shop = ExampleUI.SKELETONMERCHANT;
                                break;

                            case NPCID.Steampunker:
                                ExampleUI.the_shop = ExampleUI.STEAMPUNKER;
                                break;

                            case NPCID.Stylist:
                                ExampleUI.the_shop = ExampleUI.STYLIST;
                                break;

                            case NPCID.DD2Bartender:
                                ExampleUI.the_shop = ExampleUI.TAVERNKEEP;
                                break;

                            case NPCID.TaxCollector:
                                ExampleUI.the_shop = ExampleUI.TAXCOLLECTOR;
                                break;

                            case NPCID.TravellingMerchant:
                                ExampleUI.the_shop = ExampleUI.TRAVELLINGMERCHANT;
                                break;

                            case NPCID.Truffle:
                                ExampleUI.the_shop = ExampleUI.TRUFFLE;
                                break;

                            case NPCID.WitchDoctor:
                                ExampleUI.the_shop = ExampleUI.WITCHDOCTOR;
                                break;

                            case NPCID.Wizard:
                                ExampleUI.the_shop = ExampleUI.WIZARD;
                                break;
                        }
                        ExampleUI.Visible = true;
                        MerchantsPlus.instance._exampleUserInterface.SetState(new ExampleUI());
                    }
                    break;
            }

            // Reset shop category index
            ExampleUI.ShopCounters[ExampleUI.the_shop] = 0;

            return base.CanChat(npc);
        }
    }
}