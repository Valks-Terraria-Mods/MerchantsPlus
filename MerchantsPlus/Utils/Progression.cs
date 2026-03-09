using System.Linq;

namespace MerchantsPlus;

public static class Progression
{
    public enum FullLevel
    {
        None = 0,
        SlimeKing = 1,
        EyeOfCthulhu = 2,
        GoblinArmy = 3,
        BrainOrEater = 4,
        QueenBee = 5,
        Skeletron = 6,
        WallOfFlesh = 7,
        Pirates = 8,
        BloodMoonClown = 9,
        FirstMechanicalBoss = 10,
        SecondMechanicalBoss = 11,
        AllMechanicalBosses = 12,
        Christmas = 13,
        Halloween = 14,
        Plantera = 15,
        Golem = 16,
        Fishron = 17,
        Martians = 18,
        Cultist = 19,
        Towers = 20,
        Moonlord = 21
    }

    public enum BossLevel
    {
        None = 0,
        SlimeKing = 1,
        EyeOfCthulhu = 2,
        BrainOrEater = 3,
        QueenBee = 4,
        Skeletron = 5,
        WallOfFlesh = 6,
        FirstMechanicalBoss = 7,
        SecondMechanicalBoss = 8,
        AllMechanicalBosses = 9,
        Plantera = 10,
        Golem = 11,
        Fishron = 12,
        Cultist = 13,
        Moonlord = 14
    }

    private const int MinFullLevel = (int)FullLevel.None;
    private const int MaxFullLevel = (int)FullLevel.Moonlord;
    private const int MechanicalBossPreviewBaseLevel = (int)FullLevel.BloodMoonClown;

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

    private static FullLevel ClampFullLevel(int level) => (FullLevel)Math.Clamp(level, MinFullLevel, MaxFullLevel);

    public static IDisposable PushPreviewLevelOverride(int level)
    {
        int previousLevel = _previewLevelOverride ?? -1;
        _previewLevelOverride = (int)ClampFullLevel(level);
        return new PreviewScope(previousLevel);
    }

    private static bool IsUnlockedAt(FullLevel requiredLevel, bool worldState) => IsUnlockedAt((int)requiredLevel, worldState);

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

    public static bool SlimeKing => IsUnlockedAt(FullLevel.SlimeKing, NPC.downedSlimeKing);
    public static bool EyeOfCthulhu => IsUnlockedAt(FullLevel.EyeOfCthulhu, NPC.downedBoss1);
    public static bool BrainOfCthulhu => IsUnlockedAt(FullLevel.BrainOrEater, NPC.downedBoss2);
    public static bool EaterOfWorlds => IsUnlockedAt(FullLevel.BrainOrEater, NPC.downedBoss2);
    public static bool BrainOrEater => IsUnlockedAt(FullLevel.BrainOrEater, NPC.downedBoss2);
    public static bool QueenBee => IsUnlockedAt(FullLevel.QueenBee, NPC.downedQueenBee);
    public static bool Skeletron => IsUnlockedAt(FullLevel.Skeletron, NPC.downedBoss3);
    public static bool WallOfFlesh => IsUnlockedAt(FullLevel.WallOfFlesh, Main.hardMode);
    public static bool DownedMechs(int amount)
    {
        if (UnlockAllItems)
        {
            return true;
        }

        if (_previewLevelOverride.HasValue)
        {
            return _previewLevelOverride.Value >= MechanicalBossPreviewBaseLevel + amount;
        }

        int downedMechCount = new[] { NPC.downedMechBoss1, NPC.downedMechBoss2, NPC.downedMechBoss3 }.Count(b => b);
        return downedMechCount >= amount;
    }

    public static bool Plantera => IsUnlockedAt(FullLevel.Plantera, NPC.downedPlantBoss);
    public static bool Golem => IsUnlockedAt(FullLevel.Golem, NPC.downedGolemBoss);
    public static bool Fishron => IsUnlockedAt(FullLevel.Fishron, NPC.downedFishron);
    public static bool Cultist => IsUnlockedAt(FullLevel.Cultist, NPC.downedAncientCultist);
    public static bool TowerSolar => IsUnlockedAt(FullLevel.Towers, NPC.downedTowerSolar);
    public static bool TowerVortex => IsUnlockedAt(FullLevel.Towers, NPC.downedTowerVortex);
    public static bool TowerNebula => IsUnlockedAt(FullLevel.Towers, NPC.downedTowerNebula);
    public static bool TowerStardust => IsUnlockedAt(FullLevel.Towers, NPC.downedTowerStardust);
    public static bool Towers => IsUnlockedAt(FullLevel.Towers, NPC.downedTowers);
    public static bool Moonlord => IsUnlockedAt(FullLevel.Moonlord, NPC.downedMoonlord);

