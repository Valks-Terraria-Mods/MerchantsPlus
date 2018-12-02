using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
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

        public DragableUIPanel CoinCounterPanel;
        public UIHoverImageButton ExampleButton;
        public static bool Visible;
        public static int talkingTo;

        public static int the_shop = 0;

        public static bool UpdateName;

        private static string[][] shopNames = new string[][]{
            new string[]{ "Fishing Stuff", "Bait", "Buffs", "Crates" },
            new string[]{ "Guns", "Msc" },
            new string[]{ "Clothing"},
            new string[]{"Robotics", "Buffs" },
            new string[]{ "Explosives", "Msc"},
            new string[]{ "Nature", "Seeds", "Msc"},
            new string[]{"Strange Plants", "Color" },
            new string[]{  "Reforge", "Workshop", "Movement", "Informational", "Combat", "Health and Mana", "Immunity", "Defensive", "Special", "Miscellaneous", "Calamity Special"},
            new string[]{ "Shop", "Msc" },
            new string[]{ "Mechanics",    "Wood",        "Rich Mahogany",        "Boreal",        "Palm",        "Ebonwood",        "Shadewood",        "Pearlwood",        "Spooky",        "Dynasty",        "Cactus",        "Pumpkin",        "Mushroom",        "Granite",        "Marble",        "Meteorite",        "Crystal",        "Glass",        "Living",        "Skyware",        "Frozen",        "Honey",        "Slime",        "Bone",        "Flesh",        "Steampunk",        "Lihzahrd",        "Martian",        "Obsidian",        "Dungeon",        "Golden"},
            new string[]{  "Gear", "Pets", "Mounts", "Overhaul"},
            new string[]{ "Heal", "Stuff" },
            new string[]{ "Tools", "Paint", "Wallpaper", "Paintings 1", "Paintings 2"},
            new string[]{"Party Stuff", "Vanity Sets 1", "Vanity Sets 2", "Vanity Sets 3", "Vanity Sets 4", "Boss Masks" },
            new string[]{ "Arrr", "Potions"  },
            new string[]{"Decor", "Bulbs", "Lights", "Potions"  },
            new string[]{"Gear", "Music Boxes"  },
            new string[]{  "Gear", "Solutions", "Logic"},
            new string[]{"Hair Dyes",        "Overworld",        "Underworld",        "Desert",        "Snow",        "Jungle",        "Ocean",        "Corruption",        "Crimson",        "Hallow",        "Space",        "Mushroom",        "Dungeon",        "Bloodmoon",        "Eclipse",        "Goblin Army",        "Old Ones Army",        "Frost Legion",        "Pumpkin Moon",        "Frost Moon",        "Pirate Invasion",        "Martian Madness",        "Solar Zone",        "Vortex Zone",        "Nebula Zone",        "Stardust Zone" },
            new string[]{  "Gear" },
            new string[]{"NotImplemented" },
            new string[]{ "Gear" },
            new string[]{ "Gear"},
            new string[]{  "Gear", "Flasks"},
            new string[]{ "Gear" }
        };
        private static int[] shopCounters = new int[shopNames.Length];
        private static string[] currentShops = new string[shopNames.Length];

        private TextButton button;

        private void InitCurrentShopNames() {
            for (int i = 0; i < shopNames.Length; i++)
            {
                currentShops[i] = shopNames[i][0];
            }
        }

        public override void OnInitialize()
        {
            InitCurrentShopNames();

            CoinCounterPanel = new DragableUIPanel();
            CoinCounterPanel.SetPadding(0);
            
            CoinCounterPanel.Left.Set(150f, 0f);
            CoinCounterPanel.Top.Set(190f, 0f);
            CoinCounterPanel.Width.Set(200f, 0f);
            CoinCounterPanel.Height.Set(35f, 0f);
            CoinCounterPanel.BackgroundColor = new Color(73, 94, 171);

            button = new TextButton(currentShops[the_shop], 0.9f);
            button.Left.Set(25, 0f);
            button.Top.Set(3, 0f);
            button.OnClick += new MouseEvent(PlayButtonClicked);
            CoinCounterPanel.Append(button);

            TextButton button2 = new TextButton("Cycle Shop", 0.9f);
            button2.Left.Set(80, 0f);
            button2.Top.Set(3, 0f);
            button2.OnClick += new MouseEvent(CycleShopButtonClicked);
            CoinCounterPanel.Append(button2);

            Append(CoinCounterPanel);
        }

        private void CycleShopButtonClicked(UIMouseEvent evt, UIElement listeningElement) 
        {
            CoinCounterPanel.RemoveChild(button);

            ShiftShop();

            button = new TextButton(currentShops[the_shop], 0.9f);
            button.Left.Set(25, 0f);
            button.Top.Set(3, 0f);
            button.OnClick += new MouseEvent(PlayButtonClicked);

            CoinCounterPanel.Append(button);
        }

        private void ShiftShop() {
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
            Visible = false;
            Main.PlaySound(12, -1, -1, 1, 1f, 0f);
            Main.playerInventory = true;
            Main.npcChatText = "";
            Main.npcShop = 20;
            Chest shop = Main.instance.shop[Main.npcShop];
            shop.SetupShop(Main.npcShop);
            for (int i = 0; i < shop.item.Length; i++) {
                shop.item[i].TurnToAir();
            }

            int nextSlot = 0;

            if (the_shop == WITCHDOCTOR) {
                switch (currentShops[the_shop])
                {
                    case "Flasks":
                        shop.item[nextSlot++].SetDefaults(ItemID.FlaskofCursedFlames);
                        shop.item[nextSlot++].SetDefaults(ItemID.FlaskofFire);
                        shop.item[nextSlot++].SetDefaults(ItemID.FlaskofGold);
                        shop.item[nextSlot++].SetDefaults(ItemID.FlaskofIchor);
                        shop.item[nextSlot++].SetDefaults(ItemID.FlaskofNanites);
                        shop.item[nextSlot++].SetDefaults(ItemID.FlaskofParty);
                        shop.item[nextSlot++].SetDefaults(ItemID.FlaskofPoison);
                        shop.item[nextSlot++].SetDefaults(ItemID.FlaskofVenom);
                        break;
                    default:
                        shop.item[nextSlot++].SetDefaults(ItemID.HerculesBeetle);
                        shop.item[nextSlot++].SetDefaults(ItemID.NecromanticScroll);
                        shop.item[nextSlot++].SetDefaults(ItemID.PygmyNecklace);
                        break;
                }
            }
            
        }
    }
}