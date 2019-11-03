using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.Shops
{
    class ShopClothier
    {
        private Chest shop;
        private int nextSlot;

        public ShopClothier(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            switch (currentShop) {
                case "Clothing":
                    shop.item[nextSlot++].SetDefaults(ItemID.BlackThread);
                    shop.item[nextSlot++].SetDefaults(ItemID.PinkThread);
                    shop.item[nextSlot++].SetDefaults(ItemID.FamiliarWig);
                    shop.item[nextSlot++].SetDefaults(ItemID.FamiliarShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.FamiliarPants);

                    if (NPC.downedSlimeKing)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.EyePatch);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 5);
                        shop.item[nextSlot].SetDefaults(ItemID.PlatinumCrown);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 10);
                    }

                    if (NPC.downedBoss1)
                    { // eye
                        shop.item[nextSlot].SetDefaults(ItemID.Sunglasses);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 10);
                    }

                    if (NPC.downedBoss2)
                    { //worm / brain
                        shop.item[nextSlot].SetDefaults(ItemID.GuyFawkesMask);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 10);
                    }

                    if (NPC.downedBoss3)
                    { // skeletron
                        shop.item[nextSlot].SetDefaults(ItemID.ReindeerAntlers);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 10);
                    }

                    if (Main.hardMode)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ReaperRobe);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 10);
                        shop.item[nextSlot].SetDefaults(ItemID.ReaperHood);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 10);
                    }

                    if (NPC.downedMechBossAny)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.SpaceCreaturePants);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 10);
                        shop.item[nextSlot].SetDefaults(ItemID.SpaceCreatureShirt);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 10);
                        shop.item[nextSlot].SetDefaults(ItemID.SpaceCreatureMask);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 10);
                    }

                    if (NPC.downedPlantBoss)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.BunnyHood);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 10);
                    }

                    if (Main.raining)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.CrownosLeggings);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 25);
                        shop.item[nextSlot].SetDefaults(ItemID.CrownosBreastplate);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 25);
                        shop.item[nextSlot].SetDefaults(ItemID.CrownosMask);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 25);
                    }

                    if (Main.bloodMoon)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.CenxsDressPants);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 25);

                        shop.item[nextSlot].SetDefaults(ItemID.CenxsLeggings);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 25);

                        shop.item[nextSlot].SetDefaults(ItemID.CenxsDress);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 25);

                        shop.item[nextSlot].SetDefaults(ItemID.CenxsBreastplate);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 25);

                        shop.item[nextSlot].SetDefaults(ItemID.CenxsTiara);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 25);
                    }

                    if (Main.eclipse)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.JimsLeggings);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 25);

                        shop.item[nextSlot].SetDefaults(ItemID.JimsBreastplate);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 25);

                        shop.item[nextSlot].SetDefaults(ItemID.JimsHelmet);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 25);
                    }

                    if (Main.dayTime)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ArkhalisPants);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 25);

                        shop.item[nextSlot].SetDefaults(ItemID.ArkhalisShirt);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 25);

                        shop.item[nextSlot].SetDefaults(ItemID.ArkhalisHat);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 25);
                    }
                    else
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.LokisPants);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 25);

                        shop.item[nextSlot].SetDefaults(ItemID.LokisShirt);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 25);

                        shop.item[nextSlot].SetDefaults(ItemID.LokisHelm);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 25);
                    }

                    if (Main.hardMode)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.LeinforsPants);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 25);

                        shop.item[nextSlot].SetDefaults(ItemID.LeinforsShirt);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 25);

                        shop.item[nextSlot].SetDefaults(ItemID.LeinforsHat);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 25);

                        shop.item[nextSlot].SetDefaults(ItemID.LeinforsAccessory);
                        shop.item[nextSlot++].shopCustomPrice = Utils.coins(0, 0, 25);
                    }
                    break;
                default:
                    shop.SetupShop(5);
                break;
            }
        }
    }
}
