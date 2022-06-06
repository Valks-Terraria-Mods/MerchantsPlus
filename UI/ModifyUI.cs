namespace MerchantsPlus.UI
{
    internal class ModifyUI : ModSystem
    {
        public override void UpdateUI(GameTime gameTime)
        {
            base.UpdateUI(gameTime);

            if (ShopUI.Visible)
            {
                MerchantsPlus.UserInterface.Update(gameTime);
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
                            MerchantsPlus.UserInterface.Draw(Main.spriteBatch, new GameTime());
                        }
                        return true;
                    },
                    InterfaceScaleType.UI)
                );
            }
        }
    }
}
