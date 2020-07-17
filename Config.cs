using System.IO;
using Terraria;
using Terraria.IO;

namespace MerchantsPlus
{
    public static class Config
    {
        public static bool MerchantScaling = false;
        public static bool MerchantExtraLife = false;
        public static bool MerchantDialog = false;
        public static bool MerchantDrops = false;
        public static bool MerchantProjectiles = false;

        private static readonly string ConfigPath = Path.Combine(Main.SavePath, "Mod Configs", "MerchantsPlus.json");
        private static Preferences Configuration = new Preferences(ConfigPath);

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
        private static bool ReadConfig()
        {
            if (Configuration.Load())
            {
                Configuration.Get("MerchantScaling", ref MerchantScaling);
                Configuration.Get("MerchantExtraLife", ref MerchantExtraLife);
                Configuration.Get("MerchantDialog", ref MerchantDialog);
                Configuration.Get("MerchantDrops", ref MerchantDrops);
                Configuration.Get("MerchantProjectiles", ref MerchantProjectiles);
                return true;
            }
            return false;
        }

        //Creates a config file. This will only be called if the config file doesn't exist yet or it's invalid.
        private static void CreateConfig()
        {
            Configuration.Clear();
            Configuration.Put("MerchantScaling", MerchantScaling);
            Configuration.Put("MerchantExtraLife", MerchantExtraLife);
            Configuration.Put("MerchantDialog", MerchantDialog);
            Configuration.Put("MerchantDrops", MerchantDrops);
            Configuration.Put("MerchantProjectiles", MerchantProjectiles);
            Configuration.Save();
        }
    }
}