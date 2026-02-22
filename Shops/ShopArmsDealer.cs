namespace MerchantsPlus.Shops;

public class ShopArmsDealer : Shop
{
    public override List<string> Shops { get; } = [.. ShopArmsDealerCatalog.ShopNames];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == ShopArmsDealerCatalog.GunsShopName)
        {
            Guns();
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.ArmsDealer);
    }

    private void Guns()
    {
        ShopBulletMain();
        ShopBulletOther();
        ShopPistol();
        ShopRifle();
        ShopShotgun();
        AddConditionalOffers(ShopArmsDealerCatalog.GunUnlocks);
        AddItem(ShopArmsDealerCatalog.AmmoBoxItemId);
    }

    private void ShopBulletMain()
    {
        ReplaceFromOffers(ShopArmsDealerCatalog.BulletMainReplacements);
    }

    private void ShopBulletOther()
    {
        ReplaceFromOffers(ShopArmsDealerCatalog.BulletOtherReplacements);

        ReplacePrice(Coins.Silver());
        ReplacePrice(Progression.SlimeKing, Coins.Copper(50));
        ReplacePrice(Progression.EyeOfCthulhu, Coins.Copper(25));
        ReplacePrice(Progression.BrainOrEater, Coins.Copper(5));
        ReplacePrice(Progression.QueenBee, Coins.Copper());
    }

    private void ShopPistol()
    {
        ReplaceFromOffers(ShopArmsDealerCatalog.PistolReplacements);
    }

    private void ShopRifle()
    {
        ReplaceFromOffers(ShopArmsDealerCatalog.RifleReplacements);
    }

    private void ShopShotgun()
    {
        ReplaceFromOffers(ShopArmsDealerCatalog.ShotgunReplacements);
    }

    private void ReplaceFromOffers(IReadOnlyList<ConditionalShopOffer> offers)
    {
        foreach (ConditionalShopOffer offer in offers)
        {
            if (!offer.IsUnlocked())
            {
                continue;
            }

            if (offer.ItemIds.Length > 0)
            {
                ReplaceItem(offer.ItemIds[0]);
            }

            if (offer.Price.HasValue)
            {
                ReplacePrice(offer.Price.Value);
            }
        }

        NextSlot++;
    }
}

