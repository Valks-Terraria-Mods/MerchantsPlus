namespace MerchantsPlus.Items;

public class ItemsVanity : BaseItem
{
    private static readonly Dictionary<int, int> customPrices = new()
    {
        { ItemID.BeePants, Coins.Silver(5) },
        { ItemID.BeeShirt, Coins.Silver(5) },
        { ItemID.BeeHat, Coins.Silver(5) },
        { ItemID.PharaohsMask, Coins.Gold() },
        { ItemID.LeinforsPants, Coins.Gold(5) },
        { ItemID.LeinforsShirt, Coins.Gold(5) },
        { ItemID.LeinforsHat, Coins.Gold(5) },
        { ItemID.ArkhalisPants, Coins.Gold(5) },
        { ItemID.ArkhalisShirt, Coins.Gold(5) },
        { ItemID.ArkhalisHat, Coins.Gold(5) },
        { ItemID.OgreMask, Coins.Silver(20) },
        { ItemID.BossMaskDarkMage, Coins.Silver(20) },
        { ItemID.BossMaskBetsy, Coins.Silver(20) },
        { ItemID.LokisPants, Coins.Gold(5) },
        { ItemID.LokisShirt, Coins.Gold(5) },
        { ItemID.LokisHelm, Coins.Gold(5) },
        { ItemID.SkiphsPants, Coins.Gold(5) },
        { ItemID.SkiphsShirt, Coins.Gold(5) },
        { ItemID.SkiphsHelm, Coins.Gold(5) },
        { ItemID.Yoraiz0rPants, Coins.Gold(5) },
        { ItemID.Yoraiz0rShirt, Coins.Gold(5) },
        { ItemID.Yoraiz0rHead, Coins.Gold(5) },
        { ItemID.BossMaskCultist, Coins.Gold(5) },
        { ItemID.BejeweledValkyrieBody, Coins.Gold(5) },
        { ItemID.BejeweledValkyrieHead, Coins.Gold(5) },
        { ItemID.SunMask, Coins.Gold() },
        { ItemID.MoonMask, Coins.Gold() },
        { ItemID.DukeFishronMask, Coins.Gold() },
        { ItemID.KingSlimeMask, Coins.Silver(10) },
        { ItemID.DestroyerMask, Coins.Gold() },
        { ItemID.EyeMask, Coins.Gold() },
        { ItemID.EaterMask, Coins.Gold() },
        { ItemID.GolemMask, Coins.Gold() },
        { ItemID.PlanteraMask, Coins.Gold() },
        { ItemID.BeeMask, Coins.Gold() },
        { ItemID.SkeletronPrimeMask, Coins.Gold() },
        { ItemID.TwinMask, Coins.Gold() },
        { ItemID.FleshMask, Coins.Gold() },
        { ItemID.BrainMask, Coins.Gold() },
        { ItemID.CenxsDressPants, Coins.Gold(5) },
        { ItemID.CenxsDress, Coins.Gold(5) },
        { ItemID.CenxsTiara, Coins.Gold(5) },
        { ItemID.CenxsLeggings, Coins.Gold(5) },
        { ItemID.CenxsBreastplate, Coins.Gold(5) },
        { ItemID.DTownsLeggings, Coins.Gold(5) },
        { ItemID.DTownsBreastplate, Coins.Gold(5) },
        { ItemID.DTownsHelmet, Coins.Gold(5) },
        { ItemID.AaronsLeggings, Coins.Gold(5) },
        { ItemID.AaronsBreastplate, Coins.Gold(5) },
        { ItemID.AaronsHelmet, Coins.Gold(5) },
        { ItemID.JimsLeggings, Coins.Gold(5) },
        { ItemID.JimsBreastplate, Coins.Gold(5) },
        { ItemID.JimsHelmet, Coins.Gold(5) },
        { ItemID.WillsLeggings, Coins.Gold(5) },
        { ItemID.WillsBreastplate, Coins.Gold(5) },
        { ItemID.WillsHelmet, Coins.Gold(5) },
        { ItemID.CrownosLeggings, Coins.Gold(5) },
        { ItemID.CrownosBreastplate, Coins.Gold(5) },
        { ItemID.CrownosMask, Coins.Gold(5) },
        { ItemID.SkeletronMask, Coins.Gold() },
        { ItemID.SailorPants, Coins.Silver(5) },
        { ItemID.SailorShirt, Coins.Silver(5) },
        { ItemID.SailorHat, Coins.Silver(5) },
        { ItemID.EyePatch, Coins.Silver(5) },
        { ItemID.Skull, Coins.Gold() },
        { ItemID.UmbrellaHat, Coins.Silver(5) },
        { ItemID.MummyPants, Coins.Silver(5) },
        { ItemID.MummyShirt, Coins.Silver(5) },
        { ItemID.MummyMask, Coins.Silver(5) },
        { ItemID.GreenCap, Coins.Silver(5) },
        { ItemID.PharaohsRobe, Coins.Gold() },
        { ItemID.RedsLeggings, Coins.Gold(5) },
        { ItemID.RedsBreastplate, Coins.Gold(5) },
        { ItemID.RedsHelmet, Coins.Gold(5) }
    };

    public override void SetDefaults(Item item)
    {
        base.SetDefaults(item);

        if (customPrices.TryGetValue(item.type, out int customPrice))
        {
            item.shopCustomPrice = customPrice;
        }
    }
}
