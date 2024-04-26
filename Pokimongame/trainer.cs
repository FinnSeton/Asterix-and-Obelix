using System;
using System.Collections.Generic;

namespace PokemonGame
{
    public class Trainer
    {
        public string Name;
        public List<Pokeball> Belt;

        // Constructor
        public Trainer(string name)
        {
            this.Name = name;
            this.Belt = new List<Pokeball>();
            // Add six pokeballs with Charmander to the belt
            for (int i = 0; i < 2; i++)
            {   
                AddPokeballWithCharmander();
                AddPokeballWithBulbasaur();
                AddPokeballWithSquirtle();
            }
        }

        // Method to add a Pokeball with Charmander to the belt
        private void AddPokeballWithCharmander()
        {
            if (Belt.Count >= 6)
            {
                throw new InvalidOperationException("The belt can only hold six pokeballs.");
            }
            Pokemon charmander = new Charmander("charmander", "flamey", "Fire", "Water");
            Pokeball pokeball = new Pokeball(30, "red", charmander, false);
            Belt.Add(pokeball);
        }
        private void AddPokeballWithBulbasaur()
        {
            if (Belt.Count >= 6)
            {
                throw new InvalidOperationException("The belt can only hold six pokeballs.");
            }
            Pokemon bulbasaur = new Bulbasaur("bulbasaur", "wiet", "Grass", "Fire");
            Pokeball pokeball = new Pokeball(30, "green", bulbasaur, false);
            Belt.Add(pokeball);
        }
        private void AddPokeballWithSquirtle()
        {
            if (Belt.Count >= 6)
            {
                throw new InvalidOperationException("The belt can only hold six pokeballs.");
            }
            Pokemon squirtle = new Squirtle("squirtle", "pissboy", "water", "grass");
            Pokeball pokeball = new Pokeball(30, "blue", squirtle, false);
            Belt.Add(pokeball);
        }


        // Method to throw a pokeball from the belt
        public Pokeball ThrowPokeball()
        {
            if (Belt.Count == 0)
            {
                Program.slowWrite("No pokeballs left in the belt.");
                throw new IndexOutOfRangeException("to implement");

            }
            Pokeball pokeball = Belt[0]; // Get the first pokeball
            Belt.RemoveAt(0); // Remove the pokeball from the belt
            pokeball.Throwpokeball(); // Throw the pokeball
            Program.slowWrite(" ");
            pokeball.Pokemon.BattleCry(); // Pokemon does its battle cry
            Program.slowWrite(" ");
            return pokeball;
        }

        // Method to return a pokemon back to its pokeball and put the pokeball back on the belt
        public void ReturnPokemon(Pokemon pokemon)
        {
            if (Belt.Count >= 6)
            {
                throw new InvalidOperationException("The belt can only hold six pokeballs.");
            }
            Pokeball pokeball = new Pokeball(30, "red", pokemon, false);
            Belt.Add(pokeball); // Add the pokeball back to the belt
            Program.slowWrite($"{pokemon.Nickname} returned to its pokeball and put back on the belt.");
        }

        // Getter for name
        public string GetName()
        {
            return Name;
        }

        // Getter for belt
        public List<Pokeball> GetBelt()
        {
            return Belt;
        }

        public void ShuffleBelt()
        {
            Random rng = new Random();
            int n = this.Belt.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Pokeball value = this.Belt[k];
                this.Belt[k] = this.Belt[n];
                this.Belt[n] = value;
            }
        }
    }
}
