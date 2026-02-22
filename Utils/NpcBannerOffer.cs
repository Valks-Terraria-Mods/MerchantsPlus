namespace MerchantsPlus.Shops;

public sealed class NpcBannerOffer(int bannerItemId, int price, params short[] npcIds)
{
    public int BannerItemId { get; } = bannerItemId;
    public int Price { get; } = price;
    public short[] NpcIds { get; } = npcIds;

    public bool IsUnlocked(int requiredKills)
    {
        foreach (short npcId in NpcIds)
        {
            if (WorldUtils.Kills(npcId) >= requiredKills)
            {
                return true;
            }
        }

        return false;
    }
}