    public static bool GoblinArmy => IsUnlockedAt(FullLevel.GoblinArmy, NPC.downedGoblins);
    public static bool BloodMoon => IsUnlockedAt(FullLevel.BloodMoonClown, NPC.downedClown);
    public static bool Pirates => IsUnlockedAt(FullLevel.Pirates, NPC.downedPirates);
    public static bool Halloween => IsUnlockedAt(FullLevel.Halloween, NPC.downedHalloweenTree || NPC.downedHalloweenKing);
    public static bool Christmas => IsUnlockedAt(FullLevel.Christmas, NPC.downedFrost || NPC.downedChristmasIceQueen || NPC.downedChristmasSantank || NPC.downedChristmasTree);
    public static bool Martians => IsUnlockedAt(FullLevel.Martians, NPC.downedMartians);

    public static bool Hardmode => IsUnlockedAt(FullLevel.WallOfFlesh, Main.hardMode);

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
            return MaxFullLevel;
        }

        if (_previewLevelOverride.HasValue)
        {
            return (int)ClampFullLevel(_previewLevelOverride.Value);
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
            return (int)BossLevel.Moonlord;
        }

        if (_previewLevelOverride.HasValue)
        {
            int level = (int)ClampFullLevel(_previewLevelOverride.Value);
            return level switch
            {
                >= (int)FullLevel.Moonlord => (int)BossLevel.Moonlord,
                >= (int)FullLevel.Cultist => (int)BossLevel.Cultist,
                >= (int)FullLevel.Fishron => (int)BossLevel.Fishron,
                >= (int)FullLevel.Golem => (int)BossLevel.Golem,
                >= (int)FullLevel.Plantera => (int)BossLevel.Plantera,
                >= (int)FullLevel.AllMechanicalBosses => (int)BossLevel.AllMechanicalBosses,
                >= (int)FullLevel.SecondMechanicalBoss => (int)BossLevel.SecondMechanicalBoss,
                >= (int)FullLevel.FirstMechanicalBoss => (int)BossLevel.FirstMechanicalBoss,
                >= (int)FullLevel.WallOfFlesh => (int)BossLevel.WallOfFlesh,
                >= (int)FullLevel.Skeletron => (int)BossLevel.Skeletron,
                >= (int)FullLevel.QueenBee => (int)BossLevel.QueenBee,
                >= (int)FullLevel.BrainOrEater => (int)BossLevel.BrainOrEater,
                >= (int)FullLevel.EyeOfCthulhu => (int)BossLevel.EyeOfCthulhu,
                >= (int)FullLevel.SlimeKing => (int)BossLevel.SlimeKing,
                _ => (int)BossLevel.None
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
        if (requiredProgression <= MinFullLevel)
        {
            return GetLevelFullUnlockHint(FullLevel.None);
        }

        if (requiredProgression > MaxFullLevel)
        {
            return "Reach later world progression.";
        }

        return GetLevelFullUnlockHint((FullLevel)requiredProgression);
    }

    public static string GetLevelFullUnlockHint(FullLevel requiredProgression)
    {
        if (UnlockAllItems)
        {
            return "UnlockAllItems is enabled.";
        }

        return requiredProgression switch
        {
            FullLevel.None => "No progression requirement.",
            FullLevel.SlimeKing => "Defeat King Slime.",
            FullLevel.EyeOfCthulhu => "Defeat Eye of Cthulhu.",
            FullLevel.GoblinArmy => "Defeat a Goblin Army invasion.",
            FullLevel.BrainOrEater => "Defeat Eater of Worlds or Brain of Cthulhu.",
            FullLevel.QueenBee => "Defeat Queen Bee.",
            FullLevel.Skeletron => "Defeat Skeletron.",
            FullLevel.WallOfFlesh => "Defeat Wall of Flesh to enter Hardmode.",
            FullLevel.Pirates => "Defeat a Pirate Invasion.",
            FullLevel.BloodMoonClown => "Defeat a Clown during a Blood Moon.",
            FullLevel.FirstMechanicalBoss => "Defeat one Mechanical Boss.",
            FullLevel.SecondMechanicalBoss => "Defeat a second Mechanical Boss.",
            FullLevel.AllMechanicalBosses => "Defeat all three Mechanical Bosses.",
            FullLevel.Christmas => "Defeat a Frost Moon boss.",
            FullLevel.Halloween => "Defeat a Pumpkin Moon boss.",
            FullLevel.Plantera => "Defeat Plantera.",
            FullLevel.Golem => "Defeat Golem.",
            FullLevel.Fishron => "Defeat Duke Fishron.",
            FullLevel.Martians => "Defeat the Martian Madness event.",
            FullLevel.Cultist => "Defeat Lunatic Cultist.",
            FullLevel.Towers => "Defeat the Celestial Pillars.",
            FullLevel.Moonlord => "Defeat Moon Lord.",
            _ => "Reach later world progression.",
        };
    }
}
