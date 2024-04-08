using System;
using PokemonGame;

namespace PokemonGame

{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a trainer
            Trainer ash = new Trainer("Ash");
            Trainer garry = new Trainer("garry");
            garry.ShuffleBelt();
            // Game loop
            Arena arena = new Arena(ash, garry);
            arena.doBattle();
            Console.WriteLine( arena.checkwinner());
        }
    }
}
