public class Pokemon
{
    // Fields for Pokemon's nickname, strength, and weakness
    public string name;
    public string nickname;
    public string strength;
    public string weakness;


    // Constructor for Pokemon class to initialize its fields
    public Pokemon(string name, string nickname, string strength, string weakness)
    {
        this.name = name;
        this.nickname = nickname;
        this.strength = strength;
        this.weakness = weakness;
    }

    // Method for Pokemon to perform its battle cry
    public void BattleCry()
    {

        Console.WriteLine($"{nickname}: {name}!");

    }
    //Getter method for name
    public string GetPokemonName()
    {
        return name;
    }
    
    //setter method for name
    public void SetPokemonName(string newPokemonName)
    {
        name = newPokemonName;
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