using Terraria;
using Terraria.GameContent;

namespace MerchantsPlus;

public class RemoveHappinessCurrencyMultiplier : ModSystem
{
    public override void Load()
    {
        On_ShopHelper.GetShoppingSettings += On_ShopHelper_GetShopSettings;
    }

    // https://github.com/tModLoader/tModLoader/wiki/Advanced-Detouring-Guide
    private static ShoppingSettings On_ShopHelper_GetShopSettings(On_ShopHelper.orig_GetShoppingSettings orig, ShopHelper self, Player player, NPC npc)
    {
        ShoppingSettings settings = orig(self, player, npc);

        if (Config.Instance.DisableHappinessPriceMultiplier)
        {
            settings.PriceAdjustment = 1;
        }

        return settings;
    }
}
