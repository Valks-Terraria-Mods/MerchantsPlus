using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus
{
    class AntiVanillaNPCs : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.OldMan)
            {
                npc.lifeMax = 500;
                npc.scale = 0.8f;
            }

            if (npc.type == NPCID.Guide || npc.type == NPCID.TravellingMerchant) {
                npc.lifeMax = 1;
                npc.AddBuff(BuffID.Poisoned, 100000, true);
                npc.friendly = false;
                npc.townNPC = false;
                npc.dontCountMe = true;
                npc.aiStyle = 7;
            }

            /*switch (npc.type)
            {
                case NPCID.Angler:
                case NPCID.ArmsDealer:
                case NPCID.Clothier:
                case NPCID.Cyborg:
                case NPCID.Demolitionist:
                case NPCID.Dryad:
                case NPCID.DyeTrader:
                case NPCID.GoblinTinkerer:
                case NPCID.Guide:
                case NPCID.Mechanic:
                case NPCID.Nurse:
                case NPCID.Painter:
                case NPCID.PartyGirl:
                case NPCID.Pirate:
                case NPCID.SantaClaus:
                case NPCID.SkeletonMerchant:
                case NPCID.Steampunker:
                case NPCID.Stylist:
                case NPCID.DD2Bartender:
                case NPCID.TaxCollector:
                case NPCID.TravellingMerchant:
                case NPCID.Truffle:
                case NPCID.WitchDoctor:
                case NPCID.Wizard:
                case NPCID.BoundGoblin:
                case NPCID.BoundMechanic:
                case NPCID.BoundWizard:
                case NPCID.SleepingAngler:
                    npc.lifeMax = 1;
                    npc.AddBuff(BuffID.Poisoned, 100000, true);
                    npc.friendly = false;
                    npc.townNPC = false;
                    npc.dontCountMe = true;
                    npc.aiStyle = 7;
                    break;
            }*/
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.OldMan) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "You want to fight big pa? Come back at night!" });
        }

        public override void NPCLoot(NPC npc)
        {
            Utils.dropItem(npc, NPCID.OldMan, new short[] { ItemID.Bacon }, 100);
        }
    }
}
