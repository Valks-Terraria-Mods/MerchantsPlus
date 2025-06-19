using MerchantsPlus.Shops;
using Terraria.GameContent.UI.Elements;

namespace MerchantsPlus.UI;

public class ShopUI : UIState
{
    public static Dictionary<int, Shop> Shops { get; } = new() {
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
    public static int CurrentMerchantId { get; set; }

    private TextButton _merchantName;
    private TextButton _currentShopName;
    private TextButton _cycleShopBtn;

    public override void OnInitialize()
    {
        UIPanel shopPanel = new();
        shopPanel.SetPadding(0);
        shopPanel.Left.Set(75f, 0f);
        shopPanel.Top.Set(428f, 0f);
        shopPanel.Width.Set(375f, 0f);
        shopPanel.Height.Set(35f, 0f);
        shopPanel.BackgroundColor = new Color(0, 0, 0, 0.6f);

        _merchantName = new TextButton("Merchant Name", 0.9f)
        {
            HAlign = 0.03f
        };

        _merchantName.Top.Set(4, 0f);
        _merchantName.OnLeftClick += ShopButtonClicked;

        shopPanel.Append(_merchantName);

        _currentShopName = new TextButton("Shop Name", 0.9f)
        {
            HAlign = 0.5f
        };

        _currentShopName.Top.Set(4, 0f);
        _currentShopName.OnLeftClick += ShopButtonClicked;

        shopPanel.Append(_currentShopName);

        _cycleShopBtn = new TextButton("Cycle Shop", 0.9f)
        {
            HAlign = 0.97f
        };

        _cycleShopBtn.Top.Set(4, 0f);
        _cycleShopBtn.OnLeftClick += CycleShopButtonClicked;

        shopPanel.Append(_cycleShopBtn);

        Append(shopPanel);
    }

    public void UpdateUI()
    {
        UpdateShopName();
        UpdateMerchantName();
        UpdateCycleShopName();
    }

    private void UpdateCycleShopName()
    {
        _cycleShopBtn.SetText(Shops[CurrentMerchantId].Shops.Count == 1 ? "" : "Cycle Shop");
    }

    private void UpdateMerchantName()
    {
        foreach (NPC npc in Main.npc)
        {
            if (npc.type != CurrentMerchantId) 
                continue;
            
            _merchantName.SetText(npc.TypeName);
            return;
        }

        // If you cannot find the merchant name, default to "Merchant"
        _merchantName.SetText("Merchant");
    }

    private void UpdateShopName()
    {
        if (Shops[CurrentMerchantId].Shops.Count == 0)
        {
            _currentShopName.SetText("Shop");
            return;
        }

        int shopIndex = Shops[CurrentMerchantId].CycleIndex;

        _currentShopName.SetText(Shops[CurrentMerchantId].Shops[shopIndex]);
    }

    private void CycleShopButtonClicked(UIMouseEvent evt, UIElement listeningElement)
    {
        ShiftShop();
        UpdateUI();
        OpenShop(Shops[CurrentMerchantId].CycleIndex);
    }

    private static void ShiftShop()
    {
        if (Shops[CurrentMerchantId].Shops.Count == 0)
        {
            return; // SafeGuard
        }

        if (Shops[CurrentMerchantId].CycleIndex >= Shops[CurrentMerchantId].Shops.Count - 1)
        {
            Shops[CurrentMerchantId].CycleIndex = 0;
        }
        else
        {
            Shops[CurrentMerchantId].CycleIndex++;
        }
    }

    private static void ShopButtonClicked(UIMouseEvent evt, UIElement listeningElement)
    {
        OpenShop(Shops[CurrentMerchantId].CycleIndex);
    }

    private static void OpenShop(int shopIndex)
    {
        string shopToOpen = "";

        if (Shops[CurrentMerchantId].Shops.Count != 0)
        {
            shopToOpen = Shops[CurrentMerchantId].Shops[shopIndex];
        }

        Shops[CurrentMerchantId].OpenShop(shopToOpen);
    }
}