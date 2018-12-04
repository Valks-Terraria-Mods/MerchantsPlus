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
            chat = Utils.dialog(new string[] {"Don't set off those explosives off I have behind you.",
            "Anything that moves in the sky, I see it.",
            "Rocketry is a very delicate task, it requires alot of focus.",
            "Aim. Shoot. Kill.",
            Main.eclipse ? "Are you afraid of a mere eclipse? I'm not!" : "Always keep your wits about you.",
            Main.raining ? "This rain is bad for my circuits." : "A bright day is my day.",
            Main.hardMode ? "The world feels a lot more tougher than it use to be." : "This world is weak."});
        }

        

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Cyborg) return;
            attackDelay = 1;
            projType = ProjectileID.BouncyGrenade;
        }

        
    }
}
