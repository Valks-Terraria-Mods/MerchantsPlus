using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class SkeletonMerchant : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.SkeletonMerchant)
            {
                npc.lifeMax = 500;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type == NPCID.SkeletonMerchant)
            {
                switch (Main.rand.Next(3))
                {
                    case 0:
                        chat = "I really like music!";
                        break;
                    case 1:
                        chat = "I got some good beats you might like.";
                        break;
                    default:
                        chat = "I got a load of genres you can listen to! :)";
                        break;
                }
            }
        }
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.SkeletonMerchant)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxAltOverworldDay);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxAltUnderground);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxBoss1);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxBoss2);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxBoss3);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxBoss4);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxBoss5);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxCorruption);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxCrimson);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxDD2);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxDesert);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxDungeon);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxEclipse);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxEerie);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxFrostMoon);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxGoblins);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxIce);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxJungle);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxLunarBoss);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxMartians);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxMushrooms);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxNight);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxOcean);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxOverworldDay);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxPlantera);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxPumpkinMoon);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxRain);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxSandstorm);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxSnow);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxSpace);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxTemple);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxTheHallow);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxTitle);
                shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxTowers);
            }
        }
    }
}
