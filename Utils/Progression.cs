using System.Linq;

namespace MerchantsPlus;

public static class Progression
{
    public static bool SlimeKing => NPC.downedSlimeKing;
    public static bool EyeOfCthulhu => NPC.downedBoss1;
    public static bool BrainOfCthulhu => NPC.downedBoss2;
    public static bool EaterOfWorlds => NPC.downedBoss2;
    public static bool BrainOrEater => NPC.downedBoss2;
    public static bool QueenBee => NPC.downedQueenBee;
    public static bool Skeletron => NPC.downedBoss3;
    public static bool WallOfFlesh => Main.hardMode;
    public static bool DownedMechs(int amount)
    {
        int downedMechCount = new[] { NPC.downedMechBoss1, NPC.downedMechBoss2, NPC.downedMechBoss3 }.Count(b => b);

        return downedMechCount >= amount;
    }
    public static bool Plantera => NPC.downedPlantBoss;
    public static bool Golem => NPC.downedGolemBoss;
    public static bool Fishron => NPC.downedFishron;
    public static bool Cultist => NPC.downedAncientCultist;
    public static bool TowerSolar => NPC.downedTowerSolar;
    public static bool TowerVortex => NPC.downedTowerVortex;
    public static bool TowerNebula => NPC.downedTowerNebula;
    public static bool TowerStardust => NPC.downedTowerStardust;
    public static bool Towers => NPC.downedTowers;
    public static bool Moonlord => NPC.downedMoonlord;

    public static bool GoblinArmy => NPC.downedGoblins;
    public static bool BloodMoon => NPC.downedClown;
    public static bool Pirates => NPC.downedPirates;
    public static bool Halloween => NPC.downedHalloweenTree || NPC.downedHalloweenKing;
    public static bool Christmas => NPC.downedFrost || NPC.downedChristmasIceQueen || NPC.downedChristmasSantank || NPC.downedChristmasTree;
    public static bool Martians => NPC.downedMartians;

    public static bool Hardmode => Main.hardMode;

    /// <summary>
    /// The players progression, the first 7 levels are prehardmode and the 18 other 
    /// levels are hardmode. (Making a total of 21 progression levels)
    /// </summary>
    /// <returns>The highest progression level (1–21) of the hardest boss defeated, or 0 if none.</returns>
    public static int Level() 
    {
        // Build a list of booleans in order of progression:
        List<bool> conditions =
        [
            SlimeKing,                                 // 1
            EyeOfCthulhu,                              // 2
            GoblinArmy,                                // 3
            BrainOfCthulhu || EaterOfWorlds,           // 4
            QueenBee,                                  // 5
            Skeletron,                                 // 6
            WallOfFlesh,                               // 7
            Pirates,                                   // 8
            BloodMoon,                                 // 9
            DownedMechs(1),                            // 10
            DownedMechs(2),                            // 11
            DownedMechs(3),                            // 12
            Christmas,                                 // 13
            Halloween,                                 // 14
            Plantera,                                  // 15
            Golem,                                     // 16
            Fishron,                                   // 17
            Martians,                                  // 18
            Cultist,                                   // 19
            Towers,                                    // 20
            Moonlord                                   // 21
        ];

        // Walk backward to find the highest true index:
        for (int i = conditions.Count - 1; i >= 0; i--) 
        {
            if (conditions[i])
                return i + 1;    // +1 to convert 0-based index into 1-based level
        }

        // If none are true, return 0 (no progression yet)
        return 0;
    }
}
