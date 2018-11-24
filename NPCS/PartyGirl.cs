using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class PartyGirl : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.PartyGirl) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 0.8f;
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.PartyGirl) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "PARTY TIME BRUH" ,
                "SWINGIN' MA HEAD BRUH", "GOTTA' LOVE THIS PARTY BRUH"});
        }

        public override void SetupShop(int type, Chest shop, ref int nextSlot) {
            if (type != NPCID.PartyGirl) return;
            shop.item[nextSlot++].SetDefaults(ItemID.MysteriousCape);
            shop.item[nextSlot++].SetDefaults(ItemID.DiamondRing);
            shop.item[nextSlot++].SetDefaults(ItemID.AngelHalo);
            shop.item[nextSlot++].SetDefaults(ItemID.GingerBeard);

            shop.item[nextSlot].SetDefaults(ItemID.Carrot);
            shop.item[nextSlot++].shopCustomPrice = 100000;

            shop.item[nextSlot++].SetDefaults(ItemID.AmberMosquito);
            shop.item[nextSlot++].SetDefaults(ItemID.Fish);
            shop.item[nextSlot++].SetDefaults(ItemID.BoneRattle);
            shop.item[nextSlot++].SetDefaults(ItemID.BoneKey);
            shop.item[nextSlot++].SetDefaults(ItemID.ParrotCracker);
            shop.item[nextSlot++].SetDefaults(ItemID.Seaweed);
            shop.item[nextSlot++].SetDefaults(ItemID.StrangeGlowingMushroom);
            shop.item[nextSlot++].SetDefaults(ItemID.ToySled);

            shop.item[nextSlot].SetDefaults(ItemID.EatersBone);
            shop.item[nextSlot++].shopCustomPrice = 100000;

            shop.item[nextSlot++].SetDefaults(ItemID.Nectar);
            shop.item[nextSlot++].SetDefaults(ItemID.LizardEgg);
            shop.item[nextSlot++].SetDefaults(ItemID.Seedling);
            shop.item[nextSlot++].SetDefaults(ItemID.TikiTotem);
            shop.item[nextSlot++].SetDefaults(ItemID.EyeSpring);
            shop.item[nextSlot++].SetDefaults(ItemID.MagicalPumpkinSeed);
            shop.item[nextSlot++].SetDefaults(ItemID.CursedSapling);
            shop.item[nextSlot++].SetDefaults(ItemID.SpiderEgg);

            shop.item[nextSlot].SetDefaults(ItemID.BabyGrinchMischiefWhistle);
            shop.item[nextSlot++].shopCustomPrice = 100000;

            shop.item[nextSlot++].SetDefaults(ItemID.TartarSauce);
            shop.item[nextSlot++].SetDefaults(ItemID.ZephyrFish);
            shop.item[nextSlot++].SetDefaults(ItemID.CompanionCube);
            shop.item[nextSlot++].SetDefaults(ItemID.DD2PetGato);
        }
    }
}
