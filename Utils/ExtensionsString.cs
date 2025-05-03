using System.Linq;

namespace MerchantsPlus;

public static class ExtensionsString
{
    public static string AddSpaceBeforeEachCapital(this string v)
    {
        return string.Concat(v.Select(x => char.IsUpper(x) ? " " + x : x.ToString())).TrimStart(' ');
    }
}
