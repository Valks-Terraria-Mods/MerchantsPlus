using MerchantsPlus.UI;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;

namespace MerchantsPlus
{
	class MerchantsPlus : Mod
	{
        internal static MerchantsPlus instance;
        internal ExampleUI ExampleUI;
        internal UserInterface _exampleUserInterface;

        public static int universalPotionCost = 20000;
        public static int universalAccessoryCost = 300000;

        public static bool overhaulLoaded;
        public static bool calamityLoaded;
        public static bool thoriumLoaded;
        public static bool autoTrashLoaded;

        public static Mod calamity;
        public static Mod overhaul;
        public static Mod thorium;
        public static Mod autoTrash;

		public MerchantsPlus()
		{
            
		}

        public override void UpdateUI(GameTime gameTime)
        {
            if (ExampleUI.Visible)
            {
                _exampleUserInterface.Update(gameTime);
            }
        }

        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            int mouseTextIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
            if (mouseTextIndex != -1)
            {
                layers.Insert(mouseTextIndex, new LegacyGameInterfaceLayer(
                    "MerchantsPlus: Custom Shops",
                    delegate {
                        if (ExampleUI.Visible)
                        {
                            _exampleUserInterface.Draw(Main.spriteBatch, new GameTime());
                        }
                        return true;
                    },
                    InterfaceScaleType.UI)
                );
            }
        }

        public override void Load()
        {
            instance = this;

            if (!Main.dedServ) {
                // Custom UI
                ExampleUI = new ExampleUI();
                ExampleUI.Activate();

                _exampleUserInterface = new UserInterface();
            }

            overhaulLoaded = ModLoader.GetMod("TerrariaOverhaul") != null;
            thoriumLoaded = ModLoader.GetMod("ThoriumMod") != null;
            calamityLoaded = ModLoader.GetMod("CalamityMod") != null;
            autoTrashLoaded = ModLoader.GetMod("AutoTrash") != null;

            if (calamityLoaded) {
                calamity = ModLoader.GetMod("CalamityMod");
            }

            if (thoriumLoaded) {
                thorium = ModLoader.GetMod("ThoriumMod");
            }

            if (overhaulLoaded) {
                overhaul = ModLoader.GetMod("TerrariaOverhaul");
            }

            if (autoTrashLoaded) {
                autoTrash = ModLoader.GetMod("AutoTrash");
            }
            
            Config.Load();
        }

        public override void Unload()
        {
            instance = null;
        }
    }
}
