﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    internal class Wizard : GlobalNPC
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Wizard) return;
            if (!Config.merchantDialog) return;
            chat = Utils.Dialog(new string[] { "Gandolf? Is that you?",
                "My magic is more then you think young one.",
                "It is dangerous to go alone little one. Bring friends on your journey.",
                "The dungeon is a dark place litte one, be careful.",
                "Some say a lord possesses this world.",
                Utils.DialogGift(npc, "Here take this little one, you may need this on your journey.", "Be safe on your journey.", true, 10, ItemID.MagicDagger, 50000),
                "The world is a big place little one."});
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Wizard) return;
            attackDelay = 1;
            projType = ProjectileID.RainbowCrystalExplosion;
            if (Utils.DownedMechBosses() == 1)
            {
                projType = ProjectileID.BallofFire;
            }
            if (Utils.DownedMechBosses() == 2)
            {
                projType = ProjectileID.BallofFrost;
            }
            if (Utils.DownedMechBosses() == 3)
            {
                projType = ProjectileID.MagnetSphereBall;
            }
            if (NPC.downedPlantBoss)
            {
                projType = ProjectileID.RainbowRodBullet;
            }
            if (NPC.downedGolemBoss)
            {
                projType = ProjectileID.RainbowBack;
            }
            if (NPC.downedFishron)
            {
                projType = ProjectileID.RainbowFront;
            }
            if (NPC.downedMoonlord)
            {
                projType = ProjectileID.RainbowCrystal;
            }
        }
    }
}