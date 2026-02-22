namespace MerchantsPlus.Shops;

public class ShopArmsDealer : Shop
{
    private static bool UnlockAllItems => Config.Instance?.UnlockAllItems == true;

    public override List<string> Shops { get; } = BuildShopList(NPCID.ArmsDealer, ShopArmsDealerCatalog.ShopNames);

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.ArmsDealer, shop))
        {
            return;
        }

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
        if (UnlockAllItems)
        {
            AddOfferItemsAll(ShopArmsDealerCatalog.BulletMainReplacements);
            return;
        }

        ReplaceFromOffers(ShopArmsDealerCatalog.BulletMainReplacements);
    }

    private void ShopBulletOther()
    {
        if (UnlockAllItems)
        {
            AddOfferItemsAll(ShopArmsDealerCatalog.BulletOtherReplacements);
            return;
        }

        ReplaceFromOffers(ShopArmsDealerCatalog.BulletOtherReplacements);

        ReplacePrice(Coins.Silver());
        ReplacePrice(Progression.SlimeKing, Coins.Copper(50));
        ReplacePrice(Progression.EyeOfCthulhu, Coins.Copper(25));
        ReplacePrice(Progression.BrainOrEater, Coins.Copper(5));
        ReplacePrice(Progression.QueenBee, Coins.Copper());
    }

    private void ShopPistol()
    {
        if (UnlockAllItems)
        {
            AddOfferItemsAll(ShopArmsDealerCatalog.PistolReplacements);
            return;
        }

        ReplaceFromOffers(ShopArmsDealerCatalog.PistolReplacements);
    }

    private void ShopRifle()
    {
        if (UnlockAllItems)
        {
            AddOfferItemsAll(ShopArmsDealerCatalog.RifleReplacements);
            return;
        }

        ReplaceFromOffers(ShopArmsDealerCatalog.RifleReplacements);
    }

    private void ShopShotgun()
    {
        if (UnlockAllItems)
        {
            AddOfferItemsAll(ShopArmsDealerCatalog.ShotgunReplacements);
            return;
        }

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

    private void AddOfferItemsAll(IReadOnlyList<ConditionalShopOffer> offers)
    {
        HashSet<int> added = new();

        foreach (ConditionalShopOffer offer in offers)
        {
            foreach (int itemId in offer.ItemIds)
            {
                if (!added.Add(itemId) || itemId <= ItemID.None)
                {
                    continue;
                }

                if (offer.Price.HasValue)
                {
                    AddItem(itemId, offer.Price.Value);
                }
                else
                {
                    AddItem(itemId);
                }
            }
        }
    }
}




