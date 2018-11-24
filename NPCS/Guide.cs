using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Guide : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.Guide) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 0.8f;
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Guide) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "I'm a very helpful guide. :)" });
        }

        public override void NPCLoot(NPC npc)
        {
            Utils.dropItem(npc, NPCID.Guide, new short[] { ItemID.IronBow }, 25);
        }

        public override void TownNPCAttackCooldown(NPC npc, ref int cooldown, ref int randExtraCooldown)
        {
            if (npc.type != NPCID.Guide) return;
            cooldown = 0;
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Guide) return;
            projType = ProjectileID.WoodenArrowFriendly;
            if (NPC.downedSlimeKing)
            {
                projType = ProjectileID.FlamingArrow;
            }
            if (NPC.downedBoss1) {
                projType = ProjectileID.FrostburnArrow;
            }
            if (NPC.downedBoss2)
            {
                projType = ProjectileID.JestersArrow;
            }
            if (Main.hardMode) {
                projType = ProjectileID.UnholyArrow;
            }
            if (Utils.downedMechBosses() == 1)
            {
                projType = ProjectileID.HolyArrow;
            }
            if (Utils.downedMechBosses() == 2)
            {
                projType = ProjectileID.CursedArrow;
            }
            if (Utils.downedMechBosses() == 3)
            {
                projType = ProjectileID.VenomArrow;
            }
            if (NPC.downedPlantBoss)
            {
                projType = ProjectileID.ChlorophyteArrow;
            }
            if (NPC.downedMoonlord)
            {
                projType = ProjectileID.MoonlordArrow;
            }
        }
    }
}
