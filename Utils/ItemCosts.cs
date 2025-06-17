namespace MerchantsPlus;

public static class ItemCosts
{
    public static int Potions     { get; } = Coins.Gold(1);
    public static int Accessories { get; } = Coins.Gold(1);
    public static int Ores        { get; } = Coins.Gold(1);
    public static int Pets        { get; } = Coins.Gold(1);
    public static int Mounts      { get; } = Coins.Gold(5);
    public static int Vanity      { get; } = Coins.Gold(1);
    public static int Seeds       { get; } = Coins.Gold(1);
    public static int Dyes        { get; } = Coins.Gold(1);
}
