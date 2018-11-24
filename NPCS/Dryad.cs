using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    // sell wood types / loot bags
    class Dryad : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.Dryad) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 0.75f;
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Dryad) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "I will protect you from the darkness!",
                "I will do whatever it takes to protect you!",
                "If it's the last thing I'll do, I'll protect you!"});
        }
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type != NPCID.Dryad) return;

            shop.item[nextSlot++].SetDefaults(ItemID.CorruptSeeds);
            shop.item[nextSlot++].SetDefaults(ItemID.HallowedSeeds);
            shop.item[nextSlot++].SetDefaults(ItemID.GrassSeeds);
            shop.item[nextSlot++].SetDefaults(ItemID.MushroomGrassSeeds);
            shop.item[nextSlot++].SetDefaults(ItemID.CrimsonSeeds);
            shop.item[nextSlot++].SetDefaults(ItemID.BlinkrootSeeds);
            shop.item[nextSlot++].SetDefaults(ItemID.DaybloomSeeds);
            shop.item[nextSlot++].SetDefaults(ItemID.DeathweedSeeds);
            shop.item[nextSlot++].SetDefaults(ItemID.FireblossomSeeds);
            shop.item[nextSlot++].SetDefaults(ItemID.MoonglowSeeds);
            shop.item[nextSlot++].SetDefaults(ItemID.WaterleafSeeds);
            shop.item[nextSlot++].SetDefaults(ItemID.ShiverthornSeeds);

            if (Main.hardMode) {
                if (Utils.kills(NPCID.JungleSlime) > 5)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.NaturesGift);
                }
                if (NPC.downedBoss1)
                {
                    if (Utils.kills(NPCID.DemonEye) > 15)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.BandofRegeneration);
                    }
                }
                if (NPC.downedBoss2)
                {
                    if (Utils.kills(NPCID.EaterofSouls) > 15)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.BandofStarpower);
                    }

                    if (Utils.kills(NPCID.BloodCrawler) > 15)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.PanicNecklace);
                    }
                }
                if (Utils.kills(NPCID.Mimic) > 5)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.PhilosophersStone);
                    shop.item[nextSlot++].SetDefaults(ItemID.CrossNecklace);
                }
                if (Utils.kills(NPCID.Werewolf) > 10)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.AdhesiveBandage);
                }
                if (Utils.kills(NPCID.BlueArmoredBones) > 10 || Utils.kills(NPCID.ArmoredSkeleton) > 10)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.ArmorPolish);
                }
                if (Utils.kills(NPCID.ToxicSludge) > 10)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.Bezoar);
                }
                if (Utils.kills(NPCID.Hornet) > 10)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.FeralClaws);
                }
                if (Utils.kills(NPCID.CursedSkull) > 10)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.Nazar);
                }
                if (Utils.kills(NPCID.CorruptSlime) > 10)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.Blindfold);
                }
                if (Utils.kills(NPCID.Mummy) > 10)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.TrifoldMap);
                }
                if (Utils.kills(NPCID.Corruptor) > 10)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.Vitamins);
                }
                if (Utils.kills(NPCID.Pixie) > 10)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.FastClock);
                    shop.item[nextSlot++].SetDefaults(ItemID.Megaphone);
                }
                if (Utils.kills(NPCID.Vampire) > 10)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.MoonStone);
                }
                if (Utils.kills(NPCID.Medusa) > 2)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.PocketMirror);
                }
                if (Utils.kills(NPCID.FireImp) > 10)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.ObsidianRose);
                }
            }
        }
    }
}
