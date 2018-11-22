using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Clothier : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.Clothier)
                if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 0.7f;
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Clothier) return;
            chat = Utils.dialog(new string[] {"Hi :(",
            "T-shirts man, no one ever buys them. ;(",
            "Would you care to buy a pair of pants? :("});
        }

        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type != NPCID.Clothier) return;
            if (NPC.downedSlimeKing)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.EyePatch);
                shop.item[nextSlot++].SetDefaults(ItemID.PlatinumCrown);
            }

            if (NPC.downedBoss1)
            { // eye
                shop.item[nextSlot++].SetDefaults(ItemID.Sunglasses);
            }

            if (NPC.downedBoss2)
            { //worm / brain
                shop.item[nextSlot++].SetDefaults(ItemID.GuyFawkesMask);
            }

            if (NPC.downedBoss3)
            { // skeletron
                shop.item[nextSlot++].SetDefaults(ItemID.ReindeerAntlers);
            }

            if (Main.hardMode)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.ReaperRobe);
                shop.item[nextSlot++].SetDefaults(ItemID.ReaperHood);
            }

            if (NPC.downedMechBossAny)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.SpaceCreaturePants);
                shop.item[nextSlot++].SetDefaults(ItemID.SpaceCreatureShirt);
                shop.item[nextSlot++].SetDefaults(ItemID.SpaceCreatureMask);
            }

            if (NPC.downedPlantBoss)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.BunnyHood);
            }

            if (Main.raining)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.CrownosLeggings);
                shop.item[nextSlot++].SetDefaults(ItemID.CrownosBreastplate);
                shop.item[nextSlot++].SetDefaults(ItemID.CrownosMask);
            }

            if (Main.bloodMoon)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.CenxsDressPants);
                shop.item[nextSlot++].SetDefaults(ItemID.CenxsLeggings);
                shop.item[nextSlot++].SetDefaults(ItemID.CenxsDress);
                shop.item[nextSlot++].SetDefaults(ItemID.CenxsBreastplate);
                shop.item[nextSlot++].SetDefaults(ItemID.CenxsTiara);
            }

            if (Main.eclipse)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.JimsLeggings);
                shop.item[nextSlot++].SetDefaults(ItemID.JimsBreastplate);
                shop.item[nextSlot++].SetDefaults(ItemID.JimsHelmet);
            }

            if (Main.dayTime)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.ArkhalisPants);
                shop.item[nextSlot++].SetDefaults(ItemID.ArkhalisShirt);
                shop.item[nextSlot++].SetDefaults(ItemID.ArkhalisHat);
            }
            else
            {
                shop.item[nextSlot++].SetDefaults(ItemID.LokisPants);
                shop.item[nextSlot++].SetDefaults(ItemID.LokisShirt);
                shop.item[nextSlot++].SetDefaults(ItemID.LokisHelm);
            }

            if (Main.hardMode)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.LeinforsPants);
                shop.item[nextSlot++].SetDefaults(ItemID.LeinforsShirt);
                shop.item[nextSlot++].SetDefaults(ItemID.LeinforsHat);
                shop.item[nextSlot++].SetDefaults(ItemID.LeinforsAccessory);
            }
        }
    }
}
