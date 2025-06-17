namespace MerchantsPlus.Shops;

public class ShopDemolitionist : Shop
{
    public override string[] Shops => ["Explosives", "Potions"];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Potions")
        {
            AddItem(ItemID.MiningPotion, ItemCosts.Potions);
            AddItem(ItemID.NightOwlPotion, ItemCosts.Potions);
            AddItem(ItemID.ShinePotion, ItemCosts.Potions);
            AddItem(ItemID.SpelunkerPotion, ItemCosts.Potions);
            AddItem(ItemID.StinkPotion, ItemCosts.Potions);
            return;
        }

        if (shop == "Explosives")
        {
            AddItem(ItemID.Grenade);

            if (NPC.AnyNPCs(NPCID.PartyGirl))
            {
                AddItem(ItemID.PartyGirlGrenade);
            }

            if (Progression.SlimeKing)
            {
                AddItem(ItemID.Bomb);
            }

            if (Progression.EyeOfCthulhu)
            {
                AddItem(ItemID.Dynamite);
            }

            if (WorldUtils.HasNpc(NPCID.Angler))
            {
                AddItem(ItemID.BombFish);
            }

            if (Progression.QueenBee)
            {
                AddItem(ItemID.Beenade);
            }

            if (Progression.Skeletron)
            {
                AddItem(ItemID.ExplosiveBunny);
            }

            if (Progression.Hardmode)
            {
                AddItem(ItemID.Explosives);
                AddItem(ItemID.StickyGrenade);
                AddItem(ItemID.StickyBomb);
                AddItem(ItemID.StickyDynamite);
                AddItem(ItemID.BouncyGrenade);
                AddItem(ItemID.BouncyBomb);
                AddItem(ItemID.BouncyDynamite);
            }

            if (Progression.BloodMoon)
            {
                AddItem(ItemID.ExplosiveJackOLantern);
            }

            if (Progression.Moonlord)
            {
                AddItem(ItemID.LandMine);
            }
            return;
        }

        // Default Shop
        Inv.SetupShop(ShopType.Demolitionist);
    }
}