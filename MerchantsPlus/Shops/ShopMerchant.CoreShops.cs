namespace MerchantsPlus.Shops;

public partial class ShopMerchant
{
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
}
