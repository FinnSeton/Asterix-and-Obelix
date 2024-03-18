using PokemonGame;

public abstract class Pokemon
{
    // Fields for Pokemon's nickname, strength, and weakness
    public string name { get; set; }
    public string nickname{ get; set; }
    public string strength{ get; set; }
    public string weakness{ get; set; }
    
    public Pokemon(string name, string nickname, string strength, string weakness)
    {
        this.name = name;
        this.nickname = nickname;
        this.strength = strength;
        this.weakness = weakness;
        Pokedex pokedex = new Pokedex();
        Pokedex.UpdateTrueAmountPokemon();
    }
    
    // Method for Pokemon to perform its battle cry
    public abstract void BattleCry();
}
class charmander : Pokemon
{
    // Constructor for charmander class to initialize its fields
    public charmander(string name, string nickname, string strength, string weakness) : base(name,nickname,strength,weakness)
    {
        this.name = "charmander";
        this.nickname = nickname;
        this.strength = "fire";
        this.weakness = "water";
    }

    public override void BattleCry()
    {
        Console.WriteLine($"{nickname}: charmander!");
    }
}
class bulbasaur : Pokemon
{
    // Constructor for bulbasaur class to initialize its fields
    public bulbasaur(string name, string nickname, string strength, string weakness) : base(name,nickname,strength,weakness)
    {
        this.name = "bulbasaur";
        this.nickname = nickname;
        this.strength = "grass";
        this.weakness = "fire";
    }
    public override void BattleCry()
    {
        Console.WriteLine($"{nickname}: bulbasaur!");
    }
}
class squirtle : Pokemon
{
    // Constructor for Squirtle  class to initialize its fields
    public squirtle (string name, string nickname, string strength, string weakness) : base(name,nickname,strength,weakness)
    {
        this.name = "Squirtle";
        this.nickname = nickname;
        this.strength = "water";
        this.weakness = "grass";
    }
    public override void BattleCry()
    {
        Console.WriteLine($"{nickname}: squitle!");
    }
}
