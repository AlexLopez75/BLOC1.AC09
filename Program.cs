using System;
public class Program
{
    public static void Main()
    {
        const string InputNumber = "Input value {0}:";
        const string InputError = "Enter a number";
        const string EvenNumbers = "\nEven numbers: ";
        const string OddNumbers = "\nOdd numbers: ";

        int i=0, number, input = 1;
        int[] arrayNumsEven = new int[20];
        int[] arrayNumsOdd = new int[20];

        for (input = 0; input < 20; input++)
        {
            Console.WriteLine(InputNumber, input + 1);
            try
            {
                number = Int32.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    arrayNumsEven[i] = number;
                    i++;
                }
                else
                {
                    arrayNumsOdd[i] = number;
                    i++;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(InputError);
                input--;
            }
            catch (Exception)
            {
                Console.WriteLine(InputError);
                input--;
            }
        }
        i = 0;
        Console.Write(EvenNumbers);
        for (i = 0; i < arrayNumsEven.Length; i++)
        {
            if (arrayNumsEven[i] != 0)
            {
                Console.Write($"{arrayNumsEven[i]} ");
            }
        }
        i = 0;
        Console.Write(OddNumbers);
        for (i = 0; i < arrayNumsOdd.Length; i++)
        {
            if (arrayNumsOdd[i] != 0)
            {
                Console.Write($"{arrayNumsOdd[i]} ");
            }
        }
    }
}