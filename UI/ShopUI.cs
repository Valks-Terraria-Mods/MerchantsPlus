using MerchantsPlus.Shops;
using Terraria.GameContent.UI.Elements;

namespace MerchantsPlus.UI;

public partial class ShopUI : UIState
{
    private const float PanelWidth = 375f;
    private const float PanelHeight = 114f;
    private const string HintPrefix = "Hint: ";
    private const float HintScale = 0.65f;
    private const float LeftColumnX = 16f;
    private const float LeftColumnWidth = 160f;
    private const float ListLeft = 170f;
    private const float ListTop = 4f;
    private const float ListBottomPadding = 34f;
    private const float HintLeft = LeftColumnX;
    private const float HintTop = 93f;
    private const float HintWrapWidth = PanelWidth - 16f;
    private readonly record struct ShopUnlockInfo(int LockedCount, int NextRequiredProgression, int NextItemId, bool HasCatalogData);

    public static Dictionary<int, Shop> Shops { get; } = CreateShops();

    public static bool Visible { get; set; }
    public static int CurrentMerchantId { get; set; }

    private UIText _merchantNameText;
    private UIText _shopNameText;
    private UIText _hintText;
    private UIList _shopList;
    private DraggableUIPanel _rootPanel;
    private int _lastMerchantId = NPCID.None;
    private int _lastSelectedIndex = -1;
    private string _lastShopsSignature = string.Empty;
    private int _lastHintMerchantId = NPCID.None;
    private string _lastHintShopName = string.Empty;
    private int _lastHintProgressionLevel = int.MinValue;
    private bool _lastHintUnlockAll;
    private string _lastHintText = string.Empty;

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
}
