using System;
public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        const string Welcome = "Welcome to Treasure Explorer! \nA 10x10 map with hidden treasures has been generated. You have 3 attempts to obtain the màximum amount of diamonds.";
        const string MainMenu = "===== Main Menu =====";
        const string Option1 = "1 - Dig in";
        const string Option2 = "\n2 - Show map";
        const string Option3 = "\n3 - Exit";
        const string MenuError = "Input a value between 1 and 3";
        const string DigIn = "You have chosen to dig.";
        const string InputRow = "Input a row (0-9): ";
        const string InputColumn = "Input a column (0-9): ";
        const string InputError = "Input a number between 0 and 9";
        const string MsgDigIn = "Digging in coordinates ({0},{1})...";
        const string Treasure = "💎 ";
        const string Nothing = "❌ ";
        const string MsgEmpty = "There's nothing in here.";
        const string MsgFound = "You struck a diamond!";
        const string OutOfAttempts = "You are out of attemps.";
        const string TotalTreasure = "You have obtained a total of {0} treasures!";
        const int MinTreasure = 0;
        const int MaxTreasure = 10;

        string[,] matrixMap = new string[10,10];
        int option, row, column, treasure, totalTreasure = 0, dig = 0;
        bool isValid;

        Random rnd = new Random();
        
        treasure = rnd.Next(0, 11);

        for (int i = 0; i < matrixMap.GetLength(0); i++)
        {
            for (int j = 0; j < matrixMap.GetLength(1); j++)
            {
                treasure = rnd.Next(MinTreasure, MaxTreasure);
                if (treasure == 9)
                {
                    matrixMap[i, j] = Treasure;
                }
                else
                {
                    matrixMap[i, j] = Nothing;
                }
            } 
        }

        Console.WriteLine(Welcome);
        Console.WriteLine(MainMenu);
        
        do
        {
            Console.WriteLine(Option1 + Option2 + Option3);
            isValid = Int32.TryParse(Console.ReadLine(), out option);

            if (option >= 1 && option <=3 && isValid)
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine(DigIn);
                        Console.WriteLine(InputRow);
                        isValid = Int32.TryParse(Console.ReadLine(), out row);

                        if (row >= 0 && row <= 9 && isValid)
                        {
                            Console.WriteLine(InputColumn);
                            isValid = Int32.TryParse(Console.ReadLine(), out column);

                            if (column >= 0 && column <= 9 && isValid)
                            {
                                Console.WriteLine(MsgDigIn, row, column);
                                if (matrixMap[row, column] == Treasure)
                                {
                                    Console.WriteLine(MsgFound);
                                    totalTreasure++;
                                    dig++;
                                }
                                else
                                {
                                    Console.WriteLine(MsgEmpty);
                                    dig++;
                                }
                            }
                            else
                            {
                                Console.WriteLine(InputError);
                            }
                        }
                        else
                        {
                            Console.WriteLine(InputError);
                        }
                        break;
                    case 2:
                        for (int i = 0; i < matrixMap.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrixMap.GetLength(1); j++)
                            {
                                treasure = rnd.Next(MinTreasure, MaxTreasure);
                                Console.Write($"{matrixMap[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        break;
                }
            }
            else
            {
                Console.WriteLine(MenuError);
            }
        } while (dig < 3 && option != 3);
        if (dig == 3)
        {
            Console.WriteLine(OutOfAttempts);
            Console.WriteLine(TotalTreasure, totalTreasure); 
        }
    }
}