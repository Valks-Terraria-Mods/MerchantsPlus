using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Pirate : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.Pirate) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 0.9f;
        }

        public override void TownNPCAttackCooldown(NPC npc, ref int cooldown, ref int randExtraCooldown)
        {
            if (npc.type != NPCID.Pirate) return;
            cooldown = 0;
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Pirate) return;
            projType = ProjectileID.Bullet;
            if (Utils.downedMechBosses() == 1)
            {
                projType = ProjectileID.CursedBullet;
            }
            if (Utils.downedMechBosses() == 2)
            {
                projType = ProjectileID.IchorBullet;
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

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Pirate) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { Utils.dialogGift(npc, "Oh ye rich friend? Take a cannonball arr.", "Arrrrr", true, 5, ItemID.Cannonball, 100000),
                "Arr?"});
        }

        public override void SetupShop(int type, Chest shop, ref int nextSlot) {
            if (type != NPCID.Pirate) return;
            shop.item[nextSlot++].SetDefaults(ItemID.RangerEmblem);
            shop.item[nextSlot++].SetDefaults(ItemID.SorcererEmblem);
            shop.item[nextSlot++].SetDefaults(ItemID.SummonerEmblem);
            shop.item[nextSlot++].SetDefaults(ItemID.WarriorEmblem);
        }
    }
}
