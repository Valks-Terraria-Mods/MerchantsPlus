namespace MerchantsPlus.Merchants;

internal class ShopCyborg : Shop
{
    public override string[] Shops => new string[] { "Robotics", "Buffs" };

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Buffs")
        {
            AddItem(ItemID.GravitationPotion, Utils.UniversalPotionCost);
            AddItem(ItemID.SwiftnessPotion, Utils.UniversalPotionCost);

            AddItem(ItemID.ThornsPotion, Utils.UniversalPotionCost);

            AddItem(ItemID.TitanPotion, Utils.UniversalPotionCost);

            AddItem(ItemID.WarmthPotion, Utils.UniversalPotionCost);

            AddItem(ItemID.WrathPotion, Utils.UniversalPotionCost);

            return;
        }

        if (shop == "Robotics")
        {
            AddItem(ItemID.ProximityMineLauncher);
            AddItem(ItemID.Nanites);
            AddItem(ItemID.PortalGun);
            AddItem(ItemID.PortalGunStation);

            if (NPC.downedGolemBoss)
            {
                AddItem(ItemID.ElectrosphereLauncher);
            }

            if (NPC.downedFishron)
            {
                AddItem(ItemID.RocketLauncher);
            }

            if (NPC.downedAncientCultist)
            {
                AddItem(ItemID.SnowmanCannon);
            }

            if (NPC.downedTowerVortex)
            {
                AddItem(ItemID.NailGun);
            }
            return;
        }

        // Default Shop
        Inv.SetupShop(14);
    }
}