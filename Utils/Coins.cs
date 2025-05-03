namespace MerchantsPlus;

public static class Coins
{
    public static int Copper(int amount = 1) => Combined(amount);
    public static int Silver(int amount = 1) => Combined(0, amount);
    public static int Gold(int amount = 1) => Combined(0, 0, amount);
    public static int Platinum(int amount = 1) => Combined(0, 0, 0, amount);
    public static int Combined(int copper, int silver = 0, int gold = 0, int platinum = 0)
    {
        return copper + silver * SILVER + gold * GOLD + platinum * PLATINUM * (int)Config.Instance.ShopPriceMultiplier;
    }

    private const int SILVER = 100;
    private const int GOLD = 10000;
    private const int PLATINUM = 1000000;
}
