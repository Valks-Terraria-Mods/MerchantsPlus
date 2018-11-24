using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class GoblinTinkerer : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.GoblinTinkerer) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 0.8f;
        }

        public override void DrawEffects(NPC npc, ref Color drawColor) {
            if (npc.type != NPCID.BoundGoblin) return;
            Lighting.AddLight(npc.position, new Vector3(1, 0, 0));
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.GoblinTinkerer) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "Were going to mod your gear right up baby. :)" ,
                "I got all the modifications you will ever need. >:)",
                "Did someone call for a modder? >:D"});
        }
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type != NPCID.GoblinTinkerer) return;

            const int SLOT_BOOTS = 0;
            const int SLOT_GRAPPLE = 3;

            if (NPC.downedSlimeKing)
            {
                if (Utils.kills(NPCID.BlueSlime) > 100) shop.item[nextSlot++].SetDefaults(ItemID.Aglet);
                if (Utils.kills(NPCID.RedSlime) > 100) shop.item[nextSlot++].SetDefaults(ItemID.AnkletoftheWind);
                if (Utils.kills(NPCID.PurpleSlime) > 100) shop.item[nextSlot++].SetDefaults(ItemID.Shackle);
                shop.item[SLOT_GRAPPLE].SetDefaults(ItemID.SlimeHook);
            }
            if (NPC.downedBoss1)
            {
                if (Utils.kills(NPCID.DemonEye) > 100) shop.item[nextSlot++].SetDefaults(ItemID.CloudinaBottle);
                if (Utils.kills(NPCID.DemonEye2) > 100) shop.item[nextSlot++].SetDefaults(ItemID.SandstorminaBottle);
                if (Utils.kills(NPCID.Zombie) > 100) shop.item[nextSlot++].SetDefaults(ItemID.BlizzardinaBottle);
                shop.item[SLOT_GRAPPLE].SetDefaults(ItemID.IvyWhip);
            }

            if (NPC.downedBoss2)
            {
                if (Utils.kills(NPCID.Zombie) > 150) shop.item[nextSlot++].SetDefaults(ItemID.ClimbingClaws);
                if (Utils.kills(NPCID.PinkJellyfish) > 50) shop.item[nextSlot++].SetDefaults(ItemID.Flipper);
                if (Utils.kills(NPCID.Antlion) > 50) shop.item[nextSlot++].SetDefaults(ItemID.FlyingCarpet);
                if (Utils.kills(NPCID.BlueJellyfish) > 50) shop.item[nextSlot++].SetDefaults(ItemID.FrogLeg);
            }

            if (NPC.downedBoss3)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.HermesBoots);
                shop.item[nextSlot++].SetDefaults(ItemID.IceSkates);
                shop.item[nextSlot++].SetDefaults(ItemID.LavaCharm);
                shop.item[nextSlot++].SetDefaults(ItemID.LuckyHorseshoe);
                shop.item[nextSlot++].SetDefaults(ItemID.ShinyRedBalloon);
            }

            if (NPC.downedMechBoss1)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.Tabi);
                shop.item[nextSlot++].SetDefaults(ItemID.BlackBelt);
                shop.item[nextSlot++].SetDefaults(ItemID.MoonCharm);
                shop.item[nextSlot++].SetDefaults(ItemID.CobaltShield);
            }

            if (NPC.downedMechBoss2)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.FleshKnuckles);
                shop.item[nextSlot++].SetDefaults(ItemID.FrozenTurtleShell);
                shop.item[nextSlot++].SetDefaults(ItemID.HandWarmer);
                shop.item[nextSlot++].SetDefaults(ItemID.HoneyComb);
            }

            if (NPC.downedMechBoss3)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.MagmaStone);
                shop.item[nextSlot++].SetDefaults(ItemID.PaladinsShield);
                shop.item[nextSlot++].SetDefaults(ItemID.PutridScent);

            }

            if (NPC.downedPlantBoss)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.SharkToothNecklace);
                shop.item[nextSlot++].SetDefaults(ItemID.StarCloak);
                shop.item[nextSlot++].SetDefaults(ItemID.SunStone);
                shop.item[nextSlot++].SetDefaults(ItemID.TitanGlove);
                shop.item[nextSlot++].SetDefaults(ItemID.DiscountCard);
                shop.item[nextSlot++].SetDefaults(ItemID.JellyfishNecklace);
                shop.item[nextSlot++].SetDefaults(ItemID.LuckyCoin);
                shop.item[nextSlot++].SetDefaults(ItemID.NeptunesShell);
            }

            if (Main.hardMode) {
                shop.item[SLOT_GRAPPLE].SetDefaults(ItemID.DualHook);
                shop.item[SLOT_BOOTS].SetDefaults(ItemID.LightningBoots);
            }

            if (Utils.downedMechBosses() == 3) {
                shop.item[SLOT_GRAPPLE].SetDefaults(ItemID.IlluminantHook);
                shop.item[SLOT_BOOTS].SetDefaults(ItemID.FrostsparkBoots);
            }

            if (NPC.downedPlantBoss) {
                shop.item[SLOT_GRAPPLE].SetDefaults(ItemID.AntiGravityHook);
            }

            if (NPC.downedGolemBoss) {
                shop.item[SLOT_GRAPPLE].SetDefaults(ItemID.SpookyHook);
            }

            if (NPC.downedMoonlord) {
                shop.item[SLOT_GRAPPLE].SetDefaults(ItemID.LunarHook);
            }
        }
    }
}
