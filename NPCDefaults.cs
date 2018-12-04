using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus
{
    class NPCDefaults : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            switch (npc.type)
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
                case NPCID.OldMan:
                case NPCID.BoundGoblin:
                case NPCID.BoundMechanic:
                case NPCID.BoundWizard:
                case NPCID.SleepingAngler:
                    if (Config.merchantScaling) npc.scale = 0.9f;
                    if (Config.merchantExtraLife) npc.lifeMax = 500;
                    break;
            }
        }

        public override void DrawEffects(NPC npc, ref Color drawColor) {
            switch (npc.type) {
                case NPCID.BoundGoblin:
                case NPCID.BoundMechanic:
                case NPCID.BoundWizard:
                    Lighting.AddLight(npc.position, new Vector3(1, 1, 1));
                    break;
            }
        }
    }
}
