using System;
public class Program
{
    public static void Main()
    {
        const string MenuStart = "What do you want to do?";
        const string MenuExit = "0 - Exit";
        const string MenuPokedex = "1 - List Pokémon";
        const string InputError = "Enter 0 or 1";
        const string PokemonNumber = ". ";
        const string PokemonRelease = "\nWhich Pokémon do you want to release? Enter the index: ";
        const string PokedexImputError = "Enter a value between 1 and 15";
        const string PokemeonReleased = "The index {0} is empty. There's no Pokémon in that slot to release.";

        int pokemon, input = 0;
        string empty = "Empty";
        string[] arrayPokedex = { "Pikachu", "Charmander", "Squirtle", "Bulbasaur", "Eevee", "Jigglypuff", "Meowth", "Psyduck", "Snorlax", "Gengar", "Machop", "Magikarp", "Vulpix", "Onix", "Abra"};

        do
        {
            Console.WriteLine(MenuStart);
            Console.WriteLine(MenuExit);
            Console.WriteLine(MenuPokedex);
        
            try 
            {
                input = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (input)
                {
                    case 1:
                        int j = 1;
                        for (int i = 0; i < arrayPokedex.Length; i++)
                        {
                            Console.Write(j + PokemonNumber);
                            Console.WriteLine($"{arrayPokedex[i]}");
                            j++;
                        }

                        Console.WriteLine(PokemonRelease);
                        try
                        {
                            pokemon = Int32.Parse(Console.ReadLine());
                            if (arrayPokedex[pokemon - 1] == empty)
                            {
                                Console.WriteLine(PokemeonReleased, pokemon);
                            }
                            else
                            {
                                arrayPokedex[pokemon - 1] = empty;
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine(PokedexImputError);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine(PokedexImputError);
                        }
                        break;
                    case 0:
                        break;
                }
            }
            catch (FormatException) 
            {
                Console.WriteLine(InputError);
            }
            catch (Exception)
            {
                Console.WriteLine(InputError);
            }
            Console.WriteLine();
        } while (input == 1);
    }
}