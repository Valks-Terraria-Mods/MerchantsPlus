using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Clothier : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.Clothier) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 0.7f;
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Clothier) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] {"There's one thing I like about this world is that you can sit back and relax and make clothes.",
            "Ah peace and quiet.",
            "One day I'll make the most beautiful piece of clothing ever laid eyes on.",
            "Oh you're back for more? I've got a big selection for you.",
            "This red hat really suits me well!",
            "I love hearing the birds in the early morning. It's just so peaceful.",
            "I always dreamed of living on the beach.",
            "Just.. so.. peaceful..",
            Main.dayTime ? "The sunshine is upon us!" : "I don't really like that it's so dark outside..",
            Main.hardMode ? "You know the world use to be very peaceful, not it seems very stirred up." : "The world is very calm right now, I like it.",
            Main.raining ? "Rain is so noisy, not my kind of day.." : "At least it's not raining!",
            Main.eclipse ? "I'm so scared!" : "I don't think I'm afraid of anything. Why do you ask?",
            "I hope you like the clothes I have on sale today, come back tomorrow and I'll have different clothes to sell!",
            "I get the job done, if it's a shoe, a hat, it's no problem for me.",
            "Me? Make a shirt for you? That's not a problem for me! I'll get right on it!",
            "I could teach you how to make your own clothes! All you need is a few materials I have in my shop!"});
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
                shop.item[nextSlot].SetDefaults(ItemID.CenxsDressPants);
                shop.item[nextSlot++].shopCustomPrice = 100000;

                shop.item[nextSlot].SetDefaults(ItemID.CenxsLeggings);
                shop.item[nextSlot++].shopCustomPrice = 100000;

                shop.item[nextSlot].SetDefaults(ItemID.CenxsDress);
                shop.item[nextSlot++].shopCustomPrice = 100000;

                shop.item[nextSlot].SetDefaults(ItemID.CenxsBreastplate);
                shop.item[nextSlot++].shopCustomPrice = 100000;

                shop.item[nextSlot].SetDefaults(ItemID.CenxsTiara);
                shop.item[nextSlot++].shopCustomPrice = 100000;
            }

            if (Main.eclipse)
            {
                shop.item[nextSlot].SetDefaults(ItemID.JimsLeggings);
                shop.item[nextSlot++].shopCustomPrice = 100000;

                shop.item[nextSlot].SetDefaults(ItemID.JimsBreastplate);
                shop.item[nextSlot++].shopCustomPrice = 100000;

                shop.item[nextSlot].SetDefaults(ItemID.JimsHelmet);
                shop.item[nextSlot++].shopCustomPrice = 100000;
            }

            if (Main.dayTime)
            {
                shop.item[nextSlot].SetDefaults(ItemID.ArkhalisPants);
                shop.item[nextSlot++].shopCustomPrice = 100000;

                shop.item[nextSlot].SetDefaults(ItemID.ArkhalisShirt);
                shop.item[nextSlot++].shopCustomPrice = 100000;

                shop.item[nextSlot].SetDefaults(ItemID.ArkhalisHat);
                shop.item[nextSlot++].shopCustomPrice = 100000;
            }
            else
            {
                shop.item[nextSlot].SetDefaults(ItemID.LokisPants);
                shop.item[nextSlot++].shopCustomPrice = 100000;

                shop.item[nextSlot].SetDefaults(ItemID.LokisShirt);
                shop.item[nextSlot++].shopCustomPrice = 100000;

                shop.item[nextSlot].SetDefaults(ItemID.LokisHelm);
                shop.item[nextSlot++].shopCustomPrice = 100000;
            }

            if (Main.hardMode)
            {
                shop.item[nextSlot].SetDefaults(ItemID.LeinforsPants);
                shop.item[nextSlot++].shopCustomPrice = 100000;

                shop.item[nextSlot].SetDefaults(ItemID.LeinforsShirt);
                shop.item[nextSlot++].shopCustomPrice = 100000;

                shop.item[nextSlot].SetDefaults(ItemID.LeinforsHat);
                shop.item[nextSlot++].shopCustomPrice = 100000;

                shop.item[nextSlot].SetDefaults(ItemID.LeinforsAccessory);
                shop.item[nextSlot++].shopCustomPrice = 100000;
            }
        }
    }
}
