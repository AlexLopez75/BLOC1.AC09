using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
public class Program
{
    public static void Main()
    {
        const string PlayerList = "Player list: ";
        const string GamesTitle = "\nGames played:";
        const string GamesPlayed = "\n{0} played {1} games.";
        const string GamesScores = "\nGame scores:";
        const string AveragePoints = "--> Average: {0} points";
        const string TotalPoints = "\nTotal global points of the tournament: {0} points";
        const int MinPoints = 0;
        const int MaxPoints = 101;

        string[] arrayPlayers = { "Alexloes75", "Xx_KillerGamer_xX", "CheepClapper69", "LolitoFDEZ" };
        int[] arrayGames = { 3, 2, 5, 1 };
        int[][] scores = new int[4][];
        scores[0] = new int[3];
        scores[1] = new int[2];
        scores[2] = new int[5];
        scores[3] = new int[1];
        int totalPoints = 0;

        Random rand = new Random();

        Console.Write(PlayerList);
        for (int i = 0; i < arrayPlayers.Length; i++)
        {
            Console.Write($"{arrayPlayers[i]} ");
        }
        Console.WriteLine();

        Console.Write(GamesTitle);
        for (int i = 0; i < arrayPlayers.Length; i++)
        {
            Console.Write(GamesPlayed, arrayPlayers[i], arrayGames[i]);
        }
        Console.WriteLine();

        Console.WriteLine(GamesScores);
        for (int i = 0; i < scores.Length; i++)
        {
            int sum = 0;
            int average = 0;
            Console.Write($"{arrayPlayers[i]}: ");
            for (int j = 0; j < scores[i].Length; j++)
            {
                int points = rand.Next(MinPoints, MaxPoints);
                scores[i][j] = points;
                sum = sum + points;
                totalPoints = totalPoints + points;
                Console.Write($"- {scores[i][j]} ");
            }
            average = sum / scores[i].Length;
            Console.WriteLine(AveragePoints, average);
        }

        Console.WriteLine(TotalPoints, totalPoints);
    }
}