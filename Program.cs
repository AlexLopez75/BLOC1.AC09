using System;
public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        const string Shop = "===== ITEMS IN STOCK AT THE SHOP =====";
        const string ItemStats = "Name - Level - Power - Weight (kg) - Price (€) - Is rare? - Rare type";
        const int MinLevel = 1;
        const int MaxLevel = 11;
        const int MinPower = 100;
        const int MaxPower = 501;
        const int MinWeight = 1;
        const int MaxWeight = 11;
        const int MinPrice = 1;
        const int MaxPrice = 201;

        int[] arrayPower = new int[4];
        int[] arrayLevel = new int[4];
        double[] arrayWeight = new double[4];
        double[] arrayPrice = new double[4];
        string[] arrayName = { "Sword", "Shield", "Potion", "Bow" };
        string[] arrayRarity = { "Common", "Uncommon", "Rare", "Legendary" };
        bool[] arrayIsRare = new bool[4];
        string rarity;

        Random rnd = new Random();

        Console.WriteLine(Shop);
        Console.WriteLine(ItemStats);

        for (int i = 0; i < arrayName.Length; i++)
        {
            arrayLevel[i] = rnd.Next(MinLevel, MaxLevel + 1);
            arrayPower[i] = rnd.Next(MinPower, MaxPower + 1);
            arrayWeight[i] = rnd.NextDouble() * rnd.Next(MinWeight, MaxWeight);
            arrayPrice[i] = rnd.NextDouble() * rnd.Next(MinPrice, MaxPrice);
            
            if (rnd.Next(0,2) == 0)
            {
                arrayIsRare[i] = false;
                rarity = arrayRarity[0];
            }
            else
            {
                arrayIsRare[i] = true;
                rarity = arrayRarity[rnd.Next(1,4)];
            }

            Console.WriteLine($"{arrayName[i]} - {arrayLevel[i]} - {arrayPower[i]} - {arrayWeight[i]:0.0} - {arrayPrice[i]:0.00}€ - {arrayIsRare[i]} - {rarity}");
        }
    }
}