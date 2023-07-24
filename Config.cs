using System.IO;
using Terraria.IO;

namespace MerchantsPlus;

public static class Config
{
    public static double ShopPriceMultiplier
    {
        get => shopPriceMultiplier;
        set => shopPriceMultiplier = value;
    }
    
    public static bool MerchantScaling
    {
        get => merchantScaling;
        set => merchantScaling = value;
    }

    public static bool MerchantExtraLife
    {
        get => merchantExtraLife;
        set => merchantExtraLife = value;
    }

    public static bool MerchantDialog
    {
        get => merchantDialog;
        set => merchantDialog = value;
    }

    public static bool MerchantDrops
    {
        get => merchantDrops;
        set => merchantDrops = value;
    }

    public static bool MerchantProjectiles
    {
        get => merchantProjectiles;
        set => merchantProjectiles = value;
    }

    static double shopPriceMultiplier = 1.0;

    static bool merchantExtraLife;
    static bool merchantDialog = true;
    static bool merchantDrops;
    static bool merchantProjectiles;
    static bool merchantScaling;

    static readonly string ConfigPath = Path.Combine(Main.SavePath, "Mod Configs", "MerchantsPlus.json");
    static readonly Preferences Configuration = new(ConfigPath);

    public static void Load()
    {
        //Reading the config file
        bool success = ReadConfig();

        if (!success)
        {
            MerchantsPlus.Console.Warn("Failed to read Example Mod's config file! Recreating config...");
            CreateConfig();
        }
    }

    //Returns "true" if the config file was found and successfully loaded.
    static bool ReadConfig()
    {
        if (!Configuration.Load())
            return false;

        Configuration.Get("MerchantScaling", ref merchantScaling);
        Configuration.Get("MerchantExtraLife", ref merchantExtraLife);
        Configuration.Get("MerchantDialog", ref merchantDialog);
        Configuration.Get("MerchantDrops", ref merchantDrops);
        Configuration.Get("MerchantProjectiles", ref merchantProjectiles);
        Configuration.Get("ShopPriceMultiplier", ref shopPriceMultiplier);

        return true;
    }

    // Creates a config file. This will only be called if the config file
    // doesn't exist yet or it's invalid.
    static void CreateConfig()
    {
        Configuration.Clear();
        Configuration.Put("MerchantScaling", merchantScaling);
        Configuration.Put("MerchantExtraLife", merchantExtraLife);
        Configuration.Put("MerchantDialog", merchantDialog);
        Configuration.Put("MerchantDrops", merchantDrops);
        Configuration.Put("MerchantProjectiles", merchantProjectiles);
        Configuration.Put("ShopPriceMultiplier", shopPriceMultiplier);
        Configuration.Save();
    }
}