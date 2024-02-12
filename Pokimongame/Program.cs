using System;
using System.Collections.Generic;

namespace PokemonGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;
            while (playing)
            {
                Console.WriteLine("Welcome to the Pokemon Battle Simulator!");

                // Create trainers
                Console.WriteLine("Enter the name of the first trainer:");
                string? trainer1Name = Console.ReadLine();
                if (trainer1Name == null)
                {
                    Console.WriteLine("Invalid trainer name. Please try again.");
                    continue;
                }
                Trainer trainer1 = new Trainer(trainer1Name);

                Console.WriteLine("Enter the name of the second trainer:");
                string? trainer2Name = Console.ReadLine();
                if (trainer2Name == null)
                {
                    Console.WriteLine("Invalid trainer name. Please try again.");
                    continue;
                }
                Trainer trainer2 = new Trainer(trainer2Name);

                // Battle loop
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine($"Round {i + 1}:");
                    // Trainer 1's turn
                    Console.WriteLine($"{trainer1.GetName()} throws a pokeball:");
                    trainer1.ThrowPokeball();

                    // Trainer 2's turn
                    Console.WriteLine($"{trainer2.GetName()} throws a pokeball:");
                    trainer2.ThrowPokeball();

                    // Return Pokemon
                    Console.WriteLine($"{trainer1.GetName()} returns the Pokemon:");
                    trainer1.ReturnPokemon(trainer1.GetBelt()[0].GetPokemon());

                    Console.WriteLine($"{trainer2.GetName()} returns the Pokemon:");
                    trainer2.ReturnPokemon(trainer2.GetBelt()[0].GetPokemon());

                    Console.WriteLine(); // Add a blank line for readability
                }

                // Ask if the player wants to continue
                Console.WriteLine("Do you want to continue? (yes/no)");
                string input = Console.ReadLine()?.ToLower();
                if (input != "yes")
                    playing = false;
            }
        }
    }
}
