using MerchantsPlus.UI;
using Terraria.GameInput;
using Terraria.ModLoader;
using Terraria;

namespace MerchantsPlus
{
    class ThePlayer : ModPlayer
    {
        public override void ProcessTriggers(TriggersSet triggersSet) {
            ExampleUI.Visible = false;
        }
    }
}
