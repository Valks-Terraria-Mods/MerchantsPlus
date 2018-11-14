using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class GoblinTinkerer : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot) {
            if (type == NPCID.GoblinTinkerer) {
                shop.item[nextSlot++].SetDefaults(ItemID.Aglet);
                shop.item[nextSlot++].SetDefaults(ItemID.AnkletoftheWind);
                shop.item[nextSlot++].SetDefaults(ItemID.CloudinaBottle);
                shop.item[nextSlot++].SetDefaults(ItemID.SandstorminaBottle);
                shop.item[nextSlot++].SetDefaults(ItemID.BlizzardinaBottle);
                shop.item[nextSlot++].SetDefaults(ItemID.ClimbingClaws);
                shop.item[nextSlot++].SetDefaults(ItemID.Flipper);
                shop.item[nextSlot++].SetDefaults(ItemID.FlyingCarpet);
                shop.item[nextSlot++].SetDefaults(ItemID.FrogLeg);
                shop.item[nextSlot++].SetDefaults(ItemID.HermesBoots);
                shop.item[nextSlot++].SetDefaults(ItemID.IceSkates);
                shop.item[nextSlot++].SetDefaults(ItemID.LavaCharm);
                shop.item[nextSlot++].SetDefaults(ItemID.LuckyHorseshoe);
                shop.item[nextSlot++].SetDefaults(ItemID.ShinyRedBalloon);
                shop.item[nextSlot++].SetDefaults(ItemID.Tabi);
                shop.item[nextSlot++].SetDefaults(ItemID.BlackBelt);
                shop.item[nextSlot++].SetDefaults(ItemID.MoonCharm);
                shop.item[nextSlot++].SetDefaults(ItemID.CobaltShield);
                shop.item[nextSlot++].SetDefaults(ItemID.FleshKnuckles);
                shop.item[nextSlot++].SetDefaults(ItemID.FrozenTurtleShell);
                shop.item[nextSlot++].SetDefaults(ItemID.HandWarmer);
                shop.item[nextSlot++].SetDefaults(ItemID.HoneyComb);
                shop.item[nextSlot++].SetDefaults(ItemID.MagmaStone);
                shop.item[nextSlot++].SetDefaults(ItemID.PaladinsShield);
                shop.item[nextSlot++].SetDefaults(ItemID.PutridScent);
                shop.item[nextSlot++].SetDefaults(ItemID.Shackle);
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
