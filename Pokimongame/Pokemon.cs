public abstract class Pokemon
{
    // Fields for Pokemon's nickname, strength, and weakness
    public string name;
    public string nickname;
    public string strength;
    public string weakness;
    
    // Method for Pokemon to perform its battle cry
    public Pokemon()
    {
    }
    public void BattleCry()
    {

        Console.WriteLine($"{nickname}: {name}!");

    }
    //getter for name
    public string GetName()
    {
        return name;
    }
}
class charmander : Pokemon
{
    // Constructor for Pokemon class to initialize its fields
    public charmander(string nickname, string strength, string weakness)
    {
        this.name = "charmander";
        this.nickname = nickname;
        this.strength = strength;
        this.weakness = weakness;
    }
}