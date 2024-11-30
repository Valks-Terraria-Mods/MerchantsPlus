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
            ItemID.KingSlimeBossBag => Main.expertMode ? Utils.Coins(0, 0, 5) : Utils.Coins(0, 0, 3),
            ItemID.EyeOfCthulhuBossBag => Main.expertMode ? Utils.Coins(0, 0, 8) : Utils.Coins(0, 0, 4),
            ItemID.BrainOfCthulhuBossBag => Main.expertMode ? Utils.Coins(0, 0, 20) : Utils.Coins(0, 0, 13),
            ItemID.EaterOfWorldsBossBag => Main.expertMode ? Utils.Coins(0, 0, 20) : Utils.Coins(0, 0, 13),
            ItemID.QueenBeeBossBag => Main.expertMode ? Utils.Coins(0, 0, 14) : Utils.Coins(0, 0, 6),
            ItemID.SkeletronBossBag => Main.expertMode ? Utils.Coins(0, 0, 13) : Utils.Coins(0, 0, 6),
            ItemID.WallOfFleshBossBag => Main.expertMode ? Utils.Coins(0, 0, 22) : Utils.Coins(0, 0, 10),
            ItemID.TwinsBossBag => Main.expertMode ? Utils.Coins(0, 0, 35) : Utils.Coins(0, 0, 20),
            ItemID.DestroyerBossBag => Main.expertMode ? Utils.Coins(0, 0, 35) : Utils.Coins(0, 0, 20),
            ItemID.SkeletronPrimeBossBag => Main.expertMode ? Utils.Coins(0, 0, 35) : Utils.Coins(0, 0, 20),
            ItemID.PlanteraBossBag => Main.expertMode ? Utils.Coins(0, 0, 55) : Utils.Coins(0, 0, 30),
            ItemID.GolemBossBag => Main.expertMode ? Utils.Coins(0, 0, 40) : Utils.Coins(0, 0, 30),
            ItemID.FishronBossBag => Main.expertMode ? Utils.Coins(0, 0, 70) : Utils.Coins(0, 0, 30),
            ItemID.CultistBossBag => Main.expertMode ? Utils.Coins(0, 0, 30) : Utils.Coins(0, 0, 15),
            ItemID.MoonLordBossBag => Main.expertMode ? Utils.Coins(0, 0, 0, 10) : Utils.Coins(0, 0, 0, 3),
            _ => item.shopCustomPrice
        };
    }
}
