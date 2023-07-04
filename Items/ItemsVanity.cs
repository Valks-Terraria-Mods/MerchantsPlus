using Terraria.ID;

namespace MerchantsPlus.Items;

class ItemsVanity : BaseItem
{
    public override void SetDefaults(Item item)
    {
        base.SetDefaults(item);

        if (item.type == ItemID.BeePants) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.BeeShirt) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.BeeHat) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.PharaohsMask) item.shopCustomPrice = Utils.Coins(0, 0, 1);
        if (item.type == ItemID.LeinforsPants) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.LeinforsShirt) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.LeinforsHat) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.ArkhalisPants) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.ArkhalisShirt) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.ArkhalisHat) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.OgreMask) item.shopCustomPrice = Utils.Coins(0, 20);
        if (item.type == ItemID.BossMaskDarkMage) item.shopCustomPrice = Utils.Coins(0, 20);
        if (item.type == ItemID.BossMaskBetsy) item.shopCustomPrice = Utils.Coins(0, 20);
        if (item.type == ItemID.LokisPants) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.LokisShirt) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.LokisHelm) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.SkiphsPants) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.SkiphsShirt) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.SkiphsHelm) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.Yoraiz0rPants) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.Yoraiz0rShirt) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.Yoraiz0rHead) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.MoonMask) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.BossMaskCultist) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.BejeweledValkyrieBody) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.BejeweledValkyrieHead) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.SunMask) item.shopCustomPrice = Utils.Coins(0, 0, 1);
        if (item.type == ItemID.MoonMask) item.shopCustomPrice = Utils.Coins(0, 0, 1);
        if (item.type == ItemID.DukeFishronMask) item.shopCustomPrice = Utils.Coins(0, 0, 1);
        if (item.type == ItemID.KingSlimeMask) item.shopCustomPrice = Utils.Coins(0, 10);
        if (item.type == ItemID.DestroyerMask) item.shopCustomPrice = Utils.Coins(0, 0, 1);
        if (item.type == ItemID.EyeMask) item.shopCustomPrice = Utils.Coins(0, 0, 1);
        if (item.type == ItemID.EaterMask) item.shopCustomPrice = Utils.Coins(0, 0, 1);
        if (item.type == ItemID.GolemMask) item.shopCustomPrice = Utils.Coins(0, 0, 1);
        if (item.type == ItemID.PlanteraMask) item.shopCustomPrice = Utils.Coins(0, 0, 1);
        if (item.type == ItemID.BeeMask) item.shopCustomPrice = Utils.Coins(0, 0, 1);
        if (item.type == ItemID.SkeletronPrimeMask) item.shopCustomPrice = Utils.Coins(0, 0, 1);
        if (item.type == ItemID.TwinMask) item.shopCustomPrice = Utils.Coins(0, 0, 1);
        if (item.type == ItemID.FleshMask) item.shopCustomPrice = Utils.Coins(0, 0, 1);
        if (item.type == ItemID.BrainMask) item.shopCustomPrice = Utils.Coins(0, 0, 1);
        if (item.type == ItemID.CenxsDressPants) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.CenxsDress) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.CenxsTiara) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.CenxsLeggings) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.CenxsBreastplate) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.DTownsLeggings) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.DTownsBreastplate) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.DTownsHelmet) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.AaronsLeggings) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.AaronsBreastplate) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.AaronsHelmet) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.JimsLeggings) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.JimsBreastplate) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.JimsHelmet) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.WillsLeggings) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.WillsBreastplate) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.WillsHelmet) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.CrownosLeggings) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.CrownosBreastplate) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.CrownosMask) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.SkeletronMask) item.shopCustomPrice = Utils.Coins(0, 0, 1);
        if (item.type == ItemID.SailorPants) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.SailorShirt) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.SailorHat) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.EyePatch) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.Skull) item.shopCustomPrice = Utils.Coins(0, 0, 1);
        if (item.type == ItemID.UmbrellaHat) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.MummyPants) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.MummyShirt) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.MummyMask) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.GreenCap) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.PharaohsRobe) item.shopCustomPrice = Utils.Coins(0, 0, 1);
        if (item.type == ItemID.CrownosMask) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.CrownosMask) item.shopCustomPrice = Utils.Coins(0, 5);
        if (item.type == ItemID.RedsLeggings) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.RedsBreastplate) item.shopCustomPrice = Utils.Coins(0, 0, 5);
        if (item.type == ItemID.RedsHelmet) item.shopCustomPrice = Utils.Coins(0, 0, 5);
    }
}
