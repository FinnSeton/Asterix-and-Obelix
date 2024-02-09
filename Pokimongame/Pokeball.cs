namespace PokimonGame;
    using PokimonGame;

class Pokeball
{
    public Pokemon? pokemon;
    
    //setter for pokemon
    public void SetPokemon(Pokemon NewPokemon)
    {
        pokemon = NewPokemon;
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