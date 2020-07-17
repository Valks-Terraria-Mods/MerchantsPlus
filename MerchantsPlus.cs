using log4net;
using MerchantsPlus.UI;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;

namespace MerchantsPlus
{
    internal class MerchantsPlus : Mod
    {
        internal static MerchantsPlus instance;
        internal ExampleUI ExampleUI;
        internal UserInterface _exampleUserInterface;

        public static ILog Console;

        public static int universalPotionCost = Utils.Coins(0, 0, 5);
        public static int universalAccessoryCost = Utils.Coins(0, 0, 25);
        public static int universalOreCost = Utils.Coins(0, 0, 1);

        public MerchantsPlus()
        {
        }

        public override void Load()
        {
            instance = this;
            Console = this.Logger;

            if (!Main.dedServ)
            {
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

        public override void UpdateUI(GameTime gameTime)
        {
            base.UpdateUI(gameTime);

            if (ExampleUI.Visible)
            {
                _exampleUserInterface.Update(gameTime);
            }
        }

        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            base.ModifyInterfaceLayers(layers);

            int mouseTextIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
            if (mouseTextIndex != -1)
            {
                layers.Insert(mouseTextIndex, new LegacyGameInterfaceLayer(
                    "MerchantsPlus: Custom Shops",
                    delegate
                    {
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
    }
}