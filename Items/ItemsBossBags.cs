using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Items;

public class ItemsBossBags : BaseItem
{
    public override void SetDefaults(Item item)
    {
        base.SetDefaults(item);

        item.shopCustomPrice = item.type switch
        {
            ItemID.KingSlimeBossBag => Main.expertMode ? Coins.Gold(5) : Coins.Gold(3),
            ItemID.EyeOfCthulhuBossBag => Main.expertMode ? Coins.Gold(8) : Coins.Gold(4),
            ItemID.BrainOfCthulhuBossBag => Main.expertMode ? Coins.Gold(20) : Coins.Gold(13),
            ItemID.EaterOfWorldsBossBag => Main.expertMode ? Coins.Gold(20) : Coins.Gold(13),
            ItemID.QueenBeeBossBag => Main.expertMode ? Coins.Gold(14) : Coins.Gold(6),
            ItemID.SkeletronBossBag => Main.expertMode ? Coins.Gold(13) : Coins.Gold(6),
            ItemID.WallOfFleshBossBag => Main.expertMode ? Coins.Gold(22) : Coins.Gold(10),
            ItemID.TwinsBossBag => Main.expertMode ? Coins.Gold(35) : Coins.Gold(20),
            ItemID.DestroyerBossBag => Main.expertMode ? Coins.Gold(35) : Coins.Gold(20),
            ItemID.SkeletronPrimeBossBag => Main.expertMode ? Coins.Gold(35) : Coins.Gold(20),
            ItemID.PlanteraBossBag => Main.expertMode ? Coins.Gold(55) : Coins.Gold(30),
            ItemID.GolemBossBag => Main.expertMode ? Coins.Gold(40) : Coins.Gold(30),
            ItemID.FishronBossBag => Main.expertMode ? Coins.Gold(70) : Coins.Gold(30),
            ItemID.CultistBossBag => Main.expertMode ? Coins.Gold(30) : Coins.Gold(15),
            ItemID.MoonLordBossBag => Main.expertMode ? Coins.Platinum(10) : Coins.Platinum(3),
            _ => item.shopCustomPrice
        };
    }
}
