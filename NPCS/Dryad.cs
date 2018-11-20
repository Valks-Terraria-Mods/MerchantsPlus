using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    // sell wood types / loot bags
    class Dryad : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.Dryad)
            {
                npc.lifeMax = 500;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type == NPCID.Dryad)
            {
                switch (Main.rand.Next(3))
                {
                    case 0:
                        chat = "I will protect you from the darkness!";
                        break;
                    case 1:
                        chat = "I will do whatever it takes to protect you!";
                        break;
                    default:
                        chat = "If it's the last thing I'll do, I'll protect you!";
                        break;
                }
            }
        }
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.Dryad) {
                if (Utils.kills(NPCID.JungleSlime) > 5) {
                    shop.item[nextSlot++].SetDefaults(ItemID.NaturesGift);
                }
                if (NPC.downedBoss1) {
                    if (Utils.kills(NPCID.DemonEye) > 15)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.BandofRegeneration);
                    }
                }
                if (NPC.downedBoss2) {
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
