using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    internal class Mechanic : GlobalNPC
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Mechanic) return;
            if (!Config.merchantDialog) return;
            chat = Utils.Dialog(new string[] { "We gotta' fix that pipe ma keeps talking about.",
                "Pa keeps telling me to fix his ol' radio.",
                "Ma won't stop nagging me about that ol' ufo."});
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Mechanic) return;
            attackDelay = 1;
            projType = ProjectileID.MechanicWrench;
            if (Utils.DownedMechBosses() == 1)
            {
                projType = ProjectileID.ExplosiveBunny;
            }
            if (Utils.DownedMechBosses() == 2)
            {
                projType = ProjectileID.BallofFrost;
            }
            if (Utils.DownedMechBosses() == 3)
            {
                projType = ProjectileID.Flamarang;
            }
            if (NPC.downedPlantBoss)
            {
                projType = ProjectileID.IceSickle;
            }
        }
    }
}