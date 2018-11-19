using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class DyeTrader : GlobalNPC
    {
        // custom loot bags with all the dyes in them (e.g. blue, red bags)
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.DyeTrader) {
                if (NPC.downedSlimeKing) {
                    shop.item[nextSlot++].SetDefaults(ItemID.BlueDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.SkyBlueDye);
                }

                if (NPC.downedBoss1) {
                    shop.item[nextSlot++].SetDefaults(ItemID.RedDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.PinkDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.PurpleDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.VioletDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.BlackDye);
                }

                if (NPC.downedBoss2) {
                    shop.item[nextSlot++].SetDefaults(ItemID.GreenDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.LimeDye);
                }

                if (NPC.downedQueenBee) {
                    shop.item[nextSlot++].SetDefaults(ItemID.CyanDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.TealDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.YellowDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.OrangeDye);
                }

                if (NPC.downedBoss3) {
                    shop.item[nextSlot++].SetDefaults(ItemID.PurpleOozeDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.ReflectiveMetalDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.ShadowDye);
                }
                
                if (Main.hardMode) {
                    shop.item[nextSlot++].SetDefaults(ItemID.ShadowflameHadesDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.PhaseDye);
                    shop.item[nextSlot++].SetDefaults(ItemID.TwilightDye);
                }
            }
        }
    }
}
