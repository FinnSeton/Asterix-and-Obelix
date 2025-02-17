using System;
using PokemonGame;

namespace PokemonGame
{
    public static class Program
    {
        public static void slowWrite(string writeline)
        {
            Console.WriteLine(writeline);
            System.Threading.Thread.Sleep(00);
        }

        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                // Create trainers
                Trainer ash = new Trainer("Ash");
                Trainer garry = new Trainer("Garry");

                garry.ShuffleBelt();
                ash.ShuffleBelt();

                // Game loop
                Arena arena = new Arena(ash, garry);
                arena.DoBattle();

                Program.slowWrite(arena.Checkwinner());
                
                // Ask the player if they want to play again
                Console.WriteLine("Do you want to play again? (yes/no)");
                string playAgainResponse = Console.ReadLine().Trim().ToLower();
                Arena.AddToBattles();

                Console.WriteLine("Rounds played:" + Arena.Rounds + "Battles played: " + Arena.battles);
                
                if (playAgainResponse != "yes")
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thank you for playing! Goodbye!");
        }
    }
}