namespace MerchantsPlus;

public static class WorldUtils
{
    public static bool HasNpc(int npcId) => NPC.AnyNPCs(npcId);
    public static int Kills(short theNpc) => NPC.killCount[Item.NPCtoBanner(theNpc)];

    public static int MultiKills(short[] npcs)
    {
        int kills = 0;
        
        for (int i = 0; i < npcs.Length; i++)
        {
            kills += NPC.killCount[Item.NPCtoBanner(i)];
        }
        
        return kills;
    }

    public static bool IsNpcHere(short npc)
    {
        int theNpc = NPC.FindFirstNPC(npc);
        return theNpc >= 0;
    }
}