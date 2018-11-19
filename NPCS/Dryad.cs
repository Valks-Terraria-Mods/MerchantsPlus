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
                if (NPC.downedBoss2) {
                    shop.item[nextSlot++].SetDefaults(ItemID.BandofRegeneration);
                    shop.item[nextSlot++].SetDefaults(ItemID.BandofStarpower);
                    shop.item[nextSlot++].SetDefaults(ItemID.NaturesGift);
                    shop.item[nextSlot++].SetDefaults(ItemID.PanicNecklace);

                }
                if (NPC.downedBoss3) {
                    if (NPC.killCount[Item.NPCtoBanner(NPCID.Mimic)] > 5) {
                        shop.item[nextSlot++].SetDefaults(ItemID.PhilosophersStone);
                    }
                    if (NPC.killCount[Item.NPCtoBanner(NPCID.Werewolf)] > 10)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.AdhesiveBandage);
                    }
                    if (NPC.killCount[Item.NPCtoBanner(NPCID.BlueArmoredBones)] > 10 || NPC.killCount[Item.NPCtoBanner(NPCID.ArmoredSkeleton)] > 10) {
                        shop.item[nextSlot++].SetDefaults(ItemID.ArmorPolish);
                    }
                    if (NPC.killCount[Item.NPCtoBanner(NPCID.ToxicSludge)] > 10) {
                        shop.item[nextSlot++].SetDefaults(ItemID.Bezoar);
                    }
                    if (NPC.killCount[Item.NPCtoBanner(NPCID.Hornet)] > 10) {
                        shop.item[nextSlot++].SetDefaults(ItemID.FeralClaws);
                    }
                    if (NPC.killCount[Item.NPCtoBanner(NPCID.CursedSkull)] > 10)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.Nazar);
                    }
                    if (NPC.killCount[Item.NPCtoBanner(NPCID.CorruptSlime)] > 10) {
                        shop.item[nextSlot++].SetDefaults(ItemID.Blindfold);
                    }
                    if (NPC.killCount[Item.NPCtoBanner(NPCID.Mummy)] > 10) {
                        shop.item[nextSlot++].SetDefaults(ItemID.TrifoldMap);
                    }
                    if (NPC.killCount[Item.NPCtoBanner(NPCID.Corruptor)] > 10) {
                        shop.item[nextSlot++].SetDefaults(ItemID.Vitamins);
                    }
                    if (NPC.killCount[Item.NPCtoBanner(NPCID.Pixie)] > 10)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.FastClock);
                    }
                    
                }

                if (Main.hardMode) {
                    if (NPC.downedGolemBoss) shop.item[nextSlot++].SetDefaults(ItemID.EyeoftheGolem);
                    if (NPC.downedMechBoss1) {
                        shop.item[nextSlot++].SetDefaults(ItemID.PocketMirror);
                    }
                    if (NPC.downedMechBoss2) {
                        shop.item[nextSlot++].SetDefaults(ItemID.Megaphone);
                    }
                    if (NPC.downedMechBoss3) {
                        shop.item[nextSlot++].SetDefaults(ItemID.MoonStone);
                    }
                    shop.item[nextSlot++].SetDefaults(ItemID.ObsidianRose);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrossNecklace);
                }
                
            }
            
        }
    }
}
