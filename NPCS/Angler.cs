using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class Angler : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type != NPCID.Angler) return;
            if (Config.merchantExtraLife) npc.lifeMax = 500;
            if (Config.merchantScaling) npc.scale = 0.8f;
        }

        public override void TownNPCAttackCooldown(NPC npc, ref int cooldown, ref int randExtraCooldown)
        {
            if (npc.type != NPCID.Angler) return;
            cooldown = 0;
        }

        public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
        {
            if (npc.type != NPCID.Angler) return;
            projType = ProjectileID.FrostDaggerfish;
            if (NPC.downedSlimeKing) {
                projType = ProjectileID.IceSickle;
            }
            if (NPC.downedBoss1) {
                projType = ProjectileID.Blizzard;
            }
            if (NPC.downedBoss2) {
                projType = ProjectileID.InfluxWaver;
            }
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Angler) return;
            if (!Config.merchantDialog) return;
            chat = Utils.dialog(new string[]{"Hey want to do a contest? Whoever gets the most fish wins!",
            "I have more fish than you will ever have in a lifetime!",
            "Did you hear? There's a big monster in the sea and one day I'm going to release him on you. ;)",
            "The bigger the fish the better.",
            "Can't wait to see what you caught today!",
            "Oh you're back for more? Were just getting started!",
            "I wish I was the ultimate fish with the ultimate powers.",
            "Don't talk to me about anything else besides fish!",
            "Not now, I'm thinking of another quest for you! Eeek!",
            "Fish are so rare these days!",
            "Oh what did you catch today?!",
            "Is that for me?!",
            "Is that a fish you got there?",
            "Don't really like sharks but other than that I like every other fish!",
            "Sometimes the sea glares at me..",
            "Sometimes that sea scares me, I don't know why.",
            "I wonder what's at the bottom of the ocean.. FISH OF COURSE!",
            "You got a fish in your inventory, I'm a physic.",
            "No fish will ever get me alive!",
            "I am the fastest swimmer!",
            "Are you getting tired yet? Don't stop now, we have to get more fish!"});
        }

        public override void NPCLoot(NPC npc)
        {
            Utils.dropItem(npc, NPCID.Angler, new short[] { ItemID.IronBow }, 25);
        }
    }
}
