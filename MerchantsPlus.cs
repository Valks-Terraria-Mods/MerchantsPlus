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

        public static int universalPotionCost = Utils.coins(0, 0, 10);
        public static int universalAccessoryCost = Utils.coins(0, 0, 25);
        public static int universalOreCost = Utils.coins(0, 0, 1);

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
            
            Config.Load();
        }

        public override void Unload()
        {
            instance = null;
        }
    }
}
