using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Nurse : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.Nurse) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 0.8f;
        }

        public override void TownNPCAttackCooldown(NPC npc, ref int cooldown, ref int randExtraCooldown)
        {
            if (npc.type != NPCID.Nurse) return;
            cooldown = 0;
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Nurse) return;
            projType = ProjectileID.NurseSyringeHurt;
            if (NPC.downedSlimeKing)
            {
                projType = ProjectileID.Flamarang;
            }
            if (NPC.downedBoss1)
            {
                projType = ProjectileID.Flamelash;
            }
            if (NPC.downedBoss2)
            {
                projType = ProjectileID.BlueFlare;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Nurse) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "Modder still working on my dialog." });
        }

        public override void NPCLoot(NPC npc)
        {
            Utils.dropItem(npc, NPCID.Nurse, new short[] { ItemID.LifeCrystal }, 10);
        }
    }
}
