namespace MerchantsPlus.Shops;

public partial class ShopMerchant
{
    private void Wings()
    {
        if (UnlockAllItems)
        {
            int moonlordWing = GetClassItem(ShopMerchantCatalog.MoonlordWings);
            AddItem(moonlordWing > ItemID.None ? moonlordWing : ItemID.FishronWings, Coins.Platinum());
            return;
        }

        ReplaceFromOffers(ShopMerchantCatalog.WingReplacements);
        ReplaceItem(Progression.Moonlord, GetClassItem(ShopMerchantCatalog.MoonlordWings), Coins.Platinum());

        NextSlot++;
    }

    private void Pickaxe()
    {
        if (UnlockAllItems)
        {
            int moonlordPickaxe = GetClassItem(ShopMerchantCatalog.MoonlordPickaxes);
            AddItem(moonlordPickaxe > ItemID.None ? moonlordPickaxe : ItemID.Picksaw);
            return;
        }

        ReplaceItem(ShopMerchantCatalog.GetBasePickaxe());
        ReplaceItem(Progression.EyeOfCthulhu, ShopMerchantCatalog.GetEyePickaxe());
        ReplaceItem(Progression.BrainOrEater, ShopMerchantCatalog.GetEvilPickaxe());
        ReplaceFromOffers(ShopMerchantCatalog.PickaxeReplacements);
        ReplaceClassItem(Progression.Moonlord, ShopMerchantCatalog.MoonlordPickaxes);

        NextSlot++;
    }

    private void Axe()
    {
        if (UnlockAllItems)
        {
            int moonlordHamaxe = GetClassItem(ShopMerchantCatalog.MoonlordHamaxes);
            AddItem(moonlordHamaxe > ItemID.None ? moonlordHamaxe : ItemID.ChlorophyteGreataxe);
            return;
        }

        ReplaceItem(ShopMerchantCatalog.GetBaseAxe());
        ReplaceItem(Progression.EyeOfCthulhu, ShopMerchantCatalog.GetEyeAxe());
        ReplaceItem(Progression.BrainOrEater, ShopMerchantCatalog.GetEvilAxe());
        ReplaceFromOffers(ShopMerchantCatalog.AxeReplacements);
        ReplaceClassItem(Progression.Moonlord, ShopMerchantCatalog.MoonlordHamaxes);
        NextSlot++;
    }

    private void Hammer()
    {
        if (UnlockAllItems)
        {
            int moonlordHamaxe = GetClassItem(ShopMerchantCatalog.MoonlordHamaxes);
            AddItem(moonlordHamaxe > ItemID.None ? moonlordHamaxe : ItemID.ChlorophyteJackhammer);
            return;
        }

        ReplaceItem(ShopMerchantCatalog.GetBaseHammer());
        ReplaceItem(Progression.EyeOfCthulhu, ShopMerchantCatalog.GetEyeHammer());
        ReplaceItem(Progression.BrainOrEater, ShopMerchantCatalog.GetEvilHammer());
        ReplaceFromOffers(ShopMerchantCatalog.HammerReplacements);
        ReplaceClassItem(Progression.Moonlord, ShopMerchantCatalog.MoonlordHamaxes);

        NextSlot++;
    }

    private void Helmet()
    {
        if (UnlockAllItems)
        {
            int moonlordHelmet = GetClassItem(ShopMerchantCatalog.MoonlordHelmets);
            AddItem(moonlordHelmet > ItemID.None ? moonlordHelmet : ItemID.ChlorophyteHelmet);
            return;
        }

        ReplaceItem(ShopMerchantCatalog.GetBaseHelmet());
        ReplaceItem(Progression.SlimeKing, ShopMerchantCatalog.GetSlimeHelmet());
        ReplaceItem(Progression.EyeOfCthulhu, ShopMerchantCatalog.GetEyeHelmet());
        ReplaceItem(Progression.BrainOrEater, ShopMerchantCatalog.GetEvilHelmet());

        ReplaceClassItem(Progression.Skeletron, ShopMerchantCatalog.SkeletronHelmets);
        ReplaceClassItem(Progression.DownedMechs(1), ShopMerchantCatalog.MechTierOneHelmets);
        ReplaceClassItem(Progression.DownedMechs(2), ShopMerchantCatalog.MechTierTwoHelmets);
        ReplaceClassItem(Progression.DownedMechs(3), ShopMerchantCatalog.MechTierThreeHelmets);
        ReplaceClassItem(Progression.Moonlord, ShopMerchantCatalog.MoonlordHelmets);

        NextSlot++;
    }

