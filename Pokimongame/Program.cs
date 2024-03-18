using System;

namespace PokemonGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a trainer
            Trainer ash = new Trainer("Ash");
            Trainer garry = new Trainer("garry");
            // Game loop
            Battle.doBattle( ash, garry);
            
        }
    }
}
