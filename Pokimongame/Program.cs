using System;

public class Pokemon
{
    // Fields for Pokemon's nickname, strength, and weakness
    string nickname;
    string strength;
    string weakness;

    // Constructor for Pokemon class to initialize its fields
    public Pokemon(string nickname, string strength, string weakness)
    {
        this.nickname = nickname;
        this.strength = strength;
        this.weakness = weakness;
    }

    // Method for Pokemon to perform its battle cry
    public void BattleCry()
    {

        Console.WriteLine($"{nickname}! (Pokemon's battle cry)");

    }

    // Getter method for nickname
    public string GetName()
    {
        return nickname;
    }

    // Setter method for nickname
    public void SetName(string newName)
    {
        nickname = newName;
    }

    // Getter method for weakness
    public string GetWeakness()
    {
        return weakness;
    }

    // Setter method for weakness
    public void SetWeakness(string newWeakness)
    {
        weakness = newWeakness;
    }

    // Getter method for strength
    public string GetStrength()
    {
        return strength;
    }

    // Setter method for strength
    public void SetStrength(string newStrength)
    {
        strength = newStrength;
    }
}

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
            Pokemon pokemon = new Pokemon(nickname, "Fire", "Water");

            // Pokemon does its battle cry for ten times
            pokemon.BattleCry();

            // Ask if the player wants to continue
            Console.WriteLine("Do you want to continue? (yes/no)");
            string input = Console.ReadLine().ToLower();
            if (input != "yes")
                playing = false;
        }
    }
}
