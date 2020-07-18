using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Shops
{
    internal class ShopDyeTrader : Shop
    {
        public ShopDyeTrader(bool merchant, params string[] shops) : base(merchant, shops)
        {
        }

        public override void OpenShop(string shop)
        {
            base.OpenShop(shop);

            if (shop == "Color")
            {
                AddItem(ItemID.DyeVat);
                AddItem(ItemID.SilverDye);
                AddItem(ItemID.TeamDye);
                AddItem(ItemID.BrownDye);
                if (NPC.downedSlimeKing)
                {
                    if (Utils.Kills(NPCID.BlueSlime) > 20) AddItem(ItemID.BrightBlueDye);
                    if (Utils.Kills(NPCID.BlueSlime) > 10) AddItem(ItemID.BlueDye);
                    if (Utils.Kills(NPCID.Harpy) > 20) AddItem(ItemID.BrightSkyBlueDye);
                    if (Utils.Kills(NPCID.Harpy) > 10) AddItem(ItemID.SkyBlueDye);
                }

                if (Utils.DownedEyeOfCthulhu())
                {
                    if (Utils.Kills(NPCID.RedSlime) > 20) AddItem(ItemID.BrightRedDye);
                    if (Utils.Kills(NPCID.RedSlime) > 10) AddItem(ItemID.RedDye);
                    if (Utils.Kills(NPCID.PinkJellyfish) > 10) AddItem(ItemID.BrightPinkDye);
                    if (Utils.Kills(NPCID.Pinky) > 1) AddItem(ItemID.PinkDye);
                    if (Utils.Kills(NPCID.PurpleSlime) > 20) AddItem(ItemID.BrightPurpleDye);
                    if (Utils.Kills(NPCID.PurpleSlime) > 10) AddItem(ItemID.PurpleDye);
                    if (Utils.Kills(NPCID.DemonEye) > 20) AddItem(ItemID.BrightVioletDye);
                    if (Utils.Kills(NPCID.DemonEye) > 10) AddItem(ItemID.VioletDye);
                    if (Utils.Kills(NPCID.Zombie) > 20) AddItem(ItemID.BlackDye);
                }

                if (Utils.DownedBrainOfCthulhu() || Utils.DownedEaterOfWorlds())
                {
                    if (Utils.Kills(NPCID.EaterofSouls) > 20 || (Utils.Kills(NPCID.BloodCrawler) > 20)) AddItem(ItemID.BrightGreenDye);
                    if (Utils.Kills(NPCID.EaterofSouls) > 10 || (Utils.Kills(NPCID.BloodCrawler) > 10)) AddItem(ItemID.GreenDye);
                    if (Utils.Kills(NPCID.DevourerBody) > 20 || (Utils.Kills(NPCID.FaceMonster) > 20)) AddItem(ItemID.BrightLimeDye);
                    if (Utils.Kills(NPCID.DevourerBody) > 10 || (Utils.Kills(NPCID.FaceMonster) > 10)) AddItem(ItemID.LimeDye);
                }

                if (NPC.downedQueenBee)
                {
                    if (Utils.Kills(NPCID.AngryTrapper) > 10) AddItem(ItemID.BrightCyanDye);
                    if (Utils.Kills(NPCID.AngryTrapper) > 5) AddItem(ItemID.CyanDye);
                    if (Utils.Kills(NPCID.JungleSlime) > 20) AddItem(ItemID.BrightTealDye);
                    if (Utils.Kills(NPCID.JungleSlime) > 10) AddItem(ItemID.TealDye);
                    if (Utils.Kills(NPCID.Hornet) > 20) AddItem(ItemID.BrightYellowDye);
                    if (Utils.Kills(NPCID.Hornet) > 10) AddItem(ItemID.YellowDye);
                    if (Utils.Kills(NPCID.JungleBat) > 20) AddItem(ItemID.BrightOrangeDye);
                    if (Utils.Kills(NPCID.JungleBat) > 10) AddItem(ItemID.OrangeDye);
                }

                if (Utils.DownedSkeletron())
                {
                    if (Utils.Kills(NPCID.AngryBones) > 10) AddItem(ItemID.PurpleOozeDye);
                    if (Utils.Kills(NPCID.DarkCaster) > 10) AddItem(ItemID.ReflectiveMetalDye);
                    if (Utils.Kills(NPCID.CursedSkull) > 10) AddItem(ItemID.ShadowDye);
                    if (Utils.Kills(NPCID.DungeonSlime) > 10) AddItem(ItemID.StardustDye);
                    if (Utils.Kills(NPCID.AngryBones) > 20) AddItem(ItemID.GrimDye);
                    if (Utils.Kills(NPCID.DarkCaster) > 20) AddItem(ItemID.HadesDye);
                    if (Utils.Kills(NPCID.CursedSkull) > 20) AddItem(ItemID.LivingFlameDye);
                    if (Utils.Kills(NPCID.DungeonSlime) > 20) AddItem(ItemID.MartianArmorDye);
                }

                if (Main.hardMode)
                {
                    if (Utils.Kills(NPCID.PossessedArmor) > 10) AddItem(ItemID.ShadowflameHadesDye);
                    if (Utils.Kills(NPCID.WanderingEye) > 10) AddItem(ItemID.PhaseDye);
                    if (Utils.Kills(NPCID.Wraith) > 10) AddItem(ItemID.TwilightDye);
                }
                return;
            }

            // Default Shop
            Inv.SetupShop(12);
        }
    }
}