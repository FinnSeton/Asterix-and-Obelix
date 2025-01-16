using PokemonGame;

public abstract class Pokemon
{
    // Fields for Pokemon's nickname, strength, and weakness
    public string  Name { get; set; }
    public string Nickname{ get; set; }
    public string Strength{ get; set; }
    public string Weakness{ get; set; }
    public  bool HasFainted { get; set; }

    protected enum PokemonType
    {
        Fire,
        Grass,
        Water
    }
    
    protected Pokemon(string name, string nickname, string strength, string weakness, bool HasFainted)
    {
        this.Name = name;
        this.Nickname = nickname;
        this.Strength = strength;
        this.Weakness = weakness;
        this.HasFainted = HasFainted;
        Pokedex pokedex = new Pokedex();
        Pokedex.UpdateTrueAmountPokemon();
        Pokedex.UpdateTrueAmountPokemon();
    }
    
    // Method for Pokémon to perform its battle cry
    public abstract void BattleCry();
}
class Charmander : Pokemon
{
    // Constructor for charmander class to initialize its fields
    public Charmander(string name, string nickname, string strength, string weakness,bool HasFainted) : base(name,nickname,strength,weakness,HasFainted)
    {
        this.Name = "charmander";
        this.Nickname = nickname;
        this.Strength = PokemonType.Fire.ToString();
        this.Weakness = PokemonType.Water.ToString();
        this.HasFainted = false;
    }

    public override void BattleCry()
    {
        Program.slowWrite($"{Nickname}: charmander!");
    }
}
class Bulbasaur : Pokemon
{
    // Constructor for bulbasaur class to initialize its fields
    public Bulbasaur(string name, string nickname, string strength, string weakness,bool HasFainted) : base(name,nickname,strength,weakness,HasFainted)
    {
        this.Name = "bulbasaur";
        this.Nickname = nickname;
        this.Strength = PokemonType.Grass.ToString();
        this.Weakness = PokemonType.Fire.ToString();
        this.HasFainted = false;
    }
    public override void BattleCry()
    {
        Program.slowWrite($"{Nickname}: bulbasaur!");
    }
}
class Squirtle : Pokemon
{
    // Constructor for Squirtle  class to initialize its fields
    public Squirtle (string name, string nickname, string strength, string weakness,bool HasFainted) : base(name,nickname,strength,weakness,HasFainted)
    {
        this.Name = "Squirtle";
        this.Nickname = nickname;
        this.Strength = PokemonType.Water.ToString();
        this.Weakness = PokemonType.Grass.ToString();
        this.HasFainted = false;
    }
    public  override void BattleCry()
    {
        Program.slowWrite($"{Nickname}: squitle!");
    }
}