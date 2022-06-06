using System.Collections.Generic;

using Terraria;
using Terraria.Audio;
using Terraria.ID;

namespace MerchantsPlus.Merchants
{
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

            List<string> otherShops = new List<string>();
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
            PrepareShop();
        }

        private void PrepareShop()
        {
            SoundEngine.PlaySound(SoundID.MenuTick);
            Main.playerInventory = true;
            Main.npcChatText = "";
            //Main.npcShop = 20;

            Inv = Main.instance.shop[Main.npcShop];
            Inv.SetupShop(0);

            NextSlot = 0;

            Quests.Clear();
        }

        protected void AddItem(int itemID)
        {
            Inv.item[NextSlot++].SetDefaults(itemID);
        }

        protected void AddItem(int itemID, int price)
        {
            Inv.item[NextSlot].SetDefaults(itemID);
            Inv.item[NextSlot++].shopCustomPrice = price;
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
    }
}