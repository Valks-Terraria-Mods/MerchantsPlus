using System.IO;
using Terraria;
using Terraria.IO;
using Terraria.ModLoader;

namespace MerchantsPlus
{
    public static class Config
    {
        public static bool merchantScaling = true;
        public static bool merchantExtraLife = true;
        public static bool merchantDialog = true;

        static string ConfigPath = Path.Combine(Main.SavePath, "Mod Configs", "MerchantsPlus.json");
        static Preferences Configuration = new Preferences(ConfigPath);

        public static void Load()
        {
            //Reading the config file
            bool success = ReadConfig();

            if (!success)
            {
                ErrorLogger.Log("Failed to read Example Mod's config file! Recreating config...");
                CreateConfig();
            }
        }

        //Returns "true" if the config file was found and successfully loaded.
        static bool ReadConfig()
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
        static void CreateConfig()
        {
            Configuration.Clear();
            //Configuration.Put("MerchantScaling", merchantScaling);
            //Configuration.Put("MerchantExtraLife", merchantExtraLife);
            //Configuration.Put("MerchantDialog", merchantDialog);
            Configuration.Save();
        }
    }
}
