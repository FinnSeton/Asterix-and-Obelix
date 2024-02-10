using System;
using PokemonGame;

class Program
{
    static void Main(string[] args)
    {
        // Start the game
        bool playing = true;
        while (playing)
        {
            // Ask the player to give a name to Pokemon
            Console.WriteLine("Enter a nickname for your Pokemon:");
            string nickname = Console.ReadLine();

            // Create a Pokemon object with the given nickname
            Pokemon pokemon = new Pokemon("charmander", nickname, "Fire", "Water");
            // create a pokeball object with the given pokemon
            Pokeball pokeball = new Pokeball(30, "red", pokemon);
            //trainer throws the pokeball
            pokeball.Throwpokeball();
            // Pokemon does its battle cry
            pokemon.BattleCry();

            // Ask if the player wants to continue
            Console.WriteLine("Do you want to continue? (yes/no)");
            string input = Console.ReadLine().ToLower();
            if (input != "yes")
                playing = false;
        }
    }
}
