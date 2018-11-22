using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Pirate : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.Pirate) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 0.9f;
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Pirate) return;
            chat = Utils.dialog(new string[] { Utils.dialogGift(npc, "Oh ye rich friend? Take a cannonball arr.", "Arrrrr", true, 5, ItemID.Cannonball, 100000),
                "Arr?"});
        }

        public override void SetupShop(int type, Chest shop, ref int nextSlot) {
            if (type != NPCID.Pirate) return;
            shop.item[nextSlot++].SetDefaults(ItemID.RangerEmblem);
            shop.item[nextSlot++].SetDefaults(ItemID.SorcererEmblem);
            shop.item[nextSlot++].SetDefaults(ItemID.SummonerEmblem);
            shop.item[nextSlot++].SetDefaults(ItemID.WarriorEmblem);
        }
    }
}
