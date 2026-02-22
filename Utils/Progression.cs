using System.Linq;

namespace MerchantsPlus;

public static class Progression
{
    private sealed class PreviewScope(int previousLevel) : IDisposable
    {
        private bool _disposed;

        public void Dispose()
        {
            if (_disposed)
            {
                return;
            }

            _previewLevelOverride = previousLevel < 0 ? null : previousLevel;
            _disposed = true;
        }
    }

    private static bool UnlockAllItems => Config.Instance?.UnlockAllItems == true;
    private static int? _previewLevelOverride;

    public static IDisposable PushPreviewLevelOverride(int level)
    {
        int previousLevel = _previewLevelOverride ?? -1;
        _previewLevelOverride = Math.Clamp(level, 0, 21);
        return new PreviewScope(previousLevel);
    }

    private static bool IsUnlockedAt(int requiredLevel, bool worldState)
    {
        if (UnlockAllItems)
        {
            return true;
        }

        if (_previewLevelOverride.HasValue)
        {
            return _previewLevelOverride.Value >= requiredLevel;
        }

        return worldState;
    }

    public static bool SlimeKing => IsUnlockedAt(1, NPC.downedSlimeKing);
    public static bool EyeOfCthulhu => IsUnlockedAt(2, NPC.downedBoss1);
    public static bool BrainOfCthulhu => IsUnlockedAt(4, NPC.downedBoss2);
    public static bool EaterOfWorlds => IsUnlockedAt(4, NPC.downedBoss2);
    public static bool BrainOrEater => IsUnlockedAt(4, NPC.downedBoss2);
    public static bool QueenBee => IsUnlockedAt(5, NPC.downedQueenBee);
    public static bool Skeletron => IsUnlockedAt(6, NPC.downedBoss3);
    public static bool WallOfFlesh => IsUnlockedAt(7, Main.hardMode);
    public static bool DownedMechs(int amount)
    {
        if (UnlockAllItems)
        {
            return true;
        }

        if (_previewLevelOverride.HasValue)
        {
            return _previewLevelOverride.Value >= 9 + amount;
        }

        int downedMechCount = new[] { NPC.downedMechBoss1, NPC.downedMechBoss2, NPC.downedMechBoss3 }.Count(b => b);
        return downedMechCount >= amount;
    }

    public static bool Plantera => IsUnlockedAt(15, NPC.downedPlantBoss);
    public static bool Golem => IsUnlockedAt(16, NPC.downedGolemBoss);
    public static bool Fishron => IsUnlockedAt(17, NPC.downedFishron);
    public static bool Cultist => IsUnlockedAt(19, NPC.downedAncientCultist);
    public static bool TowerSolar => IsUnlockedAt(20, NPC.downedTowerSolar);
    public static bool TowerVortex => IsUnlockedAt(20, NPC.downedTowerVortex);
    public static bool TowerNebula => IsUnlockedAt(20, NPC.downedTowerNebula);
    public static bool TowerStardust => IsUnlockedAt(20, NPC.downedTowerStardust);
    public static bool Towers => IsUnlockedAt(20, NPC.downedTowers);
    public static bool Moonlord => IsUnlockedAt(21, NPC.downedMoonlord);

    public static bool GoblinArmy => IsUnlockedAt(3, NPC.downedGoblins);
    public static bool BloodMoon => IsUnlockedAt(9, NPC.downedClown);
    public static bool Pirates => IsUnlockedAt(8, NPC.downedPirates);
    public static bool Halloween => IsUnlockedAt(14, NPC.downedHalloweenTree || NPC.downedHalloweenKing);
    public static bool Christmas => IsUnlockedAt(13, NPC.downedFrost || NPC.downedChristmasIceQueen || NPC.downedChristmasSantank || NPC.downedChristmasTree);
    public static bool Martians => IsUnlockedAt(18, NPC.downedMartians);

    public static bool Hardmode => IsUnlockedAt(7, Main.hardMode);

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

        if (_previewLevelOverride.HasValue)
        {
            return Math.Clamp(_previewLevelOverride.Value, 0, 21);
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

        if (_previewLevelOverride.HasValue)
        {
            int level = Math.Clamp(_previewLevelOverride.Value, 0, 21);
            return level switch
            {
                >= 21 => 14,
                >= 19 => 13,
                >= 17 => 12,
                >= 16 => 11,
                >= 15 => 10,
                >= 12 => 9,
                >= 11 => 8,
                >= 10 => 7,
                >= 7 => 6,
                >= 6 => 5,
                >= 5 => 4,
                >= 4 => 3,
                >= 2 => 2,
                >= 1 => 1,
                _ => 0
            };
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

    public static string GetLevelFullUnlockHint(int requiredProgression)
    {
        if (UnlockAllItems)
        {
            return "UnlockAllItems is enabled.";
        }

        return requiredProgression switch
        {
            <= 0 => "No progression requirement.",
            1 => "Defeat King Slime.",
            2 => "Defeat Eye of Cthulhu.",
            3 => "Defeat a Goblin Army invasion.",
            4 => "Defeat Eater of Worlds or Brain of Cthulhu.",
            5 => "Defeat Queen Bee.",
            6 => "Defeat Skeletron.",
            7 => "Defeat Wall of Flesh to enter Hardmode.",
            8 => "Defeat a Pirate Invasion.",
            9 => "Defeat a Clown during a Blood Moon.",
            10 => "Defeat one Mechanical Boss.",
            11 => "Defeat a second Mechanical Boss.",
            12 => "Defeat all three Mechanical Bosses.",
            13 => "Defeat a Frost Moon boss.",
            14 => "Defeat a Pumpkin Moon boss.",
            15 => "Defeat Plantera.",
            16 => "Defeat Golem.",
            17 => "Defeat Duke Fishron.",
            18 => "Defeat the Martian Madness event.",
            19 => "Defeat Lunatic Cultist.",
            20 => "Defeat the Celestial Pillars.",
            21 => "Defeat Moon Lord.",
            _ => "Reach later world progression.",
        };
    }
}
