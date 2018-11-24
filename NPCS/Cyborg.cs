using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Cyborg : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.Cyborg) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 1.1f;
        }

        public override void TownNPCAttackCooldown(NPC npc, ref int cooldown, ref int randExtraCooldown)
        {
            if (npc.type != NPCID.Cyborg) return;
            cooldown = 0;
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Cyborg) return;
            projType = ProjectileID.RocketI;
            if (NPC.downedSlimeKing)
            {
                projType = ProjectileID.RocketII;
            }
            if (NPC.downedBoss1)
            {
                projType = ProjectileID.RocketIII;
            }
            if (NPC.downedBoss2)
            {
                projType = ProjectileID.RocketIV;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Cyborg) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] {"Don't set off those explosives off I have behind you.",
            "Anything that moves in the sky, I see it.",
            "Rocketry is a very delicate task, it requires alot of focus.",
            "Aim. Shoot. Kill.",
            Main.eclipse ? "Are you afraid of a mere eclipse? I'm not!" : "Always keep your wits about you.",
            Main.raining ? "This rain is bad for my circuits." : "A bright day is my day.",
            Main.hardMode ? "The world feels a lot more tougher than it use to be." : "This world is weak."});
        }

        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type != NPCID.Cyborg) return;
            if (NPC.downedGolemBoss)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.ElectrosphereLauncher);
            }

            if (NPC.downedFishron)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.RocketLauncher);
            }

            if (NPC.downedAncientCultist)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.SnowmanCannon);
            }

            if (NPC.downedTowerVortex)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.NailGun);
            }

        }

    }
}
