using MerchantsPlus.Shops;
using Terraria.GameContent.UI.Elements;

namespace MerchantsPlus.UI;

public class ShopUI : UIState
{
    public static Dictionary<int, Shop> Shops { get; } = CreateShops();

    public static bool Visible { get; set; }
    public static int CurrentMerchantId { get; set; }

    private TextButton _merchantNameBtn;
    private TextButton _shopNameBtn;
    private TextButton _cycleShopBtn;

    private static Dictionary<int, Shop> CreateShops()
    {
        Dictionary<int, Shop> shops = new()
        {
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
            { NPCID.Guide, new ShopGuide() },
        };

        AddExpandedOnlyShop(shops, NPCID.Golfer);
        AddExpandedOnlyShop(shops, NPCID.Princess);

        AddExpandedOnlyShop(shops, "TownCat");
        AddExpandedOnlyShop(shops, "TownDog");
        AddExpandedOnlyShop(shops, "TownBunny");

        AddExpandedOnlyShop(shops, "TownSlimeBlue");    // Nerdy Slime
        AddExpandedOnlyShop(shops, "TownSlimeGreen");   // Cool Slime
        AddExpandedOnlyShop(shops, "TownSlimeOld");     // Elder Slime
        AddExpandedOnlyShop(shops, "TownSlimePurple");  // Clumsy Slime
        AddExpandedOnlyShop(shops, "TownSlimeRainbow"); // Diva Slime
        AddExpandedOnlyShop(shops, "TownSlimeRed");     // Surly Slime
        AddExpandedOnlyShop(shops, "TownSlimeYellow");  // Mystic Slime
        AddExpandedOnlyShop(shops, "TownSlimeCopper");  // Squire Slime

        return shops;
    }

    private static void AddExpandedOnlyShop(Dictionary<int, Shop> shops, int npcId)
    {
        if (npcId < 0 || shops.ContainsKey(npcId))
        {
            return;
        }

        shops[npcId] = new ShopExpandedOnly(npcId);
    }

    private static void AddExpandedOnlyShop(Dictionary<int, Shop> shops, string npcName)
    {
        int npcId = NPCID.Search.GetId(npcName);
        AddExpandedOnlyShop(shops, npcId);
    }

    public override void OnInitialize()
    {
        // Setup panel
        UIPanel panel = new();
        panel.SetPadding(0);
        panel.Left.Set(75f, 0f);
        panel.Top.Set(428f, 0f);
        panel.Width.Set(375f, 0f);
        panel.Height.Set(35f, 0f);
        panel.BackgroundColor = new Color(0, 0, 0, 153);

        // Merchant name button
        _merchantNameBtn = CreateButton(0.03f, "Merchant", OnShopButtonClicked);
        panel.Append(_merchantNameBtn);

        // Current shop name button
        _shopNameBtn = CreateButton(0.5f, "Shop", OnShopButtonClicked);
        panel.Append(_shopNameBtn);

        // Cycle shop button
        _cycleShopBtn = CreateButton(0.97f, "Cycle Shop", OnCycleShopForward);
        _cycleShopBtn.OnRightClick += OnCycleShopBackward;
        panel.Append(_cycleShopBtn);

        Append(panel);
    }

    public override void OnActivate()
    {
        Visible = true;
    }

    public override void OnDeactivate()
    {
        Visible = false;
    }

    public void UpdateUI()
    {
        if (!Visible || !Shops.TryGetValue(CurrentMerchantId, out Shop shop))
            return;

        NPC npc = Array.Find(Main.npc, n => n.active && n.type == CurrentMerchantId);
        List<string> visibleShops = Shop.GetVisibleShops(CurrentMerchantId, shop.Shops);

        _merchantNameBtn.SetText(npc != null ? npc.TypeName : "Merchant");

        if (visibleShops.Count > 0)
        {
            if (shop.CycleIndex >= visibleShops.Count)
            {
                shop.CycleIndex = 0;
            }

            _shopNameBtn.SetText(visibleShops[shop.CycleIndex]);
            _cycleShopBtn.SetText(visibleShops.Count > 1 ? "Cycle Shop" : string.Empty);
        }
        else
        {
            _shopNameBtn.SetText("Shop");
            _cycleShopBtn.SetText(string.Empty);
        }
    }

    // Create a TextButton and hook its left-click handler
    private static TextButton CreateButton(float hAlign, string initialText, MouseEvent onClick)
    {
        TextButton btn = new(initialText, 0.9f)
        {
            HAlign = hAlign
        };

        btn.Top.Set(4, 0);
        btn.OnLeftClick += onClick;

        return btn;
    }

    private void OnShopButtonClicked(UIMouseEvent evt, UIElement elm)
    {
        OpenCurrentShop();
    }

    private void OnCycleShopForward(UIMouseEvent evt, UIElement elm)
    {
        CycleShop(true);
    }

    private void OnCycleShopBackward(UIMouseEvent evt, UIElement elm)
    {
        CycleShop(false);
    }

    private void CycleShop(bool forward)
    {
        Shop shop = Shops[CurrentMerchantId];
        List<string> visibleShops = Shop.GetVisibleShops(CurrentMerchantId, shop.Shops);

        int count = visibleShops.Count;
        if (count <= 1)
            return;

        if (shop.CycleIndex >= count)
        {
            shop.CycleIndex = 0;
        }

        int newIndex = forward
            ? (shop.CycleIndex + 1) % count
            : (shop.CycleIndex - 1 + count) % count;

        shop.CycleIndex = newIndex;

        UpdateUI();
        OpenCurrentShop();
    }

    private static void OpenCurrentShop()
    {
        Shop shop = Shops[CurrentMerchantId];
        List<string> visibleShops = Shop.GetVisibleShops(CurrentMerchantId, shop.Shops);
        if (visibleShops.Count == 0)
            return;

        if (shop.CycleIndex >= visibleShops.Count)
        {
            shop.CycleIndex = 0;
        }

        string shopName = visibleShops[shop.CycleIndex];
        shop.OpenShop(shopName);
    }
}