    private void Breastplate()
    {
        if (UnlockAllItems)
        {
            int moonlordBreastplate = GetClassItem(ShopMerchantCatalog.MoonlordBreastplates);
            AddItem(moonlordBreastplate > ItemID.None ? moonlordBreastplate : ItemID.ChlorophytePlateMail);
            return;
        }

        ReplaceItem(ShopMerchantCatalog.GetBaseBreastplate());
        ReplaceItem(Progression.SlimeKing, ShopMerchantCatalog.GetSlimeBreastplate());
        ReplaceItem(Progression.EyeOfCthulhu, ShopMerchantCatalog.GetEyeBreastplate());
        ReplaceItem(Progression.BrainOrEater, ShopMerchantCatalog.GetEvilBreastplate());

        ReplaceClassItem(Progression.Skeletron, ShopMerchantCatalog.SkeletronBreastplates);
        ReplaceClassItem(Progression.DownedMechs(1), ShopMerchantCatalog.MechTierOneBreastplates);
        ReplaceClassItem(Progression.DownedMechs(2), ShopMerchantCatalog.MechTierTwoBreastplates);
        ReplaceClassItem(Progression.DownedMechs(3), ShopMerchantCatalog.MechTierThreeBreastplates);
        ReplaceClassItem(Progression.Moonlord, ShopMerchantCatalog.MoonlordBreastplates);

        NextSlot++;
    }

    private void ShopGreaves()
    {
        if (UnlockAllItems)
        {
            int moonlordGreaves = GetClassItem(ShopMerchantCatalog.MoonlordGreaves);
            AddItem(moonlordGreaves > ItemID.None ? moonlordGreaves : ItemID.ChlorophyteGreaves);
            return;
        }

        ReplaceItem(ShopMerchantCatalog.GetBaseGreaves());
        ReplaceItem(Progression.SlimeKing, ShopMerchantCatalog.GetSlimeGreaves());
        ReplaceItem(Progression.EyeOfCthulhu, ShopMerchantCatalog.GetEyeGreaves());
        ReplaceItem(Progression.BrainOrEater, ShopMerchantCatalog.GetEvilGreaves());

        ReplaceClassItem(Progression.Skeletron, ShopMerchantCatalog.SkeletronGreaves);
        ReplaceClassItem(Progression.DownedMechs(1), ShopMerchantCatalog.MechTierOneGreaves);
        ReplaceClassItem(Progression.DownedMechs(2), ShopMerchantCatalog.MechTierTwoGreaves);
        ReplaceClassItem(Progression.DownedMechs(3), ShopMerchantCatalog.MechTierThreeGreaves);
        ReplaceClassItem(Progression.Moonlord, ShopMerchantCatalog.MoonlordGreaves);

        NextSlot++;
    }

    private void FishingRod()
    {
        if (UnlockAllItems)
        {
            AddItem(ItemID.GoldenFishingRod, Coins.Platinum(2));
            return;
        }

        ReplaceItem(ShopMerchantCatalog.WoodFishingPoleItemId, Coins.Silver(10));
        ReplaceProgressionItems(Progression.LevelFull(), ShopMerchantCatalog.FishingRodProgression);

        NextSlot++;
    }

    private void ReplaceProgressionItems(int progression, IReadOnlyList<ProgressionShopItem> items)
    {
        foreach (ProgressionShopItem item in items)
        {
            ReplaceItem(item.IsUnlocked(progression), item.ItemId, item.Price);
        }
    }

    private void ReplaceClassItem(bool condition, ClassItemSet classItemSet)
    {
        int classItemId = GetClassItem(classItemSet);
        ReplaceItem(condition && classItemId > 0, classItemId);
    }

    private static int GetClassItem(ClassItemSet classItemSet)
    {
        return classItemSet.GetItemId(PlayerUtils.GetPlayerClass());
    }

