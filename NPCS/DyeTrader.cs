using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class DyeTrader : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.DyeTrader) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 0.8f;
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.DyeTrader) return;
            chat = Utils.dialog(new string[] { "Hi", "Hey" });
        }

        // custom loot bags with all the dyes in them (e.g. blue, red bags)
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type != NPCID.DyeTrader) return;
            if (NPC.downedSlimeKing)
            {
                if (Utils.kills(NPCID.BlueSlime) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightBlueDye);
                if (Utils.kills(NPCID.BlueSlime) > 10) shop.item[nextSlot++].SetDefaults(ItemID.BlueDye);
                if (Utils.kills(NPCID.Harpy) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightSkyBlueDye);
                if (Utils.kills(NPCID.Harpy) > 10) shop.item[nextSlot++].SetDefaults(ItemID.SkyBlueDye);
            }

            if (NPC.downedBoss1)
            { //eye
                if (Utils.kills(NPCID.RedSlime) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightRedDye);
                if (Utils.kills(NPCID.RedSlime) > 10) shop.item[nextSlot++].SetDefaults(ItemID.RedDye);
                if (Utils.kills(NPCID.PinkJellyfish) > 10) shop.item[nextSlot++].SetDefaults(ItemID.BrightPinkDye);
                if (Utils.kills(NPCID.Pinky) > 1) shop.item[nextSlot++].SetDefaults(ItemID.PinkDye);
                if (Utils.kills(NPCID.PurpleSlime) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightPurpleDye);
                if (Utils.kills(NPCID.PurpleSlime) > 10) shop.item[nextSlot++].SetDefaults(ItemID.PurpleDye);
                if (Utils.kills(NPCID.DemonEye) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightVioletDye);
                if (Utils.kills(NPCID.DemonEye) > 10) shop.item[nextSlot++].SetDefaults(ItemID.VioletDye);
                if (Utils.kills(NPCID.Zombie) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BlackDye);
            }

            if (NPC.downedBoss2)
            { // brain / worm 
                if (Utils.kills(NPCID.EaterofSouls) > 20 || (Utils.kills(NPCID.BloodCrawler) > 20)) shop.item[nextSlot++].SetDefaults(ItemID.BrightGreenDye);
                if (Utils.kills(NPCID.EaterofSouls) > 10 || (Utils.kills(NPCID.BloodCrawler) > 10)) shop.item[nextSlot++].SetDefaults(ItemID.GreenDye);
                if (Utils.kills(NPCID.DevourerBody) > 20 || (Utils.kills(NPCID.FaceMonster) > 20)) shop.item[nextSlot++].SetDefaults(ItemID.BrightLimeDye);
                if (Utils.kills(NPCID.DevourerBody) > 10 || (Utils.kills(NPCID.FaceMonster) > 10)) shop.item[nextSlot++].SetDefaults(ItemID.LimeDye);
            }

            if (NPC.downedQueenBee)
            {
                if (Utils.kills(NPCID.AngryTrapper) > 10) shop.item[nextSlot++].SetDefaults(ItemID.BrightCyanDye);
                if (Utils.kills(NPCID.AngryTrapper) > 5) shop.item[nextSlot++].SetDefaults(ItemID.CyanDye);
                if (Utils.kills(NPCID.JungleSlime) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightTealDye);
                if (Utils.kills(NPCID.JungleSlime) > 10) shop.item[nextSlot++].SetDefaults(ItemID.TealDye);
                if (Utils.kills(NPCID.Hornet) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightYellowDye);
                if (Utils.kills(NPCID.Hornet) > 10) shop.item[nextSlot++].SetDefaults(ItemID.YellowDye);
                if (Utils.kills(NPCID.JungleBat) > 20) shop.item[nextSlot++].SetDefaults(ItemID.BrightOrangeDye);
                if (Utils.kills(NPCID.JungleBat) > 10) shop.item[nextSlot++].SetDefaults(ItemID.OrangeDye);
            }

            if (NPC.downedBoss3)
            { // skeletron
                if (Utils.kills(NPCID.AngryBones) > 10) shop.item[nextSlot++].SetDefaults(ItemID.PurpleOozeDye);
                if (Utils.kills(NPCID.DarkCaster) > 10) shop.item[nextSlot++].SetDefaults(ItemID.ReflectiveMetalDye);
                if (Utils.kills(NPCID.CursedSkull) > 10) shop.item[nextSlot++].SetDefaults(ItemID.ShadowDye);
                if (Utils.kills(NPCID.DungeonSlime) > 10) shop.item[nextSlot++].SetDefaults(ItemID.StardustDye);
                if (Utils.kills(NPCID.AngryBones) > 20) shop.item[nextSlot++].SetDefaults(ItemID.GrimDye);
                if (Utils.kills(NPCID.DarkCaster) > 20) shop.item[nextSlot++].SetDefaults(ItemID.HadesDye);
                if (Utils.kills(NPCID.CursedSkull) > 20) shop.item[nextSlot++].SetDefaults(ItemID.LivingFlameDye);
                if (Utils.kills(NPCID.DungeonSlime) > 20) shop.item[nextSlot++].SetDefaults(ItemID.MartianArmorDye);
            }

            if (Main.hardMode)
            {
                if (Utils.kills(NPCID.PossessedArmor) > 10) shop.item[nextSlot++].SetDefaults(ItemID.ShadowflameHadesDye);
                if (Utils.kills(NPCID.WanderingEye) > 10) shop.item[nextSlot++].SetDefaults(ItemID.PhaseDye);
                if (Utils.kills(NPCID.Wraith) > 10) shop.item[nextSlot++].SetDefaults(ItemID.TwilightDye);
            }
        }
    }
}
