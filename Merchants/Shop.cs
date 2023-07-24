using Terraria.Audio;
using Terraria.ID;

namespace MerchantsPlus.Merchants;

internal abstract class Shop
{
    public List<string> Shops;
    public List<string> Quests;

    protected Chest Inv;
    protected int NextSlot = 0;

    /// <summary>
    /// Sets up a new shop for a particular merchant.
    /// </summary>
    /// <param name="merchant">Is the NPC a merchant by default?</param>
    public Shop(bool merchant, params string[] shops)
    {
        Shops = new List<string>();
        if (merchant) Shops.Add("Vanilla");

        var otherShops = new List<string>();
        for (int i = 0; i < shops.Length; i++)
            otherShops.Add(shops[i]);

        Shops.AddRange(otherShops);

        Quests = new List<string>();
    }

    /// <summary>
    /// Initalizes the merchants particular shop.
    /// </summary>
    /// <param name="shop">The current shop we are in.</param>
    /// <param name="nextSlot">The nextSlot of the item to sell.</param>
    public virtual void OpenShop(string shop)
    {
        SoundEngine.PlaySound(SoundID.MenuTick);
        Main.playerInventory = true;
        Main.npcChatText = "";
        Main.SetNPCShopIndex(1);

        var npc = Main.LocalPlayer.TalkNPC;

        // For future reference this code was updated from
        // https://github.com/tModLoader/tModLoader/blob/e6caaaf678efd2a69deece4d72fdaecc4391bd26/patches/tModLoader/Terraria/ModLoader/NPCLoader.cs#L1192
        Inv = Main.instance.shop[Main.npcShop];
        Inv.SetupShop(NPCShopDatabase.GetShopName(npc.type, "Shop"), npc);

        NextSlot = 0;

        Quests.Clear();
    }

    protected void AddItem(int itemID) => 
        Inv.item[NextSlot++].SetDefaults(itemID);

    protected void AddItem(int itemID, int price)
    {
        Inv.item[NextSlot].SetDefaults(itemID);
        Inv.item[NextSlot++].shopCustomPrice = price;
    }

    protected void ReplaceItem(int itemID) => 
        Inv.item[NextSlot].SetDefaults(itemID);

    protected void ReplaceItem(int itemID, int price)
    {
        Inv.item[NextSlot].SetDefaults(itemID);
        Inv.item[NextSlot].shopCustomPrice = price;
    }

    protected void ReplacePrice(int price) => 
        Inv.item[NextSlot].shopCustomPrice = price;

    public override string ToString() => 
        GetType().Name.Replace("Shop", "").AddSpaceBeforeEachCapital();
}