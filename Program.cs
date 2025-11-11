using System;
public class Program
{
    public static void Main()
    {
        const string NumberList = "There are 10 numbers between 1 and 9 generated at random";
        const string NormalOrder = "\nNormal order: ";
        const string InverseOrder = "\nInverse order: ";

        int i = 0, input = 1;
        int[] arrayNums = new int[10];

        Random rand = new Random();

        Console.WriteLine(NumberList);

        for (input = 0; input < 10; input++)
        {
            int rnd = rand.Next(1, 10);
            arrayNums[i] = rnd;
            i++;
        }

        Console.Write(NormalOrder);
        foreach (int j in arrayNums)
        {
            Console.Write($"{j} ");
        }

        Console.Write(InverseOrder);
        
        for (i = arrayNums.Length - 1; i >= 0; i--)
        {
            Console.Write($"{arrayNums[i]} ");
        }
    }
}