using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Items
{
    class ItemsBossBags : BaseItem
    {
        public override void SetDefaults(Item item)
        {
            base.SetDefaults(item);

            if (item.type == ItemID.KingSlimeBossBag)
            {
                if (Main.expertMode)
                    item.shopCustomPrice = Utils.Coins(0, 0, 5);
                else
                    item.shopCustomPrice = Utils.Coins(0, 0, 3);
            }
            if (item.type == ItemID.EyeOfCthulhuBossBag)
            {
                if (Main.expertMode)
                    item.shopCustomPrice = Utils.Coins(0, 0, 8);
                else
                    item.shopCustomPrice = Utils.Coins(0, 0, 4);
            }
            if (item.type == ItemID.BrainOfCthulhuBossBag)
            {
                if (Main.expertMode)
                    item.shopCustomPrice = Utils.Coins(0, 0, 20);
                else
                    item.shopCustomPrice = Utils.Coins(0, 0, 13);
            }
            if (item.type == ItemID.EaterOfWorldsBossBag)
            {
                if (Main.expertMode)
                    item.shopCustomPrice = Utils.Coins(0, 0, 20);
                else
                    item.shopCustomPrice = Utils.Coins(0, 0, 13);
            }
            if (item.type == ItemID.QueenBeeBossBag)
            {
                if (Main.expertMode)
                    item.shopCustomPrice = Utils.Coins(0, 0, 14);
                else
                    item.shopCustomPrice = Utils.Coins(0, 0, 6);
            }
            if (item.type == ItemID.SkeletronBossBag)
            {
                if (Main.expertMode)
                    item.shopCustomPrice = Utils.Coins(0, 0, 13);
                else
                    item.shopCustomPrice = Utils.Coins(0, 0, 6);
            }
            if (item.type == ItemID.WallOfFleshBossBag)
            {
                if (Main.expertMode)
                    item.shopCustomPrice = Utils.Coins(0, 0, 22);
                else
                    item.shopCustomPrice = Utils.Coins(0, 0, 10);
            }
            if (item.type == ItemID.TwinsBossBag)
            {
                if (Main.expertMode)
                    item.shopCustomPrice = Utils.Coins(0, 0, 35);
                else
                    item.shopCustomPrice = Utils.Coins(0, 0, 20);
            }
            if (item.type == ItemID.DestroyerBossBag)
            {
                if (Main.expertMode)
                    item.shopCustomPrice = Utils.Coins(0, 0, 35);
                else
                    item.shopCustomPrice = Utils.Coins(0, 0, 20);
            }
            if (item.type == ItemID.SkeletronPrimeBossBag)
            {
                if (Main.expertMode)
                    item.shopCustomPrice = Utils.Coins(0, 0, 35);
                else
                    item.shopCustomPrice = Utils.Coins(0, 0, 20);
            }
            if (item.type == ItemID.PlanteraBossBag)
            {
                if (Main.expertMode)
                    item.shopCustomPrice = Utils.Coins(0, 0, 55);
                else
                    item.shopCustomPrice = Utils.Coins(0, 0, 30);
            }
            if (item.type == ItemID.GolemBossBag)
            {
                if (Main.expertMode)
                    item.shopCustomPrice = Utils.Coins(0, 0, 40);
                else
                    item.shopCustomPrice = Utils.Coins(0, 0, 30);
            }
            if (item.type == ItemID.FishronBossBag)
            {
                if (Main.expertMode)
                    item.shopCustomPrice = Utils.Coins(0, 0, 70);
                else
                    item.shopCustomPrice = Utils.Coins(0, 0, 30);
            }
            if (item.type == ItemID.CultistBossBag)
            {
                if (Main.expertMode)
                    item.shopCustomPrice = Utils.Coins(0, 0, 30);
                else
                    item.shopCustomPrice = Utils.Coins(0, 0, 15);
            }
            if (item.type == ItemID.MoonLordBossBag)
            {
                if (Main.expertMode)
                    item.shopCustomPrice = Utils.Coins(0, 0, 0, 10);
                else
                    item.shopCustomPrice = Utils.Coins(0, 0, 0, 3);
            }
        }
    }
}
