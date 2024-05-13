using System;
using PokemonGame;

namespace PokemonGame

{
    public static class Program
    {
        public static void slowWrite(string writeline)
        {
            Console.WriteLine(writeline);
            System.Threading.Thread.Sleep(0);
        }
        
        static void Main(string[] args)
        {
            // Create a trainer
            Trainer ash = new Trainer("Ash");
            Trainer garry = new Trainer("garry");
            garry.ShuffleBelt();
            ash.ShuffleBelt();
            // Game loop
            Arena arena = new Arena(ash, garry);
            arena.DoBattle();
            Program.slowWrite( arena.Checkwinner());
        }
    }
}
