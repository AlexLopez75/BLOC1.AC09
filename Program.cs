using System;
public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        const string GameStats = "===== Game Kill Stats =====";
        const string Separator = "\n-------------------------------------------------------------------";
        const string PlayerMatch = "Player --- Match 1 --- Match 2 --- Match 3 --- Match 4 --- Match 5";
        const int MinKills = 0;
        const int MaxKills = 10;

        string[] arrayGamers = { "Alexloes75", "Xx_KillerGamer_xX", "CheepClapper69", "LolitoFDEZ" };
        int[,] matrixKills = new int[4,5];

        Random rnd = new Random();

        Console.WriteLine(GameStats + Separator);
        Console.WriteLine(PlayerMatch + Separator);
        for (int i = 0; i < matrixKills.GetLength(0); i++)
        {
            Console.Write($"{arrayGamers[i]} ");
            for (int j = 0; j < matrixKills.GetLength(1); j++)
            {
                int kill = rnd.Next(MinKills, MaxKills);
                matrixKills[i, j] = kill;
                Console.Write($"--- {matrixKills[i, j]} ");
            }
            Console.WriteLine(Separator);
        }
    }
}