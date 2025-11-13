using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
public class Program
{
    public static void Main()
    {
        const string NumberList = "There are 10 numbers between 1 and 9 generated at random";
        const string InputError = "Enter a number between 1 and 9.";
        const string NumberSearch = "What number do you want to search?";
        const string SearchFound = "The number {0} is in the list and it's repeated {1} times.";
        const string SearchNotFound = "The number {0} is not in the list.";
        const string AscendentOrder = "\nAscendent order: ";
        const int MinValue = 1;
        const int MaxValue = 10;

        int search, repeat = 0;
        int[] arrayNums = new int[10];
        bool isValid, found = false;

        Random rand = new Random();

        Console.WriteLine(NumberList);
        for (int i = 0; i < arrayNums.Length; i++)
        {
            int rnd = rand.Next(MinValue, MaxValue);
            arrayNums[i] = rnd;
        }
        do 
        {
            Console.WriteLine(NumberSearch);
            isValid = Int32.TryParse(Console.ReadLine(), out search);
            if (isValid)
            {
                for (int i = 0; i < arrayNums.Length; i++)
                {
                    if (arrayNums[i] == search)
                    {
                        found = true;
                        repeat++;
                    }
                }
            }
            else
            {
                Console.WriteLine(InputError);
            }
        } while (!isValid);

        if (found)
        {
            Console.WriteLine(SearchFound, search, repeat);
        }
        else 
        { 
            Console.WriteLine(SearchNotFound, search); 
        }

        for (int i = 0; i < arrayNums.Length; i++)
        {
            for (int j = 0; j < arrayNums.Length - 1; j++)
            {
                if (arrayNums[j] > arrayNums[j + 1])
                {
                    int aux = arrayNums[j + 1];
                    arrayNums[j + 1] = arrayNums[j];
                    arrayNums[j] = aux;
                }
            }
        }

        Console.Write(AscendentOrder);
        for (int i = 0; i < arrayNums.Length; i++)
        {
            Console.Write($"{arrayNums[i]} ");
        }
    }
}