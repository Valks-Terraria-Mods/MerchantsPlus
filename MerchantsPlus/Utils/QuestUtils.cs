namespace MerchantsPlus;

public static class QuestUtils
{
    public static void QuestKills(List<string> dialog, string enemy, int curKills, int targetKills)
    {
        if (curKills < targetKills)
        {
            dialog.Add($"Quest: Kill {targetKills - curKills} more {enemy}");
        }
    }

    public static string Dialog(string[] lines) => lines[Main.rand.Next(lines.Length)];
}
