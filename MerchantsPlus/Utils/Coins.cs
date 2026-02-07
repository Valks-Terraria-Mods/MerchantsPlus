namespace MerchantsPlus;

public static class Coins
{
    public static int Copper(int amount = 1) => Combined(amount);
    public static int Silver(int amount = 1) => Combined(0, amount);
    public static int Gold(int amount = 1) => Combined(0, 0, amount);
    public static int Platinum(int amount = 1) => Combined(0, 0, 0, amount);

    private static int Combined(int copper, int silver = 0, int gold = 0, int platinum = 0)
    {
        const int copperPerSilver = 100;
        const int copperPerGold = 10000;
        const int copperPerPlatinum = 1000000;
        return copper + silver * copperPerSilver + gold * copperPerGold + platinum * copperPerPlatinum * (int)Config.Instance.ShopPriceMultiplier;
    }
}
