using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Wizard : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.Wizard) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 0.8f;
        }

        public override void DrawEffects(NPC npc, ref Color drawColor)
        {
            if (npc.type != NPCID.BoundWizard) return;
            Lighting.AddLight(npc.position, new Vector3(0, 1, 0));
        }

        public override void TownNPCAttackMagic(NPC npc, ref float auraLightMultiplier) {
            if (npc.type != NPCID.Wizard) return;
            auraLightMultiplier *= 2;
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay) {
            if (npc.type != NPCID.Wizard) return;
            projType = ProjectileID.RainbowCrystalExplosion;
            if (Utils.downedMechBosses() == 1) {
                projType = ProjectileID.BallofFire;
            }
            if (Utils.downedMechBosses() == 2) {
                projType = ProjectileID.BallofFrost;
            }
            if (Utils.downedMechBosses() == 3) {
                projType = ProjectileID.MagnetSphereBall;
            }
            if (NPC.downedPlantBoss) {
                projType = ProjectileID.RainbowRodBullet;
            }
            if (NPC.downedGolemBoss) {
                projType = ProjectileID.RainbowBack;
            }
            if (NPC.downedFishron) {
                projType = ProjectileID.RainbowFront;
            }
            if (NPC.downedMoonlord) {
                projType = ProjectileID.RainbowCrystal;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Wizard) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "Gandolf? Is that you?",
                "My magic is more then you think young one.",
                "It is dangerous to go alone little one. Bring friends on your journey.",
                "The dungeon is a dark place litte one, be careful.",
                "Some say a lord possesses this world.",
                Utils.dialogGift(npc, "Here take this little one, you may need this on your journey.", "Be safe on your journey.", true, 10, ItemID.MagicDagger, 50000),
                "The world is a big place little one."});
        }
    }
}
