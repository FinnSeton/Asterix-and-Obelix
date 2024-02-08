using System;

class Pokimon
{
    // Fields for Pokimon's nickname, strength, and weakness
    string nickname;
    string strength;
    string weakness;

    // Constructor for Pokimon class to initialize its fields
    public Pokimon(string nickname, string strength, string weakness)
    {
        this.nickname = nickname;
        this.strength = strength;
        this.weakness = weakness;
    }

    // Method for Pokimon to perform its battle cry
    public void BattleCry()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{nickname}! (Pokimon's battle cry)");
        }
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
            // Ask the player to give a name to Pokimon
            Console.WriteLine("Enter a nickname for your Pokimon:");
            string nickname = Console.ReadLine();

            // Create a Pokimon object with the given nickname
            Pokimon Pokimon = new Pokimon(nickname, "Fire", "Water");

            // Pokimon does its battle cry for ten times
            Pokimon.BattleCry();

            // Ask if the player wants to continue
            Console.WriteLine("Do you want to continue? (yes/no)");
            string input = Console.ReadLine().ToLower();
            if (input != "yes")
                playing = false;
        }
    }
}
