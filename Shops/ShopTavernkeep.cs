using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    internal class ShopTavernkeep
    {
        private Chest shop;
        private int nextSlot;

        public ShopTavernkeep(Chest shop, int nextSlot)
        {
            this.shop = shop;
            this.nextSlot = nextSlot;
        }

        public void InitShop(string currentShop)
        {
            switch (currentShop)
            {
                case "Gear":
                    shop.item[nextSlot++].SetDefaults(ItemID.Ale);
                    shop.item[nextSlot++].SetDefaults(ItemID.DD2ElderCrystal);
                    shop.item[nextSlot++].SetDefaults(ItemID.DD2ElderCrystalStand);
                    shop.item[nextSlot++].SetDefaults(ItemID.DefendersForge);
                    shopBallista(shop, nextSlot);
                    shopExplosive(shop, nextSlot);
                    shopLightning(shop, nextSlot);
                    shopFlameburst(shop, nextSlot);
                    shop.item[nextSlot++].SetDefaults(ItemID.ApprenticeScarf);
                    shop.item[nextSlot++].SetDefaults(ItemID.SquireShield);
                    shop.item[nextSlot++].SetDefaults(ItemID.HuntressBuckler);
                    shop.item[nextSlot++].SetDefaults(ItemID.MonkBelt);
                    break;

                default:
                    shop.SetupShop(21);
                    break;
            }
        }

        private void shopFlameburst(Chest shop, int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.DD2FlameburstTowerT1Popper);
            if (Utils.DownedMechBosses() == 1) shop.item[nextSlot].SetDefaults(ItemID.DD2FlameburstTowerT2Popper);
            if (NPC.downedGolemBoss) shop.item[nextSlot].SetDefaults(ItemID.DD2FlameburstTowerT3Popper);
            nextSlot++;
        }

        private void shopBallista(Chest shop, int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.DD2BallistraTowerT1Popper);
            if (Utils.DownedMechBosses() == 1) shop.item[nextSlot].SetDefaults(ItemID.DD2BallistraTowerT2Popper);
            if (NPC.downedGolemBoss) shop.item[nextSlot].SetDefaults(ItemID.DD2BallistraTowerT3Popper);
            nextSlot++;
        }

        private void shopLightning(Chest shop, int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.DD2LightningAuraT1Popper);
            if (Utils.DownedMechBosses() == 1) shop.item[nextSlot].SetDefaults(ItemID.DD2LightningAuraT2Popper);
            if (NPC.downedGolemBoss) shop.item[nextSlot].SetDefaults(ItemID.DD2LightningAuraT3Popper);
            nextSlot++;
        }

        private void shopExplosive(Chest shop, int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.DD2ExplosiveTrapT1Popper);
            if (Utils.DownedMechBosses() == 1) shop.item[nextSlot].SetDefaults(ItemID.DD2ExplosiveTrapT2Popper);
            if (NPC.downedGolemBoss) shop.item[nextSlot].SetDefaults(ItemID.DD2ExplosiveTrapT3Popper);
            nextSlot++;
        }
    }
}