using MerchantsPlus.ModDefs;
using Terraria.WorldBuilding;

namespace MerchantsPlus.Shops;

public class ShopGuide : Shop
{
    public override string[] Shops => ["Gear", "Pylons", "Boss Summons"];

    public override void OpenShop(string shop)
    {
        base.OpenShop(shop);

        if (shop == "Gear")
        {
            if (Progression.Hardmode)
            {
                AddItem(ItemID.MagicMirror, Coins.Gold());
            }

            AddItem(ItemID.CordageGuide, Coins.Gold());

            if (!WorldUtils.IsNpcHere(NPCID.Merchant))
            {
                AddItem(ItemID.Torch);
            }

            if (Progression.Skeletron && !Progression.Hardmode)
            {
                AddItem(ItemID.GuideVoodooDoll, Coins.Gold(5));
            }

            if (Progression.EaterOfWorlds || Progression.BrainOfCthulhu)
            {
                if (!Progression.Hardmode)
                {
                    AddItem(ItemID.Obsidian, Coins.Silver());
                }
            }

            if (!WorldUtils.IsNpcHere(NPCID.Pirate))
            {
                AddItem(ItemID.Cannon, Coins.Gold(2));
                AddItem(ItemID.Cannonball);
            }

            AddItem(ItemID.Gel, Coins.Silver());
        }

        if (shop == "Pylons")
        {
            AddItem(ItemID.TeleportationPylonVictory, Coins.Gold());
            AddItem(ItemID.TeleportationPylonUnderground, Coins.Gold());
            AddItem(ItemID.TeleportationPylonSnow, Coins.Gold());
            AddItem(ItemID.TeleportationPylonPurity, Coins.Gold());
            AddItem(ItemID.TeleportationPylonOcean, Coins.Gold());
            AddItem(ItemID.TeleportationPylonMushroom, Coins.Gold());
            AddItem(ItemID.TeleportationPylonJungle, Coins.Gold());
            AddItem(ItemID.TeleportationPylonHallow, Coins.Gold());
            AddItem(ItemID.TeleportationPylonDesert, Coins.Gold());
        }

        if (shop == "Boss Summons")
        {
            BossSummons();
        }
    }
    
    private void BossSummons()
    {
        AddItem(ItemID.SlimeCrown, Coins.Gold(3));

        if (Thorium.ModLoaded)
        {
            AddItem(Thorium.GrandFlareGun, Coins.Gold(2));
            AddItem(Thorium.StormFlare, Coins.Gold());
        }
        
        if (Progression.SlimeKing)
            AddItem(ItemID.SuspiciousLookingEye, Coins.Gold(5));
        
        if (Progression.EyeOfCthulhu)
            AddItem(GenVars.crimsonLeft ? ItemID.BloodySpine : ItemID.WormFood, Coins.Gold(5));

        if (Progression.Skeletron)
        {
            AddItem(ItemID.Abeemination, Coins.Gold(5));
            AddItem(ItemID.DeerThing, Coins.Gold(5));
            AddItem(ItemID.GuideVoodooDoll, Coins.Gold(5));
        }

        if (Main.hardMode)
        {
            AddItem(ItemID.QueenSlimeCrystal, Coins.Gold(5));
            AddItem(ItemID.MechanicalEye, Coins.Gold(5));
            AddItem(ItemID.MechanicalSkull, Coins.Gold(5));
            AddItem(ItemID.MechanicalWorm, Coins.Gold(5));

            if (Progression.DownedMechs(3))
            {
                AddItem(ItemID.LihzahrdPowerCell, Coins.Gold(5));
            }

            if (Progression.Golem)
            {
                AddItem(ItemID.TruffleWorm, Coins.Gold(5));
            }

            if (Progression.Towers)
            {
                AddItem(ItemID.CelestialSigil, Coins.Gold(10));
            }
        }
    }
}