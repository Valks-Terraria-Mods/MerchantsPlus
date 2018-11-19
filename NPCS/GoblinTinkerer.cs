using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class GoblinTinkerer : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot) {
            if (type == NPCID.GoblinTinkerer) {
                if (NPC.downedSlimeKing) {
                    shop.item[nextSlot++].SetDefaults(ItemID.Aglet);
                    shop.item[nextSlot++].SetDefaults(ItemID.AnkletoftheWind);
                    shop.item[nextSlot++].SetDefaults(ItemID.Shackle);
                }
                if (NPC.downedBoss1) {
                    shop.item[nextSlot++].SetDefaults(ItemID.CloudinaBottle);
                    shop.item[nextSlot++].SetDefaults(ItemID.SandstorminaBottle);
                    shop.item[nextSlot++].SetDefaults(ItemID.BlizzardinaBottle);
                }

                if (NPC.downedBoss2) {
                    shop.item[nextSlot++].SetDefaults(ItemID.ClimbingClaws);
                    shop.item[nextSlot++].SetDefaults(ItemID.Flipper);
                    shop.item[nextSlot++].SetDefaults(ItemID.FlyingCarpet);
                    shop.item[nextSlot++].SetDefaults(ItemID.FrogLeg);
                }

                if (NPC.downedBoss3) {
                    shop.item[nextSlot++].SetDefaults(ItemID.HermesBoots);
                    shop.item[nextSlot++].SetDefaults(ItemID.IceSkates);
                    shop.item[nextSlot++].SetDefaults(ItemID.LavaCharm);
                    shop.item[nextSlot++].SetDefaults(ItemID.LuckyHorseshoe);
                    shop.item[nextSlot++].SetDefaults(ItemID.ShinyRedBalloon);
                }

                if (NPC.downedMechBoss1) {
                    shop.item[nextSlot++].SetDefaults(ItemID.Tabi);
                    shop.item[nextSlot++].SetDefaults(ItemID.BlackBelt);
                    shop.item[nextSlot++].SetDefaults(ItemID.MoonCharm);
                    shop.item[nextSlot++].SetDefaults(ItemID.CobaltShield);
                }

                if (NPC.downedMechBoss2) {
                    shop.item[nextSlot++].SetDefaults(ItemID.FleshKnuckles);
                    shop.item[nextSlot++].SetDefaults(ItemID.FrozenTurtleShell);
                    shop.item[nextSlot++].SetDefaults(ItemID.HandWarmer);
                    shop.item[nextSlot++].SetDefaults(ItemID.HoneyComb);
                }

                if (NPC.downedMechBoss3) {
                    shop.item[nextSlot++].SetDefaults(ItemID.MagmaStone);
                    shop.item[nextSlot++].SetDefaults(ItemID.PaladinsShield);
                    shop.item[nextSlot++].SetDefaults(ItemID.PutridScent);
                    
                }

                if (NPC.downedPlantBoss) {
                    shop.item[nextSlot++].SetDefaults(ItemID.SharkToothNecklace);
                    shop.item[nextSlot++].SetDefaults(ItemID.StarCloak);
                    shop.item[nextSlot++].SetDefaults(ItemID.SunStone);
                    shop.item[nextSlot++].SetDefaults(ItemID.TitanGlove);
                    shop.item[nextSlot++].SetDefaults(ItemID.DiscountCard);
                    shop.item[nextSlot++].SetDefaults(ItemID.JellyfishNecklace);
                    shop.item[nextSlot++].SetDefaults(ItemID.LuckyCoin);
                    shop.item[nextSlot++].SetDefaults(ItemID.NeptunesShell);
                }
                
            }
        }
    }
}
