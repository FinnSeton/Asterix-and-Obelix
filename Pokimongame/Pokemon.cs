using PokemonGame;

public abstract class Pokemon
{
    // Fields for Pokemon's nickname, strength, and weakness
    public string Name { get; set; }
    public string Nickname { get; set; }
    public PokemonType Strength { get; set; }
    public PokemonType Weakness { get; set; }
    public bool HasFainted { get; set; }

    public enum PokemonType
    {
        Fire,
        Grass,
        Water
    }
    
    protected Pokemon(string name, string nickname, PokemonType strength, PokemonType weakness, bool hasFainted)
    {
        this.Name = name;
        this.Nickname = nickname;
        this.Strength = strength;
        this.Weakness = weakness;
        this.HasFainted = hasFainted;
        
        Pokedex.UpdateTrueAmountPokemon();
    }
    
    // Method for Pokémon to perform its battle cry
    public abstract void BattleCry();
}

class Charmander : Pokemon
{
    public Charmander(string nickname, PokemonType strength, PokemonType weakness) 
        : base("Charmander", nickname, strength, weakness, false)
    {
    }

    public override void BattleCry()
    {
        Program.slowWrite($"{Nickname}: Charmander!");
    }
}

class Bulbasaur : Pokemon
{
    public Bulbasaur(string nickname, PokemonType strength, PokemonType weakness) 
        : base("Bulbasaur", nickname, strength, weakness, false)
    {
    }

    public override void BattleCry()
    {
        Program.slowWrite($"{Nickname}: Bulbasaur!");
    }
}

class Squirtle : Pokemon
{
    public Squirtle(string nickname, PokemonType strength, PokemonType weakness) 
        : base("Squirtle", nickname, strength, weakness, false)
    {
    }

    public override void BattleCry()
    {
        Program.slowWrite($"{Nickname}: Squirtle!");
    }
}