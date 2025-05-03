namespace MerchantsPlus.Shops;

public class ShopDemolitionist : Shop
{
    public override string[] Shops => ["Explosives", "Potions"];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Potions")
        {
            AddItem(ItemID.MiningPotion, Utils.UniversalPotionCost);
            AddItem(ItemID.NightOwlPotion, Utils.UniversalPotionCost);
            AddItem(ItemID.ShinePotion, Utils.UniversalPotionCost);
            AddItem(ItemID.SpelunkerPotion, Utils.UniversalPotionCost);
            AddItem(ItemID.StinkPotion, Utils.UniversalPotionCost);
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

            if (Utils.HasNPC(NPCID.Angler))
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