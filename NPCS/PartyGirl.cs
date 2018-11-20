using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class PartyGirl : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.PartyGirl)
            {
                npc.lifeMax = 500;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type == NPCID.PartyGirl)
            {
                switch (Main.rand.Next(3))
                {
                    case 0:
                        chat = "PARTY TIME BRUH";
                        break;
                    case 1:
                        chat = "SWINGIN' MA HEAD BRUH";
                        break;
                    default:
                        chat = "GOTTA' LOVE THIS PARTY BRUH";
                        break;
                }
            }
        }

        public override void SetupShop(int type, Chest shop, ref int nextSlot) {
            if (type == NPCID.PartyGirl) {
                shop.item[nextSlot++].SetDefaults(ItemID.WinterCape);
                shop.item[nextSlot++].SetDefaults(ItemID.MysteriousCape);
                shop.item[nextSlot++].SetDefaults(ItemID.RedCape);
                shop.item[nextSlot++].SetDefaults(ItemID.CrimsonCloak);
                shop.item[nextSlot++].SetDefaults(ItemID.DiamondRing);
                shop.item[nextSlot++].SetDefaults(ItemID.AngelHalo);
                shop.item[nextSlot++].SetDefaults(ItemID.GingerBeard);
                shop.item[nextSlot++].SetDefaults(ItemID.Yoraiz0rDarkness);
                shop.item[nextSlot++].SetDefaults(ItemID.LeinforsAccessory);
                shop.item[nextSlot++].SetDefaults(ItemID.PartyBalloonAnimal);
                shop.item[nextSlot++].SetDefaults(ItemID.PartyBundleOfBalloonsAccessory);
            }
        }
    }
}
