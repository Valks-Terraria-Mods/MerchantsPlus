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
    /// <returns>The players progression level.</returns>
    public static int Level()
    {
        List<bool> conditions =
        [
            SlimeKing,
            EyeOfCthulhu,
            GoblinArmy,
            BrainOfCthulhu || EaterOfWorlds,
            QueenBee,
            Skeletron,
            WallOfFlesh,
            Pirates,
            BloodMoon,
            DownedMechs(1),
            DownedMechs(2),
            DownedMechs(3),
            Christmas,
            Halloween,
            Plantera,
            Golem,
            Fishron,
            Martians,
            Cultist,
            Towers,
            Moonlord
        ];

        return conditions.Count(c => c);
    }
}
