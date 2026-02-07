using System.Collections.Generic;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace MerchantsPlus.UI;

public class ShopUnlockAsteriskWorldData : ModSystem
{
    // Persisted per world: merchantId, shopName -> acknowledged unlocked count
    public static Dictionary<(int MerchantId, string ShopName), int> AcknowledgedCounts = new();

    public override void OnWorldUnload()
    {
        AcknowledgedCounts.Clear();
    }

    public override void SaveWorldData(TagCompound tag)
    {
        var list = new List<TagCompound>();
        foreach (var kvp in AcknowledgedCounts)
        {
            list.Add(new TagCompound
            {
                ["MerchantId"] = kvp.Key.MerchantId,
                ["ShopName"] = kvp.Key.ShopName,
                ["Count"] = kvp.Value
            });
        }
        tag["ShopUnlockAsterisk_AcknowledgedCounts"] = list;
    }

    public override void LoadWorldData(TagCompound tag)
    {
        AcknowledgedCounts.Clear();
        if (tag.ContainsKey("ShopUnlockAsterisk_AcknowledgedCounts"))
        {
            foreach (TagCompound entry in tag.GetList<TagCompound>("ShopUnlockAsterisk_AcknowledgedCounts"))
            {
                int merchantId = entry.GetInt("MerchantId");
                string shopName = entry.GetString("ShopName");
                int count = entry.GetInt("Count");
                AcknowledgedCounts[(merchantId, shopName)] = count;
            }
        }
    }
}
