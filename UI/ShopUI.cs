using MerchantsPlus.Merchants;
using Terraria.GameContent.UI.Elements;
using Terraria.ID;

namespace MerchantsPlus.UI;

// This UI will appear when a new dialog is opened with a merchant
internal class ShopUI : UIState
{
    public static Dictionary<int, Shop> Shops { get; } = new() {
        // DO NOT CHANGE THESE NAMES WITHOUT CHECKING THAT THEY MATCH
        // CORRECTLY INSIDE THEIR RESPECTIVE SHOP CLASSES!
        { NPCID.Angler, new ShopAngler("Bait", "Buffs", "Crates") },
        { NPCID.ArmsDealer, new ShopArmsDealer("Guns") },
        { NPCID.Clothier, new ShopClothier("Clothing", "Boss Masks", "Vanity I", "Vanity II", "Vanity III", "Vanity IV") },
        { NPCID.Cyborg, new ShopCyborg("Robotics", "Buffs") },
        { NPCID.Demolitionist, new ShopDemolitionist("Explosives", "Potions") },
        { NPCID.Dryad, new ShopDryad("Seeds", "Potions") },
        { NPCID.DyeTrader, new ShopDyeTrader("Basic", "Bright", "Gradient", "Compound", "Strange", "Lunar") },
        { NPCID.GoblinTinkerer, new ShopGoblinTinkerer("Movement", "Informational", "Combat", "Health and Mana",
            "Immunity", "Defensive", "Special", "Miscellaneous") },
        { NPCID.Mechanic, new ShopMechanic("Mechanics", "Materials") },
        { NPCID.Merchant, new ShopMerchant("Gear", "Ores", "Pets", "Mounts") },
        { NPCID.Nurse, new ShopNurse("Potions") },
        { NPCID.Painter, new ShopPainter("Tools", "Paint", "Wallpaper", "Paintings I", "Paintings II") },
        { NPCID.PartyGirl, new ShopPartyGirl("Party Stuff") },
        { NPCID.Pirate, new ShopPirate("Arrr", "Potions") },
        { NPCID.SantaClaus, new ShopSantaClaus("Decor", "Bulbs", "Lights", "Potions") },
        { NPCID.SkeletonMerchant, new ShopSkeletonMerchant("Gear", "Music Boxes") },
        { NPCID.Steampunker, new ShopSteampunker("Gear", "Solutions", "Logic") },
        { NPCID.Stylist, new ShopStylist("Hair Dyes", "Overworld", "Underworld", "Desert", "Snow", "Jungle", "Ocean",
            "Corruption", "Crimson", "Hallow", "Space", "Mushroom", "Dungeon", "Bloodmoon", "Eclipse", "Goblin Army",
            "Old Ones Army", "Frost Legion", "Pumpkin Moon", "Frost Moon", "Pirate Invasion", "Martian Madness",
            "Solar Zone", "Vortex Zone", "Nebula Zone", "Stardust Zone") },
        { NPCID.DD2Bartender, new ShopTavernkeep("Gear") },
        { NPCID.TaxCollector, new ShopTaxCollector() },
        { NPCID.TravellingMerchant, new ShopTravellingMerchant("Gear") },
        { NPCID.Truffle, new ShopTruffle("Gear") },
        { NPCID.WitchDoctor, new ShopWitchDoctor("Gear", "Flasks", "Wings") },
        { NPCID.Wizard, new ShopWizard("Gear") },
        { NPCID.Guide, new ShopGuide("Gear") }
    };

    public static bool Visible { get; set; }
    public static int CurrentMerchantID { get; set; }

    UIText currentShopName;
    UIPanel shopPanel;

    public override void OnInitialize()
    {
        shopPanel = new UIPanel();
        shopPanel.SetPadding(0);
        shopPanel.Left.Set(200f, 0f);
        shopPanel.Top.Set(428f, 0f);
        shopPanel.Width.Set(250f, 0f);
        shopPanel.Height.Set(35f, 0f);
        shopPanel.BackgroundColor = new Color(0, 0, 0, 0.6f);

        currentShopName = new UIText("Shop Name", 0.9f);
        currentShopName.Left.Set(10, 0f);
        currentShopName.Top.Set(8, 0f);
        currentShopName.OnLeftClick += new MouseEvent(ShopButtonClicked);
        shopPanel.Append(currentShopName);

        var cycleShopButton = new TextButton("Cycle Shop", 0.9f);
        cycleShopButton.Left.Set(150, 0f);
        cycleShopButton.Top.Set(4, 0f);
        cycleShopButton.OnLeftClick += new MouseEvent(CycleShopButtonClicked);
        shopPanel.Append(cycleShopButton);

        Append(shopPanel);
    }

    public void UpdateShopName()
    {
        if (Shops[CurrentMerchantID].Shops.Count == 0)
        {
            currentShopName.SetText("Shop");
            return;
        }

        int shopIndex = Shops[CurrentMerchantID].CycleIndex;

        currentShopName.SetText(Shops[CurrentMerchantID].Shops[shopIndex]);
    }

    void CycleShopButtonClicked(UIMouseEvent evt, UIElement listeningElement)
    {
        ShiftShop();
        UpdateShopName();
        OpenShop(Shops[CurrentMerchantID].CycleIndex);
    }

    void ShiftShop()
    {
        if (Shops[CurrentMerchantID].Shops.Count == 0) return; // Safe Guard
        if (Shops[CurrentMerchantID].CycleIndex >= Shops[CurrentMerchantID].Shops.Count - 1)
        {
            Shops[CurrentMerchantID].CycleIndex = 0;
        }
        else
        {
            Shops[CurrentMerchantID].CycleIndex++;
        }
    }

    void ShopButtonClicked(UIMouseEvent evt, UIElement listeningElement) =>
        OpenShop(0);

    void OpenShop(int shopIndex)
    {
        string shopToOpen = "";

        if (Shops[CurrentMerchantID].Shops.Count != 0)
            shopToOpen = Shops[CurrentMerchantID].Shops[shopIndex];

        Shops[CurrentMerchantID].OpenShop(shopToOpen);
    }
}