using System;
using System.Collections.Generic;

namespace PokemonGame
{
    public class Trainer
    {
        public string name;
        public List<Pokeball> belt;

        // Constructor
        public Trainer(string name)
        {
            this.name = name;
            this.belt = new List<Pokeball>();
            // Add six pokeballs with Charmander to the belt
            for (int i = 0; i < 6; i++)
            {   
                AddPokeballWithCharmander();
            }
        }

        // Method to add a Pokeball with Charmander to the belt
        private void AddPokeballWithCharmander()
        {
            if (belt.Count >= 6)
            {
                throw new InvalidOperationException("The belt can only hold six pokeballs.");
            }
            Pokemon charmander = new charmander("charmander", "Fire", "Water");
            Pokeball pokeball = new Pokeball(30, "red", charmander, false);
            belt.Add(pokeball);
        }

        // Method to throw a pokeball from the belt
        public void ThrowPokeball()
        {
            if (belt.Count == 0)
            {
                Console.WriteLine("No pokeballs left in the belt.");
                return;
            }
            Pokeball pokeball = belt[0]; // Get the first pokeball
            belt.RemoveAt(0); // Remove the pokeball from the belt
            pokeball.Throwpokeball(); // Throw the pokeball
        }

        // Method to return a pokemon back to its pokeball and put the pokeball back on the belt
        public void ReturnPokemon(Pokemon pokemon)
        {
            if (belt.Count >= 6)
            {
                throw new InvalidOperationException("The belt can only hold six pokeballs.");
            }
            Pokeball pokeball = new Pokeball(30, "red", pokemon, false);
            belt.Add(pokeball); // Add the pokeball back to the belt
            Console.WriteLine($"{pokemon.GetName()} returned to its pokeball and put back on the belt.");
        }

        // Getter for name
        public string GetName()
        {
            return name;
        }

        // Getter for belt
        public List<Pokeball> GetBelt()
        {
            return belt;
        }
    }
}
