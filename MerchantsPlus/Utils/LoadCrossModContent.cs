using MerchantsPlus.ModDefs;
using MerchantsPlus.Shops;

namespace MerchantsPlus;

public class LoadCrossModContent : ModSystem
{
    private bool _loaded;
    
    public override void OnWorldLoad()
    {
        if (_loaded) return;
        
        if (ModLoader.TryGetMod("MagicStorage", out Mod magicStorage))
        {
            MagicStorage.Load(magicStorage);
            ShopUI.Shops.Add(MagicStorage.Golem.Type, new ShopGolem());
        }

        if (ModLoader.TryGetMod("CalamityMod", out Mod _))
        {
            Shop shop = ShopUI.Shops[NPCID.Guide];
            shop.Shops.Add("Calamity");
        }

        if (ModLoader.TryGetMod("ThoriumMod", out Mod _))
        {
            Shop shop = ShopUI.Shops[NPCID.Guide];
            shop.Shops.Add("Thorium");
        }

        if (ModLoader.TryGetMod("Redemption", out Mod _))
        {
            Shop shop = ShopUI.Shops[NPCID.Guide];
            shop.Shops.Add("Redemption");
        }

        _loaded = true;
    }
}
