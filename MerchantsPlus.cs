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
        public static MerchantsPlus Instance;
        public static ILog Console;

        public UserInterface UserInterface;

        private ShopUI m_ShopUI;

        public MerchantsPlus()
        {
        }

        public override void Load()
        {
            Instance = this;
            Console = this.Logger;

            if (!Main.dedServ)
            {
                // Custom UI
                m_ShopUI = new ShopUI();
                m_ShopUI.Activate();

                UserInterface = new UserInterface();
            }

            Config.Load();
        }

        public override void Unload()
        {
            Instance = null;
        }

        public override void UpdateUI(GameTime gameTime)
        {
            base.UpdateUI(gameTime);

            if (ShopUI.Visible)
            {
                UserInterface.Update(gameTime);
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
                        if (ShopUI.Visible)
                        {
                            UserInterface.Draw(Main.spriteBatch, new GameTime());
                        }
                        return true;
                    },
                    InterfaceScaleType.UI)
                );
            }
        }
    }
}