using System.IO;
using Terraria;
using Terraria.IO;

namespace MerchantsPlus
{
    public static class Config
    {
        public static bool merchantScaling = false;
        public static bool merchantExtraLife = false;
        public static bool merchantDialog = false;

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
                Configuration.Get("MerchantScaling", ref merchantScaling);
                Configuration.Get("MerchantExtraLife", ref merchantExtraLife);
                Configuration.Get("MerchantDialog", ref merchantDialog);
                return true;
            }
            return false;
        }

        //Creates a config file. This will only be called if the config file doesn't exist yet or it's invalid.
        private static void CreateConfig()
        {
            Configuration.Clear();
            Configuration.Put("MerchantScaling", merchantScaling);
            Configuration.Put("MerchantExtraLife", merchantExtraLife);
            Configuration.Put("MerchantDialog", merchantDialog);
            Configuration.Save();
        }
    }
}