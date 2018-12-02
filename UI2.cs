using MerchantsPlus.UI;
using Terraria;
using Terraria.ID;
using Terraria.UI;

namespace MerchantsPlus
{
    //combines a UserInterface and a UIState
    public class UI2 : UserInterface
    {
        public bool IsVisible
        {
            get
            {
                return base.IsVisible;
            }
            set
            {
                base.IsVisible = value;
                OnVisibilityChange(base.IsVisible);
            }
        }
        private void OnVisibilityChange(bool new_value)
        {
            Main.NewText("test");
            switch (ExampleUI.talkingTo)
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
        }
    }
}
