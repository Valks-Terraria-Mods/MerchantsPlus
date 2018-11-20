using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class GoblinTinkerer : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.GoblinTinkerer)
            {
                npc.lifeMax = 500;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type == NPCID.GoblinTinkerer)
            {
                switch (Main.rand.Next(3))
                {
                    case 0:
                        chat = "Were going to mod your gear right up baby. :)";
                        break;
                    case 1:
                        chat = "I got all the modifications you will ever need. >:)";
                        break;
                    default:
                        chat = "Did someone call for a modder? >:D";
                        break;
                }
            }
        }
        public override void SetupShop(int type, Chest shop, ref int nextSlot) {
            if (type == NPCID.GoblinTinkerer) {
                if (NPC.downedSlimeKing) {
                    if (Utils.kills(NPCID.BlueSlime) > 100) shop.item[nextSlot++].SetDefaults(ItemID.Aglet);
                    if (Utils.kills(NPCID.RedSlime) > 100) shop.item[nextSlot++].SetDefaults(ItemID.AnkletoftheWind);
                    if (Utils.kills(NPCID.PurpleSlime) > 100) shop.item[nextSlot++].SetDefaults(ItemID.Shackle);
                }
                if (NPC.downedBoss1) {
                    if (Utils.kills(NPCID.DemonEye) > 100) shop.item[nextSlot++].SetDefaults(ItemID.CloudinaBottle);
                    if (Utils.kills(NPCID.DemonEye2) > 100) shop.item[nextSlot++].SetDefaults(ItemID.SandstorminaBottle);
                    if (Utils.kills(NPCID.Zombie) > 100) shop.item[nextSlot++].SetDefaults(ItemID.BlizzardinaBottle);
                }

                if (NPC.downedBoss2) {
                    if (Utils.kills(NPCID.Zombie) > 150) shop.item[nextSlot++].SetDefaults(ItemID.ClimbingClaws);
                    if (Utils.kills(NPCID.PinkJellyfish) > 50) shop.item[nextSlot++].SetDefaults(ItemID.Flipper);
                    if (Utils.kills(NPCID.Antlion) > 50) shop.item[nextSlot++].SetDefaults(ItemID.FlyingCarpet);
                    if (Utils.kills(NPCID.BlueJellyfish) > 50) shop.item[nextSlot++].SetDefaults(ItemID.FrogLeg);
                }

                if (NPC.downedBoss3) {
                    shop.item[nextSlot++].SetDefaults(ItemID.HermesBoots);
                    shop.item[nextSlot++].SetDefaults(ItemID.IceSkates);
                    shop.item[nextSlot++].SetDefaults(ItemID.LavaCharm);
                    shop.item[nextSlot++].SetDefaults(ItemID.LuckyHorseshoe);
                    shop.item[nextSlot++].SetDefaults(ItemID.ShinyRedBalloon);
                }

                if (NPC.downedMechBoss1) {
                    shop.item[nextSlot++].SetDefaults(ItemID.Tabi);
                    shop.item[nextSlot++].SetDefaults(ItemID.BlackBelt);
                    shop.item[nextSlot++].SetDefaults(ItemID.MoonCharm);
                    shop.item[nextSlot++].SetDefaults(ItemID.CobaltShield);
                }

                if (NPC.downedMechBoss2) {
                    shop.item[nextSlot++].SetDefaults(ItemID.FleshKnuckles);
                    shop.item[nextSlot++].SetDefaults(ItemID.FrozenTurtleShell);
                    shop.item[nextSlot++].SetDefaults(ItemID.HandWarmer);
                    shop.item[nextSlot++].SetDefaults(ItemID.HoneyComb);
                }

                if (NPC.downedMechBoss3) {
                    shop.item[nextSlot++].SetDefaults(ItemID.MagmaStone);
                    shop.item[nextSlot++].SetDefaults(ItemID.PaladinsShield);
                    shop.item[nextSlot++].SetDefaults(ItemID.PutridScent);
                    
                }

                if (NPC.downedPlantBoss) {
                    shop.item[nextSlot++].SetDefaults(ItemID.SharkToothNecklace);
                    shop.item[nextSlot++].SetDefaults(ItemID.StarCloak);
                    shop.item[nextSlot++].SetDefaults(ItemID.SunStone);
                    shop.item[nextSlot++].SetDefaults(ItemID.TitanGlove);
                    shop.item[nextSlot++].SetDefaults(ItemID.DiscountCard);
                    shop.item[nextSlot++].SetDefaults(ItemID.JellyfishNecklace);
                    shop.item[nextSlot++].SetDefaults(ItemID.LuckyCoin);
                    shop.item[nextSlot++].SetDefaults(ItemID.NeptunesShell);
                }
                
            }
        }
    }
}
