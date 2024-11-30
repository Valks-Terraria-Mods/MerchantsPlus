using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace MerchantsPlus.Items;

public class ItemsVanity : BaseItem
{
    private static readonly Dictionary<int, int> customPrices = new()
    {
        { ItemID.BeePants, Utils.Coins(0, 5) },
        { ItemID.BeeShirt, Utils.Coins(0, 5) },
        { ItemID.BeeHat, Utils.Coins(0, 5) },
        { ItemID.PharaohsMask, Utils.Coins(0, 0, 1) },
        { ItemID.LeinforsPants, Utils.Coins(0, 0, 5) },
        { ItemID.LeinforsShirt, Utils.Coins(0, 0, 5) },
        { ItemID.LeinforsHat, Utils.Coins(0, 0, 5) },
        { ItemID.ArkhalisPants, Utils.Coins(0, 0, 5) },
        { ItemID.ArkhalisShirt, Utils.Coins(0, 0, 5) },
        { ItemID.ArkhalisHat, Utils.Coins(0, 0, 5) },
        { ItemID.OgreMask, Utils.Coins(0, 20) },
        { ItemID.BossMaskDarkMage, Utils.Coins(0, 20) },
        { ItemID.BossMaskBetsy, Utils.Coins(0, 20) },
        { ItemID.LokisPants, Utils.Coins(0, 0, 5) },
        { ItemID.LokisShirt, Utils.Coins(0, 0, 5) },
        { ItemID.LokisHelm, Utils.Coins(0, 0, 5) },
        { ItemID.SkiphsPants, Utils.Coins(0, 0, 5) },
        { ItemID.SkiphsShirt, Utils.Coins(0, 0, 5) },
        { ItemID.SkiphsHelm, Utils.Coins(0, 0, 5) },
        { ItemID.Yoraiz0rPants, Utils.Coins(0, 0, 5) },
        { ItemID.Yoraiz0rShirt, Utils.Coins(0, 0, 5) },
        { ItemID.Yoraiz0rHead, Utils.Coins(0, 0, 5) },
        { ItemID.BossMaskCultist, Utils.Coins(0, 0, 5) },
        { ItemID.BejeweledValkyrieBody, Utils.Coins(0, 0, 5) },
        { ItemID.BejeweledValkyrieHead, Utils.Coins(0, 0, 5) },
        { ItemID.SunMask, Utils.Coins(0, 0, 1) },
        { ItemID.MoonMask, Utils.Coins(0, 0, 1) },
        { ItemID.DukeFishronMask, Utils.Coins(0, 0, 1) },
        { ItemID.KingSlimeMask, Utils.Coins(0, 10) },
        { ItemID.DestroyerMask, Utils.Coins(0, 0, 1) },
        { ItemID.EyeMask, Utils.Coins(0, 0, 1) },
        { ItemID.EaterMask, Utils.Coins(0, 0, 1) },
        { ItemID.GolemMask, Utils.Coins(0, 0, 1) },
        { ItemID.PlanteraMask, Utils.Coins(0, 0, 1) },
        { ItemID.BeeMask, Utils.Coins(0, 0, 1) },
        { ItemID.SkeletronPrimeMask, Utils.Coins(0, 0, 1) },
        { ItemID.TwinMask, Utils.Coins(0, 0, 1) },
        { ItemID.FleshMask, Utils.Coins(0, 0, 1) },
        { ItemID.BrainMask, Utils.Coins(0, 0, 1) },
        { ItemID.CenxsDressPants, Utils.Coins(0, 0, 5) },
        { ItemID.CenxsDress, Utils.Coins(0, 0, 5) },
        { ItemID.CenxsTiara, Utils.Coins(0, 0, 5) },
        { ItemID.CenxsLeggings, Utils.Coins(0, 0, 5) },
        { ItemID.CenxsBreastplate, Utils.Coins(0, 0, 5) },
        { ItemID.DTownsLeggings, Utils.Coins(0, 0, 5) },
        { ItemID.DTownsBreastplate, Utils.Coins(0, 0, 5) },
        { ItemID.DTownsHelmet, Utils.Coins(0, 0, 5) },
        { ItemID.AaronsLeggings, Utils.Coins(0, 0, 5) },
        { ItemID.AaronsBreastplate, Utils.Coins(0, 0, 5) },
        { ItemID.AaronsHelmet, Utils.Coins(0, 0, 5) },
        { ItemID.JimsLeggings, Utils.Coins(0, 0, 5) },
        { ItemID.JimsBreastplate, Utils.Coins(0, 0, 5) },
        { ItemID.JimsHelmet, Utils.Coins(0, 0, 5) },
        { ItemID.WillsLeggings, Utils.Coins(0, 0, 5) },
        { ItemID.WillsBreastplate, Utils.Coins(0, 0, 5) },
        { ItemID.WillsHelmet, Utils.Coins(0, 0, 5) },
        { ItemID.CrownosLeggings, Utils.Coins(0, 0, 5) },
        { ItemID.CrownosBreastplate, Utils.Coins(0, 0, 5) },
        { ItemID.CrownosMask, Utils.Coins(0, 0, 5) },
        { ItemID.SkeletronMask, Utils.Coins(0, 0, 1) },
        { ItemID.SailorPants, Utils.Coins(0, 5) },
        { ItemID.SailorShirt, Utils.Coins(0, 5) },
        { ItemID.SailorHat, Utils.Coins(0, 5) },
        { ItemID.EyePatch, Utils.Coins(0, 5) },
        { ItemID.Skull, Utils.Coins(0, 0, 1) },
        { ItemID.UmbrellaHat, Utils.Coins(0, 5) },
        { ItemID.MummyPants, Utils.Coins(0, 5) },
        { ItemID.MummyShirt, Utils.Coins(0, 5) },
        { ItemID.MummyMask, Utils.Coins(0, 5) },
        { ItemID.GreenCap, Utils.Coins(0, 5) },
        { ItemID.PharaohsRobe, Utils.Coins(0, 0, 1) },
        { ItemID.RedsLeggings, Utils.Coins(0, 0, 5) },
        { ItemID.RedsBreastplate, Utils.Coins(0, 0, 5) },
        { ItemID.RedsHelmet, Utils.Coins(0, 0, 5) }
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
