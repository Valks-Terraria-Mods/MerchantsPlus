namespace MerchantsPlus.Shops;

public class ShopCyborg : Shop
{
    public override string[] Shops => ["Robotics", "Buffs"];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Buffs")
        {
            AddItem(ItemID.GravitationPotion, ItemCosts.Potions);
            AddItem(ItemID.SwiftnessPotion, ItemCosts.Potions);
            AddItem(ItemID.ThornsPotion, ItemCosts.Potions);
            AddItem(ItemID.TitanPotion, ItemCosts.Potions);
            AddItem(ItemID.WarmthPotion, ItemCosts.Potions);
            AddItem(ItemID.WrathPotion, ItemCosts.Potions);

            return;
        }

        if (shop == "Robotics")
        {
            AddItem(ItemID.ProximityMineLauncher);
            AddItem(ItemID.Nanites);
            AddItem(ItemID.PortalGun);
            AddItem(ItemID.PortalGunStation);

            if (Progression.Golem)
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
        Inv.SetupShop(ShopType.Cyborg);
    }
}