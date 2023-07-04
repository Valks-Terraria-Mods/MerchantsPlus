using MerchantsPlus.Merchants;
using Terraria.GameContent.UI.Elements;

namespace MerchantsPlus.UI;

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

    public static Dictionary<int, Shop> Shops = new() {
        { ANGLER, new ShopAngler(false, "Fishing Gear", "Bait", "Buffs", "Crates") },
        { ARMSDEALER, new ShopArmsDealer(true, "Guns") },
        { CLOTHIER, new ShopClothier(true, "Clothing", "Boss Masks", "Vanity I", "Vanity II", "Vanity III", "Vanity IV") },
        { CYBORG, new ShopCyborg(true, "Robotics", "Buffs") },
        { DEMOLITIONIST, new ShopDemolitionist(true, "Explosives", "Potions") },
        { DRYAD, new ShopDryad(true, "Seeds", "Potions") },
        { DYETRADER, new ShopDyeTrader(true, "Basic", "Bright", "Gradient", "Compound", "Strange", "Lunar") },
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
        { WITCHDOCTOR, new ShopWitchDoctor(true, "Gear", "Flasks", "Wings") },
        { WIZARD, new ShopWizard(true, "Gear") },
        { GUIDE, new ShopGuide(false, "Shop") }
    };

    public static bool Visible { get; set; }

    public static int CurrentShopIndex { get; set; }
    public static int[] ShopCycleIndexes { get; } = new int[Shops.Count];

    public UIPanel ShopPanel;

    readonly string[] shopNames = new string[Shops.Count];

    UIText currentShopName;

    public override void OnInitialize()
    {
        // This is the first shop name the player will see (for all shops)
        // before pressing cycle shop button
        for (int i = 0; i < shopNames.Length; i++)
            shopNames[i] = "Shop";

        ShopPanel = new UIPanel();
        ShopPanel.SetPadding(0);
        ShopPanel.Left.Set(200f, 0f);
        ShopPanel.Top.Set(428f, 0f);
        ShopPanel.Width.Set(250f, 0f);
        ShopPanel.Height.Set(35f, 0f);
        ShopPanel.BackgroundColor = new Color(0, 0, 0, 0.6f);

        currentShopName = new UIText(shopNames[CurrentShopIndex], 0.9f);
        currentShopName.Left.Set(10, 0f);
        currentShopName.Top.Set(8, 0f);
        currentShopName.OnClick += new MouseEvent(ShopButtonClicked);
        ShopPanel.Append(currentShopName);

        var cycleShopButton = new TextButton("Cycle Shop", 0.9f);
        cycleShopButton.Left.Set(150, 0f);
        cycleShopButton.Top.Set(4, 0f);
        cycleShopButton.OnClick += new MouseEvent(CycleShopButtonClicked);
        ShopPanel.Append(cycleShopButton);

        Append(ShopPanel);
    }

    private void CycleShopButtonClicked(UIMouseEvent evt, UIElement listeningElement)
    {
        ShopPanel.RemoveChild(currentShopName);

        ShiftShop();

        currentShopName.SetText(shopNames[CurrentShopIndex]);

        ShopPanel.Append(currentShopName);

        OpenShop();
    }

    private void ShiftShop()
    {
        if (Shops[CurrentShopIndex].Shops.Count == 0) return; // Safe Guard
        if (ShopCycleIndexes[CurrentShopIndex] >= Shops[CurrentShopIndex].Shops.Count - 1)
        {
            shopNames[CurrentShopIndex] = Shops[CurrentShopIndex].Shops[0];
            ShopCycleIndexes[CurrentShopIndex] = 0;
        }
        else
        {
            shopNames[CurrentShopIndex] = Shops[CurrentShopIndex].Shops[++ShopCycleIndexes[CurrentShopIndex]];
        }
    }

    private void ShopButtonClicked(UIMouseEvent evt, UIElement listeningElement) =>
        OpenShop();

    private void OpenShop() =>
        Shops[CurrentShopIndex].OpenShop(shopNames[CurrentShopIndex]);
}