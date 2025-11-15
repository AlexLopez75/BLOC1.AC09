using System;
public class Program
{
    public static void Main()
    {
        const string InputNumber = "Input value {0}:";
        const string InputError = "Enter a number";
        const string EvenNumbers = "\nEven numbers: ";
        const string OddNumbers = "\nOdd numbers: ";

        int number;
        int[] arrayNumsEven = new int[20];
        int[] arrayNumsOdd = new int[20];

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(InputNumber, i + 1);
            try
            {
                number = Int32.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    arrayNumsEven[i] = number;
                }
                else
                {
                    arrayNumsOdd[i] = number;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(InputError);
                i--;
            }
            catch (Exception)
            {
                Console.WriteLine(InputError);
                i--;
            }
        }

        Console.Write(EvenNumbers);
        for (int i = 0; i < arrayNumsEven.Length; i++)
        {
            if (arrayNumsEven[i] != 0)
            {
                Console.Write($"{arrayNumsEven[i]} ");
            }
        }

        Console.Write(OddNumbers);
        for (int i = 0; i < arrayNumsOdd.Length; i++)
        {
            if (arrayNumsOdd[i] != 0)
            {
                Console.Write($"{arrayNumsOdd[i]} ");
            }
        }
    }
}