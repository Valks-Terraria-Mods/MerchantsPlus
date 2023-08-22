using MerchantsPlus.Merchants;
using Terraria.GameContent.UI.Elements;

namespace MerchantsPlus.UI;

// This UI will appear when a new dialog is opened with a merchant
internal class ShopUI : UIState
{
    public static Dictionary<int, Shop> Shops { get; } = new() {
        // DO NOT CHANGE THESE NAMES WITHOUT CHECKING THAT THEY MATCH
        // CORRECTLY INSIDE THEIR RESPECTIVE SHOP CLASSES!
        { NPCID.Angler, new ShopAngler() },
        { NPCID.ArmsDealer, new ShopArmsDealer() },
        { NPCID.Clothier, new ShopClothier() },
        { NPCID.Cyborg, new ShopCyborg() },
        { NPCID.Demolitionist, new ShopDemolitionist() },
        { NPCID.Dryad, new ShopDryad() },
        { NPCID.DyeTrader, new ShopDyeTrader() },
        { NPCID.GoblinTinkerer, new ShopGoblinTinkerer() },
        { NPCID.Mechanic, new ShopMechanic() },
        { NPCID.Merchant, new ShopMerchant() },
        { NPCID.Nurse, new ShopNurse() },
        { NPCID.Painter, new ShopPainter() },
        { NPCID.PartyGirl, new ShopPartyGirl() },
        { NPCID.Pirate, new ShopPirate() },
        { NPCID.SantaClaus, new ShopSantaClaus() },
        { NPCID.SkeletonMerchant, new ShopSkeletonMerchant() },
        { NPCID.Steampunker, new ShopSteampunker() },
        { NPCID.Stylist, new ShopStylist() },
        { NPCID.DD2Bartender, new ShopTavernkeep() },
        { NPCID.TaxCollector, new ShopTaxCollector() },
        { NPCID.TravellingMerchant, new ShopTravellingMerchant() },
        { NPCID.Truffle, new ShopTruffle() },
        { NPCID.WitchDoctor, new ShopWitchDoctor() },
        { NPCID.Wizard, new ShopWizard() },
        { NPCID.Guide, new ShopGuide() }
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
        if (Shops[CurrentMerchantID].Shops.Length == 0)
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
        if (Shops[CurrentMerchantID].Shops.Length == 0) return; // Safe Guard
        if (Shops[CurrentMerchantID].CycleIndex >= Shops[CurrentMerchantID].Shops.Length - 1)
        {
            Shops[CurrentMerchantID].CycleIndex = 0;
        }
        else
        {
            Shops[CurrentMerchantID].CycleIndex++;
        }
    }

    void ShopButtonClicked(UIMouseEvent evt, UIElement listeningElement) =>
        OpenShop(Shops[CurrentMerchantID].CycleIndex);

    void OpenShop(int shopIndex)
    {
        string shopToOpen = "";

        if (Shops[CurrentMerchantID].Shops.Length != 0)
            shopToOpen = Shops[CurrentMerchantID].Shops[shopIndex];

        Shops[CurrentMerchantID].OpenShop(shopToOpen);
    }
}