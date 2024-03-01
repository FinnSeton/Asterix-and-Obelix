using System;

namespace PokemonGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a trainer
            Trainer ash = new Trainer("Ash");

            // Game loop
            while (true)
            {
                Console.WriteLine("1. Throw Pokeball");
                Console.WriteLine("2. Quit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Throw a pokeball
                        ash.ThrowPokeball();
                        break;
                    case "2":
                        // Quit the game
                        Console.WriteLine("Exiting the game.");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }
        }
    }
}
