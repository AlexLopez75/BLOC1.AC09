using System;
public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        const string Troops = "===== TROOPS TURNS =====";
        const string Defense = "🛡️ ";
        const string Attack = "⚔️ ";
        const string Map = "===== MAP =====";
        const string WatchTower = "🗼 ";
        const string HidingCave = "🕳️ ";
        const string NeutralTerrain = "🌿 ";
        const string Regions = "===== REGIONS =====";
        const string Extra = "💎 ";
        const string Empty = "➖ ";

        string[] arrayTroops = new string[10];
        string[,] matrixMap = new string[5,5];
        string[][] jaggArrRegions = new string[3][];
        jaggArrRegions[0] = new string[4];
        jaggArrRegions[1] = new string[2];
        jaggArrRegions[2] = new string[3];

        Random rnd = new Random();

        Console.WriteLine(Troops);
        for (int i = 0; i < arrayTroops.Length; i++)
        {
            
            if ((i % 2) == 0)
            {
                arrayTroops[i] = Defense;
            }
            else
            {
                arrayTroops[i] = Attack;
            }
            Console.Write($"{arrayTroops[i]} ");
        }
        Console.WriteLine();

        Console.WriteLine(Map);
        for (int i = 0; i < matrixMap.GetLength(0); i++)
        {
            for (int j = 0; j < matrixMap.GetLength(1); j++)
            {
                if ((i % 2) == 0 && (j % 2) == 0)
                {
                    matrixMap[i,j] = WatchTower;
                }
                else if ((i % 2) != 0 && (j % 2) != 0) 
                {
                    matrixMap[i, j] = HidingCave;
                }
                else
                {
                    matrixMap[i, j] = NeutralTerrain;
                }
                Console.Write($"{matrixMap[i,j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine(Regions);
        for (int i = 0; i < jaggArrRegions.Length; i++)
        {
            for (int j = 0; j < jaggArrRegions[i].Length; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    jaggArrRegions[i][j] = Extra;
                }
                else
                {
                    jaggArrRegions[i][j] = Empty;
                }
                Console.Write($"{jaggArrRegions[i][j]} ");
            }
            Console.WriteLine();
        }
    }
}