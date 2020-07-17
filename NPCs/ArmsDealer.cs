using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    internal class ArmsDealer : GlobalNPC
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.ArmsDealer) return;
            if (!Config.merchantDialog) return;
            chat = Utils.Dialog(new string[] { "GET UR EEPIC GUNS NOW",
                "EPIC GUNS FER SALE BRUH",
                "IM 5 YEARS OLD DEAL WITH IT BRAH",
                "YOU NEED A GUN BRAH?",
                "GET YA GUNS TODAY BRAH",
                "GUNS FOR SALE BRAH!",
                "BRAH YOU GONNA' BUY SOMETIN OR WHAT",
                "BRAH I DON'T GOT ALL DAY",
                "EPIC GUNS BRAH",
                "BRAH IT LOOKS LIKE YOU NEED A GUN!",
                "NEED A GUN BRAH?",
                Utils.IsNPCHere(NPCID.Pirate) ? "TELL YE PIRATE DUDE TO STOP SHOOTIN' CANNON BALLS AT ME" : "WONDER WHERE THAT PIRATE DUDE IS AT, HE OWES MEH GUNNNZZ"});
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.ArmsDealer) return;
            attackDelay = 1;
            projType = ProjectileID.Bullet;
            if (NPC.downedSlimeKing)
            {
                projType = ProjectileID.GoldenBullet;
            }
            if (NPC.downedBoss2)
            {
                projType = ProjectileID.MeteorShot;
            }
            if (Utils.DownedMechBosses() == 1)
            {
                projType = ProjectileID.CursedBullet;
            }
            if (Utils.DownedMechBosses() == 2)
            {
                projType = ProjectileID.IchorBullet;
            }
            if (Utils.DownedMechBosses() == 3)
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