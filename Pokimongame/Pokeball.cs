namespace PokemonGame;
    using PokemonGame;

    public class Pokeball
{
    public int catchrate;
    public string color;
    public Pokemon? pokemon;
    public bool isopen;

    //consructor for the pokeball
    public Pokeball(int catchrate, string color, Pokemon pokemon, bool isopen)
    {
        this.catchrate = catchrate;
        this.color = color;
        this.pokemon = pokemon;
        this.isopen = false;
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
    
    //setter for catchrate
    public void setCatchrate(int newCatchRate)
    {
        catchrate = newCatchRate;
    }
    
    //getter for catchrate
    public int GetCatchrate()
    {
        return catchrate;
    }
    
    //setter for color
    public void setColor(string newColor)
    {
        color = newColor;
    }
    
    //getter for color
    public string GetColor()
    {
        return color;
    }
    
    //method for pokeball being thrown

    public void Throwpokeball()
    {
        this.isopen = true;
        Console.WriteLine($"{pokemon.nickname}! i choose you!");
    }
    
    //method for pokeball being returned
    public void Returnpokeball()
    {
        this.isopen = false;
        Console.WriteLine($"{pokemon.nickname}! come back!");
    }
    
}