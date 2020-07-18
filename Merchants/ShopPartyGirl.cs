using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Merchants
{
    internal class ShopPartyGirl : Shop
    {
        public ShopPartyGirl(bool merchant, params string[] shops) : base(merchant, shops)
        {
        }

        public override void OpenShop(string shop)
        {
            base.OpenShop(shop);

            if (shop == "Party Stuff")
            {
                AddItem(ItemID.ConfettiGun);
                AddItem(ItemID.Confetti);
                AddItem(ItemID.SmokeBomb);
                AddItem(ItemID.BubbleMachine);
                AddItem(ItemID.BubbleWand);
                AddItem(ItemID.BeachBall);
                AddItem(ItemID.LavaLamp);
                AddItem(ItemID.FireworksBox);
                AddItem(ItemID.FireworkFountain);
                AddItem(ItemID.RedRocket);
                AddItem(ItemID.GreenRocket);
                AddItem(ItemID.BlueRocket);
                AddItem(ItemID.YellowRocket);
                AddItem(ItemID.ConfettiCannon);
                AddItem(ItemID.Bubble);
                AddItem(ItemID.SmokeBlock);
                AddItem(ItemID.PartyMonolith);
                AddItem(ItemID.SillyBalloonMachine);
                AddItem(ItemID.PartyPresent);
                AddItem(ItemID.Pigronata);
                AddItem(ItemID.SillyStreamerBlue);
                AddItem(ItemID.SillyStreamerGreen);
                AddItem(ItemID.SillyStreamerPink);
                AddItem(ItemID.SillyBalloonTiedPurple);
                AddItem(ItemID.SillyBalloonTiedGreen);
                AddItem(ItemID.SillyBalloonTiedPink);
                AddItem(ItemID.MysteriousCape);
                AddItem(ItemID.DiamondRing);
                AddItem(ItemID.AngelHalo);
                AddItem(ItemID.GingerBeard);
                return;
            }

            // Default Shop
            Inv.SetupShop(13);
        }
    }
}