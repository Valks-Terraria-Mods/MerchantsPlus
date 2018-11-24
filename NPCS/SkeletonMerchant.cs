using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class SkeletonMerchant : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.SkeletonMerchant) return;
            if (Config.merchantExtraLife) npc.lifeMax = 2000;
            if (Config.merchantScaling) npc.scale = 1.5f;
        }

        public override void DrawEffects(NPC npc, ref Color drawColor)
        {
            if (npc.type != NPCID.BoundWizard) return;
            Lighting.AddLight(npc.position, new Vector3(0.7f, 0, 0.5f));
        }

        public override void TownNPCAttackCooldown(NPC npc, ref int cooldown, ref int randExtraCooldown)
        {
            if (npc.type != NPCID.SkeletonMerchant) return;
            cooldown = 0;
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.SkeletonMerchant) return;
            projType = ProjectileID.GreenLaser;
        }

        public override void TownNPCAttackStrength(NPC npc, ref int damage, ref float knockback) {
            if (npc.type != NPCID.SkeletonMerchant) return;
            damage += 50;
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.SkeletonMerchant) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "(You hear a small crackling noise..)" ,
                "(The skeleton merchant stares blankly at you..)",
                "(The skeleton merchant seems to be getting impatient..)"});
        }
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type != NPCID.SkeletonMerchant) return;
            /*shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxAltOverworldDay);
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
            shop.item[nextSlot++].SetDefaults(ItemID.MusicBoxTheHallow);*/
        }
    }
}
