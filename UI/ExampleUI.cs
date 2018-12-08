using MerchantsPlus.Shops;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace MerchantsPlus.UI
{
    internal class ExampleUI : UIState
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

        public UIPanel CoinCounterPanel;
        public UIHoverImageButton ExampleButton;
        public static bool Visible;

        public static int the_shop = 0;

        public static bool UpdateName;

        private static string[][] shopNames = new string[][]{
            new string[]{ "Fishing Stuff", "Bait", "Buffs", "Crates" },
            new string[]{ "Vanilla", "Guns", "Msc" },
            new string[]{ "Vanilla", "Clothing"},
            new string[]{ "Vanilla", "Robotics", "Buffs" },
            new string[]{ "Vanilla", "Explosives", "Msc"},
            new string[]{ "Vanilla", "Seeds", "Msc"},
            new string[]{ "Vanilla", "Color" },
            new string[]{  "Vanilla", "Movement", "Informational", "Combat", "Health and Mana", "Immunity", "Defensive", "Special", "Miscellaneous", "Calamity Special"},
            new string[]{ "Shop", "Msc" },
            new string[]{ "Vanilla", "Mechanics",    "Wood",        "Rich Mahogany",        "Boreal",        "Palm",        "Ebonwood",        "Shadewood",        "Pearlwood",        "Spooky",        "Dynasty",        "Cactus",        "Pumpkin",        "Mushroom",        "Granite",        "Marble",        "Meteorite",        "Crystal",        "Glass",        "Living",        "Skyware",        "Frozen",        "Honey",        "Slime",        "Bone",        "Flesh",        "Steampunk",        "Lihzahrd",        "Martian",        "Obsidian",        "Dungeon",        "Golden"},
            new string[]{  "Vanilla","Gear", "Pets", "Mounts", "Overhaul"},
            new string[]{ "Healing", "Potions" },
            new string[]{ "Vanilla","Tools", "Paint", "Wallpaper", "Paintings 1", "Paintings 2"},
            new string[]{ "Vanilla", "Party Stuff", "Vanity Sets 1", "Vanity Sets 2", "Vanity Sets 3", "Vanity Sets 4", "Boss Masks" },
            new string[]{ "Vanilla", "Arrr", "Potions"  },
            new string[]{"Vanilla", "Decor", "Bulbs", "Lights", "Potions"  },
            new string[]{"Vanilla","Gear", "Music Boxes"  },
            new string[]{  "Vanilla", "Gear", "Solutions", "Logic"},
            new string[]{"Vanilla", "Hair Dyes",        "Overworld",        "Underworld",        "Desert",        "Snow",        "Jungle",        "Ocean",        "Corruption",        "Crimson",        "Hallow",        "Space",        "Mushroom",        "Dungeon",        "Bloodmoon",        "Eclipse",        "Goblin Army",        "Old Ones Army",        "Frost Legion",        "Pumpkin Moon",        "Frost Moon",        "Pirate Invasion",        "Martian Madness",        "Solar Zone",        "Vortex Zone",        "Nebula Zone",        "Stardust Zone" },
            new string[]{  "Vanilla", "Gear" },
            new string[]{"NotImplemented" },
            new string[]{ "Vanilla", "Gear" },
            new string[]{ "Vanilla", "Gear"},
            new string[]{  "Vanilla","Gear", "Flasks"},
            new string[]{ "Vanilla","Gear" }
        };
        private static int[] shopCounters = new int[shopNames.Length];
        private static string[] currentShops = new string[shopNames.Length];

        private TextButton button;

        private void InitCurrentShopNames()
        {
            for (int i = 0; i < shopNames.Length; i++)
            {
                currentShops[i] = shopNames[i][0];
            }
        }

        public override void OnInitialize()
        {
            InitCurrentShopNames();

            CoinCounterPanel = new UIPanel();
            CoinCounterPanel.SetPadding(0);

            if (MerchantsPlus.autoTrashLoaded)
            {
                CoinCounterPanel.Left.Set(160f, 0f);
            }
            else {
                CoinCounterPanel.Left.Set(200f, 0f);
            }
            
            CoinCounterPanel.Top.Set(428f, 0f);
            CoinCounterPanel.Width.Set(250f, 0f);
            CoinCounterPanel.Height.Set(35f, 0f);
            CoinCounterPanel.BackgroundColor = Main.bgColor;

            button = new TextButton(currentShops[the_shop], 0.9f);
            button.Left.Set(10, 0f);
            button.Top.Set(4, 0f);
            button.OnClick += new MouseEvent(PlayButtonClicked);
            CoinCounterPanel.Append(button);

            TextButton button2 = new TextButton("Cycle Shop", 0.9f);
            button2.Left.Set(150, 0f);
            button2.Top.Set(4, 0f);
            button2.OnClick += new MouseEvent(CycleShopButtonClicked);
            CoinCounterPanel.Append(button2);

            Append(CoinCounterPanel);
        }

        public override void Update(GameTime gameTime)
        {
            if (Main.LocalPlayer.talkNPC <= 0)
            {
                Visible = false;
                //MerchantsPlus.instance._exampleUserInterface.IsVisible = false;
            }
        }

        private void CycleShopButtonClicked(UIMouseEvent evt, UIElement listeningElement)
        {
            CoinCounterPanel.RemoveChild(button);

            ShiftShop();

            button = new TextButton(currentShops[the_shop], 0.9f);
            button.Left.Set(10, 0f);
            button.Top.Set(4, 0f);
            button.OnClick += new MouseEvent(PlayButtonClicked);

            CoinCounterPanel.Append(button);
        }

        private void ShiftShop()
        {
            if (shopCounters[the_shop] >= shopNames[the_shop].Length - 1)
            {
                currentShops[the_shop] = shopNames[the_shop][0];
                shopCounters[the_shop] = 0;
            }
            else
            {
                currentShops[the_shop] = shopNames[the_shop][++shopCounters[the_shop]];
            }
        }

        private void PlayButtonClicked(UIMouseEvent evt, UIElement listeningElement)
        {
            //Main.PlaySound(SoundID.MenuOpen);
            //Main.NewText(Main.npc[Main.player[Main.myPlayer].talkNPC].type);
            //Visible = false;


            Main.PlaySound(12, -1, -1, 1, 1f, 0f);
            Main.playerInventory = true;
            Main.npcChatText = "";
            Main.npcShop = 20;
            Chest shop = Main.instance.shop[Main.npcShop];
            shop.SetupShop(0);

            int nextSlot = 0;

            switch (the_shop) {
                case ANGLER:
                    ShopAngler shopAngler = new ShopAngler(shop, nextSlot);
                    shopAngler.InitShop(currentShops[the_shop]);
                    break;
                case ARMSDEALER:
                    ShopArmsDealer shopArmsDealer = new ShopArmsDealer(shop, nextSlot);
                    shopArmsDealer.InitShop(currentShops[the_shop]);
                    break;
                case CLOTHIER:
                    ShopClothier shopClothier = new ShopClothier(shop, nextSlot);
                    shopClothier.InitShop(currentShops[the_shop]);
                    break;
                case CYBORG:
                    ShopCyborg shopCyborg = new ShopCyborg(shop, nextSlot);
                    shopCyborg.InitShop(currentShops[the_shop]);
                    break;
                case DEMOLITIONIST:
                    ShopDemolitionist shopDemolitionist = new ShopDemolitionist(shop, nextSlot);
                    shopDemolitionist.InitShop(currentShops[the_shop]);
                    break;
                case DRYAD:
                    ShopDryad shopDryad = new ShopDryad(shop, nextSlot);
                    shopDryad.InitShop(currentShops[the_shop]);
                    break;
                case DYETRADER:
                    ShopDyeTrader shopDyeTrader = new ShopDyeTrader(shop, nextSlot);
                    shopDyeTrader.InitShop(currentShops[the_shop]);
                    break;
                case GOBLINTINKERER:
                    ShopGoblinTinkerer shopGoblinTinkerer = new ShopGoblinTinkerer(shop, nextSlot);
                    shopGoblinTinkerer.InitShop(currentShops[the_shop]);
                    break;
                case GUIDE:
                    ShopGuide shopGuide = new ShopGuide(shop, nextSlot);
                    shopGuide.InitShop(currentShops[the_shop]);
                    break;
                case MECHANIC:
                    ShopMechanic shopMechanic = new ShopMechanic(shop, nextSlot);
                    shopMechanic.InitShop(currentShops[the_shop]);
                    break;
                case MERCHANT:
                    ShopMerchant shopMerchant = new ShopMerchant(shop, nextSlot);
                    shopMerchant.InitShop(currentShops[the_shop]);
                    break;
                case NURSE:
                    ShopNurse shopNurse = new ShopNurse(shop, nextSlot);
                    shopNurse.InitShop(currentShops[the_shop]);
                    break;
                case PAINTER:
                    ShopPainter shopPainter = new ShopPainter(shop, nextSlot);
                    shopPainter.InitShop(currentShops[the_shop]);
                    break;
                case PARTYGIRL:
                    ShopPartyGirl shopPartyGirl = new ShopPartyGirl(shop, nextSlot);
                    shopPartyGirl.InitShop(currentShops[the_shop]);
                    break;
                case PIRATE:
                    ShopPirate shopPirate = new ShopPirate(shop, nextSlot);
                    shopPirate.InitShop(currentShops[the_shop]);
                    break;
                case SANTACLAUS:
                    ShopSantaClaus shopSantaClaus = new ShopSantaClaus(shop, nextSlot);
                    shopSantaClaus.InitShop(currentShops[the_shop]);
                    break;
                case SKELETONMERCHANT:
                    ShopSkeletonMerchant shopSkeletonMerchant = new ShopSkeletonMerchant(shop, nextSlot);
                    shopSkeletonMerchant.InitShop(currentShops[the_shop]);
                    break;
                case STEAMPUNKER:
                    ShopSteampunker shopSteampunker = new ShopSteampunker(shop, nextSlot);
                    shopSteampunker.InitShop(currentShops[the_shop]);
                    break;
                case STYLIST:
                    ShopStylist shopStylist = new ShopStylist(shop, nextSlot);
                    shopStylist.InitShop(currentShops[the_shop]);
                    break;
                case TAVERNKEEP:
                    ShopTavernkeep shopTavernkeep = new ShopTavernkeep(shop, nextSlot);
                    shopTavernkeep.InitShop(currentShops[the_shop]);
                    break;
                case TAXCOLLECTOR:
                    ShopTaxCollector shopTaxCollector = new ShopTaxCollector(shop, nextSlot);
                    shopTaxCollector.InitShop(currentShops[the_shop]);
                    break;
                case TRAVELLINGMERCHANT:
                    ShopTravellingMerchant shopTravellingMerchant = new ShopTravellingMerchant(shop, nextSlot);
                    shopTravellingMerchant.InitShop(currentShops[the_shop]);
                    break;
                case TRUFFLE:
                    ShopTruffle shopTruffle = new ShopTruffle(shop, nextSlot);
                    shopTruffle.InitShop(currentShops[the_shop]);
                    break;
                case WITCHDOCTOR:
                    ShopWitchDoctor shopWitchDoctor = new ShopWitchDoctor(shop, nextSlot);
                    shopWitchDoctor.InitShop(currentShops[the_shop]);
                    break;
                case WIZARD:
                    ShopWizard shopWizard = new ShopWizard(shop, nextSlot);
                    shopWizard.InitShop(currentShops[the_shop]);
                    break;
            }
        }
    }
}