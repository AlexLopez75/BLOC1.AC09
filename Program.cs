using System;
public class Program
{
    public static void Main()
    {
        const string Start = "Enter 10 numbers between 1 and 9";
        const string InputNumber = "Input value {0}:";
        const string InputError = "Enter a number between 1 and 9.";
        const string NormalOrder = "\nNormal order: ";
        const string InverseOrder = "\nInverse order: ";
        const int MinNumber = 1;
        const int MaxNumber = 9;

        int i = 0, number, input = 1;
        int[] arrayNums = new int[10];
        bool isValid;

        Console.WriteLine(Start);

        for (input = 0; input < 10; input++)
        {
            Console.WriteLine(InputNumber, input + 1);
            try
            {
                isValid = Int32.TryParse(Console.ReadLine(), out number);
                if (isValid)
                {
                    if (number >= MinNumber && number <= MaxNumber)
                    {
                        arrayNums[i] = number;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine(InputError);
                        input--;
                    }
                }
                else
                {
                    Console.WriteLine(InputError);
                    input--;
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