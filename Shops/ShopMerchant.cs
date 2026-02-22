using Terraria.WorldBuilding;

namespace MerchantsPlus.Shops;

public class ShopMerchant : Shop
{
    private enum ShopNames
    {
        Gear,
        Potions,
        Ores,
        Pets,
        Mounts
    }

    public override List<string> Shops { get; } = [
        nameof(ShopNames.Gear),
        nameof(ShopNames.Potions),
        nameof(ShopNames.Ores),
        nameof(ShopNames.Pets),
        nameof(ShopNames.Mounts)
    ];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

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
        int progression = Progression.LevelFull();
        AddItemsAtPrice(Coins.Silver(), ShopMerchantCatalog.SilverPotions);
        AddItemsAtPrice(ItemCosts.Potions, ShopMerchantCatalog.BasicPotions);
        AddItem(ShopMerchantCatalog.GenderChangePotionItemId, Coins.Copper());
        AddItem(Progression.EyeOfCthulhu, ShopMerchantCatalog.ObsidianSkinPotionItemId, ItemCosts.Potions);

        if (Progression.Hardmode)
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
        ReplaceFromOffers(ShopMerchantCatalog.WingReplacements);
        ReplaceItem(Progression.Moonlord, GetClassItem(ShopMerchantCatalog.MoonlordWings), Coins.Platinum());

        NextSlot++;
    }

    private void Pickaxe()
    {
        ReplaceItem(ShopMerchantCatalog.GetBasePickaxe());
        ReplaceItem(Progression.EyeOfCthulhu, ShopMerchantCatalog.GetEyePickaxe());
        ReplaceItem(Progression.BrainOrEater, ShopMerchantCatalog.GetEvilPickaxe());
        ReplaceFromOffers(ShopMerchantCatalog.PickaxeReplacements);
        ReplaceClassItem(Progression.Moonlord, ShopMerchantCatalog.MoonlordPickaxes);

        NextSlot++;
    }

    private void Axe()
    {
        ReplaceItem(ShopMerchantCatalog.GetBaseAxe());
        ReplaceItem(Progression.EyeOfCthulhu, ShopMerchantCatalog.GetEyeAxe());
        ReplaceItem(Progression.BrainOrEater, ShopMerchantCatalog.GetEvilAxe());
        ReplaceFromOffers(ShopMerchantCatalog.AxeReplacements);
        ReplaceClassItem(Progression.Moonlord, ShopMerchantCatalog.MoonlordHamaxes);
        NextSlot++;
    }

    private void Hammer()
    {
        ReplaceItem(ShopMerchantCatalog.GetBaseHammer());
        ReplaceItem(Progression.EyeOfCthulhu, ShopMerchantCatalog.GetEyeHammer());
        ReplaceItem(Progression.BrainOrEater, ShopMerchantCatalog.GetEvilHammer());
        ReplaceFromOffers(ShopMerchantCatalog.HammerReplacements);
        ReplaceClassItem(Progression.Moonlord, ShopMerchantCatalog.MoonlordHamaxes);

        NextSlot++;
    }

    private void Helmet()
    {
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
        ReplaceItem(ShopMerchantCatalog.GetBaseShortsword());
        ReplaceItem(Progression.EyeOfCthulhu, ShopMerchantCatalog.GetEyeShortsword());

        NextSlot++;
    }

    private void Broadswords()
    {
        ReplaceItem(ShopMerchantCatalog.GetBaseBroadsword());
        ReplaceItem(Progression.EyeOfCthulhu, ShopMerchantCatalog.GetEyeBroadsword());
        ReplaceItem(Progression.BrainOrEater, ShopMerchantCatalog.GetEvilBroadsword());
        ReplaceFromOffers(ShopMerchantCatalog.BroadswordReplacements);

        NextSlot++;
    }

    private void Bows()
    {
        ReplaceItem(ShopMerchantCatalog.GetBaseBow());
        ReplaceItem(Progression.EyeOfCthulhu, ShopMerchantCatalog.GetEyeBow());
        ReplaceItem(Progression.BrainOrEater, ShopMerchantCatalog.GetEvilBow());
        ReplaceFromOffers(ShopMerchantCatalog.BowReplacements);

        NextSlot++;
    }

    private void MageWeapon()
    {
        ReplaceFromOffers(ShopMerchantCatalog.MageWeaponReplacements);

        NextSlot++;
    }

    private void SummonerWeapon()
    {
        ReplaceFromOffers(ShopMerchantCatalog.SummonerWeaponReplacements);
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
        ReplaceItem(ShopMerchantCatalog.WoodFishingPoleItemId, Coins.Silver(10));
        ReplaceProgressionItems(Progression.LevelFull(), ShopMerchantCatalog.FishingRodProgression);

        NextSlot++;
    }

    private void Gear()
    {
        AddItems(ShopMerchantCatalog.GearBasics);

        if (!Main.hardMode)
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
        ReplaceFromOffers(ShopMerchantCatalog.BootReplacements);

        NextSlot++;
    }


    private void HealPotion()
    {
        ReplaceFromOffers(ShopMerchantCatalog.HealingPotionReplacements);

        NextSlot++;
    }

    private void ManaPotion()
    {
        ReplaceFromOffers(ShopMerchantCatalog.ManaPotionReplacements);

        NextSlot++;
    }

    private void Torches()
    {
        ReplaceFromOffers(ShopMerchantCatalog.TorchReplacements);
        ReplacePrice(Coins.Silver());

        NextSlot++;
    }

    private void Arrows()
    {
        ReplaceFromOffers(ShopMerchantCatalog.ArrowReplacements);

        NextSlot++;
    }

    private void Rope()
    {
        ReplaceFromOffers(ShopMerchantCatalog.RopeReplacements);
        ReplacePrice(Coins.Copper());

        NextSlot++;
    }

    private void LightPet()
    {
        ReplaceFromOffers(ShopMerchantCatalog.LightPetReplacements);
        ReplacePrice(Coins.Gold(2));

        NextSlot++;
    }

    private void ThrowerWep()
    {
        ReplaceFromOffers(ShopMerchantCatalog.ThrowerReplacements);

        NextSlot++;
    }

    private void Hooks()
    {
        ReplaceFromOffers(ShopMerchantCatalog.HookReplacements);

        NextSlot++;
    }

    private void BuffPotion()
    {
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
    }
}



