using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Pirate : GlobalNPC
    {


        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Pirate) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { Utils.dialogGift(npc, "Oh ye rich friend? Take a cannonball arr.", "Arrrrr", true, 5, ItemID.Cannonball, 100000),
                "Arr?"});
        }

        
        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Pirate) return;
            attackDelay = 1;
            projType = ProjectileID.Bullet;
            if (Utils.downedMechBosses() == 1)
            {
                projType = ProjectileID.CannonballFriendly;
            }
        }

        
    }
}
