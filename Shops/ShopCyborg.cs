namespace MerchantsPlus.Shops;

public class ShopCyborg : Shop
{
    public override List<string> Shops { get; } = ["Robotics"];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

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