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
                    /*if (MerchantsPlus.overhaulLoaded)
                    {
                        Mod overhaul = ModLoader.GetMod("TerrariaOverhaul");
                        shop.item[nextSlot++].SetDefaults(overhaul.ItemType("HaxxCostume"));
                    }*/
                    if (NPC.downedSlimeKing)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.EyePatch);
                        shop.item[nextSlot++].SetDefaults(ItemID.PlatinumCrown);
                    }

                    if (NPC.downedBoss1)
                    { // eye
                        shop.item[nextSlot++].SetDefaults(ItemID.Sunglasses);
                    }

                    if (NPC.downedBoss2)
                    { //worm / brain
                        shop.item[nextSlot++].SetDefaults(ItemID.GuyFawkesMask);
                    }

                    if (NPC.downedBoss3)
                    { // skeletron
                        shop.item[nextSlot++].SetDefaults(ItemID.ReindeerAntlers);
                    }

                    if (Main.hardMode)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.ReaperRobe);
                        shop.item[nextSlot++].SetDefaults(ItemID.ReaperHood);
                    }

                    if (NPC.downedMechBossAny)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.SpaceCreaturePants);
                        shop.item[nextSlot++].SetDefaults(ItemID.SpaceCreatureShirt);
                        shop.item[nextSlot++].SetDefaults(ItemID.SpaceCreatureMask);
                    }

                    if (NPC.downedPlantBoss)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.BunnyHood);
                    }

                    if (Main.raining)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.CrownosLeggings);
                        shop.item[nextSlot++].SetDefaults(ItemID.CrownosBreastplate);
                        shop.item[nextSlot++].SetDefaults(ItemID.CrownosMask);
                    }

                    if (Main.bloodMoon)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.CenxsDressPants);
                        shop.item[nextSlot++].shopCustomPrice = 100000;

                        shop.item[nextSlot].SetDefaults(ItemID.CenxsLeggings);
                        shop.item[nextSlot++].shopCustomPrice = 100000;

                        shop.item[nextSlot].SetDefaults(ItemID.CenxsDress);
                        shop.item[nextSlot++].shopCustomPrice = 100000;

                        shop.item[nextSlot].SetDefaults(ItemID.CenxsBreastplate);
                        shop.item[nextSlot++].shopCustomPrice = 100000;

                        shop.item[nextSlot].SetDefaults(ItemID.CenxsTiara);
                        shop.item[nextSlot++].shopCustomPrice = 100000;
                    }

                    if (Main.eclipse)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.JimsLeggings);
                        shop.item[nextSlot++].shopCustomPrice = 100000;

                        shop.item[nextSlot].SetDefaults(ItemID.JimsBreastplate);
                        shop.item[nextSlot++].shopCustomPrice = 100000;

                        shop.item[nextSlot].SetDefaults(ItemID.JimsHelmet);
                        shop.item[nextSlot++].shopCustomPrice = 100000;
                    }

                    if (Main.dayTime)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.ArkhalisPants);
                        shop.item[nextSlot++].shopCustomPrice = 100000;

                        shop.item[nextSlot].SetDefaults(ItemID.ArkhalisShirt);
                        shop.item[nextSlot++].shopCustomPrice = 100000;

                        shop.item[nextSlot].SetDefaults(ItemID.ArkhalisHat);
                        shop.item[nextSlot++].shopCustomPrice = 100000;
                    }
                    else
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.LokisPants);
                        shop.item[nextSlot++].shopCustomPrice = 100000;

                        shop.item[nextSlot].SetDefaults(ItemID.LokisShirt);
                        shop.item[nextSlot++].shopCustomPrice = 100000;

                        shop.item[nextSlot].SetDefaults(ItemID.LokisHelm);
                        shop.item[nextSlot++].shopCustomPrice = 100000;
                    }

                    if (Main.hardMode)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.LeinforsPants);
                        shop.item[nextSlot++].shopCustomPrice = 100000;

                        shop.item[nextSlot].SetDefaults(ItemID.LeinforsShirt);
                        shop.item[nextSlot++].shopCustomPrice = 100000;

                        shop.item[nextSlot].SetDefaults(ItemID.LeinforsHat);
                        shop.item[nextSlot++].shopCustomPrice = 100000;

                        shop.item[nextSlot].SetDefaults(ItemID.LeinforsAccessory);
                        shop.item[nextSlot++].shopCustomPrice = 100000;
                    }
                    break;
                default:
                    shop.SetupShop(5);
                break;
            }
        }
    }
}
