namespace MerchantsPlus.Shops;

public class ShopMerchant : Shop
{
    private static bool UnlockAllItems => Config.Instance?.UnlockAllItems == true;

    private enum ShopNames
    {
        Gear,
        Potions,
        Ores,
        Pets,
        Mounts
    }

    public override List<string> Shops { get; } = BuildShopList(
        NPCID.Merchant,
        [
            nameof(ShopNames.Gear),
            nameof(ShopNames.Potions),
            nameof(ShopNames.Ores),
            nameof(ShopNames.Pets),
            nameof(ShopNames.Mounts),
        ]);

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (OpenExpandedShop(NPCID.Merchant, shop))
        {
            return;
        }

        Action openShop = shop switch
        {
            nameof(ShopNames.Mounts) => Mounts,
            nameof(ShopNames.Pets) => Pets,
            nameof(ShopNames.Ores) => Ores,
            nameof(ShopNames.Gear) => Gear,
            nameof(ShopNames.Potions) => Potions,
            _ => () => Inv.SetupShop(ShopType.Merchant)
        };
        openShop();
    }

    private void Potions()
    {
        bool unlockAllItems = Config.Instance?.UnlockAllItems == true;
        int progression = Progression.LevelFull();
        AddItemsAtPrice(Coins.Silver(), ShopMerchantCatalog.SilverPotions);
        AddItemsAtPrice(ItemCosts.Potions, ShopMerchantCatalog.BasicPotions);
        AddItem(ShopMerchantCatalog.GenderChangePotionItemId, Coins.Copper());
        AddItem(Progression.EyeOfCthulhu, ShopMerchantCatalog.ObsidianSkinPotionItemId, ItemCosts.Potions);

        if (unlockAllItems)
        {
            AddItem(ShopMerchantCatalog.LuckPotionLesserItemId, ItemCosts.Potions);
            AddItem(ShopMerchantCatalog.LuckPotionItemId, ItemCosts.Potions);
            AddItem(ShopMerchantCatalog.LuckPotionGreaterItemId, ItemCosts.Potions);
        }
        else if (Progression.Hardmode)
        {
            AddItem(Progression.Cultist ? ShopMerchantCatalog.LuckPotionGreaterItemId : ShopMerchantCatalog.LuckPotionItemId, ItemCosts.Potions);
        }
        else
        {
            AddItem(ShopMerchantCatalog.LuckPotionLesserItemId, ItemCosts.Potions);
        }

        if (WorldUtils.HasNpc(NPCID.Angler))
        {
            AddItemsAtPrice(ItemCosts.Potions, ShopMerchantCatalog.FishingPotions);
        }

        AddItem(WorldUtils.HasNpc(NPCID.Painter), ShopMerchantCatalog.BuilderPotionItemId, ItemCosts.Potions);
        AddItem(WorldUtils.HasNpc(NPCID.ArmsDealer), ShopMerchantCatalog.AmmoReservationPotionItemId, ItemCosts.Potions);
        AddProgressionItems(progression, ShopMerchantCatalog.ProgressionPotions);

        // Room for 3 more potions...
    }

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

    private void Mounts()
    {
        AddItemsAtPrice(ItemCosts.Mounts, ShopMerchantCatalog.BaseMounts);
        AddConditionalOffers(ShopMerchantCatalog.MountUnlocks);
    }

    private void Pets()
    {
        AddItemsAtPrice(ItemCosts.Pets, ShopMerchantCatalog.PetLicenses);
        AddConditionalOffers(ShopMerchantCatalog.PetUnlocks);
    }

    private void Ores()
    {
        if (UnlockAllItems)
        {
            AddItemsAtPrice(50, ShopMerchantCatalog.BaseOreBars);
            AddItemsAtPrice(100, ShopMerchantCatalog.TierOneOreBars);
            AddItemsAtPrice(150, ShopMerchantCatalog.TierTwoOreBars);
            AddItemsAtPrice(200, ShopMerchantCatalog.TierThreeOreBars);
            AddItemsAtPrice(250, ShopMerchantCatalog.EvilOreBars);
            AddItem(ShopMerchantCatalog.MeteoriteOreItemId, 300);
            AddItem(ShopMerchantCatalog.HellstoneOreItemId, 350);
            AddItemsAtPrice(400, ShopMerchantCatalog.HardmodeBarsTier1);
            AddItemsAtPrice(450, ShopMerchantCatalog.HardmodeBarsTier2);
            AddItemsAtPrice(500, ShopMerchantCatalog.HardmodeBarsTier3);
            AddItem(ShopMerchantCatalog.HallowedOreItemId, 550);
            AddItem(ShopMerchantCatalog.ChlorophyteOreItemId, 600);
            AddItem(ShopMerchantCatalog.LunarOreItemId, 650);
            return;
        }

        AddItem(ShopMerchantCatalog.GetBaseOre(), 50);

        if (Progression.SlimeKing)
        {
            AddItem(ShopMerchantCatalog.GetTierOneOre(), 100);
            AddItem(ShopMerchantCatalog.GetTierTwoOre(), 150);
            AddItem(ShopMerchantCatalog.GetTierThreeOre(), 200);
        }

        if (Progression.EyeOfCthulhu)
        {
            AddItem(ShopMerchantCatalog.GetEvilOre(), 250);
        }

        if (Progression.BrainOrEater)
        {
            AddItem(ShopMerchantCatalog.MeteoriteOreItemId, 300);
            AddItem(Progression.Hardmode, ShopMerchantCatalog.HellstoneOreItemId, 350);
        }

        if (Progression.DownedMechs(1))
        {
            AddItemsAtPrice(400, ShopMerchantCatalog.HardmodeBarsTier1);
        }

        if (Progression.DownedMechs(2))
        {
            AddItemsAtPrice(450, ShopMerchantCatalog.HardmodeBarsTier2);
        }

        if (Progression.DownedMechs(3))
        {
            AddItemsAtPrice(500, ShopMerchantCatalog.HardmodeBarsTier3);
            AddItem(ShopMerchantCatalog.HallowedOreItemId, 550);
        }

        AddItem(Progression.Plantera, ShopMerchantCatalog.ChlorophyteOreItemId, 600);
        AddItem(Progression.Moonlord, ShopMerchantCatalog.LunarOreItemId, 650);
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

    private void Gear()
    {
        AddItems(ShopMerchantCatalog.GearBasics);

        if (!Main.hardMode && !UnlockAllItems)
        {
            AddItem(ShopMerchantCatalog.PreHardmodeBugNetItemId);
        }
        else
        {
            AddItem(ShopMerchantCatalog.HardmodeBugNetItemId);
        }

        FishingRod();
        Pickaxe();
        Axe();
        Hammer();
        Helmet();
        Breastplate();
        ShopGreaves();
        AddClassWeapons();

        HealPotion();
        ManaPotion();
        Torches();
        Arrows();
        Rope();
        LightPet();
        Hooks();
        Boots();

        AddItem(ShopMerchantCatalog.PiggyBankItemId);
        AddItem(ShopMerchantCatalog.SafeItemId, Coins.Gold());
        AddItem(ShopMerchantCatalog.WoodItemId, Coins.Silver());

        BuffPotion();

        AddItem(ShopMerchantCatalog.EmptyBucketItemId, Coins.Gold());

        Wings();
    }

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

    private void BuffPotion()
    {
        if (UnlockAllItems)
        {
            AddItemsAtPrice(ItemCosts.Potions, ShopMerchantCatalog.MagePotions);
            AddItem(ShopMerchantCatalog.ArcheryPotionItemId, ItemCosts.Potions);
            return;
        }

        PlayerClass playerClass = PlayerUtils.GetPlayerClass();

        if (playerClass == PlayerClass.Mage)
        {
            AddItemsAtPrice(ItemCosts.Potions, ShopMerchantCatalog.MagePotions);
            return;
        }

        if (playerClass is PlayerClass.Melee or PlayerClass.Ranger)
        {
            AddItem(ShopMerchantCatalog.ArcheryPotionItemId, ItemCosts.Potions);
        }
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