    private void Boots()
    {
        if (UnlockAllItems)
        {
            AddItem(ItemID.TerrasparkBoots);
            return;
        }

        ReplaceFromOffers(ShopMerchantCatalog.BootReplacements, fallbackToFirstItem: true);

        NextSlot++;
    }

    private void HealPotion()
    {
        if (UnlockAllItems)
        {
            AddItem(ItemID.SuperHealingPotion);
            return;
        }

        ReplaceFromOffers(ShopMerchantCatalog.HealingPotionReplacements, fallbackToFirstItem: true);

        NextSlot++;
    }

    private void ManaPotion()
    {
        if (UnlockAllItems)
        {
            AddItem(ItemID.SuperManaPotion);
            return;
        }

        ReplaceFromOffers(ShopMerchantCatalog.ManaPotionReplacements, fallbackToFirstItem: true);

        NextSlot++;
    }

    private void Torches()
    {
        if (UnlockAllItems)
        {
            AddItem(ItemID.UltrabrightTorch, Coins.Silver());
            return;
        }

        ReplaceFromOffers(ShopMerchantCatalog.TorchReplacements, fallbackToFirstItem: true);
        ReplacePrice(Coins.Silver());

        NextSlot++;
    }

    private void Arrows()
    {
        if (UnlockAllItems)
        {
            AddItem(ItemID.MoonlordArrow);
            return;
        }

        ReplaceFromOffers(ShopMerchantCatalog.ArrowReplacements, fallbackToFirstItem: true);

        NextSlot++;
    }

    private void Rope()
    {
        if (UnlockAllItems)
        {
            AddItem(ItemID.Chain, Coins.Copper());
            return;
        }

        ReplaceFromOffers(ShopMerchantCatalog.RopeReplacements, fallbackToFirstItem: true);
        ReplacePrice(Coins.Copper());

        NextSlot++;
    }

    private void LightPet()
    {
        if (UnlockAllItems)
        {
            AddItem(ItemID.WispinaBottle, Coins.Gold(2));
            return;
        }

        ReplaceFromOffers(ShopMerchantCatalog.LightPetReplacements, fallbackToFirstItem: true);
        ReplacePrice(Coins.Gold(2));

        NextSlot++;
    }

    private void ThrowerWep()
    {
        if (UnlockAllItems)
        {
            AddItem(ItemID.BoneJavelin);
            return;
        }

        ReplaceFromOffers(ShopMerchantCatalog.ThrowerReplacements, fallbackToFirstItem: true);

        NextSlot++;
    }

    private void Hooks()
    {
        if (UnlockAllItems)
        {
            AddItem(ItemID.LunarHook);
            return;
        }

        ReplaceFromOffers(ShopMerchantCatalog.HookReplacements, fallbackToFirstItem: true);

        NextSlot++;
    }

    private bool ReplaceFromOffers(IReadOnlyList<ConditionalShopOffer> offers, bool fallbackToFirstItem = false)
    {
        int fallbackItemId = ItemID.None;
        int? fallbackPrice = null;
        bool replaced = false;

        foreach (ConditionalShopOffer offer in offers)
        {
            if (fallbackItemId <= ItemID.None && offer.ItemIds.Length > 0 && offer.ItemIds[0] > ItemID.None)
            {
                fallbackItemId = offer.ItemIds[0];
            }

            if (!fallbackPrice.HasValue && offer.Price.HasValue)
            {
                fallbackPrice = offer.Price.Value;
            }

            if (!offer.IsUnlocked())
            {
                continue;
            }

            if (offer.ItemIds.Length > 0 && offer.ItemIds[0] > ItemID.None)
            {
                ReplaceItem(offer.ItemIds[0]);
                replaced = true;
            }

            if (offer.Price.HasValue)
            {
                ReplacePrice(offer.Price.Value);
            }
        }

        if (!replaced && fallbackToFirstItem && fallbackItemId > ItemID.None)
        {
            ReplaceItem(fallbackItemId);
            if (fallbackPrice.HasValue)
            {
                ReplacePrice(fallbackPrice.Value);
            }

            replaced = true;
        }

        return replaced;
    }
}
