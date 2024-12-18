﻿using Terraria.Audio;

namespace MerchantsPlus.Shops;

public abstract class Shop
{
    public int CycleIndex { get; set; }
    public abstract string[] Shops { get; }
    public List<string> Quests { get; } = [];

    protected Chest Inv;
    protected int NextSlot = 0;

    /// <summary>
    /// Opens the merchants shop.
    /// </summary>
    /// <param name="shop">The current shop we are in.</param>
    /// <param name="nextSlot">The nextSlot of the item to sell.</param>
    public virtual void OpenShop(string shop)
    {
        _ = SoundEngine.PlaySound(SoundID.MenuTick);
        Main.playerInventory = true;
        Main.npcChatText = "";

        // Not sure what this line of code does
        // Note that any number greater than 1 will cause index out of bounds error
        // freezing the game
        // If this line of code is commented out then an error will appear saying
        // "Object reference not set to an instance of an object"
        Main.SetNPCShopIndex(1);

        NPC npc = Main.LocalPlayer.TalkNPC;

        // For future reference this code was updated from
        // https://github.com/tModLoader/tModLoader/blob/e6caaaf678efd2a69deece4d72fdaecc4391bd26/patches/tModLoader/Terraria/ModLoader/NPCLoader.cs#L1192
        Inv = Main.instance.shop[Main.npcShop];

        // Setting this to '2' will setup the shop items for the arms dealer
        // The arms dealer sells 3 guns
        Inv.SetupShop(NPCShopDatabase.GetShopNameFromVanillaIndex(2), npc);

        // Lets remove these guns as we will add our own items later
        for (int i = 0; i < Inv.item.Length; i++)
        {
            Inv.item[i].SetDefaults(0);
        }

        NextSlot = 0;

        Quests.Clear();
    }

    protected void AddItem(int itemID, bool condition = true)
    {
        if (condition)
        {
            Inv.item[NextSlot++].SetDefaults(itemID);
        }
    }

    protected void AddItem(int itemID, int price, int progression = 0)
    {
        if (Utils.Progression() >= progression)
        {
            Inv.item[NextSlot].SetDefaults(itemID);
            Inv.item[NextSlot++].shopCustomPrice = price;
        }
    }

    protected void ReplaceItem(int itemID)
    {
        Inv.item[NextSlot].SetDefaults(itemID);
    }

    protected void ReplaceItem(int itemID, int price)
    {
        Inv.item[NextSlot].SetDefaults(itemID);
        Inv.item[NextSlot].shopCustomPrice = price;
    }

    protected void ReplacePrice(int price)
    {
        Inv.item[NextSlot].shopCustomPrice = price;
    }

    public override string ToString()
    {
        return GetType().Name.Replace("Shop", "").AddSpaceBeforeEachCapital();
    }
}