using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class SantaClaus : GlobalNPC
    {


        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.SantaClaus) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "HOHOHOOOOOHOOOOOO",
                "HOOOOOOOO HOOOOOO HOOOOOOOO",
                "You were a good lil' kid wern't ya buddy? HOOOOOOOOO HOOOOOOO HOOOOOOOOOO",
                "HOOOOOOOOOOOOOOOO HOOOOOOOOOOOO HOOOOOOOOOOOOO"});
        }

       

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.SantaClaus) return;
            attackDelay = 1;
            projType = ProjectileID.SantaBombs;
        }

        
    }
}
