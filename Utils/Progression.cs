using System.Linq;

namespace MerchantsPlus;

public static class Progression
{
    private static bool UnlockAllItems => Config.Instance?.UnlockAllItems == true;

    public static bool SlimeKing => UnlockAllItems || NPC.downedSlimeKing;
    public static bool EyeOfCthulhu => UnlockAllItems || NPC.downedBoss1;
    public static bool BrainOfCthulhu => UnlockAllItems || NPC.downedBoss2;
    public static bool EaterOfWorlds => UnlockAllItems || NPC.downedBoss2;
    public static bool BrainOrEater => UnlockAllItems || NPC.downedBoss2;
    public static bool QueenBee => UnlockAllItems || NPC.downedQueenBee;
    public static bool Skeletron => UnlockAllItems || NPC.downedBoss3;
    public static bool WallOfFlesh => UnlockAllItems || Main.hardMode;
    public static bool DownedMechs(int amount)
    {
        if (UnlockAllItems)
        {
            return true;
        }

        int downedMechCount = new[] { NPC.downedMechBoss1, NPC.downedMechBoss2, NPC.downedMechBoss3 }.Count(b => b);
        return downedMechCount >= amount;
    }

    public static bool Plantera => UnlockAllItems || NPC.downedPlantBoss;
    public static bool Golem => UnlockAllItems || NPC.downedGolemBoss;
    public static bool Fishron => UnlockAllItems || NPC.downedFishron;
    public static bool Cultist => UnlockAllItems || NPC.downedAncientCultist;
    public static bool TowerSolar => UnlockAllItems || NPC.downedTowerSolar;
    public static bool TowerVortex => UnlockAllItems || NPC.downedTowerVortex;
    public static bool TowerNebula => UnlockAllItems || NPC.downedTowerNebula;
    public static bool TowerStardust => UnlockAllItems || NPC.downedTowerStardust;
    public static bool Towers => UnlockAllItems || NPC.downedTowers;
    public static bool Moonlord => UnlockAllItems || NPC.downedMoonlord;

    public static bool GoblinArmy => UnlockAllItems || NPC.downedGoblins;
    public static bool BloodMoon => UnlockAllItems || NPC.downedClown;
    public static bool Pirates => UnlockAllItems || NPC.downedPirates;
    public static bool Halloween => UnlockAllItems || NPC.downedHalloweenTree || NPC.downedHalloweenKing;
    public static bool Christmas => UnlockAllItems || NPC.downedFrost || NPC.downedChristmasIceQueen || NPC.downedChristmasSantank || NPC.downedChristmasTree;
    public static bool Martians => UnlockAllItems || NPC.downedMartians;

    public static bool Hardmode => UnlockAllItems || Main.hardMode;

    private static int GetHighestProgressionLevel(bool[] conditions)
    {
        for (int i = conditions.Length - 1; i >= 0; i--)
        {
            if (conditions[i])
            {
                return i + 1; // +1 converts a 0-based index into a 1-based level.
            }
        }

        // If none are true, return 0 (no progression yet).
        return 0;
    }

    /// <summary>
    /// The players progression, the first 7 levels are prehardmode and the 18 other
    /// levels are hardmode. (Making a total of 21 progression levels)
    /// </summary>
    /// <returns>The highest progression level (1-21) of the hardest boss defeated, or 0 if none.</returns>
    public static int LevelFull()
    {
        if (UnlockAllItems)
        {
            return 21;
        }

        bool[] conditions =
        [
            SlimeKing,                       // 1
            EyeOfCthulhu,                    // 2
            GoblinArmy,                      // 3
            BrainOfCthulhu || EaterOfWorlds, // 4
            QueenBee,                        // 5
            Skeletron,                       // 6
            WallOfFlesh,                     // 7
            Pirates,                         // 8
            BloodMoon,                       // 9
            DownedMechs(1),                  // 10
            DownedMechs(2),                  // 11
            DownedMechs(3),                  // 12
            Christmas,                       // 13
            Halloween,                       // 14
            Plantera,                        // 15
            Golem,                           // 16
            Fishron,                         // 17
            Martians,                        // 18
            Cultist,                         // 19
            Towers,                          // 20
            Moonlord                         // 21
        ];

        return GetHighestProgressionLevel(conditions);
    }

    public static int LevelBoss()
    {
        if (UnlockAllItems)
        {
            return 14;
        }

        bool[] conditions =
        [
            SlimeKing,                       // 1
            EyeOfCthulhu,                    // 2
            BrainOfCthulhu || EaterOfWorlds, // 3
            QueenBee,                        // 4
            Skeletron,                       // 5
            WallOfFlesh,                     // 6
            DownedMechs(1),                  // 7
            DownedMechs(2),                  // 8
            DownedMechs(3),                  // 9
            Plantera,                        // 10
            Golem,                           // 11
            Fishron,                         // 12
            Cultist,                         // 13
            Moonlord                         // 14
        ];

        return GetHighestProgressionLevel(conditions);
    }
}
