using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class ArmsDealer : GlobalNPC
    {
        

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.ArmsDealer) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "Get 'yer epic guns now!",
                "Epic guns 'fer sale!",
                "I 'aint five, don't treat me like I can't do this 'ere math!",
                "Ya need a gun?",
                "Get 'yer guns right here!",
                "Guns 'fer sale!",
                "Are 'yer gonna buy somethin'?",
                "I 'aint got all day!",
                "Epic guns!",
                "Looks you you 'ere need a gun!",
                "'Ey, need a gun?",
                Utils.isNPCHere(NPCID.Pirate) ? "Tell that 'ere pirate dude to stop shooting cannon balls at 'urs truly!" : "'Ere did that pirate dude go? He owes me money!"});
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.ArmsDealer) return;
            attackDelay = 1;
            projType = ProjectileID.Bullet;
            if (NPC.downedSlimeKing)
            {
                projType = ProjectileID.Bullet;
            }
            if (NPC.downedBoss1)
            {
                projType = ProjectileID.MeteorShot;
            }
            if (NPC.downedBoss3)
            {
                projType = ProjectileID.BulletHighVelocity;
            }
            if (Utils.downedMechBosses() == 3)
            {
                projType = ProjectileID.CrystalBullet;
            }
            if (NPC.downedPlantBoss)
            {
                projType = ProjectileID.ChlorophyteBullet;
            }
            if (NPC.downedMoonlord)
            {
                projType = ProjectileID.MoonlordBullet;
            }
        }
    }
}
