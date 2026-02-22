using Terraria.Audio;

namespace MerchantsPlus.Shops;

public abstract partial class Shop
{
    public abstract List<string> Shops { get; }
    public int CycleIndex { get; set; }
    private static int _forcedContextNpcType = NPCID.None;
    private static int _forcedContextNpcIndex = -1;
    private static int _suppressOpenSoundDepth;
    private static string _openSourceTag = "default";

    protected Chest Inv;
    protected int NextSlot;

    private bool HasAvailableSlot()
    {
        return Inv?.item is not null && (uint)NextSlot < (uint)Inv.item.Length;
    }

    /// <summary>
    /// Returns a display-friendly shop name derived from the class name.
    /// </summary>
    /// <returns>The shop name without the <c>Shop</c> prefix and with spaced capitals.</returns>
    public override string ToString()
    {
        return GetType().Name.Replace("Shop", "").AddSpaceBeforeEachCapital();
    }
}
