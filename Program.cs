using System;
public class Program
{
    public static void Main()
    {
        const string NumberList = "There are 10 numbers between 1 and 9 generated at random";
        const string NormalOrder = "\nNormal order: ";
        const string InverseOrder = "\nInverse order: ";

        int[] arrayNums = new int[10];

        Random rand = new Random();

        Console.WriteLine(NumberList);

        for (int i = 0; i < 10; i++)
        {
            int rnd = rand.Next(1, 10);
            arrayNums[i] = rnd;
        }

        Console.Write(NormalOrder);
        foreach (int j in arrayNums)
        {
            Console.Write($"{j} ");
        }

        Console.Write(InverseOrder);
        
        for (int i = arrayNums.Length - 1; i >= 0; i--)
        {
            Console.Write($"{arrayNums[i]} ");
        }
    }
}