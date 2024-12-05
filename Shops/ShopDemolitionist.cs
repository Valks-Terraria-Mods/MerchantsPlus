namespace MerchantsPlus.Merchants;

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

            if (NPC.downedSlimeKing)
            {
                AddItem(ItemID.Bomb);
            }

            if (Utils.DownedEyeOfCthulhu())
            {
                AddItem(ItemID.Dynamite);
            }

            if (Utils.HasNPC(NPCID.Angler))
            {
                AddItem(ItemID.BombFish);
            }

            if (NPC.downedQueenBee)
            {
                AddItem(ItemID.Beenade);
            }

            if (Utils.DownedSkeletron())
            {
                AddItem(ItemID.ExplosiveBunny);
            }

            if (Main.hardMode)
            {
                AddItem(ItemID.Explosives);
                AddItem(ItemID.StickyGrenade);
                AddItem(ItemID.StickyBomb);
                AddItem(ItemID.StickyDynamite);
                AddItem(ItemID.BouncyGrenade);
                AddItem(ItemID.BouncyBomb);
                AddItem(ItemID.BouncyDynamite);
            }

            if (NPC.downedClown)
            {
                AddItem(ItemID.ExplosiveJackOLantern);
            }

            if (NPC.downedMoonlord)
            {
                AddItem(ItemID.LandMine);
            }
            return;
        }

        // Default Shop
        Inv.SetupShop(4);
    }
}