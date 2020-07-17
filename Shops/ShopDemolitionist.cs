using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    internal class ShopDemolitionist
    {
        private Chest shop;
        private int nextSlot;

        public ShopDemolitionist(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            switch (currentShop)
            {
                case "Msc":
                    shop.item[nextSlot].SetDefaults(ItemID.MiningPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.NightOwlPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.ShinePotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.SpelunkerPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    shop.item[nextSlot].SetDefaults(ItemID.StinkPotion);
                    shop.item[nextSlot++].shopCustomPrice = MerchantsPlus.universalPotionCost;
                    break;

                case "Explosives":
                    shop.item[nextSlot++].SetDefaults(ItemID.Grenade);
                    if (NPC.AnyNPCs(NPCID.PartyGirl))
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.PartyGirlGrenade);
                    }

                    if (NPC.downedSlimeKing)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.Bomb);
                    }

                    if (NPC.downedBoss1)
                    { // eye of chulutu
                        shop.item[nextSlot++].SetDefaults(ItemID.Dynamite);
                    }

                    if (NPC.AnyNPCs(NPCID.Angler))
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.BombFish);
                    }

                    if (NPC.downedQueenBee)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.Beenade);
                    }

                    if (NPC.downedBoss3)
                    { // skeletron
                        shop.item[nextSlot++].SetDefaults(ItemID.ExplosiveBunny);
                    }

                    if (Main.hardMode)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.Explosives);
                        shop.item[nextSlot++].SetDefaults(ItemID.StickyGrenade);
                        shop.item[nextSlot++].SetDefaults(ItemID.StickyBomb);
                        shop.item[nextSlot++].SetDefaults(ItemID.StickyDynamite);
                        shop.item[nextSlot++].SetDefaults(ItemID.BouncyGrenade);
                        shop.item[nextSlot++].SetDefaults(ItemID.BouncyBomb);
                        shop.item[nextSlot++].SetDefaults(ItemID.BouncyDynamite);
                    }

                    if (NPC.downedClown)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.ExplosiveJackOLantern);
                    }

                    if (NPC.downedMoonlord)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.LandMine);
                    }
                    break;

                default:
                    shop.SetupShop(4);
                    break;
            }
        }
    }
}