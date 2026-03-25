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
            { NPCID.Angler, new ShopExpandedOnly(NPCID.Angler) },
            { NPCID.ArmsDealer, new ShopExpandedOnly(NPCID.ArmsDealer) },
            { NPCID.Clothier, new ShopExpandedOnly(NPCID.Clothier) },
            { NPCID.Cyborg, new ShopExpandedOnly(NPCID.Cyborg) },
            { NPCID.Demolitionist, new ShopExpandedOnly(NPCID.Demolitionist) },
            { NPCID.Dryad, new ShopExpandedOnly(NPCID.Dryad) },
            { NPCID.DyeTrader, new ShopExpandedOnly(NPCID.DyeTrader) },
            { NPCID.GoblinTinkerer, new ShopExpandedOnly(NPCID.GoblinTinkerer) },
            { NPCID.Mechanic, new ShopExpandedOnly(NPCID.Mechanic) },
            { NPCID.Merchant, new ShopMerchant() },
            { NPCID.Nurse, new ShopExpandedOnly(NPCID.Nurse) },
            { NPCID.Painter, new ShopExpandedOnly(NPCID.Painter) },
            { NPCID.PartyGirl, new ShopExpandedOnly(NPCID.PartyGirl) },
            { NPCID.Pirate, new ShopExpandedOnly(NPCID.Pirate) },
            { NPCID.SantaClaus, new ShopExpandedOnly(NPCID.SantaClaus) },
            { NPCID.SkeletonMerchant, new ShopExpandedOnly(NPCID.SkeletonMerchant) },
            { NPCID.Steampunker, new ShopExpandedOnly(NPCID.Steampunker) },
            { NPCID.Stylist, new ShopExpandedOnly(NPCID.Stylist) },
            { NPCID.DD2Bartender, new ShopExpandedOnly(NPCID.DD2Bartender) },
            { NPCID.TaxCollector, new ShopExpandedOnly(NPCID.TaxCollector) },
            { NPCID.TravellingMerchant, new ShopExpandedOnly(NPCID.TravellingMerchant) },
            { NPCID.Truffle, new ShopExpandedOnly(NPCID.Truffle) },
            { NPCID.WitchDoctor, new ShopExpandedOnly(NPCID.WitchDoctor) },
            { NPCID.Guide, new ShopGuide() },
        };

        AddExpandedOnlyShop(shops, NPCID.Golfer);
        AddExpandedOnlyShop(shops, NPCID.Princess);
        AddExpandedOnlyShop(shops, NPCID.Wizard);

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
