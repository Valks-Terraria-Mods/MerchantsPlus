using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    internal class Pirate : GlobalNPC
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Pirate) return;
            if (!Config.merchantDialog) return;
            chat = Utils.Dialog(new string[] { Utils.DialogGift(npc, "Oh ye rich friend? Take a cannonball arr.", "Arrrrr", true, 5, ItemID.Cannonball, 100000),
                "Arr?"});
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Pirate) return;
            attackDelay = 1;
            projType = ProjectileID.Bullet;
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