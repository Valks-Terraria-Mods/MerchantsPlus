using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Demolitionist : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.Demolitionist) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 0.9f;
        }

        public override void TownNPCAttackCooldown(NPC npc, ref int cooldown, ref int randExtraCooldown)
        {
            if (npc.type != NPCID.Demolitionist) return;
            cooldown = 0;
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Demolitionist) return;
            projType = ProjectileID.Grenade;
            if (NPC.downedSlimeKing)
            {
                projType = ProjectileID.StickyGrenade;
            }
            if (NPC.downedBoss1)
            {
                projType = ProjectileID.BouncyGrenade;
            }
            if (NPC.downedBoss2)
            {
                projType = ProjectileID.HappyBomb;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Demolitionist) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[] { "Modder still working on my dialog." });
        }

        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type != NPCID.Demolitionist) return;
            if (NPC.AnyNPCs(NPCID.PartyGirl))
            {
                shop.item[nextSlot++].SetDefaults(ItemID.PartyGirlGrenade);
            }

            if (NPC.downedSlimeKing)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.StickyGrenade);
                shop.item[nextSlot++].SetDefaults(ItemID.StickyBomb);
                shop.item[nextSlot++].SetDefaults(ItemID.StickyDynamite);
                shop.item[nextSlot++].SetDefaults(ItemID.BouncyGrenade);
                shop.item[nextSlot++].SetDefaults(ItemID.BouncyBomb);
                shop.item[nextSlot++].SetDefaults(ItemID.BouncyDynamite);
            }

            if (NPC.downedBoss1)
            { // eye of chulutu
                shop.item[nextSlot++].SetDefaults(ItemID.Explosives);
            }

            if (NPC.AnyNPCs(NPCID.Angler))
            {
                shop.item[nextSlot++].SetDefaults(ItemID.BombFish);
            }

            if (NPC.downedQueenBee)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.Beenade);
            }

            if (NPC.downedBoss3)
            { // skeletron
                shop.item[nextSlot++].SetDefaults(ItemID.ExplosiveBunny);
            }

            if (NPC.downedClown)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.ExplosiveJackOLantern);
            }

            if (NPC.downedMoonlord)
            {
                shop.item[nextSlot++].SetDefaults(ItemID.LandMine);
            }
        }

    }
}
