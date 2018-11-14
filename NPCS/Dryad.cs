using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    // sell wood types / loot bags
    class Dryad : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.Dryad) {
                shop.item[nextSlot++].SetDefaults(ItemID.BandofRegeneration);
                shop.item[nextSlot++].SetDefaults(ItemID.BandofStarpower);
                shop.item[nextSlot++].SetDefaults(ItemID.NaturesGift);
                shop.item[nextSlot++].SetDefaults(ItemID.PhilosophersStone);
                shop.item[nextSlot++].SetDefaults(ItemID.AdhesiveBandage);
                shop.item[nextSlot++].SetDefaults(ItemID.ArmorPolish);
                shop.item[nextSlot++].SetDefaults(ItemID.Bezoar);
                shop.item[nextSlot++].SetDefaults(ItemID.EyeoftheGolem);
                shop.item[nextSlot++].SetDefaults(ItemID.FeralClaws);
                shop.item[nextSlot++].SetDefaults(ItemID.PanicNecklace);
                shop.item[nextSlot++].SetDefaults(ItemID.PocketMirror);
                shop.item[nextSlot++].SetDefaults(ItemID.Megaphone);
                shop.item[nextSlot++].SetDefaults(ItemID.MoonStone);
                shop.item[nextSlot++].SetDefaults(ItemID.Nazar);
                shop.item[nextSlot++].SetDefaults(ItemID.ObsidianRose);
                shop.item[nextSlot++].SetDefaults(ItemID.CrossNecklace);
                shop.item[nextSlot++].SetDefaults(ItemID.FastClock);
                shop.item[nextSlot++].SetDefaults(ItemID.Blindfold);
                shop.item[nextSlot++].SetDefaults(ItemID.TrifoldMap);
                shop.item[nextSlot++].SetDefaults(ItemID.Vitamins);
            }
            
        }
    }
}
