using MerchantsPlus.Merchants;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.ID;
using Terraria.UI;

namespace MerchantsPlus.UI
{
    internal class ShopUI : UIState
    {
        public const int ANGLER = 0;
        public const int ARMSDEALER = 1;
        public const int CLOTHIER = 2;
        public const int CYBORG = 3;
        public const int DEMOLITIONIST = 4;
        public const int DRYAD = 5;
        public const int DYETRADER = 6;
        public const int GOBLINTINKERER = 7;
        public const int GUIDE = 8;
        public const int MECHANIC = 9;
        public const int MERCHANT = 10;
        public const int NURSE = 11;
        public const int PAINTER = 12;
        public const int PARTYGIRL = 13;
        public const int PIRATE = 14;
        public const int SANTACLAUS = 15;
        public const int SKELETONMERCHANT = 16;
        public const int STEAMPUNKER = 17;
        public const int STYLIST = 18;
        public const int TAVERNKEEP = 19;
        public const int TAXCOLLECTOR = 20;
        public const int TRAVELLINGMERCHANT = 21;
        public const int TRUFFLE = 22;
        public const int WITCHDOCTOR = 23;
        public const int WIZARD = 24;

        private static readonly Dictionary<int, Shop> shops = new Dictionary<int, Shop>() {
            { ANGLER, new ShopAngler(false, "Fishing Gear", "Bait", "Buffs", "Crates") },
            { ARMSDEALER, new ShopArmsDealer(true, "Guns", "Msc") },
            { CLOTHIER, new ShopClothier(true, "Clothing", "Boss Masks", "Vanity I", "Vanity II", "Vanity III", "Vanity IV") },
            { CYBORG, new ShopCyborg(true, "Robotics", "Buffs") },
            { DEMOLITIONIST, new ShopDemolitionist(true, "Explosives", "Potions") },
            { DRYAD, new ShopDryad(true, "Seeds", "Potions") },
            { DYETRADER, new ShopDyeTrader(true, "Color") },
            { GOBLINTINKERER, new ShopGoblinTinkerer(true, "Movement", "Informational", "Combat", "Health and Mana", 
                "Immunity", "Defensive", "Special", "Miscellaneous") },
            { MECHANIC, new ShopMechanic(true, "Mechanics", "Materials") },
            { MERCHANT, new ShopMerchant(true, "Gear", "Ores", "Pets", "Mounts") },
            { NURSE, new ShopNurse(true, "Potions") },
            { PAINTER, new ShopPainter(true, "Tools", "Paint", "Wallpaper", "Paintings I", "Paintings II") },
            { PARTYGIRL, new ShopPartyGirl(true, "Party Stuff") },
            { PIRATE, new ShopPirate(true, "Arrr", "Potions") },
            { SANTACLAUS, new ShopSantaClaus(true, "Decor", "Bulbs", "Lights", "Potions") },
            { SKELETONMERCHANT, new ShopSkeletonMerchant(true, "Gear", "Music Boxes") },
            { STEAMPUNKER, new ShopSteampunker(true, "Gear", "Solutions", "Logic") },
            { STYLIST, new ShopStylist(true, "Hair Dyes", "Overworld", "Underworld", "Desert", "Snow", "Jungle", "Ocean", 
                "Corruption", "Crimson", "Hallow", "Space", "Mushroom", "Dungeon", "Bloodmoon", "Eclipse", "Goblin Army", 
                "Old Ones Army", "Frost Legion", "Pumpkin Moon", "Frost Moon", "Pirate Invasion", "Martian Madness", 
                "Solar Zone", "Vortex Zone", "Nebula Zone", "Stardust Zone") },
            { TAVERNKEEP, new ShopTavernkeep(true, "Gear") },
            { TAXCOLLECTOR, new ShopTaxCollector(false) },
            { TRAVELLINGMERCHANT, new ShopTravellingMerchant(true, "Gear") },
            { TRUFFLE, new ShopTruffle(true, "Gear") },
            { WITCHDOCTOR, new ShopWitchDoctor(true, "Gear", "Flasks") },
            { WIZARD, new ShopWizard(true, "Gear") },
            { GUIDE, new ShopGuide(false, "Shop") }
        };

        public UIPanel ShopPanel;
        public static bool Visible;

        public static int TheShop;

        // Shop counters keeps track of the current shop index the player is in within that merchants set of shops
        public static int[] ShopCounters = new int[shops.Count];

        // Current shops keeps track of the current shop name the player is in within that merchants set of shops
        public static string[] CurrentShops = new string[shops.Count];

        private TextButton m_OpenShopButton;

        /// <summary>
        /// This is the first shop name the player will see (for all shops) before pressing cycle shop button.
        /// </summary>
        private void InitCurrentShops()
        {
            for (int i = 0; i < CurrentShops.Length; i++)
                CurrentShops[i] = "Shop";
        }

        public override void OnInitialize()
        {
            InitCurrentShops();

            ShopPanel = new UIPanel();
            ShopPanel.SetPadding(0);
            ShopPanel.Left.Set(200f, 0f);
            ShopPanel.Top.Set(428f, 0f);
            ShopPanel.Width.Set(250f, 0f);
            ShopPanel.Height.Set(35f, 0f);
            ShopPanel.BackgroundColor = Main.bgColor;

            m_OpenShopButton = new TextButton(CurrentShops[TheShop], 0.9f);
            m_OpenShopButton.Left.Set(10, 0f);
            m_OpenShopButton.Top.Set(4, 0f);
            m_OpenShopButton.OnClick += new MouseEvent(ShopButtonClicked);
            ShopPanel.Append(m_OpenShopButton);

            TextButton cycleShopButton = new TextButton("Cycle Shop", 0.9f);
            cycleShopButton.Left.Set(150, 0f);
            cycleShopButton.Top.Set(4, 0f);
            cycleShopButton.OnClick += new MouseEvent(CycleShopButtonClicked);
            ShopPanel.Append(cycleShopButton);

            Append(ShopPanel);
        }

        public override void Update(GameTime gameTime)
        {
            if (Main.LocalPlayer.talkNPC <= 0)
            {
                Visible = false;
            }
        }

        private void CycleShopButtonClicked(UIMouseEvent evt, UIElement listeningElement)
        {
            ShopPanel.RemoveChild(m_OpenShopButton);

            ShiftShop();

            // Recreate 'Open Shop Button', to update the name of the new shop once the cycle shop button is clicked
            m_OpenShopButton = new TextButton(CurrentShops[TheShop], 0.9f);
            m_OpenShopButton.Left.Set(10, 0f);
            m_OpenShopButton.Top.Set(4, 0f);
            m_OpenShopButton.OnClick += new MouseEvent(ShopButtonClicked);

            ShopPanel.Append(m_OpenShopButton);

            OpenShop();
        }

        private void ShiftShop()
        {
            if (shops[TheShop].Shops.Count == 0) return; // Safe Guard
            if (ShopCounters[TheShop] >= shops[TheShop].Shops.Count - 1)
            {
                CurrentShops[TheShop] = shops[TheShop].Shops[0];
                ShopCounters[TheShop] = 0;
            }
            else
            {
                CurrentShops[TheShop] = shops[TheShop].Shops[++ShopCounters[TheShop]];
            }
        }

        private void ShopButtonClicked(UIMouseEvent evt, UIElement listeningElement)
        {
            OpenShop();
        }

        private void OpenShop()
        {
            shops[TheShop].OpenShop(CurrentShops[TheShop]);
        }
    }
}