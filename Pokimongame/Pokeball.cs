namespace PokemonGame;
    using PokemonGame;

class Pokeball
{
    public int catchrate;
    public string color;
    public Pokemon? pokemon;

    //consructor for the pokeball
    public Pokeball(int catchrate, string color, Pokemon pokemon)
    {
        this.catchrate = catchrate;
        this.color = color;
        this.pokemon = pokemon;
    }
    
    //setter for pokemon
    public void SetPokemon(Pokemon newPokemon)
    {
        pokemon = newPokemon;
    }
    
    //getter for pokemon
    public Pokemon GetPokemon()
    {
        return pokemon;
    }
    
    //method for pokeball being thrown

    public void Throwpokeball()
    {
        Console.WriteLine();
        Console.WriteLine($"{pokemon.nickname}! i choose you!");
    }
}