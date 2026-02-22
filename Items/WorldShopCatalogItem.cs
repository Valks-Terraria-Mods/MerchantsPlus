namespace MerchantsPlus.Items;

public class WorldShopCatalogItem : ModItem
{
    public override string Texture => "Terraria/Images/Item_3620";

    public override void SetStaticDefaults()
    {
        Item.ResearchUnlockCount = 1;
    }

    public override void SetDefaults()
    {
        Item.width = 24;
        Item.height = 24;
        Item.maxStack = 1;
        Item.value = Item.buyPrice(silver: 1);
        Item.rare = ItemRarityID.White;
        Item.useTime = 20;
        Item.useAnimation = 20;
        Item.useStyle = ItemUseStyleID.HoldUp;
        Item.UseSound = SoundID.MenuOpen;
        Item.consumable = false;
        Item.noMelee = true;
    }

    public override bool? UseItem(Player player)
    {
        if (player?.mouseInterface == true || Main.blockInput)
        {
            return false;
        }

        AddCustomShopUI ui = ModContent.GetInstance<AddCustomShopUI>();
        if (ui?.IsPointerOverAnyCustomUI() == true)
        {
            return false;
        }

        if (!Main.dedServ && player.whoAmI == Main.myPlayer)
        {
            ui.ShowWorldShopsUI();
        }

        return true;
    }

    public override void AddRecipes()
    {
        CreateRecipe()
            .AddIngredient(ItemID.Wood, 5)
            .Register();
    }
}
