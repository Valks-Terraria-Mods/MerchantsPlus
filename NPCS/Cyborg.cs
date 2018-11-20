using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCS
{
    class Cyborg : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.Cyborg)
            {
                npc.lifeMax = 500;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type == NPCID.Cyborg)
            {
                switch (Main.rand.Next(3))
                {
                    case 0:
                        chat = "猫が好きです";
                        break;
                    case 1:
                        chat = "猫は好き？";
                        break;
                    default:
                        chat = "私が猫を撃った銃を売ることができたら、私はそうするだろう";
                        break;
                }
            }
        }

        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.Cyborg) {
                if (NPC.downedGolemBoss)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.ElectrosphereLauncher);
                }

                if (NPC.downedFishron)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.RocketLauncher);
                }

                if (NPC.downedAncientCultist) {
                    shop.item[nextSlot++].SetDefaults(ItemID.SnowmanCannon);
                }

                if (NPC.downedTowerVortex) {
                    shop.item[nextSlot++].SetDefaults(ItemID.NailGun);
                }
                
            }
            
        }
    }
}
