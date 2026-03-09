namespace MerchantsPlus.Shops;

public partial class ShopMerchant
{
    private void AddClassWeapons()
    {
        switch (PlayerUtils.GetPlayerClass())
        {
            case PlayerClass.Melee:
                if (!NPC.downedBoss2)
                {
                    Shortswords();
                }

                Broadswords();
                return;
            case PlayerClass.Ranger:
                Bows();
                return;
            case PlayerClass.Mage:
                MageWeapon();
                return;
            case PlayerClass.Summoner:
                SummonerWeapon();
                return;
            case PlayerClass.Thrower:
                ThrowerWep();
                return;
        }
    }

    private void Shortswords()
    {
        if (UnlockAllItems)
        {
            AddItem(ShopMerchantCatalog.GetEyeShortsword());
            return;
        }

        ReplaceItem(ShopMerchantCatalog.GetBaseShortsword());
        ReplaceItem(Progression.EyeOfCthulhu, ShopMerchantCatalog.GetEyeShortsword());

        NextSlot++;
    }

    private void Broadswords()
    {
        if (UnlockAllItems)
        {
            AddItem(ItemID.TerraBlade);
            return;
        }

        ReplaceItem(ShopMerchantCatalog.GetBaseBroadsword());
        ReplaceItem(Progression.EyeOfCthulhu, ShopMerchantCatalog.GetEyeBroadsword());
        ReplaceItem(Progression.BrainOrEater, ShopMerchantCatalog.GetEvilBroadsword());
        ReplaceFromOffers(ShopMerchantCatalog.BroadswordReplacements);

        NextSlot++;
    }

    private void Bows()
    {
        if (UnlockAllItems)
        {
            AddItem(ItemID.Phantasm);
            return;
        }

        ReplaceItem(ShopMerchantCatalog.GetBaseBow());
        ReplaceItem(Progression.EyeOfCthulhu, ShopMerchantCatalog.GetEyeBow());
        ReplaceItem(Progression.BrainOrEater, ShopMerchantCatalog.GetEvilBow());
        ReplaceFromOffers(ShopMerchantCatalog.BowReplacements);

        NextSlot++;
    }

    private void MageWeapon()
    {
        if (UnlockAllItems)
        {
            AddItem(ItemID.SpectreStaff);
            return;
        }

        ReplaceFromOffers(ShopMerchantCatalog.MageWeaponReplacements, fallbackToFirstItem: true);

        NextSlot++;
    }

    private void SummonerWeapon()
    {
        if (UnlockAllItems)
        {
            AddItem(ItemID.StardustDragonStaff, Coins.Gold(2));
            return;
        }

        ReplaceFromOffers(ShopMerchantCatalog.SummonerWeaponReplacements, fallbackToFirstItem: true);
        ReplacePrice(Coins.Gold(2));

        NextSlot++;
    }
}
