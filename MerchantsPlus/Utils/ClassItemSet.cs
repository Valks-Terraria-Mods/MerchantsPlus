namespace MerchantsPlus.Shops;

public sealed class ClassItemSet(int meleeItemId, int rangerItemId, int mageItemId, int summonerItemId, int defaultItemId = ItemID.None)
{
    public int MeleeItemId { get; } = meleeItemId;
    public int RangerItemId { get; } = rangerItemId;
    public int MageItemId { get; } = mageItemId;
    public int SummonerItemId { get; } = summonerItemId;
    public int DefaultItemId { get; } = defaultItemId;

    public int GetItemId(PlayerClass playerClass)
    {
        return playerClass switch
        {
            PlayerClass.Melee => MeleeItemId,
            PlayerClass.Ranger => RangerItemId,
            PlayerClass.Mage => MageItemId,
            PlayerClass.Summoner => SummonerItemId,
            _ => DefaultItemId
        };
    }

    public int[] GetAllItemIds()
    {
        HashSet<int> ids =
        [
            MeleeItemId,
            RangerItemId,
            MageItemId,
            SummonerItemId,
        ];

        if (DefaultItemId > ItemID.None)
        {
            ids.Add(DefaultItemId);
        }

        ids.Remove(ItemID.None);
        return [.. ids];
    }
}
