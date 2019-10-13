using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Cyborg : GlobalNPC
    {

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Cyborg) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] {"Don't set off those explosives off behind you!",
            "Anything that moves, I see it.",
            "Rocketry is a very delicate task, it requires alot of focus.",
            "Aim. Shoot. Kill.",
            Main.eclipse ? "You are afraid of a mere eclipse?" : "Always keep your wits about you.",
            Main.raining ? "This rain is bad for my circuits." : "A bright day is a good day.",
            Main.hardMode ? "What a good time to be alive." : "This world is weak."});
        }

        

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Cyborg) return;
            attackDelay = 1;
            projType = ProjectileID.RocketIV;
        }

        
    }
}
