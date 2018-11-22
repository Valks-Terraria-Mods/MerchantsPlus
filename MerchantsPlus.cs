using Terraria.ModLoader;

namespace MerchantsPlus
{
	class MerchantsPlus : Mod
	{
		public MerchantsPlus()
		{
		}

        public override void Load()
        {
            Config.Load();
        }
    }
}
